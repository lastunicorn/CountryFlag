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

public class SouthKorea_CoatOfArms : CoatOfArms
{
    public SouthKorea_CoatOfArms()
    {
        Country = Countries.SouthAfrica;

        Id = "Coa";
        Label = "Coat of arms";
        StartDate = new FlagDate(2000, 04, 27);
        CoaDescription = new CoatOfArmsDescription
        {
            Shield = "Arms: Or, representations of two San human figures of red ochre, statant respectant, the hands of the innermost arms clasped, with upper arm, inner wrist, waist and knee bands Argent, and a narrow border of red ochre; the shield ensigned of a spear and knobkierie in saltire, Sable. Thereabove a demi-secretary bird displayed Or, charged on the breast with a stylized representation of a protea flower with outer petals Vert, inner petals Or and seeded of nine triangles conjoined in three rows, the upper triangle Gules, the second row Vert, Or inverted and Vert, and the third row Vert, Or inverted, Sable, Or inverted and Vert. Above the head of the secretary bird an arc of seven rays facetted Or and Orange, the two outer rays conjoined to the elevated wings. Upon a riband Vert, the motto !KE E:/XARRA //KE in letters Argent. Issuant from the ends of the riband two pairs of elephant tusks curving inwards, the tips conjoined to the wings of the secretary bird, Or, therewithin and flanking the shields, two ears of wheat Brunatré.",
            Motto = "ǃke e꞉ ǀxarra ǁke - \"Diverse People Unite\" in |Xam"
        };
    }
}