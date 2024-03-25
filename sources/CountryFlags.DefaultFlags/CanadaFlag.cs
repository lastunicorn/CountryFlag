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

public class CanadaFlag : CountryFlag
{
    public CanadaFlag()
    {
        Country = Countries.Canada;

        Names = new List<FlagName>
        {
            "Canadian flag",
            "Maple Leaf",
            new()
            {
                NativeName = "l'Unifolié",
                EnglishTranslation = "the one-leafed"
            }
        };
        Description = "A vertical triband of red (hoist-side and fly-side) and white (double width) with the red maple leaf centered on the white band.";
        StartDate = new FlagDate(1965, 02, 15);
        DesignedBy = "George F. G. Stanley";
        Usage = FlagUsage.NationalFlag | FlagUsage.CivilEnsign | FlagUsage.StateEnsign;
    }
}