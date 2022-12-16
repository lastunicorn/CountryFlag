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

namespace DustInTheWind.Flags.CountryFlags;

public static partial class Countries
{
    public static Country Denmark { get; } = new()
    {
        ShortName = "Denmark",
        FullName = "Denmark",
        IsoCodeAlpha2 = "DK",
        IsoCodeAlpha3 = "DNK",
        IsoCodeNumeric = "208",
        IsIndependent = true
    };

    public static Country Djibouti { get; } = new()
    {
        ShortName = "Djibouti",
        FullName = "Republic of Djibouti",
        IsoCodeAlpha2 = "DJ",
        IsoCodeAlpha3 = "DJI",
        IsoCodeNumeric = "262",
        IsIndependent = true
    };

    public static Country Dominica { get; } = new()
    {
        ShortName = "Dominica",
        FullName = "Commonwealth of Dominica",
        IsoCodeAlpha2 = "DM",
        IsoCodeAlpha3 = "DMA",
        IsoCodeNumeric = "212",
        IsIndependent = true
    };

    public static Country DominicanRepublic { get; } = new()
    {
        ShortName = "Dominican Republic",
        FullName = "Dominican Republic",
        IsoCodeAlpha2 = "DO",
        IsoCodeAlpha3 = "DOM",
        IsoCodeNumeric = "214",
        IsIndependent = true
    };
}