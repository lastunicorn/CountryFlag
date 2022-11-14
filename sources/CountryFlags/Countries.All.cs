﻿// Country Flags
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

using System.Collections.Immutable;

namespace DustInTheWind.CountryFlags;

public static partial class Countries
{
    public static ImmutableList<Country> All { get; }

    static Countries()
    {
        Country[] countries =
        {
            // A

            Afghanistan_IslamicEmirate,
            Afghanistan_IslamicRepublic,
            Aland,
            Albania,
            Algeria,
            AmericanSamoa,
            Andorra,
            Angola,
            Anguilla,
            Antarctica,
            AntiguaAndBarbuda,
            Argentina,
            Armenia,
            Aruba,
            Australia,
            Azerbaijan,

            // B

            Bahamas,
            Bahrain,
            Bangladesh,
            Barbados,
            Belarus,
            Belgium,
            Belize,
            Benin,
            Bermuda,
            Bhutan,
            Bolivia,
            CaribbeanNetherlands,
            BosniaHerzegovina,
            Botswana,
            BouvetIsland,
            Brazil,
            BritishIndianOceanTerritory,
            Brunei,
            Bulgaria,
            BurkinaFaso,
            Burundi,

            // C

            CapeVerde,
            Cambodia,
            Cameroon,
            Canada,
            CaymanIslands,
            CentralAfricanRepublic,
            Chad,
            Chile,
            ChristmasIsland,
            CocosIslands,
            Colombia,
            Comoros,
            Congo_Republic,
            Congo_DemocraticRepublic,
            CookIslands,
            CostaRica,
            IvoryCoast,
            Croatia,
            Cuba,
            Curacao,
            Cyprus,
            Czechia,

            // D

            Denmark,
            Djibouti,
            Dominica,
            DominicanRepublic,

            // E

            Ecuador,
            Egypt,
            ElSalvador,
            EquatorialGuinea,
            Eritrea,
            Estonia,
            Eswatini,
            Ethiopia,

            // F

            FalklandIslands,
            FaroeIslands,
            Fiji,
            Finland,
            France,
            FrenchGuiana,
            FrenchPolynesia,
            FrenchSouthernTerritories,

            // G

            Gabon,
            Gambia,
            Georgia,
            Germany,
            Ghana,
            Gibraltar,
            Greece,
            Greenland,
            Grenada,
            Guadeloupe,
            Guam,
            Guatemala,
            Guernsey,
            Guinea,
            GuineaBissau,
            Guyana
        };

        All = countries.ToImmutableList();
    }
}