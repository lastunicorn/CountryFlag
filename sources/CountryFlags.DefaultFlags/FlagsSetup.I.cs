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

namespace DustInTheWind.CountryFlags.DefaultFlags;

internal static partial class FlagsSetup
{
    public static void Iceland()
    {
        Countries.Iceland.Flags.Add(new CountryFlag
        {
            Description = "A blue field with the white-edged red Nordic cross that extends to the edges; the vertical part of the cross is shifted to the hoist side.\r\nIn Blazon, \"Azure, a cross gules fimbriated argent\".",
            StartDate = new FlagDate(1944, 06, 17),
            DesignedBy = "Matthías Þórðarson",
            Usage = FlagUsage.CivilFlag | FlagUsage.CivilEnsign
        });
    }

    public static void India()
    {
        Countries.India.Flags.Add(new CountryFlag
        {
            Names = new List<FlagName>
            {
                new ()
                {
                    NativeName = "Tiraṅgā",
                    EnglishTranslation = "Tricolour"
                }
            },
            Description = "A horizontal triband of India saffron, white, and India green; charged with a navy blue wheel with 24 spokes in the centre.",
            StartDate = new FlagDate(1947, 07, 22),
            DesignedBy = "Pingali Venkayya",
            Usage = FlagUsage.NationalFlag
        });
    }

    public static void Indonesia()
    {
        Countries.Indonesia.Flags.Add(new CountryFlag
        {
            Description = "A horizontal bicolour of red and white.",
            StartDate = new FlagDate(1950, 08, 17),
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void Iran()
    {
        Countries.Iran.Flags.Add(new CountryFlag
        {
            Description = "A horizontal tricolor of green, white and red with the National Emblem in red centred on the white band and the Takbir written in the Kufic script in white, repeated 11 times along the bottom edge of the green band and 11 times along the top edge of the red band, for a total of 22 times on the fringe of the bands.",
            StartDate = new FlagDate(1980, 07, 29),
            DesignedBy = "Hamid Nadimi",
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void Iraq()
    {
        Countries.Iraq.Flags.Add(new CountryFlag
        {
            Description = "A horizontal tricolour of red, white, and black, charged with the takbīr in green Kufic script, centered on the white stripe.",
            StartDate = new FlagDate(2008, 01, 22),
            Usage = FlagUsage.StateFlag | FlagUsage.WarFlag | FlagUsage.NationalEnsign
        });
    }

    public static void Ireland()
    {
        Countries.Ireland.Flags.Add(new CountryFlag
        {
            Names = new List<FlagName>
            {
                new FlagName
                {
                    NativeName = "Bratach na hÉireann",
                    EnglishTranslation = "flag of Ireland"
                }
            },
            Description = "A vertical tricolour of green, white and orange.",
            StartDate = new FlagDate(1937),
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void IsleOfMan()
    {
        Countries.IsleOfMan.Flags.Add(new CountryFlag
        {
            Description = "A triskelion made up of three armoured legs with golden spurs, in the centre of a red flag.",
            StartDate = new FlagDate(1932, 12, 01),
            Usage = FlagUsage.CivilAndStateFlag
        });
    }

    public static void Israel()
    {
        Countries.Israel.Flags.Add(new CountryFlag
        {
            Description = "A blue Star of David between two horizontal blue stripes on a white field.",
            StartDate = new FlagDate(1948, 10, 28),
            Usage = FlagUsage.NationalFlag
        });
    }

    public static void Italy()
    {
        Countries.Italy.Flags.Add(new CountryFlag
        {
            Names = new List<FlagName>
            {
                new FlagName
                {
                    NativeName = "il Tricolore"
                }
            },
            Description = "A vertical tricolour of green, white and red.",
            StartDate = new FlagDate(1946, 06, 18),
            Usage = FlagUsage.NationalFlag
        });
    }
}