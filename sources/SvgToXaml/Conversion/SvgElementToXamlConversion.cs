// Country Flags
// Copyright (C) 2022-2024 Dust in the Wind
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using DustInTheWind.SvgToXaml.Svg;

namespace DustInTheWind.SvgToXaml.Conversion;

internal abstract class SvgElementToXamlConversion<TSvg, TXaml> : IConversion<TXaml>
    where TSvg : SvgElement
    where TXaml : UIElement
{
    private readonly SvgUse svgUse;

    protected TSvg SvgElement { get; }

    protected TXaml XamlElement { get; private set; }

    protected SvgElementToXamlConversion(TSvg svgElement, SvgUse svgUse = null)
    {
        this.svgUse = svgUse;
        SvgElement = svgElement ?? throw new ArgumentNullException(nameof(svgElement));
    }

    public TXaml Execute()
    {
        XamlElement = CreateXamlElement();
        
        if (SvgElement.Transforms.Count > 0)
            XamlElement.RenderTransform = SvgElement.Transforms.ToXaml();

        List<SvgElement> inheritedSvgElements = EnumerateInheritedElements().ToList();

        InheritPropertiesFrom(inheritedSvgElements);

        return XamlElement;
    }

    protected abstract TXaml CreateXamlElement();

    protected virtual IEnumerable<SvgElement> EnumerateInheritedElements()
    {
        if (svgUse == null)
        {
            yield return SvgElement;

            List<SvgElement> ancestors = SvgElement.EnumerateAncestors().ToList();

            foreach (SvgElement ancestor in ancestors)
                yield return ancestor;
        }
        else
        {
            yield return svgUse;
            yield return SvgElement;

            List<SvgElement> ancestors = svgUse.EnumerateAncestors().ToList();

            foreach (SvgElement ancestor in ancestors)
                yield return ancestor;
        }
    }

    protected virtual void InheritPropertiesFrom(IEnumerable<SvgElement> svgElements)
    {
        SetOpacity(svgElements);
    }

    private void SetOpacity(IEnumerable<SvgElement> svgElements)
    {
        double? opacity = svgElements
            .Select(x => x.CalculateOpacity())
            .FirstOrDefault(x => x != null);

        if (opacity != null)
            XamlElement.Opacity = opacity.Value;
    }
}