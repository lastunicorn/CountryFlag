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

using System.Collections.Generic;

namespace DustInTheWind.CountryFlags.DefaultFlags;

public class EcuadorFlag : CountryFlag
{
    public EcuadorFlag()
    {
        Country = Countries.Ecuador;

        Names = new List<FlagName>
        {
            new()
            {
                NativeName = "La Tricolor",
                EnglishTranslation = "The Tricolor"
            }
        };
        Description = "A horizontal tricolor of yellow (double width), blue and red with the National Coat of Arms superimposed at the center.";
        StartDate = new FlagDate(1860, 09, 26);
        Usage = FlagUsage.StateFlag | FlagUsage.WarFlag | FlagUsage.StateEnsign | FlagUsage.WarEnsign;
    }
}