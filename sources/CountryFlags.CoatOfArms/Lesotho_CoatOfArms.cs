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

public class Lesotho_CoatOfArms : CoatOfArms
{
    public Lesotho_CoatOfArms()
    {
        Country = Countries.Lesotho;

        Id = "Coa";
        Label = "Coat of arms";
        Armiger = "Letsie III, King of Lesotho";
        StartDate = new FlagDate(2006, 10, 04);
        CoaDescription = new CoatOfArmsDescription
        {
            Shield = "The crocodile on the shield has been retained from the arms of Basutoland, the predecessor to Lesotho",
            Supporters = "two Basotho horses",
            Compartment = "The summit of Thaba Bosiu",
            Motto = new MultiLanguageText
            {
                new()
                {
                    Text = "Khotso, Pula, Nala ",
                    Language = "sesotho"
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