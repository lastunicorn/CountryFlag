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

public class Austria_Variant1CoatOfArms : CoatOfArms
{
    public Austria_Variant1CoatOfArms()
    {
        Country = Countries.Austria;

        Id = "Coa_Variant1";
        Label = "Coat of arms (Variant 1)";
        Armiger = "Republic of Austria";
        StartDate = new FlagDate(1945);
        CoaDescription = new CoatOfArmsDescription
        {
            Shield = "Gules, a fess Argent",
            Supporters = "An eagle displayed sable, armed Or, langued Gules, crowned with a Mural crown of 3 turrets Or, bound at the wrists by shackles with broken chains proper, holding in dexter a sickle and in its sinister a hammer all Or."
        };
        Comments = "Bundeswappen like the heraldic description in Art. 8a Abs. 2 B-VG but with detailed eagle's feathers";
    }
}