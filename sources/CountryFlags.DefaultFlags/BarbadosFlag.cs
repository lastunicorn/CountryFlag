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

public class BarbadosFlag : CountryFlag
{
    public BarbadosFlag()
    {
        Country = Countries.Barbados;

        Names = new List<FlagName>
        {
            "The Broken Trident"
        };
        Description = "A vertical triband of ultramarine (hoist-side and fly-side) and gold with the black trident-head centred on the gold band.";
        StartDate = new FlagDate(1966, 11, 30);
        DesignedBy = "Grantley W. Prescod";
        Usage = FlagUsage.NationalFlag | FlagUsage.CivilEnsign | FlagUsage.StateEnsign;
    }
}