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

namespace DustInTheWind.CountryFlags.Present;

public static partial class FlagsSetup
{
    public static void Namibia()
    {
    }

    public static void Nauru()
    {
    }

    public static void Nepal()
    {
    }

    public static void Netherlands()
    {
    }

    public static void NewCaledonia()
    {
    }

    public static void NewZealand()
    {
    }

    public static void Nicaragua()
    {
    }

    public static void Niger()
    {
    }

    public static void Nigeria()
    {
    }

    public static void Niue()
    {
    }

    public static void NorfolkIsland()
    {
    }

    public static void NorthMacedonia()
    {
    }

    public static void NorthernMarianaIslands()
    {
    }

    public static void Norway()
    {
        Countries.Norway.Flags.Add(new CountryFlag
        {
            Id = "STATE",
            Usage = FlagUsage.StateFlag | FlagUsage.WarFlag | FlagUsage.StateEnsign | FlagUsage.WarEnsign
        });
    }
}