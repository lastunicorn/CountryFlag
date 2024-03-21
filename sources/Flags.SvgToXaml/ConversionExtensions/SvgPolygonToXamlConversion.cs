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
using System.Windows.Shapes;
using DustInTheWind.SvgToXaml.Svg;
using FillRule = System.Windows.Media.FillRule;

namespace DustInTheWind.SvgToXaml.ConversionExtensions;

internal class SvgPolygonToXamlConversion : SvgShapeToXamlConversion<SvgPolygon, Polygon>
{
    public SvgPolygonToXamlConversion(SvgPolygon svgPolygon, SvgUse? svgUse = null)
        : base(svgPolygon, svgUse)
    {
    }

    protected override Polygon CreateXamlElement()
    {
        Polygon polygon = new()
        {
            Points = SvgElement.Points.ToXaml()
        };

        SetFillRule(polygon, SvgElement);

        return polygon;
    }

    private static void SetFillRule(Polygon polygon, SvgPolygon svgPolygon)
    {
        Svg.FillRule? fillRule = svgPolygon.CalculateFillRule();

        if (fillRule != null)
        {
            polygon.FillRule = fillRule switch
            {
                Svg.FillRule.EvenOdd => FillRule.EvenOdd,
                Svg.FillRule.Nonzero => FillRule.Nonzero,
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }
}