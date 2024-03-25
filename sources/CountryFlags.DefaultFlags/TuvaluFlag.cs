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

public class TuvaluFlag : CountryFlag
{
    public TuvaluFlag()
    {
        Country = Countries.Tuvalu;

        Description = "A Light Blue Ensign with a map of the 9 islands, using 9 yellow stars on the fly half of the flag.";
        StartDate = new FlagDate(1997, 04, 11);
        Usage = FlagUsage.NationalFlagAndEnsign;
    }
}