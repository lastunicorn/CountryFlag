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

public class SamoaFlag : CountryFlag
{
    public SamoaFlag()
    {
        Country = Countries.Samoa;

        Description = "A red field with the blue rectangle on the upper hoist-side quadrant bearing the Southern Cross of four white larger five-pointed stars and the smaller star in the center.";
        StartDate = new FlagDate(1962, 01, 01);
        Usage = FlagUsage.NationalFlagAndEnsign;
    }
}