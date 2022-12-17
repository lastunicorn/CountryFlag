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

namespace DustInTheWind.Flags.Core;

public readonly struct FlagId
{
    public string RepositoryId { get; init; }

    public string Value { get; init; }

    public bool HasRepository => !string.IsNullOrWhiteSpace(RepositoryId);

    public override string ToString()
    {
        return string.IsNullOrEmpty(RepositoryId)
            ? Value
            : RepositoryId + ":" + Value;
    }

    public static implicit operator FlagId(string value)
    {
        int separatorIndex = value.IndexOf(":", StringComparison.Ordinal);

        if (separatorIndex >= 0)
            return new FlagId
            {
                RepositoryId = value[..separatorIndex],
                Value = value[(separatorIndex + 1)..]
            };

        return new FlagId
        {
            RepositoryId = string.Empty,
            Value = value
        };
    }
}