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

namespace DustInTheWind.Flags.CountryFlags.Default;

public static partial class FlagsSetup
{
    public static void FalklandIslands ()
    {
        Countries.FalklandIslands.Flags.Add(new CountryFlag
        {
            Description = "Blue Ensign with the coat-of-arms of the Falkland Islands in the fly.",
            StartDate = new DateTime(1999, 01, 25),
            Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag | FlagUsage.StateEnsign
        });

        Countries.FalklandIslands.Flags.Add(new CountryFlag
        {
            Id = "CivilEnsign",
            Description = "Red Ensign with the coat-of-arms of the Falkland Islands in the fly.",
            StartDate = new DateTime(1999, 01, 25),
            Usage = FlagUsage.CivilEnsign
        });
        
        Countries.FalklandIslands.Flags.Add(new CountryFlag
        {
            Id = "Governor",
            Names = new List<FlagName>
            {
                "Flag of the Governor"
            },
            Description = "A Union Flag defaced with the coat-of-arms of the Falkland Islands.",
            StartDate = new DateTime(1948, 09, 29),
            Usage = FlagUsage.Other
        });
    }

    public static void FaroeIslands ()
    {
        Countries.FaroeIslands.Flags.Add(new CountryFlag
        {
            Description = "A blue-fimbriated red Nordic cross on a white field.",
            StartDate = new DateTime(1940, 04, 25),
            DesignedBy = "Jens Oliver Lisberg",
            Usage = FlagUsage.NationalEnsign | FlagUsage.CivilEnsign
        });

        Countries.FaroeIslands.Flags.Add(new CountryFlag
        {
            Id = "Swallowtailed",
            Description = "Swallowtailed version of the flag, unofficial, but popular on the Islands"
        });
    }

    public static void Fiji ()
    {
        Countries.Fiji.Flags.Add(new CountryFlag
        {
            Names = new List<FlagName>
            {
                new()
                {
                    NativeName = "kuila ni Viti",
                    EnglishTranslation = "flag of Fiji"
                }
            },
            Description = "A Cyan Ensign with the shield from the national coat of arms centred in the fly half.",
            StartDate = new DateTime(1970, 10, 10),
            DesignedBy = "Tessa Mackenzie",
            Usage = FlagUsage.NationalFlag
        });

        Countries.Fiji.Flags.Add(new CountryFlag
        {
            Id = "CivilEnsign",
            Names = new List<FlagName>
            {
                "Civil Ensign"
            },
            Description = "A Red Ensign with the shield from the national coat of arms centred in the fly half.",
            Usage = FlagUsage.CivilEnsign
        });

        Countries.Fiji.Flags.Add(new CountryFlag
        {
            Id = "StateEnsign",
            Names = new List<FlagName>
            {
                "State Ensign"
            },
            Description = "A Blue Ensign with the shield from the national coat of arms centred in the fly half.",
            Usage = FlagUsage.StateEnsign
        });

        Countries.Fiji.Flags.Add(new CountryFlag
        {
            Id = "NavalEnsign",
            Names = new List<FlagName>
            {
                "Naval Ensign"
            },
            Description = "A White Ensign with the national coat of arms centred in the fly half.",
            Usage = FlagUsage.WarEnsign
        });

        Countries.Fiji.Flags.Add(new CountryFlag
        {
            Id = "AirEnsign",
            Names = new List<FlagName>
            {
                "Civil Air Ensign"
            },
            Description = "A dark blue cross outlined in white on a light blue field with the Union Jack in the canton and the shield from the Fijian coat of arms superimposed over the right arm of the cross.",
            Usage = FlagUsage.AirForceEnsign
        });
    }

    public static void Finland ()
    {
        Countries.Finland.Flags.Add(new CountryFlag
        {
            Description = "Sea-blue Nordic cross on white field.",
            StartDate = new DateTime(1918, 05, 28),
            Usage = FlagUsage.CivilFlag | FlagUsage.CivilEnsign
        });

        Countries.Finland.Flags.Add(new CountryFlag
        {
            Id = "StateFlag",
            Description = "Sea-blue Nordic cross on white field, rectangular Coat of Arms of Finland (colours gold and silver on red).",
            StartDate = new DateTime(1978, 01, 01)
        });

        Countries.Finland.Flags.Add(new CountryFlag
        {
            Id = "TailedStateFlag",
            Description = "Sea-blue Nordic cross on white field, rectangular Coat of Arms of Finland (colours gold and silver on red), swallow-tailed.",
            StartDate = new DateTime(1978, 01, 01),
            Usage = FlagUsage.WarFlag | FlagUsage.WarEnsign
        });

        Countries.Finland.Flags.Add(new CountryFlag
        {
            Id = "President",
            Description = "Sea-blue Nordic cross on white field, rectangular Coat of Arms of Finland (colours gold and silver on red), swallow-tailed, Cross of Liberty in canton (colors gold on blue).",
            StartDate = new DateTime(1918, 01, 01),
            Usage = FlagUsage.LeaderFlag
        });

        Countries.Finland.Flags.Add(new CountryFlag
        {
            Id = "NavalJack",
            Description = "A white field with the Coat of Arms of Finland in the center.",
            StartDate = new DateTime(1918, 01, 01),
            Usage = FlagUsage.NavalJack
        });
    }

    public static void France ()
    {
        Countries.France.Flags.Add(new CountryFlag
        {
            Names = new List<FlagName>
            {
                new()
                {
                    NativeName = "Tricolore",
                    EnglishTranslation = "Tricolour"
                }
            },
            Description = "A vertical tricolour of blue, white, and red",
            StartDate = new DateTime(1794, 02, 15),
            DesignedBy = "Lafayette, Jacques-Louis David",
            Usage = FlagUsage.NationalFlag
        });

        Countries.France.Flags.Add(new CountryFlag
        {
            Id = "Variant",
            Description = "An interchangeable variant of the national flag with lighter shades.",
            StartDate = new DateTime(1974, 01, 01),
            Usage = FlagUsage.NationalFlag
        });
    }

    public static void FrenchGuiana ()
    {
        Countries.FrenchGuiana.Flags.Add(new CountryFlag());
    }

    public static void FrenchPolynesia ()
    {
        Countries.FrenchPolynesia.Flags.Add(new CountryFlag
        {
            Description = "Two red horizontal bands encase a wide white band in a 1:2:1 ratio, with the Coat of arms centred on the white stripe.",
            StartDate = new DateTime(1984, 11, 23),
            Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag
        });

        Countries.FrenchPolynesia.Flags.Add(new CountryFlag
        {
            Id = "FranchTricolore",
            Names = new List<FlagName>
            {
                "Flag of the French Republic"
            },
            StartDate = new DateTime(1794, 02, 15),
            Usage = FlagUsage.NationalFlag | FlagUsage.CivilEnsign | FlagUsage.StateEnsign
        });
    }

    public static void FrenchSouthernTerritories ()
    {
        Countries.FrenchSouthernTerritories.Flags.Add(new CountryFlag
        {
            Description = "A blue ensign with the French tricolor in the canton and the letters T.A.A.F in the form of a white anchor in the fly surrounded by five, five-pointed white stars.",
            StartDate = new DateTime(2007, 02, 23)
        });
    }
}