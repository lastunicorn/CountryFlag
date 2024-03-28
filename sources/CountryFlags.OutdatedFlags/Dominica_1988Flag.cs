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

public class Dominica_1988Flag : CountryFlag
{
    public Dominica_1988Flag()
    {
        Country = Countries.Dominica;

        Id = "1988";
        Names = new List<FlagName>
        {
            new()
            {
                EnglishTranslation = "Flag 1988-1990"
            }
        };
        StartDate = new FlagDate(1988);
        EndDate = new FlagDate(1990);
    }
}