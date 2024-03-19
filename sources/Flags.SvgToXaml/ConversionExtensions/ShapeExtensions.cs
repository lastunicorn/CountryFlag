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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using DustInTheWind.SvgToXaml.Svg;

namespace DustInTheWind.SvgToXaml.ConversionExtensions;

internal static class ShapeExtensions
{
    public static void InheritPropertiesFrom(this Shape shape, params SvgElement[] svgElements)
    {
        SetFill(shape, svgElements);
        SetStroke(shape, svgElements);
        SetStrokeThickness(shape, svgElements);
        SetStrokeLineCap(shape, svgElements);
        SetStrokeLineJoin(shape, svgElements);
        SetStrokeDashOffset(shape, svgElements);
        SetStrokeMiterLimit(shape, svgElements);
        SetRenderTransform(shape, svgElements);
        SetOpacity(shape, svgElements);
    }

    private static void SetFill(Shape shape, params SvgElement[] svgElements)
    {
        string? fill = svgElements
            .Select(x => x.CalculateFill())
            .FirstOrDefault(x => x != null);

        if (fill == null)
        {
            shape.Fill = Brushes.Black;
        }
        else
        {
            bool isNone = string.Compare(fill, "none", StringComparison.OrdinalIgnoreCase) == 0;

            shape.Fill = isNone
                ? null
                : (Brush)new BrushConverter().ConvertFrom(fill)!;
        }
    }

    private static void SetStroke(Shape shape, params SvgElement[] svgElements)
    {
        string? stroke = svgElements
            .Select(x => x.CalculateStroke())
            .FirstOrDefault(x => x != null);

        if (stroke != null)
        {
            bool isNone = string.Compare(stroke, "none", StringComparison.OrdinalIgnoreCase) == 0;

            if (!isNone)
                shape.Stroke = (Brush)new BrushConverter().ConvertFrom(stroke)!;
        }
    }

    private static void SetStrokeThickness(Shape shape, params SvgElement[] svgElements)
    {
        double? strokeWidth = svgElements
            .Select(x => x.CalculateStrokeWidth())
            .FirstOrDefault(x => x != null);

        if (strokeWidth != null)
            shape.StrokeThickness = strokeWidth.Value;
    }

    private static void SetStrokeLineCap(Shape shape, params SvgElement[] svgElements)
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

            shape.StrokeStartLineCap = penLineCap;
            shape.StrokeEndLineCap = penLineCap;
        }
    }

    private static void SetStrokeLineJoin(Shape shape, params SvgElement[] svgElements)
    {
        StrokeLineJoin? strokeLineJoin = svgElements
            .Select(x => x.CalculateStrokeLineJoin())
            .FirstOrDefault(x => x != null);

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
    }

    private static void SetStrokeDashOffset(Shape shape, params SvgElement[] svgElements)
    {
        double? strokeDashOffset = svgElements
            .Select(x => x.CalculateStrokeDashOffset())
            .FirstOrDefault(x => x != null);

        if (strokeDashOffset != null)
            shape.StrokeDashOffset = strokeDashOffset.Value;
    }

    private static void SetStrokeMiterLimit(Shape shape, params SvgElement[] svgElements)
    {
        double? strokeMiterLimit = svgElements
            .Select(x => x.CalculateStrokeMiterLimit())
            .FirstOrDefault(x => x != null);

        if (strokeMiterLimit != null)
            shape.StrokeMiterLimit = strokeMiterLimit.Value;
    }

    private static void SetRenderTransform(UIElement shape, params SvgElement[] svgElements)
    {
        //if (svgElement.Transforms.Count > 0)
        //    shape.RenderTransform = svgElement.Transforms.ToXaml();

        List<ISvgTransform> transforms = svgElements
            .Reverse()
            .SelectMany(x => x.Transforms)
            .ToList();

        if (transforms.Any())
            shape.RenderTransform = transforms.ToXaml();
    }

    private static void SetOpacity(Shape shape, params SvgElement[] svgElements)
    {
        double? opacity = svgElements
            .Select(x => x.CalculateOpacity())
            .FirstOrDefault(x => x != null);

        if (opacity != null)
            shape.Opacity = opacity.Value;
    }
}