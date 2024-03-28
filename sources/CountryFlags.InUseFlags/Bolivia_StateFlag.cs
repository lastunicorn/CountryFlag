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

public class Bolivia_StateFlag : CountryFlag
{
    public Bolivia_StateFlag()
    {
        Country = Countries.Bolivia;

        Id = "State";
        Names = new List<FlagName>
        {
            "State Flag"
        };
        Description = "A horizontal tricolor of red, yellow and green with the coat of arms.";
        StartDate = new DateTime(1851, 10, 31);
        DesignedBy = "Manuel Isidoro Belzu";
        Usage = FlagUsage.StateFlag | FlagUsage.WarFlag | FlagUsage.StateEnsign;
    }
}