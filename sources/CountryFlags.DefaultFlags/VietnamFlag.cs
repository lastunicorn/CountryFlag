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

public class VietnamFlag : CountryFlag
{
    public VietnamFlag()
    {
        Country = Countries.Vietnam;

        Names = new List<FlagName>
        {
            new()
            {
                NativeName = "Cờ đỏ sao vàng",
                EnglishTranslation = "red flag with a golden star"
            },
            new()
            {
                NativeName = "Cờ Tổ quốc",
                EnglishTranslation = "flag of the Fatherland"
            }
        };
        Description = "A large yellow star centered on a red field.";
        StartDate = new FlagDate(1976);
        DesignedBy = "Nguyễn Hữu Tiến";
        Usage = FlagUsage.CivilAndStateFlag;
    }
}