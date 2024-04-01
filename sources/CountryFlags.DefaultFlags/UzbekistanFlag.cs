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

public class UzbekistanFlag : CountryFlag
{
    public UzbekistanFlag()
    {
        Country = Countries.Uzbekistan;

        Description = "A horizontal triband of azure, white and green, separated by two narrow red stripes. A white crescent and three rows of twelve white five-pointed stars are situated on the left side of the upper azure stripe.";
        StartDate = new FlagDate(1991, 11, 18);
        DesignedBy = "Farhod Yoʻldoshev";
        Usage = FlagUsage.CivilAndStateFlag | FlagUsage.CivilAndStateEnsign;
    }
}