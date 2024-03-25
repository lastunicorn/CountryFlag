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

public class EgyptFlag : CountryFlag
{
    public EgyptFlag()
    {
        Country = Countries.Egypt;

        Names = new List<FlagName>
        {
            new()
            {
                NativeName = "عَلَمْ مَصر",
                Romanized = "ˈʕælæm mɑsˤɾ",
                EnglishTranslation = "National flag of Egypt"
            }
        };
        Description = "Horizontally divided red-white-black tricolor flag with the Eagle of Saladin.";
        StartDate = new FlagDate(1984, 10, 04);
        DesignedBy = "Aly Kamel El-Deeb";
        Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag | FlagUsage.CivilEnsign | FlagUsage.StateEnsign;
    }
}