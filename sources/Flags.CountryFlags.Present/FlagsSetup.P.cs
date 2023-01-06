// Country Flags
// Copyright (C) 2022 Dust in the Wind
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

namespace DustInTheWind.CountryFlags.Present;

public static partial class FlagsSetup
{
    public static void Pakistan()
    {
        Countries.Pakistan.Flags.Add(new CountryFlag
        {
            Id = "CivilEnsign",
            Names = new List<FlagName>
            {
                "Civil ensign"
            },
            Description = "A red field with the national flag in the canton.",
            Usage = FlagUsage.CivilEnsign
        });

        Countries.Pakistan.Flags.Add(new CountryFlag
        {
            Id = "NavalEnsign",
            Names = new List<FlagName>
            {
                "Naval ensign"
            },
            Description = "A lengthened version of the national flag.",
            Usage = FlagUsage.WarEnsign
        });
    }

    public static void Palau()
    {
    }

    public static void Palestine()
    {
    }

    public static void Panama()
    {
    }

    public static void PapuaNewGuinea()
    {
    }

    public static void Paraguay()
    {
    }

    public static void Peru()
    {
    }

    public static void Philippines()
    {
    }

    public static void Pitcairn()
    {
    }

    public static void Poland()
    {
    }

    public static void Portugal()
    {
    }

    public static void PuertoRico()
    {
    }
}