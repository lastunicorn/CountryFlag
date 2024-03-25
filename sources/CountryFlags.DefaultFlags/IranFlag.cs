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

public class IranFlag : CountryFlag
{
    public IranFlag()
    {
        Country = Countries.Iran;

        Description = "A horizontal tricolor of green, white and red with the National Emblem in red centred on the white band and the Takbir written in the Kufic script in white, repeated 11 times along the bottom edge of the green band and 11 times along the top edge of the red band, for a total of 22 times on the fringe of the bands.";
        StartDate = new FlagDate(1980, 07, 29);
        DesignedBy = "Hamid Nadimi";
        Usage = FlagUsage.NationalFlagAndEnsign;
    }
}