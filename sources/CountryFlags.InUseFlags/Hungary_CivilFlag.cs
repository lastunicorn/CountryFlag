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

public class Hungary_CivilFlag : CountryFlag
{
    public Hungary_CivilFlag()
    {
        Country = Countries.Hungary;

        Id = "Civil";
        Names = new List<FlagName>
        {
            "Civil flag and ensign"
        };
        Description = "A horizontal tricolour of red-white-green.";
        StartDate = new FlagDate(1957, 08, 18);
        Usage = FlagUsage.CivilFlag | FlagUsage.CivilEnsign;
    }
}