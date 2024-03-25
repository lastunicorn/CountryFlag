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

namespace DustInTheWind.CountryFlags.DefaultFlags;

public class GuyanaFlag : CountryFlag
{
    public GuyanaFlag()
    {
        Country = Countries.Guyana;

        Names = new List<FlagName>
        {
            "The Golden Arrowhead"
        };
        Description = "A green field with the black-edged red isosceles triangle based on the hoist-side superimposed on the larger white-edged golden triangle, also based on the hoist-side, pointed toward the fly-side.";
        StartDate = new FlagDate(1966, 05, 26);
        DesignedBy = "Whitney Smith";
        Usage = FlagUsage.NationalFlag;
    }
}