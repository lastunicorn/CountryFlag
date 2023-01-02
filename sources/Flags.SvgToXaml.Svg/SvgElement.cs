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
using System.Globalization;
using System.Linq;
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

    public string[]? ClassNames { get; set; }

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

        ClassNames = element.Class?.Split(new[] { ' ' }, StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);

        Transforms = new SvgTransformList();

        if (element.Transform != null)
            Transforms.ParseAndAdd(element.Transform);

        Opacity = element.OpacitySpecified
            ? element.Opacity
            : null;
    }

    private Svg? GetParentSvg()
    {
        SvgGroup? parent = Parent;

        while (parent != null)
        {
            if (parent is Svg svg)
                return svg;

            parent = parent.Parent;
        }

        return null;
    }

    private IEnumerable<SvgStyleClass>? GetApplicableClasses()
    {
        if (ClassNames == null)
            return null;

        Svg? parentSvg = GetParentSvg();
        SvgStyleClasses? svgStyleClasses = parentSvg?.SvgStyleClasses;

        return svgStyleClasses?
            .Where(x => ClassNames.Contains(x.Name))
            .Where(x => x.Value != null)
            .Reverse();
    }

    private string? GetStyleValueFromClasses(string name)
    {
        IEnumerable<SvgStyleClass>? applicableClasses = GetApplicableClasses();

        if (applicableClasses == null) 
            return null;

        foreach (SvgStyleClass svgStyleClass in applicableClasses)
        {
            SvgStyleItem? styleItem1 = svgStyleClass.Value?[name];

            if (styleItem1 != null)
                return styleItem1.Value;
        }

        return null;
    }

    public string? CalculateFill()
    {
        string? rawValue = GetStyleValueFromClasses("fill");

        if (rawValue != null)
            return rawValue;

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
        string? rawValue = GetStyleValueFromClasses("fill-rule");

        if (rawValue != null)
            return (FillRule)Enum.Parse(typeof(FillRule), rawValue, true);

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
        string? rawValue = GetStyleValueFromClasses("stroke");

        if (rawValue != null)
            return rawValue;

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
        string? rawValue = GetStyleValueFromClasses("stroke-width");

        if (rawValue != null)
            return double.Parse(rawValue, CultureInfo.InvariantCulture);

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
        string? rawValue = GetStyleValueFromClasses("stroke-linecap");

        if (rawValue != null)
            return (StrokeLineCap)Enum.Parse(typeof(StrokeLineCap), rawValue, true);

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