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
using System.Windows;
using System.Windows.Controls;
using DustInTheWind.Flags.Core;

namespace DustInTheWind.Flags.CountryFlags;

public class CountryFlagRepository : IFlagRepository
{
    public string Id => "countries";

    public Canvas? Get(FlagId id)
    {
        if (id.HasRepository && id.RepositoryId != Id)
            return null;

        string idUpperCase = id.Value.ToUpper();

        Uri resourceUri = new($"Pack://application:,,,/DustInTheWind.Flags.CountryFlags;component/Flags/{idUpperCase}.xaml");
        string resourceName = "CountryFlag_" + idUpperCase;

        try
        {
            ResourceDictionary resourceDictionary = new()
            {
                Source = resourceUri
            };

            return resourceDictionary[resourceName] as Canvas;
        }
        catch
        {
            return null;
        }
    }
}