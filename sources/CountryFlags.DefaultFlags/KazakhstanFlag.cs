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

public class KazakhstanFlag : CountryFlag
{
    public KazakhstanFlag()
    {
        Country = Countries.Kazakhstan;

        Description = "A gold sun with 32 rays above a soaring golden steppe eagle, both centered on a turquoise field. The hoist side displays a national ornamental pattern \"qoşqar-müiız\"";
        StartDate = new FlagDate(1992, 07, 04);
        DesignedBy = "Shaken Niyazbekov";
        Usage = FlagUsage.NationalFlag | FlagUsage.CivilEnsign;
    }
}