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

using static System.Net.Mime.MediaTypeNames;

namespace DustInTheWind.CountryFlags;

public readonly struct FlagName
{
    public string NativeName { get; init; }

    public string Romanized { get; init; }

    public string EnglishTranslation { get; init; }

    public static implicit operator FlagName(string flagName)
    {
        return new FlagName
        {
            NativeName = flagName,
            EnglishTranslation = flagName
        };
    }

    public static implicit operator List<FlagName>(FlagName flagName)
    {
        return new List<FlagName>
        {
            flagName
        };
    }
}