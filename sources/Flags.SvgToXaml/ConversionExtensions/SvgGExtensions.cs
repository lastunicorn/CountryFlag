// Country Flags
// Copyright (C) 2022 Dust in the Wind
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

using System.Windows.Controls;
using System.Windows.Shapes;
using DustInTheWind.Flags.SvgToXaml.Svg;

namespace DustInTheWind.Flags.SvgToXaml.ConversionExtensions;

internal static class SvgGExtensions
{
    public static Canvas? ToXaml(this SvgGroup? svgGroup)
    {
        if (svgGroup == null)
            return null;

        Canvas canvas = new();

        if (svgGroup.Transforms.Count > 0) 
            canvas.RenderTransform = svgGroup.Transforms.ToXaml();

        foreach (SvgElement svgElement in svgGroup.Children)
        {
            if (svgElement is SvgCircle svgCircle)
            {
                Ellipse ellipse = svgCircle.ToXaml();
                canvas.Children.Add(ellipse);
            }
            else if (svgElement is SvgEllipse svgEllipse)
            {
                Ellipse ellipse = svgEllipse.ToXaml();
                canvas.Children.Add(ellipse);
            }
            else if (svgElement is SvgPath svgPath)
            {
                Path xamlPath = svgPath.ToXaml();
                canvas.Children.Add(xamlPath);
            }
            else if (svgElement is SvgRectangle svgRect)
            {
                Rectangle xamlRectangle = svgRect.ToXaml();
                canvas.Children.Add(xamlRectangle);
            }
            else if (svgElement is SvgPolygon svgPolygon)
            {
                Polygon xamlPolygon = svgPolygon.ToXaml();
                canvas.Children.Add(xamlPolygon);
            }
            else if (svgElement is SvgGroup svgGChild)
            {
                Canvas? xamlCanvas = svgGChild.ToXaml();

                if (xamlCanvas != null)
                    canvas.Children.Add(xamlCanvas);
            }
        }

        return canvas;
    }
}