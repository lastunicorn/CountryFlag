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

public class SaintKittsAndNevisFlag : CountryFlag
{
    public SaintKittsAndNevisFlag()
    {
        Country = Countries.SaintKittsAndNevis;

        Description = "A yellow-edged black diagonal band bearing two white five-pointed stars divided diagonally from the lower hoist-side corner to the upper fly-side corner: the upper triangle is green and the lower triangle is red.";
        StartDate = new FlagDate(1983, 09, 19);
        Usage = FlagUsage.NationalFlag | FlagUsage.CivilAndStateEnsign;
    }
}