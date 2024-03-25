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

public class PapuaNewGuineaFlag : CountryFlag
{
    public PapuaNewGuineaFlag()
    {
        Country = Countries.PapuaNewGuinea;

        Description = "Divided diagonally from the upper hoist-side corner to the lower fly-side corner: the upper triangle is red with the soaring Raggiana bird-of-paradise and the lower triangle is black with the Southern Cross of four white larger five-pointed stars and the smaller star.";
        StartDate = new FlagDate(1971, 07, 01);
        DesignedBy = "Susan Karike Huhume";
        Usage = FlagUsage.NationalFlag | FlagUsage.CivilEnsign | FlagUsage.StateEnsign;
    }
}