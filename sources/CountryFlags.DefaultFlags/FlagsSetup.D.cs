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

namespace DustInTheWind.CountryFlags.DefaultFlags;

internal static partial class FlagsSetup
{
    public static void Denmark()
    {
        Countries.Denmark.Flags.Add(new CountryFlag
        {
            Names = new List<FlagName>
            {
                "Dannebrog"
            },
            Description = "A white Nordic cross with a red background.",
            StartDate = new FlagDate(1625),
            Usage = FlagUsage.CivilFlag | FlagUsage.CivilEnsign
        });
    }

    public static void Djibouti()
    {
        Countries.Djibouti.Flags.Add(new CountryFlag
        {
            Names = new List<FlagName>
            {
                new()
                {
                    NativeName = "Drapeau National",
                    EnglishTranslation = "National Flag"
                },
                new()
                {
                    NativeName = "علم الوطني",
                    EnglishTranslation = "National Flag"
                }
            },
            Description = "A horizontal bicolour of light blue and light green, with a white isosceles triangle at the hoist bearing a red star in its center.",
            StartDate = new FlagDate(1977, 06, 27),
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void Dominica()
    {
        Countries.Dominica.Flags.Add(new CountryFlag
        {
            Description = "A green field with the centred cross of three bands: the vertical part is: yellow, black and white and the horizontal part is: yellow, black and white and the red disk superimposed at the centre of the cross bearing a purple Sisserou Parrot facing the hoist-side encircled by ten green five-pointed stars.",
            StartDate = new FlagDate(1990),
            DesignedBy = "Alwin Bully",
            Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag
        });
    }

    public static void DominicanRepublic()
    {
        Countries.DominicanRepublic.Flags.Add(new CountryFlag
        {
            Description = "A white cross with the national coat of arms in the centre that divides the flag into four rectangles, blue and red at the top and red and blue at the bottom.",
            StartDate = new FlagDate(1863, 11, 06),
            DesignedBy = "Juan Pablo Duarte",
            Usage = FlagUsage.StateFlag | FlagUsage.WarFlag | FlagUsage.StateEnsign | FlagUsage.WarEnsign
        });
    }
}