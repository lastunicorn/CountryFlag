﻿// Country Flags
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

public class Bahamas_Emblem : CoatOfArms
{
    public Bahamas_Emblem()
    {
        Country = Countries.Bahamas;

        Id = "Emblem";
        Label = "National Emblem";
        StartDate = new FlagDate(1964);
        CoaDescription = new CoatOfArmsDescription
        {
            Motto = new TranslationNote
            {
                Text = "Expulsis Piratis – Restituta Commercia",
                EnglishTranslation = "Pirates Expelled – Commerce Restored"
            }
        };
    }
}