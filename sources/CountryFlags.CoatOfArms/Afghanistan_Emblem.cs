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

public class Afghanistan_Emblem : CoatOfArms
{
    public Afghanistan_Emblem()
    {
        Country = Countries.Afghanistan_IslamicEmirate;

        Id = "Emblem";
        Label = "National emblem";
        Armiger = "Islamic Emirate of Afghanistan";
        StartDate = new FlagDate(2021, 08, 15);
        CoaDescription = new CoatOfArmsDescription
        {
            Shield = "Azure a stag trippant Or.",
            OtherElements = "Comital coronet above the shield",
            Motto = "لا إله إلا الله محمد رسول الله \"There is no god except Allah; Mohammad is the messenger of Allah.\" (Shahada)"
        };
    }
}