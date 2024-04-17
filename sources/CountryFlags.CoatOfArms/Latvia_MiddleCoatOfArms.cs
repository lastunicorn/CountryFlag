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

public class Latvia_MiddleCoatOfArms : CoatOfArms
{
    public Latvia_MiddleCoatOfArms()
    {
        Country = Countries.Latvia;

        Id = "Coa_Middle";
        Label = "Middle coat of arms";
        Armiger = "Republic of Latvia";
        StartDate = new FlagDate(1921, 06, 15);
        CoaDescription = new CoatOfArmsDescription
        {
            Crest = "An arc of three mullets Or.",
            Shield = "Per fess and in base per pale: 1st Azure, a demi-sun issuing from base Or; 2nd Argent, a lion rampant contourné Gules; 3rd Gules, a gryphon segreant brandishing in the dexter claw a sword Argent.",
            Compartment = "Two oak branches fructed Vert."
        };
    }
}