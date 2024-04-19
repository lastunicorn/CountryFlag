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

public class Barbados_OldCoatOfArms : CoatOfArms
{
    public Barbados_OldCoatOfArms()
    {
        Country = Countries.Barbados;

        Id = "Coa_Old";
        Label = "Coat of arms";
        Armiger = "Barbados";
        StartDate = new FlagDate(1870);
        EndDate = new FlagDate(1966);
        CoaDescription = new CoatOfArmsDescription
        {
            Crest = "A dexter Cubit Arm of a Barbadian erect proper the hand grasping two Sugar Canes in saltire proper.",
            Torse = "Or and Gules",
            Shield = "Or a bearded Fig Tree eradicated in chief two Red Pride of Barbados Flowers proper.",
            Supporters = "On the sinister (left) side a Dolphinfish and on the dexter (right) side a Pelican proper.",
            Compartment = "A scroll with the National Motto",
            Motto = "Pride and Industry"
        };
    }
}