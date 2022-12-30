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

namespace DustInTheWind.Flags.CountryFlags;

public static partial class Countries
{
    public static Country CaboVerde { get; } = new()
    {
        ShortName = "Cabo Verde",
        FullName = "Republic of Cabo Verde",
        IsoCodeAlpha2 = "CV",
        IsoCodeAlpha3 = "CPV",
        IsoCodeNumeric = "132",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "Five unequal horizontal bands of blue (six-twelfths), white, red, white (each of the bands are one-twelfth) and blue (three-twelfths) with the circle of ten yellow five-pointed stars centered on the red stripe and positioned three-eighths of the length of the flag from the hoist-side.",
                StartDate = new DateTime(1992, 09, 22),
                Usage = FlagUsage.NationalFlagAndEnsign
            }
        }
    };

    public static Country Cambodia { get; } = new()
    {
        ShortName = "Cambodia",
        FullName = "Kingdom of Cambodia",
        IsoCodeAlpha2 = "KH",
        IsoCodeAlpha3 = "KHM",
        IsoCodeNumeric = "116",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "Three horizontal bands of blue, red (double width) and blue, with a depiction of Angkor Wat in white centred on the red band.",
                StartDate = new DateTime(1948, 01, 01),
                Usage = FlagUsage.NationalFlagAndEnsign
            }
        }
    };

    public static Country Cameroon { get; } = new()
    {
        ShortName = "Cameroon",
        FullName = "Republic of Cameroon",
        IsoCodeAlpha2 = "CM",
        IsoCodeAlpha3 = "CMR",
        IsoCodeNumeric = "120",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A vertical tricolour of green, red and yellow, with a gold star centred on the red band.",
                StartDate = new DateTime(1975, 05, 20),
                Usage = FlagUsage.NationalFlagAndEnsign
            }
        }
    };

    public static Country Canada { get; } = new()
    {
        ShortName = "Canada",
        FullName = "Canada",
        IsoCodeAlpha2 = "CA",
        IsoCodeAlpha3 = "CAN",
        IsoCodeNumeric = "124",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Names = new List<string>
                {
                    "Canadian flag",
                    "Maple Leaf"
                },
                Description = "A vertical triband of red (hoist-side and fly-side) and white (double width) with the red maple leaf centered on the white band.",
                StartDate = new DateTime(1965, 02, 15),
                DesignedBy = "George F. G. Stanley",
                Usage = FlagUsage.NationalFlag | FlagUsage.CivilEnsign | FlagUsage.StateEnsign
            }
        }
    };

    public static Country CaymanIslands { get; } = new()
    {
        ShortName = "Cayman Islands",
        FullName = "Cayman Islands",
        IsoCodeAlpha2 = "KY",
        IsoCodeAlpha3 = "CYM",
        IsoCodeNumeric = "136",
        IsIndependent = false,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A British blue ensign with the coat of arms of the Cayman Islands in the fly.",
                StartDate = new DateTime(1999, 01, 01),
                Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag | FlagUsage.StateEnsign
            },
            new()
            {
                Id = "CivilEnsign",
                StartDate = new DateTime(1999, 01, 01),
                Usage = FlagUsage.CivilEnsign
            },
            new()
            {
                Id = "Governor",
                StartDate = new DateTime(1999, 01, 01),
                Usage = FlagUsage.LeaderFlag
            },
            new()
            {
                Id = "Old1958",
                StartDate = new DateTime(1958, 01, 01),
                EndDate = new DateTime(1999, 01, 01),
                Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag | FlagUsage.StateEnsign
            }
        }
    };

    public static Country CentralAfricanRepublic { get; } = new()
    {
        ShortName = "Central African Republic",
        FullName = "Central African Republic",
        IsoCodeAlpha2 = "CF",
        IsoCodeAlpha3 = "CAF",
        IsoCodeNumeric = "140",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "Four horizontal stripes of blue, white, green and yellow intersected by one vertical stripe of red in the middle; with a yellow five-pointed star in the canton.",
                StartDate = new DateTime(1958, 12, 01),
                DesignedBy = "Barthélemy Boganda",
                Usage = FlagUsage.NationalFlag
            }
        }
    };

    public static Country Chad { get; } = new()
    {
        ShortName = "Chad",
        FullName = "Republic of Chad",
        IsoCodeAlpha2 = "TD",
        IsoCodeAlpha3 = "TCD",
        IsoCodeNumeric = "148",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Names = new List<string>
                {
                    "Les trois barres"
                },
                Description = "A vertical tricolor of blue, gold, and red.",
                StartDate = new DateTime(1959, 11, 06),
                Usage = FlagUsage.NationalFlag
            }
        }
    };

    public static Country Chile { get; } = new()
    {
        ShortName = "Chile",
        FullName = "Republic of Chile",
        IsoCodeAlpha2 = "CL",
        IsoCodeAlpha3 = "CHL",
        IsoCodeNumeric = "152",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A horizontal bicolor of white and red with the blue square ended on the upper hoist-side corner of the white band bearing the white five-pointed star in the center.",
                StartDate = new DateTime(1817, 10, 18),
                DesignedBy = "Ignacio Zenteno or Gregorio de Andía y Varela.",
                Usage = FlagUsage.NationalFlagAndEnsign
            },
            new()
            {
                Id = "President",
                Description = "Same design as the National Flag with the National Coat of Arms superimposed at the center.",
                DesignedBy = "Alfonso Martinez Delpelao",
                Usage = FlagUsage.LeaderFlag
            }
        }
    };

    public static Country China { get; } = new()
    {
        ShortName = "China",
        FullName = "People's Republic of China",
        IsoCodeAlpha2 = "CN",
        IsoCodeAlpha3 = "CHN",
        IsoCodeNumeric = "156",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A large golden star within an arc of four smaller golden stars, in the canton, on a field of Chinese red.",
                StartDate = new DateTime(1949, 09, 27),
                DesignedBy = "Zeng Liansong",
                Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag | FlagUsage.CivilEnsign | FlagUsage.StateEnsign
            },
            new()
            {
                Id = "WarFlag",
                Description = "A Chinese red field with a yellow star and Chinese numerals \"八一\", referencing 1 August, at the canton.",
                StartDate = new DateTime(1949, 06, 15),
                Usage = FlagUsage.WarFlag | FlagUsage.NavalJack
            }
        }
    };

    public static Country ChristmasIsland { get; } = new()
    {
        ShortName = "Christmas Island",
        FullName = "Territory of Christmas Island",
        IsoCodeAlpha2 = "CX",
        IsoCodeAlpha3 = "CXR",
        IsoCodeNumeric = "162",
        IsIndependent = false,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "Blue and green diagonal bicolour charged with a southern cross of four seven-pointed white stars and one smaller five-pointed white star on the blue half, a golden bosun bird in gold on the green half, and a gold circle in the centre containing the shape of the island in green.",
                StartDate = new DateTime(2002, 02, 26),
                Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag
            }
        }
    };

    public static Country CocosIslands { get; } = new()
    {
        ShortName = "Cocos (Keeling) Islands",
        FullName = "Territory of Cocos (Keeling) Islands",
        IsoCodeAlpha2 = "CC",
        IsoCodeAlpha3 = "CCK",
        IsoCodeNumeric = "166",
        IsIndependent = false,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "Green, with a palm tree on a gold disc in the canton, a gold crescent in the centre of the flag and a gold southern cross in the fly.",
                StartDate = new DateTime(2004, 04, 06),
                DesignedBy = "Mohammed Minkom",
                Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag
            }
        }
    };

    public static Country Colombia { get; } = new()
    {
        ShortName = "Colombia",
        FullName = "Republic of Colombia",
        IsoCodeAlpha2 = "CO",
        IsoCodeAlpha3 = "COL",
        IsoCodeNumeric = "170",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Names = new List<string>
                {
                    "El Tricolor Nacional",
                    "The National Tricolor"
                },
                Description = "A horizontal tricolour of yellow (double-width), blue and red.",
                StartDate = new DateTime(1861, 11, 26),
                Usage = FlagUsage.NationalFlag | FlagUsage.StateEnsign
            },
            new()
            {
                Id = "CivilEnsign",
                Description = "The national flag defaced in the centre with a blue ellipse outlined in red and an eight-pointed white star.",
                Usage = FlagUsage.CivilEnsign
            },
            new()
            {
                Id = "NavalEnsign",
                Description = "The national flag defaced in the centre with a white circle outlined in red and the coat of arms of Colombia.",
                Usage = FlagUsage.WarEnsign
            }
        }
    };

    public static Country Comoros { get; } = new()
    {
        ShortName = "Comoros",
        FullName = "Union of the Comoros",
        IsoCodeAlpha2 = "KM",
        IsoCodeAlpha3 = "COM",
        IsoCodeNumeric = "174",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "Four horizontal stripes of yellow, white, red and blue (from top to bottom); with a green chevron based on the hoist side charged with a white crescent and four five-pointed stars.",
                StartDate = new DateTime(2001, 12, 23),
                Usage = FlagUsage.NationalFlag
            }
        }
    };

    public static Country Congo_Republic { get; } = new()
    {
        ShortName = "Republic of the Congo",
        FullName = "Republic of the Congo",
        IsoCodeAlpha2 = "CG",
        IsoCodeAlpha3 = "COG",
        IsoCodeNumeric = "178",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A diagonal tricolour of green, yellow and red radiating from the lower hoist side corner.",
                StartDate = new DateTime(1959, 09, 15),
                Usage = FlagUsage.NationalFlagAndEnsign
            }
        }
    };

    public static Country Congo_DemocraticRepublic { get; } = new()
    {
        ShortName = "Democratic Republic of the Congo",
        FullName = "Democratic Republic of the Congo",
        IsoCodeAlpha2 = "CD",
        IsoCodeAlpha3 = "COD",
        IsoCodeNumeric = "180",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A sky blue field with a yellow five-pointed star in the canton and cut yellow-fimbriated red diagonal band from the lower hoist-side to the upper fly-side.",
                StartDate = new DateTime(2006, 02, 20),
                Usage = FlagUsage.NationalFlagAndEnsign
            },
            new()
            {
                Id = "President",
                Description = "National flag with the addition of the inscription \"Le President\"",
                StartDate = new DateTime(2006, 02, 20),
                Usage = FlagUsage.LeaderFlag
            }
        }
    };

    public static Country CookIslands { get; } = new()
    {
        ShortName = "Cook Islands",
        FullName = "Cook Islands",
        IsoCodeAlpha2 = "CK",
        IsoCodeAlpha3 = "COK",
        IsoCodeNumeric = "184",
        IsIndependent = false,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "Blue ensign with a ring of fifteen white stars in the fly.",
                StartDate = new DateTime(1979, 08, 04),
                Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag
            },
            new()
            {
                Id = "King",
                Usage = FlagUsage.LeaderFlag
            }
        }
    };

    public static Country CostaRica { get; } = new()
    {
        ShortName = "Costa Rica",
        FullName = "Republic of Costa Rica",
        IsoCodeAlpha2 = "CR",
        IsoCodeAlpha3 = "CRI",
        IsoCodeNumeric = "188",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "Five horizontal bands of blue, white, and red (double width).",
                StartDate = new DateTime(1848, 09, 29),
                DesignedBy = "Pacífica Fernández",
                Usage = FlagUsage.NationalFlag | FlagUsage.CivilEnsign
            },
            new()
            {
                Id = "StateAndWar",
                Description = "Five horizontal bands of blue, white, and red (double width), with the coat of arms offcenter to the left.",
                StartDate = new DateTime(1906, 11, 27),
                DesignedBy = "Pacífica Fernández",
                Usage = FlagUsage.StateFlag | FlagUsage.WarFlag | FlagUsage.StateEnsign | FlagUsage.WarEnsign
            }
        }
    };

    public static Country IvoryCoast { get; } = new()
    {
        ShortName = "Côte d'Ivoire",
        FullName = "Republic of Côte d'Ivoire",
        IsoCodeAlpha2 = "CI",
        IsoCodeAlpha3 = "CIV",
        IsoCodeNumeric = "384",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A vertical tricolor of orange, white, and green.",
                StartDate = new DateTime(1959, 12, 03),
                Usage = FlagUsage.NationalFlagAndEnsign
            }
        }
    };

    public static Country Croatia { get; } = new()
    {
        ShortName = "Croatia",
        FullName = "Republic of Croatia",
        IsoCodeAlpha2 = "HR",
        IsoCodeAlpha3 = "HRV",
        IsoCodeNumeric = "191",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Names = new List<string>
                {
                    "Trobojnica",
                    "The Tricolour"
                },
                Description = "A horizontal tricolour of red, white, and blue with the Coat of Arms of Croatia in the centre.",
                StartDate = new DateTime(1990, 12, 21),
                DesignedBy = "Miroslav Šutej",
                Usage = FlagUsage.NationalFlag
            },
            new()
            {
                Id = "Ensign",
                Description = "Three equal horizontal bands of red (top), white and blue superimposed by the Croatian coat of arms.",
                StartDate = new DateTime(1992, 01, 01),
                Usage = FlagUsage.CivilEnsign | FlagUsage.StateEnsign
            },
            new()
            {
                Id = "NavalEnsign",
                Description = "Three equal horizontal bands of red (top), white and blue superimposed by the emblem of the Croatian Navy.",
                StartDate = new DateTime(1992, 01, 01),
                Usage = FlagUsage.WarEnsign
            }
        }
    };

    public static Country Cuba { get; } = new()
    {
        ShortName = "Cuba",
        FullName = "Republic of Cuba",
        IsoCodeAlpha2 = "CU",
        IsoCodeAlpha3 = "CUB",
        IsoCodeNumeric = "192",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "Five horizontal stripes of blue alternate with white with the red equilateral triangle based on the hoist-side bearing the white five-pointed star in the center.",
                StartDate = new DateTime(1902, 05, 20),
                DesignedBy = "Miguel Teurbe Tolón, Narciso López",
                Usage = FlagUsage.NationalFlagAndEnsign
            },
            new()
            {
                Id = "President",
                Usage = FlagUsage.LeaderFlag
            },
            new()
            {
                Id = "NavalJack",
                Usage = FlagUsage.NavalJack
            }
        }
    };

    public static Country Curacao { get; } = new()
    {
        ShortName = "Curaçao",
        FullName = "Country of Curaçao",
        IsoCodeAlpha2 = "CW",
        IsoCodeAlpha3 = "CUW",
        IsoCodeNumeric = "531",
        IsIndependent = false,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                StartDate = new DateTime(1984, 07, 02)
            },
            new()
            {
                Id = "Governor",
                StartDate = new DateTime(1984, 07, 02),
                Usage = FlagUsage.LeaderFlag
            }
        }
    };

    public static Country Cyprus { get; } = new()
    {
        ShortName = "Cyprus",
        FullName = "Republic of Cyprus",
        IsoCodeAlpha2 = "CY",
        IsoCodeAlpha3 = "CYP",
        IsoCodeNumeric = "196",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "An outline of the island of Cyprus in copper above two green olive branches on a white field.",
                StartDate = new DateTime(2006, 04, 24),
                DesignedBy = "İsmet Güney",
                Usage = FlagUsage.NationalFlagAndEnsign
            }
        }
    };

    public static Country Czechia { get; } = new()
    {
        ShortName = "Czechia",
        FullName = "Czech Republic",
        IsoCodeAlpha2 = "CZ",
        IsoCodeAlpha3 = "CZE",
        IsoCodeNumeric = "203",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "Two equal horizontal bands of white (top) and red with a blue isosceles triangle based on the hoist side.",
                StartDate = new DateTime(1993, 03, 30),
                DesignedBy = "Jaroslav Kursa",
                Usage = FlagUsage.NationalEnsign | FlagUsage.CivilEnsign | FlagUsage.StateEnsign
            }
        }
    };
}