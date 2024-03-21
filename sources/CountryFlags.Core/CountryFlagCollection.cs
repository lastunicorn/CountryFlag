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

using System;
using System.Collections.ObjectModel;

namespace DustInTheWind.CountryFlags;

public class CountryFlagCollection : Collection<CountryFlag>
{
    private Country? country;

    public Country? Country
    {
        get => country;
        set
        {
            country = value;

            foreach (CountryFlag countryFlag in Items)
                countryFlag.Country = country;
        }
    }

    protected override void InsertItem(int index, CountryFlag item)
    {
        if (item == null) throw new ArgumentNullException(nameof(item));

        item.Country = country;
        base.InsertItem(index, item);
    }

    protected override void RemoveItem(int index)
    {
        CountryFlag countryFlag = Items[index];
        countryFlag.Country = null;

        base.RemoveItem(index);
    }

    protected override void SetItem(int index, CountryFlag item)
    {
        if (item == null) throw new ArgumentNullException(nameof(item));

        CountryFlag countryFlag = Items[index];
        countryFlag.Country = null;

        item.Country = country;

        base.SetItem(index, item);
    }

    protected override void ClearItems()
    {
        foreach (CountryFlag countryFlag in Items)
            countryFlag.Country = null;

        base.ClearItems();
    }
}