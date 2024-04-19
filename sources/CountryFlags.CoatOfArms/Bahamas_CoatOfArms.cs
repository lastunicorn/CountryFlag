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

public class Bahamas_CoatOfArms : CoatOfArms
{
    public Bahamas_CoatOfArms()
    {
        Country = Countries.Bahamas;

        Id = "Coa";
        Label = "Coat of arms";
        Armiger = "Charles III in Right of the Bahamas";
        StartDate = new FlagDate(1971, 12, 07);
        CoaDescription = new CoatOfArmsDescription
        {
            Crest = "Upon a representation of Our Royal Helmet mantled Azure doubled Argent on a Wreath Or and Azure. A Conch Shell proper in front of a Panache of Palm Fronds proper.",
            Torse = "Orange and Azure",
            Shield = "Upon a representation of the Santa Maria on a base barry wavy of four Azure and Argent on a Chief Azure demi-sun Or.",
            Supporters = "On the dexter side a Marlin proper and on the sinister side a Flamingo proper",
            Compartment = "Per pale Waves of the Sea and Swampland proper.",
            Motto = "Forward, Upward, Onward Together"
        };
    }
}