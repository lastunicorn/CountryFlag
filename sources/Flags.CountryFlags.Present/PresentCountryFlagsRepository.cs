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
using System.Text;
using System.Windows;
using System.Windows.Controls;
using DustInTheWind.Flags.Core;

namespace DustInTheWind.CountryFlags.Present;

internal class PresentCountryFlagsRepository : FlagRepositoryBase
{
    public override string Id => "country";

    protected override Canvas? GetInternal(FlagId flagId)
    {
        CountryFlag? countryFlag = Countries.EnumerateAll()
            .SelectMany(x => x.Flags)
            .FirstOrDefault(x => x.IsMatch(flagId.Value));

        if (countryFlag?.Country == null)
            return null;

        string resourceId = CalculateResourceIdFor(countryFlag);

        if (string.IsNullOrEmpty(resourceId))
            return null;

        bool resourceExists = Exists(resourceId);
        if (!resourceExists)
            return null;

        Uri resourceUri = new($"Pack://application:,,,/DustInTheWind.CountryFlags.Present;component/Flags/{resourceId}.xaml");

        ResourceDictionary resourceDictionary = new()
        {
            Source = resourceUri
        };

        string resourceName = "CountryFlag_" + resourceId;

        return resourceDictionary.Contains(resourceName)
            ? resourceDictionary[resourceName] as Canvas
            : null;
    }

    private static string CalculateResourceIdFor(CountryFlag countryFlag)
    {
        StringBuilder sb = new();

        if (countryFlag.Country != null)
            sb.Append(countryFlag.Country.IsoCodeAlpha2);

        if (countryFlag.Id != null)
        {
            if (sb.Length > 0)
                sb.Append("_");

            sb.Append(countryFlag.Id);
        }

        return sb.ToString();
    }

    private static bool Exists(string flagId)
    {
        Assembly executingAssembly = Assembly.GetExecutingAssembly();
        return GetResourcePaths(executingAssembly)
            .Where(x => x is string)
            .Cast<string>()
            .Any(x => x.Contains($"flags/{flagId}.baml", StringComparison.OrdinalIgnoreCase));
    }

    public static IEnumerable<object> GetResourcePaths(Assembly assembly)
    {
        CultureInfo culture = System.Threading.Thread.CurrentThread.CurrentCulture;
        string resourceName = assembly.GetName().Name + ".g";
        ResourceManager resourceManager = new(resourceName, assembly);

        try
        {
            ResourceSet? resourceSet = resourceManager.GetResourceSet(culture, true, true);

            if (resourceSet == null)
                yield break;

            foreach (System.Collections.DictionaryEntry resource in resourceSet)
                yield return resource.Key;
        }
        finally
        {
            resourceManager.ReleaseAllResources();
        }
    }
}