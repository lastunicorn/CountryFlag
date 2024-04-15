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

public class Antarctica_TrueSouthFlag : CountryFlag
{
    public Antarctica_TrueSouthFlag()
    {
        Country = Countries.Antarctica;

        Id = "TrueSouth";
        Label = "True South";
        Description = "Horizontal stripes of navy and white represent the long days and nights at Antarctica's extreme latitude. In the center, a lone white peak erupts from a field of snow and ice, echoing those of the bergs, mountains, and pressure ridges that define the Antarctic horizon. The long shadow it casts forms the unmistakable shape of a compass arrow pointed south, an homage to the continent's legacy of exploration. Together, the two center shapes create a diamond, symbolizing the hope that Antarctica will continue to be a center of peace, discovery, and cooperation for generations to come.";
        StartDate = new FlagDate(2018);
        DesignedBy = "Evan Townsend";
    }
}