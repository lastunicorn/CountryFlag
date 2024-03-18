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

using System.Windows;
using DustInTheWind.CountryFlags.DefaultFlags;
using DustInTheWind.CountryFlags.Demo.ViewModels;
using DustInTheWind.CountryFlags.Demo.Views;
using DustInTheWind.CountryFlags.InUseFlags;
using DustInTheWind.Flags.Core;

namespace DustInTheWind.CountryFlags.Demo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            FlagsSetup.LoadModule(typeof(DefaultFlagsModule));
            FlagsSetup.LoadModule(typeof(InUseFlagsModule));

            MainViewModel mainViewModel = new();
            MainWindow mainWindow = new(mainViewModel);
            mainWindow.Show();

            MainWindow = mainWindow;

            base.OnStartup(e);
        }
    }
}