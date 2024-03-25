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

public class Bolivia_WiphalaFlag : CountryFlag
{
    public Bolivia_WiphalaFlag()
    {
        Country = Countries.Bolivia;

        Id = "Wiphala";
        Names = new List<FlagName>
        {
            "Wiphala",
            "Dual flag"
        };
        Description = "Banner composed of a 7-by-7 square patchwork in seven colours, arranged diagonally.";
        StartDate = new DateTime(2009, 02, 07);
        Usage = FlagUsage.NationalFlag;
    }
}