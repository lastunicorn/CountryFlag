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

namespace DustInTheWind.CountryFlags.DefaultFlags;

internal static partial class FlagsSetup
{
    public static void Zambia()
    {
        Countries.Zambia.Flags.Add(new CountryFlag
        {
            Description = "A green field with an orange coloured eagle in flight over a rectangular block of three vertical stripes coloured from left to right in red, black and orange",
            StartDate = new FlagDate(1964, 10, 24),
            DesignedBy = "Gabriel Ellison",
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void Zimbabwe()
    {
        Countries.Zimbabwe.Flags.Add(new CountryFlag
        {
            Description = "Seven horizontal stripes of green, yellow, red, black, red, yellow and green with a black-edged white isosceles triangle base on the hoist side bearing a Zimbabwe bird superimposed on a red five-pointed star.",
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }
}