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

public class DominicanRepublicFlag : CountryFlag
{
    public DominicanRepublicFlag()
    {
        Country = Countries.DominicanRepublic;

        Description = "A white cross with the national coat of arms in the centre that divides the flag into four rectangles, blue and red at the top and red and blue at the bottom.";
        StartDate = new FlagDate(1863, 11, 06);
        DesignedBy = "Juan Pablo Duarte";
        Usage = FlagUsage.StateFlag | FlagUsage.WarFlag | FlagUsage.StateEnsign | FlagUsage.WarEnsign;
    }
}