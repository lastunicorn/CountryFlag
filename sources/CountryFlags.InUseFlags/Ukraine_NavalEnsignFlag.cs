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

public class Ukraine_NavalEnsignFlag : CountryFlag
{
    public Ukraine_NavalEnsignFlag()
    {
        Country = Countries.Ukraine;

        Id = "NavalEnsign";
        Names = new List<FlagName>
        {
            new()
            {
                EnglishTranslation = "Naval Ensign"
            }
        };
        Description = "White with a blue Saint George's cross that extends to the edges of the flag, with the national bicolour in the canton.";
        StartDate = new FlagDate(2006, 06, 20);
        Usage = FlagUsage.WarEnsign;
    }
}