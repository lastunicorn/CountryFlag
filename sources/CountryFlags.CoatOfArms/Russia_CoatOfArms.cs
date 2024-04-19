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

public class Russia_CoatOfArms : CoatOfArms
{
    public Russia_CoatOfArms()
    {
        Country = Countries.Russia;

        Id = "Coa";
        Label = "Coat of arms";
        Armiger = "Russian Federation";
        StartDate = new FlagDate(1993, 11, 30);
        CoaDescription = new CoatOfArmsDescription
        {
            Shield = "Gules, a double-headed eagle displayed, twice imperially crowned, grasping in the dexter claw an imperial sceptre, and in the sinister claw an imperial orb, all Or; in chief another larger imperial crown with issuant and pendent therefrom a ribbon, also Or; the eagle is charged on the breast with an escutcheon Gules, Saint George slaying the dragon."
        };
    }
}