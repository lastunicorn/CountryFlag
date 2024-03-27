﻿// Country Flags
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

namespace DustInTheWind.CountryFlags.OutdatedFlags;

public class Panama_FirstFlag : CountryFlag
{
    public Panama_FirstFlag()
    {
        Country = Countries.Panama;

        Id = "First";
        Names = new List<FlagName>
        {
            "Original flag"
        };
        Comments = "Original design of the flag, according to Manuel E. Amador.";
        StartDate = new FlagDate(1903, 11, 03);
        EndDate = new FlagDate(1904);
        Usage = FlagUsage.NationalFlagAndEnsign;
    }
}