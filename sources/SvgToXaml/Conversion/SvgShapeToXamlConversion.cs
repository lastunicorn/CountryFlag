﻿// Country Flags
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
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;
using System.Windows.Shapes;
using DustInTheWind.SvgToXaml.Svg;

namespace DustInTheWind.SvgToXaml.Conversion;

internal abstract class SvgShapeToXamlConversion<TSvg, TXaml> : SvgElementToXamlConversion<TSvg, TXaml>
    where TSvg : SvgElement
    where TXaml : Shape
{
    protected SvgShapeToXamlConversion(TSvg svgElement, SvgUse? svgUse = null)
        : base(svgElement, svgUse)
    {
    }

    protected override void InheritPropertiesFrom(IEnumerable<SvgElement> svgElements)
    {
        base.InheritPropertiesFrom(svgElements);

        SetFill(svgElements);
        SetStroke(svgElements);
        SetStrokeThickness(svgElements);
        SetStrokeLineCap(svgElements);
        SetStrokeLineJoin(svgElements);
        SetStrokeDashOffset(svgElements);
        SetStrokeMiterLimit(svgElements);
    }

    private void SetFill(IEnumerable<SvgElement> svgElements)
    {
        string? fill = svgElements
            .Select(x => x.CalculateFill())
            .FirstOrDefault(x => x != null);

        if (fill == null)
        {
            XamlElement.Fill = Brushes.Black;
        }
        else
        {
            bool isNone = string.Compare(fill, "none", StringComparison.OrdinalIgnoreCase) == 0;

            XamlElement.Fill = isNone
                ? null
                : (Brush)new BrushConverter().ConvertFrom(fill)!;
        }
    }

    private void SetStroke(IEnumerable<SvgElement> svgElements)
    {
        string? stroke = svgElements
            .Select(x => x.CalculateStroke())
            .FirstOrDefault(x => x != null);

        if (stroke != null)
        {
            bool isNone = string.Compare(stroke, "none", StringComparison.OrdinalIgnoreCase) == 0;

            if (!isNone)
                XamlElement.Stroke = (Brush)new BrushConverter().ConvertFrom(stroke)!;
        }
    }

    private void SetStrokeThickness(IEnumerable<SvgElement> svgElements)
    {
        double? strokeWidth = svgElements
            .Select(x => x.CalculateStrokeWidth())
            .FirstOrDefault(x => x != null);

        if (strokeWidth != null)
            XamlElement.StrokeThickness = strokeWidth.Value;
    }

    private void SetStrokeLineCap(IEnumerable<SvgElement> svgElements)
    {
        StrokeLineCap? strokeLineCap = svgElements
            .Select(x => x.CalculateStrokeLineCap())
            .FirstOrDefault(x => x != null);

        if (strokeLineCap != null)
        {
            PenLineCap penLineCap = strokeLineCap switch
            {
                StrokeLineCap.Butt => PenLineCap.Flat,
                StrokeLineCap.Square => PenLineCap.Square,
                StrokeLineCap.Round => PenLineCap.Round,
                _ => throw new ArgumentOutOfRangeException()
            };

            XamlElement.StrokeStartLineCap = penLineCap;
            XamlElement.StrokeEndLineCap = penLineCap;
        }
    }

    private void SetStrokeLineJoin(IEnumerable<SvgElement> svgElements)
    {
        StrokeLineJoin? strokeLineJoin = svgElements
            .Select(x => x.CalculateStrokeLineJoin())
            .FirstOrDefault(x => x != null);

        if (strokeLineJoin != null)
        {
            XamlElement.StrokeLineJoin = strokeLineJoin switch
            {
                StrokeLineJoin.Miter => PenLineJoin.Miter,
                StrokeLineJoin.Bevel => PenLineJoin.Bevel,
                StrokeLineJoin.Round => PenLineJoin.Round,
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }

    private void SetStrokeDashOffset(IEnumerable<SvgElement> svgElements)
    {
        double? strokeDashOffset = svgElements
            .Select(x => x.CalculateStrokeDashOffset())
            .FirstOrDefault(x => x != null);

        if (strokeDashOffset != null)
            XamlElement.StrokeDashOffset = strokeDashOffset.Value;
    }

    private void SetStrokeMiterLimit(IEnumerable<SvgElement> svgElements)
    {
        double? strokeMiterLimit = svgElements
            .Select(x => x.CalculateStrokeMiterLimit())
            .FirstOrDefault(x => x != null);

        if (strokeMiterLimit != null)
            XamlElement.StrokeMiterLimit = strokeMiterLimit.Value;
    }
}