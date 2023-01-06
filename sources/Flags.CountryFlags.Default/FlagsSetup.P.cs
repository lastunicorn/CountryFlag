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
    public static void Pakistan()
    {
        Countries.Pakistan.Flags.Add(new CountryFlag
        {
            Names = new List<FlagName>
            {
                new()
                {
                    NativeName = "Parcham-e Sitārah o Hilāl",
                    EnglishTranslation = "Flag of the Star and Crescent"
                }
            },
            Description = "A white star and crescent on a dark green field, with a vertical white stripe at the hoist.",
            StartDate = new DateTime(1947, 08, 11),
            DesignedBy = "Amiruddin Kidwai",
            Usage = FlagUsage.NationalFlag
        });
    }

    public static void Palau()
    {
        Countries.Palau.Flags.Add(new CountryFlag
        {
            Description = "A light blue field with the large yellow disk shifted slightly to the hoist-side of center.",
            StartDate = new DateTime(1981, 01, 01),
            DesignedBy = "Blau J. Skebong",
            Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag | FlagUsage.CivilEnsign | FlagUsage.StateEnsign
        });
    }

    public static void Palestine()
    {
        Countries.Palestine.Flags.Add(new CountryFlag
        {
            Names = new List<FlagName>
            {
                "National flag"
            },
            Description = "A horizontal tricolour of black, white, and green; with a red triangle based at the hoist.",
            StartDate = new DateTime(1964, 11, 15),
            Usage = FlagUsage.NationalFlag
        });
    }

    public static void Panama()
    {
        Countries.Panama.Flags.Add(new CountryFlag());
    }

    public static void PapuaNewGuinea()
    {
        Countries.PapuaNewGuinea.Flags.Add(new CountryFlag());
    }

    public static void Paraguay()
    {
        Countries.Paraguay.Flags.Add(new CountryFlag());
    }

    public static void Peru()
    {
        Countries.Peru.Flags.Add(new CountryFlag());
    }

    public static void Philippines()
    {
        Countries.Philippines.Flags.Add(new CountryFlag());
    }

    public static void Pitcairn()
    {
        Countries.Pitcairn.Flags.Add(new CountryFlag());
    }

    public static void Poland()
    {
        Countries.Poland.Flags.Add(new CountryFlag());
    }

    public static void Portugal()
    {
        Countries.Portugal.Flags.Add(new CountryFlag());
    }

    public static void PuertoRico()
    {
        Countries.PuertoRico.Flags.Add(new CountryFlag());
    }
}