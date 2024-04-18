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

public class Aruba_CoatOfArms : CoatOfArms
{
    public Aruba_CoatOfArms()
    {
        Country = Countries.Aruba;

        Id = "Coa";
        Label = "Coat of arms";
        Armiger = "Aruba";
        StartDate = new FlagDate(1955, 11, 15);
        CoaDescription = new CoatOfArmsDescription
        {
            Crest = "A lion couchant Gules",
            Shield = "Quartered by a cross Argent, the first Azure an aloe plant Or, the second Or the Hooiberg hill Vert issuant from barry wavy sea of Azure and Argent, the third Or two dexter hands Gules shaking each other fesswise, the fourth Gules an Argent cogwheel.",
            Supporters = "A pair of laurel branches Vert, tied at the bottom."
        };
    }
}