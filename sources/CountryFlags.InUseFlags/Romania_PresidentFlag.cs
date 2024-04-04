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

namespace DustInTheWind.CountryFlags.InUseFlags;

public class Romania_PresidentFlag : CountryFlag
{
    public Romania_PresidentFlag()
    {
        Country = Countries.Romania;

        Id = "President";
        Names = new List<FlagName>
        {
            new()
            {
                EnglishTranslation = "President's Flag"
            }
        };
        Usage = FlagUsage.LeaderFlag;
    }
}