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

public class CaribbeanNetherlands_MonarchFlag : CountryFlag
{
    public CaribbeanNetherlands_MonarchFlag()
    {
        Country = Countries.CaribbeanNetherlands;

        Id = "Monarch";
        Names = new List<FlagName>
        {
            "Royal Standard of the Netherlands"
        };
        Description = "Orange field divided in four by a nassau-blue cross, showing bugle-horns of the Principality of Orange and the coat of arms of the Kingdom, surrounded by a crown and the insignia of the Military Order of William.";
        StartDate = new DateTime(1908, 08, 27);
        Usage = FlagUsage.NavalJack;
    }
}