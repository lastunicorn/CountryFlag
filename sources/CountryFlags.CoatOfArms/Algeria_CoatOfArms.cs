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

public class Algeria_CoatOfArms : CoatOfArms
{
    public Algeria_CoatOfArms()
    {
        Country = Countries.Algeria;

        Id = "Coa";
        Label = "Coat of arms";
        Armiger = "People's Democratic Republic of Algeria";
        StartDate = new FlagDate(1976, 11, 01);
        CoaDescription = new CoatOfArmsDescription
        {
            Shield = "At the top, the sun rising over a mountain, In the center, a skilled goldsmith symmetrical about the major, the three central fingers together, the two ends of the fingers ended in beak of a dove carrying an olive branch. At the bottom, the crescent and star. Right, the ballot box topped with three ears differentiated and oak leaves and left an olive branch with fruit, layered and topped with a palm roof and smokestacks and oil drilling derricks and form of an outside circumference with an inscription in Arabic",
            Motto = new TranslationNote
            {
                Text = "الجمهورية الجزائرية الديمقراطية الشّعبية",
                EnglishTranslation = "People's Democratic Republic of Algeria"
            }
        };
    }
}