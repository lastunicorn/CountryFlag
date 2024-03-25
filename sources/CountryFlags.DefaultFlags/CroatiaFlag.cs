﻿// Country Flags
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

public class CroatiaFlag : CountryFlag
{
    public CroatiaFlag()
    {
        Country = Countries.Croatia;

        Names = new List<FlagName>
        {
            new()
            {
                NativeName = "Trobojnica",
                EnglishTranslation = "The Tricolour"
            }
        };
        Description = "A horizontal tricolour of red, white, and blue with the Coat of Arms of Croatia in the centre.";
        StartDate = new FlagDate(1990, 12, 21);
        DesignedBy = "Miroslav Šutej";
        Usage = FlagUsage.NationalFlag;
    }
}