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

public class BhutanFlag : CountryFlag
{
    public BhutanFlag()
    {
        Country = Countries.Bhutan;

        Description = "Divided diagonally from the lower hoist-side corner to the upper fly-side corner; the upper triangle is yellow and the lower triangle is orange, with a white dragon holding four jewels in its claws centered along the dividing line and facing away from the hoist.";
        StartDate = new FlagDate(1969);
        DesignedBy = "Mayum Choying Wangmo Dorji";
        Usage = FlagUsage.NationalFlag;
    }
}