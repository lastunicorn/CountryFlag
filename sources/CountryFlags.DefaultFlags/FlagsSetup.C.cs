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

namespace DustInTheWind.CountryFlags.DefaultFlags;

internal static partial class FlagsSetup
{
    public static void CaboVerde()
    {
        Countries.CaboVerde.Flags.Add(new CountryFlag
        {
            Description = "Five unequal horizontal bands of blue (six-twelfths), white, red, white (each of the bands are one-twelfth) and blue (three-twelfths) with the circle of ten yellow five-pointed stars centered on the red stripe and positioned three-eighths of the length of the flag from the hoist-side.",
            StartDate = new FlagDate(1992, 09, 22),
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void Cambodia()
    {
        Countries.Cambodia.Flags.Add(new CountryFlag
        {
            Description = "Three horizontal bands of blue, red (double width) and blue, with a depiction of Angkor Wat in white centred on the red band.",
            StartDate = new FlagDate(1993, 09, 24),
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void Cameroon()
    {
        Countries.Cameroon.Flags.Add(new CountryFlag
        {
            Description = "A vertical tricolour of green, red and yellow, with a gold star centered on the red band.",
            StartDate = new FlagDate(1975, 05, 20),
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void Canada()
    {
        Countries.Canada.Flags.Add(new CountryFlag
        {
            Names = new List<FlagName>
            {
                "Canadian flag",
                "Maple Leaf",
                new()
                {
                    NativeName = "l'Unifolié",
                    EnglishTranslation = "the one-leafed"
                }
            },
            Description = "A vertical triband of red (hoist-side and fly-side) and white (double width) with the red maple leaf centered on the white band.",
            StartDate = new FlagDate(1965, 02, 15),
            DesignedBy = "George F. G. Stanley",
            Usage = FlagUsage.NationalFlag | FlagUsage.CivilEnsign | FlagUsage.StateEnsign
        });
    }

    public static void CaymanIslands()
    {
        Countries.CaymanIslands.Flags.Add(new CountryFlag
        {
            Description = "A British blue ensign with the coat of arms of the Cayman Islands in the fly.",
            StartDate = new FlagDate(1999),
            Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag | FlagUsage.StateEnsign
        });
    }

    public static void CentralAfricanRepublic()
    {
        Countries.CentralAfricanRepublic.Flags.Add(new CountryFlag
        {
            Description = "Four horizontal stripes of blue, white, green and yellow intersected by one vertical stripe of red in the middle; with a yellow five-pointed star in the canton.",
            StartDate = new DateTime(1958, 12, 01),
            DesignedBy = "Barthélemy Boganda",
            Usage = FlagUsage.NationalFlag
        });
    }

    public static void Chad()
    {
        Countries.Chad.Flags.Add(new CountryFlag
        {
            Names = new List<FlagName>
            {
                "Drapeau du Tchad",
                "علم تشاد",
                "Les trois barres"
            },
            Description = "The flag of Chad is a vertical tricolour consisting (left to right) of a blue, a gold and a red column. These were intended to be a combination of the colours of blue, white and red as seen on the Flag of France with the Pan-African colours of green, yellow and red. Furthermore, the blue represents the sky and hope; the gold is the sun and desert, and the red signifies the bloodshed over independence.",
            StartDate = new FlagDate(1959, 11, 06),
            Usage = FlagUsage.NationalFlag
        });
    }

    public static void Chile()
    {
        Countries.Chile.Flags.Add(new CountryFlag
        {
            Names = new List<FlagName>
            {
                new()
                {
                    NativeName = "La Estrella Solitaria",
                    EnglishTranslation = "The Lone Star",
                }
            },
            Description = "A horizontal bicolor of white and red with the blue square ended on the upper hoist-side corner of the white band bearing the white five-pointed star in the center.",
            StartDate = new FlagDate(1817, 10, 18),
            DesignedBy = "Ignacio Zenteno or Gregorio de Andía y Varela.",
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void China()
    {
        Countries.China.Flags.Add(new CountryFlag
        {
            Names = new List<FlagName>
            {
                new()
                {
                    NativeName = "五星红旗",
                    EnglishTranslation = "Five-star Red Flag"
                }
            },
            Description = "A large golden star within an arc of four smaller golden stars, in the canton, on a field of Chinese red.",
            StartDate = new FlagDate(1949, 09, 27),
            DesignedBy = "Zeng Liansong",
            Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag | FlagUsage.CivilEnsign | FlagUsage.StateEnsign
        });
    }

    public static void ChristmasIsland()
    {
        Countries.ChristmasIsland.Flags.Add(new CountryFlag
        {
            Description = "Blue and green diagonal bicolour charged with a southern cross of four seven-pointed white stars and one smaller five-pointed white star on the blue half, a golden bosun bird in gold on the green half, and a gold circle in the centre containing the shape of the island in green.",
            StartDate = new FlagDate(2002, 02, 26),
            Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag
        });
    }

    public static void CocosIslands()
    {
        Countries.CocosIslands.Flags.Add(new CountryFlag
        {
            Description = "Green, with a palm tree on a gold disc in the canton, a gold crescent in the centre of the flag and a gold southern cross in the fly.",
            StartDate = new FlagDate(2004, 04, 06),
            DesignedBy = "Mohammed Minkom",
            Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag
        });
    }

    public static void Colombia()
    {
        Countries.Colombia.Flags.Add(new CountryFlag
        {
            Names = new List<FlagName>
            {
                new()
                {
                    NativeName = "El Tricolor Nacional",
                    EnglishTranslation = "The National Tricolor"
                }
            },
            Description = "A horizontal tricolour of yellow (double-width), blue and red.",
            StartDate = new FlagDate(1861, 11, 26),
            Usage = FlagUsage.NationalFlag | FlagUsage.StateEnsign
        });
    }

    public static void Comoros()
    {
        Countries.Comoros.Flags.Add(new CountryFlag
        {
            Description = "Four horizontal stripes of yellow, white, red and blue (from top to bottom); with a green chevron based on the hoist side charged with a white crescent and four five-pointed stars.",
            StartDate = new FlagDate(2001, 12, 23),
            Usage = FlagUsage.NationalFlag
        });
    }

    public static void Congo_Republic()
    {
        Countries.Congo_Republic.Flags.Add(new CountryFlag
        {
            Description = "A diagonal tricolour of green, yellow and red radiating from the lower hoist side corner.",
            StartDate = new FlagDate(1959, 09, 15),
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void Congo_DemocraticRepublic()
    {
        Countries.Congo_DemocraticRepublic.Flags.Add(new CountryFlag
        {
            Description = "A sky blue field with a yellow five-pointed star in the canton and cut yellow-fimbriated red diagonal band from the lower hoist-side to the upper fly-side.",
            StartDate = new FlagDate(2006, 02, 20),
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void CookIslands()
    {
        Countries.CookIslands.Flags.Add(new CountryFlag
        {
            Description = "Blue ensign with a ring of fifteen white stars in the fly.",
            StartDate = new FlagDate(1979, 08, 04),
            Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag
        });
    }

    public static void CostaRica()
    {
        Countries.CostaRica.Flags.Add(new CountryFlag
        {
            Description = "Five horizontal bands of blue, white, and red (double width).",
            StartDate = new FlagDate(1848, 09, 29),
            DesignedBy = "Pacífica Fernández",
            Usage = FlagUsage.NationalFlag | FlagUsage.CivilEnsign
        });
    }

    public static void IvoryCoast()
    {
        Countries.IvoryCoast.Flags.Add(new CountryFlag
        {
            Description = "A vertical tricolor of orange, white, and green.",
            StartDate = new FlagDate(1959, 12, 03),
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void Croatia()
    {
        Countries.Croatia.Flags.Add(new CountryFlag
        {
            Names = new List<FlagName>
            {
                new()
                {
                    NativeName = "Trobojnica",
                    EnglishTranslation = "The Tricolour"
                }
            },
            Description = "A horizontal tricolour of red, white, and blue with the Coat of Arms of Croatia in the centre.",
            StartDate = new FlagDate(1990, 12, 21),
            DesignedBy = "Miroslav Šutej",
            Usage = FlagUsage.NationalFlag
        });
    }

    public static void Cuba()
    {
        Countries.Cuba.Flags.Add(new CountryFlag
        {
            Description = "Five horizontal stripes of blue alternate with white with the red equilateral triangle based on the hoist-side bearing the white five-pointed star in the center.",
            StartDate = new FlagDate(1902, 05, 20),
            DesignedBy = new StringList
            {
                "Miguel Teurbe Tolón",
                "Narciso López"
            },
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void Curacao()
    {
        Countries.Curacao.Flags.Add(new CountryFlag
        {
            StartDate = new FlagDate(1984, 07, 02)
        });
    }

    public static void Cyprus()
    {
        Countries.Cyprus.Flags.Add(new CountryFlag
        {
            Description = "An outline of the island of Cyprus in copper above two green olive branches on a white field.",
            StartDate = new FlagDate(2006, 04, 24),
            DesignedBy = "İsmet Güney",
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void Czechia()
    {
        Countries.Czechia.Flags.Add(new CountryFlag
        {
            Names = new List<FlagName>
            {
                new()
                {
                    NativeName = "Státní vlajka České republiky",
                    EnglishTranslation = "National flag of the Czech Republic"
                }
            },
            Description = "Two equal horizontal bands of white (top) and red with a blue isosceles triangle based on the hoist side.",
            StartDate = new FlagDate(1993, 03, 30),
            DesignedBy = "Jaroslav Kursa",
            Usage = FlagUsage.CivilAndStateFlag | FlagUsage.NationalEnsign
        });
    }
}