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

namespace DustInTheWind.CountryFlags.CountryCoatOfArms;

public class Australia_CoatOfArms : CoatOfArms
{
    public Australia_CoatOfArms()
    {
        Country = Countries.Australia;

        Id = "Coa";
        Label = "Coat of arms";
        StartDate = new FlagDate(1912, 09, 19);
        CoaDescription = new CoatOfArmsDescription
        {
            Crest = "The Commonwealth Star: A seven-pointed star, or (gold)",
            Torse = "Or and azure (blue)",
            Shield = "The official blazon of the Commonwealth.",
            Supporters = "Dexter (left) a red kangaroo, sinister (right) an emu, both proper (natural colours)",
            Compartment = "none, golden wattle is depicted in its place",
            Motto = "none, the name of the country is written on a scroll"
        };
    }
}