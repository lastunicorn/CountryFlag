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

namespace DustInTheWind.CountryFlags.DefaultFlags;

public class CocosIslandsFlag : CountryFlag
{
    public CocosIslandsFlag()
    {
        Country = Countries.CocosIslands;

        Description = "Green, with a palm tree on a gold disc in the canton, a gold crescent in the centre of the flag and a gold southern cross in the fly.";
        StartDate = new FlagDate(2004, 04, 06);
        DesignedBy = "Mohammed Minkom";
        Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag;
    }
}