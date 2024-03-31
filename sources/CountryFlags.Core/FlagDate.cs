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

using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;

namespace DustInTheWind.CountryFlags;

public class FlagDate
{
    public Date Date { get; init; }

    public string Description { get; init; }

    public FlagDate(Date date)
    {
        Date = date;
        Description = string.Empty;
    }

    public FlagDate(DateTime dateTime)
    {
        Date = new Date(dateTime.Year, dateTime.Month, dateTime.Day);
        Description = string.Empty;
    }

    public FlagDate(int year)
    {
        Date = new Date(year);
        Description = string.Empty;
    }

    public FlagDate(int year, int month)
    {
        Date = new Date(year, month);
        Description = string.Empty;
    }

    public FlagDate(int year, int month, int day)
    {
        Date = new Date(year, month, day);
        Description = string.Empty;
    }

    public static implicit operator FlagDate(Date date)
    {
        return new FlagDate(date);
    }

    public static implicit operator FlagDate(DateTime dateTime)
    {
        return new FlagDate(dateTime);
    }
}

public readonly struct Date
{
    public int Year { get; }

    public int? Month { get; }

    public int? Day { get; }

    public Date(int year)
    {
        Year = year;
        Month = null;
        Day = null;
    }

    public Date(int year, int month)
    {
        Year = year;
        Month = month;
        Day = null;
    }

    public Date(int year, int month, int day)
    {
        Year = year;
        Month = month;
        Day = day;
    }

    public override string ToString()
    {
        StringBuilder sb = new();

        sb.Append(Year);

        if (Month.HasValue)
            sb.Append($"-{Month:00}");

        if (Day.HasValue)
            sb.Append($"-{Day:00}");

        return sb.ToString();
    }

    public static implicit operator Date(DateTime dateTime)
    {
        return new Date(dateTime.Year, dateTime.Month, dateTime.Day);
    }
}