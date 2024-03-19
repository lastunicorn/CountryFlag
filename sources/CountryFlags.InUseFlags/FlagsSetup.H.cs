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
    public static void Haiti()
    {
        Countries.Haiti.Flags.Add(new CountryFlag
        {
            Id = "Civil",
            Names = new List<FlagName>
            {
                "Civil flag and ensign"
            },
            Description = "A horizontal bicolour of blue and red.",
            StartDate = new FlagDate(1986, 02, 26),
            Usage = FlagUsage.CivilFlag | FlagUsage.CivilEnsign
        });
    }

    public static void HeardIslandAndMcDonaldIslands()
    {
    }

    public static void HolySee()
    {
    }

    public static void Honduras()
    {
        Countries.Honduras.Flags.Add(new CountryFlag
        {
            Id = "NavalEnsign",
            Names = new List<FlagName>
            {
                "Naval ensign"
            },
            Description = "A horizontal triband of blue (top and bottom) and white with the National Coat of Arms above an inverted arc of five blue five-pointed stars centered on the white band.",
            Usage = FlagUsage.NationalEnsign
        });
    }

    public static void HongKong()
    {
    }

    public static void Hungary()
    {
        Countries.Hungary.Flags.Add(new CountryFlag
        {
            Id = "Civil",
            Names = new List<FlagName>
            {
                "Civil flag and ensign"
            },
            Description = "A horizontal tricolour of red-white-green.",
            StartDate = new FlagDate(1957, 08, 18),
            Usage = FlagUsage.CivilFlag | FlagUsage.CivilEnsign
        });

        Countries.Hungary.Flags.Add(new CountryFlag
        {
            Id = "Unofficial",
            Names = new List<FlagName>
            {
                "Unofficial state flag"
            },
            Description = "A horizontal tricolour of red, white and green with the state coat of arms in the centre.",
            StartDate = new FlagDate(1995, 10, 10),
            Usage = FlagUsage.StateFlag
        });

        Countries.Hungary.Flags.Add(new CountryFlag
        {
            Id = "WarFlag",
            Names = new List<FlagName>
            {
                "War flag"
            },
            StartDate = new FlagDate(1991, 03, 15),
            Usage = FlagUsage.WarFlag
        });

        Countries.Hungary.Flags.Add(new CountryFlag
        {
            Id = "WarEnsign",
            Names = new List<FlagName>
            {
                "Naval ensign"
            },
            StartDate = new FlagDate(1991),
            Usage = FlagUsage.WarEnsign
        });
    }
}