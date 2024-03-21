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
    public static Country Reunion { get; } = new()
    {
        ShortName = "Réunion",
        FullName = "Réunion",
        IsoCodeAlpha2 = "RE",
        IsoCodeAlpha3 = "REU",
        IsoCodeNumeric = "638",
        IsIndependent = false
    };

    public static Country Romania { get; } = new()
    {
        ShortName = "Romania",
        FullName = "Romania",
        IsoCodeAlpha2 = "RO",
        IsoCodeAlpha3 = "ROU",
        IsoCodeNumeric = "642",
        IsIndependent = true
    };

    public static Country Russia { get; } = new()
    {
        ShortName = "Russia",
        FullName = "Russian Federation",
        IsoCodeAlpha2 = "RU",
        IsoCodeAlpha3 = "RUS",
        IsoCodeNumeric = "643",
        IsIndependent = true
    };

    public static Country Rwanda { get; } = new()
    {
        ShortName = "Rwanda",
        FullName = "Republic of Rwanda",
        IsoCodeAlpha2 = "RW",
        IsoCodeAlpha3 = "RWA",
        IsoCodeNumeric = "646",
        IsIndependent = true
    };
}