﻿// Country Flags
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

using System.Linq;
using System.Windows.Controls;
using System.Windows.Shapes;
using DustInTheWind.SvgToXaml.Svg;

namespace DustInTheWind.SvgToXaml.ConversionExtensions;

internal static class SvgCircleExtensions
{
    public static Ellipse ToXaml(this SvgCircle svgCircle, params SvgElement[] svgElements)
    {
        Ellipse ellipse = new()
        {
            Width = svgCircle.Radius * 2,
            Height = svgCircle.Radius * 2
        };

        SvgElement[] svgElementsToInherit = svgElements
            .SafeConcat(svgCircle)
            .ToArray();

        ellipse.InheritPropertiesFrom(svgElementsToInherit);

        double left = svgCircle.CenterX - svgCircle.Radius;
        if (left != 0)
            Canvas.SetLeft(ellipse, left);

        double top = svgCircle.CenterY - svgCircle.Radius;
        if (top != 0)
            Canvas.SetTop(ellipse, top);

        return ellipse;
    }
}