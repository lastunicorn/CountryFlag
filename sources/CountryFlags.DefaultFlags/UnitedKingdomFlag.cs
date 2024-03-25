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

public class UnitedKingdomFlag : CountryFlag
{
    public UnitedKingdomFlag()
    {
        Country = Countries.UnitedKingdom;

        Description = "A white-fimbriated symmetric red cross on a blue field with a white-fimbriated counterchanged saltire of red and white.";
        StartDate = new FlagDate(1801, 01, 01);
        Usage = FlagUsage.NationalFlag;
    }
}