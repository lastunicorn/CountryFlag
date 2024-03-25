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

public class ChristmasIslandFlag : CountryFlag
{
    public ChristmasIslandFlag()
    {
        Country = Countries.ChristmasIsland;

        Description = "Blue and green diagonal bicolour charged with a southern cross of four seven-pointed white stars and one smaller five-pointed white star on the blue half, a golden bosun bird in gold on the green half, and a gold circle in the centre containing the shape of the island in green.";
        StartDate = new FlagDate(2002, 02, 26);
        Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag;
    }
}