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
    public static void Haiti()
    {
        Countries.Haiti.Flags.Add(new CountryFlag
        {
            Description = "A horizontal bicolour of blue and red, charged with the Coat of Arms in a small white box in the center.",
            StartDate = new FlagDate(1986, 02, 26),
            DesignedBy = "Catherine Flon",
            Usage = FlagUsage.StateFlag | FlagUsage.WarFlag | FlagUsage.StateEnsign | FlagUsage.WarEnsign
        });
    }

    public static void HeardIslandAndMcDonaldIslands()
    {
        Countries.HeardIslandAndMcDonaldIslands.Flags.Add(new CountryFlag
        {
            Description = "The Territory of Heard Island and McDonald Islands is an Australian external territory, and uses the Australian flag."
        });
    }

    public static void HolySee()
    {
        Countries.HolySee.Flags.Add(new CountryFlag
        {
            Description = "A vertical bicolour of gold and white, charged with the coat of arms centred on the white portion.",
            StartDate = new FlagDate(1929, 06, 07),
            Usage = FlagUsage.NationalFlag
        });
    }

    public static void Honduras()
    {
        Countries.Honduras.Flags.Add(new CountryFlag
        {
            Description = "A horizontal triband of turquoise (top and bottom) and white with five turquoise five-pointed stars arranged in an X pattern centered on the white band.",
            StartDate = new FlagDate(2022, 01, 26),
            Usage = FlagUsage.NationalFlag | FlagUsage.CivilEnsign | FlagUsage.StateEnsign
        });
    }

    public static void HongKong()
    {
        Countries.HongKong.Flags.Add(new CountryFlag
        {
            Description = "A stylised, white, five-petal Bauhinia blakeana flower in the centre of a red field.",
            StartDate = new FlagDate(1990, 04, 04),
            DesignedBy = "Tao Ho",
            Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag | FlagUsage.CivilEnsign | FlagUsage.StateEnsign
        });
    }

    public static void Hungary()
    {
        Countries.Hungary.Flags.Add(new CountryFlag
        {
            Description = "A horizontal tricolour of red, white and green.",
            StartDate = new FlagDate(1990, 06, 19),
            Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag
        });
    }
}