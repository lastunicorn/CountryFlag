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

public class Anguilla_CoatOfArms : CoatOfArms
{
    public Anguilla_CoatOfArms()
    {
        Country = Countries.Anguilla;

        Id = "Coa";
        Label = "Coat of Arms";
        StartDate = new FlagDate(1990, 11, 27);
        CoaDescription = new CoatOfArmsDescription
        {
            Crest = "An Eel (Anguilla Anguilla) haurient proper crowned with an Ancient Crown Or. (It is included by the official description, but it is not used.)",
            Shield = "Argent in base the Sea of Turquoise hue in chief three natural Dolphins embowed and leaping in a circle each tinctured Orange-Gold the Shield garnished of Gold.",
            OtherElements = "Dexter An Anguillan Fisherman proper wearing trousers rolled up to the knee Azure with a cloth waistband Or holding with his dexter hand a Strap Sable suspended therefrom by the mouth two pot fish namely a Jack Fish and a Red Snapper proper Sinister An Anguillan Woman vested in an ankle and wrist length Robe and Head Wrap Azure thereover an Apron Argent the lower hem and tied round the waist with an Orange-Gold band holding by the Stalk a Maize Plant leaved Vert fructed proper. (It is included by the official description, but it is not used.)"
        };
    }
}