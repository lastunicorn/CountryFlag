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

public class TaiwanFlag : CountryFlag
{
    public TaiwanFlag()
    {
        Country = Countries.Taiwan;

        Names = new List<FlagName>
        {
            new()
            {
                NativeName = "青天白日滿地紅",
                EnglishTranslation = "Blue Sky, White Sun, and a Wholly Red Earth"
            }
        };
        Description = "A red field with a navy blue canton bearing a white sun with 12 triangular rays";
        StartDate = new FlagDate(1895)
        {
            Description = "by Revive China Society, original version"
        };
        OtherDates = new List<FlagDate>
        {
            new(1906)
            {
                Description = "addition of the red field"
            },
            new(1912, 01, 01)
            {
                Description = "naval flag"
            },
            new(1921, 05, 05)
            {
                Description = "by Guangzhou government"
            },
            new(1928, 12, 09)
            {
                Description = "in mainland China"
            },
            new(1945, 10, 25)
            {
                Description = "in Taiwan"
            },
            new(1949, 10, 01)
            {
                Description = "Relinquished in mainland China"
            },
            new(1950, 05, 01)
            {
                Description = "Relinquished in Hainan"
            }
        };
        DesignedBy = new StringList
        {
            "Lu Haodong (The canton of the flag)",
            "Sun Yat-sen (The full layout)"
        };
        Usage = FlagUsage.CivilAndStateFlag | FlagUsage.NationalEnsign;
    }
}