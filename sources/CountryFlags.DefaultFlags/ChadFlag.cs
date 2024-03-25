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

namespace DustInTheWind.CountryFlags.DefaultFlags;

public class ChadFlag : CountryFlag
{
    public ChadFlag()
    {
        Country = Countries.Chad;

        Names = new List<FlagName>
        {
            "Drapeau du Tchad",
            "علم تشاد",
            "Les trois barres"
        };
        Description = "The flag of Chad is a vertical tricolour consisting (left to right) of a blue, a gold and a red column. These were intended to be a combination of the colours of blue, white and red as seen on the Flag of France with the Pan-African colours of green, yellow and red. Furthermore, the blue represents the sky and hope; the gold is the sun and desert, and the red signifies the bloodshed over independence.";
        StartDate = new FlagDate(1959, 11, 06);
        Usage = FlagUsage.NationalFlag;
    }
}