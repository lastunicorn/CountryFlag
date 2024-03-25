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

public class TurksAndCaicosIslandsFlag : CountryFlag
{
    public TurksAndCaicosIslandsFlag()
    {
        Country = Countries.TurksAndCaicosIslands;

        Description = "A blue ensign with the Union flag in the canton and the coat of arms of the Turks and Caicos Islands in the fly half.";
        StartDate = new FlagDate(1968, 11, 07);
        Usage = FlagUsage.NationalFlag;
    }
}