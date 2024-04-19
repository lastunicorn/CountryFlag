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

public class Russia_ChargeCoatOfArms : CoatOfArms
{
    public Russia_ChargeCoatOfArms()
    {
        Country = Countries.Russia;

        Id = "Coa_Charge";
        Label = "Coat of arms (Charge)";
        Armiger = "Russian Federation";
        StartDate = new FlagDate(1993, 11, 30);
        CoaDescription = new CoatOfArmsDescription
        {
            OtherElements = "The charge of the coat of arms."
        };
    }
}