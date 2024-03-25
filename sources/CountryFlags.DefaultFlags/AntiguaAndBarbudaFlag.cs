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

public class AntiguaAndBarbudaFlag : CountryFlag
{
    public AntiguaAndBarbudaFlag()
    {
        Country = Countries.AntiguaAndBarbuda;

        Description = "A horizontal tri-colour of black, blue (half-width), and white, with two red right scalene triangles on opposite sides. On the black band is a yellow half-sun with nine rays.";
        StartDate = new FlagDate(1967, 02, 27);
        DesignedBy = "Sir Reginald Samuel";
        Usage = FlagUsage.NationalFlag | FlagUsage.CivilEnsign;
    }
}