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

namespace DustInTheWind.CountryFlags.InUseFlags;

internal static partial class FlagsSetup
{
    public static void Afghanistan_IslamicEmirate()
    {
    }

    public static void Afghanistan_IslamicRepublic()
    {
    }

    public static void Aland()
    {
    }
    
    public static void Albania()
    {

        Countries.Albania.Flags.Add(new CountryFlag
        {
            Id = "CivilEnsign",
            Description = "A horizontal tricolour with red on the top and bottom stripes, and black in the middle.",
            Usage = FlagUsage.CivilEnsign
        });

        Countries.Albania.Flags.Add(new CountryFlag
        {
            Id = "NavalEnsign",
            Description = "A double-headed eagle on a white background with a red stripe at the bottom.",
            Usage = FlagUsage.WarEnsign
        });
    }
    
    public static void Algeria()
    {
        Countries.Algeria.Flags.Add(new CountryFlag
        {
            Id = "President",
            Names = new List<FlagName>
            {
                "President's Flag"
            },
            Usage = FlagUsage.LeaderFlag
        });

        Countries.Algeria.Flags.Add(new CountryFlag
        {
            Id = "NavalEnsign",
            Names = new List<FlagName>
            {
                "Naval ensign"
            },
            Usage = FlagUsage.WarEnsign
        });

        Countries.Algeria.Flags.Add(new CountryFlag
        {
            Id = "NavalJack",
            Names = new List<FlagName>
            {
                "Naval jack"
            },
            Usage = FlagUsage.NavalJack
        });
    }

    public static void AmericanSamoa()
    {
    }
    
    public static void Andorra()
    {
        Countries.Andorra.Flags.Add(new CountryFlag
        {
            Id = "Civil",
            Names = new List<FlagName>
            {
                "Civil flag and ensign"
            },
            Description = "A vertical tricolour of blue, yellow and red.",
            StartDate = new FlagDate(1866),
            DesignedBy = "Napoleon III",
            Usage = FlagUsage.CivilFlag | FlagUsage.CivilEnsign
        });
    }

    public static void Angola()
    {
    }

    public static void Anguilla()
    {
    }

    public static void Antarctica()
    {
    }

    public static void AntiguaAndBarbuda()
    {
        Countries.AntiguaAndBarbuda.Flags.Add(new CountryFlag
        {
            Id = "StateEnsign",
            Description = "A white field with a red cross, the national flag in the canton.",
            Usage = FlagUsage.StateEnsign
        });
    }
    
    public static void Argentina()
    {
        Countries.Argentina.Flags.Add(new CountryFlag
        {
            Id = "Civil",
            Names = new List<FlagName>
            {
                new()
                {
                    NativeName = "Bandera de Ornato",
                    EnglishTranslation = "Ornamental Flag"
                }
            },
            Description = "A horizontal triband of light blue (top and bottom) and white (center).",
            StartDate = new FlagDate(1812, 02, 27),
            Usage = FlagUsage.CivilFlag | FlagUsage.CivilEnsign
        });
    }

    public static void Armenia()
    {
        Countries.Armenia.Flags.Add(new CountryFlag
        {
            Id = "President",
            Names = new List<FlagName>
            {
                "President's Flag"
            },
            Description = "A horizontal tricolour of red, blue, and orange defaced with the Presidential seal at its centre.",
            Usage = FlagUsage.LeaderFlag
        });
    }

    public static void Aruba()
    {
        Countries.Aruba.Flags.Add(new CountryFlag
        {
            Id = "Governor",
            Usage = FlagUsage.LeaderFlag
        });
    }
    
    public static void Australia()
    {
        Countries.Australia.Flags.Add(new CountryFlag
        {
            Id = "CivilEnsign",
            Names = new List<FlagName>
            {
                "Australian Red Ensign"
            },
            Description = "A Red Ensign defaced with the Commonwealth/Federation Star at the hoist, and the Southern Cross in the fly half.",
            Usage = FlagUsage.CivilEnsign
        });
       
        Countries.Australia.Flags.Add(new CountryFlag
        {
            Id = "NavalEnsign",
            Names = new List<FlagName>
            {
                "Royal Australian Navy Ensign"
            },
            Description = "A defaced British White Ensign without the cross. The cross is replaced with the Southern Cross and the Commonwealth Star/Federation Star.",
            StartDate = new FlagDate(1967),
            Usage = FlagUsage.CivilEnsign
        });
       
        Countries.Australia.Flags.Add(new CountryFlag
        {
            Id = "AirEnsign",
            Names = new List<FlagName>
            {
                "Royal Australian Air Force Ensign"
            },
            Description = "A field of air force blue with the Union Flag in the canton, the Commonwealth Star below the Union Flag with the Southern Cross in the fly and the RAAF roundel in the lower fly.",
            StartDate = new FlagDate(1982),
            Usage = FlagUsage.AirForceEnsign
        });
    }
    
    public static void Austria()
    {
        Countries.Austria.Flags.Add(new CountryFlag
        {
            Id = "StateAndWar",
            Description = "A horizontal triband of red (top and bottom) and white defaced with the Coat of arms of Austria at its centre.",
            Usage = FlagUsage.StateFlag | FlagUsage.WarFlag | FlagUsage.StateEnsign | FlagUsage.WarEnsign
        });
    }

    public static void Azerbaijan()
    {
    }
}