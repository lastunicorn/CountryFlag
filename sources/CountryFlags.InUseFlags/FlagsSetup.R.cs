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
    public static void Reunion ()
    {
    }

    public static void Romania ()
    {
    }

    public static void Russia ()
    {
        Countries.Russia.Flags.Add(new CountryFlag
        {
            Id = "NavalEnsign",
            Names = new List<FlagName>
            {
                "Variant flag of Russia"
            },
            Description = "St. Andrew's Cross with a white background and two blue diagonal bands forming a saltire.",
            StartDate = new FlagDate(1992),
            DesignedBy = "Peter the Great",
            Usage = FlagUsage.WarEnsign
        });

        Countries.Russia.Flags.Add(new CountryFlag
        {
            Id = "President",
            Names = new List<FlagName>
            {
                new()
                {
                    NativeName = "Штандарт Президента",
                    EnglishTranslation = "Presidential standard"
                }
            },
            Description = "The square tricolour with the coat of arms (in this case the double-headed eagle is depicted without the shield) in the middle.",
            StartDate = new FlagDate(1994, 02, 15),
            Usage = FlagUsage.LeaderFlag,
            Comments = "The President of Russia uses a Presidential Standard (Russian: Штандарт Президента), which was introduced via Presidential Decree No.319 on 15 February 1994."
        });
    }

    public static void Rwanda ()
    {
        Countries.Rwanda.Flags.Add(new CountryFlag
        {
            Id = "President",
            Names = new List<FlagName>
            {
                "Presidential Flag"
            },
            Description = "Flag of the President of Rwanda",
            Usage = FlagUsage.LeaderFlag
        });
    }
}