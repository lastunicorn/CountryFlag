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

namespace DustInTheWind.CountryFlags;

public static partial class Countries
{
    public static Country Jamaica { get; } = new()
    {
        ShortName = "Jamaica",
        FullName = "Jamaica",
        IsoCodeAlpha2 = "JM",
        IsoCodeAlpha3 = "JAM",
        IsoCodeNumeric = "388",
        IsIndependent = true
    };

    public static Country Japan { get; } = new()
    {
        ShortName = "Japan",
        FullName = "Japan",
        IsoCodeAlpha2 = "JP",
        IsoCodeAlpha3 = "JPN",
        IsoCodeNumeric = "392",
        IsIndependent = true
    };

    public static Country Jersey { get; } = new()
    {
        ShortName = "Jersey",
        FullName = "Bailiwick of Jersey",
        IsoCodeAlpha2 = "JE",
        IsoCodeAlpha3 = "JEY",
        IsoCodeNumeric = "832",
        IsIndependent = false
    };

    public static Country Jordan { get; } = new()
    {
        ShortName = "Jordan",
        FullName = "Hashemite Kingdom of Jordan",
        IsoCodeAlpha2 = "JO",
        IsoCodeAlpha3 = "JOR",
        IsoCodeNumeric = "400",
        IsIndependent = true
    };
}