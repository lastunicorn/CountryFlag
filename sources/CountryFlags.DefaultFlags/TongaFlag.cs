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

public class TongaFlag : CountryFlag
{
    public TongaFlag()
    {
        Country = Countries.Tonga;

        Description = "A red field with the white rectangle on the upper hoist-side corner bearing the red Greek Cross in the centre.";
        StartDate = new FlagDate(1875, 11, 04);
        Usage = FlagUsage.CivilAndStateFlag | FlagUsage.CivilAndStateEnsign;
    }
}