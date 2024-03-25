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

public class Poland_NavalEnsignFlag : CountryFlag
{
    public Poland_NavalEnsignFlag()
    {
        Country = Countries.Poland;

        Id = "NavalEnsign";
        Names = new List<FlagName>
        {
            "Naval ensign"
        };
        Description = "A flag consisting of two stripes, white and red, terminated in two triangular tongues on a free leech. In the center of the white strip, in the part between the louvre and the apex of the indentation between the tongues, is the emblem of the Republic of Poland.";
        StartDate = new FlagDate(1993, 02, 19);
        Usage = FlagUsage.WarEnsign;
    }
}