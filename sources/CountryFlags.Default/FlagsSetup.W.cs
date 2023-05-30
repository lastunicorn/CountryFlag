// Country Flags
// Copyright (C) 2022 Dust in the Wind
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

namespace DustInTheWind.CountryFlags.Main;

public static partial class FlagsSetup
{
    public static void WallisAndFutuna()
    {
        Countries.WallisAndFutuna.Flags.Add(new CountryFlag
        {
            Names = new List<FlagName>
            {
                "Tricolore"
            },
            Description = "A vertical tricolour of blue, white, and red.",
            StartDate = new FlagDate(1794, 02, 15),
            Usage = FlagUsage.NationalFlag | FlagUsage.CivilAndStateEnsign
        });
    }

    public static void WesternSahara()
    {
        Countries.WesternSahara.Flags.Add(new CountryFlag
        {
            Description = "A black, white, and green horizontal tricolor charged with a red star and crescent in the centre stripe and a red chevron at the hoist.",
            StartDate = new FlagDate(1976, 02, 27),
            DesignedBy = "El Uali Mustafá Sayed",
            Usage = FlagUsage.NationalFlag
        });
    }
}