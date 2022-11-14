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

namespace DustInTheWind.CountryFlags;

public static partial class Countries
{
    public static Country FalklandIslands { get; } = new()
    {
        ShortName = "Falkland Islands",
        FullName = "Falkland Islands (Malvinas)",
        IsoCodeAlpha2 = "FK",
        IsoCodeAlpha3 = "FLK",
        IsoCodeNumeric = "238",
        IsIndependent = false
    };

    public static Country FaroeIslands { get; } = new()
    {
        ShortName = "Faroe Islands",
        FullName = "Faroe Islands",
        IsoCodeAlpha2 = "FO",
        IsoCodeAlpha3 = "FRO",
        IsoCodeNumeric = "234",
        IsIndependent = false
    };

    public static Country Fiji { get; } = new()
    {
        ShortName = "Fiji",
        FullName = "Republic of Fiji",
        IsoCodeAlpha2 = "FJ",
        IsoCodeAlpha3 = "FJI",
        IsoCodeNumeric = "242",
        IsIndependent = true
    };

    public static Country Finland { get; } = new()
    {
        ShortName = "Finland",
        FullName = "Republic of Finland",
        IsoCodeAlpha2 = "FI",
        IsoCodeAlpha3 = "FIN",
        IsoCodeNumeric = "246",
        IsIndependent = true
    };

    public static Country France { get; } = new()
    {
        ShortName = "France",
        FullName = "French Republic",
        IsoCodeAlpha2 = "FR",
        IsoCodeAlpha3 = "FRA",
        IsoCodeNumeric = "250",
        IsIndependent = true
    };

    public static Country FrenchGuiana { get; } = new()
    {
        ShortName = "French Guiana",
        FullName = "French Guiana",
        IsoCodeAlpha2 = "GF",
        IsoCodeAlpha3 = "GUF",
        IsoCodeNumeric = "254",
        IsIndependent = false
    };

    public static Country FrenchPolynesia { get; } = new()
    {
        ShortName = "French Polynesia",
        FullName = "French Polynesia",
        IsoCodeAlpha2 = "PF",
        IsoCodeAlpha3 = "PYF",
        IsoCodeNumeric = "258",
        IsIndependent = false
    };

    public static Country FrenchSouthernTerritories { get; } = new()
    {
        ShortName = "French Southern Territories",
        FullName = "French Southern and Antarctic Lands",
        IsoCodeAlpha2 = "TF",
        IsoCodeAlpha3 = "ATF",
        IsoCodeNumeric = "260",
        IsIndependent = false
    };
}