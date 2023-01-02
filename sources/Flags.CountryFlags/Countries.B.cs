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

namespace DustInTheWind.Flags.CountryFlags;

public static partial class Countries
{
    public static Country Bahamas { get; } = new()
    {
        ShortName = "Bahamas",
        FullName = "Commonwealth of The Bahamas",
        IsoCodeAlpha2 = "BS",
        IsoCodeAlpha3 = "BHS",
        IsoCodeNumeric = "044",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A horizontal triband of aquamarine (top and bottom) and gold with the black chevron aligned to the hoist-side.",
                StartDate = new DateTime(1973, 07, 10),
                DesignedBy = "Dr. Hervis Bain",
                Usage = FlagUsage.NationalFlag
            },
            new()
            {
                Id = "CivilEnsign",
                Description = "A white cross on a red field, the national flag in the canton.",
                Usage = FlagUsage.CivilEnsign
            },
            new()
            {
                Id = "StateEnsign",
                Description = "A blue cross on a white field, the national flag in the canton.",
                Usage = FlagUsage.StateEnsign
            },
            new()
            {
                Id = "WarEnsign",
                Description = "A red cross on a white field, the national flag in the canton.",
                Usage = FlagUsage.WarEnsign
            }
        }
    };

    public static Country Bahrain { get; } = new()
    {
        ShortName = "Bahrain",
        FullName = "Kingdom of Bahrain",
        IsoCodeAlpha2 = "BH",
        IsoCodeAlpha3 = "BHR",
        IsoCodeNumeric = "048",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A white field on the hoist side separated from a larger red field on the fly by five white triangles in the form of a zigzag pattern.",
                StartDate = new DateTime(2002, 02, 14),
                Usage = FlagUsage.NationalFlagAndEnsign
            }
        }
    };

    public static Country Bangladesh { get; } = new()
    {
        ShortName = "Bangladesh",
        FullName = "People's Republic of Bangladesh",
        IsoCodeAlpha2 = "BD",
        IsoCodeAlpha3 = "BGD",
        IsoCodeNumeric = "050",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A red disc slightly off center to the left defacing a dark green banner.",
                StartDate = new DateTime(1972, 01, 17),
                DesignedBy = "Quamrul Hassan",
                Usage = FlagUsage.NationalFlag
            }
        }
    };

    public static Country Barbados { get; } = new()
    {
        ShortName = "Barbados",
        FullName = "Barbados",
        IsoCodeAlpha2 = "BB",
        IsoCodeAlpha3 = "BRB",
        IsoCodeNumeric = "052",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A vertical triband of ultramarine (hoist-side and fly-side) and gold with the black trident-head centred on the gold band.",
                StartDate = new DateTime(1966, 11, 30),
                DesignedBy = "Grantley W. Prescod",
                Usage = FlagUsage.NationalFlag | FlagUsage.CivilEnsign | FlagUsage.StateEnsign
            }
        }
    };

    public static Country Belarus { get; } = new()
    {
        ShortName = "Belarus",
        FullName = "Republic of Belarus",
        IsoCodeAlpha2 = "BY",
        IsoCodeAlpha3 = "BLR",
        IsoCodeNumeric = "112",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A horizontal bicolour of red over green in a 2:1 ratio, with a red ornamental pattern on a white vertical stripe at the hoist.",
                StartDate = new DateTime(1951, 12, 25),
                DesignedBy = "Mikhail Husyev",
                Usage = FlagUsage.NationalFlagAndEnsign
            }
        }
    };

    public static Country Belgium { get; } = new()
    {
        ShortName = "Belgium",
        FullName = "Kingdom of Belgium",
        IsoCodeAlpha2 = "BE",
        IsoCodeAlpha3 = "BEL",
        IsoCodeNumeric = "056",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A vertical tricolour of black, yellow, and red.",
                StartDate = new DateTime(1831, 01, 23),
                Usage = FlagUsage.CivilEnsign
            }
        }
    };

    public static Country Belize { get; } = new()
    {
        ShortName = "Belize",
        FullName = "Belize",
        IsoCodeAlpha2 = "BZ",
        IsoCodeAlpha3 = "BLZ",
        IsoCodeNumeric = "084",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A royal blue field with two red narrow horizontal stripes along the top and the bottom edges and the large white disk in the centre bearing the National Coat of Arms.",
                StartDate = new DateTime(1981, 09, 21),
                Usage = FlagUsage.NationalFlagAndEnsign
            }
        }
    };

    public static Country Benin { get; } = new()
    {
        ShortName = "Benin",
        FullName = "Republic of Benin",
        IsoCodeAlpha2 = "BJ",
        IsoCodeAlpha3 = "BEN",
        IsoCodeNumeric = "204",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A horizontal bicolor of yellow and red with a green vertical band at the hoist.",
                StartDate = new DateTime(1959, 11, 16),
                Usage = FlagUsage.NationalFlagAndEnsign
            }
        }
    };

    public static Country Bermuda { get; } = new()
    {
        ShortName = "Bermuda",
        FullName = "Bermuda",
        IsoCodeAlpha2 = "BM",
        IsoCodeAlpha3 = "BMU",
        IsoCodeNumeric = "060",
        IsIndependent = false,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "Red Ensign with the coat-of-arms of Bermuda in the fly.",
                StartDate = new DateTime(1999, 01, 01),
                Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag | FlagUsage.CivilEnsign
            }
        }
    };

    public static Country Bhutan { get; } = new()
    {
        ShortName = "Bhutan",
        FullName = "Kingdom of Bhutan",
        IsoCodeAlpha2 = "BT",
        IsoCodeAlpha3 = "BTN",
        IsoCodeNumeric = "064",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "Divided diagonally from the lower hoist-side corner to the upper fly-side corner; the upper triangle is yellow and the lower triangle is orange, with a white dragon holding four jewels in its claws centered along the dividing line and facing away from the hoist.",
                StartDate = new DateTime(1969, 01, 01),
                DesignedBy = "Mayum Choying Wangmo Dorji",
                Usage = FlagUsage.NationalFlag
            }
        }
    };

    public static Country Bolivia { get; } = new()
    {
        ShortName = "Bolivia",
        FullName = "Plurinational State of Bolivia",
        IsoCodeAlpha2 = "BO",
        IsoCodeAlpha3 = "BOL",
        IsoCodeNumeric = "068",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A horizontal tricolor of red, yellow and green.",
                StartDate = new DateTime(1851, 10, 31),
                Usage = FlagUsage.CivilFlag | FlagUsage.CivilEnsign
            }
        }
    };

    public static Country CaribbeanNetherlands { get; } = new()
    {
        ShortName = "Caribbean Netherlands",
        FullName = "Bonaire, Sint Eustatius and Saba",
        IsoCodeAlpha2 = "BQ",
        IsoCodeAlpha3 = "BES",
        IsoCodeNumeric = "535",
        IsIndependent = false,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A horizontal triband of red (bright vermilion), white, and cobalt blue.",
                StartDate = new DateTime(1575, 01, 01),
                Usage = FlagUsage.NationalFlagAndEnsign
            }
        }
    };

    public static Country BosniaHerzegovina { get; } = new()
    {
        ShortName = "Bosnia and Herzegovina",
        FullName = "Bosnia and Herzegovina",
        IsoCodeAlpha2 = "BA",
        IsoCodeAlpha3 = "BIH",
        IsoCodeNumeric = "070",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A medium blue field with a yellow right triangle separating said field; along the hypotenuse of the triangle, there are seven full five-pointed white stars and two half stars at the top and bottom of the flag.",
                StartDate = new DateTime(1998, 02, 04),
                DesignedBy = "Mladen Kolobarić. The flag was proclaimed by the High Representative Carlos Westendorp",
                Usage = FlagUsage.NationalFlag
            }
        }
    };

    public static Country Botswana { get; } = new()
    {
        ShortName = "Botswana",
        FullName = "Republic of Botswana",
        IsoCodeAlpha2 = "BW",
        IsoCodeAlpha3 = "BWA",
        IsoCodeNumeric = "072",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A light blue field cut horizontally in the centre by a black stripe with a thin white frame.",
                StartDate = new DateTime(1966, 09, 30),
                Usage = FlagUsage.NationalFlag
            }
        }
    };

    public static Country BouvetIsland { get; } = new()
    {
        ShortName = "Bouvet Island",
        FullName = "Bouvet Island",
        IsoCodeAlpha2 = "BV",
        IsoCodeAlpha3 = "BVT",
        IsoCodeNumeric = "074",
        IsIndependent = false
    };

    public static Country Brazil { get; } = new()
    {
        ShortName = "Brazil",
        FullName = "Federative Republic of Brazil",
        IsoCodeAlpha2 = "BR",
        IsoCodeAlpha3 = "BRA",
        IsoCodeNumeric = "076",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A green field with the large yellow rhombus in the center bearing the blue disk, which is formed the celestial globe, depicted the starry sky of twenty-seven small white five-pointed stars spanned by the white equatorial curved band with the National Motto: \"Ordem E Progresso\" (Portuguese for \"Order and Progress\"), written in green.",
                StartDate = new DateTime(1889, 11, 19),
                DesignedBy = "Raimundo Teixeira Mendes",
                Usage = FlagUsage.NationalFlagAndEnsign
            }
        }
    };

    public static Country BritishIndianOceanTerritory { get; } = new()
    {
        ShortName = "British Indian Ocean Territory",
        FullName = "British Indian Ocean Territory",
        IsoCodeAlpha2 = "IO",
        IsoCodeAlpha3 = "IOT",
        IsoCodeNumeric = "086",
        IsIndependent = false,
        FlagsInternal = new CountryFlagCollection()
        {
            new()
            {
                Description = "A Blue Ensign with 7 wavy white stripes, with a palm tree on the hoist side and a crown over it.",
                StartDate = new DateTime(1990, 11, 08)
            }
        }
    };

    public static Country Brunei { get; } = new()
    {
        ShortName = "Brunei",
        FullName = "Brunei Darussalam",
        IsoCodeAlpha2 = "BN",
        IsoCodeAlpha3 = "BRN",
        IsoCodeNumeric = "096",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A centered red crest of Brunei on a yellow field cut by black and white diagonal stripes (parallelograms).",
                StartDate = new DateTime(1959, 09, 29),
                DesignedBy = "Yura Halim",
                Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag | FlagUsage.CivilEnsign
            }
        }
    };

    public static Country Bulgaria { get; } = new()
    {
        ShortName = "Bulgaria",
        FullName = "Republic of Bulgaria",
        IsoCodeAlpha2 = "BG",
        IsoCodeAlpha3 = "BGR",
        IsoCodeNumeric = "100",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A horizontal tricolour of white, green and red.",
                StartDate = new DateTime(1879, 01, 01),
                Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag | FlagUsage.CivilEnsign
            }
        }
    };

    public static Country BurkinaFaso { get; } = new()
    {
        ShortName = "Burkina Faso",
        FullName = "Burkina Faso",
        IsoCodeAlpha2 = "BF",
        IsoCodeAlpha3 = "BFA",
        IsoCodeNumeric = "854",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "Two horizontal bands of red and green with a yellow five-pointed star in the center.",
                StartDate = new DateTime(1984, 08, 04),
                Usage = FlagUsage.NationalFlag
            }
        }
    };

    public static Country Burundi { get; } = new()
    {
        ShortName = "Burundi",
        FullName = "Republic of Burundi",
        IsoCodeAlpha2 = "BI",
        IsoCodeAlpha3 = "BDI",
        IsoCodeNumeric = "108",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A white diagonal cross divided into four panels of red (top and bottom) and green (hoist-side and fly-side) with the white disk superimposed at the center of the cross bearing three red six-pointed stars with green outlines arranged in the triangular form (one above, two below).",
                StartDate = new DateTime(1967, 01, 01),
                Usage = FlagUsage.NationalFlagAndEnsign
            }
        }
    };
}