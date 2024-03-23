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

using System.Collections.Generic;

namespace DustInTheWind.CountryFlags.DefaultFlags;

internal static partial class FlagsSetup
{
    public static void Reunion()
    {
        Countries.Reunion.Flags.Add(new CountryFlag
        {
            Description = "A vertical tricolour of blue, white, and red.",
            StartDate = new FlagDate(1794, 02, 15),
            Usage = FlagUsage.NationalFlag | FlagUsage.CivilEnsign | FlagUsage.StateEnsign
        });
    }

    public static void Romania()
    {
        Countries.Romania.Flags.Add(new CountryFlag
        {
            Description = "A vertical tricolor of blue, yellow, and red.",
            StartDate = new FlagDate(1989, 12, 27),
            Usage = FlagUsage.NationalFlagAndEnsign
        });
    }

    public static void Russia()
    {
        Countries.Russia.Flags.Add(new CountryFlag
        {
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
            },
            Description = "A horizontal tricolour of white, dark blue and red.",
            StartDate = new FlagDate(2000, 12, 25),
            DesignedBy = "Peter the Great",
            Usage = FlagUsage.CivilFlag | FlagUsage.StateFlag | FlagUsage.CivilEnsign | FlagUsage.StateEnsign
        });
    }

    public static void Rwanda()
    {
        Countries.Rwanda.Flags.Add(new CountryFlag
        {
            Description = "A horizontal tricolour of light blue (double width), yellow and green; charged with a sun-yellow sun in the upper-fly side corner.",
            StartDate = new FlagDate(2001, 10, 25),
            DesignedBy = "Alphonse Kirimobenecyo",
            Usage = FlagUsage.NationalFlag
        });
    }
}