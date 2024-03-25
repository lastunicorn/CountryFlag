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

namespace DustInTheWind.CountryFlags.OutdatedFlags;

public class Bangladesh_Liberation1971Flag : CountryFlag
{
    public Bangladesh_Liberation1971Flag()
    {
        Country = Countries.Bangladesh;

        Id = "Liberation1971";
        Names = new List<FlagName>
        {
            "Liberation War 1971"
        };
        Description = "A red disc with a golden outline of Bangladesh on a green banner.";
        Comments = "Flag used during the Liberation War (1971)";
        StartDate = new FlagDate(1971, 03, 02);
        EndDate = new FlagDate(1971, 12, 12);
    }
}