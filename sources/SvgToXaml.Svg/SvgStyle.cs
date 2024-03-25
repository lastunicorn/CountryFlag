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

using System.Collections.ObjectModel;

namespace DustInTheWind.SvgToXaml.Svg;

public class SvgStyle : Collection<SvgStyleItem>
{
    public SvgStyleItem this[string name] => Items.FirstOrDefault(x => x.Name == name);

    public override string ToString()
    {
        return string.Join(";", Items);
    }

    public static implicit operator SvgStyle(string text)
    {
        if (text == null)
            return null;

        SvgStyle svgStyle = new();

        IEnumerable<SvgStyleItem> items = text.Split(';', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
            .Select(x =>
            {
                string[] parts = x.Split(':', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

                if (parts.Length != 2)
                    return null;

                return new SvgStyleItem
                {
                    Name = parts[0],
                    Value = parts[1]
                };
            })
            .Where(x => x != null)!;

        foreach (SvgStyleItem item in items)
            svgStyle.Add(item);

        return svgStyle;
    }
}