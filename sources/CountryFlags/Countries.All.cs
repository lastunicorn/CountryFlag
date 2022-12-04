// Country Flags
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

using System.Collections.Generic;

namespace DustInTheWind.Flags.CountryFlags;

public static partial class Countries
{
    public static void Initialize(){}

    public static IEnumerable<Country> EnumerateAll()
    {
        // A

        yield return Afghanistan_IslamicEmirate;
        yield return Afghanistan_IslamicRepublic;
        yield return Aland;
        yield return Albania;
        yield return Algeria;
        yield return AmericanSamoa;
        yield return Andorra;
        yield return Angola;
        yield return Anguilla;
        yield return Antarctica;
        yield return AntiguaAndBarbuda;
        yield return Argentina;
        yield return Armenia;
        yield return Aruba;
        yield return Australia;
        yield return Azerbaijan;

        // B

        yield return Bahamas;
        yield return Bahrain;
        yield return Bangladesh;
        yield return Barbados;
        yield return Belarus;
        yield return Belgium;
        yield return Belize;
        yield return Benin;
        yield return Bermuda;
        yield return Bhutan;
        yield return Bolivia;
        yield return CaribbeanNetherlands;
        yield return BosniaHerzegovina;
        yield return Botswana;
        yield return BouvetIsland;
        yield return Brazil;
        yield return BritishIndianOceanTerritory;
        yield return Brunei;
        yield return Bulgaria;
        yield return BurkinaFaso;
        yield return Burundi;

        // C

        yield return CapeVerde;
        yield return Cambodia;
        yield return Cameroon;
        yield return Canada;
        yield return CaymanIslands;
        yield return CentralAfricanRepublic;
        yield return Chad;
        yield return Chile;
        yield return ChristmasIsland;
        yield return CocosIslands;
        yield return Colombia;
        yield return Comoros;
        yield return Congo_Republic;
        yield return Congo_DemocraticRepublic;
        yield return CookIslands;
        yield return CostaRica;
        yield return IvoryCoast;
        yield return Croatia;
        yield return Cuba;
        yield return Curacao;
        yield return Cyprus;
        yield return Czechia;

        // D

        yield return Denmark;
        yield return Djibouti;
        yield return Dominica;
        yield return DominicanRepublic;

        // E

        yield return Ecuador;
        yield return Egypt;
        yield return ElSalvador;
        yield return EquatorialGuinea;
        yield return Eritrea;
        yield return Estonia;
        yield return Eswatini;
        yield return Ethiopia;

        // F

        yield return FalklandIslands;
        yield return FaroeIslands;
        yield return Fiji;
        yield return Finland;
        yield return France;
        yield return FrenchGuiana;
        yield return FrenchPolynesia;
        yield return FrenchSouthernTerritories;

        // G

        yield return DustInTheWind.CountryFlags.Countries.Gabon;
        yield return DustInTheWind.CountryFlags.Countries.Gambia;
        yield return DustInTheWind.CountryFlags.Countries.Georgia;
        yield return DustInTheWind.CountryFlags.Countries.Germany;
        yield return DustInTheWind.CountryFlags.Countries.Ghana;
        yield return DustInTheWind.CountryFlags.Countries.Gibraltar;
        yield return DustInTheWind.CountryFlags.Countries.Greece;
        yield return DustInTheWind.CountryFlags.Countries.Greenland;
        yield return DustInTheWind.CountryFlags.Countries.Grenada;
        yield return DustInTheWind.CountryFlags.Countries.Guadeloupe;
        yield return DustInTheWind.CountryFlags.Countries.Guam;
        yield return DustInTheWind.CountryFlags.Countries.Guatemala;
        yield return DustInTheWind.CountryFlags.Countries.Guernsey;
        yield return DustInTheWind.CountryFlags.Countries.Guinea;
        yield return DustInTheWind.CountryFlags.Countries.GuineaBissau;
        yield return DustInTheWind.CountryFlags.Countries.Guyana;

        // H

        yield return Haiti;
        yield return HeardIslandAndMcDonaldIslands;
        yield return HolySee;
        yield return Honduras;
        yield return HongKong;
        yield return Hungary;
    }

    //static Countries()
    //{
    //    Country[] countries =
    //    {
    //        // A

    //        Afghanistan_IslamicEmirate,
    //        Afghanistan_IslamicRepublic,
    //        Aland,
    //        Albania,
    //        Algeria,
    //        AmericanSamoa,
    //        Andorra,
    //        Angola,
    //        Anguilla,
    //        Antarctica,
    //        AntiguaAndBarbuda,
    //        Argentina,
    //        Armenia,
    //        Aruba,
    //        Australia,
    //        Azerbaijan,

    //        // B

    //        Bahamas,
    //        Bahrain,
    //        Bangladesh,
    //        Barbados,
    //        Belarus,
    //        Belgium,
    //        Belize,
    //        Benin,
    //        Bermuda,
    //        Bhutan,
    //        Bolivia,
    //        CaribbeanNetherlands,
    //        BosniaHerzegovina,
    //        Botswana,
    //        BouvetIsland,
    //        Brazil,
    //        BritishIndianOceanTerritory,
    //        Brunei,
    //        Bulgaria,
    //        BurkinaFaso,
    //        Burundi,

    //        // C

    //        CapeVerde,
    //        Cambodia,
    //        Cameroon,
    //        Canada,
    //        CaymanIslands,
    //        CentralAfricanRepublic,
    //        Chad,
    //        Chile,
    //        ChristmasIsland,
    //        CocosIslands,
    //        Colombia,
    //        Comoros,
    //        Congo_Republic,
    //        Congo_DemocraticRepublic,
    //        CookIslands,
    //        CostaRica,
    //        IvoryCoast,
    //        Croatia,
    //        Cuba,
    //        Curacao,
    //        Cyprus,
    //        Czechia,

    //        // D

    //        Denmark,
    //        Djibouti,
    //        Dominica,
    //        DominicanRepublic,

    //        // E

    //        Ecuador,
    //        Egypt,
    //        ElSalvador,
    //        EquatorialGuinea,
    //        Eritrea,
    //        Estonia,
    //        Eswatini,
    //        Ethiopia,

    //        // F

    //        FalklandIslands,
    //        FaroeIslands,
    //        Fiji,
    //        Finland,
    //        France,
    //        FrenchGuiana,
    //        FrenchPolynesia,
    //        FrenchSouthernTerritories,

    //        // G

    //        Gabon,
    //        Gambia,
    //        Georgia,
    //        Germany,
    //        Ghana,
    //        Gibraltar,
    //        Greece,
    //        Greenland,
    //        Grenada,
    //        Guadeloupe,
    //        Guam,
    //        Guatemala,
    //        Guernsey,
    //        Guinea,
    //        GuineaBissau,
    //        Guyana,

    //        // H

    //        Haiti,
    //        HeardIslandAndMcDonaldIslands,
    //        HolySee,
    //        Honduras,
    //        HongKong,
    //        Hungary
    //    };

    //    EnumerateAll = countries.ToImmutableList();
    //}
}