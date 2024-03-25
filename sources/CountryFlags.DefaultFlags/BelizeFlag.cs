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

public class BelizeFlag : CountryFlag
{
    public BelizeFlag()
    {
        Country = Countries.Belize;

        Description = "A royal blue field with two red narrow horizontal stripes along the top and the bottom edges and the large white disk in the centre bearing the National Coat of Arms.";
        StartDate = new FlagDate(1981, 09, 21);
        Usage = FlagUsage.NationalFlagAndEnsign;
    }
}