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

using System;

namespace DustInTheWind.CountryFlags.InUseFlags;

public class Belgium_NavalEnsignFlag : CountryFlag
{
    public Belgium_NavalEnsignFlag()
    {
        Country = Countries.Belgium;

        Id = "NavalEnsign";
        Description = "A yellow saltire on a white field, bordered above and below in red and to the left and right in black, charged on the top with a crown above crossed cannons and on the bottom by a fouled anchor.";
        StartDate = new DateTime(1950, 02, 23);
        Usage = FlagUsage.WarEnsign;
    }
}