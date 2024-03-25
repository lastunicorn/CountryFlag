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

public class Australia_NavalEnsignFlag : CountryFlag
{
    public Australia_NavalEnsignFlag()
    {
        Country = Countries.Australia;

        Id = "NavalEnsign";
        Names = new List<FlagName>
        {
            "Royal Australian Navy Ensign"
        };
        Description = "A defaced British White Ensign without the cross. The cross is replaced with the Southern Cross and the Commonwealth Star/Federation Star.";
        StartDate = new FlagDate(1967);
        Usage = FlagUsage.CivilEnsign;
    }
}