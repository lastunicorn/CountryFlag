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

namespace DustInTheWind.CountryFlags.CountryCoatOfArms;

public class Finland_CoatOfArms : CoatOfArms
{
    public Finland_CoatOfArms()
    {
        Country = Countries.Finland;

        Id = "Coa";
        Label = "Coat of arms";
        Armiger = "Republic of Finland";
        StartDate = new FlagDate(1580)
        {
            Description = "first documented"
        };
        OtherDates = new List<FlagDate>
        {
            new(1978)
            {
                Description = "current version"
            }
        };
        CoaDescription = new CoatOfArmsDescription
        {
            Shield = "Gules, sémy of nine roses Argent, a crowned lion rampant Or armed of the same trampling a sabre Argent hilted and pommeled Or, his dexter foreleg in the form of an arm in armour Argent garnished Or bearing aloft a sword Argent hilted and pommeled Or."
        };
    }
}