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

public class BotswanaFlag : CountryFlag
{
    public BotswanaFlag()
    {
        Country = Countries.Botswana;

        Description = "A light blue field cut horizontally in the centre by a black stripe with a thin white frame.";
        StartDate = new FlagDate(1966, 09, 30);
        Usage = FlagUsage.NationalFlag;
    }
}