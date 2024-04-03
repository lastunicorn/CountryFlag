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

public class SouthKoreaFlag : CountryFlag
{
    public SouthKoreaFlag()
    {
        Country = Countries.SouthKorea;

        Names = new List<FlagName>
        {
            new()
            {
                NativeName = "태극기"
            },
            new()
            {
                NativeName = "太極旗"
            }
        };
        Description = "A white field with a centered red and blue taegeuk surrounded by four trigrams";
        StartDate = new FlagDate(1883, 01, 27)
        {
            Description = "original version, used by the Joseon dynasty"
        };
        OtherDates = new List<FlagDate>
        {
            new(1942, 06, 29)
            {
                Description = "during Japanese occupation, by the exiled Provisional Government of the Republic of Korea"
            },
            new(1949, 10, 15)
            {
                Description = "for South Korea, by the first Republic of Korea, current geometry"
            },
            new(2011, 05, 30)
            {
                Description = "current colors"
            }
        };
        DesignedBy = new StringList
        {
            "Lee Eung-jun and Ma Jianzhong (Designed)",
            "Park Yung-hyo (Selected)",
            "Gojong (Approved)"
        };
        Usage = FlagUsage.NationalFlagAndEnsign;
    }
}