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

public class Benin_LesserCoatOfArms : CoatOfArms
{
    public Benin_LesserCoatOfArms()
    {
        Country = Countries.Benin;

        Id = "Coa_Lesser";
        Label = "Coat of arms (Lesser)";
        Armiger = "Republic of Benin";
        StartDate = new FlagDate(1990);
        OtherDates = new List<FlagDate>
        {
            new(1964)
        };
        CoaDescription = new CoatOfArmsDescription
        {
            Shield = "Quarterly,1, Argent, a Somba Castle Or, 2, Argent, a Star of Benin proper, 3, Argent, a Palm Tree vert charged with fruit gules, 4, Argent, a ship sable sailing on a sea azure with a sewn upon the line of quartering a lozenge gules"
        };
    }
}