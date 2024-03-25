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

public class TimorLesteFlag : CountryFlag
{
    public TimorLesteFlag()
    {
        Country = Countries.TimorLeste;

        Description = "A red field with the black isosceles triangle based on the hoist-side bearing a white five-pointed star in the center superimposed on the larger yellow triangle, also based on the hoist-side, that extends to the center of the flag.";
        StartDate = new FlagDate(2002, 05, 19);
        Usage = FlagUsage.NationalFlagAndEnsign;
    }
}