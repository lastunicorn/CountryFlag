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

using System.Reflection;

namespace DustInTheWind.CountryFlags;

public static class FlagsSetup
{
    public static void LoadAllFromAssemblyContaining<T>()
    {
        LoadAllFrom(typeof(T).Assembly);
    }

    public static void LoadAllFromAssemblyContaining(Type type)
    {
        LoadAllFrom(type.Assembly);
    }

    public static void LoadAllFrom(params Assembly[] assemblies)
    {
        IEnumerable<Type> types = assemblies
            .SelectMany(x => x.ExportedTypes);

        foreach (Type type in types)
        {
            bool isCountryFlag = typeof(CountryFlag).IsAssignableFrom(type);
            if (isCountryFlag)
                CreateAndRegisterFlag(type);

            bool isRepository = typeof(IFlagRepository).IsAssignableFrom(type);
            if (isRepository)
                CreateAndRegisterRepository(type);
        }
    }

    private static void CreateAndRegisterFlag(Type type)
    {
        CountryFlag countryFlag = (CountryFlag)Activator.CreateInstance(type);

        bool countryExists = Countries.EnumerateAll()
            .Any(x => x == countryFlag.Country);

        if (countryExists)
            countryFlag.Country.Flags.Add(countryFlag);
    }

    private static void CreateAndRegisterRepository(Type type)
    {
        IFlagRepository flagRepository = (IFlagRepository)Activator.CreateInstance(type);
        FlagRepositories.Add(flagRepository);
    }
}