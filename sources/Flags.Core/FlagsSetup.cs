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
using System.Linq;
using System.Reflection;

namespace DustInTheWind.Flags.Core;

public static class FlagsSetup
{
    public static void LoadModule(Type flagModuleType)
    {
        if (flagModuleType == null) throw new ArgumentNullException(nameof(flagModuleType));

        IFlagModule? flagModule = Activator.CreateInstance(flagModuleType) as IFlagModule;

        if (flagModule == null)
            throw new ArgumentException($"The provided type is not a flag module. It must implement the interface {typeof(IFlagModule)}", nameof(flagModuleType));

        LoadModuleInternal(flagModule);
    }

    public static void LoadModulesFromAssemblyContaining(Type type)
    {
        if (type == null) throw new ArgumentNullException(nameof(type));

        Assembly assembly = type.Assembly;
        LoadModulesFrom(assembly);
    }

    public static void LoadModulesFrom(params Assembly[] assemblies)
    {
        IEnumerable<IFlagModule> flagModules = assemblies
            .SelectMany(x => x.ExportedTypes)
            .Where(x => typeof(IFlagModule).IsAssignableFrom(x))
            .Select(x => (IFlagModule)Activator.CreateInstance(x)!);

        foreach (IFlagModule flagModule in flagModules)
            LoadModuleInternal(flagModule);
    }

    private static void LoadModuleInternal(IFlagModule flagModule)
    {
        IEnumerable<IFlagRepository> flagRepositories = flagModule.GetFlagRepositories();
        FlagRepositories.AddRange(flagRepositories);

        flagModule.InitializeFlags();
    }
}