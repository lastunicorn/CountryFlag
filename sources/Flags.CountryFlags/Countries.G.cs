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
    public static Country Gabon { get; } = new()
    {
        ShortName = "Gabon",
        FullName = "Gabonese Republic",
        IsoCodeAlpha2 = "GA",
        IsoCodeAlpha3 = "GAB",
        IsoCodeNumeric = "266",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A horizontal triband of green, gold and blue.",
                StartDate = new DateTime(1960, 08, 17)
            },
            new()
            {
                Id = "President",
                StartDate = new DateTime(2016, 01, 01),
                Usage = FlagUsage.LeaderFlag
            }
        }
    };

    public static Country Gambia { get; } = new()
    {
        ShortName = "Gambia",
        FullName = "Republic of The Gambia",
        IsoCodeAlpha2 = "GM",
        IsoCodeAlpha3 = "GMB",
        IsoCodeNumeric = "270",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A horizontal tricolor of red, blue and green; each band of colour is separated by a narrow band of white.",
                StartDate = new DateTime(1965, 02, 18),
                DesignedBy = "Louis Thomasi",
                Usage = FlagUsage.NationalFlagAndEnsign
            },
            new()
            {
                Id = "President",
                Names = new List<FlagName>
                {
                    "Standard of the President"
                },
                Description = "A blue flag with the national coat of arms charged in the center."
            }
        }
    };

    public static Country Georgia { get; } = new()
    {
        ShortName = "Georgia",
        FullName = "Georgia",
        IsoCodeAlpha2 = "GE",
        IsoCodeAlpha3 = "GEO",
        IsoCodeNumeric = "268",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A white field with a centred red cross; a red Bolnur-Katskhuri cross centres each quarter.",
                StartDate = new DateTime(2004, 01, 14),
                Usage = FlagUsage.NationalFlag | FlagUsage.CivilEnsign | FlagUsage.StateEnsign
            },
            new()
            {
                Id = "President",
                Names = new List<FlagName>
                {
                    "Presidential Standard"
                },
                Usage = FlagUsage.LeaderFlag
            },
            new()
            {
                Id = "MinisterOfDefence",
                Names = new List<FlagName>
                {
                    "Flag of the Minister of Defence"
                },
                Usage = FlagUsage.Other
            },
            new()
            {
                Id = "ChiefGeneralStaff",
                Names = new List<FlagName>
                {
                    "Chief of the General Staff"
                },
                Usage = FlagUsage.Other
            },
            new ()
            {
                Id = "WarFlag",
                Names = new List<FlagName>
                {
                    "War flag of Georgia"
                },
                Usage = FlagUsage.WarFlag
            },
            new ()
            {
                Id = "NavalEnsign",
                Names = new List<FlagName>
                {
                    "Naval ensign"
                },
                Description = "A dark blue field with a centred red cross with a white cross overlaid over it.",
                Usage = FlagUsage.WarEnsign
            }
        }
    };

    public static Country Germany { get; } = new()
    {
        ShortName = "Germany",
        FullName = "Federal Republic of Germany",
        IsoCodeAlpha2 = "DE",
        IsoCodeAlpha3 = "DEU",
        IsoCodeNumeric = "276",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A horizontal tricolour of black, red, and gold.",
                StartDate = new DateTime(1949, 05, 23),
                Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag | FlagUsage.CivilEnsign
            },
            new()
            {
                Id = "StateFlag",
                Description = "The civil flag with the coat of arms at the centre.",
                StartDate = new DateTime(1950, 06, 07),
                Usage = FlagUsage.StateFlag | FlagUsage.WarFlag | FlagUsage.StateEnsign
            },
            new()
            {
                Id = "NavalEnsign",
                Description = "A swallowtail of the civil flag with the coat of arms at the centre.",
                StartDate = new DateTime(1956, 05, 25),
                Usage = FlagUsage.WarEnsign
            }
        }
    };

    public static Country Ghana { get; } = new()
    {
        ShortName = "Ghana",
        FullName = "Republic of Ghana",
        IsoCodeAlpha2 = "GH",
        IsoCodeAlpha3 = "GHA",
        IsoCodeNumeric = "288",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A horizontal triband of red, gold, and green, charged with a black star in the centre.",
                StartDate = new DateTime(1957, 01, 01),
                DesignedBy = "Theodosia Okoh",
                Usage = FlagUsage.NationalFlag | FlagUsage.CivilEnsign | FlagUsage.StateEnsign
            },
            new()
            {
                Id = "CivilEnsign",
                Description = "A red field with the national flag, fimbriated in black, in the canton.",
                Usage = FlagUsage.CivilEnsign
            },
            new()
            {
                Id = "NavalEnsign",
                Description = "Red St. George's Cross on white centrrensign, with the national flag in canton.",
                Usage = FlagUsage.WarEnsign
            }
        }
    };

    public static Country Gibraltar { get; } = new()
    {
        ShortName = "Gibraltar",
        FullName = "Gibraltar",
        IsoCodeAlpha2 = "GI",
        IsoCodeAlpha3 = "GIB",
        IsoCodeNumeric = "292",
        IsIndependent = false,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "White with a red stripe at the bottom with a three-towered, two-tiered red castle in the white section. Each tower has a door and a window and from the door of the middle tower hangs a gold key which mainly overlaps the red stripe.",
                StartDate = new DateTime(1982, 11, 08),
                Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag
            },
            new()
            {
                Id = "Union",
                Description = "Flag of the United Kingdom",
                Usage = FlagUsage.Other
            },
            new()
            {
                Id = "StateEnsign",
                Description = "Blue Ensign with the Union Flag in the canton and the badge of Gibraltar in the fly.",
                StartDate = new DateTime(1998, 01, 01),
                Usage = FlagUsage.StateEnsign
            },
            new()
            {
                Id = "CivilEnsign",
                Names = new List<FlagName>
                {
                    "Civil ensign of Gibraltar"
                },
                Description = "Red Ensign with the Union Flag in the canton and the badge of Gibraltar in the fly.",
                StartDate = new DateTime(1998, 01, 01),
                Usage = FlagUsage.CivilEnsign
            },
            new()
            {
                Id = "Governor",
                Names = new List<FlagName>
                {
                    "Flag of the Governor of Gibraltar"
                },
                Description = "A Union Flag defaced with the coat of arms.",
                Usage = FlagUsage.LeaderFlag
            }
        }
    };

    public static Country Greece { get; } = new()
    {
        ShortName = "Greece",
        FullName = "Hellenic Republic",
        IsoCodeAlpha2 = "GR",
        IsoCodeAlpha3 = "GRC",
        IsoCodeNumeric = "300",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
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
                StartDate = new DateTime(1978, 12, 22),
                Usage = FlagUsage.NationalFlagAndEnsign
            }
        }
    };

    public static Country Greenland { get; } = new()
    {
        ShortName = "Greenland",
        FullName = "Greenland",
        IsoCodeAlpha2 = "GL",
        IsoCodeAlpha3 = "GRL",
        IsoCodeNumeric = "304",
        IsIndependent = false,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Names = new List<FlagName>
                {
                    new ()
                    {
                        NativeName = "Erfalasorput",
                        EnglishTranslation = "our flag"
                    },
                    new ()
                    {
                        NativeName = "Aappalaartoq",
                        EnglishTranslation = "the red"
                    }
                },
                Description = "A horizontal bicolour of white and red, with a counterchanged disk slightly off-centre towards the hoist.",
                StartDate = new DateTime(1985, 06, 21),
                DesignedBy = "Thue Christiansen",
                Usage = FlagUsage.NationalFlag | FlagUsage.CivilEnsign
            }
        }
    };

    public static Country Grenada { get; } = new()
    {
        ShortName = "Grenada",
        FullName = "Grenada",
        IsoCodeAlpha2 = "GD",
        IsoCodeAlpha3 = "GRD",
        IsoCodeNumeric = "308",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A rectangle divided diagonally into two yellow triangles at the top and bottom and two green triangles at the hoist and fly, surrounded by a red border charged with six five pointed yellow stars, another five-pointed yellow star on a red disc at the centre, and a nutmeg at the hoist.",
                StartDate = new DateTime(1974, 02,07),
                DesignedBy = "Anthony C. George",
                Usage = FlagUsage.NationalFlag
            },
            new()
            {
                Id = "CivilEnsign",
                Names = new List<FlagName>
                {
                    "Civil ensign"
                },
                Usage = FlagUsage.CivilEnsign
            },
            new()
            {
                Id = "NavalEnsign",
                Names = new List<FlagName>
                {
                    "Naval ensign"
                },
                Usage = FlagUsage.WarEnsign
            }
        }
    };

    public static Country Guadeloupe { get; } = new()
    {
        ShortName = "Guadeloupe",
        FullName = "Guadeloupe",
        IsoCodeAlpha2 = "GP",
        IsoCodeAlpha3 = "GLP",
        IsoCodeNumeric = "312",
        IsIndependent = false,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
            }
        }
    };

    public static Country Guam { get; } = new()
    {
        ShortName = "Guam",
        FullName = "Guam",
        IsoCodeAlpha2 = "GU",
        IsoCodeAlpha3 = "GUM",
        IsoCodeNumeric = "316",
        IsIndependent = false,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A dark blue background with a thin red border and the Seal in the center.",
                StartDate = new DateTime(1948, 02, 09),
                Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag
            }
        }
    };

    public static Country Guatemala { get; } = new()
    {
        ShortName = "Guatemala",
        FullName = "Republic of Guatemala",
        IsoCodeAlpha2 = "GT",
        IsoCodeAlpha3 = "GTM",
        IsoCodeNumeric = "320",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A vertical triband of Maya blue (hoist-side and fly-side) and white with the National Emblem centered on the white band.",
                StartDate = new DateTime(1871, 01,01),
                Usage = FlagUsage.StateFlag | FlagUsage.WarFlag | FlagUsage.StateEnsign | FlagUsage.WarEnsign
            },
            new()
            {
                Id = "Civil",
                Description = "A vertical triband of Maya blue (hoist-side and fly-side) and white.",
                StartDate = new DateTime(1871, 01, 01),
                Usage = FlagUsage.CivilFlag | FlagUsage.CivilEnsign
            }
        }
    };

    public static Country Guernsey { get; } = new()
    {
        ShortName = "Guernsey",
        FullName = "Guernsey",
        IsoCodeAlpha2 = "GG",
        IsoCodeAlpha3 = "GGY",
        IsoCodeNumeric = "831",
        IsIndependent = false,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
            }
        }
    };

    public static Country Guinea { get; } = new()
    {
        ShortName = "Guinea",
        FullName = "Republic of Guinea",
        IsoCodeAlpha2 = "GN",
        IsoCodeAlpha3 = "GIN",
        IsoCodeNumeric = "324",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A vertical tricolour of red, yellow and green.",
                StartDate = new DateTime(1958, 11, 10),
                Usage = FlagUsage.NationalFlagAndEnsign
            },
            new()
            {
                Id = "President",
                Names = new List<FlagName>
                {
                    "Presidential standard"
                },
                Usage = FlagUsage.LeaderFlag
            }
        }
    };

    public static Country GuineaBissau { get; } = new()
    {
        ShortName = "Guinea-Bissau",
        FullName = "Republic of Guinea-Bissau",
        IsoCodeAlpha2 = "GW",
        IsoCodeAlpha3 = "GNB",
        IsoCodeNumeric = "624",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "One vertical red line on the hoist side charged with a black five-pointed star; two horizontal lines on the fly side (yellow and green).",
                StartDate = new DateTime(1973, 09, 24),
                Usage = FlagUsage.NationalFlagAndEnsign
            }
        }
    };

    public static Country Guyana { get; } = new()
    {
        ShortName = "Guyana",
        FullName = "Co‑operative Republic of Guyana",
        IsoCodeAlpha2 = "GY",
        IsoCodeAlpha3 = "GUY",
        IsoCodeNumeric = "328",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Names = new List<FlagName>
                {
                    "The Golden Arrowhead"
                },
                Description = "A green field with the black-edged red isosceles triangle based on the hoist-side superimposed on the larger white-edged golden triangle, also based on the hoist-side, pointed toward the fly-side.",
                StartDate = new DateTime(1966, 05, 26),
                DesignedBy = "Whitney Smith",
                Usage = FlagUsage.NationalFlag
            },
            new()
            {
                Id = "Ensign",
                Names = new List<FlagName>
                {
                    "National ensign"
                },
                Description = "An elongated version of the above.",
                Usage = FlagUsage.NationalEnsign
            },
            new ()
            {
                Id = "Air",
                Names = new List<FlagName>
                {
                    "Civil air ensign"
                },
                Description = "British Civil Air Ensign combined with national flag of Guyana. May be flown at airports and from landed aircraft.",
                Usage = FlagUsage.AirForceEnsign
            }
        }
    };
}