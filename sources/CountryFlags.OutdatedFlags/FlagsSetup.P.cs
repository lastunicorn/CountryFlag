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

namespace DustInTheWind.CountryFlags.OutdatedFlags;

internal static partial class FlagsSetup
{
    public static void Pakistan()
    {
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
        Countries.PuertoRico.Flags.Add(new CountryFlag
        {
            Id = "AzulCeleste",
            Names = new List<FlagName>
            {
                "Original flag version from 1895"
            },
            Description = "Five equal horizontal bands of red (top and bottom) alternating with white; Azul Celeste (sky blue tone) equilateral triangle based on the hoist side bears a large, white, five-pointed star in the center.",
            StartDate = new FlagDate(1895, 12, 22),
            EndDate = new FlagDate(1898, 12, 10),
            Comments = "Flag was abandoned after military occupation by the United States."
        });
    }
}