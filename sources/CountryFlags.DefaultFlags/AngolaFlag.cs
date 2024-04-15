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

public class AngolaFlag : CountryFlag
{
    public AngolaFlag()
    {
        Country = Countries.Angola;

        Description = "A horizontal bicolour of red and black, with a yellow half gear wheel crossed by a machete and crowned with a star in the center.";
        StartDate = new FlagDate(1975, 11, 11);
        DesignedBy = new StringList
        {
            "Henrique de Carvalho Santos",
            "António Alberto Neto"
        };
        Usage = FlagUsage.NationalFlag;
    }
}