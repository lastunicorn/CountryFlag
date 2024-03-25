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

public class Belgium_StateEnsignFlag : CountryFlag
{
    public Belgium_StateEnsignFlag()
    {
        Country = Countries.Belgium;

        Id = "StateEnsign";
        Description = "As above, with the central pale defaced by a lion rampant ensigned by a crown, both sable (black), the lion armed and langued gules (red).";
        StartDate = new DateTime(1950, 01, 01);
        Usage = FlagUsage.StateEnsign;
    }
}