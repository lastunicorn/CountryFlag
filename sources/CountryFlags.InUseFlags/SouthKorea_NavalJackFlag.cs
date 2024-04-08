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

namespace DustInTheWind.CountryFlags.InUseFlags;

public class SouthKorea_NavalJackFlag : CountryFlag
{
    public SouthKorea_NavalJackFlag()
    {
        Country = Countries.SouthKorea;

        Id = "NavalJack";
        Label = "Naval Jack";
        Description = "A Blue Ensign with a white canton that has a red and blue taegeuk superimposed in the center of the canton, with two anchors crossing.";
        Usage = FlagUsage.NavalJack;
    }
}