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

public class EthiopiaFlag : CountryFlag
{
    public EthiopiaFlag()
    {
        Country = Countries.Ethiopia;

        Description = "A horizontal tricolour of green, yellow and red with the National Emblem superimposed at the center.";
        StartDate = new FlagDate(2009, 05, 16);
        DesignedBy = "Abebe Alambo";
        Usage = FlagUsage.NationalFlagAndEnsign;
    }
}