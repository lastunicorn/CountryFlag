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
    public static void Taiwan()
    {
        Countries.Taiwan.Flags.Add(new CountryFlag());
    }

    public static void Tajikistan()
    {
        Countries.Tajikistan.Flags.Add(new CountryFlag
        {
            Description = "A horizontal tricolour of red, white and green, with a yellow crown surmounted by an arc of seven stars at the centre.",
            StartDate = new FlagDate(1992, 11, 24),
            DesignedBy = "Zuhur Habibullaev",
            Usage = FlagUsage.NationalFlag
        });
    }

    public static void Tanzania()
    {
        Countries.Tanzania.Flags.Add(new CountryFlag
        {
            Description = "A Yellow-edged black diagonal band divided diagonally from the lower hoist-side corner: the upper triangle is green and the lower triangle is light blue.",
            StartDate = new FlagDate(1964, 06, 30),
            Usage = FlagUsage.NationalFlag | FlagUsage.CivilAndStateEnsign
        });
    }

    public static void Thailand()
    {
        Countries.Thailand.Flags.Add(new CountryFlag
        {
            Description = "Five horizontal stripes of red, white, blue, white and red, the middle stripe twice as wide as the others.",
            StartDate = new FlagDate(1917, 09, 28),
            DesignedBy = "King Vajiravudh (Rama VI)",
            Usage = FlagUsage.NationalFlag | FlagUsage.CivilAndStateEnsign
        });
    }

    public static void TimorLeste()
    {
        Countries.TimorLeste.Flags.Add(new CountryFlag
        {
            Description = "A red field with the black isosceles triangle based on the hoist-side bearing a white five-pointed star in the center superimposed on the larger yellow triangle, also based on the hoist-side, that extends to the center of the flag.",
            StartDate = new FlagDate(2002, 05, 19),
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void Togo()
    {
        Countries.Togo.Flags.Add(new CountryFlag
        {
            Description = "Five equal horizontal bands of green (top and bottom) alternating with yellow; with a red canton bearing a white five-pointed star.",
            StartDate = new FlagDate(1960, 04, 28),
            DesignedBy = "Paul Ahyi",
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void Tokelau()
    {
        Countries.Tokelau.Flags.Add(new CountryFlag
        {
            Description = "A yellow Tokelauan canoe sailing towards the Southern Cross represented by four white stars on a blue field.",
            StartDate = new FlagDate(2009, 09, 07),
            Usage = FlagUsage.StateFlag
        });
    }

    public static void Tonga()
    {
        Countries.Tonga.Flags.Add(new CountryFlag
        {
            Description = "A red field with the white rectangle on the upper hoist-side corner bearing the red Greek Cross in the centre.",
            StartDate = new FlagDate(1875, 11, 04),
            Usage = FlagUsage.CivilAndStateFlag | FlagUsage.CivilAndStateEnsign
        });
    }

    public static void TrinidadAndTobago()
    {
        Countries.TrinidadAndTobago.Flags.Add(new CountryFlag
        {
            Description = "A red field with a white-fimbriated black diagonal band from the upper hoist-side to the lower fly-side.",
            StartDate = new FlagDate(1962, 08, 31),
            DesignedBy = "Carlisle Chang",
            Usage = FlagUsage.NationalFlag
        });
    }

    public static void Tunisia()
    {
        Countries.Tunisia.Flags.Add(new CountryFlag
        {
            Description = "A red field with a centered white sun-disc containing a red five-pointed star surrounded by a red crescent.",
            StartDate = new FlagDate(1827, 10, 20),
            DesignedBy = "Hussein II",
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void Turkey()
    {
        Countries.Turkey.Flags.Add(new CountryFlag
        {
            Names = new List<FlagName>
            {
                new FlagName
                {
                    NativeName = "al bayrak",
                    EnglishTranslation = "the red flag"
                },
                new FlagName
                {
                    NativeName = "al sancak",
                    EnglishTranslation = "the red banner"
                }
            },
            Description = "A red field with a white star and crescent slightly left of center.",
            StartDate = new FlagDate(1936, 05, 29),
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void Turkmenistan()
    {
        Countries.Turkmenistan.Flags.Add(new CountryFlag
        {
            Description = "A green field with a vertical red stripe near the hoist side, containing five carpet guls stacked above two crossed olive branches; a white waxing crescent moon and five white five-pointed stars appear in the upper field, to the fly side of the red stripe.",
            StartDate = new FlagDate(2001, 01, 24),
            Usage = FlagUsage.NationalFlag
        });
    }

    public static void TurksAndCaicosIslands()
    {
        Countries.TurksAndCaicosIslands.Flags.Add(new CountryFlag
        {
            Description = "A blue ensign with the Union flag in the canton and the coat of arms of the Turks and Caicos Islands in the fly half.",
            StartDate = new FlagDate(1968, 11, 07),
            Usage = FlagUsage.NationalFlag
        });
    }

    public static void Tuvalu()
    {
        Countries.Tuvalu.Flags.Add(new CountryFlag
        {
            Description = "A Light Blue Ensign with a map of the 9 islands, using 9 yellow stars on the fly half of the flag.",
            StartDate = new FlagDate(1997, 04, 11),
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }
}