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

namespace DustInTheWind.CountryFlags.InUseFlags;

internal static partial class FlagsSetup
{
    public static void Macao()
    {
    }

    public static void Madagascar()
    {
        Countries.Madagascar.Flags.Add(new CountryFlag
        {
            Id = "President",
            Names = new List<FlagName>
            {
                new ()
                {
                    EnglishTranslation = "Presidential standard"
                }
            },
            Description = "The National flag with the Seal of Madagascar in the center of the tri-point with the initials \"R. M.\" in the canton.",
            Usage = FlagUsage.LeaderFlag
        });
    }

    public static void Malawi()
    {
    }

    public static void Malaysia()
    {
    }

    public static void Maldives()
    {
    }

    public static void Mali()
    {
    }

    public static void Malta()
    {
    }

    public static void MarshallIslands()
    {
    }

    public static void Martinique()
    {
    }

    public static void Mauritania()
    {
    }

    public static void Mauritius()
    {
    }

    public static void Mayotte()
    {
    }

    public static void Mexico()
    {
        Countries.Mexico.Flags.Add(new CountryFlag
        {
            Id = "NavalJack",
            Description = "A diagonal tricolor of white, green, red, with a thin anchor in the center. Three eight-pointed gold stars are in the canton, and the bottom two corners.",
            Usage = FlagUsage.NavalJack
        });
    }

    public static void Micronesia()
    {
    }

    public static void Moldova()
    {
        Countries.Moldova.Flags.Add(new CountryFlag
        {
            Id = "WarFlag",
            Names = new List<FlagName>
            {
                new()
                {
                    EnglishTranslation = "Armed Forces of Moldova"
                }
            },
            Description = "A blue cloth, bearing a red cross within a larger yellow cross. On the front of the cloth, in the center, lies the Emblem of the National Army. The reverse of the flag has the chromatic layout and features in the center the army motto in golden letters: Romanian: \"Pentru Onoare! Pentru Patrie! Pentru Tricolor!\" (For Honour! For Country! For the Tricolour!)",
            StartDate = new FlagDate(1991, 03, 28),
            Usage = FlagUsage.WarFlag
        });

        Countries.Moldova.Flags.Add(new CountryFlag
        {
            Id = "President",
            Names = new List<FlagName>
            {
                new()
                {
                    EnglishTranslation = "Standard of the President"
                }
            },
            StartDate = new FlagDate(2010),
            Usage = FlagUsage.LeaderFlag
        });

        Countries.Moldova.Flags.Add(new CountryFlag
        {
            Id = "PresidentOfParliament",
            Names = new List<FlagName>
            {
                new()
                {
                    EnglishTranslation = "Standard of the President of the Parliament"
                }
            },
            StartDate = new FlagDate(2010),
            Usage = FlagUsage.LeaderFlag
        });

        Countries.Moldova.Flags.Add(new CountryFlag
        {
            Id = "PrimeMinister",
            Names = new List<FlagName>
            {
                new()
                {
                    EnglishTranslation = "Standard of the Prime Minister"
                }
            },
            StartDate = new FlagDate(2010),
            Usage = FlagUsage.LeaderFlag
        });
    }

    public static void Monaco()
    {
    }

    public static void Mongolia()
    {
    }

    public static void Montenegro()
    {
    }

    public static void Montserrat()
    {
    }

    public static void Morocco()
    {
    }

    public static void Mozambique()
    {
    }

    public static void Myanmar()
    {
    }
}