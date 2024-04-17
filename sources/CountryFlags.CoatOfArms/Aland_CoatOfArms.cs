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

public class Aland_CoatOfArms : CoatOfArms
{
    public Aland_CoatOfArms()
    {
        Country = Countries.Aland;

        Id = "Coa";
        Label = "Coat of Arms";
        Armiger = "Åland";
        StartDate = new FlagDate(1560);
        OtherDates = new List<FlagDate>
        {
            new(1952, 12, 10)
            {
                Description = "current version"
            }
        };
        CoaDescription = new CoatOfArmsDescription
        {
            Shield = "Azure a stag trippant Or.",
            OtherElements = "Comital coronet above the shield"
        };
    }
}