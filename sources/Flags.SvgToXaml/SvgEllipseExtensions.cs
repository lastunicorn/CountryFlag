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
using Flags.SvgToXaml.SvgModel;

namespace Flags.SvgToXaml;

internal static class SvgEllipseExtensions
{
    public static Ellipse ToXaml(this SvgEllipse svgEllipse)
    {
        Ellipse ellipse = new()
        {
            Width = svgEllipse.Rx * 2,
            Height = svgEllipse.Ry * 2
        };

        ellipse.UpdateFrom(svgEllipse);

        float left = svgEllipse.Cx - svgEllipse.Rx;
        if (left != 0)
            Canvas.SetLeft(ellipse, left);

        float top = svgEllipse.Cy - svgEllipse.Ry;
        if (top != 0)
            Canvas.SetTop(ellipse, top);

        return ellipse;
    }
}