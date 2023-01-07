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

using System.Linq;

namespace DustInTheWind.CountryFlags.Demo.ViewModels;

public class FlagItemViewModel
{
    public string? Title { get; }

    public string? Id { get; }

    public bool IsAdditional { get; }

    public FlagItemViewModel(CountryFlag? countryFlag)
    {
        if (countryFlag == null)
            return;

        Id = countryFlag.FullId;
        IsAdditional = !string.IsNullOrEmpty(countryFlag.Id);

        if (IsAdditional)
        {
            string? name = countryFlag.Names?.Count is > 0
                ? countryFlag.Names.First().EnglishTranslation
                : null;

            Title = name ?? countryFlag.Country?.ShortName;
        }
        else
        {
            Title = countryFlag.Country?.ShortName;
        }
    }

    public override string ToString()
    {
        return Title ?? string.Empty;
    }
}