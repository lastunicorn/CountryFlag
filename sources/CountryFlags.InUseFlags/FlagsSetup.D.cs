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
    public static void Denmark()
    {
        Countries.Denmark.Flags.Add(new CountryFlag
        {
            Id = "Splitflaget",
            Names = new List<FlagName>
            {
                new()
                {
                    NativeName = "Splitflaget",
                    EnglishTranslation = "The national flag of Denmark"
                },
                new()
                {
                    NativeName = "Rigets flag",
                    EnglishTranslation = "Flag of the Kingdom [of Denmark]"
                }
            },
            Usage = FlagUsage.StateFlag | FlagUsage.WarFlag | FlagUsage.StateEnsign
        });
    }

    public static void Djibouti()
    {
    }

    public static void Dominica()
    {
        Countries.Dominica.Flags.Add(new CountryFlag
        {
            Id = "President",
            Names = new List<FlagName>
            {
                "President's flag"
            },
            Description = "A green field with the coat of arms of Dominica at the centre.",
            Usage = FlagUsage.LeaderFlag
        });
    }

    public static void DominicanRepublic()
    {
        Countries.DominicanRepublic.Flags.Add(new CountryFlag
        {
            Id = "Civil",
            Names = new List<FlagName>
            {
                "Civil flag and ensign"
            },
            Description = "Quarterly, the first and fourth quarters blue and the second and third quarters red, with a white cross overall.",
            Usage = FlagUsage.CivilFlag | FlagUsage.CivilEnsign
        });
    }
}