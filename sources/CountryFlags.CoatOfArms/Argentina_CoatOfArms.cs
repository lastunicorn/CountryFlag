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

public class Argentina_CoatOfArms : CoatOfArms
{
    public Argentina_CoatOfArms()
    {
        Country = Countries.Argentina;

        Id = "Coa";
        Label = "Coat of arms";
        Armiger = "Argentine Republic";
        StartDate = new FlagDate(1944);
        OtherDates = new List<FlagDate>
        {
            new(1813)
            {
                Description = "older design"
            }
        };
        CoaDescription = new CoatOfArmsDescription
        {
            Crest = "A Sun of May or",
            Shield = "Party per fess azure and argent, in base two arms throughout fessways, the hands shaking and holding a pike paleways proper ensigned on the top with a Phrygian cap gules.",
            OtherElements = "Around the shield two sprigs of laurel vert tied together in base by a ribbon azure charged with a fess argent."
        };
    }
}