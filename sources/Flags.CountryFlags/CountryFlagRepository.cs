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
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
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

        bool resourceExists = CheckResourceExists(id);
        if (!resourceExists)
            return null;

        string idUpperCase = id.Value.ToUpper();

        Uri resourceUri = new($"Pack://application:,,,/DustInTheWind.Flags.CountryFlags;component/Flags/{idUpperCase}.xaml");

        try
        {
            ResourceDictionary resourceDictionary = new()
            {
                Source = resourceUri
            };

            string resourceName = "CountryFlag_" + idUpperCase;

            return resourceDictionary.Contains(resourceName)
                ? resourceDictionary[resourceName] as Canvas
                : null;
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    private static bool CheckResourceExists(FlagId id)
    {
        return GetResourcePaths(Assembly.GetExecutingAssembly())
            .Where(x => x is string)
            .Cast<string>()
            .Any(x => x.Contains($"flags/{id.Value}", StringComparison.OrdinalIgnoreCase));
    }

    public static IEnumerable<object> GetResourcePaths(Assembly assembly)
    {
        CultureInfo culture = System.Threading.Thread.CurrentThread.CurrentCulture;
        string resourceName = assembly.GetName().Name + ".g";
        ResourceManager resourceManager = new(resourceName, assembly);

        try
        {
            ResourceSet? resourceSet = resourceManager.GetResourceSet(culture, true, true);

            foreach (System.Collections.DictionaryEntry resource in resourceSet)
            {
                yield return resource.Key;
            }
        }
        finally
        {
            resourceManager.ReleaseAllResources();
        }
    }
}