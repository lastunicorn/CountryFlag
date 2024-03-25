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

public class BosniaHerzegovinaFlag : CountryFlag
{
    public BosniaHerzegovinaFlag()
    {
        Country = Countries.BosniaHerzegovina;

        Description = "A medium blue field with a yellow right triangle separating said field; along the hypotenuse of the triangle, there are seven full five-pointed white stars and two half stars at the top and bottom of the flag.";
        StartDate = new FlagDate(1998, 02, 04);
        DesignedBy = "Mladen Kolobaric";
        Usage = FlagUsage.NationalFlag;
        Comments = "The flag was proclaimed by the High Representative Carlos Westendorp";
    }
}