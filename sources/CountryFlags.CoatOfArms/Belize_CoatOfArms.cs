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

public class Belize_CoatOfArms : CoatOfArms
{
    public Belize_CoatOfArms()
    {
        Country = Countries.Belize;

        Id = "Coa";
        Label = "Coat of arms";
        Armiger = "Charles III in Right of Belize";
        StartDate = new FlagDate(1981);
        OtherDates = new List<FlagDate>
        {
            new(2019)
            {
                Description = "standardized"
            }
        };
        CoaDescription = new CoatOfArmsDescription
        {
            Crest = "A mahogany tree proper",
            Shield = "Party per pall inverted, 1st Argent a paddle and a squaring axe proper in saltire 2nd Or a saw and beating axe proper in saltire 3rd per fess bleu celeste and barry wavy or vert azure above the last a sailing ship proper[",
            Supporters = "Dexter a Belizean Mestizo woodsman proper garbed in trousers argent bearing in the dexter hand a beating axe, sinister an Afro Belizean woodsman proper garbed in trousers argent bearing in the sinister hand a paddle proper",
            Compartment = "A grassy field proper",
            Motto = new MultiLanguageText
            {
                new()
                {
                    Text = "SUB UMBRA FLOREO"
                },
                new()
                {
                    Text = "Under the shade I flourish",
                    Language = "english"
                }
            },
            OtherElements = "The whole surrounded by a wreath of 25 leaves proper"
        };
    }
}