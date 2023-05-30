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
    public static void Namibia()
    {
        Countries.Namibia.Flags.Add(new CountryFlag
        {
            Description = "A white-edged red diagonal band radiating from the lower hoist-side corner. The upper triangle is blue, charged with a gold sun with 12 triangular rays and the lower triangle is green.",
            StartDate = new FlagDate(1990, 03, 21),
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void Nauru()
    {
        Countries.Nauru.Flags.Add(new CountryFlag
        {
            Description = "A blue field with the thin yellow narrow horizontal stripe across in the center and the large white twelve-pointed star on the bottom of the stripe and near the hoist-side.",
            StartDate = new FlagDate(1968, 01, 31),
            DesignedBy = new StringList
            {
                "Theo Jankowski",
                "Don Stevenson",
                "Ortrud Clay"
            },
            Usage = FlagUsage.StateFlag | FlagUsage.CivilEnsign
        });
    }

    public static void Nepal()
    {
        Countries.Nepal.Flags.Add(new CountryFlag
        {
            Description = "The national flag of Nepal consists of two juxtaposed triangular figures with a crimson-coloured base and deep blue borders, there being a white emblem of the crescent moon with eight rays visible out of sixteen in the upper part and a white emblem of a twelve rayed sun in the lower part.",
            StartDate = new FlagDate(1962, 12, 16),
            Usage = FlagUsage.NationalFlag
        });
    }

    public static void Netherlands()
    {
        Countries.Netherlands.Flags.Add(new CountryFlag
        {
            Description = "A horizontal triband of red (bright vermilion), white, and cobalt blue",
            StartDate = new FlagDate(1575),
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void NewCaledonia()
    {
        Countries.NewCaledonia.Flags.Add(new CountryFlag
        {
            Description = "A vertical tricolour of blue, white, and red.",
            StartDate = new FlagDate(1794, 02, 15),
            Usage = FlagUsage.NationalFlag
        });

        Countries.NewCaledonia.Flags.Add(new CountryFlag
        {
            Id = "FLNKS",
            Description = "A horizontal tricolour of blue, red, and green charged with a yellow disc outlined in black and defaced with a black flèche faîtière.",
            StartDate = new FlagDate(2010, 07, 13),
            Usage = FlagUsage.NationalFlag
        });
    }

    public static void NewZealand()
    {
        Countries.NewZealand.Flags.Add(new CountryFlag
        {
            Description = "A Blue Ensign with a Union Jack in the first quarter and four five-pointed red stars with white borders on the fly representing the Southern Cross.",
            StartDate = new FlagDate(1902, 03, 24),
            DesignedBy = "Albert Hastings Markham",
            Usage = FlagUsage.NationalFlag | FlagUsage.StateEnsign
        });
    }

    public static void Nicaragua()
    {
        Countries.Nicaragua.Flags.Add(new CountryFlag
        {
            Description = "A horizontal triband of Azure (top and bottom) and white with the National Coat of Arms centered on the white band.",
            StartDate = new FlagDate(1908, 09, 04),
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void Niger()
    {
        Countries.Niger.Flags.Add(new CountryFlag
        {
            Description = "A horizontal triband of orange, white and green; charged with an orange circle in the centre.",
            StartDate = new FlagDate(1959, 11, 23),
            Usage = FlagUsage.NationalFlag
        });
    }

    public static void Nigeria()
    {
        Countries.Nigeria.Flags.Add(new CountryFlag
        {
            Description = "A vertical bicolour triband of green, white and green.",
            StartDate = new FlagDate(1960, 10, 01),
            DesignedBy = "Michael Taiwo Akinkunmi",
            Usage = FlagUsage.NationalFlag
        });
    }

    public static void Niue()
    {
        Countries.Niue.Flags.Add(new CountryFlag
        {
            Description = "A golden yellow flag with the Union flag in the upper left (hoist) quarter of the flags. On the Union Jack are two yellow five-pointed stars on the vertical stripe and two on the horizontal stripe. In the centre of the Union flag is a blue disc with another, slightly larger, yellow five-pointed star.",
            StartDate = new FlagDate(1975, 10, 15),
            DesignedBy = "Patricia Rex",
            Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag
        });
    }

    public static void NorfolkIsland()
    {
        Countries.NorfolkIsland.Flags.Add(new CountryFlag
        {
            Description = "Norfolk Island pine (Araucaria heterophylla) in a central white stripe between two green stripes.",
            StartDate = new FlagDate(1979, 07, 09),
            Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag
        });
    }

    public static void NorthMacedonia()
    {
        Countries.NorthMacedonia.Flags.Add(new CountryFlag
        {
            Description = "A stylised yellow sun on a red field, with eight broadening rays extending from the centre to the edge of the field.",
            StartDate = new FlagDate(1995, 10, 05),
            DesignedBy = "Miroslav Grčev",
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void NorthernMarianaIslands()
    {
        Countries.NorthernMarianaIslands.Flags.Add(new CountryFlag
        {
            Description = "A circle of flowers and plants with a gray sculpture and a white star on a blue field.",
            StartDate = new FlagDate(1985, 07),
            Usage = FlagUsage.StateFlag | FlagUsage.WarFlag
        });
    }

    public static void Norway()
    {
        Countries.Norway.Flags.Add(new CountryFlag
        {
            Description = "A red field charged with a white-fimbriated dark blue Nordic cross that extends to the edges; the vertical part of the cross is shifted to the hoist side.",
            StartDate = new FlagDate(1821, 07, 13),
            DesignedBy = "Fredrik Meltzer",
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }
}