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
    public static Country Vanuatu { get; } = new()
    {
        ShortName = "Vanuatu",
        FullName = "Republic of Vanuatu",
        IsoCodeAlpha2 = "VU",
        IsoCodeAlpha3 = "VUT",
        IsoCodeNumeric = "548",
        IsIndependent = true
    };

    public static Country Venezuela { get; } = new()
    {
        ShortName = "Venezuela",
        FullName = "Bolivarian Republic of Venezuela",
        IsoCodeAlpha2 = "VE",
        IsoCodeAlpha3 = "VEN",
        IsoCodeNumeric = "862",
        IsIndependent = true
    };

    public static Country Vietnam { get; } = new()
    {
        ShortName = "Vietnam",
        FullName = "Socialist Republic of Vietnam",
        IsoCodeAlpha2 = "VN",
        IsoCodeAlpha3 = "VNM",
        IsoCodeNumeric = "704",
        IsIndependent = true
    };

    public static Country BritishVirginIslands { get; } = new()
    {
        ShortName = "British Virgin Islands",
        FullName = "Virgin Islands",
        IsoCodeAlpha2 = "VG",
        IsoCodeAlpha3 = "VGB",
        IsoCodeNumeric = "92",
        IsIndependent = false
    };

    public static Country UnitedStatesVirginIslands { get; } = new()
    {
        ShortName = "United States Virgin Islands",
        FullName = "Virgin Islands of the United States",
        IsoCodeAlpha2 = "VI",
        IsoCodeAlpha3 = "VIR",
        IsoCodeNumeric = "850",
        IsIndependent = false
    };
}