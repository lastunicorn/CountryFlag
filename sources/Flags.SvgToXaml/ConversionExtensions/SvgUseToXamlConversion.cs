// Country Flags
// Copyright (C) 2022-2023 Dust in the Wind
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

namespace DustInTheWind.SvgToXaml.ConversionExtensions;

internal class SvgUseToXamlConversion
{
    private readonly SvgUse svgUse;

    public SvgUseToXamlConversion(SvgUse svgUse)
    {
        this.svgUse = svgUse ?? throw new ArgumentNullException(nameof(svgUse));
    }

    public UIElement Execute()
    {
        SvgElement? inheritedElement = svgUse.GetInheritedElement();

        if (inheritedElement is SvgCircle svgCircle)
        {
            SvgCircleToXamlConversion conversion = new(svgCircle, svgUse);
            return conversion.Execute();
        }

        if (inheritedElement is SvgEllipse svgEllipse)
        {
            SvgEllipseToXamlConversion conversion = new(svgEllipse, svgUse);
            return conversion.Execute();
        }

        if (inheritedElement is SvgPath svgPath)
        {
            SvgPathToXamlConversion conversion = new(svgPath, svgUse);
            return conversion.Execute();
        }

        if (inheritedElement is SvgLine svgLine)
        {
            SvgLineToXamlConversion conversion = new(svgLine, svgUse);
            return conversion.Execute();
        }

        if (inheritedElement is SvgRectangle svgRectangle)
        {
            SvgRectangleToXamlConversion conversion = new(svgRectangle, svgUse);
            return conversion.Execute();
        }

        if (inheritedElement is SvgPolygon svgPolygon)
        {
            SvgPolygonToXamlConversion conversion = new(svgPolygon, svgUse);
            return conversion.Execute();
        }

        if (inheritedElement is SvgGroup svgGroup)
        {
            SvgGroupToXamlConversion conversion = new(svgGroup, svgUse);
            return conversion.Execute();
        }

        Type inheritedElementType = inheritedElement.GetType();
        throw new Exception($"Unknown inherited element type: {inheritedElementType.FullName}");
    }
}