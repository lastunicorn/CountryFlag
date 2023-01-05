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

namespace DustInTheWind.Flags.CountryFlags.Default;

public static partial class FlagsSetup
{
    public static void Afghanistan_IslamicEmirate()
    {
        Countries.Afghanistan_IslamicEmirate.Flags.Add(new CountryFlag
        {
            Description = "The Shahada in black on a white field in the calligraphic Thuluth script",
            StartDate = new DateTime(1997, 10, 27),
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void Afghanistan_IslamicRepublic()
    {
        Countries.Afghanistan_IslamicRepublic.Flags.Add(new CountryFlag
        {
            Description = "Three vertical bands of black, red and green with the National Emblem in white centered on the red band and then slightly overlapping the black and green bands.",
            StartDate = new DateTime(2013, 08, 19),
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void Aland()
    {
        Countries.Aland.Flags.Add(new CountryFlag
        {
            Description = "A yellow-fimbriated red Nordic cross on a blue field",
            StartDate = new DateTime(1954, 01, 01),
            Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag | FlagUsage.CivilEnsign | FlagUsage.StateEnsign
        });
    }

    /// <summary>
    /// Must add a civil and naval ensign.
    /// </summary>
    public static void Albania()
    {
        Countries.Albania.Flags.Add(new CountryFlag
        {
            Description = "A red field with a black two-headed eagle in the center.",
            StartDate = new DateTime(2002, 07, 22),
            DesignedBy = "Sadik Kaceli",
            Usage = FlagUsage.NationalFlag
        });

        Countries.Albania.Flags.Add(new CountryFlag
        {
            Id = "CivilEnsign",
            Description = "A horizontal tricolour with red on the top and bottom stripes, and black in the middle.",
            Usage = FlagUsage.CivilEnsign
        });

        Countries.Albania.Flags.Add(new CountryFlag
        {
            Id = "NavalEnsign",
            Description = "A double-headed eagle on a white background with a red stripe at the bottom.",
            Usage = FlagUsage.WarEnsign
        });
    }

    /// <summary>
    /// Must add a naval ensign and a naval jack.
    /// </summary>
    public static void Algeria()
    {
        Countries.Algeria.Flags.Add(new CountryFlag
        {
            Description = "A vertical bicolor of green and white with the red crescent encircling the red five-pointed star centered along the dividing line.",
            StartDate = new DateTime(1962, 07, 03),
            Usage = FlagUsage.NationalFlag | FlagUsage.CivilEnsign | FlagUsage.StateEnsign
        });

        Countries.Algeria.Flags.Add(new CountryFlag
        {
            Id = "President",
            Names = new List<FlagName>
            {
                "President's Flag"
            },
            Usage = FlagUsage.LeaderFlag
        });

        Countries.Algeria.Flags.Add(new CountryFlag
        {
            Id = "NavalEnsign",
            Names = new List<FlagName>
            {
                "Naval ensign"
            },
            Usage = FlagUsage.WarEnsign
        });

        Countries.Algeria.Flags.Add(new CountryFlag
        {
            Id = "NavalJack",
            Names = new List<FlagName>
            {
                "Naval jack"
            },
            Usage = FlagUsage.NavalJack
        });
    }

    public static void AmericanSamoa()
    {
        Countries.AmericanSamoa.Flags.Add(new CountryFlag
        {
            Description = "A red-edged white triangle pointing towards the hoist charged with a bald eagle clutching a war club and a fly-whisk. The white triangle divided the dark blue field into two separate triangles.",
            StartDate = new DateTime(1960, 04, 17),
            DesignedBy = "Fareti Sotoa",
            Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag
        });
    }

    /// <summary>
    /// Must add civil flag and civil ensign
    /// </summary>
    public static void Andorra()
    {
        Countries.Andorra.Flags.Add(new CountryFlag
        {
            Description = "A vertical tricolour of blue, yellow and red with the National Coat of Arms centred on the yellow band.",
            StartDate = new DateTime(1866),
            DesignedBy = "Napoleon III",
            Usage = FlagUsage.StateFlag
        });

        Countries.Andorra.Flags.Add(new CountryFlag
        {
            Id = "Civil",
            Names = new List<FlagName>
            {
                "Civil flag and ensign"
            },
            Description = "A vertical tricolour of blue, yellow and red.",
            StartDate = new DateTime(1866, 01, 01),
            DesignedBy = "Napoleon III",
            Usage = FlagUsage.CivilFlag | FlagUsage.CivilEnsign
        });
    }

    public static void Angola()
    {
        Countries.Angola.Flags.Add(new CountryFlag
        {
            Description = "Two horizontal bands of red and black with the Machete and Gear Emblem in the center.",
            StartDate = new DateTime(1975, 11, 11),
            DesignedBy = "Henrique de Carvalho Santos, António Alberto Neto",
            Usage = FlagUsage.NationalFlag
        });
    }

    public static void Anguilla()
    {
        Countries.Anguilla.Flags.Add(new CountryFlag
        {
            Description = "A Blue Ensign charged in the fly with the coat of arms of Anguilla",
            Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag | FlagUsage.StateEnsign
        });
    }

    public static void Antarctica()
    {
        Countries.Antarctica.Flags.Add(new CountryFlag
        {
            StartDate = new DateTime(2002, 01, 01)
        });
    }

    public static void AntiguaAndBarbuda()
    {
        Countries.AntiguaAndBarbuda.Flags.Add(new CountryFlag
        {
            Description = "A horizontal tri-colour of black, blue (half-width), and white, with two red right scalene triangles on opposite sides. On the black band is a yellow half-sun with nine rays.",
            StartDate = new DateTime(1967, 02, 27),
            DesignedBy = "Sir Reginald Samuel",
            Usage = FlagUsage.NationalFlag | FlagUsage.CivilEnsign
        });
     
        Countries.AntiguaAndBarbuda.Flags.Add(new CountryFlag
        {
            Id = "StateEnsign",
            Description = "A white field with a red cross, the national flag in the canton.",
            Usage = FlagUsage.StateEnsign
        });
    }

    /// <summary>
    /// Must add alternative civil flag and ensign.
    /// </summary>
    public static void Argentina()
    {
        Countries.Argentina.Flags.Add(new CountryFlag
        {
            Description = "A horizontal triband of light blue (top and bottom) and white with a Sun of May centered on the white band.",
            StartDate = new DateTime(1861, 01, 01),
            DesignedBy = "Manuel Belgrano",
            Usage = FlagUsage.NationalFlagAndEnsign
        });

        Countries.Argentina.Flags.Add(new CountryFlag
        {
            Id = "Civil",
            Names = new List<FlagName>
            {
                new()
                {
                    NativeName = "Bandera de Ornato",
                    EnglishTranslation = "Ornamental Flag"
                }
            },
            Description = "A horizontal triband of light blue (top and bottom) and white (center).",
            StartDate = new DateTime(1812, 02, 27),
            Usage = FlagUsage.CivilFlag | FlagUsage.CivilEnsign
        });
    }

    public static void Armenia()
    {
        Countries.Armenia.Flags.Add(new CountryFlag
        {
            Description = "A horizontal tricolour of red, blue, and apricot.",
            StartDate = new DateTime(1990, 08, 24),
            DesignedBy = "Stepan Malkhasyants",
            Usage = FlagUsage.NationalFlag
        });

        Countries.Armenia.Flags.Add(new CountryFlag
        {
            Id = "President",
            Names = new List<FlagName>
            {
                "President's Flag"
            },
            Description = "A horizontal tricolour of red, blue, and orange defaced with the Presidential seal at its centre.",
            Usage = FlagUsage.LeaderFlag
        });
    }

    public static void Aruba()
    {
        Countries.Aruba.Flags.Add(new CountryFlag
        {
            StartDate = new DateTime(1976, 03, 18),
            Usage = FlagUsage.NationalFlag
        });

        Countries.Aruba.Flags.Add(new CountryFlag
        {
            Id = "Governor",
            Usage = FlagUsage.LeaderFlag
        });
    }

    /// <summary>
    /// Must add civil ensign and naval ensign and air force ensign.
    /// </summary>
    public static void Australia()
    {
        Countries.Australia.Flags.Add(new CountryFlag
        {
            Description = "A Blue Ensign defaced with the Commonwealth Star in the lower hoist quarter and the five stars of the Southern Cross in the fly half.",
            StartDate = new DateTime(1903, 12, 08),
            DesignedBy = "Annie Dorrington, Ivor Evans, Lesley Hawkins, Egbert Nutall and William Stevens",
            Usage = FlagUsage.NationalFlag | FlagUsage.StateEnsign
        });

        Countries.Australia.Flags.Add(new CountryFlag
        {
            Id = "CivilEnsign",
            Names = new List<FlagName>
            {
                "Australian Red Ensign"
            },
            Description = "A Red Ensign defaced with the Commonwealth/Federation Star at the hoist, and the Southern Cross in the fly half.",
            Usage = FlagUsage.CivilEnsign
        });
       
        Countries.Australia.Flags.Add(new CountryFlag
        {
            Id = "NavalEnsign",
            Names = new List<FlagName>
            {
                "Royal Australian Navy Ensign"
            },
            Description = "A defaced British White Ensign without the cross. The cross is replaced with the Southern Cross and the Commonwealth Star/Federation Star.",
            StartDate = new DateTime(1967, 01, 01),
            Usage = FlagUsage.CivilEnsign
        });
       
        Countries.Australia.Flags.Add(new CountryFlag
        {
            Id = "AirEnsign",
            Names = new List<FlagName>
            {
                "Royal Australian Air Force Ensign"
            },
            Description = "A field of air force blue with the Union Flag in the canton, the Commonwealth Star below the Union Flag with the Southern Cross in the fly and the RAAF roundel in the lower fly.",
            StartDate = new DateTime(1982, 01, 01),
            Usage = FlagUsage.AirForceEnsign
        });
    }

    /// <summary>
    /// Must add state and war flag, state and naval ensign.
    /// </summary>
    public static void Austria()
    {
        Countries.Austria.Flags.Add(new CountryFlag
        {
            Description = "A horizontal triband of red (top and bottom) and white.",
            StartDate = new DateTime(1945, 05, 01),
            Usage = FlagUsage.CivilFlag | FlagUsage.CivilEnsign
        });
     
        Countries.Austria.Flags.Add(new CountryFlag
        {
            Id = "StateAndWar",
            Description = "A horizontal triband of red (top and bottom) and white defaced with the Coat of arms of Austria at its centre.",
            Usage = FlagUsage.StateFlag | FlagUsage.WarFlag | FlagUsage.StateEnsign | FlagUsage.WarEnsign
        });
    }

    public static void Azerbaijan()
    {
        Countries.Azerbaijan.Flags.Add(new CountryFlag
        {
            Description = "A horizontal tricolour of bright blue, red, and green, with a white crescent and an eight-pointed star centred on a red band.",
            StartDate = new DateTime(1991, 02, 05),
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }
}