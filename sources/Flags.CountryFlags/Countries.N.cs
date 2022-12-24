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
        Description = "A white-edged red diagonal band radiating from the lower hoist-side corner. The upper triangle is blue, charged with a gold sun with 12 triangular rays and the lower triangle is green.",
        AdoptedDate = new DateTime(1990, 03, 21),
        Usage = FlagUsage.All
    };

    public static Country Nauru { get; } = new()
    {
        ShortName = "Nauru",
        FullName = "Republic of Nauru",
        IsoCodeAlpha2 = "NR",
        IsoCodeAlpha3 = "NRU",
        IsoCodeNumeric = "520",
        IsIndependent = true,
        Description = "A blue field with the thin yellow narrow horizontal stripe across in the center and the large white twelve-pointed star on the bottom of the stripe and near the hoist-side.",
        AdoptedDate = new DateTime(1968, 01, 31),
        DesignedBy = "Theo Jankowski, Don Stevenson, Ortrud Clay",
        Usage = FlagUsage.StateFlag | FlagUsage.CivilEnsign
    };

    public static Country Nepal { get; } = new()
    {
        ShortName = "Nepal",
        FullName = "Federal Democratic Republic of Nepal",
        IsoCodeAlpha2 = "NP",
        IsoCodeAlpha3 = "NPL",
        IsoCodeNumeric = "524",
        IsIndependent = true,
        Description = "The national flag of Nepal consists of two juxtaposed triangular figures with a crimson-coloured base and deep blue borders, there being a white emblem of the crescent moon with eight rays visible out of sixteen in the upper part and a white emblem of a twelve rayed sun in the lower part.",
        AdoptedDate = new DateTime(1962, 12, 16),
        Usage = FlagUsage.NationalFlag
    };

    public static Country Netherlands { get; } = new()
    {
        ShortName = "Netherlands",
        FullName = "Kingdom of the Netherlands",
        IsoCodeAlpha2 = "NL",
        IsoCodeAlpha3 = "NLD",
        IsoCodeNumeric = "528",
        IsIndependent = true,
        Description = "A horizontal triband of red (bright vermilion), white, and cobalt blue",
        AdoptedDate = new DateTime(1575, 01, 01),
        Usage = FlagUsage.All
    };

    public static Country NewCaledonia { get; } = new()
    {
        ShortName = "New Caledonia",
        FullName = "New Caledonia",
        IsoCodeAlpha2 = "NC",
        IsoCodeAlpha3 = "NCL",
        IsoCodeNumeric = "540",
        IsIndependent = false,
        Description = "A vertical tricolour of blue, white, and red.",
        AdoptedDate = new DateTime(1794, 02, 15),
        Usage = FlagUsage.NationalFlag
    };

    public static Country NewCaledoniaFlnks { get; } = new()
    {
        ShortName = "New Caledonia",
        FullName = "New Caledonia",
        IsoCodeAlpha2 = "NC_FLNKS",
        IsoCodeAlpha3 = "NCL_FLNKS",
        IsoCodeNumeric = "540_FLNKS",
        IsIndependent = false,
        Description = "A horizontal tricolour of blue, red, and green charged with a yellow disc outlined in black and defaced with a black flèche faîtière.",
        AdoptedDate = new DateTime(2010, 07, 13)
    };

    public static Country NewZealand { get; } = new()
    {
        ShortName = "New Zealand",
        FullName = "New Zealand",
        IsoCodeAlpha2 = "NZ",
        IsoCodeAlpha3 = "NZL",
        IsoCodeNumeric = "554",
        IsIndependent = true,
        Description = "A Blue Ensign with a Union Jack in the first quarter and four five-pointed red stars with white borders on the fly representing the Southern Cross.",
        AdoptedDate = new DateTime(1902, 03, 24),
        DesignedBy = "Albert Hastings Markham",
        Usage = FlagUsage.NationalFlag | FlagUsage.StateEnsign
    };

    public static Country Nicaragua { get; } = new()
    {
        ShortName = "Nicaragua",
        FullName = "Republic of Nicaragua",
        IsoCodeAlpha2 = "NI",
        IsoCodeAlpha3 = "NIC",
        IsoCodeNumeric = "558",
        IsIndependent = true,
        Description = "A horizontal triband of Azure (top and bottom) and white with the National Coat of Arms centered on the white band.",
        AdoptedDate = new DateTime(1908, 09, 04),
        Usage = FlagUsage.All
    };

    public static Country Niger { get; } = new()
    {
        ShortName = "Niger",
        FullName = "Republic of the Niger",
        IsoCodeAlpha2 = "NE",
        IsoCodeAlpha3 = "NER",
        IsoCodeNumeric = "562",
        IsIndependent = true
    };

    public static Country Nigeria { get; } = new()
    {
        ShortName = "Nigeria",
        FullName = "Federal Republic of Nigeria",
        IsoCodeAlpha2 = "NG",
        IsoCodeAlpha3 = "NGA",
        IsoCodeNumeric = "566",
        IsIndependent = true
    };

    public static Country Niue { get; } = new()
    {
        ShortName = "Niue",
        FullName = "Niue",
        IsoCodeAlpha2 = "NU",
        IsoCodeAlpha3 = "NIU",
        IsoCodeNumeric = "570",
        IsIndependent = false
    };

    public static Country NorfolkIsland { get; } = new()
    {
        ShortName = "Norfolk Island",
        FullName = "Norfolk Island",
        IsoCodeAlpha2 = "NF",
        IsoCodeAlpha3 = "NFK",
        IsoCodeNumeric = "574",
        IsIndependent = false
    };

    public static Country NorthMacedonia { get; } = new()
    {
        ShortName = "North Macedonia",
        FullName = "Republic of North Macedonia",
        IsoCodeAlpha2 = "MK",
        IsoCodeAlpha3 = "MKD",
        IsoCodeNumeric = "807",
        IsIndependent = true
    };

    public static Country NorthernMarianaIslands { get; } = new()
    {
        ShortName = "Northern Mariana Islands",
        FullName = "Commonwealth of the Northern Mariana Islands",
        IsoCodeAlpha2 = "MP",
        IsoCodeAlpha3 = "MNP",
        IsoCodeNumeric = "580",
        IsIndependent = false
    };

    public static Country Norway { get; } = new()
    {
        ShortName = "Norway",
        FullName = "Kingdom of Norway",
        IsoCodeAlpha2 = "NO",
        IsoCodeAlpha3 = "NOR",
        IsoCodeNumeric = "578",
        IsIndependent = true
    };
}