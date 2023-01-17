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

using System;

namespace DustInTheWind.CountryFlags;

[Flags]
public enum FlagUsage : ulong
{
    None = 0,

    /// <summary>
    /// Bit 0
    /// </summary>
    CivilFlag = 0x1,

    /// <summary>
    /// Bit 1
    /// </summary>
    StateFlag = 0x2,

    /// <summary>
    /// Bit 2
    /// </summary>
    WarFlag = 0x4,

    /// <summary>
    /// Bit 0, 1 ,2
    /// </summary>
    NationalFlag = 0x7,

    /// <summary>
    /// Bit 0, 1
    /// </summary>
    CivilAndStateFlag = 0x3,

    /// <summary>
    /// Bit 3
    /// </summary>
    CivilEnsign = 0x8,

    /// <summary>
    /// Bit 4
    /// </summary>
    StateEnsign = 0x10,

    /// <summary>
    /// Bit 5
    /// </summary>
    WarEnsign = 0x20,

    /// <summary>
    /// Bit 3, 4, 5
    /// </summary>
    NationalEnsign = 0x38,

    /// <summary>
    /// Bit 3, 4
    /// </summary>
    CivilAndStateEnsign = 0x18,

    /// <summary>
    /// Bit 1, 2, 3, 4, 5
    /// </summary>
    NationalFlagAndEnsign = 0x3f,

    /// <summary>
    /// Bit 6
    /// </summary>
    NavalJack = 0x40,

    /// <summary>
    /// Bit 7
    /// </summary>
    LeaderFlag = 0x80,

    /// <summary>
    /// Bit 8
    /// </summary>
    AirForceEnsign = 0x100,

    /// <summary>
    /// Bit 63
    /// </summary>
    Other = 0x8000_0000_0000_0000
}