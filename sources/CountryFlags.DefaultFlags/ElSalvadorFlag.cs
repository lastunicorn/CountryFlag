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

public class ElSalvadorFlag : CountryFlag
{
    public ElSalvadorFlag()
    {
        Country = Countries.ElSalvador;

        Names = new List<FlagName>
        {
            new()
            {
                NativeName = "Bandera Magna",
                EnglishTranslation = "Magna flag"
            }
        };
        Description = "A horizontal triband of cobalt blue (top and bottom) and white with the National Coat of Arms in the center and occupying the entire hight of the white stripe with its top touching the upper blue strip and its base touching the lower blue stripe.";
        StartDate = new FlagDate(1912, 05, 27);
        Usage = FlagUsage.StateFlag | FlagUsage.WarFlag | FlagUsage.WarEnsign;
    }
}