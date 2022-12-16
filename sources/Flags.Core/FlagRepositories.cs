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

namespace DustInTheWind.Flags.Core;

public static class FlagRepositories
{
    public static IFlagRepository? Repository { get; private set; }

    public static void Add(IFlagRepository flagRepository)
    {
        if (flagRepository == null) throw new ArgumentNullException(nameof(flagRepository));

        AddInternal(flagRepository);
    }

    private static void AddInternal(IFlagRepository flagRepository)
    {
        if (Repository == null)
        {
            Repository = flagRepository;
        }
        else if (Repository is AggregateFlagRepository aggregateFlagRepository)
        {
            aggregateFlagRepository.Add(flagRepository);
        }
        else
        {
            Repository = new AggregateFlagRepository
            {
                Repository,
                flagRepository
            };
        }
    }

    public static void AddRange(IEnumerable<IFlagRepository?> flagRepositories)
    {
        if (flagRepositories == null) throw new ArgumentNullException(nameof(flagRepositories));

        foreach (IFlagRepository? flagRepository in flagRepositories)
        {
            if (flagRepository == null)
                continue;

            AddInternal(flagRepository);
        }
    }
}