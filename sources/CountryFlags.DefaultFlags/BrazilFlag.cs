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

public class BrazilFlag : CountryFlag
{
    public BrazilFlag()
    {
        Country = Countries.Brazil;

        Description = "A green field with the large yellow rhombus in the center bearing the blue disk, which is formed the celestial globe, depicted the starry sky of twenty-seven small white five-pointed stars spanned by the white equatorial curved band with the National Motto: \"Ordem E Progresso\" (Portuguese for \"Order and Progress\"), written in green.";
        StartDate = new FlagDate(1889, 11, 19);
        DesignedBy = "Raimundo Teixeira Mendes";
        Usage = FlagUsage.NationalFlagAndEnsign;
    }
}