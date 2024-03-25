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

public class Afghanistan_IslamicEmirateFlag_Republic : CountryFlag
{
    public Afghanistan_IslamicEmirateFlag_Republic()
    {
        Country = Countries.Afghanistan_IslamicEmirate;

        Id = "Republic";
        Description = "Three vertical bands of black, red and green with the National Emblem in white centered on the red band and then slightly overlapping the black and green bands.";
        StartDate = new FlagDate(2013, 08, 19);
        Usage = FlagUsage.NationalFlagAndEnsign;
    }
}