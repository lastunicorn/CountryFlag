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

public class Australia_AirEnsignFlag : CountryFlag
{
    public Australia_AirEnsignFlag()
    {
        Country = Countries.Australia;

        Id = "AirEnsign";
        Names = new List<FlagName>
        {
            "Royal Australian Air Force Ensign"
        };
        Description = "A field of air force blue with the Union Flag in the canton, the Commonwealth Star below the Union Flag with the Southern Cross in the fly and the RAAF roundel in the lower fly.";
        StartDate = new FlagDate(1982);
        Usage = FlagUsage.AirForceEnsign;
    }
}