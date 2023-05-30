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
    /// <summary>
    /// Mast add naval ensign.
    /// </summary>
    public static void Oman()
    {
        Countries.Oman.Flags.Add(new CountryFlag
        {
            Description = "A horizontal tricolor of white, red and green; with a vertical red stripe at the hoist, charged with the National emblem of Oman.",
            StartDate = new FlagDate(1995, 04, 25),
            Usage = FlagUsage.NationalFlag | FlagUsage.CivilEnsign | FlagUsage.StateEnsign
        });
    }
}