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

namespace DustInTheWind.Flags.CountryFlags;

public static partial class Countries
{
    public static Country Haiti { get; } = new()
    {
        ShortName = "Haiti",
        FullName = "Republic of Haiti",
        IsoCodeAlpha2 = "HT",
        IsoCodeAlpha3 = "HTI",
        IsoCodeNumeric = "332",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
        }
    };

    public static Country HeardIslandAndMcDonaldIslands { get; } = new()
    {
        ShortName = "Heard Island and McDonald Islands",
        FullName = "Heard Island and McDonald Islands",
        IsoCodeAlpha2 = "HM",
        IsoCodeAlpha3 = "HMD",
        IsoCodeNumeric = "334",
        IsIndependent = false,
        FlagsInternal = new CountryFlagCollection
        {
            new()
        }
    };

    public static Country HolySee { get; } = new()
    {
        ShortName = "Holy See",
        FullName = "Vatican City State",
        IsoCodeAlpha2 = "VA",
        IsoCodeAlpha3 = "VAT",
        IsoCodeNumeric = "336",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
        }
    };

    public static Country Honduras { get; } = new()
    {
        ShortName = "Honduras",
        FullName = "Republic of Honduras",
        IsoCodeAlpha2 = "HN",
        IsoCodeAlpha3 = "HND",
        IsoCodeNumeric = "340",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
        }
    };

    public static Country HongKong { get; } = new()
    {
        ShortName = "Hong Kong",
        FullName = "Hong Kong Special Administrative Region of the People's Republic of China",
        IsoCodeAlpha2 = "HK",
        IsoCodeAlpha3 = "HKG",
        IsoCodeNumeric = "344",
        IsIndependent = false,
        FlagsInternal = new CountryFlagCollection
        {
            new()
        }
    };

    public static Country Hungary { get; } = new()
    {
        ShortName = "Hungary",
        FullName = "Hungary",
        IsoCodeAlpha2 = "HU",
        IsoCodeAlpha3 = "HUN",
        IsoCodeNumeric = "348",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
        }
    };
}