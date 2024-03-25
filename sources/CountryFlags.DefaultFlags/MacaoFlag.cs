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

public class MacaoFlag : CountryFlag
{
    public MacaoFlag()
    {
        Country = Countries.Macao;

        Description = "Peacock green field with a lotus flower above the stylised Governor Nobre de Carvalho Bridge and water in white, beneath an arc of five golden five-pointed stars, where the large star is in the center flanked by four smaller stars, two on each side of the large star.";
        StartDate = new FlagDate(1993, 03, 31);
        DesignedBy = new StringList
        {
            "Zhang Lei",
            "Xiao Hong"
        };
        Usage = FlagUsage.CivilAndStateFlag | FlagUsage.CivilAndStateEnsign;
    }
}