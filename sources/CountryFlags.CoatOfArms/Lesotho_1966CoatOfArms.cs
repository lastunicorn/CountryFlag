﻿// Country Flags
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

public class Lesotho_1966CoatOfArms : CoatOfArms
{
    public Lesotho_1966CoatOfArms()
    {
        Country = Countries.Lesotho;

        Id = "Coa_1966";
        Label = "Coat of arms 1966";
        Armiger = "Letsie III, King of Lesotho";
        StartDate = new FlagDate(1966);
        EndDate = new FlagDate(2006);
        CoaDescription = new CoatOfArmsDescription
        {
            Compartment = "The summit of Thaba Bosiu",
            Motto = new MultiLanguageText
            {
                new()
                {
                    Text = "Khotso, Pula, Nala"
                },
                new()
                {
                    Text = "Peace, Rain, Prosperity",
                    Language = "english"
                }
            }
        };
    }
}