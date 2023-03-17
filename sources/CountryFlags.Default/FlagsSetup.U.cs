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

namespace DustInTheWind.CountryFlags.Default;

public static partial class FlagsSetup
{
    public static void Uganda()
    {
        Countries.Uganda.Flags.Add(new CountryFlag
        {
            Description = "Six equal horizontal bands of black (top), yellow, red, black, yellow, and red (bottom); a white disc is superimposed at the centre and depicts the national symbol, a grey crowned crane, facing the hoist side.",
            StartDate = new FlagDate(1962, 10, 09),
            DesignedBy = "Grace Ibingira",
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void Ukraine()
    {
        Countries.Ukraine.Flags.Add(new CountryFlag
        {
            Description = "A horizontal bicolour of blue and yellow.",
            StartDate = new FlagDate(2006, 09, 01),
            Usage = FlagUsage.NationalFlag | FlagUsage.StateEnsign
        });
    }

    public static void UnitedArabEmirates()
    {
        Countries.UnitedArabEmirates.Flags.Add(new CountryFlag
        {
            Description = "A horizontal tricolour of green, white and black with a vertical 1⁄4-width red bar at the hoist",
            StartDate = new FlagDate(1971, 12, 02),
            DesignedBy = "Abdulla Mohamed Al Maainah",
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void UnitedKingdom()
    {
        Countries.UnitedKingdom.Flags.Add(new CountryFlag
        {
            Description = "A white-fimbriated symmetric red cross on a blue field with a white-fimbriated counterchanged saltire of red and white.",
            StartDate = new FlagDate(1801, 01, 01),
            Usage = FlagUsage.NationalFlag
        });
    }

    public static void UnitedStatesOfAmerica()
    {
        Countries.UnitedStatesOfAmerica.Flags.Add(new CountryFlag
        {
            Names = new List<FlagName>
            {
                "The American flag",
                "The Stars and Stripes Red, White, and Blue",
                "Old Glory",
                "The Star-Spangled Banner",
                "United States (U.S.) flag"
            },
            Description = "Thirteen horizontal stripes alternating red and white; in the canton, 50 white stars of alternating numbers of six and five per horizontal row on a blue field.",
            StartDate = new FlagDate(1960, 07, 04),
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void UnitedStatesMinorOutlyingIslands()
    {
        Countries.UnitedStatesMinorOutlyingIslands.Flags.Add(new CountryFlag());
    }

    public static void Uruguay()
    {
        Countries.Uruguay.Flags.Add(new CountryFlag
        {
            Description = "Four horizontal stripes of blue with the upper hoist-side corner bearing the Sun of May in the centre over a white canvas.",
            StartDate = new FlagDate(1830, 07, 11),
            DesignedBy = "Joaquín Suárez",
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void Uzbekistan()
    {
        Countries.Uzbekistan.Flags.Add(new CountryFlag
        {
            Description = "A horizontal triband of azure, white and green, separated by two narrow red stripes. A white crescent and three rows of twelve white five-pointed stars are situated on the left side of the upper azure stripe.",
            StartDate = new FlagDate(1991, 11, 18),
            DesignedBy = "Farxod Yuldaşev",
            Usage = FlagUsage.CivilAndStateFlag | FlagUsage.CivilAndStateEnsign
        });
    }
}