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
    public static Country Afghanistan_IslamicEmirate { get; } = new()
    {
        ShortName = "Afghanistan",
        FullName = "Islamic Emirate of Afghanistan",
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "The Shahada in black on a white field in the calligraphic Thuluth script",
                StartDate = new DateTime(1997, 10, 27),
                Usage = FlagUsage.NationalFlagAndEnsign
            }
        }
    };

    public static Country Afghanistan_IslamicRepublic { get; } = new()
    {
        ShortName = "Afghanistan",
        FullName = "Islamic Republic of Afghanistan",
        IsoCodeAlpha2 = "AF",
        IsoCodeAlpha3 = "AFG",
        IsoCodeNumeric = "004",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "Three vertical bands of black, red and green with the National Emblem in white centered on the red band and then slightly overlapping the black and green bands.",
                StartDate = new DateTime(2013, 08, 19),
                Usage = FlagUsage.NationalFlagAndEnsign
            }
        }
    };

    public static Country Aland { get; } = new()
    {
        ShortName = "Åland",
        FullName = "Åland",
        IsoCodeAlpha2 = "AX",
        IsoCodeAlpha3 = "ALA",
        IsoCodeNumeric = "248",
        IsIndependent = false,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A yellow-fimbriated red Nordic cross on a blue field",
                StartDate = new DateTime(1954, 01, 01),
                Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag | FlagUsage.CivilEnsign | FlagUsage.StateEnsign
            }
        }
    };

    /// <summary>
    /// Must add a civil and naval ensign.
    /// </summary>
    public static Country Albania { get; } = new()
    {
        ShortName = "Albania",
        FullName = "Republic of Albania",
        IsoCodeAlpha2 = "AL",
        IsoCodeAlpha3 = "ALB",
        IsoCodeNumeric = "008",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A red field with a black two-headed eagle in the center.",
                StartDate = new DateTime(2002, 07, 22),
                DesignedBy = "Sadik Kaceli",
                Usage = FlagUsage.NationalFlag
            }
        }
    };

    /// <summary>
    /// Must add a naval ensign and a naval jack.
    /// </summary>
    public static Country Algeria { get; } = new()
    {
        ShortName = "Algeria",
        FullName = "People's Democratic Republic of Algeria",
        IsoCodeAlpha2 = "DZ",
        IsoCodeAlpha3 = "DZA",
        IsoCodeNumeric = "012",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A vertical bicolor of green and white with the red crescent encircling the red five-pointed star centered along the dividing line.",
                StartDate = new DateTime(1962, 07, 03),
                Usage = FlagUsage.NationalFlag | FlagUsage.CivilEnsign | FlagUsage.StateEnsign
            }
        }
    };

    public static Country AmericanSamoa { get; } = new()
    {
        ShortName = "American Samoa",
        FullName = "American Samoa",
        IsoCodeAlpha2 = "AS",
        IsoCodeAlpha3 = "ASM",
        IsoCodeNumeric = "016",
        IsIndependent = false,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A red-edged white triangle pointing towards the hoist charged with a bald eagle clutching a war club and a fly-whisk. The white triangle divided the dark blue field into two separate triangles.",
                StartDate = new DateTime(1960, 04, 17),
                DesignedBy = "Fareti Sotoa",
                Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag
            }
        }
    };

    /// <summary>
    /// Must add civil flag and civil ensign
    /// </summary>
    public static Country Andorra { get; } = new()
    {
        ShortName = "Andorra",
        FullName = "Principality of Andorra",
        IsoCodeAlpha2 = "AD",
        IsoCodeAlpha3 = "AND",
        IsoCodeNumeric = "020",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A vertical tricolour of blue, yellow and red with the National Coat of Arms centred on the yellow band.",
                StartDate = new DateTime(1866),
                DesignedBy = "Napoleon III",
                Usage = FlagUsage.StateFlag
            }
        }
    };

    public static Country Angola { get; } = new()
    {
        ShortName = "Angola",
        FullName = "Republic of Angola",
        IsoCodeAlpha2 = "AO",
        IsoCodeAlpha3 = "AGO",
        IsoCodeNumeric = "024",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "Two horizontal bands of red and black with the Machete and Gear Emblem in the center.",
                StartDate = new DateTime(1975, 11, 11),
                DesignedBy = "Henrique de Carvalho Santos, António Alberto Neto",
                Usage = FlagUsage.NationalFlag
            }
        }
    };

    public static Country Anguilla { get; } = new()
    {
        ShortName = "Anguilla",
        FullName = "Anguilla",
        IsoCodeAlpha2 = "AI",
        IsoCodeAlpha3 = "AIA",
        IsoCodeNumeric = "660",
        IsIndependent = false,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A Blue Ensign charged in the fly with the coat of arms of Anguilla",
                Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag | FlagUsage.StateEnsign
            }
        }
    };

    public static Country Antarctica { get; } = new()
    {
        ShortName = "Antarctica",
        FullName = "Antarctica",
        IsoCodeAlpha2 = "AQ",
        IsoCodeAlpha3 = "ATA",
        IsoCodeNumeric = "010",
        IsIndependent = false,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                StartDate = new DateTime(2002, 01, 01)
            }
        }
    };

    /// <summary>
    /// Must add state ensign.
    /// </summary>
    public static Country AntiguaAndBarbuda { get; } = new()
    {
        ShortName = "Antigua and Barbuda",
        FullName = "Antigua and Barbuda",
        IsoCodeAlpha2 = "AG",
        IsoCodeAlpha3 = "ATG",
        IsoCodeNumeric = "028",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A horizontal tri-colour of black, blue (half-width), and white, with two red right scalene triangles on opposite sides. On the black band is a yellow half-sun with nine rays.",
                StartDate = new DateTime(1967, 02, 27),
                DesignedBy = "Sir Reginald Samuel",
                Usage = FlagUsage.NationalFlag | FlagUsage.CivilEnsign
            }
        }
    };

    /// <summary>
    /// Must add alternative civil flag and ensign.
    /// </summary>
    public static Country Argentina { get; } = new()
    {
        ShortName = "Argentina",
        FullName = "Argentine Republic",
        IsoCodeAlpha2 = "AR",
        IsoCodeAlpha3 = "ARG",
        IsoCodeNumeric = "032",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A horizontal triband of light blue (top and bottom) and white with a Sun of May centered on the white band.",
                StartDate = new DateTime(1861, 01, 01),
                DesignedBy = "Manuel Belgrano",
                Usage = FlagUsage.NationalFlagAndEnsign
            }
        }
    };

    public static Country Armenia { get; } = new()
    {
        ShortName = "Armenia",
        FullName = "Republic of Armenia",
        IsoCodeAlpha2 = "AM",
        IsoCodeAlpha3 = "ARM",
        IsoCodeNumeric = "051",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A horizontal tricolour of red, blue, and apricot.",
                StartDate = new DateTime(1990, 08, 24),
                DesignedBy = "Stepan Malkhasyants",
                Usage = FlagUsage.NationalFlag
            }
        }
    };

    public static Country Aruba { get; } = new()
    {
        ShortName = "Aruba",
        FullName = "Country of Aruba",
        IsoCodeAlpha2 = "AW",
        IsoCodeAlpha3 = "ABW",
        IsoCodeNumeric = "533",
        IsIndependent = false,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                StartDate = new DateTime(1976, 03, 18),
                Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag
            }
        }
    };

    /// <summary>
    /// Must add civil ensign and naval ensign and air force ensign.
    /// </summary>
    public static Country Australia { get; } = new()
    {
        ShortName = "Australia",
        FullName = "Commonwealth of Australia",
        IsoCodeAlpha2 = "AU",
        IsoCodeAlpha3 = "AUS",
        IsoCodeNumeric = "036",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A Blue Ensign defaced with the Commonwealth Star in the lower hoist quarter and the five stars of the Southern Cross in the fly half.",
                StartDate = new DateTime(1903, 12, 08),
                DesignedBy = "Annie Dorrington, Ivor Evans, Lesley Hawkins, Egbert Nutall and William Stevens",
                Usage = FlagUsage.NationalFlag | FlagUsage.StateEnsign
            }
        }
    };

    /// <summary>
    /// Must add state and war flag, state and naval ensign.
    /// </summary>
    public static Country Austria { get; } = new()
    {
        ShortName = "Austria",
        FullName = "Republic of Austria",
        IsoCodeAlpha2 = "AT",
        IsoCodeAlpha3 = "AUT",
        IsoCodeNumeric = "040",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A horizontal triband of red (top and bottom) and white.",
                StartDate = new DateTime(1945, 05, 01),
                Usage = FlagUsage.CivilFlag | FlagUsage.CivilEnsign
            }
        }
    };

    public static Country Azerbaijan { get; } = new()
    {
        ShortName = "Azerbaijan",
        FullName = "Republic of Azerbaijan",
        IsoCodeAlpha2 = "AZ",
        IsoCodeAlpha3 = "AZE",
        IsoCodeNumeric = "031",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A horizontal tricolour of bright blue, red, and green, with a white crescent and an eight-pointed star centred on a red band.",
                StartDate = new DateTime(1991, 02, 05),
                Usage = FlagUsage.NationalFlagAndEnsign
            }
        }
    };
}