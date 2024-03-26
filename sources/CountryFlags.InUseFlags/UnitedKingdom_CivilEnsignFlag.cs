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

public class UnitedKingdom_CivilEnsignFlag : CountryFlag
{
    public UnitedKingdom_CivilEnsignFlag()
    {
        Country = Countries.UnitedKingdom;

        Id = "CivilEnsign";
        Names = new List<FlagName>
        {
            new()
            {
                EnglishTranslation = "Red Ensign"
            },
            new()
            {
                EnglishTranslation = "Red Duster"
            }
        };
        Description = "Red with the Union Jack occupying one quarter of the field and placed in the canton.";
        Usage = FlagUsage.CivilEnsign;
    }
}