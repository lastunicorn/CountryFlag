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
    public static void Iceland()
    {
    }

    public static void India()
    {
        Countries.India.Flags.Add(new CountryFlag
        {
            Id = "CivilEnsign",
            Names = new List<FlagName>
            {
                new()
                {
                    EnglishTranslation = "Civil Ensign"
                },
                new()
                {
                    EnglishTranslation = "Red Ensign"
                }
            },
            Description = "A red ensign with the Indian Flag in the canton.",
            Usage = FlagUsage.CivilEnsign
        });

        Countries.India.Flags.Add(new CountryFlag
        {
            Id = "StateEnsign",
            Names = new List<FlagName>
            {
                new()
                {
                    EnglishTranslation = "State Ensign"
                },
                new()
                {
                    EnglishTranslation = "Blue Ensign"
                }
            },
            Description = "A blue ensign with the Indian Flag in the canton, and a yellow anchor horizontally in the fly.",
            Usage = FlagUsage.StateEnsign
        });

        Countries.India.Flags.Add(new CountryFlag
        {
            Id = "NavalEnsign",
            Names = new List<FlagName>
            {
                new()
                {
                    EnglishTranslation = "Naval Ensign"
                },
                new()
                {
                    EnglishTranslation = "White Ensign"
                }
            },
            Description = "A white ensign with the Indian Flag in the canton, and a blue octagon with golden borders encasing the national emblem atop an anchor superimposed on a shield with the naval motto \"Śaṁ No Varuṇaḥ\" in Devanagari in the fly.",
            Usage = FlagUsage.WarEnsign
        });

        Countries.India.Flags.Add(new CountryFlag
        {
            Id = "AirEnsign",
            Names = new List<FlagName>
            {
                new()
                {
                    EnglishTranslation = "Air Force Ensign"
                }
            },
            Description = "A sky blue ensign with the Indian Flag in the canton and the Air Force roundel in the fly.",
            Usage = FlagUsage.WarEnsign
        });
    }

    public static void Indonesia()
    {
    }

    public static void Iran()
    {
    }

    public static void Iraq()
    {
    }

    public static void Ireland()
    {
    }

    public static void IsleOfMan()
    {
    }

    public static void Israel()
    {
    }

    public static void Italy()
    {
    }
}