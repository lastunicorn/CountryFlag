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
    public static void Vanuatu()
    {
        Countries.Vanuatu.Flags.Add(new CountryFlag
        {
            Description = "A horizontal bicolor of red and green with a golden pall, fimbriated in black, with a black chevron filling the lefthand space and two gold crossed namele cycad fronds encircled in a gold boar tusk centered on the chevron.",
            StartDate = new FlagDate(1980, 02, 18),
            DesignedBy = "Kalontas Mahlon",
            Usage = FlagUsage.NationalFlag | FlagUsage.CivilAndStateEnsign
        });
    }

    public static void Venezuela()
    {
        Countries.Venezuela.Flags.Add(new CountryFlag
        {
            Description = "A horizontal tricolour of yellow, blue and red with an arc of eight white five-pointed stars centred on the blue band.",
            StartDate = new FlagDate(1896, 03, 12),
            DesignedBy = "Francisco de Miranda",
            Usage = FlagUsage.NationalFlag | FlagUsage.CivilEnsign
        });
    }

    public static void Vietnam()
    {
        Countries.Vietnam.Flags.Add(new CountryFlag
        {
            Names = new List<FlagName>
            {
                new()
                {
                    NativeName = "Cờ đỏ sao vàng",
                    EnglishTranslation = "red flag with a golden star"
                },
                new()
                {
                    NativeName = "Cờ Tổ quốc",
                    EnglishTranslation = "flag of the Fatherland"
                }
            },
            Description = "A large yellow star centered on a red field.",
            StartDate = new FlagDate(1976),
            DesignedBy = "Nguyễn Hữu Tiến",
            Usage = FlagUsage.CivilAndStateFlag
        });
    }

    public static void BritishVirginIslands()
    {
        Countries.BritishVirginIslands.Flags.Add(new CountryFlag
        {
            Description = "A blue ensign with the Union flag in the top left hand corner and the coat of arms centre-right.",
            StartDate = new FlagDate(1960, 11, 15),
            Usage = FlagUsage.NationalFlag
        });
    }

    public static void UnitedStatesVirginIslands()
    {
        Countries.UnitedStatesVirginIslands.Flags.Add(new CountryFlag
        {
            Description = "A simplified version of the coat of arms of the United States between the letters V and I (for Virgin Islands). The yellow-colored eagle holds a sprig of laurel in one talon, and three arrows in the other. The blue color in the shield on the eagle's breast is the same color as that of the flag and shield of the United States.",
            StartDate = new FlagDate(1921, 05, 17),
            Usage = FlagUsage.CivilAndStateFlag
        });
    }
}