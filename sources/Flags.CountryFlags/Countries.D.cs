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
    public static Country Denmark { get; } = new()
    {
        ShortName = "Denmark",
        FullName = "Denmark",
        IsoCodeAlpha2 = "DK",
        IsoCodeAlpha3 = "DNK",
        IsoCodeNumeric = "208",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Names = new List<FlagName>
                {
                    "Dannebrog"
                },
                Description = "A white Nordic cross with a red background.",
                StartDate = new DateTime(1625, 01, 01),
                Usage = FlagUsage.CivilFlag | FlagUsage.CivilEnsign
            },
            new()
            {
                Id = "Splitflaget",
                Names = new List<FlagName>
                {
                    new()
                    {
                        NativeName = "Splitflaget",
                        EnglishTranslation = "The national flag of Denmark"
                    },
                    new()
                    {
                        NativeName = "Rigets flag",
                        EnglishTranslation = "Flag of the Kingdom [of Denmark]"
                    }
                },
                Usage = FlagUsage.StateFlag | FlagUsage.WarFlag | FlagUsage.StateEnsign
            }
        }
    };

    public static Country Djibouti { get; } = new()
    {
        ShortName = "Djibouti",
        FullName = "Republic of Djibouti",
        IsoCodeAlpha2 = "DJ",
        IsoCodeAlpha3 = "DJI",
        IsoCodeNumeric = "262",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Names = new List<FlagName>
                {
                    new()
                    {
                        NativeName = "Drapeau National",
                        EnglishTranslation = "National Flag"
                    },
                    new()
                    {
                        NativeName = "علم الوطني",
                        EnglishTranslation = "National Flag"
                    }
                },
                Description = "A horizontal bicolour of light blue and light green, with a white isosceles triangle at the hoist bearing a red star in its center.",
                StartDate = new DateTime(1977, 06, 27),
                Usage = FlagUsage.NationalFlagAndEnsign
            }
        }
    };

    public static Country Dominica { get; } = new()
    {
        ShortName = "Dominica",
        FullName = "Commonwealth of Dominica",
        IsoCodeAlpha2 = "DM",
        IsoCodeAlpha3 = "DMA",
        IsoCodeNumeric = "212",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A green field with the centred cross of three bands: the vertical part is: yellow, black and white and the horizontal part is: yellow, black and white and the red disk superimposed at the centre of the cross bearing a purple Sisserou Parrot facing the hoist-side encircled by ten green five-pointed stars.",
                StartDate = new DateTime(1990, 01, 01),
                DesignedBy = "Alwin Bully",
                Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag
            },
            new()
            {
                Id = "President",
                Description = "A green field with the coat of arms of Dominica at the centre.",
                Usage = FlagUsage.LeaderFlag
            }
        }
    };

    public static Country DominicanRepublic { get; } = new()
    {
        ShortName = "Dominican Republic",
        FullName = "Dominican Republic",
        IsoCodeAlpha2 = "DO",
        IsoCodeAlpha3 = "DOM",
        IsoCodeNumeric = "214",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A white cross with the national coat of arms in the centre that divides the flag into four rectangles, blue and red at the top and red and blue at the bottom.",
                StartDate = new DateTime(1863, 11, 06),
                DesignedBy = "Juan Pablo Duarte",
                Usage = FlagUsage.StateFlag | FlagUsage.WarFlag | FlagUsage.StateEnsign | FlagUsage.WarEnsign
            },
            new()
            {
                Id = "Civil",
                Description = "Quarterly, the first and fourth quarters blue and the second and third quarters red, with a white cross overall.",
                Usage = FlagUsage.CivilFlag | FlagUsage.CivilEnsign
            }
        }
    };
}