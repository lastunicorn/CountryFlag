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

using System.Collections.ObjectModel;

namespace DustInTheWind.CountryFlags.Demo.ViewModels;

public class CountryTreeItem
{
    public string Title { get; }

    public string FlagId { get; }

    public ObservableCollection<FlagTreeItem> Flags { get; }

    public CountryTreeItem(Country country)
    {
        Title = country.ShortName;

        FlagId = country.Flags
            .FirstOrDefault(x => x.Id == null)?
            .FullId;

        IEnumerable<FlagTreeItem> flags = country.Flags
            .Where(x => x.Id != null)
            .Select(x => new FlagTreeItem(x));

        Flags = new ObservableCollection<FlagTreeItem>(flags);
    }
}