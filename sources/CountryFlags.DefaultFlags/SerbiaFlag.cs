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

public class SerbiaFlag : CountryFlag
{
    public SerbiaFlag()
    {
        Country = Countries.Serbia;

        Names = new List<FlagName>
        {
            "State flag"
        };
        Description = "A horizontal tricolour of red, blue, and white; charged with the lesser Coat of arms left of center.";
        StartDate = new FlagDate(2010);
        Usage = FlagUsage.StateFlag | FlagUsage.StateEnsign;
    }
}