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

public class SlovakiaFlag : CountryFlag
{
    public SlovakiaFlag()
    {
        Country = Countries.Slovakia;

        Description = "A horizontal tricolor of white, blue, and red; charged with coat of arms at the hoist side.";
        StartDate = new FlagDate(1992, 09, 03);
        Usage = FlagUsage.NationalFlag;
        DesignedBy = new StringList
        {
            "Ladislav Čisárik",
            "Ladislav Vrtel"
        };
    }
}