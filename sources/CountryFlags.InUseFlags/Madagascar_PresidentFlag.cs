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

public class Madagascar_PresidentFlag : CountryFlag
{
    public Madagascar_PresidentFlag()
    {
        Country = Countries.Madagascar;

        Id = "President";
        Names = new List<FlagName>
        {
            new()
            {
                EnglishTranslation = "Presidential standard"
            }
        };
        Description = "The National flag with the Seal of Madagascar in the center of the tri-point with the initials \"R. M.\" in the canton.";
        Usage = FlagUsage.LeaderFlag;
    }
}