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

namespace DustInTheWind.Flags.CountryFlags.Demo.ViewModels;

public static class FlagUsageExtensions
{
    public static string ToDisplayString(this FlagUsage flagUsage)
    {
        if (flagUsage == FlagUsage.None)
            return "unknown usage";

        List<string> items = new();

        if (flagUsage.HasFlag(FlagUsage.NationalFlagAndEnsign))
        {
            items.Add("national flag and ensign");
        }
        else
        {
            if (flagUsage.HasFlag(FlagUsage.NationalFlag))
            {
                items.Add("national flag");
            }
            else
            {
                if (flagUsage.HasFlag(FlagUsage.CivilFlag))
                    items.Add("civil flag");

                if (flagUsage.HasFlag(FlagUsage.StateFlag))
                    items.Add("state flag");

                if (flagUsage.HasFlag(FlagUsage.WarFlag))
                    items.Add("war flag");
            }

            if (flagUsage.HasFlag(FlagUsage.NationalEnsign))
            {
                items.Add("national ensign");
            }
            else
            {
                if (flagUsage.HasFlag(FlagUsage.CivilEnsign))
                    items.Add("civil ensign");

                if (flagUsage.HasFlag(FlagUsage.StateEnsign))
                    items.Add("state ensign");

                if (flagUsage.HasFlag(FlagUsage.WarEnsign))
                    items.Add("war ensign");
            }
        }

        if (flagUsage.HasFlag(FlagUsage.NavalJack))
            items.Add("naval jack");

        if (flagUsage.HasFlag(FlagUsage.LeaderFlag))
            items.Add("leader's flag");

        if (flagUsage.HasFlag(FlagUsage.Other))
            items.Add("other usage");

        return string.Join(", ", items);
    }
}