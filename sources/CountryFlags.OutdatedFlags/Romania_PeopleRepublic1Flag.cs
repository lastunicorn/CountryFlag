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

public class Romania_PeopleRepublic1Flag : CountryFlag
{
    public Romania_PeopleRepublic1Flag()
    {
        Country = Countries.Romania;

        Id = "PeopleRepublic1";
        Label = "Romanian People's Republic (1948)";
        StartDate = new FlagDate(1948);
        EndDate = new FlagDate(1948);
    }
}