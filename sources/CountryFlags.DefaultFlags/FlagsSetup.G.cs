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
    public static void Gabon()
    {
        Countries.Gabon.Flags.Add(new CountryFlag
        {
            Description = "A horizontal triband of green, gold and blue.",
            StartDate = new FlagDate(1960, 08, 17)
        });
    }

    public static void Gambia()
    {
        Countries.Gambia.Flags.Add(new CountryFlag
        {
            Description = "A horizontal tricolor of red, blue and green; each band of colour is separated by a narrow band of white.",
            StartDate = new FlagDate(1965, 02, 18),
            DesignedBy = "Louis Thomasi",
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void Georgia()
    {
        Countries.Georgia.Flags.Add(new CountryFlag
        {
            Description = "A white field with a centred red cross; a red Bolnur-Katskhuri cross centres each quarter.",
            StartDate = new FlagDate(2004, 01, 14),
            Usage = FlagUsage.NationalFlag | FlagUsage.CivilEnsign | FlagUsage.StateEnsign
        });
    }

    public static void Germany()
    {
        Countries.Germany.Flags.Add(new CountryFlag
        {
            Description = "A horizontal tricolour of black, red, and gold.",
            StartDate = new FlagDate(1949, 05, 23),
            Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag | FlagUsage.CivilEnsign
        });
    }

    public static void Ghana()
    {
        Countries.Ghana.Flags.Add(new CountryFlag
        {
            Description = "A horizontal triband of red, gold, and green, charged with a black star in the centre.",
            StartDate = new FlagDate(1966, 02, 28),
            DesignedBy = "Theodosia Okoh",
            Usage = FlagUsage.NationalFlag | FlagUsage.CivilEnsign | FlagUsage.StateEnsign
        });
    }

    public static void Gibraltar()
    {
        Countries.Gibraltar.Flags.Add(new CountryFlag
        {
            Description = "White with a red stripe at the bottom with a three-towered, two-tiered red castle in the white section. Each tower has a door and a window and from the door of the middle tower hangs a gold key which mainly overlaps the red stripe.",
            StartDate = new FlagDate(1982, 11, 08),
            Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag
        });
    }

    public static void Greece()
    {
        Countries.Greece.Flags.Add(new CountryFlag
        {
            Names = new List<FlagName>
            {
                new()
                {
                    NativeName = "Η Γαλανόλευκη",
                    Romanized = "I Galanolefki",
                    EnglishTranslation = "The Blue and White"
                },
                new()
                {
                    NativeName = "Η Κυανόλευκη",
                    Romanized = "I Kyanolefki",
                    EnglishTranslation = "The Azure and White"
                }
            },
            Description = "Nine horizontal stripes, in turn blue and white; a white Greek cross throughout a blue canton.",
            StartDate = new FlagDate(1978, 12, 22),
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void Greenland()
    {
        Countries.Greenland.Flags.Add(new CountryFlag
        {
            Names = new List<FlagName>
            {
                new()
                {
                    NativeName = "Erfalasorput",
                    EnglishTranslation = "our flag"
                },
                new()
                {
                    NativeName = "Aappalaartoq",
                    EnglishTranslation = "the red"
                }
            },
            Description = "A horizontal bicolour of white and red, with a counterchanged disk slightly off-centre towards the hoist.",
            StartDate = new FlagDate(1985, 06, 21),
            DesignedBy = "Thue Christiansen",
            Usage = FlagUsage.NationalFlag | FlagUsage.CivilEnsign
        });
    }

    public static void Grenada()
    {
        Countries.Grenada.Flags.Add(new CountryFlag
        {
            Description = "A rectangle divided diagonally into two yellow triangles at the top and bottom and two green triangles at the hoist and fly, surrounded by a red border charged with six five pointed yellow stars, another five-pointed yellow star on a red disc at the centre, and a nutmeg at the hoist.",
            StartDate = new FlagDate(1974, 02, 07),
            DesignedBy = "Anthony C. George",
            Usage = FlagUsage.NationalFlag
        });
    }

    public static void Guadeloupe()
    {
        Countries.Guadeloupe.Flags.Add(new CountryFlag
        {
        });
    }

    public static void Guam()
    {
        Countries.Guam.Flags.Add(new CountryFlag
        {
            Description = "A dark blue background with a thin red border and the Seal in the center.",
            StartDate = new FlagDate(1948, 02, 09),
            Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag
        });
    }

    public static void Guatemala()
    {
        Countries.Guatemala.Flags.Add(new CountryFlag
        {
            Description = "A vertical triband of Maya blue (hoist-side and fly-side) and white with the National Emblem centered on the white band.",
            StartDate = new FlagDate(1871),
            Usage = FlagUsage.StateFlag | FlagUsage.WarFlag | FlagUsage.StateEnsign | FlagUsage.WarEnsign
        });
    }

    public static void Guernsey()
    {
        Countries.Guernsey.Flags.Add(new CountryFlag
        {
        });
    }

    public static void Guinea()
    {
        Countries.Guinea.Flags.Add(new CountryFlag
        {
            Description = "A vertical tricolour of red, yellow and green.",
            StartDate = new FlagDate(1958, 11, 10),
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void GuineaBissau()
    {
        Countries.GuineaBissau.Flags.Add(new CountryFlag
        {
            Description = "One vertical red line on the hoist side charged with a black five-pointed star; two horizontal lines on the fly side (yellow and green).",
            StartDate = new FlagDate(1973, 09, 24),
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void Guyana()
    {
        Countries.Guyana.Flags.Add(new CountryFlag
        {
            Names = new List<FlagName>
            {
                "The Golden Arrowhead"
            },
            Description = "A green field with the black-edged red isosceles triangle based on the hoist-side superimposed on the larger white-edged golden triangle, also based on the hoist-side, pointed toward the fly-side.",
            StartDate = new FlagDate(1966, 05, 26),
            DesignedBy = "Whitney Smith",
            Usage = FlagUsage.NationalFlag
        });
    }
}