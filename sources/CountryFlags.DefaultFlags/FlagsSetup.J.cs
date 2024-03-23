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
    public static void Jamaica()
    {
        Countries.Jamaica.Flags.Add(new CountryFlag());
    }

    public static void Japan()
    {
        Countries.Japan.Flags.Add(new CountryFlag
        {
            Names = new List<FlagName>
            {
                new()
                {
                    NativeName = "日章旗",
                    EnglishTranslation = "flag of the sun",
                    Romanized = "Nisshoki"
                },
                new()
                {
                    NativeName = "日の丸",
                    EnglishTranslation = "Ball of the sun",
                    Romanized = "Hinomaru"
                }
            },
            Description = "A white background with a large crimson dot in the middle",
            StartDate = new FlagDate(1999, 08, 13),
            Usage = FlagUsage.CivilAndStateFlag | FlagUsage.CivilAndStateEnsign
        });
    }

    public static void Jersey()
    {
        Countries.Jersey.Flags.Add(new CountryFlag());
    }

    public static void Jordan()
    {
        Countries.Jordan.Flags.Add(new CountryFlag());
    }
}