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

public class Moldova_WarFlagFlag : CountryFlag
{
    public Moldova_WarFlagFlag()
    {
        Country = Countries.Moldova;

        Id = "WarFlag";
        Names = new List<FlagName>
        {
            new()
            {
                EnglishTranslation = "Armed Forces of Moldova"
            }
        };
        Description = "A blue cloth, bearing a red cross within a larger yellow cross. On the front of the cloth, in the center, lies the Emblem of the National Army. The reverse of the flag has the chromatic layout and features in the center the army motto in golden letters: Romanian: \"Pentru Onoare! Pentru Patrie! Pentru Tricolor!\" (For Honour! For Country! For the Tricolour!)";
        StartDate = new FlagDate(1991, 03, 28);
        Usage = FlagUsage.WarFlag;
    }
}