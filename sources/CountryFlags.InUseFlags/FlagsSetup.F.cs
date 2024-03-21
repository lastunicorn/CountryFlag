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
    public static void FalklandIslands ()
    {
        Countries.FalklandIslands.Flags.Add(new CountryFlag
        {
            Id = "CivilEnsign",
            Names = new List<FlagName>
            {
                "Civil ensign"
            },
            Description = "Red Ensign with the coat-of-arms of the Falkland Islands in the fly.",
            StartDate = new FlagDate(1999, 01, 25),
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
            StartDate = new FlagDate(1948, 09, 29),
            Usage = FlagUsage.LeaderFlag
        });
    }

    public static void FaroeIslands ()
    {
        Countries.FaroeIslands.Flags.Add(new CountryFlag
        {
            Id = "Swallowtailed",
            Names = new List<FlagName>
            {
                "Swallowtailed flag"
            },
            Description = "Swallowtailed version of the flag, unofficial, but popular on the Islands"
        });
    }

    public static void Fiji ()
    {
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
            Id = "StateFlag",
            Names = new List<FlagName>
            {
                "State flag"
            },
            Description = "Sea-blue Nordic cross on white field, rectangular Coat of Arms of Finland (colours gold and silver on red).",
            StartDate = new FlagDate(1978)
        });

        Countries.Finland.Flags.Add(new CountryFlag
        {
            Id = "TailedStateFlag",
            Description = "Sea-blue Nordic cross on white field, rectangular Coat of Arms of Finland (colours gold and silver on red), swallow-tailed.",
            StartDate = new FlagDate(1978),
            Usage = FlagUsage.WarFlag | FlagUsage.WarEnsign
        });

        Countries.Finland.Flags.Add(new CountryFlag
        {
            Id = "President",
            Names = new List<FlagName>
            {
                "President's flag"
            },
            Description = "Sea-blue Nordic cross on white field, rectangular Coat of Arms of Finland (colours gold and silver on red), swallow-tailed, Cross of Liberty in canton (colors gold on blue).",
            StartDate = new FlagDate(1918),
            Usage = FlagUsage.LeaderFlag
        });

        Countries.Finland.Flags.Add(new CountryFlag
        {
            Id = "NavalJack",
            Names = new List<FlagName>
            {
                "Naval jack"
            },
            Description = "A white field with the Coat of Arms of Finland in the center.",
            StartDate = new FlagDate(1918),
            Usage = FlagUsage.NavalJack
        });
    }

    public static void France ()
    {
        Countries.France.Flags.Add(new CountryFlag
        {
            Id = "Variant",
            Description = "An interchangeable variant of the national flag with lighter shades.",
            StartDate = new FlagDate(1974),
            Usage = FlagUsage.NationalFlag
        });
    }

    public static void FrenchGuiana ()
    {
    }

    public static void FrenchPolynesia ()
    {
        Countries.FrenchPolynesia.Flags.Add(new CountryFlag
        {
            Id = "FranchTricolore",
            Names = new List<FlagName>
            {
                "Flag of the French Republic"
            },
            StartDate = new FlagDate(1794, 02, 15),
            Usage = FlagUsage.NationalFlag | FlagUsage.CivilEnsign | FlagUsage.StateEnsign
        });
    }

    public static void FrenchSouthernTerritories ()
    {
    }
}