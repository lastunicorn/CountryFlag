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

public class Paraguay_ReverseSideFlag : CountryFlag
{
    public Paraguay_ReverseSideFlag()
    {
        Country = Countries.Paraguay;

        Id = "ReverseSide";
        Names = new List<FlagName>
        {
            "Reverse side"
        };
        Description = "A horizontal triband of red, white and blue, defaced on the reverse with the reversed coat of arms of Paraguay.";
        StartDate = new FlagDate(2013, 07, 15);
        Usage = FlagUsage.NationalFlagAndEnsign;
    }
}