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

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.RegularExpressions;

namespace DustInTheWind.SvgToXaml.Svg;

public class CssClassCollection : Collection<CssClass>
{
    public CssClass this[string name] => Items.FirstOrDefault(x => x.Name == name);

    public static implicit operator CssClassCollection(string text)
    {
        if (text == null)
            return null;

        Regex regex = new(@"\.(\w+)\s*{\s*(.*?)\s*}", RegexOptions.Multiline);

        MatchCollection matches = regex.Matches(text);

        IEnumerable<CssClass> items = matches
            .Select(x => new CssClass
            {
                Name = x.Groups[1].Value,
                Value = x.Groups[2].Value
            });

        CssClassCollection cssClasses = new();

        foreach (CssClass item in items)
            cssClasses.Add(item);

        return cssClasses;
    }
}