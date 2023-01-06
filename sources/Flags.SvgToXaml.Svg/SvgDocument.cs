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
using System.IO;
using System.Xml.Serialization;

namespace DustInTheWind.SvgToXaml.Svg;

public class SvgDocument
{
    public Svg? Svg { get; set; }

    public static SvgDocument Parse(string svg)
    {
        XmlSerializer xmlSerializer = new(typeof(Serialization.Svg));

        using StringReader sr = new(svg);
        object? deserializedObject = xmlSerializer.Deserialize(sr);

        if (deserializedObject is Serialization.Svg svgObject)
        {
            return new SvgDocument
            {
                Svg = new Svg(svgObject)
            };
        }

        throw new ArgumentException("The value is not a valid svg document.", nameof(svg));
    }
}