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
using System.Globalization;
using DustInTheWind.Flags.SvgToXaml.Svg.Serialization;

namespace DustInTheWind.Flags.SvgToXaml.Svg;

public class SvgElement
{
    public SvgGroup? Parent { get; set; }

    public string? Fill { get; set; }

    public FillRule? FillRule { get; set; }

    public string? Stroke { get; set; }

    public double? StrokeWidth { get; set; }

    public StrokeLineCap? StrokeLineCap { get; set; }

    public StrokeLineJoin? StrokeLineJoin { get; set; }

    public double? StrokeDashOffset { get; set; }

    public double? StrokeMiterLimit { get; set; }

    public SvgStyle? Style { get; set; }

    public SvgTransformList Transforms { get; set; }

    public double? Opacity { get; set; }

    public SvgElement()
    {
    }

    protected internal SvgElement(Element element)
    {
        if (element == null) throw new ArgumentNullException(nameof(element));

        Fill = element.Fill;

        FillRule = element.FillRule == null
            ? null
            : (FillRule)Enum.Parse(typeof(FillRule), element.FillRule, true);

        Stroke = element.Stroke;

        StrokeWidth = element.StrokeWidthSpecified
            ? element.StrokeWidth
            : null;

        StrokeLineJoin = element.StrokeLineJoin == null
            ? null
            : (StrokeLineJoin)Enum.Parse(typeof(StrokeLineJoin), element.StrokeLineJoin, true);

        StrokeLineCap = element.StrokeLineCap == null
            ? null
            : (StrokeLineCap)Enum.Parse(typeof(StrokeLineCap), element.StrokeLineCap, true);

        StrokeDashOffset = element.StrokeDashOffsetSpecified
            ? element.StrokeDashOffset
            : null;

        StrokeMiterLimit = element.StrokeMiterLimitSpecified
            ? element.StrokeMiterLimit
            : null;

        Style = element.Style;

        Transforms = new SvgTransformList();

        if (element.Transform != null)
            Transforms.ParseAndAdd(element.Transform);

        Opacity = element.OpacitySpecified
            ? element.Opacity
            : null;
    }

    public string? CalculateFill()
    {
        SvgStyleItem? styleItem = Style?["fill"];

        if (styleItem != null)
            return styleItem.Value;

        string? value = Fill;

        if (value != null)
            return value;

        return Parent?.CalculateFill();
    }

    public FillRule? CalculateFillRule()
    {
        SvgStyleItem? styleItem = Style?["fill-rule"];

        if (styleItem != null)
            return (FillRule)Enum.Parse(typeof(FillRule), styleItem.Value, true);

        FillRule? value = FillRule;

        if (value != null)
            return value;

        return Parent?.CalculateFillRule();
    }

    public string? CalculateStroke()
    {
        SvgStyleItem? styleItem = Style?["stroke"];

        if (styleItem != null)
            return styleItem.Value;

        string? value = Stroke;

        if (value != null)
            return value;

        return Parent?.CalculateStroke();
    }

    public double? CalculateStrokeWidth()
    {
        SvgStyleItem? styleItem = Style?["stroke-width"];

        if (styleItem != null)
        {
            string valueAsString = styleItem.Value.Trim();

            if (valueAsString.EndsWith("px"))
                valueAsString = valueAsString[..^2];

            return double.Parse(valueAsString, CultureInfo.InvariantCulture);
        }

        double? value = StrokeWidth;

        if (value != null)
            return value;

        return Parent?.CalculateStrokeWidth();
    }

    public StrokeLineCap? CalculateStrokeLineCap()
    {
        SvgStyleItem? styleItem = Style?["stroke-linecap"];

        if (styleItem != null)
            return (StrokeLineCap)Enum.Parse(typeof(StrokeLineCap), styleItem.Value, true);

        StrokeLineCap? value = StrokeLineCap;

        if (value != null)
            return value;

        return Parent?.CalculateStrokeLineCap();
    }

    public StrokeLineJoin? CalculateStrokeLineJoin()
    {
        StrokeLineJoin? value = StrokeLineJoin;

        if (value != null)
            return value;

        return Parent?.CalculateStrokeLineJoin();
    }

    public double? CalculateStrokeDashOffset()
    {
        double? value = StrokeDashOffset;

        if (value != null)
            return value;

        return Parent?.CalculateStrokeDashOffset();
    }

    public double? CalculateStrokeMiterLimit()
    {
        double? value = StrokeMiterLimit;

        if (value != null)
            return value;

        return Parent?.CalculateStrokeMiterLimit();
    }

    public double? CalculateOpacity()
    {
        double? value = Opacity;

        if (value != null)
            return value;

        return Parent?.CalculateOpacity();
    }
}