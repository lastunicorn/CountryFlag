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

namespace DustInTheWind.CountryFlags.Default;

public static partial class FlagsSetup
{
    public static void Bahamas()
    {
        Countries.Bahamas.Flags.Add(new CountryFlag
        {
            Description = "A horizontal triband of aquamarine (top and bottom) and gold with the black chevron aligned to the hoist-side.",
            StartDate = new FlagDate(1973, 07, 10),
            DesignedBy = "Dr. Hervis Bain",
            Usage = FlagUsage.NationalFlag
        });
    }

    public static void Bahrain()
    {
        Countries.Bahrain.Flags.Add(new CountryFlag
        {
            Description = "A white field on the hoist side separated from a larger red field on the fly by five white triangles in the form of a zigzag pattern.",
            StartDate = new FlagDate(2002, 02, 14),
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void Bangladesh()
    {
        Countries.Bangladesh.Flags.Add(new CountryFlag
        {
            Names = new List<FlagName>
            {
                new()
                {
                    NativeName = "লাল সবুজ",
                    Romanized = "Lal Shôbuz",
                    EnglishTranslation = "The Red & Green"
                }
            },
            Description = "A red disc slightly off center to the left defacing a dark green banner.",
            StartDate = new FlagDate(1972, 01, 17),
            DesignedBy = "Quamrul Hassan",
            Usage = FlagUsage.NationalFlag
        });
    }

    public static void Barbados()
    {
        Countries.Barbados.Flags.Add(new CountryFlag
        {
            Names = new List<FlagName>
            {
                "The Broken Trident"
            },
            Description = "A vertical triband of ultramarine (hoist-side and fly-side) and gold with the black trident-head centred on the gold band.",
            StartDate = new FlagDate(1966, 11, 30),
            DesignedBy = "Grantley W. Prescod",
            Usage = FlagUsage.NationalFlag | FlagUsage.CivilEnsign | FlagUsage.StateEnsign
        });
    }

    public static void Belarus()
    {
        Countries.Belarus.Flags.Add(new CountryFlag
        {
            Description = "A horizontal bicolour of red over green in a 2:1 ratio, with a red ornamental pattern on a white vertical stripe at the hoist.",
            StartDate = new FlagDate(1951, 12, 25),
            DesignedBy = "Mikhail Husyev",
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void Belgium()
    {
        Countries.Belgium.Flags.Add(new CountryFlag
        {
            Description = "A vertical tricolour of black, yellow, and red.",
            StartDate = new FlagDate(1831, 01, 23),
            Usage = FlagUsage.CivilEnsign
        });
    }

    public static void Belize()
    {
        Countries.Belize.Flags.Add(new CountryFlag
        {
            Description = "A royal blue field with two red narrow horizontal stripes along the top and the bottom edges and the large white disk in the centre bearing the National Coat of Arms.",
            StartDate = new FlagDate(1981, 09, 21),
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void Benin()
    {
        Countries.Benin.Flags.Add(new CountryFlag
        {
            Description = "A horizontal bicolor of yellow and red with a green vertical band at the hoist.",
            StartDate = new FlagDate(1959, 11, 16),
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void Bermuda()
    {
        Countries.Bermuda.Flags.Add(new CountryFlag
        {
            Description = "Red Ensign with the coat-of-arms of Bermuda in the fly.",
            StartDate = new FlagDate(1999),
            Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag | FlagUsage.CivilEnsign
        });
    }

    public static void Bhutan()
    {
        Countries.Bhutan.Flags.Add(new CountryFlag
        {
            Description = "Divided diagonally from the lower hoist-side corner to the upper fly-side corner; the upper triangle is yellow and the lower triangle is orange, with a white dragon holding four jewels in its claws centered along the dividing line and facing away from the hoist.",
            StartDate = new FlagDate(1969),
            DesignedBy = "Mayum Choying Wangmo Dorji",
            Usage = FlagUsage.NationalFlag
        });
    }

    public static void Bolivia()
    {
        Countries.Bolivia.Flags.Add(new CountryFlag
        {
            Names = new List<FlagName>
            {
                new()
                {
                    NativeName = "La Tricolor",
                    EnglishTranslation = "The tricolor"
                }
            },
            Description = "A horizontal tricolor of red, yellow and green.",
            StartDate = new FlagDate(1851, 10, 31),
            Usage = FlagUsage.CivilFlag | FlagUsage.CivilEnsign
        });
    }

    public static void CaribbeanNetherlands()
    {
        Countries.CaribbeanNetherlands.Flags.Add(new CountryFlag
        {
            Description = "A horizontal triband of red (bright vermilion), white, and cobalt blue.",
            StartDate = new FlagDate(1575),
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void BosniaHerzegovina()
    {
        Countries.BosniaHerzegovina.Flags.Add(new CountryFlag
        {
            Description = "A medium blue field with a yellow right triangle separating said field; along the hypotenuse of the triangle, there are seven full five-pointed white stars and two half stars at the top and bottom of the flag.",
            StartDate = new FlagDate(1998, 02, 04),
            DesignedBy = "Mladen Kolobarić",
            Usage = FlagUsage.NationalFlag,
            Comments = "The flag was proclaimed by the High Representative Carlos Westendorp"
        });
    }

    public static void Botswana()
    {
        Countries.Botswana.Flags.Add(new CountryFlag
        {
            Description = "A light blue field cut horizontally in the centre by a black stripe with a thin white frame.",
            StartDate = new FlagDate(1966, 09, 30),
            Usage = FlagUsage.NationalFlag
        });
    }

    public static void BouvetIsland()
    {
        Countries.BouvetIsland.Flags.Add(new CountryFlag
        {
            Names = new List<FlagName>
            {
                "Norway flag"
            },
            Comments = "Bouvet Island is an island claimed by Norway, and declared an uninhabited protected nature reserve."
        });
    }

    public static void Brazil()
    {
        Countries.Brazil.Flags.Add(new CountryFlag
        {
            Description = "A green field with the large yellow rhombus in the center bearing the blue disk, which is formed the celestial globe, depicted the starry sky of twenty-seven small white five-pointed stars spanned by the white equatorial curved band with the National Motto: \"Ordem E Progresso\" (Portuguese for \"Order and Progress\"), written in green.",
            StartDate = new FlagDate(1889, 11, 19),
            DesignedBy = "Raimundo Teixeira Mendes",
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void BritishIndianOceanTerritory()
    {
        Countries.BritishIndianOceanTerritory.Flags.Add(new CountryFlag
        {
            Description = "A Blue Ensign with 7 wavy white stripes, with a palm tree on the hoist side and a crown over it.",
            StartDate = new FlagDate(1990, 11, 08)
        });
    }

    public static void Brunei()
    {
        Countries.Brunei.Flags.Add(new CountryFlag
        {
            Description = "A centered red crest of Brunei on a yellow field cut by black and white diagonal stripes (parallelograms).",
            StartDate = new FlagDate(1959, 09, 29),
            DesignedBy = "Yura Halim",
            Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag | FlagUsage.CivilEnsign
        });
    }

    public static void Bulgaria()
    {
        Countries.Bulgaria.Flags.Add(new CountryFlag
        {
            Description = "A horizontal tricolour of white, green and red.",
            StartDate = new DateTime(1990, 11, 27),
            Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag | FlagUsage.CivilEnsign
        });
    }

    public static void BurkinaFaso()
    {
        Countries.BurkinaFaso.Flags.Add(new CountryFlag
        {
            Description = "Two horizontal bands of red and green with a yellow five-pointed star in the center.",
            StartDate = new FlagDate(1984, 08, 04),
            Usage = FlagUsage.NationalFlag
        });
    }

    public static void Burundi()
    {
        Countries.Burundi.Flags.Add(new CountryFlag
        {
            Description = "A white diagonal cross divided into four panels of red (top and bottom) and green (hoist-side and fly-side) with the white disk superimposed at the center of the cross bearing three red six-pointed stars with green outlines arranged in the triangular form (one above, two below).",
            StartDate = new FlagDate(1982),
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }
}