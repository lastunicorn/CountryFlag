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

using System.Collections.Generic;

namespace DustInTheWind.CountryFlags.Default;

public static partial class FlagsSetup
{
    public static void SaintBarthelemy()
    {
        Countries.SaintBarthelemy.Flags.Add(new CountryFlag
        {
            Names = new List<FlagName>
            {
                "Flag of France"
            },
            StartDate = new FlagDate(1794, 02, 15),
            Usage = FlagUsage.NationalFlag | FlagUsage.CivilAndStateEnsign
        });
    }

    public static void SaintHelenaAscensionAndTristanDdaCunha()
    {
        Countries.SaintHelenaAscensionAndTristanDdaCunha.Flags.Add(new CountryFlag
        {
            Names = new List<FlagName>
            {
                "United Kingdom Flag"
            },
            Description = "The United Kingdom's flag",
            Comments = "Saint Helena, Ascension and Tristan da Cunha, a British Overseas Territory, does not have its own flag; however, the three administrative divisions do have their own flags."
        });
    }

    public static void SaintKittsAndNevis()
    {
        Countries.SaintKittsAndNevis.Flags.Add(new CountryFlag
        {
            Description = "A yellow-edged black diagonal band bearing two white five-pointed stars divided diagonally from the lower hoist-side corner to the upper fly-side corner: the upper triangle is green and the lower triangle is red.",
            StartDate = new FlagDate(1983, 09, 19),
            Usage = FlagUsage.NationalFlag | FlagUsage.CivilAndStateEnsign
        });
    }

