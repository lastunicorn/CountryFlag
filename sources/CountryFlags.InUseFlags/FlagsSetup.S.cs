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
    public static void SaintBarthelemy()
    {
    }

    public static void SaintHelena()
    {
    }

    public static void SaintKittsAndNevis()
    {
    }

    public static void SaintLucia()
    {
    }

    public static void SaintMartin()
    {
    }

    public static void SaintPierreAndMiquelon()
    {
    }

    public static void SaintVincentAndTheGrenadines()
    {
    }

    public static void Samoa()
    {
    }

    public static void SanMarino()
    {
        Countries.SanMarino.Flags.Add(new CountryFlag
        {
            Id = "State",
            Names = new List<FlagName>
            {
                "State flag"
            },
            Description = "A horizontal bicolour of white and light blue; charged with the national coat of arms in the centre.",
            StartDate = new FlagDate(2011, 07, 22),
            Usage = FlagUsage.StateFlag | FlagUsage.WarFlag
        });
    }

    public static void SaoTomeAndPrincipe()
    {
    }

    public static void SaudiArabia()
    {
        Countries.SaudiArabia.Flags.Add(new CountryFlag
        {
            Id = "Alternate",
            Description = "A green field with the Shahada or Muslim creed written in the Thuluth script in white above a horizontal sword, having its tip pointed to the left.",
            StartDate = new FlagDate(1973, 03, 15),
            Usage = FlagUsage.StateFlag | FlagUsage.WarFlag | FlagUsage.StateEnsign | FlagUsage.WarEnsign
        });
    }

    public static void Senegal()
    {
    }

    public static void Serbia()
    {
        Countries.Serbia.Flags.Add(new CountryFlag
        {
            Id = "Civil",
            Names = new List<FlagName>
            {
                "Civil flag"
            },
            Description = "Horizontal tricolour of red, blue, and white.",
            StartDate = new FlagDate(2004),
            Usage = FlagUsage.CivilAndStateFlag | FlagUsage.CivilEnsign
        });
    }

    public static void Seychelles()
    {
    }

    public static void SierraLeone()
    {
        Countries.SierraLeone.Flags.Add(new CountryFlag
        {
            Id = "NationalEnsign",
            Names = new List<FlagName>
            {
                "National ensign"
            },
            Description = "White flag with the national flag in canton.",
            StartDate = new FlagDate(1961, 04, 27),
            Usage = FlagUsage.NationalEnsign
        });

        Countries.SierraLeone.Flags.Add(new CountryFlag
        {
            Id = "President",
            Names = new List<FlagName>
            {
                "Standard of the President"
            },
            Usage = FlagUsage.LeaderFlag
        });
    }

    public static void Singapore()
    {
    }

    public static void SintMaarten()
    {
        Countries.SintMaarten.Flags.Add(new CountryFlag
        {
            Id = "Governor",
            Names = new List<FlagName>
            {
                "Standard of the Governor"
            },
            Usage = FlagUsage.LeaderFlag
        });
    }

    public static void Slovakia()
    {
        Countries.Slovakia.Flags.Add(new CountryFlag
        {
            Id = "President",
            Names = new List<FlagName>
            {
                "Presidential standard"
            },
            StartDate = new FlagDate(1993),
            Usage = FlagUsage.LeaderFlag
        });
    }

    public static void Slovenia()
    {
    }

    public static void SolomonIslands()
    {
    }

    public static void Somalia()
    {
    }

    public static void SouthAfrica()
    {
    }

    public static void SouthGeorgiaAndTheSouthSandwichIslands()
    {
    }

    public static void SouthSudan()
    {
    }

    public static void Spain()
    {
    }

    public static void SriLanka()
    {
    }

    public static void Sudan()
    {
    }

    public static void Suriname()
    {
    }

    public static void SvalbardAndJanMayen()
    {
    }

    public static void Sweden()
    {
        Countries.Sweden.Flags.Add(new CountryFlag
        {
            Id = "War",
            Names = new List<FlagName>
            {
                "Military Flag"
            },
            Description = "Blue with a yellow Nordic cross that extends to the edges of the flag. Overall ratio, including the tails, is 1:2",
            StartDate = new FlagDate(1906, 06, 22),
            Usage = FlagUsage.WarFlag | FlagUsage.WarEnsign
        });
    }

    public static void Switzerland()
    {
        Countries.Switzerland.Flags.Add(new CountryFlag
        {
            Id = "Ensign",
            Names = new List<FlagName>
            {
                "Civil and state ensign"
            },
            Description = "Red flag with a white cross in the centre and background in red.",
            StartDate = new FlagDate(1882),
            Usage = FlagUsage.CivilEnsign | FlagUsage.StateEnsign
        });
    }

    public static void SyrianArabRepublic()
    {
    }
}