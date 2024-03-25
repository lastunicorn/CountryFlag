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

public class NorwayFlag : CountryFlag
{
    public NorwayFlag()
    {
        Country = Countries.Norway;

        Description = "A red field charged with a white-fimbriated dark blue Nordic cross that extends to the edges; the vertical part of the cross is shifted to the hoist side.";
        StartDate = new FlagDate(1821, 07, 13);
        DesignedBy = "Fredrik Meltzer";
        Usage = FlagUsage.NationalFlagAndEnsign;
    }
}