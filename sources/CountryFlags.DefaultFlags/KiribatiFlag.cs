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

public class KiribatiFlag : CountryFlag
{
    public KiribatiFlag()
    {
        Country = Countries.Kiribati;

        Description = "A horizontal bicolour of red and blue with the yellow frigate bird flying over the rising sun with seventeen rays centered on the upper half and three white wavy horizontal stripes on the lower half.";
        StartDate = new FlagDate(1979, 07, 12);
        DesignedBy = "Arthur Grimble";
        Usage = FlagUsage.NationalFlagAndEnsign;
    }
}