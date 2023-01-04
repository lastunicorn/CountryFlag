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
    public static Country Reunion { get; } = new()
    {
        ShortName = "Réunion",
        FullName = "Réunion",
        IsoCodeAlpha2 = "RE",
        IsoCodeAlpha3 = "REU",
        IsoCodeNumeric = "638",
        IsIndependent = false,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A vertical tricolour of blue, white, and red.",
                StartDate = new DateTime(1794, 02, 15),
                Usage = FlagUsage.NationalFlag | FlagUsage.CivilEnsign | FlagUsage.StateEnsign
            }
        }
    };

    public static Country Romania { get; } = new()
    {
        ShortName = "Romania",
        FullName = "Romania",
        IsoCodeAlpha2 = "RO",
        IsoCodeAlpha3 = "ROU",
        IsoCodeNumeric = "642",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A vertical tricolor of blue, yellow, and red.",
                StartDate = new DateTime(1989, 12, 27),
                Usage = FlagUsage.NationalFlagAndEnsign
            },
            new()
            {
                Id = "MoldaviaAndWallachia",
                Names = new List<FlagName>
                {
                    "Flag of the United Principalities of Moldavia and Wallachia"
                },
                StartDate = new DateTime(1859, 01, 01),
                EndDate = new DateTime(1862, 01, 01)
            },
            new()
            {
                Id = "UnitedPrincipalities",
                Names = new List<FlagName>
                {
                    "Flag of the Romanian United Principalities"
                },
                StartDate = new DateTime(1862, 01, 01),
                EndDate = new DateTime(1866, 01, 01)
            },
            new()
            {
                Id = "UnitedRomania",
                Names = new List<FlagName>
                {
                    "Flag of Romania"
                },
                StartDate = new DateTime(1866, 01, 01),
                EndDate = new DateTime(1948, 01, 01)
            },
            new()
            {
                Id = "PeopleRepublic1",
                Names = new List<FlagName>
                {
                    "Flag of the Romanian People's Republic (1948)"
                },
                StartDate = new DateTime(1948, 01, 01),
                EndDate = new DateTime(1948, 03, 01)
            },
            new()
            {
                Id = "PeopleRepublic2",
                Names = new List<FlagName>
                {
                    "Flag of the Romanian People's Republic (1948-1952)"
                },
                StartDate = new DateTime(1948, 01, 01),
                EndDate = new DateTime(1952, 01, 01)
            },
            new()
            {
                Id = "PeopleRepublic3",
                Names = new List<FlagName>
                {
                    "Flag of the Romanian People's Republic (1952–1965)"
                },
                StartDate = new DateTime(1952, 01, 01),
                EndDate = new DateTime(1965, 01, 01)
            },
            new()
            {
                Id = "SocialistRepublic",
                Names = new List<FlagName>
                {
                    "Flag of the Socialist Republic of Romania (1965–1989)"
                },
                StartDate = new DateTime(1952, 01, 01),
                EndDate = new DateTime(1965, 01, 01)
            },
            new()
            {
                Id = "Revolution1989",
                Names = new List<FlagName>
                {
                    "Flag of the anti-Ceaușescu protesters during the Romanian Revolution"
                },
                StartDate = new DateTime(1989, 12, 17),
                EndDate = new DateTime(1965, 01, 01),
                Comments = "Starting on 17 December 1989, during the revolution at Timișoara, the protesters began waving flags with the Communist coat of arms cut out of the middle. The coat of arms was perceived as a symbol of Nicolae Ceaușescu's dictatorship. These flags were called \"the flag with the hole\" (drapelul cu gaură)."
            }
        }
    };

    public static Country Russia { get; } = new()
    {
        ShortName = "Russia",
        FullName = "Russian Federation",
        IsoCodeAlpha2 = "RU",
        IsoCodeAlpha3 = "RUS",
        IsoCodeNumeric = "643",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Names = new List<FlagName>
                {
                    new()
                    {
                        NativeName = "Флаг России",
                        Romanized = "Flag Rossii",
                        EnglishTranslation = "The national flag of Russia"
                    },
                    new()
                    {
                        NativeName = "Государственный флаг Российской Федерации",
                        Romanized = "Gosudarstvenny flag Rossiyskoy Federatsii",
                        EnglishTranslation = "The State Flag of the Russian"
                    },
                    new()
                    {
                        NativeName = "Триколор",
                        Romanized = "Trikolor",
                        EnglishTranslation = "Tricolour"
                    }
                },
                Description = "A horizontal tricolour of white, dark blue and red.",
                StartDate = new DateTime(2000, 12, 25),
                DesignedBy = "Peter the Great",
                Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag | FlagUsage.CivilEnsign | FlagUsage.StateEnsign
            },
            new()
            {
                Id = "NavalEnsign",
                Names = new List<FlagName>
                {
                    "Variant flag of Russia"
                },
                Description = "St. Andrew's Cross with a white background and two blue diagonal bands forming a saltire.",
                StartDate = new DateTime(1992, 01, 01),
                DesignedBy = "Peter the Great",
                Usage = FlagUsage.WarEnsign
            },
            new()
            {
                Id = "President",
                Names = new List<FlagName>
                {
                    new()
                    {
                        NativeName = "Штандарт Президента",
                        EnglishTranslation = "Presidential standard"
                    }
                },
                Description = "The square tricolour with the coat of arms (in this case the double-headed eagle is depicted without the shield) in the middle.",
                StartDate = new DateTime(1994, 02, 15),
                Usage = FlagUsage.LeaderFlag,
                Comments = "The President of Russia uses a Presidential Standard (Russian: Штандарт Президента), which was introduced via Presidential Decree No.319 on 15 February 1994."
            }
        }
    };

    public static Country Rwanda { get; } = new()
    {
        ShortName = "Rwanda",
        FullName = "Republic of Rwanda",
        IsoCodeAlpha2 = "RW",
        IsoCodeAlpha3 = "RWA",
        IsoCodeNumeric = "646",
        IsIndependent = true,
        FlagsInternal = new CountryFlagCollection
        {
            new()
            {
                Description = "A horizontal tricolour of light blue (double width), yellow and green; charged with a sun-yellow sun in the upper-fly side corner.",
                StartDate = new DateTime(2001, 10, 25),
                DesignedBy = "Alphonse Kirimobenecyo",
                Usage = FlagUsage.NationalFlag
            },
            new()
            {
                Id = "President",
                Names = new List<FlagName>
                {
                    "Presidential Flag"
                },
                Description = "Flag of the President of Rwanda",
                Usage = FlagUsage.LeaderFlag
            }
        }
    };
}