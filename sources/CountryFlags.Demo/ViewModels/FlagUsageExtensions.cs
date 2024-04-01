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

namespace DustInTheWind.CountryFlags.Demo.ViewModels;

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
        else if (flagUsage.HasFlag(FlagUsage.CivilFlagAndEnsign))
        {
            items.Add("civil flag and ensign");
        }
        else if (flagUsage.HasFlag(FlagUsage.StateFlagAndEnsign))
        {
            items.Add("state flag and ensign");
        }
        else if (flagUsage.HasFlag(FlagUsage.WarFlagAndEnsign))
        {
            items.Add("war flag and ensign");
        }
        else if (flagUsage.HasFlag(FlagUsage.NationalFlag))
        {
            items.Add("national flag");
        }
        else if (flagUsage.HasFlag(FlagUsage.NationalEnsign))
        {
            items.Add("national ensign");
        }
        else
        {
            // Add flag items

            List<string> flagItems = new();

            if (flagUsage.HasFlag(FlagUsage.CivilFlag))
                flagItems.Add("civil");

            if (flagUsage.HasFlag(FlagUsage.StateFlag))
                flagItems.Add("state");

            if (flagUsage.HasFlag(FlagUsage.WarFlag))
                flagItems.Add("war");

            if (flagItems.Count > 0)
            {
                string text = string.Join(" and ", flagItems);
                items.Add(text + " flag");
            }

            // Add ensign items

            List<string> ensignItems = new();

            if (flagUsage.HasFlag(FlagUsage.CivilEnsign))
                ensignItems.Add("civil");

            if (flagUsage.HasFlag(FlagUsage.StateEnsign))
                ensignItems.Add("state");

            if (flagUsage.HasFlag(FlagUsage.WarEnsign))
                ensignItems.Add("war");

            if (ensignItems.Count > 0)
            {
                string text = string.Join(" and ", ensignItems);
                items.Add(text + " ensign");
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