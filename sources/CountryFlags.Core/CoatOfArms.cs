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

namespace DustInTheWind.CountryFlags;

public class CoatOfArms : CountryFlag
{
    /// <summary>
    /// In heraldry, an armiger is a person entitled to use a heraldic achievement
    /// (e.g., bear arms, an "armour-bearer") either by hereditary right, grant, matriculation,
    /// or assumption of arms. Such a person is said to be armigerous; a family or a clan
    /// likewise. 
    /// </summary>
    public string Armiger { get; set; }
    
    public CoatOfArmsDescription CoaDescription { get; set; }
}