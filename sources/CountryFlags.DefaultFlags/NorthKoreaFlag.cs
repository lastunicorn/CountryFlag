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

public class NorthKoreaFlag : CountryFlag
{
    public NorthKoreaFlag()
    {
        Country = Countries.NorthKorea;

        Description = "A wide red stripe at the centre, bordered by a narrow white stripe both above and below, followed by a blue stripe. The central red stripe carries a five-pointed red star within a white circle near the hoist.";
        StartDate = new FlagDate(1948, 07, 10)
        {
            Description = "introduced"
        };
        OtherDates = new List<FlagDate>
        {
            new(1948, 09, 08)
            {
                Description = "official"
            }
        };
        DesignedBy = new StringList
        {
            "Kim Il Sung (North Korean official claim)",
            "Kim Tu-bong"
        };
        Usage = FlagUsage.NationalFlagAndEnsign;
    }
}