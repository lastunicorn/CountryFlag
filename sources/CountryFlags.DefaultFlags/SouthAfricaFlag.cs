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

public class SouthAfricaFlag : CountryFlag
{
    public SouthAfricaFlag()
    {
        Country = Countries.SouthAfrica;

        Description = "A horizontal bicolour of red and blue with a black isosceles triangle based on the hoist-side and a green pall, a central green band that splits into a horizontal Y, centred over the partition lines and was edged in both white against the red and the blue bands and yellow against the triangle, in which the arms of the Y ends at the corners of the hoist and embraces the triangle on the hoist-side.";
        StartDate = new FlagDate(1994, 04, 27);
        DesignedBy = "Frederick Brownell";
        Usage = FlagUsage.CivilAndStateFlag | FlagUsage.CivilAndStateEnsign;
    }
}