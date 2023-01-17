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
using System.Linq;

namespace DustInTheWind.CountryFlags.Demo.ViewModels;

public class FlagInfoViewModel
{
    public string? CountryName { get; }

    public string? IsoCodeAlpha2 { get; }

    public string? IsoCodeAlpha3 { get; }

    public string? IsoCodeNumeric { get; }

    public string? CountryFullName { get; }

    public string? FlagName { get; }

    public string? FlagDescription { get; }

    public FlagUsage FlagUsage { get; }

    public string FlagUsageDescription { get; }

    public FlagDate? StartDate { get; }

    public FlagInfoViewModel(CountryFlag? countryFlag)
    {
        CountryName = countryFlag?.Country?.ShortName;
        IsoCodeAlpha2 = countryFlag?.Country?.IsoCodeAlpha2;
        IsoCodeAlpha3 = countryFlag?.Country?.IsoCodeAlpha3;
        IsoCodeNumeric = countryFlag?.Country?.IsoCodeNumeric;
        CountryFullName = countryFlag?.Country?.FullName;

        IEnumerable<string>? flagNames = countryFlag?.Names?.Select(x => x.EnglishTranslation);
        FlagName = flagNames != null
            ? string.Join(", ", flagNames)
            : string.Empty;

        FlagDescription = countryFlag?.Description;
        FlagUsage = countryFlag?.Usage ?? FlagUsage.None;
        FlagUsageDescription = countryFlag?.Usage.ToDisplayString() ?? string.Empty;

        StartDate = countryFlag?.StartDate;
    }

    public override string ToString()
    {
        return CountryName ?? string.Empty;
    }
}