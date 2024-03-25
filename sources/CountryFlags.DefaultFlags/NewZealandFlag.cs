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

public class NewZealandFlag : CountryFlag
{
    public NewZealandFlag()
    {
        Country = Countries.NewZealand;

        Description = "A Blue Ensign with a Union Jack in the first quarter and four five-pointed red stars with white borders on the fly representing the Southern Cross.";
        StartDate = new FlagDate(1902, 03, 24);
        DesignedBy = "Albert Hastings Markham";
        Usage = FlagUsage.NationalFlag | FlagUsage.StateEnsign;
    }
}