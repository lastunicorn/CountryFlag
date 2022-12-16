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
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace DustInTheWind.Flags.Core;

internal class AggregateFlagRepository : IFlagRepository, IEnumerable<IFlagRepository>
{
    private readonly ConcurrentBag<IFlagRepository> items = new();

    public string Id => string.Empty;

    public void Add(IFlagRepository flagRepository)
    {
        if (flagRepository == null) throw new ArgumentNullException(nameof(flagRepository));

        items.Add(flagRepository);
    }

    public Canvas? Get(FlagId id)
    {
        if (id.HasRepository)
            return items.FirstOrDefault(x => x.Id == id.RepositoryId)?.Get(id);

        return items
            .Select(x => x.Get(id))
            .FirstOrDefault();
    }

    public IEnumerator<IFlagRepository> GetEnumerator()
    {
        return items.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}