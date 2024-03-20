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

namespace DustInTheWind.CountryFlags.InUseFlags;

internal static partial class FlagsSetup
{
    public static void Jamaica()
    {
    }

    public static void Japan()
    {
        Countries.Japan.Flags.Add(new CountryFlag
        {
            Id = "GroundForces",
            Names = new List<FlagName>
            {
                new()
                {
                    NativeName = "八条旭日旗",
                    EnglishTranslation = "Ground Self-Defense Force"
                }
            },
            StartDate = new FlagDate(1954),
            Usage = FlagUsage.WarFlag
        });

        Countries.Japan.Flags.Add(new CountryFlag
        {
            Id = "MaritimeForces",
            Names = new List<FlagName>
            {
                new()
                {
                    NativeName = "十六条旭日旗",
                    EnglishTranslation = "Maritime Self-Defense Force"
                }
            },
            StartDate = new FlagDate(1954),
            Usage = FlagUsage.WarEnsign
        });

        Countries.Japan.Flags.Add(new CountryFlag
        {
            Id = "AirForces",
            Names = new List<FlagName>
            {
                new()
                {
                    EnglishTranslation = "Air Self-Defense Force"
                }
            },
            StartDate = new FlagDate(1954),
            Usage = FlagUsage.AirForceEnsign
        });

        Countries.Japan.Flags.Add(new CountryFlag
        {
            Id = "Emperor",
            Names = new List<FlagName>
            {
                new()
                {
                    EnglishTranslation = "The standard of the Japanese Emperor"
                }
            },
            Description = "A 16-petal chrysanthemum (called Kikkamon, Japanese:菊花紋), colored in gold, centered on a red background with a 2:3 ratio.",
            Usage = FlagUsage.LeaderFlag
        });

        Countries.Japan.Flags.Add(new CountryFlag
        {
            Id = "AirRoundel",
            Names = new List<FlagName>
            {
                new()
                {
                    EnglishTranslation = "Military aircraft insignia"
                }
            },
            StartDate = new FlagDate(1945),
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