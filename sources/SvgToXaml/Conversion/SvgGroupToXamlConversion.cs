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
using System.Windows.Controls;
using System.Windows.Shapes;
using DustInTheWind.SvgToXaml.Svg;

namespace DustInTheWind.SvgToXaml.Conversion;

internal class SvgGroupToXamlConversion
{
    private readonly SvgGroup svgGroup;
    private readonly SvgUse? svgUse;

    public SvgGroupToXamlConversion(SvgGroup svgGroup, SvgUse? svgUse = null)
    {
        this.svgGroup = svgGroup ?? throw new ArgumentNullException(nameof(svgGroup));
        this.svgUse = svgUse;
    }

    public Canvas Execute()
    {
        Canvas canvas = new();

        if (svgGroup.Transforms.Count > 0)
            canvas.RenderTransform = svgGroup.Transforms.ToXaml();

        foreach (SvgElement svgElement in svgGroup.Children)
        {
            if (svgElement is SvgCircle svgCircle)
            {
                SvgCircleToXamlConversion conversion = new(svgCircle);
                Ellipse ellipse = conversion.Execute();
                canvas.Children.Add(ellipse);
            }
            else if (svgElement is SvgEllipse svgEllipse)
            {
                SvgEllipseToXamlConversion conversion = new(svgEllipse);
                Ellipse ellipse = conversion.Execute();
                canvas.Children.Add(ellipse);
            }
            else if (svgElement is SvgPath svgPath)
            {
                SvgPathToXamlConversion conversion = new(svgPath);
                Path xamlPath = conversion.Execute();
                canvas.Children.Add(xamlPath);
            }
            else if (svgElement is SvgLine svgLine)
            {
                SvgLineToXamlConversion conversion = new(svgLine);
                Line xamlLine = conversion.Execute();
                canvas.Children.Add(xamlLine);
            }
            else if (svgElement is SvgRectangle svgRect)
            {
                SvgRectangleToXamlConversion conversion = new(svgRect);
                Rectangle xamlRectangle = conversion.Execute();
                canvas.Children.Add(xamlRectangle);
            }
            else if (svgElement is SvgPolygon svgPolygon)
            {
                SvgPolygonToXamlConversion conversion = new(svgPolygon);
                Polygon xamlPolygon = conversion.Execute();
                canvas.Children.Add(xamlPolygon);
            }
            else if (svgElement is SvgGroup svgGChild)
            {
                SvgGroupToXamlConversion conversion = new(svgGChild);
                Canvas xamlCanvas = conversion.Execute();
                canvas.Children.Add(xamlCanvas);
            }
            else if (svgElement is SvgUse svgUse)
            {
                SvgUseToXamlConversion conversion = new(svgUse);
                UIElement uiElement = conversion.Execute();
                canvas.Children.Add(uiElement);
            }
        }

        return canvas;
    }
}