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
    public static Country Namibia { get; } = new()
    {
        ShortName = "Namibia",
        FullName = "Republic of Namibia",
        IsoCodeAlpha2 = "NA",
        IsoCodeAlpha3 = "NAM",
        IsoCodeNumeric = "516",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A white-edged red diagonal band radiating from the lower hoist-side corner. The upper triangle is blue, charged with a gold sun with 12 triangular rays and the lower triangle is green.",
                AdoptedDate = new DateTime(1990, 03, 21),
                Usage = FlagUsage.All
            }
        }
    };

    public static Country Nauru { get; } = new()
    {
        ShortName = "Nauru",
        FullName = "Republic of Nauru",
        IsoCodeAlpha2 = "NR",
        IsoCodeAlpha3 = "NRU",
        IsoCodeNumeric = "520",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A blue field with the thin yellow narrow horizontal stripe across in the center and the large white twelve-pointed star on the bottom of the stripe and near the hoist-side.",
                AdoptedDate = new DateTime(1968, 01, 31),
                DesignedBy = "Theo Jankowski, Don Stevenson, Ortrud Clay",
                Usage = FlagUsage.StateFlag | FlagUsage.CivilEnsign
            }
        }
    };

    public static Country Nepal { get; } = new()
    {
        ShortName = "Nepal",
        FullName = "Federal Democratic Republic of Nepal",
        IsoCodeAlpha2 = "NP",
        IsoCodeAlpha3 = "NPL",
        IsoCodeNumeric = "524",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "The national flag of Nepal consists of two juxtaposed triangular figures with a crimson-coloured base and deep blue borders, there being a white emblem of the crescent moon with eight rays visible out of sixteen in the upper part and a white emblem of a twelve rayed sun in the lower part.",
                AdoptedDate = new DateTime(1962, 12, 16),
                Usage = FlagUsage.NationalFlag
            }
        }
    };

    public static Country Netherlands { get; } = new()
    {
        ShortName = "Netherlands",
        FullName = "Kingdom of the Netherlands",
        IsoCodeAlpha2 = "NL",
        IsoCodeAlpha3 = "NLD",
        IsoCodeNumeric = "528",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A horizontal triband of red (bright vermilion), white, and cobalt blue",
                AdoptedDate = new DateTime(1575, 01, 01),
                Usage = FlagUsage.All
            }
        }
    };

    public static Country NewCaledonia { get; } = new()
    {
        ShortName = "New Caledonia",
        FullName = "New Caledonia",
        IsoCodeAlpha2 = "NC",
        IsoCodeAlpha3 = "NCL",
        IsoCodeNumeric = "540",
        IsIndependent = false,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A vertical tricolour of blue, white, and red.",
                AdoptedDate = new DateTime(1794, 02, 15),
                Usage = FlagUsage.NationalFlag
            },
            new()
            {
                Id = "FLNKS",
                Description = "A horizontal tricolour of blue, red, and green charged with a yellow disc outlined in black and defaced with a black flèche faîtière.",
                AdoptedDate = new DateTime(2010, 07, 13),
                Usage = FlagUsage.NationalFlag
            }
        }
    };

    public static Country NewZealand { get; } = new()
    {
        ShortName = "New Zealand",
        FullName = "New Zealand",
        IsoCodeAlpha2 = "NZ",
        IsoCodeAlpha3 = "NZL",
        IsoCodeNumeric = "554",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A Blue Ensign with a Union Jack in the first quarter and four five-pointed red stars with white borders on the fly representing the Southern Cross.",
                AdoptedDate = new DateTime(1902, 03, 24),
                DesignedBy = "Albert Hastings Markham",
                Usage = FlagUsage.NationalFlag | FlagUsage.StateEnsign
            }
        }
    };

    public static Country Nicaragua { get; } = new()
    {
        ShortName = "Nicaragua",
        FullName = "Republic of Nicaragua",
        IsoCodeAlpha2 = "NI",
        IsoCodeAlpha3 = "NIC",
        IsoCodeNumeric = "558",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A horizontal triband of Azure (top and bottom) and white with the National Coat of Arms centered on the white band.",
                AdoptedDate = new DateTime(1908, 09, 04),
                Usage = FlagUsage.All
            }
        }
    };

    public static Country Niger { get; } = new()
    {
        ShortName = "Niger",
        FullName = "Republic of the Niger",
        IsoCodeAlpha2 = "NE",
        IsoCodeAlpha3 = "NER",
        IsoCodeNumeric = "562",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A horizontal triband of orange, white and green; charged with an orange circle in the centre.",
                AdoptedDate = new DateTime(1959, 11, 23),
                Usage = FlagUsage.NationalFlag
            }
        }
    };

    public static Country Nigeria { get; } = new()
    {
        ShortName = "Nigeria",
        FullName = "Federal Republic of Nigeria",
        IsoCodeAlpha2 = "NG",
        IsoCodeAlpha3 = "NGA",
        IsoCodeNumeric = "566",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A vertical bicolour triband of green, white and green.",
                AdoptedDate = new DateTime(1960, 10, 01),
                DesignedBy = "Michael Taiwo Akinkunmi",
                Usage = FlagUsage.NationalFlag
            }
        }
    };

    public static Country Niue { get; } = new()
    {
        ShortName = "Niue",
        FullName = "Niue",
        IsoCodeAlpha2 = "NU",
        IsoCodeAlpha3 = "NIU",
        IsoCodeNumeric = "570",
        IsIndependent = false,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A golden yellow flag with the Union flag in the upper left (hoist) quarter of the flags. On the Union Jack are two yellow five-pointed stars on the vertical stripe and two on the horizontal stripe. In the centre of the Union flag is a blue disc with another, slightly larger, yellow five-pointed star.",
                AdoptedDate = new DateTime(1975, 10, 15),
                DesignedBy = "Patricia Rex",
                Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag
            }
        }
    };

    public static Country NorfolkIsland { get; } = new()
    {
        ShortName = "Norfolk Island",
        FullName = "Norfolk Island",
        IsoCodeAlpha2 = "NF",
        IsoCodeAlpha3 = "NFK",
        IsoCodeNumeric = "574",
        IsIndependent = false,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "Norfolk Island pine (Araucaria heterophylla) in a central white stripe between two green stripes.",
                AdoptedDate = new DateTime(1979, 07, 09),
                Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag
            }
        }
    };

    public static Country NorthMacedonia { get; } = new()
    {
        ShortName = "North Macedonia",
        FullName = "Republic of North Macedonia",
        IsoCodeAlpha2 = "MK",
        IsoCodeAlpha3 = "MKD",
        IsoCodeNumeric = "807",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A stylised yellow sun on a red field, with eight broadening rays extending from the centre to the edge of the field.",
                AdoptedDate = new DateTime(1995, 10, 5),
                DesignedBy = "Miroslav Grčev",
                Usage = FlagUsage.All
            }
        }
    };

    public static Country NorthernMarianaIslands { get; } = new()
    {
        ShortName = "Northern Mariana Islands",
        FullName = "Commonwealth of the Northern Mariana Islands",
        IsoCodeAlpha2 = "MP",
        IsoCodeAlpha3 = "MNP",
        IsoCodeNumeric = "580",
        IsIndependent = false,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A circle of flowers and plants with a gray sculpture and a white star on a blue field.",
                AdoptedDate = new DateTime(1985, 07, 01),
                Usage = FlagUsage.StateFlag | FlagUsage.WarFlag
            }
        }
    };

    public static Country Norway { get; } = new()
    {
        ShortName = "Norway",
        FullName = "Kingdom of Norway",
        IsoCodeAlpha2 = "NO",
        IsoCodeAlpha3 = "NOR",
        IsoCodeNumeric = "578",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A red field charged with a white-fimbriated dark blue Nordic cross that extends to the edges; the vertical part of the cross is shifted to the hoist side.",
                AdoptedDate = new DateTime(1821, 07, 13),
                DesignedBy = "Fredrik Meltzer",
                Usage = FlagUsage.All
            }
        }
    };
}