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

public class NiueFlag : CountryFlag
{
    public NiueFlag()
    {
        Country = Countries.Niue;

        Description = "A golden yellow flag with the Union flag in the upper left (hoist) quarter of the flags. On the Union Jack are two yellow five-pointed stars on the vertical stripe and two on the horizontal stripe. In the centre of the Union flag is a blue disc with another, slightly larger, yellow five-pointed star.";
        StartDate = new FlagDate(1975, 10, 15);
        DesignedBy = "Patricia Rex";
        Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag;
    }
}