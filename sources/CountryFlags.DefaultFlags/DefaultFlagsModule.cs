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

using System.Collections.Generic;
using DustInTheWind.Flags.Core;

namespace DustInTheWind.CountryFlags.DefaultFlags;

public class DefaultFlagsModule : IFlagModule
{
    private static volatile bool isInitialized;

    public IEnumerable<IFlagRepository> GetFlagRepositories()
    {
        yield return new DefaultFlagsRepository();
    }

    public void InitializeFlags()
    {
        if(isInitialized)
            return;

        AddFlagsToCountries();

        isInitialized = true;
    }

    private static void AddFlagsToCountries()
    {
        // A

        FlagsSetup.Afghanistan_IslamicEmirate();
        FlagsSetup.Aland();
        FlagsSetup.Albania();
        FlagsSetup.Algeria();
        FlagsSetup.AmericanSamoa();
        FlagsSetup.Andorra();
        FlagsSetup.Angola();
        FlagsSetup.Anguilla();
        FlagsSetup.Antarctica();
        FlagsSetup.AntiguaAndBarbuda();
        FlagsSetup.Argentina();
        FlagsSetup.Armenia();
        FlagsSetup.Aruba();
        FlagsSetup.Australia();
        FlagsSetup.Austria();
        FlagsSetup.Azerbaijan();

        // B

        FlagsSetup.Bahamas();
        FlagsSetup.Bahrain();
        FlagsSetup.Bangladesh();
        FlagsSetup.Barbados();
        FlagsSetup.Belarus();
        FlagsSetup.Belgium();
        FlagsSetup.Belize();
        FlagsSetup.Benin();
        FlagsSetup.Bermuda();
        FlagsSetup.Bhutan();
        FlagsSetup.Bolivia();
        FlagsSetup.CaribbeanNetherlands();
        FlagsSetup.BosniaHerzegovina();
        FlagsSetup.Botswana();
        FlagsSetup.BouvetIsland();
        FlagsSetup.Brazil();
        FlagsSetup.BritishIndianOceanTerritory();
        FlagsSetup.Brunei();
        FlagsSetup.Bulgaria();
        FlagsSetup.BurkinaFaso();
        FlagsSetup.Burundi();

        // C

        FlagsSetup.CaboVerde();
        FlagsSetup.Cambodia();
        FlagsSetup.Cameroon();
        FlagsSetup.Canada();
        FlagsSetup.CaymanIslands();
        FlagsSetup.CentralAfricanRepublic();
        FlagsSetup.Chad();
        FlagsSetup.Chile();
        FlagsSetup.China();
        FlagsSetup.ChristmasIsland();
        FlagsSetup.CocosIslands();
        FlagsSetup.Colombia();
        FlagsSetup.Comoros();
        FlagsSetup.Congo_Republic();
        FlagsSetup.Congo_DemocraticRepublic();
        FlagsSetup.CookIslands();
        FlagsSetup.CostaRica();
        FlagsSetup.IvoryCoast();
        FlagsSetup.Croatia();
        FlagsSetup.Cuba();
        FlagsSetup.Curacao();
        FlagsSetup.Cyprus();
        FlagsSetup.Czechia();

        // D

        FlagsSetup.Denmark();
        FlagsSetup.Djibouti();
        FlagsSetup.Dominica();
        FlagsSetup.DominicanRepublic();

        // E

        FlagsSetup.Ecuador();
        FlagsSetup.Egypt();
        FlagsSetup.ElSalvador();
        FlagsSetup.EquatorialGuinea();
        FlagsSetup.Eritrea();
        FlagsSetup.Estonia();
        FlagsSetup.Eswatini();
        FlagsSetup.Ethiopia();

        // F

        FlagsSetup.FalklandIslands();
        FlagsSetup.FaroeIslands();
        FlagsSetup.Fiji();
        FlagsSetup.Finland();
        FlagsSetup.France();
        FlagsSetup.FrenchGuiana();
        FlagsSetup.FrenchPolynesia();
        FlagsSetup.FrenchSouthernTerritories();

        // G

        FlagsSetup.Gabon();
        FlagsSetup.Gambia();
        FlagsSetup.Georgia();
        FlagsSetup.Germany();
        FlagsSetup.Ghana();
        FlagsSetup.Gibraltar();
        FlagsSetup.Greece();
        FlagsSetup.Greenland();
        FlagsSetup.Grenada();
        FlagsSetup.Guadeloupe();
        FlagsSetup.Guam();
        FlagsSetup.Guatemala();
        FlagsSetup.Guernsey();
        FlagsSetup.Guinea();
        FlagsSetup.GuineaBissau();
        FlagsSetup.Guyana();

        // H

        FlagsSetup.Haiti();
        FlagsSetup.HeardIslandAndMcDonaldIslands();
        FlagsSetup.HolySee();
        FlagsSetup.Honduras();
        FlagsSetup.HongKong();
        FlagsSetup.Hungary();

        // I

        FlagsSetup.Iceland();
        FlagsSetup.India();
        FlagsSetup.Indonesia();
        FlagsSetup.Iran();
        FlagsSetup.Iraq();
        FlagsSetup.Ireland();
        FlagsSetup.IsleOfMan();
        FlagsSetup.Israel();
        FlagsSetup.Italy();

        // J

        FlagsSetup.Jamaica();
        FlagsSetup.Japan();
        FlagsSetup.Jersey();
        FlagsSetup.Jordan();

        // K

        FlagsSetup.Kazakhstan();
        FlagsSetup.Kenya();
        FlagsSetup.Kiribati();
        FlagsSetup.NorthKorea();
        FlagsSetup.SouthKorea();
        FlagsSetup.Kuwait();
        FlagsSetup.Kyrgyzstan();

        // L

        FlagsSetup.Laos();
        FlagsSetup.Latvia();
        FlagsSetup.Lebanon();
        FlagsSetup.Lesotho();
        FlagsSetup.Liberia();
        FlagsSetup.Libya();
        FlagsSetup.Liechtenstein();
        FlagsSetup.Lithuania();
        FlagsSetup.Luxembourg();

        // M

        FlagsSetup.Macao();
        FlagsSetup.Madagascar();
        FlagsSetup.Malawi();
        FlagsSetup.Malaysia();
        FlagsSetup.Maldives();
        FlagsSetup.Mali();
        FlagsSetup.Malta();
        FlagsSetup.MarshallIslands();
        FlagsSetup.Martinique();
        FlagsSetup.Mauritania();
        FlagsSetup.Mauritius();
        FlagsSetup.Mayotte();
        FlagsSetup.Mexico();
        FlagsSetup.Micronesia();
        FlagsSetup.Moldova();
        FlagsSetup.Monaco();
        FlagsSetup.Mongolia();
        FlagsSetup.Montenegro();
        FlagsSetup.Montserrat();
        FlagsSetup.Morocco();
        FlagsSetup.Mozambique();
        FlagsSetup.Myanmar();

        // N

        FlagsSetup.Namibia();
        FlagsSetup.Nauru();
        FlagsSetup.Nepal();
        FlagsSetup.Netherlands();
        FlagsSetup.NewCaledonia();
        FlagsSetup.NewZealand();
        FlagsSetup.Nicaragua();
        FlagsSetup.Niger();
        FlagsSetup.Nigeria();
        FlagsSetup.Niue();
        FlagsSetup.NorfolkIsland();
        FlagsSetup.NorthMacedonia();
        FlagsSetup.NorthernMarianaIslands();
        FlagsSetup.Norway();

        // O

        FlagsSetup.Oman();

        // P

        FlagsSetup.Pakistan();
        FlagsSetup.Palau();
        FlagsSetup.Palestine();
        FlagsSetup.Panama();
        FlagsSetup.PapuaNewGuinea();
        FlagsSetup.Paraguay();
        FlagsSetup.Peru();
        FlagsSetup.Philippines();
        FlagsSetup.Pitcairn();
        FlagsSetup.Poland();
        FlagsSetup.Portugal();
        FlagsSetup.PuertoRico();

        // Q

        FlagsSetup.Qatar();

        // R

        FlagsSetup.Reunion();
        FlagsSetup.Romania();
        FlagsSetup.Russia();
        FlagsSetup.Rwanda();

        // S

        FlagsSetup.SaintBarthelemy();
        FlagsSetup.SaintHelenaAscensionAndTristanDdaCunha();
        FlagsSetup.SaintKittsAndNevis();
        FlagsSetup.SaintLucia();
        FlagsSetup.SaintMartin();
        FlagsSetup.SaintPierreAndMiquelon();
        FlagsSetup.SaintVincentAndTheGrenadines();
        FlagsSetup.Samoa();
        FlagsSetup.SanMarino();
        FlagsSetup.SaoTomeAndPrincipe();
        FlagsSetup.SaudiArabia();
        FlagsSetup.Senegal();
        FlagsSetup.Serbia();
        FlagsSetup.Seychelles();
        FlagsSetup.SierraLeone();
        FlagsSetup.Singapore();
        FlagsSetup.SintMaarten();
        FlagsSetup.Slovakia();
        FlagsSetup.Slovenia();
        FlagsSetup.SolomonIslands();
        FlagsSetup.Somalia();
        FlagsSetup.SouthAfrica();
        FlagsSetup.SouthGeorgiaAndTheSouthSandwichIslands();
        FlagsSetup.SouthSudan();
        FlagsSetup.Spain();
        FlagsSetup.SriLanka();
        FlagsSetup.Sudan();
        FlagsSetup.Suriname();
        FlagsSetup.SvalbardAndJanMayen();
        FlagsSetup.Sweden();
        FlagsSetup.Switzerland();
        FlagsSetup.SyrianArabRepublic();

        // T

        FlagsSetup.Taiwan();
        FlagsSetup.Tajikistan();
        FlagsSetup.Tanzania();
        FlagsSetup.Thailand();
        FlagsSetup.TimorLeste();
        FlagsSetup.Togo();
        FlagsSetup.Tokelau();
        FlagsSetup.Tonga();
        FlagsSetup.TrinidadAndTobago();
        FlagsSetup.Tunisia();
        FlagsSetup.Turkey();
        FlagsSetup.Turkmenistan();
        FlagsSetup.TurksAndCaicosIslands();
        FlagsSetup.Tuvalu();

        // U

        FlagsSetup.Uganda();
        FlagsSetup.Ukraine();
        FlagsSetup.UnitedArabEmirates();
        FlagsSetup.UnitedKingdom();
        FlagsSetup.UnitedStatesOfAmerica();
        FlagsSetup.UnitedStatesMinorOutlyingIslands();
        FlagsSetup.Uruguay();
        FlagsSetup.Uzbekistan();

        // V

        FlagsSetup.Vanuatu();
        FlagsSetup.Venezuela();
        FlagsSetup.Vietnam();
        FlagsSetup.BritishVirginIslands();
        FlagsSetup.UnitedStatesVirginIslands();

        // W

        FlagsSetup.WallisAndFutuna();
        FlagsSetup.WesternSahara();

        // Y

        FlagsSetup.Yemen();

        // Z

        FlagsSetup.Zambia();
        FlagsSetup.Zimbabwe();
    }
}