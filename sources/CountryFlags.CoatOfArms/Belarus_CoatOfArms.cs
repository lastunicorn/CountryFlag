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

public class Belarus_CoatOfArms : CoatOfArms
{
    public Belarus_CoatOfArms()
    {
        Country = Countries.Belarus;

        Id = "Coa";
        Label = "Coat of arms";
        Armiger = "Republic of Belarus";
        StartDate = new FlagDate(1937)
        {
            Description = "original design"
        };
        OtherDates = new List<FlagDate>
        {
            new(1958)
            {
                Description = "modified"
            },
            new(1995)
            {
                Description = "restored"
            },
            new(2020)
            {
                Description = "current design"
            }
        };
        CoaDescription = new CoatOfArmsDescription
        {
            Crest = "Red star",
            Supporters = "Stalks of wheat, clover and flax",
            Motto = new TranslationNote
            {
                Text = "Рэспубліка Беларусь",
                Language = "belarusian",
                EnglishTranslation = "Republic of Belarus"
            }
        };
    }
}