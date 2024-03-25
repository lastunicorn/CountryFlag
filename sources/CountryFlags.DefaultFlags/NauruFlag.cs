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

namespace DustInTheWind.CountryFlags.DefaultFlags;

public class NauruFlag : CountryFlag
{
    public NauruFlag()
    {
        Country = Countries.Nauru;

        Description = "A blue field with the thin yellow narrow horizontal stripe across in the center and the large white twelve-pointed star on the bottom of the stripe and near the hoist-side.";
        StartDate = new FlagDate(1968, 01, 31);
        DesignedBy = new StringList
        {
            "Theo Jankowski",
            "Don Stevenson",
            "Ortrud Clay"
        };
        Usage = FlagUsage.StateFlag | FlagUsage.CivilEnsign;
    }
}