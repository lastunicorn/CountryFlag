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
using System.Collections.Generic;
using System.Text;

namespace DustInTheWind.Flags.CountryFlags;

public class CountryFlag
{
    public Country? Country { get; internal set; }

    public string? Id { get; init; }

    public string FullId
    {
        get
        {
            StringBuilder sb = new();

            if (Country != null)
                sb.Append(Country.IsoCodeAlpha2);

            if (Id != null)
            {
                if (sb.Length > 0)
                    sb.Append(">");

                sb.Append(Id);
            }

            return sb.ToString();
        }
    }

    public List<string> Names { get; set; }

    public string? Description { get; init; }
    
    public DateTime? StartDate { get; init; }
    
    public DateTime? EndDate { get; init; }

    public string? DesignedBy { get; init; }

    public FlagUsage Usage { get; init; }

    public string? Comments { get; init; }

    public bool IsMatch(string? id)
    {
        if (id == null)
            return false;

        return FullId == id;
    }
}