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

namespace DustInTheWind.CountryFlags;

public class CoatOfArmsDescription
{
    /// <summary>
    /// A crest is a component of a heraldic display, consisting of the device borne on top of the
    /// helm.
    /// </summary>
    public string Crest { get; set; }

    /// <summary>
    /// In heraldry, a torse or wreath is a twisted roll of fabric laid about the top of the helmet
    /// and the base of the crest.
    /// </summary>
    public string Torse { get; set; }

    /// <summary>
    /// In heraldry, an escutcheon is a shield that forms the main or focal element in an
    /// achievement of arms.
    /// </summary>
    public string Shield { get; set; }

    /// <summary>
    /// In heraldry, supporters, sometimes referred to as attendants, are figures or objects usually
    /// placed on either side of the shield and depicted holding it up.
    /// </summary>
    public string Supporters { get; set; }

    /// <summary>
    /// In heraldry, a compartment is a design placed under the shield, usually rocks, a grassy
    /// mount (mount vert), or some sort of other landscape upon which the supporters are depicted
    /// as standing.
    /// </summary>
    public string Compartment { get; set; }

    /// <summary>
    /// A motto (derived from the Latin muttum, 'mutter', by way of Italian motto, 'word' or
    /// 'sentence') is a sentence or phrase expressing a belief or purpose, or the general
    /// motivation or intention of an individual, family, social group, or organisation.
    /// </summary>
    public MultiLanguageText Motto { get; set; }

    public string OtherElements { get; set; }
}