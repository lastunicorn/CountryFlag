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

namespace DustInTheWind.CountryFlags.OutdatedFlags;

internal static partial class FlagsSetup
{
    public static void Jamaica()
    {
    }

    public static void Japan()
    {
        Countries.Japan.Flags.Add(new CountryFlag
        {
            Id = "ImperialArmy",
            Names = new List<FlagName>
            {
                new()
                {
                    NativeName = "十六条旭日旗",
                    EnglishTranslation = "War flag of the Imperial Japanese Army"
                }
            },
            StartDate = new FlagDate(1868),
            EndDate = new FlagDate(1945),
            Usage = FlagUsage.WarFlag
        });

        Countries.Japan.Flags.Add(new CountryFlag
        {
            Id = "ImperialNavy",
            Names = new List<FlagName>
            {
                new()
                {
                    EnglishTranslation = "Flag of the Imperial Japanese Navy"
                }
            },
            StartDate = new FlagDate(1889),
            EndDate = new FlagDate(1945),
            Usage = FlagUsage.WarEnsign
        });

        Countries.Japan.Flags.Add(new CountryFlag
        {
            Id = "AirRoundel_PreWWII",
            Names = new List<FlagName>
            {
                new()
                {
                    EnglishTranslation = "Military aircraft insignia"
                }
            },
            StartDate = new FlagDate(1943),
            EndDate = new FlagDate(1945),
            Usage = FlagUsage.Other
        });
    }

    public static void Jersey()
    {
    }

    public static void Jordan()
    {
    }
}