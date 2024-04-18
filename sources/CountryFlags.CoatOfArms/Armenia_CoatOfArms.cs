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

public class Armenia_CoatOfArms : CoatOfArms
{
    public Armenia_CoatOfArms()
    {
        Country = Countries.Armenia;

        Id = "Coa";
        Label = "Coat of arms";
        Names = new List<FlagName>
        {
            new()
            {
                NativeName = "Հայաստանի Զինանշան",
                EnglishTranslation = "Coat of Arms of Armenia"
            }
        };
        Armiger = "Republic of Armenia";
        StartDate = new FlagDate(1992, 04, 19);
        CoaDescription = new CoatOfArmsDescription
        {
            Shield = "Quarterly: 1; Gules, a lion passant facing to the sinister with a cross rising from its back Or, 2; Azure, a double headed eagle Or, 3; Azure, a roundel Or charged with an octofoil between two eagles trussed regardant and addorsed Or, 4; Gules, a Lion passant guardant holding a cross Or. On an Inescutcheon en surtout, a Landscape of Mount Ararat with the flood waters receding and Noah's ark at the summit, all Argent.",
            Supporters = "To the dexter, an eagle regardant Or, and to the sinister a lion regardant also Or.",
            Compartment = "Bundle of Wheat Flowers, Feather, Broken Chain, Ribon, and Sword"
        };
    }
}