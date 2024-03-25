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

public class China_WarFlagFlag : CountryFlag
{
    public China_WarFlagFlag()
    {
        Country = Countries.China;

        Id = "WarFlag";
        Description = "A Chinese red field with a yellow star and Chinese numerals \"八一\", referencing 1 August, at the canton.";
        StartDate = new FlagDate(1949, 06, 15);
        Usage = FlagUsage.WarFlag | FlagUsage.NavalJack;
    }
}