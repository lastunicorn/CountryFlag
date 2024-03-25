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

namespace DustInTheWind.CountryFlags.InUseFlags;

public class Peru_StateFlag : CountryFlag
{
    public Peru_StateFlag()
    {
        Country = Countries.Peru;

        Id = "State";
        Names = new List<FlagName>
        {
            "State flag and ensign"
        };
        Description = "A vertical triband of red (hoist-side and fly-side) and white with the National Coat of Arms centered on the white band.";
        StartDate = new FlagDate(1950, 03, 31);
        Usage = FlagUsage.StateFlag | FlagUsage.StateEnsign;
    }
}