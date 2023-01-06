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
    
    CivilFlag = 0x1,
    StateFlag = 0x2,
    WarFlag = 0x4,
    NationalFlag = 0x7,
    
    CivilEnsign = 0x8,
    StateEnsign = 0x10,
    WarEnsign = 0x20,
    NationalEnsign = 0x38,
    
    NationalFlagAndEnsign = 0x3f,
    
    NavalJack = 0x40,
    LeaderFlag = 0x80,
    AirForceEnsign = 0x100,
    
    Other = 0x8000_0000_0000_0000
}