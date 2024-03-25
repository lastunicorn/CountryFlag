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

public class AmericanSamoaFlag : CountryFlag
{
    public AmericanSamoaFlag()
    {
        Country = Countries.AmericanSamoa;

        Description = "A red-edged white triangle pointing towards the hoist charged with a bald eagle clutching a war club and a fly-whisk. The white triangle divided the dark blue field into two separate triangles.";
        StartDate = new FlagDate(1960, 04, 17);
        DesignedBy = "Fareti Sotoa";
        Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag;
    }
}