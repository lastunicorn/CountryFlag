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

public class CentralAfricanRepublicFlag : CountryFlag
{
    public CentralAfricanRepublicFlag()
    {
        Country = Countries.CentralAfricanRepublic;

        Description = "Four horizontal stripes of blue, white, green and yellow intersected by one vertical stripe of red in the middle; with a yellow five-pointed star in the canton.";
        StartDate = new DateTime(1958, 12, 01);
        DesignedBy = "Barthélemy Boganda";
        Usage = FlagUsage.NationalFlag;
    }
}