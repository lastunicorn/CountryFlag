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

using System;
using System.Collections.Generic;

namespace DustInTheWind.CountryFlags.InUseFlags;

public class CaribbeanNetherlands_NavalJackFlag : CountryFlag
{
    public CaribbeanNetherlands_NavalJackFlag()
    {
        Country = Countries.CaribbeanNetherlands;

        Id = "NavalJack";
        Names = new List<FlagName>
        {
            "Marine Geus or Prinsengeus"
        };
        Description = "12 segments in the national colors of red (bright vermilion), white, and cobalt blue.";
        StartDate = new DateTime(1931, 04, 20);
        Usage = FlagUsage.NavalJack;
    }
}