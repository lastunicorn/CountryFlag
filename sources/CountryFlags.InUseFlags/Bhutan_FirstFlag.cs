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

public class Bhutan_FirstFlag : CountryFlag
{
    public Bhutan_FirstFlag()
    {
        Country = Countries.Bhutan;

        Id = "FirstFlag";
        Comments = "This illustration of the first national flag of Bhutan, used in 1949 at the signing of the Indo-Bhutan Treaty, is based upon black-and-white photos of the event with colours supplied from later documentation.";
        StartDate = new FlagDate(1949);
        EndDate = new FlagDate(1956);
    }
}