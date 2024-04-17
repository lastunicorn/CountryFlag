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

public class Albania_CoatOfArms : CoatOfArms
{
    public Albania_CoatOfArms()
    {
        Country = Countries.Albania;

        Id = "Coa";
        Label = "Coat of Arms";
        StartDate = new FlagDate(1998, 11, 28)
        {
            Description = "by presidential decree nr. 2260"
        };
        OtherDates = new List<FlagDate>
        {
            new(2003, 07, 10)
            {
                Description = "standardized by government decision nr. 474"
            }
        };
        CoaDescription = new CoatOfArmsDescription
        {
            Shield = "Gules within a bordure narrow Or, charged by a bicapitate eagle displayed Sable, in chief a helm adorned with rosettes upon which sits a goat's head erased Or dexter proper."
        };
        Comments = "It is used in the seals and at the entrance of state institutions; as a distinctive sign in state objects; in all official acts; in documents and agreements of the Albanian state with foreign countries, based on reciprocity.";
    }
}