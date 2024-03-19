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
using System.Windows.Controls;
using System.Windows.Shapes;
using DustInTheWind.SvgToXaml.Svg;

namespace DustInTheWind.SvgToXaml.ConversionExtensions;

internal static class SvgUseExtensions
{
    public static UIElement ToXaml(this SvgUse svgUse)
    {
        if (svgUse == null) throw new ArgumentNullException(nameof(svgUse));

        Svg.Svg? svg =  svgUse.GetParentSvg();

        

        if (svg != null)
        {
            if (svgUse.Href != null && svgUse.Href.StartsWith("#"))
            {
                string id = svgUse.Href[1..];

                SvgElement? svgElement = svg.FindChild(id);

                if (svgElement is SvgCircle svgCircle)
                {
                    Ellipse ellipse = svgCircle.ToXaml(svgUse);
                    return ellipse;
                }
                
                if (svgElement is SvgEllipse svgEllipse)
                {
                    Ellipse ellipse = svgEllipse.ToXaml(svgUse);
                    return ellipse;
                }
                
                if (svgElement is SvgPath svgPath)
                {
                    Path xamlPath = svgPath.ToXaml(svgUse);
                    return xamlPath;
                }
                
                if (svgElement is SvgLine svgLine)
                {
                    Line xamlLine = svgLine.ToXaml(svgUse);
                    return xamlLine;
                }
                
                if (svgElement is SvgRectangle svgRect)
                {
                    Rectangle xamlRectangle = svgRect.ToXaml(svgUse);
                    return xamlRectangle;
                }
                
                if (svgElement is SvgPolygon svgPolygon)
                {
                    Polygon xamlPolygon = svgPolygon.ToXaml(svgUse);
                    return xamlPolygon;
                }
                
                if (svgElement is SvgGroup svgGChild)
                {
                    Canvas? xamlCanvas = svgGChild.ToXaml();

                    if (xamlCanvas != null)
                        return xamlCanvas;
                }
            }
        }

        return new UIElement();
    }
}