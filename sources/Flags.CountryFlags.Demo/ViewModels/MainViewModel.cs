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

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace DustInTheWind.Flags.CountryFlags.Demo.ViewModels;

public class MainViewModel : ViewModelBase
{
    private FlagItemViewModel? selectedFlag;
    private FlagInfoViewModel? flagInfoViewModel;
    private string? flagId;
    private string? title;
    private string? subtitle;

    public ImmutableList<FlagItemViewModel> Flags { get; }

    public FlagItemViewModel? SelectedFlag
    {
        get => selectedFlag;
        set
        {
            selectedFlag = value;
            OnPropertyChanged();

            UpdateDisplayedFlag();
        }
    }

    public string? Title
    {
        get => title;
        private set
        {
            if (value == title)
                return;

            title = value;
            OnPropertyChanged();
        }
    }

    public string? Subtitle
    {
        get => subtitle;
        private set
        {
            if (value == subtitle)
                return;

            subtitle = value;
            OnPropertyChanged();
        }
    }

    public FlagInfoViewModel? FlagInfoViewModel
    {
        get => flagInfoViewModel;
        private set
        {
            if (Equals(value, flagInfoViewModel))
                return;

            flagInfoViewModel = value;
            OnPropertyChanged();
        }
    }

    public string? FlagId
    {
        get => flagId;
        set
        {
            if (value == flagId)
                return;

            flagId = value;
            OnPropertyChanged();
        }
    }

    public MainViewModel()
    {
        IEnumerable<Country> enumerateAll = Countries.EnumerateAll();
        IEnumerable<CountryFlag> countryFlags = enumerateAll
            .SelectMany(x =>
            {
                if (x == null)
                {

                }
                return x.Flags ?? Enumerable.Empty<CountryFlag>();
            });
        IEnumerable<CountryFlag> enumerable = countryFlags
            .Where(x => x != null);
        IEnumerable<FlagItemViewModel> flagItemViewModels = enumerable
            .Select(x => new FlagItemViewModel(x))
            .Where(x => x != null);

        foreach (FlagItemViewModel flagItemViewModel in flagItemViewModels)
        {
            if (flagItemViewModel == null)
            {

            }
        }

        Flags = flagItemViewModels
            .ToImmutableList();
    }

    private void UpdateDisplayedFlag()
    {
        CountryFlag? countryFlag = selectedFlag == null
            ? null
            : Countries.EnumerateAll()
                .SelectMany(x => x.Flags ?? Enumerable.Empty<CountryFlag>())
                .FirstOrDefault(x => x.IsMatch(selectedFlag.Id));

        FlagInfoViewModel = new FlagInfoViewModel(countryFlag);
        FlagId = countryFlag?.FullId;
        Title = countryFlag?.Country?.ShortName;
        Subtitle = countryFlag?.Country?.FullName;
    }
}