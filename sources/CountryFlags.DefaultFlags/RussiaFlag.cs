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

public class RussiaFlag : CountryFlag
{
    public RussiaFlag()
    {
        Country = Countries.Russia;

        Names = new List<FlagName>
        {
            new()
            {
                NativeName = "Флаг России",
                Romanized = "Flag Rossii",
                EnglishTranslation = "The national flag of Russia"
            },
            new()
            {
                NativeName = "Государственный флаг Российской Федерации",
                Romanized = "Gosudarstvenny flag Rossiyskoy Federatsii",
                EnglishTranslation = "The State Flag of the Russian"
            },
            new()
            {
                NativeName = "Триколор",
                Romanized = "Trikolor",
                EnglishTranslation = "Tricolour"
            }
        };
        Description = "A horizontal tricolour of white, dark blue and red.";
        StartDate = new FlagDate(2000, 12, 25);
        DesignedBy = "Peter the Great";
        Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag | FlagUsage.CivilEnsign | FlagUsage.StateEnsign;
    }
}