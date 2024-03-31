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

namespace DustInTheWind.CountryFlags.InUseFlags;

public class Ukraine_VariantFlag : CountryFlag
{
    public Ukraine_VariantFlag()
    {
        Country = Countries.Ukraine;

        Id = "Variant";
        Names = new List<FlagName>
        {
            new()
            {
                EnglishTranslation = "Variant Flag"
            }
        };
        Description = "The sky-blue version that was official in 1991–1992.";
        Comments = "This variant is still in widespread use next to the current darker version.";
        StartDate = new FlagDate(1991);
        EndDate = new FlagDate(1992);
        Usage = FlagUsage.NationalFlag | FlagUsage.CivilAndStateEnsign;
    }
}