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

public class SurinameFlag : CountryFlag
{
    public SurinameFlag()
    {
        Country = Countries.Suriname;

        Description = "A horizontal triband of green (top and bottom) and red (double width) with large white border with the large yellow five-pointed star centered on the red band.";
        StartDate = new FlagDate(1975, 11, 25);
        DesignedBy = "Jack Pinas";
        Usage = FlagUsage.NationalFlagAndEnsign;
    }
}