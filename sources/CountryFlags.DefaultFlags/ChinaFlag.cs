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

public class ChinaFlag : CountryFlag
{
    public ChinaFlag()
    {
        Country = Countries.China;

        Names = new List<FlagName>
        {
            new()
            {
                NativeName = "五星红旗",
                EnglishTranslation = "Five-star Red Flag"
            }
        };
        Description = "A large golden star within an arc of four smaller golden stars, in the canton, on a field of Chinese red.";
        StartDate = new FlagDate(1949, 09, 27);
        DesignedBy = "Zeng Liansong";
        Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag | FlagUsage.CivilEnsign | FlagUsage.StateEnsign;
    }
}