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

namespace DustInTheWind.CountryFlags.DefaultFlags;

internal static partial class FlagsSetup
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
            StartDate = new FlagDate(1947, 08, 11),
            DesignedBy = "Amiruddin Kidwai",
            Usage = FlagUsage.NationalFlag
        });
    }

    public static void Palau()
    {
        Countries.Palau.Flags.Add(new CountryFlag
        {
            Description = "A light blue field with the large yellow disk shifted slightly to the hoist-side of center.",
            StartDate = new FlagDate(1981, 01, 01),
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
            StartDate = new FlagDate(1964, 11, 15),
            Usage = FlagUsage.NationalFlag
        });
    }

    public static void Panama()
    {
        Countries.Panama.Flags.Add(new CountryFlag
        {
            Description = "Divided into four rectangles: going clockwise, each quadrant contains a blue star, a red rectangle, a red star, and a blue rectangle.",
            StartDate = new FlagDate(1925, 03, 25),
            DesignedBy = "María de la Ossa de Amador",
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void PapuaNewGuinea()
    {
        Countries.PapuaNewGuinea.Flags.Add(new CountryFlag
        {
            Description = "Divided diagonally from the upper hoist-side corner to the lower fly-side corner: the upper triangle is red with the soaring Raggiana bird-of-paradise and the lower triangle is black with the Southern Cross of four white larger five-pointed stars and the smaller star.",
            StartDate = new FlagDate(1971, 07, 01),
            DesignedBy = "Susan Karike Huhume",
            Usage = FlagUsage.NationalFlag | FlagUsage.CivilEnsign | FlagUsage.StateEnsign
        });
    }

    public static void Paraguay()
    {
        Countries.Paraguay.Flags.Add(new CountryFlag
        {
            Description = "A horizontal triband of red, white and blue, defaced on the obverse with the coat of arms of Paraguay.",
            StartDate = new FlagDate(2013, 07, 15),
            Usage = FlagUsage.NationalFlagAndEnsign,
            Comments = "Has different design on its reverse side."
        });
    }

    public static void Peru()
    {
        Countries.Peru.Flags.Add(new CountryFlag
        {
            Description = "A vertical triband of red (hoist-side and fly-side) and white.",
            StartDate = new FlagDate(1950, 03, 31),
            Usage = FlagUsage.CivilFlag | FlagUsage.CivilEnsign
        });
    }

    public static void Philippines()
    {
        Countries.Philippines.Flags.Add(new CountryFlag
        {
            Description = "A horizontal bicolor of blue and red with a white equilateral triangle based at the hoist containing three, five-pointed gold stars at its vertices, and an eight-rayed gold sun at its center.",
            StartDate = new FlagDate(1998, 02, 12),
            DesignedBy = "Emilio Aguinaldo",
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void Pitcairn()
    {
        Countries.Pitcairn.Flags.Add(new CountryFlag
        {
            Description = "A Blue Ensign charged in the fly with the coat of arms of the Pitcairn Islands.",
            StartDate = new FlagDate(1984, 04, 02),
            Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag | FlagUsage.StateEnsign
        });
    }

    public static void Poland()
    {
        Countries.Poland.Flags.Add(new CountryFlag
        {
            Description = "A horizontal bicolour of white and red.",
            StartDate = new FlagDate(1980, 01, 31),
            Usage = FlagUsage.NationalFlag
        });
    }

    public static void Portugal()
    {
        Countries.Portugal.Flags.Add(new CountryFlag
        {
            Description = "A 2:3 vertically striped bicolour of green and red, with the lesser coat of arms of Portugal centered over the colour boundary.",
            StartDate = new FlagDate(1911, 06, 30),
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void PuertoRico()
    {
        Countries.PuertoRico.Flags.Add(new CountryFlag
        {
            Description = "Five equal horizontal bands of red (top and bottom) alternating with white; blue equilateral triangle based on the hoist side bears a large, white, five-pointed star in the center.",
            StartDate = new FlagDate(1952),
            Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag | FlagUsage.CivilEnsign | FlagUsage.StateEnsign
        });
    }
}