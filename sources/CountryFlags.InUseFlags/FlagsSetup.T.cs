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

namespace DustInTheWind.CountryFlags.InUseFlags;

internal static partial class FlagsSetup
{
    public static void Taiwan()
    {
    }

    public static void Tajikistan()
    {
    }

    public static void Tanzania()
    {
        Countries.Tanzania.Flags.Add(new CountryFlag
        {
            Id = "President",
            Names = new List<FlagName>
            {
                "Presidential Standard"
            },
            Description = "A green field with a blue border with the national coat of arms (without humans) imposed at the center."
        });
    }

    public static void Thailand()
    {
        Countries.Thailand.Flags.Add(new CountryFlag
        {
            Id = "NavalEnsign",
            Names = new List<FlagName>
            {
                "Naval Ensign"
            },
            Description = "A red disc containing a white elephant (Airavata) in regalia centered on the national flag.",
            StartDate = new FlagDate(1917, 09, 28),
            Usage = FlagUsage.WarEnsign
        });
    }

    public static void TimorLeste()
    {
    }

    public static void Togo()
    {
    }

    public static void Tokelau()
    {
    }

    public static void Tonga()
    {
    }

    public static void TrinidadAndTobago()
    {
    }

    public static void Tunisia()
    {
    }

    public static void Turkey()
    {
    }

    public static void Turkmenistan()
    {
    }

    public static void TurksAndCaicosIslands()
    {
    }

    public static void Tuvalu()
    {
    }
}