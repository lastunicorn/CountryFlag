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

public class GrenadaFlag : CountryFlag
{
    public GrenadaFlag()
    {
        Country = Countries.Grenada;

        Description = "A rectangle divided diagonally into two yellow triangles at the top and bottom and two green triangles at the hoist and fly, surrounded by a red border charged with six five pointed yellow stars, another five-pointed yellow star on a red disc at the centre, and a nutmeg at the hoist.";
        StartDate = new FlagDate(1974, 02, 07);
        DesignedBy = "Anthony C. George";
        Usage = FlagUsage.NationalFlag;
    }
}