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

public class Lithuania_CoatOfArms : CoatOfArms
{
    public Lithuania_CoatOfArms()
    {
        Country = Countries.Lithuania;

        Id = "Coa";
        Label = "Coat of arms";
        Armiger = "Grand Duchy of Lithuania, Republic of Lithuania";
        StartDate = new FlagDate(1366)
        {
            Description = "first documented"
        };
        OtherDates = new List<FlagDate>
        {
            new(1991)
            {
                Description = "current official version"
            }
        };
        CoaDescription = new CoatOfArmsDescription
        {
            Shield = "Gules, an armoured knight armed cap-à-pie mounted on a horse salient holding in his dexter hand a sword Argent above his head. A shield Azure hangs on the sinister shoulder charged with a double cross (Cross of Lorraine) Or. The horse saddles, straps, and belts Azure. The hilt of the sword and the fastening of the sheath, the stirrups, the curb bits of the bridle, the horseshoes, as well as the decoration of the harness, all Or."
        };
    }
}