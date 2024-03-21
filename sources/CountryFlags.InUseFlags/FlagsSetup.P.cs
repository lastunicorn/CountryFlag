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
    public static void Pakistan()
    {
        Countries.Pakistan.Flags.Add(new CountryFlag
        {
            Id = "CivilEnsign",
            Names = new List<FlagName>
            {
                "Civil ensign"
            },
            Description = "A red field with the national flag in the canton.",
            Usage = FlagUsage.CivilEnsign
        });

        Countries.Pakistan.Flags.Add(new CountryFlag
        {
            Id = "NavalEnsign",
            Names = new List<FlagName>
            {
                "Naval ensign"
            },
            Description = "A lengthened version of the national flag.",
            Usage = FlagUsage.WarEnsign
        });
    }

    public static void Palau()
    {
        Countries.Palau.Flags.Add(new CountryFlag
        {
            Id = "President",
            Names = new List<FlagName>
            {
                "Standard of the President"
            },
            Usage = FlagUsage.LeaderFlag
        });
    }

    public static void Palestine()
    {
        Countries.Palestine.Flags.Add(new CountryFlag
        {
            Id = "President",
            Names = new List<FlagName>
            {
                "Presidential standard"
            },
            Description = "A horizontal tricolour of black, white, and green; with a red triangle based at the hoist charged with the national emblem above two crossed white swords in the upper hoist corner.",
            Usage = FlagUsage.LeaderFlag
        });
    }

    public static void Panama()
    {
        Countries.Panama.Flags.Add(new CountryFlag
        {
            Id = "President",
            Names = new List<FlagName>
            {
                "Presidential standard"
            },
            Description = "The national flag with the Coat of arms of Panama charged on the center.",
            Usage = FlagUsage.LeaderFlag
        });
    }

    public static void PapuaNewGuinea()
    {
        Countries.PapuaNewGuinea.Flags.Add(new CountryFlag
        {
            Id = "NavalEnsign",
            Names = new List<FlagName>
            {
                "Naval ensign"
            },
            Description = "A white flag with the national flag of Papua New Guinea in the canton.",
            Usage = FlagUsage.NationalEnsign
        });
    }

    public static void Paraguay()
    {
        Countries.Paraguay.Flags.Add(new CountryFlag
        {
            Id = "ReverseSide",
            Names = new List<FlagName>
            {
                "Reverse side"
            },
            Description = "A horizontal triband of red, white and blue, defaced on the reverse with the reversed coat of arms of Paraguay.",
            StartDate = new FlagDate(2013, 07, 15),
            Usage = FlagUsage.NationalFlagAndEnsign
        });

        Countries.Paraguay.Flags.Add(new CountryFlag
        {
            Id = "President",
            Names = new List<FlagName>
            {
                "Presidential standard"
            },
            Usage = FlagUsage.LeaderFlag
        });

        Countries.Paraguay.Flags.Add(new CountryFlag
        {
            Id = "NavalJack",
            Names = new List<FlagName>
            {
                "Naval Jack"
            },
            Usage = FlagUsage.NavalJack
        });
    }

    public static void Peru()
    {
        Countries.Peru.Flags.Add(new CountryFlag
        {
            Id = "State",
            Names = new List<FlagName>
            {
                "State flag and ensign"
            },
            Description = "A vertical triband of red (hoist-side and fly-side) and white with the National Coat of Arms centered on the white band.",
            StartDate = new FlagDate(1950, 03, 31),
            Usage = FlagUsage.StateFlag | FlagUsage.StateEnsign
        });

        Countries.Peru.Flags.Add(new CountryFlag
        {
            Id = "War",
            Names = new List<FlagName>
            {
                "War flag"
            },
            Description = "A vertical triband of red (hoist-side and fly-side) and white.",
            Usage = FlagUsage.WarFlag | FlagUsage.WarEnsign
        });

        Countries.Peru.Flags.Add(new CountryFlag
        {
            Id = "NavalJack",
            Names = new List<FlagName>
            {
                "Naval Jack"
            },
            Description = "A red square with the white square in the center bearing the Coat of Arms (Escudo de Armas) in the center.",
            Usage = FlagUsage.NavalJack
        });
    }

    public static void Philippines()
    {
        Countries.Philippines.Flags.Add(new CountryFlag
        {
            Id = "War",
            Names = new List<FlagName>
            {
                "War flag and ensign"
            },
            Description = "As above, with the blue and red stripes switched to indicate a state of war.",
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void Pitcairn()
    {
    }

    public static void Poland()
    {
        Countries.Poland.Flags.Add(new CountryFlag
        {
            Id = "StateFlag",
            Names = new List<FlagName>
            {
                "State flag and civil and state ensign"
            },
            Description = "A horizontal bicolour of white and red defaced with the arms of Poland in the white stripe.",
            StartDate = new FlagDate(1990),
            Usage = FlagUsage.StateFlag | FlagUsage.CivilEnsign | FlagUsage.StateEnsign
        });

        Countries.Poland.Flags.Add(new CountryFlag
        {
            Id = "NavalEnsign",
            Names = new List<FlagName>
            {
                "Naval ensign"
            },
            Description = "A flag consisting of two stripes, white and red, terminated in two triangular tongues on a free leech. In the center of the white strip, in the part between the louvre and the apex of the indentation between the tongues, is the emblem of the Republic of Poland.",
            StartDate = new FlagDate(1993, 02, 19),
            Usage = FlagUsage.WarEnsign
        });

        Countries.Poland.Flags.Add(new CountryFlag
        {
            Id = "President",
            Names = new List<FlagName>
            {
                "Presidential standard"
            },
            Description = "Crowned white eagle in a red field bordered with a white wavy line.",
            StartDate = new FlagDate(1996, 01, 26),
            Usage = FlagUsage.WarEnsign
        });
    }

    public static void Portugal()
    {
        Countries.Poland.Flags.Add(new CountryFlag
        {
            Id = "War",
            Names = new List<FlagName>
            {
                "National colour of military units"
            },
            Description = "As above, but evenly striped (1:1) and with the greater coat of arms, displaying a white scroll with the motto \"Esta é a ditosa pátria minha amada\" (\"This is my beloved blissful homeland\"), taken from Os Lusíadas, III, 21, v. 1",
            StartDate = new FlagDate(1911, 06, 30),
            Usage = FlagUsage.WarFlag
        });
    }

    public static void PuertoRico()
    {
        Countries.PuertoRico.Flags.Add(new CountryFlag
        {
            Id = "DarkBlue",
            Names = new List<FlagName>
            {
                "Flag version with dark blue tone"
            },
            Description = "Five equal horizontal bands of red (top and bottom) alternating with white; blue equilateral triangle based on the hoist side bears a large, white, five-pointed star in the center. (Official colors of the flag)",
            StartDate = new FlagDate(1952),
            Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag | FlagUsage.CivilEnsign | FlagUsage.StateEnsign
        });
    }
}