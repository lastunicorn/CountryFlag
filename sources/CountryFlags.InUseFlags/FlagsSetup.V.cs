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

namespace DustInTheWind.CountryFlags.InUseFlags;

internal static partial class FlagsSetup
{
    public static void Vanuatu()
    {
    }

    public static void Venezuela()
    {
        Countries.Venezuela.Flags.Add(new CountryFlag
        {
            Id = "StateAndWar",
            Names = new List<FlagName>
            {
                "State and War"
            },
            Description = "A horizontal tricolour of yellow, blue and red with the National Coat of Arms on the upper hoist-side of the yellow band and an arc of eight white five-pointed stars centred on the blue band.",
            StartDate = new FlagDate(2006, 03, 12),
            DesignedBy = "Francisco de Miranda",
            Usage = FlagUsage.StateFlag | FlagUsage.WarFlag | FlagUsage.StateEnsign | FlagUsage.WarEnsign
        });

        Countries.Venezuela.Flags.Add(new CountryFlag
        {
            Id = "NavalJack",
            Names = new List<FlagName>
            {
                "Naval Jack"
            },
            Description = "A navy blue field charged with an anchor with eight five- pointed stars in an arc above it.",
            StartDate = new FlagDate(2006, 03, 12),
            Usage = FlagUsage.NavalJack
        });
    }

    public static void Vietnam()
    {
        Countries.Vietnam.Flags.Add(new CountryFlag
        {
            Id = "WarJack",
            Names = new List<FlagName>
            {
                "War Jack"
            },
            Description = "A golden star centered on a red field, and yellow words Quyết thắng (Determining to win) in the upper canton.",
            Usage = FlagUsage.WarFlag
        });

        Countries.Vietnam.Flags.Add(new CountryFlag
        {
            Id = "Police",
            Names = new List<FlagName>
            {
                "Police Flag"
            },
            Description = "A golden star centered on a red field, and yellow motto Bảo vệ an ninh Tổ quốc (Protecting the security of the Fatherland) in the upper canton.",
            Usage = FlagUsage.StateFlag
        });

        Countries.Vietnam.Flags.Add(new CountryFlag
        {
            Id = "Naval",
            Names = new List<FlagName>
            {
                "Naval Ensign"
            },
            Description = "A white flag with an emblem referring the Vietnam People's Navy in the top with the red label Hải quân Việt Nam (Navy of Vietnam) and a blue strip below.",
            StartDate = new FlagDate(2014, 10, 15),
            Usage = FlagUsage.WarEnsign
        });
    }

    public static void BritishVirginIslands()
    {
    }

    public static void UnitedStatesVirginIslands()
    {
    }
}