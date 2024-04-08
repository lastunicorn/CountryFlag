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

public class Japan_ImperialSeal : CountryFlag
{
    public Japan_ImperialSeal()
    {
        Country = Countries.Japan;

        Id = "ImperialSeal";
        Label = "Imperial seal";
        Description = "The symbol is a yellow or orange chrysanthemum with black or red outlines and background. A central disc is surrounded by a front set of 16 petals. A rear set of 16 petals are half staggered in relation to the front set and are visible at the edges of the flower.";
        StartDate = new FlagDate(1183);
        Comments = "Armiger: Naruhito, Emperor of Japan";
    }
}