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

using System;
using System.Windows.Media;
using System.Windows.Shapes;
using DustInTheWind.Flags.SvgToXaml.Svg;

namespace DustInTheWind.Flags.SvgToXaml.ConversionExtensions;

internal static class ShapeExtensions
{
    public static void UpdateFrom(this Shape shape, SvgElement svgElement)
    {
        string? fill = svgElement.CalculateFill();

        if (fill == null)
        {
            shape.Fill = Brushes.Black;
        }
        else
        {
            bool isNone = string.Compare(fill, "none", StringComparison.OrdinalIgnoreCase) == 0;

            if (!isNone)
                shape.Fill = (Brush)new BrushConverter().ConvertFrom(fill)!;
        }

        string? stroke = svgElement.CalculateStroke();
        if (stroke != null)
        {
            bool isNone = string.Compare(stroke, "none", StringComparison.OrdinalIgnoreCase) == 0;

            if (!isNone)
                shape.Stroke = (Brush)new BrushConverter().ConvertFrom(stroke)!;
        }

        double? strokeWidth = svgElement.CalculateStrokeWidth();
        if (strokeWidth != null)
            shape.StrokeThickness = strokeWidth.Value;

        StrokeLineCap? strokeLineCap = svgElement.CalculateStrokeLineCap();
        if (strokeLineCap != null)
        {
            PenLineCap penLineCap = strokeLineCap switch
            {
                StrokeLineCap.Flat => PenLineCap.Flat,
                StrokeLineCap.Square => PenLineCap.Square,
                StrokeLineCap.Round => PenLineCap.Round,
                StrokeLineCap.Triangle => PenLineCap.Triangle,
                _ => throw new ArgumentOutOfRangeException()
            };

            shape.StrokeStartLineCap = penLineCap;
            shape.StrokeEndLineCap = penLineCap;
        }

        StrokeLineJoin? strokeLineJoin = svgElement.CalculateStrokeLineJoin();
        if (strokeLineJoin != null)
        {
            shape.StrokeLineJoin = strokeLineJoin switch
            {
                StrokeLineJoin.Miter => PenLineJoin.Miter,
                StrokeLineJoin.Bevel => PenLineJoin.Bevel,
                StrokeLineJoin.Round => PenLineJoin.Round,
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        double? strokeDashOffset = svgElement.CalculateStrokeDashOffset();
        if (strokeDashOffset != null)
            shape.StrokeDashOffset = strokeDashOffset.Value;

        double? strokeMiterLimit = svgElement.CalculateStrokeMiterLimit();
        if (strokeMiterLimit != null)
            shape.StrokeMiterLimit = strokeMiterLimit.Value;

        if (svgElement.Transforms.Count > 0)
            shape.RenderTransform = svgElement.Transforms.ToXaml();
    }
}