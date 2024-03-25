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

public class UnitedStatesVirginIslandsFlag : CountryFlag
{
    public UnitedStatesVirginIslandsFlag()
    {
        Country = Countries.UnitedStatesVirginIslands;

        Description = "A simplified version of the coat of arms of the United States between the letters V and I (for Virgin Islands). The yellow-colored eagle holds a sprig of laurel in one talon, and three arrows in the other. The blue color in the shield on the eagle's breast is the same color as that of the flag and shield of the United States.";
        StartDate = new FlagDate(1921, 05, 17);
        Usage = FlagUsage.CivilAndStateFlag;
    }
}