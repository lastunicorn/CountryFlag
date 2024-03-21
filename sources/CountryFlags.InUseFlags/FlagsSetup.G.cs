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

internal static partial class FlagsSetup
{
    public static void Gabon()
    {
        Countries.Gabon.Flags.Add(new CountryFlag
        {
            Id = "President",
            Names = new List<FlagName>
            {
                "President's flag"
            },
            StartDate = new FlagDate(2016),
            Usage = FlagUsage.LeaderFlag
        });
    }

    public static void Gambia()
    {
        Countries.Gambia.Flags.Add(new CountryFlag
        {
            Id = "President",
            Names = new List<FlagName>
            {
                "Standard of the President"
            },
            Description = "A blue flag with the national coat of arms charged in the center."
        });
    }

    public static void Georgia()
    {
        Countries.Georgia.Flags.Add(new CountryFlag
        {
            Id = "President",
            Names = new List<FlagName>
            {
                "Presidential Standard"
            },
            Usage = FlagUsage.LeaderFlag
        });

        Countries.Georgia.Flags.Add(new CountryFlag
        {
            Id = "MinisterOfDefence",
            Names = new List<FlagName>
            {
                "Flag of the Minister of Defence"
            },
            Usage = FlagUsage.Other
        });

        Countries.Georgia.Flags.Add(new CountryFlag
        {
            Id = "ChiefGeneralStaff",
            Names = new List<FlagName>
            {
                "Chief of the General Staff"
            },
            Usage = FlagUsage.Other
        });

        Countries.Georgia.Flags.Add(new CountryFlag
        {
            Id = "WarFlag",
            Names = new List<FlagName>
            {
                "War flag of Georgia"
            },
            Usage = FlagUsage.WarFlag
        });

        Countries.Georgia.Flags.Add(new CountryFlag
        {
            Id = "NavalEnsign",
            Names = new List<FlagName>
            {
                "Naval ensign"
            },
            Description = "A dark blue field with a centred red cross with a white cross overlaid over it.",
            Usage = FlagUsage.WarEnsign
        });
    }

    public static void Germany()
    {
        Countries.Germany.Flags.Add(new CountryFlag
        {
            Id = "StateFlag",
            Names = new List<FlagName>
            {
                "State flag"
            },
            Description = "The civil flag with the coat of arms at the centre.",
            StartDate = new FlagDate(1950, 06, 07),
            Usage = FlagUsage.StateFlag | FlagUsage.WarFlag | FlagUsage.StateEnsign
        });

        Countries.Germany.Flags.Add(new CountryFlag
        {
            Id = "NavalEnsign",
            Names = new List<FlagName>
            {
                "Naval ensign"
            },
            Description = "A swallowtail of the civil flag with the coat of arms at the centre.",
            StartDate = new FlagDate(1956, 05, 25),
            Usage = FlagUsage.WarEnsign
        });
    }

    public static void Ghana()
    {
        Countries.Ghana.Flags.Add(new CountryFlag
        {
            Id = "CivilEnsign",
            Names = new List<FlagName>
            {
                "Civil ensign"
            },
            Description = "A red field with the national flag, fimbriated in black, in the canton.",
            Usage = FlagUsage.CivilEnsign
        });

        Countries.Ghana.Flags.Add(new CountryFlag
        {
            Id = "NavalEnsign",
            Names = new List<FlagName>
            {
                "Naval ensign"
            },
            Description = "Red St. George's Cross on white centrrensign, with the national flag in canton.",
            Usage = FlagUsage.WarEnsign
        });
    }

    public static void Gibraltar()
    {
        Countries.Gibraltar.Flags.Add(new CountryFlag
        {
            Id = "Union",
            Names = new List<FlagName>
            {
                "Union flag"
            },
            Description = "Flag of the United Kingdom",
            Usage = FlagUsage.Other
        });

        Countries.Gibraltar.Flags.Add(new CountryFlag
        {
            Id = "StateEnsign",
            Names = new List<FlagName>
            {
                "State ensign"
            },
            Description = "Blue Ensign with the Union Flag in the canton and the badge of Gibraltar in the fly.",
            StartDate = new FlagDate(1998),
            Usage = FlagUsage.StateEnsign
        });

        Countries.Gibraltar.Flags.Add(new CountryFlag
        {
            Id = "CivilEnsign",
            Names = new List<FlagName>
            {
                "Civil ensign of Gibraltar"
            },
            Description = "Red Ensign with the Union Flag in the canton and the badge of Gibraltar in the fly.",
            StartDate = new FlagDate(1998),
            Usage = FlagUsage.CivilEnsign
        });

        Countries.Gibraltar.Flags.Add(new CountryFlag
        {
            Id = "Governor",
            Names = new List<FlagName>
            {
                "Flag of the Governor of Gibraltar"
            },
            Description = "A Union Flag defaced with the coat of arms.",
            Usage = FlagUsage.LeaderFlag
        });
    }

    public static void Greece()
    {
    }

    public static void Greenland()
    {
    }

    public static void Grenada()
    {
        Countries.Grenada.Flags.Add(new CountryFlag
        {
            Id = "CivilEnsign",
            Names = new List<FlagName>
            {
                "Civil ensign"
            },
            Usage = FlagUsage.CivilEnsign
        });

        Countries.Grenada.Flags.Add(new CountryFlag
        {
            Id = "NavalEnsign",
            Names = new List<FlagName>
            {
                "Naval ensign"
            },
            Usage = FlagUsage.WarEnsign
        });
    }

    public static void Guadeloupe()
    {
    }

    public static void Guam()
    {
    }

    public static void Guatemala()
    {
        Countries.Guatemala.Flags.Add(new CountryFlag
        {
            Id = "Civil",
            Names = new List<FlagName>
            {
                "Civil flag and ensign"
            },
            Description = "A vertical triband of Maya blue (hoist-side and fly-side) and white.",
            StartDate = new FlagDate(1871),
            Usage = FlagUsage.CivilFlag | FlagUsage.CivilEnsign
        });
    }

    public static void Guernsey()
    {
    }

    public static void Guinea()
    {
        Countries.Guinea.Flags.Add(new CountryFlag
        {
            Id = "President",
            Names = new List<FlagName>
            {
                "Presidential standard"
            },
            Usage = FlagUsage.LeaderFlag
        });
    }

    public static void GuineaBissau()
    {
    }

    public static void Guyana()
    {
        Countries.Guyana.Flags.Add(new CountryFlag
        {
            Id = "Ensign",
            Names = new List<FlagName>
            {
                "National ensign"
            },
            Description = "An elongated version of the above.",
            Usage = FlagUsage.NationalEnsign
        });

        Countries.Guyana.Flags.Add(new CountryFlag
        {
            Id = "Air",
            Names = new List<FlagName>
            {
                "Civil air ensign"
            },
            Description = "British Civil Air Ensign combined with national flag of Guyana. May be flown at airports and from landed aircraft.",
            Usage = FlagUsage.AirForceEnsign
        });
    }
}