// Country Flags
// Copyright (C) 2022-2024 Dust in the Wind
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

using System.Collections.Generic;

namespace DustInTheWind.CountryFlags.OutdatedFlags;

internal static partial class FlagsSetup
{
    public static void Reunion()
    {
    }

    public static void Romania()
    {
        Countries.Romania.Flags.Add(new CountryFlag
        {
            Id = "MoldaviaAndWallachia",
            Names = new List<FlagName>
            {
                "Flag of the United Principalities of Moldavia and Wallachia"
            },
            StartDate = new FlagDate(1859),
            EndDate = new FlagDate(1862)
        });

        Countries.Romania.Flags.Add(new CountryFlag
        {
            Id = "UnitedPrincipalities",
            Names = new List<FlagName>
            {
                "Flag of the Romanian United Principalities"
            },
            StartDate = new FlagDate(1862),
            EndDate = new FlagDate(1866)
        });

        Countries.Romania.Flags.Add(new CountryFlag
        {
            Id = "UnitedRomania",
            Names = new List<FlagName>
            {
                "Flag of Romania"
            },
            StartDate = new FlagDate(1866),
            EndDate = new FlagDate(1948)
        });

        Countries.Romania.Flags.Add(new CountryFlag
        {
            Id = "PeopleRepublic1",
            Names = new List<FlagName>
            {
                "Flag of the Romanian People's Republic (1948)"
            },
            StartDate = new FlagDate(1948),
            EndDate = new FlagDate(1948)
        });

        Countries.Romania.Flags.Add(new CountryFlag
        {
            Id = "PeopleRepublic2",
            Names = new List<FlagName>
            {
                "Flag of the Romanian People's Republic (1948-1952)"
            },
            StartDate = new FlagDate(1948),
            EndDate = new FlagDate(1952)
        });

        Countries.Romania.Flags.Add(new CountryFlag
        {
            Id = "PeopleRepublic3",
            Names = new List<FlagName>
            {
                "Flag of the Romanian People's Republic (1952–1965)"
            },
            StartDate = new FlagDate(1952),
            EndDate = new FlagDate(1965)
        });

        Countries.Romania.Flags.Add(new CountryFlag
        {
            Id = "SocialistRepublic",
            Names = new List<FlagName>
            {
                "Flag of the Socialist Republic of Romania (1965–1989)"
            },
            StartDate = new FlagDate(1952),
            EndDate = new FlagDate(1965)
        });

        Countries.Romania.Flags.Add(new CountryFlag
        {
            Id = "Revolution1989",
            Names = new List<FlagName>
            {
                "Flag of the anti-Ceaușescu protesters during the Romanian Revolution"
            },
            StartDate = new FlagDate(1989, 12, 17),
            EndDate = new FlagDate(1989),
            Comments = "Starting on 17 December 1989, during the revolution at Timișoara, the protesters began waving flags with the Communist coat of arms cut out of the middle. The coat of arms was perceived as a symbol of Nicolae Ceaușescu's dictatorship. These flags were called \"the flag with the hole\" (drapelul cu gaură)."
        });
    }

    public static void Russia()
    {
    }

    public static void Rwanda()
    {
    }
}