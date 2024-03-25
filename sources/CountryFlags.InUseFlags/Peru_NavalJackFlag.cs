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

public class Peru_NavalJackFlag : CountryFlag
{
    public Peru_NavalJackFlag()
    {
        Country = Countries.Peru;

        Id = "NavalJack";
        Names = new List<FlagName>
        {
            "Naval Jack"
        };
        Description = "A red square with the white square in the center bearing the Coat of Arms (Escudo de Armas) in the center.";
        Usage = FlagUsage.NavalJack;
    }
}