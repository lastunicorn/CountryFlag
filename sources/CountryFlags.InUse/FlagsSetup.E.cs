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

using System;
using System.Collections.Generic;

namespace DustInTheWind.CountryFlags.Present;

public static partial class FlagsSetup
{
    public static void Ecuador ()
    {
        Countries.Ecuador.Flags.Add(new CountryFlag
        {
            Id = "Civil",
            Names = new List<FlagName>
            {
                "Civil flag and ensign"
            },
            Description = "A horizontal tricolor of yellow (double width), blue and red.",
            Usage = FlagUsage.CivilFlag | FlagUsage.CivilEnsign
        });
    }

    public static void Egypt ()
    {
        Countries.Egypt.Flags.Add(new CountryFlag
        {
            Id = "WarFlag",
            Names = new List<FlagName>
            {
                "War flag"
            },
            Description = "National flag with two white crossed sabres in canton.",
            StartDate = new FlagDate(1984, 10, 04),
            Usage = FlagUsage.WarFlag
        });

        Countries.Egypt.Flags.Add(new CountryFlag
        {
            Id = "WarEnsign",
            Names = new List<FlagName>
            {
                "War ensign"
            },
            Description = "National flag with two white fouled crossed anchors in canton.",
            StartDate = new FlagDate(1984, 10, 04),
            Usage = FlagUsage.WarEnsign
        });

        Countries.Egypt.Flags.Add(new CountryFlag
        {
            Id = "President",
            Names = new List<FlagName>
            {
                "President's flag"
            },
            Description = "National flag with gold outlined Eagle of Saladin in canton.",
            StartDate = new FlagDate(1984, 10, 04),
            Usage = FlagUsage.LeaderFlag
        });
    }

    public static void ElSalvador ()
    {
        Countries.ElSalvador.Flags.Add(new CountryFlag
        {
            Id = "Civil",
            Names = new List<FlagName>
            {
                "Civil flag and ensign"
            },
            Description = "A horizontal triband of white within cobalt blue.",
            Usage = FlagUsage.CivilFlag | FlagUsage.CivilEnsign
        });

        Countries.ElSalvador.Flags.Add(new CountryFlag
        {
            Id = "Dios",
            Names = new List<FlagName>
            {
                "Dios Union Libertad"
            },
            Description = "A horizontal triband of white within cobalt blue, the words \"DIOS UNION LIBERTAD\" in bolden golden amber centered and occupying almost the entire length of the white stripe.",
            Usage = FlagUsage.StateFlag | FlagUsage.WarFlag | FlagUsage.CivilEnsign | FlagUsage.StateEnsign
        });
    }

    public static void EquatorialGuinea ()
    {
    }

    public static void Eritrea ()
    {
    }

    public static void Estonia ()
    {
        Countries.Estonia.Flags.Add(new CountryFlag
        {
            Id = "NavalEnsign",
            Names = new List<FlagName>
            {
                "Naval ensign"
            },
            Description = "Tricolour, swallowtail, defaced with the shield of the state arms off-set towards hoist.",
            StartDate = new FlagDate(1991),
            Usage = FlagUsage.WarEnsign
        });

        Countries.Estonia.Flags.Add(new CountryFlag
        {
            Id = "PresidentLand",
            Names = new List<FlagName>
            {
                "President's land flag"
            },
            Usage = FlagUsage.LeaderFlag
        });

        Countries.Estonia.Flags.Add(new CountryFlag
        {
            Id = "PresidentSea",
            Names = new List<FlagName>
            {
                "President's sea flag"
            },
            Usage = FlagUsage.LeaderFlag
        });

        Countries.Estonia.Flags.Add(new CountryFlag
        {
            Id = "NavalJack",
            Names = new List<FlagName>
            {
                "Naval jack"
            },
            Usage = FlagUsage.NavalJack
        });
    }

    public static void Eswatini ()
    {
    }

    public static void Ethiopia ()
    {
    }
}