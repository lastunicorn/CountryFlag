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

namespace DustInTheWind.CountryFlags.DefaultFlags;

public class EritreaFlag : CountryFlag
{
    public EritreaFlag()
    {
        Country = Countries.Eritrea;

        Names = new List<FlagName>
        {
            new()
            {
                NativeName = "ሃገራዊት ባንዴራ ኤርትራ",
                EnglishTranslation = "flag of Eritrea"
            },
            new()
            {
                NativeName = "علم إريتريا الوطني",
                EnglishTranslation = "flag of Eritrea"
            }
        };
        Description = "A red isosceles triangle based on the hoist-side pointed toward the fly-side and then divided into two right triangles: the upper triangle is green and the lower triangle is blue with an Emblem (1952-1995) in gold (a vertical olive branch encircled by an olive wreath) centered on the hoist side of the triangle.";
        StartDate = new FlagDate(1995, 12, 05);
        Usage = FlagUsage.NationalFlagAndEnsign;
    }
}