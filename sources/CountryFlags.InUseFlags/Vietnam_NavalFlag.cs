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

public class Vietnam_NavalFlag : CountryFlag
{
    public Vietnam_NavalFlag()
    {
        Country = Countries.Vietnam;

        Id = "Naval";
        Names = new List<FlagName>
        {
            "Naval Ensign"
        };
        Description = "A white flag with an emblem referring the Vietnam People's Navy in the top with the red label Hải quân Việt Nam (Navy of Vietnam) and a blue strip below.";
        DesignedBy = "Vietnam People's Navy, with the influence from the naval ensign of the Soviet Navy";
        StartDate = new FlagDate(2014, 10, 15);
        Usage = FlagUsage.WarEnsign;
    }
}