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

public class Romania_CoatOfArms : CoatOfArms
{
    public Romania_CoatOfArms()
    {
        Country = Countries.Romania;

        Id = "Coa";
        Label = "Coat of Arms";
        Armiger = "Romania";
        StartDate = new FlagDate(2016, 07, 11);
        CoaDescription = new CoatOfArmsDescription
        {
            Shield = "It is used on the national currency, in classrooms, in the Parliament, on state buildings, on passports, on ID cards, in the header of the official documents (including diplomas)"
        };
        Comments = "It is used on the national currency, in classrooms, in the Parliament, on state buildings, on passports, on ID cards, in the header of the official documents (including diplomas)";
    }
}