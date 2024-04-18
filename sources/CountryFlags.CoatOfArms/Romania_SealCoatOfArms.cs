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

public class Romania_SealCoatOfArms : CoatOfArms
{
    public Romania_SealCoatOfArms()
    {
        Country = Countries.Romania;

        Id = "Coa_Seal";
        Label = "Coat of arms (Seal)";
        Armiger = "Romania";
        StartDate = new FlagDate(2016, 07, 11);
        CoaDescription = new CoatOfArmsDescription
        {
            Shield = "Azure, a crowned eagle displayed Or beaked and membered Gules holding in its beak an Orthodox Cross Or, in its dexter talon a sword, and in its sinister talon a sceptre Argent, and bearing on its breast an escutcheon quarterly: I, Azure, an eagle displayed Or beaked and membered Gules holding in its beak an Orthodox Cross Or, in dexter chief a sun in splendour and in sinister chief an increscent of the last (for Wallachia); II, gules, a bull's head caboshed Sable, in dexter base a rose, in sinister base a decrescent Argent, and between the bull's horns a mullet Or (for Western Moldavia); III, Gules, issuant from water in base Azure a bridge of two arches embattled throughout, thereon a lion rampant Or brandishing a sabre proper (for Oltenia and Banat); IV, Per fess Azure and Or, a bar Gules issuant therefrom an eagle displayed Sable between in sinister chief a decrescent Argent and in dexter chief a sun in splendour Or; in base seven castles Gules (for Transylvania); Entée en point, Azure, two dolphins urinant respectant Or (for Dobruja)"
        };
        Comments = "Used for ministerial seals and on identity cards.";
    }
}