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

public class GreeceFlag : CountryFlag
{
    public GreeceFlag()
    {
        Country = Countries.Greece;

        Names = new List<FlagName>
        {
            new()
            {
                NativeName = "Η Γαλανόλευκη",
                Romanized = "I Galanolefki",
                EnglishTranslation = "The Blue and White"
            },
            new()
            {
                NativeName = "Η Κυανόλευκη",
                Romanized = "I Kyanolefki",
                EnglishTranslation = "The Azure and White"
            }
        };
        Description = "Nine horizontal stripes, in turn blue and white; a white Greek cross throughout a blue canton.";
        StartDate = new FlagDate(1978, 12, 22);
        Usage = FlagUsage.NationalFlagAndEnsign;
    }
}