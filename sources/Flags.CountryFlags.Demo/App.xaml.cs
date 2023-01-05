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

using System.Reflection;
using System.Windows;
using DustInTheWind.Flags.Core;
using DustInTheWind.Flags.CountryFlags.Default;
using DustInTheWind.Flags.CountryFlags.Demo.ViewModels;

namespace DustInTheWind.Flags.CountryFlags.Demo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Assembly countryFlagsAssembly = typeof(Countries).Assembly;
            Assembly defaultCountryFlagsAssembly = typeof(DefaultCountryFlagsModule).Assembly;
            FlagModules.LoadFrom(countryFlagsAssembly, defaultCountryFlagsAssembly);

            MainViewModel mainViewModel = new();
            MainWindow mainWindow = new(mainViewModel);
            mainWindow.Show();

            MainWindow = mainWindow;

            base.OnStartup(e);
        }
    }
}