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
    public static Country Ecuador { get; } = new()
    {
        ShortName = "Ecuador",
        FullName = "Republic of Ecuador",
        IsoCodeAlpha2 = "EC",
        IsoCodeAlpha3 = "ECU",
        IsoCodeNumeric = "218",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Names = new List<string>
                {
                    "La Tricolor",
                    "The Tricolor"
                },
                Description = "A horizontal tricolor of yellow (double width), blue and red with the National Coat of Arms superimposed at the center.",
                StartDate = new DateTime(1860, 09, 26),
                Usage = FlagUsage.StateFlag | FlagUsage.WarFlag | FlagUsage.StateEnsign | FlagUsage.WarEnsign
            },
            new()
            {
                Id = "Civil",
                Description = "A horizontal tricolor of yellow (double width), blue and red.",
                Usage = FlagUsage.CivilFlag | FlagUsage.CivilEnsign
            }
        }
    };

    public static Country Egypt { get; } = new()
    {
        ShortName = "Egypt",
        FullName = "Arab Republic of Egypt",
        IsoCodeAlpha2 = "EG",
        IsoCodeAlpha3 = "EGY",
        IsoCodeNumeric = "818",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "Horizontally divided red-white-black tricolor flag with the Eagle of Saladin.",
                StartDate = new DateTime(1984, 10, 04),
                DesignedBy = "Aly Kamel El-Deeb",
                Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag | FlagUsage.CivilEnsign | FlagUsage.StateEnsign
            },
            new()
            {
                Id = "WarFlag",
                Names = new List<string>
                {
                    "War Flag"
                },
                Description = "National flag with two white crossed sabres in canton.",
                StartDate = new DateTime(1984, 10, 04),
                Usage = FlagUsage.WarFlag
            },
            new()
            {
                Id = "WarEnsign",
                Names = new List<string>
                {
                    "War Ensign"
                },
                Description = "National flag with two white fouled crossed anchors in canton.",
                StartDate = new DateTime(1984, 10, 04),
                Usage = FlagUsage.WarEnsign
            },
            new()
            {
                Id = "President",
                Names = new List<string>
                {
                    "President's Flag"
                },
                Description = "National flag with gold outlined Eagle of Saladin in canton.",
                StartDate = new DateTime(1984, 10, 04),
                Usage = FlagUsage.LeaderFlag
            }
        }
    };

    public static Country ElSalvador { get; } = new()
    {
        ShortName = "El Salvador",
        FullName = "Republic of El Salvador",
        IsoCodeAlpha2 = "SV",
        IsoCodeAlpha3 = "SLV",
        IsoCodeNumeric = "222",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Names = new List<string>
                {
                    "Bandera Magna",
                    "Magna flag"
                },
                Description = "A horizontal triband of cobalt blue (top and bottom) and white with the National Coat of Arms in the center and occupying the entire hight of the white stripe with its top touching the upper blue strip and its base touching the lower blue stripe.",
                StartDate = new DateTime(1912, 05, 27),
                Usage = FlagUsage.StateFlag | FlagUsage.WarFlag | FlagUsage.WarEnsign
            },
            new()
            {
                Id = "Civil",
                Description = "A horizontal triband of white within cobalt blue.",
                Usage = FlagUsage.CivilFlag | FlagUsage.CivilEnsign
            },
            new()
            {
                Id = "Dios",
                Description = "A horizontal triband of white within cobalt blue, the words \"DIOS UNION LIBERTAD\" in bolden golden amber centered and occupying almost the entire length of the white stripe.",
                Usage = FlagUsage.StateFlag | FlagUsage.WarFlag | FlagUsage.CivilEnsign | FlagUsage.StateEnsign
            }
        }
    };

    public static Country EquatorialGuinea { get; } = new()
    {
        ShortName = "Equatorial Guinea",
        FullName = "Republic of Equatorial Guinea",
        IsoCodeAlpha2 = "GQ",
        IsoCodeAlpha3 = "GNQ",
        IsoCodeNumeric = "226",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A horizontal tricolor of green, white and red with a blue isosceles triangle based on the hoist side and the National Coat of arms of Equatorial Guinea centered in the white band.",
                StartDate = new DateTime(1968, 10, 12),
                Usage = FlagUsage.StateFlag | FlagUsage.WarFlag | FlagUsage.StateEnsign | FlagUsage.WarEnsign
            }
        }
    };

    public static Country Eritrea { get; } = new()
    {
        ShortName = "Eritrea",
        FullName = "State of Eritrea",
        IsoCodeAlpha2 = "ER",
        IsoCodeAlpha3 = "ERI",
        IsoCodeNumeric = "232",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new ()
            {
                Description = "A red isosceles triangle based on the hoist-side pointed toward the fly-side and then divided into two right triangles: the upper triangle is green and the lower triangle is blue with an Emblem (1952-1995) in gold (a vertical olive branch encircled by an olive wreath) centered on the hoist side of the triangle.",
                StartDate = new DateTime(1995, 12, 05),
                Usage = FlagUsage.NationalFlagAndEnsign
            }
        }
    };

    public static Country Estonia { get; } = new()
    {
        ShortName = "Estonia",
        FullName = "Republic of Estonia",
        IsoCodeAlpha2 = "EE",
        IsoCodeAlpha3 = "EST",
        IsoCodeNumeric = "233",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new ()
            {
                Description = "A horizontal triband of blue, black, and white.",
                StartDate = new DateTime(1918, 01, 01),
                Usage = FlagUsage.CivilFlag | FlagUsage.CivilEnsign | FlagUsage.StateFlag
            },
            new()
            {
                Id = "NavalEnsign",
                Description = "Tricolour, swallowtail, defaced with the shield of the state arms off-set towards hoist.",
                StartDate = new DateTime(1991, 01, 01),
                Usage = FlagUsage.WarEnsign
            },
            new()
            {
                Id = "PresidentLand",
                Usage = FlagUsage.LeaderFlag
            },
            new()
            {
                Id = "PresidentSea",
                Usage = FlagUsage.LeaderFlag
            },
            new()
            {
                Id = "NavalJack",
                Usage = FlagUsage.NavalJack
            }
        }
    };

    public static Country Eswatini { get; } = new()
    {
        ShortName = "Eswatini",
        FullName = "Kingdom of Eswatini",
        IsoCodeAlpha2 = "SZ",
        IsoCodeAlpha3 = "SWZ",
        IsoCodeNumeric = "748",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A horizontal triband of blue (top and bottom) and the yellow-edged red (triple width) with the large black and white Nguni shield covering two spears and the staff decorated with the feather tassels called injobo (tassels-bunches of feathers of the widowbird and the lourie) all centered horizontally of the red band.",
                StartDate = new DateTime(1968, 10, 06),
                DesignedBy = "King Sobhuza II",
                Usage = FlagUsage.StateFlag | FlagUsage.WarFlag
            }
        }
    };

    public static Country Ethiopia { get; } = new()
    {
        ShortName = "Ethiopia",
        FullName = "Federal Democratic Republic of Ethiopia",
        IsoCodeAlpha2 = "ET",
        IsoCodeAlpha3 = "ETH",
        IsoCodeNumeric = "231",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A horizontal tricolour of green, yellow and red with the National Emblem superimposed at the center.",
                StartDate = new DateTime(2009, 05, 16),
                DesignedBy = "Abebe Alambo",
                Usage = FlagUsage.NationalFlagAndEnsign
            }
        }
    };
}