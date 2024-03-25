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

namespace DustInTheWind.CountryFlags.DefaultFlags;

public class PalauFlag : CountryFlag
{
    public PalauFlag()
    {
        Country = Countries.Palau;

        Description = "A light blue field with the large yellow disk shifted slightly to the hoist-side of center.";
        StartDate = new FlagDate(1981, 01, 01);
        DesignedBy = "Blau J. Skebong";
        Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag | FlagUsage.CivilEnsign | FlagUsage.StateEnsign;
    }
}