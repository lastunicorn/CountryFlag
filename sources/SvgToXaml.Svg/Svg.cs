// Country Flags
// Copyright (C) 2022-2024 Dust in the Wind
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

namespace DustInTheWind.SvgToXaml.Svg;

public class Svg : SvgGroup
{
    public Size? Width { get; set; }

    public Size? Height { get; set; }

    public SvgViewBox? ViewBox { get; set; }

    public SvgStyleClasses? SvgStyleClasses { get; set; }

    public SvgDefinitions? SvgDefinitions { get; set; }

    public Svg()
    {
    }

    internal Svg(Serialization.Svg svg)
        : base(svg)
    {
        if (svg == null) throw new ArgumentNullException(nameof(svg));

        if (svg.Width != null)
            Width = svg.Width;

        if (svg.Height != null)
            Height = svg.Height;

        if (svg.ViewBox != null)
            ViewBox = SvgViewBox.Parse(svg.ViewBox);

        if (svg.StyleElement != null)
            SvgStyleClasses = svg.StyleElement;

        if (svg.Defs != null)
            SvgDefinitions = new SvgDefinitions(svg.Defs);
    }

    public override SvgElement? FindChild(string? id)
    {
        return SvgDefinitions?.FindChild(id) ?? base.FindChild(id);
    }
}