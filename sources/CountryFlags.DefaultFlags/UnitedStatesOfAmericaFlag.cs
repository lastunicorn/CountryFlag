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

public class UnitedStatesOfAmericaFlag : CountryFlag
{
    public UnitedStatesOfAmericaFlag()
    {
        Country = Countries.UnitedStatesOfAmerica;

        Names = new List<FlagName>
        {
            "The American flag",
            "The Stars and Stripes Red, White, and Blue",
            "Old Glory",
            "The Star-Spangled Banner",
            "United States (U.S.) flag"
        };
        Description = "Thirteen horizontal stripes alternating red and white; in the canton, 50 white stars of alternating numbers of six and five per horizontal row on a blue field.";
        StartDate = new FlagDate(1960, 07, 04);
        Usage = FlagUsage.NationalFlagAndEnsign;
    }
}