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
    public static void Ecuador ()
    {
        Countries.Ecuador.Flags.Add(new CountryFlag
        {
            Names = new List<FlagName>
            {
                new()
                {
                    NativeName = "La Tricolor",
                    EnglishTranslation = "The Tricolor"
                }
            },
            Description = "A horizontal tricolor of yellow (double width), blue and red with the National Coat of Arms superimposed at the center.",
            StartDate = new DateTime(1860, 09, 26),
            Usage = FlagUsage.StateFlag | FlagUsage.WarFlag | FlagUsage.StateEnsign | FlagUsage.WarEnsign
        });
    }

    public static void Egypt ()
    {
        Countries.Egypt.Flags.Add(new CountryFlag
        {
            Names = new List<FlagName>
            {
                new()
                {
                    NativeName = "عَلَمْ مَصر",
                    Romanized = "ˈʕælæm mɑsˤɾ",
                    EnglishTranslation = "National flag of Egypt"
                }
            },
            Description = "Horizontally divided red-white-black tricolor flag with the Eagle of Saladin.",
            StartDate = new DateTime(1984, 10, 04),
            DesignedBy = "Aly Kamel El-Deeb",
            Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag | FlagUsage.CivilEnsign | FlagUsage.StateEnsign
        });
    }

    public static void ElSalvador ()
    {
        Countries.ElSalvador.Flags.Add(new CountryFlag
        {
            Names = new List<FlagName>
            {
                new()
                {
                    NativeName = "Bandera Magna",
                    EnglishTranslation = "Magna flag"
                }
            },
            Description = "A horizontal triband of cobalt blue (top and bottom) and white with the National Coat of Arms in the center and occupying the entire hight of the white stripe with its top touching the upper blue strip and its base touching the lower blue stripe.",
            StartDate = new DateTime(1912, 05, 27),
            Usage = FlagUsage.StateFlag | FlagUsage.WarFlag | FlagUsage.WarEnsign
        });
    }

    public static void EquatorialGuinea ()
    {
        Countries.EquatorialGuinea.Flags.Add(new CountryFlag
        {
            Description = "A horizontal tricolor of green, white and red with a blue isosceles triangle based on the hoist side and the National Coat of arms of Equatorial Guinea centered in the white band.",
            StartDate = new DateTime(1968, 10, 12),
            Usage = FlagUsage.StateFlag | FlagUsage.WarFlag | FlagUsage.StateEnsign | FlagUsage.WarEnsign
        });
    }

    public static void Eritrea ()
    {
        Countries.Eritrea.Flags.Add(new CountryFlag
        {
            Names = new List<FlagName>
            {
                new()
                {
                    NativeName = "ሃገራዊት ባንዴራ ኤርትራ",
                    EnglishTranslation = "flag of Eritrea"
                },
                new()
                {
                    NativeName = "علم إريتريا الوطني",
                    EnglishTranslation = "flag of Eritrea"
                }
            },
            Description = "A red isosceles triangle based on the hoist-side pointed toward the fly-side and then divided into two right triangles: the upper triangle is green and the lower triangle is blue with an Emblem (1952-1995) in gold (a vertical olive branch encircled by an olive wreath) centered on the hoist side of the triangle.",
            StartDate = new DateTime(1995, 12, 05),
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void Estonia ()
    {
        Countries.Estonia.Flags.Add(new CountryFlag
        {
            Names = new List<FlagName>
            {
                new()
                {
                    NativeName = "Eesti lipp",
                    EnglishTranslation = "flag of Estonia"
                }
            },
            Description = "A horizontal triband of blue, black, and white.",
            StartDate = new DateTime(1918, 01, 01),
            Usage = FlagUsage.CivilFlag | FlagUsage.CivilEnsign | FlagUsage.StateFlag
        });
    }

    public static void Eswatini ()
    {
        Countries.Eswatini.Flags.Add(new CountryFlag
        {
            Description = "A horizontal triband of blue (top and bottom) and the yellow-edged red (triple width) with the large black and white Nguni shield covering two spears and the staff decorated with the feather tassels called injobo (tassels-bunches of feathers of the widowbird and the lourie) all centered horizontally of the red band.",
            StartDate = new DateTime(1968, 10, 06),
            DesignedBy = "King Sobhuza II",
            Usage = FlagUsage.StateFlag | FlagUsage.WarFlag
        });
    }

    public static void Ethiopia ()
    {
        Countries.Ethiopia.Flags.Add(new CountryFlag
        {
            Description = "A horizontal tricolour of green, yellow and red with the National Emblem superimposed at the center.",
            StartDate = new DateTime(2009, 05, 16),
            DesignedBy = "Abebe Alambo",
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }
}