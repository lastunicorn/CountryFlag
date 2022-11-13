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

public class Country
{
    public string ShortName { get; init; }

    public string FullName { get; init; }

    /// <summary>
    /// ISO 3166-1 is a standard defining codes for the names of countries, dependent territories, and special areas of geographical interest.
    /// </summary>
    public string IsoCodeAlpha2 { get; init; }

    /// <summary>
    /// ISO 3166-1 is a standard defining codes for the names of countries, dependent territories, and special areas of geographical interest.
    /// </summary>
    public string IsoCodeAlpha3 { get; init; }

    /// <summary>
    /// ISO 3166-1 is a standard defining codes for the names of countries, dependent territories, and special areas of geographical interest.
    /// </summary>
    public string IsoCodeNumeric { get; init; }
}