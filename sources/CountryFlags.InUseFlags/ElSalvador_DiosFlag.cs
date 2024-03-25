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

namespace DustInTheWind.CountryFlags.InUseFlags;

public class ElSalvador_DiosFlag : CountryFlag
{
    public ElSalvador_DiosFlag()
    {
        Country = Countries.ElSalvador;

        Id = "Dios";
        Names = new List<FlagName>
        {
            "Dios Union Libertad"
        };
        Description = "A horizontal triband of white within cobalt blue, the words \"DIOS UNION LIBERTAD\" in bolden golden amber centered and occupying almost the entire length of the white stripe.";
        Usage = FlagUsage.StateFlag | FlagUsage.WarFlag | FlagUsage.CivilEnsign | FlagUsage.StateEnsign;
    }
}