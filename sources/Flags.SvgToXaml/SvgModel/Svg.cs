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

using System.Text;
using System.Xml.Serialization;

namespace Flags.SvgToXaml.SvgModel;

[XmlRoot("svg", Namespace = "http://www.w3.org/2000/svg")]
public class Svg
{
    [XmlAttribute("width")]
    public int Width { get; set; }

    [XmlAttribute("height")]
    public int Height { get; set; }

    [XmlElement("circle", typeof(SvgCircle))]
    [XmlElement("ellipse", typeof(SvgEllipse))]
    [XmlElement("path", typeof(SvgPath))]
    [XmlElement("rect", typeof(SvgRect))]
    public object[]? Elements { get; set; }
}