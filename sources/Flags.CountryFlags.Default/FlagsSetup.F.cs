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

namespace DustInTheWind.CountryFlags.Default;

public static partial class FlagsSetup
{
    public static void FalklandIslands ()
    {
        Countries.FalklandIslands.Flags.Add(new CountryFlag
        {
            Description = "Blue Ensign with the coat-of-arms of the Falkland Islands in the fly.",
            StartDate = new FlagDate(1999, 01, 25),
            Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag | FlagUsage.StateEnsign
        });
    }

    public static void FaroeIslands ()
    {
        Countries.FaroeIslands.Flags.Add(new CountryFlag
        {
            Description = "A blue-fimbriated red Nordic cross on a white field.",
            StartDate = new FlagDate(1940, 04, 25),
            DesignedBy = "Jens Oliver Lisberg",
            Usage = FlagUsage.NationalEnsign | FlagUsage.CivilEnsign
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
            StartDate = new FlagDate(1970, 10, 10),
            DesignedBy = "Tessa Mackenzie",
            Usage = FlagUsage.NationalFlag
        });
    }

    public static void Finland ()
    {
        Countries.Finland.Flags.Add(new CountryFlag
        {
            Description = "Sea-blue Nordic cross on white field.",
            StartDate = new FlagDate(1918, 05, 28),
            Usage = FlagUsage.CivilFlag | FlagUsage.CivilEnsign
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
            StartDate = new FlagDate(1794, 02, 15),
            DesignedBy = "Lafayette, Jacques-Louis David",
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
            StartDate = new FlagDate(1984, 11, 23),
            Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag
        });
    }

    public static void FrenchSouthernTerritories ()
    {
        Countries.FrenchSouthernTerritories.Flags.Add(new CountryFlag
        {
            Description = "A blue ensign with the French tricolor in the canton and the letters T.A.A.F in the form of a white anchor in the fly surrounded by five, five-pointed white stars.",
            StartDate = new FlagDate(2007, 02, 23)
        });
    }
}