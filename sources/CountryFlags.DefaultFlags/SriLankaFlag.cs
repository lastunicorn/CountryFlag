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

public class SriLankaFlag : CountryFlag
{
    public SriLankaFlag()
    {
        Country = Countries.SriLanka;

        Description = "A golden field with two panels: the smaller hoist-side panel has only two vertical bands of teal and orange and the larger fly-side panel is the maroon field depicting the golden lion holding the kastane sword in its right fore paw in the center and four bo tree (bodhi tree) leaves on each corner and the golden field appears as a border around the entire flag and extends in between the two panels, all bordering together.";
        StartDate = new FlagDate(1972, 05, 22);
        Usage = FlagUsage.CivilAndStateFlag | FlagUsage.CivilEnsign;
    }
}