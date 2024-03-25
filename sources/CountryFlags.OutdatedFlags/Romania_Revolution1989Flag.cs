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

namespace DustInTheWind.CountryFlags.OutdatedFlags;

public class Romania_Revolution1989Flag : CountryFlag
{
    public Romania_Revolution1989Flag()
    {
        Country = Countries.Romania;

        Id = "Revolution1989";
        Names = new List<FlagName>
        {
            "Flag of the anti-Ceaușescu protesters during the Romanian Revolution"
        };
        StartDate = new FlagDate(1989, 12, 17);
        EndDate = new FlagDate(1989);
        Comments = "Starting on 17 December 1989, during the revolution at Timișoara, the protesters began waving flags with the Communist coat of arms cut out of the middle. The coat of arms was perceived as a symbol of Nicolae Ceaușescu's dictatorship. These flags were called \"the flag with the hole\" (drapelul cu gaură).";
    }
}