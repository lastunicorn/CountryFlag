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
using System.Collections.Generic;

namespace DustInTheWind.CountryFlags.InUseFlags;

internal static partial class FlagsSetup
{
    public static void Bahamas ()
    {
        Countries.Bahamas.Flags.Add(new CountryFlag
        {
            Id = "CivilEnsign",
            Description = "A white cross on a red field, the national flag in the canton.",
            Usage = FlagUsage.CivilEnsign
        });
        
        Countries.Bahamas.Flags.Add(new CountryFlag
        {
            Id = "StateEnsign",
            Description = "A blue cross on a white field, the national flag in the canton.",
            Usage = FlagUsage.StateEnsign
        });
        
        Countries.Bahamas.Flags.Add(new CountryFlag
        {
            Id = "WarEnsign",
            Description = "A red cross on a white field, the national flag in the canton.",
            Usage = FlagUsage.WarEnsign
        });
    }

    public static void Bahrain ()
    {
    }

    public static void Bangladesh ()
    {
        Countries.Bangladesh.Flags.Add(new CountryFlag
        {
            Id = "CivilEnsign",
            Names = new List<FlagName>
            {
                "Civil ensign"
            },
            Description = "A Red Ensign with the national flag of Bangladesh in the canton.",
            Usage = FlagUsage.CivilEnsign
        });

        Countries.Bangladesh.Flags.Add(new CountryFlag
        {
            Id = "NavalEnsign",
            Names = new List<FlagName>
            {
                "Naval ensign"
            },
            Description = "A White Ensign with the national flag of Bangladesh in the canton.",
            Usage = FlagUsage.WarEnsign
        });

        Countries.Bangladesh.Flags.Add(new CountryFlag
        {
            Id = "AirEnsign",
            Names = new List<FlagName>
            {
                "Air force ensign"
            },
            Description = "A field of air force blue with the national flag of Bangladesh in the canton and the Bangladesh Air Force roundel in the middle of the fly.",
            Usage = FlagUsage.AirForceEnsign
        });
    }

    public static void Barbados ()
    {
        Countries.Barbados.Flags.Add(new CountryFlag
        {
            Id = "NavalEnsign",
            Names = new List<FlagName>
            {
                "Naval ensign"
            },
            Description = "A red cross on a white field, the national flag in the canton.",
            Usage = FlagUsage.WarEnsign
        });
    }

    public static void Belarus ()
    {
    }

    public static void Belgium ()
    {
        Countries.Belgium.Flags.Add(new CountryFlag
        {
            Id = "CivilEnsign",
            Description = "A vertical tricolour of black, yellow, and red.",
            Usage = FlagUsage.CivilEnsign
        });

        Countries.Belgium.Flags.Add(new CountryFlag
        {
            Id = "StateEnsign",
            Description = "As above, with the central pale defaced by a lion rampant ensigned by a crown, both sable (black), the lion armed and langued gules (red).",
            StartDate = new DateTime(1950, 01, 01),
            Usage = FlagUsage.StateEnsign
        });

        Countries.Belgium.Flags.Add(new CountryFlag
        {
            Id = "NavalEnsign",
            Description = "A yellow saltire on a white field, bordered above and below in red and to the left and right in black, charged on the top with a crown above crossed cannons and on the bottom by a fouled anchor.",
            StartDate = new DateTime(1950, 02, 23),
            Usage = FlagUsage.WarEnsign
        });
    }

    public static void Belize ()
    {
    }

    public static void Benin ()
    {
    }

    public static void Bermuda ()
    {
        Countries.Bermuda.Flags.Add(new CountryFlag
        {
            Id = "StateEnsign",
            Names = new List<FlagName>
            {
                "Government Ensign of Bermuda"
            },
            Description = "Blue Ensign with the coat-of-arms of Bermuda in the fly.",
            Usage = FlagUsage.StateEnsign
        });

        Countries.Bermuda.Flags.Add(new CountryFlag
        {
            Id = "GovernorFlag",
            Names = new List<FlagName>
            {
                "Flag of the Governor of Bermuda"
            },
            Description = "A Union Flag defaced with the coat-of-arms of Bermuda.",
            Usage = FlagUsage.LeaderFlag
        });
    }

    public static void Bhutan ()
    {
        Countries.Bhutan.Flags.Add(new CountryFlag
        {
            Id = "AlternateFlag",
            Description = "Variant of the Flag of Bhutan with a differently rendered dragon",
            Usage = FlagUsage.NationalFlag
        });
    }

    public static void Bolivia ()
    {
        Countries.Bolivia.Flags.Add(new CountryFlag
        {
            Id = "State",
            Names = new List<FlagName>
            {
                "State Flag"
            },
            Description = "A horizontal tricolor of red, yellow and green with the coat of arms.",
            StartDate = new DateTime(1851, 10, 31),
            Usage = FlagUsage.StateFlag | FlagUsage.WarFlag | FlagUsage.StateEnsign
        });

        Countries.Bolivia.Flags.Add(new CountryFlag
        {
            Id = "Wiphala",
            Names = new List<FlagName>
            {
                "Wiphala",
                "Dual flag"
            },
            Description = "Banner composed of a 7-by-7 square patchwork in seven colours, arranged diagonally.",
            StartDate = new DateTime(2009, 02, 07),
            Usage = FlagUsage.NationalFlag
        });

        Countries.Bolivia.Flags.Add(new CountryFlag
        {
            Id = "NavalEnsign",
            Names = new List<FlagName>
            {
                "Naval ensign"
            },
            Usage = FlagUsage.WarEnsign
        });

        Countries.Bolivia.Flags.Add(new CountryFlag
        {
            Id = "NavalJack",
            Names = new List<FlagName>
            {
                "Naval Jack"
            },
            Description = "A red, yellow and green square.",
            Usage = FlagUsage.NavalJack
        });
    }

    public static void CaribbeanNetherlands ()
    {
        Countries.CaribbeanNetherlands.Flags.Add(new CountryFlag
        {
            Id = "NavalJack",
            Names = new List<FlagName>
            {
                "Marine Geus or Prinsengeus"
            },
            Description = "12 segments in the national colors of red (bright vermilion), white, and cobalt blue.",
            StartDate = new DateTime(1931, 04, 20),
            Usage = FlagUsage.NavalJack
        });

        Countries.CaribbeanNetherlands.Flags.Add(new CountryFlag
        {
            Id = "Monarch",
            Names = new List<FlagName>
            {
                "Royal Standard of the Netherlands"
            },
            Description = "Orange field divided in four by a nassau-blue cross, showing bugle-horns of the Principality of Orange and the coat of arms of the Kingdom, surrounded by a crown and the insignia of the Military Order of William.",
            StartDate = new DateTime(1908, 08, 27),
            Usage = FlagUsage.NavalJack
        });
    }

    public static void BosniaHerzegovina ()
    {
    }

    public static void Botswana ()
    {
        Countries.Botswana.Flags.Add(new CountryFlag
        {
            Id = "President",
            Names = new List<FlagName>
            {
                "Presidential Standard"
            },
            Description = "A light blue field charged with a black-rimmed white circle containing the coat of arms of Botswana in the centre."
        });
    }

    public static void BouvetIsland ()
    {
    }

    public static void Brazil ()
    {
    }

    public static void BritishIndianOceanTerritory ()
    {
    }

    public static void Brunei ()
    {
    }

    public static void Bulgaria ()
    {
    }

    public static void BurkinaFaso ()
    {
    }

    public static void Burundi ()
    {
    }
}