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

public class AntiguaAndBarbuda_CoatOfArms : CoatOfArms
{
    public AntiguaAndBarbuda_CoatOfArms()
    {
        Country = Countries.AntiguaAndBarbuda;

        Id = "Coa";
        Label = "Coat of Arms";
        Armiger = "Charles III in Right of Antigua and Barbuda";
        StartDate = new FlagDate(1967, 02, 16);
        CoaDescription = new CoatOfArmsDescription
        {
            Crest = "On a helmet to the dexter, lambrequined Azure and Argent, a pineapple and four hibiscusflowers proper.",
            Torse = "Argent and Azure",
            Shield = "Barry wavy of six Argent and Azure, a sugar mill on a grassy ground, proper; and a chief wavy Sable, a rising sun radiant Or.",
            Supporters = "Two deer, the dexter supporting a sugarcane and the sinister supporting an aloe, all proper",
            Compartment = "A grassy ground surrounded by waves of the sea Argent and Azure.",
            Motto = "Each Endeavouring, All Achieving",
            OtherElements = "Comital coronet above the shield"
        };
    }
}