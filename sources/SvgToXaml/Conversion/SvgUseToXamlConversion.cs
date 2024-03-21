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
using System.Windows;
using DustInTheWind.SvgToXaml.Svg;

namespace DustInTheWind.SvgToXaml.Conversion;

internal class SvgUseToXamlConversion : IConversion<UIElement>
{
    private readonly SvgUse svgUse;

    public SvgUseToXamlConversion(SvgUse svgUse)
    {
        this.svgUse = svgUse ?? throw new ArgumentNullException(nameof(svgUse));
    }

    public UIElement Execute()
    {
        SvgElement? inheritedElement = svgUse.GetInheritedElement();

        IConversion<UIElement> conversion = ConvertChildElement(inheritedElement);
        return conversion.Execute();
    }

    private IConversion<UIElement> ConvertChildElement(SvgElement svgElement)
    {
        switch (svgElement)
        {
            case SvgCircle svgCircle:
                return new SvgCircleToXamlConversion(svgCircle, svgUse);

            case SvgEllipse svgEllipse:
                return new SvgEllipseToXamlConversion(svgEllipse, svgUse);

            case SvgPath svgPath:
                return new SvgPathToXamlConversion(svgPath, svgUse);

            case SvgLine svgLine:
                return new SvgLineToXamlConversion(svgLine, svgUse);

            case SvgRectangle svgRect:
                return new SvgRectangleToXamlConversion(svgRect, svgUse);

            case SvgPolygon svgPolygon:
                return new SvgPolygonToXamlConversion(svgPolygon, svgUse);

            case SvgGroup svgGChild:
                return new SvgGroupToXamlConversion(svgGChild, svgUse);

            default:
                Type inheritedElementType = svgElement.GetType();
                throw new Exception($"Unknown inherited element type: {inheritedElementType.FullName}");
        }
    }
}