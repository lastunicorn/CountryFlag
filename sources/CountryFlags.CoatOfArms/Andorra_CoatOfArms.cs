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

public class Andorra_CoatOfArms : CoatOfArms
{
    public Andorra_CoatOfArms()
    {
        Country = Countries.Andorra;

        Id = "Coa";
        Label = "Coat of arms";
        StartDate = new FlagDate(1993)
        {
            Description = "officially"
        };
        CoaDescription = new CoatOfArmsDescription
        {
            Shield = "Quarterly: first Gules, a crosier bendways sinister surmounted by a mitre Or lined Argent (Bishop of Urgell); second Or, three pallets Gules (Count of Foix); third Or, four pallets Gules (Catalonia); fourth Or, two cows passant in pale Gules horned and collared Azure (Viscount of Béarn).",
            Motto = new TranslationNote
            {
                Text = "Virtus Unita Fortior",
                EnglishTranslation = "United virtue is stronger"
            },
            OtherElements = "A console or."
        };
    }
}