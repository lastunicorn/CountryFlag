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
using System.Windows.Controls;
using DustInTheWind.SvgToXaml.Svg;

namespace DustInTheWind.SvgToXaml.Conversion;

internal class SvgGroupToXamlConversion : IConversion<Canvas>
{
    private readonly SvgGroup svgGroup;
    private readonly SvgUse svgUse;

    public SvgGroupToXamlConversion(SvgGroup svgGroup, SvgUse svgUse = null)
    {
        this.svgGroup = svgGroup ?? throw new ArgumentNullException(nameof(svgGroup));
        this.svgUse = svgUse;
    }

    public Canvas Execute()
    {
        Canvas canvas = new();

        if (svgGroup.Transforms.Count > 0)
            canvas.RenderTransform = svgGroup.Transforms.ToXaml();

        IEnumerable<UIElement> xamlElements = svgGroup.Children
            .Select(ConvertChildElement)
            .Select(x => x.Execute());

        foreach (UIElement uiElement in xamlElements) 
            canvas.Children.Add(uiElement);

        return canvas;
    }

    private static IConversion<UIElement> ConvertChildElement(SvgElement svgElement)
    {
        switch (svgElement)
        {
            case SvgCircle svgCircle:
                return new SvgCircleToXamlConversion(svgCircle);

            case SvgEllipse svgEllipse:
                return new SvgEllipseToXamlConversion(svgEllipse);

            case SvgPath svgPath:
                return new SvgPathToXamlConversion(svgPath);

            case SvgLine svgLine:
                return new SvgLineToXamlConversion(svgLine);

            case SvgRectangle svgRect:
                return new SvgRectangleToXamlConversion(svgRect);

            case SvgPolygon svgPolygon:
                return new SvgPolygonToXamlConversion(svgPolygon);

            case SvgGroup svgGChild:
                return new SvgGroupToXamlConversion(svgGChild);

            case SvgUse svgUse:
                return new SvgUseToXamlConversion(svgUse);

            default:
                Type inheritedElementType = svgElement.GetType();
                throw new Exception($"Unknown inherited element type: {inheritedElementType.FullName}");
        }
    }
}