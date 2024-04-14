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

namespace DustInTheWind.CountryFlags.OutdatedFlags;

public class Andorra_ThirdCrownFlag : CountryFlag
{
    public Andorra_ThirdCrownFlag()
    {
        Country = Countries.Andorra;

        Id = "ThirdCrown";
        Label = "Third flag - with crown";
        StartDate = new FlagDate(1900)
        {
            Description = "aprox. end of 19th century"
        };
        EndDate = new FlagDate(1930)
        {
            Description = "1930s"
        };
    }
}