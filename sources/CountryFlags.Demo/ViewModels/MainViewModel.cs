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

namespace DustInTheWind.CountryFlags.Demo.ViewModels;

public class MainViewModel : ViewModelBase
{
    private FlagInfoViewModel flagInfoViewModel;
    private string flagId;
    private string title;
    private string subtitle;
    private string selectedFlagId;

    public List<CountryTreeItem> CountryTree { get; }
    
    public string SelectedFlagId
    {
        get => selectedFlagId;
        set
        {
            if (value == selectedFlagId) return;
            selectedFlagId = value;
            OnPropertyChanged();

            UpdateDisplayedFlag();
        }
    }

    public string Title
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

    public string Subtitle
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

    public FlagInfoViewModel FlagInfoViewModel
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

    public string FlagId
    {
        get => flagId;
        private set
        {
            if (value == flagId)
                return;

            flagId = value;
            OnPropertyChanged();
        }
    }

    public MainViewModel()
    {
        CountryTree = Countries.EnumerateAll()
            .Select(x => new CountryTreeItem(x))
            .ToList();
    }

    private void UpdateDisplayedFlag()
    {
        CountryFlag countryFlag = selectedFlagId == null
            ? null
            : Countries.EnumerateAll()
                .SelectMany(x => x.Flags)
                .FirstOrDefault(x => x.IsMatch(selectedFlagId));

        FlagInfoViewModel = new FlagInfoViewModel(countryFlag);
        FlagId = countryFlag?.FullId;
        Title = countryFlag?.Country?.ShortName;
        Subtitle = countryFlag?.Country?.FullName;
    }
}