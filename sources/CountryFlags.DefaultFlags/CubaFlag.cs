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

public class CubaFlag : CountryFlag
{
    public CubaFlag()
    {
        Country = Countries.Cuba;

        Description = "Five horizontal stripes of blue alternate with white with the red equilateral triangle based on the hoist-side bearing the white five-pointed star in the center.";
        StartDate = new FlagDate(1902, 05, 20);
        DesignedBy = new StringList
        {
            "Miguel Teurbe Tolón",
            "Narciso López"
        };
        Usage = FlagUsage.NationalFlagAndEnsign;
    }
}