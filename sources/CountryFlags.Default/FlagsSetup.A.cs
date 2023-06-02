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

namespace DustInTheWind.CountryFlags.Main;

public static partial class FlagsSetup
{
    public static void Afghanistan_IslamicEmirate()
    {
        Countries.Afghanistan_IslamicEmirate.Flags.Add(new CountryFlag
        {
            Description = "The Shahada in black on a white field in the calligraphic Thuluth script.",
            StartDate = new FlagDate(1997, 10, 27),
            Usage = FlagUsage.NationalFlagAndEnsign
        });

        Countries.Afghanistan_IslamicEmirate.Flags.Add(new CountryFlag
        {
            Id = "Variant_Shahada",
            Description = "The Shahada in black on a white field in the calligraphic Thuluth script.",
            StartDate = new FlagDate(1997, 10, 27),
            Usage = FlagUsage.NationalFlagAndEnsign
        });

        Countries.Afghanistan_IslamicEmirate.Flags.Add(new CountryFlag
        {
            Id = "Variant",
            Description = "The Shahada in black on a white field, underneath which is \"Islamic Emirate of Afghanistan\" in Pashto, both written in calligraphic script",
            Usage = FlagUsage.NationalFlagAndEnsign
        });

        Countries.Afghanistan_IslamicEmirate.Flags.Add(new CountryFlag
        {
            Id = "Republic",
            Description = "Three vertical bands of black, red and green with the National Emblem in white centered on the red band and then slightly overlapping the black and green bands.",
            StartDate = new FlagDate(2013, 08, 19),
            Usage = FlagUsage.NationalFlagAndEnsign
        });

        Countries.Afghanistan_IslamicEmirate.Flags.Add(new CountryFlag
        {
            Id = "Republic_Variant",
            Description = "Three vertical bands of black, red and green with the National Emblem in white centered on the red band and then slightly overlapping the black and green bands.",
            StartDate = new FlagDate(2013, 08, 19),
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void Aland()
    {
        Countries.Aland.Flags.Add(new CountryFlag
        {
            Description = "A yellow-fimbriated red Nordic cross on a blue field",
            StartDate = new FlagDate(1954),
            Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag | FlagUsage.CivilEnsign | FlagUsage.StateEnsign
        });
    }

    public static void Albania()
    {
        Countries.Albania.Flags.Add(new CountryFlag
        {
            Description = "A red field with a black two-headed eagle in the center.",
            StartDate = new FlagDate(2002, 07, 22),
            DesignedBy = "Sadik Kaceli",
            Usage = FlagUsage.NationalFlag
        });
    }

    public static void Algeria()
    {
        Countries.Algeria.Flags.Add(new CountryFlag
        {
            Description = "A vertical bicolor of green and white with the red crescent encircling the red five-pointed star centered along the dividing line.",
            StartDate = new FlagDate(1962, 07, 03),
            Usage = FlagUsage.NationalFlag | FlagUsage.CivilEnsign | FlagUsage.StateEnsign
        });
    }

    public static void AmericanSamoa()
    {
        Countries.AmericanSamoa.Flags.Add(new CountryFlag
        {
            Description = "A red-edged white triangle pointing towards the hoist charged with a bald eagle clutching a war club and a fly-whisk. The white triangle divided the dark blue field into two separate triangles.",
            StartDate = new FlagDate(1960, 04, 17),
            DesignedBy = "Fareti Sotoa",
            Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag
        });
    }

    public static void Andorra()
    {
        Countries.Andorra.Flags.Add(new CountryFlag
        {
            Description = "A vertical tricolour of blue, yellow and red with the National Coat of Arms centred on the yellow band.",
            StartDate = new FlagDate(1866),
            DesignedBy = "Napoleon III",
            Usage = FlagUsage.StateFlag
        });
    }

    public static void Angola()
    {
        Countries.Angola.Flags.Add(new CountryFlag
        {
            Description = "Two horizontal bands of red and black with the Machete and Gear Emblem in the center.",
            StartDate = new FlagDate(1975, 11, 11),
            DesignedBy = new StringList
            {
                "Henrique de Carvalho Santos",
                "António Alberto Neto"
            },
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
            StartDate = new FlagDate(2002)
        });
    }

    public static void AntiguaAndBarbuda()
    {
        Countries.AntiguaAndBarbuda.Flags.Add(new CountryFlag
        {
            Description = "A horizontal tri-colour of black, blue (half-width), and white, with two red right scalene triangles on opposite sides. On the black band is a yellow half-sun with nine rays.",
            StartDate = new FlagDate(1967, 02, 27),
            DesignedBy = "Sir Reginald Samuel",
            Usage = FlagUsage.NationalFlag | FlagUsage.CivilEnsign
        });
    }

    public static void Argentina()
    {
        Countries.Argentina.Flags.Add(new CountryFlag
        {
            Description = "A horizontal triband of light blue (top and bottom) and white with a Sun of May centered on the white band.",
            StartDate = new FlagDate(1812, 03, 27),
            DesignedBy = "Manuel Belgrano",
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void Armenia()
    {
        Countries.Armenia.Flags.Add(new CountryFlag
        {
            Description = "A horizontal tricolour of red, blue, and apricot.",
            StartDate = new FlagDate(1990, 08, 24),
            DesignedBy = "Stepan Malkhasyants",
            Usage = FlagUsage.NationalFlag
        });
    }

    public static void Aruba()
    {
        Countries.Aruba.Flags.Add(new CountryFlag
        {
            StartDate = new FlagDate(1976, 03, 18),
            Usage = FlagUsage.NationalFlag
        });
    }

    public static void Australia()
    {
        Countries.Australia.Flags.Add(new CountryFlag
        {
            Description = "A Blue Ensign defaced with the Commonwealth Star in the lower hoist quarter and the five stars of the Southern Cross in the fly half.",
            StartDate = new FlagDate(1908, 12, 08),
            DesignedBy = new StringList
            {
                "Annie Dorrington",
                "Ivor Evans, Lesley Hawkins",
                "Egbert Nutall and William Stevens"
            },
            Usage = FlagUsage.NationalFlag | FlagUsage.StateEnsign
        });
    }

    public static void Austria()
    {
        Countries.Austria.Flags.Add(new CountryFlag
        {
            Description = "A horizontal triband of red (top and bottom) and white.",
            StartDate = new FlagDate(1945, 05, 01),
            Usage = FlagUsage.CivilFlag | FlagUsage.CivilEnsign
        });
    }

    public static void Azerbaijan()
    {
        Countries.Azerbaijan.Flags.Add(new CountryFlag
        {
            Description = "A horizontal tricolour of bright blue, red, and green, with a white crescent and an eight-pointed star centred on a red band.",
            StartDate = new FlagDate(1991, 02, 05),
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }
}