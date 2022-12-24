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

namespace DustInTheWind.Flags.CountryFlags;

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

    public bool IsIndependent { get; init; }
    
    public string Description { get; init; }
    
    public DateTime AdoptedDate { get; init; }
    
    public string DesignedBy { get; init; }
    
    public FlagUsage Usage { get; init; }

    public bool IsMatch(string? id)
    {
        if (id == null)
            return false;

        return IsoCodeAlpha2 == id || IsoCodeAlpha3 == id || IsoCodeNumeric == id;

        //return id.Length switch
        //{
        //    2 => id == IsoCodeAlpha2,
        //    3 => id == IsoCodeAlpha3 || id == IsoCodeNumeric,
        //    _ => false
        //};
    }
}