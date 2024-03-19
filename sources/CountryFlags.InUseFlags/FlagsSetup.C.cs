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

namespace DustInTheWind.CountryFlags.InUseFlags;

internal static partial class FlagsSetup
{
    public static void CaboVerde ()
    {
    }

    public static void Cambodia ()
    {
        Countries.Cambodia.Flags.Add(new CountryFlag
        {
            Id = "King",
            Description = "The royal arms in gold centered on a blue field.",
            StartDate = new FlagDate(1993, 09, 24),
            Usage = FlagUsage.LeaderFlag
        });
    }

    public static void Cameroon ()
    {
    }

    public static void Canada ()
    {
    }

    public static void CaymanIslands ()
    {
        Countries.CaymanIslands.Flags.Add(new CountryFlag
        {
            Id = "CivilEnsign",
            Names = new List<FlagName>
            {
                "Civil ensign"
            },
            StartDate = new FlagDate(1999),
            Usage = FlagUsage.CivilEnsign
        });

        Countries.CaymanIslands.Flags.Add(new CountryFlag
        {
            Id = "Governor",
            Names = new List<FlagName>
            {
                "Standard of the Governor"
            },
            StartDate = new FlagDate(1999),
            Usage = FlagUsage.LeaderFlag
        });
    }

    public static void CentralAfricanRepublic ()
    {
    }

    public static void Chad ()
    {
    }

    public static void Chile ()
    {
        Countries.Chile.Flags.Add(new CountryFlag
        {
            Id = "President",
            Names = new List<FlagName>
            {
                "Presidential Standard"
            },
            Description = "Same design as the National Flag with the National Coat of Arms superimposed at the center.",
            DesignedBy = "Alfonso Martinez Delpelao",
            Usage = FlagUsage.LeaderFlag
        });
    }

    public static void China ()
    {
        Countries.China.Flags.Add(new CountryFlag
        {
            Id = "WarFlag",
            Description = "A Chinese red field with a yellow star and Chinese numerals \"八一\", referencing 1 August, at the canton.",
            StartDate = new FlagDate(1949, 06, 15),
            Usage = FlagUsage.WarFlag | FlagUsage.NavalJack
        });
    }

    public static void ChristmasIsland ()
    {
    }

    public static void CocosIslands ()
    {
    }

    public static void Colombia ()
    {
        Countries.Colombia.Flags.Add(new CountryFlag
        {
            Id = "CivilEnsign",
            Names = new List<FlagName>
            {
                "Civil ensign"
            },
            Description = "The national flag defaced in the centre with a blue ellipse outlined in red and an eight-pointed white star.",
            Usage = FlagUsage.CivilEnsign
        });

        Countries.Colombia.Flags.Add(new CountryFlag
        {
            Id = "NavalEnsign",
            Names = new List<FlagName>
            {
                "Naval ensign"
            },
            Description = "The national flag defaced in the centre with a white circle outlined in red and the coat of arms of Colombia.",
            Usage = FlagUsage.WarEnsign
        });
    }

    public static void Comoros ()
    {
    }

    public static void Congo_Republic ()
    {
    }

    public static void Congo_DemocraticRepublic ()
    {
        Countries.Congo_DemocraticRepublic.Flags.Add(new CountryFlag
        {
            Id = "President",
            Description = "National flag with the addition of the inscription \"Le President\"",
            StartDate = new FlagDate(2006, 02, 20),
            Usage = FlagUsage.LeaderFlag
        });
    }

    public static void CookIslands ()
    {
        Countries.CookIslands.Flags.Add(new CountryFlag
        {
            Id = "King",
            Usage = FlagUsage.LeaderFlag
        });
    }

    public static void CostaRica ()
    {
        Countries.CostaRica.Flags.Add(new CountryFlag
        {
            Id = "StateAndWar",
            Names = new List<FlagName>
            {
                "State and war flag and ensign"
            },
            Description = "Five horizontal bands of blue, white, and red (double width), with the coat of arms offcenter to the left.",
            StartDate = new FlagDate(1906, 11, 27),
            DesignedBy = "Pacífica Fernández",
            Usage = FlagUsage.StateFlag | FlagUsage.WarFlag | FlagUsage.StateEnsign | FlagUsage.WarEnsign
        });
    }

    public static void IvoryCoast ()
    {
    }

    public static void Croatia ()
    {
        Countries.Croatia.Flags.Add(new CountryFlag
        {
            Id = "Ensign",
            Names = new List<FlagName>
            {
                "Civil and state ensign"
            },
            Description = "Three equal horizontal bands of red (top), white and blue superimposed by the Croatian coat of arms.",
            StartDate = new FlagDate(1992),
            Usage = FlagUsage.CivilEnsign | FlagUsage.StateEnsign
        });

        Countries.Croatia.Flags.Add(new CountryFlag
        {
            Id = "NavalEnsign",
            Names = new List<FlagName>
            {
                "Naval ensign"
            },
            Description = "Three equal horizontal bands of red (top), white and blue superimposed by the emblem of the Croatian Navy.",
            StartDate = new FlagDate(1992),
            Usage = FlagUsage.WarEnsign
        });
    }

    public static void Cuba ()
    {
        Countries.Cuba.Flags.Add(new CountryFlag
        {
            Id = "President",
            Names = new List<FlagName>
            {
                "President's flag"
            },
            Usage = FlagUsage.LeaderFlag
        });

        Countries.Cuba.Flags.Add(new CountryFlag
        {
            Id = "NavalJack",
            Names = new List<FlagName>
            {
                "Naval jack"
            },
            Usage = FlagUsage.NavalJack
        });
    }

    public static void Curacao ()
    {
        Countries.Curacao.Flags.Add(new CountryFlag
        {
            Id = "Governor",
            Names = new List<FlagName>
            {
                "Governor's flag"
            },
            StartDate = new DateTime(1984, 07, 02),
            Usage = FlagUsage.LeaderFlag
        });
    }

    public static void Cyprus ()
    {
    }

    public static void Czechia ()
    {
        Countries.Czechia.Flags.Add(new CountryFlag
        {
            Id = "WarFlag",
            StartDate = new FlagDate(1993),
            Usage = FlagUsage.WarFlag
        });
    }
}