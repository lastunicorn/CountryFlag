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

public class CaboVerdeFlag : CountryFlag
{
    public CaboVerdeFlag()
    {
        Country = Countries.CaboVerde;

        Description = "Five unequal horizontal bands of blue (six-twelfths), white, red, white (each of the bands are one-twelfth) and blue (three-twelfths) with the circle of ten yellow five-pointed stars centered on the red stripe and positioned three-eighths of the length of the flag from the hoist-side.";
        StartDate = new FlagDate(1992, 09, 22);
        Usage = FlagUsage.NationalFlagAndEnsign;
    }
}