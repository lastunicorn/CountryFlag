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

public class Poland_WarFlag : CountryFlag
{
    public Poland_WarFlag()
    {
        Country = Countries.Poland;

        Id = "War";
        Names = new List<FlagName>
        {
            "National colour of military units"
        };
        Description = "As above, but evenly striped (1:1) and with the greater coat of arms, displaying a white scroll with the motto \"Esta é a ditosa pátria minha amada\" (\"This is my beloved blissful homeland\"), taken from Os Lusíadas, III, 21, v. 1";
        StartDate = new FlagDate(1911, 06, 30);
        Usage = FlagUsage.WarFlag;
    }
}