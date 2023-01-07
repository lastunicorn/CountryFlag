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
using System.Text;

namespace DustInTheWind.CountryFlags
{
    public struct FlagDate
    {
        public int Year { get; }

        public int? Month { get; }

        public int? Day { get; }

        public FlagDate(int year)
        {
            Year = year;
            Month = null;
            Day = null;
        }

        public FlagDate(int year, int month)
        {
            Year = year;
            Month = month;
            Day = null;
        }

        public FlagDate(int year, int month, int day)
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

        public static implicit operator FlagDate(DateTime dateTime)
        {
            return new FlagDate(dateTime.Year, dateTime.Month, dateTime.Day);
        }
    }
}