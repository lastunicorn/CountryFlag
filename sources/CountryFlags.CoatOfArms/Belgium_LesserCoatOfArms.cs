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

public class Belgium_LesserCoatOfArms : CoatOfArms
{
    public Belgium_LesserCoatOfArms()
    {
        Country = Countries.Belgium;

        Id = "Coa_Lesser";
        Label = "Coat of arms (Lesser version)";
        Armiger = "Philippe, King of the Belgians";
        StartDate = new FlagDate(1837, 03, 17);
        CoaDescription = new CoatOfArmsDescription
        {
            Crest = "A helmet with raised visor or crowned with a Royal Crown of Belgium",
            Shield = "Sable, a lion rampant or, armed and langued Gules with two crossed sceptres (a hand of justice and a lion) or behind a shield. The grand collar of the Order of Leopold (Belgium) surrounds the shield",
            Supporters = "Two lions guardant proper each supporting a lance Gules point or with two National Flags of Belgium (Tierced per pale Sable, or and Gules).",
            Compartment = "Underneath the compartment is placed the ribbon Gules with two stripes Sable charged with the motto",
            Motto = new MultiLanguageText
            {
                new()
                {
                    Text = "L'union fait la force",
                    Language = "franch"
                },
                new()
                {
                    Text = "Eendracht maakt macht",
                    Language = "dutch"
                },
                new()
                {
                    Text = "Einigkeit macht stark",
                    Language = "german"
                },
                new()
                {
                    Text = "Unity is strength",
                    Language = "english"
                }
            },
            OtherElements = "The whole is placed on a mantle Gules with ermine lining, fringes and tassels Or and ensigned with the Royal Crown of Belgium. Above the mantle rise banners with the arms of the nine provinces that constituted Belgium in 1837. They are (from dexter to sinister) Antwerp, West Flanders, East Flanders, Liège, Brabant, Hainaut, Limburg, Luxembourg and Namur"
        };
    }
}