    public static void SaintLucia()
    {
        Countries.SaintLucia.Flags.Add(new CountryFlag
        {
            Description = "A light blue field with a small golden isosceles triangle in front of a large white-edged black isosceles triangle in the centre.",
            StartDate = new FlagDate(1967, 03, 01),
            DesignedBy = "Dunstan St Omer",
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void SaintMartin()
    {
        Countries.SaintMartin.Flags.Add(new CountryFlag
        {
            Names = new List<FlagName>
            {
                "Flag of France"
            },
            StartDate = new FlagDate(1794, 02, 15),
            Usage = FlagUsage.NationalFlag | FlagUsage.CivilAndStateEnsign
        });
    }

    public static void SaintPierreAndMiquelon()
    {
        Countries.SaintPierreAndMiquelon.Flags.Add(new CountryFlag
        {
            Names = new List<FlagName>
            {
                "Flag of France"
            }
        });
    }

    public static void SaintVincentAndTheGrenadines()
    {
        Countries.SaintVincentAndTheGrenadines.Flags.Add(new CountryFlag
        {
            Description = "A Canadian pale triband of blue, gold, and green, with three green diamonds in the centre arranged to form the letter \"V\".",
            StartDate = new FlagDate(1985, 10, 12),
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void Samoa()
    {
        Countries.Samoa.Flags.Add(new CountryFlag
        {
            Description = "A red field with the blue rectangle on the upper hoist-side quadrant bearing the Southern Cross of four white larger five-pointed stars and the smaller star in the center.",
            StartDate = new FlagDate(1962, 01, 01),
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void SanMarino()
    {
        Countries.SanMarino.Flags.Add(new CountryFlag
        {
            Names = new List<FlagName>
            {
                "Civil flag"
            },
            Description = "Plain white-blue bicolor.",
            Usage = FlagUsage.CivilFlag | FlagUsage.CivilEnsign
        });
    }

    public static void SaoTomeAndPrincipe()
    {
        Countries.SaoTomeAndPrincipe.Flags.Add(new CountryFlag
        {
            Description = "A horizontal tricolour of green, yellow and green; with a red triangle based at the hoist and two five-pointed black stars of Africa in the yellow stripe.",
            StartDate = new FlagDate(1975, 07, 12),
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void SaudiArabia()
    {
        Countries.SaudiArabia.Flags.Add(new CountryFlag
        {
            Description = "A green field with the Shahada or Muslim creed written in the Thuluth script in white above a horizontal sword, having its tip pointed to the left.",
            StartDate = new FlagDate(1973, 03, 15),
            Usage = FlagUsage.StateFlag | FlagUsage.WarFlag | FlagUsage.StateEnsign | FlagUsage.WarEnsign
        });
    }

    public static void Senegal()
    {
        Countries.Senegal.Flags.Add(new CountryFlag
        {
            Description = "A vertical tricolour of green, yellow and red; charged with a green five-pointed star at the centre.",
            StartDate = new FlagDate(1960, 08, 20),
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void Serbia()
    {
        Countries.Serbia.Flags.Add(new CountryFlag
        {
            Names = new List<FlagName>
            {
                "State flag"
            },
            Description = "A horizontal tricolour of red, blue, and white; charged with the lesser Coat of arms left of center.",
            StartDate = new FlagDate(2010),
            Usage = FlagUsage.StateFlag | FlagUsage.StateEnsign
        });
    }

    public static void Seychelles()
    {
        Countries.Seychelles.Flags.Add(new CountryFlag
        {
            Description = "Five oblique bands of blue, yellow, red, white and green radiating from the bottom of the hoist side.",
            StartDate = new FlagDate(1996, 01, 08),
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void SierraLeone()
    {
        Countries.SierraLeone.Flags.Add(new CountryFlag
        {
            Description = "A horizontal tricolour of light green, white and light blue.",
            StartDate = new FlagDate(1961, 04, 27),
            Usage = FlagUsage.NationalFlag | FlagUsage.CivilAndStateEnsign
        });
    }

    public static void Singapore()
    {
        Countries.Singapore.Flags.Add(new CountryFlag
        {
            Description = "A horizontal bicolour of red and white; charged in white in the canton with a crescent facing the fly and a pentagon of five stars representing the nation's ideals.",
            StartDate = new FlagDate(1965, 08, 09),
            Usage = FlagUsage.NationalFlag
        });
    }

    public static void SintMaarten()
    {
        Countries.SintMaarten.Flags.Add(new CountryFlag
        {
            StartDate = new FlagDate(1985, 06, 13),
            DesignedBy = "Roselle Richardson",
            Usage = FlagUsage.CivilAndStateFlag | FlagUsage.StateEnsign
        });
    }

    public static void Slovakia()
    {
        Countries.Slovakia.Flags.Add(new CountryFlag
        {
            Description = "A horizontal tricolor of white, blue, and red; charged with coat of arms at the hoist side.",
            StartDate = new FlagDate(1992, 09, 03),
            Usage = FlagUsage.NationalFlag,
            DesignedBy = new StringList
            {
                "Ladislav Čisárik",
                "Ladislav Vrtel"
            }
        });
    }

    public static void Slovenia()
    {
        Countries.Slovenia.Flags.Add(new CountryFlag());
    }

    public static void SolomonIslands()
    {
        Countries.SolomonIslands.Flags.Add(new CountryFlag());
    }

    public static void Somalia()
    {
        Countries.Somalia.Flags.Add(new CountryFlag());
    }

    public static void SouthAfrica()
    {
        Countries.SouthAfrica.Flags.Add(new CountryFlag());
    }

    public static void SouthGeorgiaAndTheSouthSandwichIslands()
    {
        Countries.SouthGeorgiaAndTheSouthSandwichIslands.Flags.Add(new CountryFlag());
    }

    public static void SouthSudan()
    {
        Countries.SouthSudan.Flags.Add(new CountryFlag());
    }

    public static void Spain()
    {
        Countries.Spain.Flags.Add(new CountryFlag());
    }

    public static void SriLanka()
    {
        Countries.SriLanka.Flags.Add(new CountryFlag());
    }

    public static void Sudan()
    {
        Countries.Sudan.Flags.Add(new CountryFlag());
    }

    public static void Suriname()
    {
        Countries.Suriname.Flags.Add(new CountryFlag());
    }

    public static void SvalbardAndJanMayen()
    {
        Countries.SvalbardAndJanMayen.Flags.Add(new CountryFlag());
    }

    public static void Sweden()
    {
        Countries.Sweden.Flags.Add(new CountryFlag());
    }

    public static void Switzerland()
    {
        Countries.Switzerland.Flags.Add(new CountryFlag());
    }

    public static void SyrianArabRepublic()
    {
        Countries.SyrianArabRepublic.Flags.Add(new CountryFlag());
    }
}