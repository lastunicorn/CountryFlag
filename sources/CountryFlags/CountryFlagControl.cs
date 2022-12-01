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

using System;
using System.Windows;
using System.Windows.Controls;

namespace DustInTheWind.CountryFlags
{
    public class CountryFlagControl : Control
    {
        #region CountryCode

        public static readonly DependencyProperty CountryCodeProperty = DependencyProperty.Register(
            nameof(CountryCode),
            typeof(string),
            typeof(CountryFlagControl),
            new PropertyMetadata(null, CountryCodeChangedCallback)
        );

        private static void CountryCodeChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is CountryFlagControl countryFlagControl)
            {
                if (e.NewValue is string newCountryCode)
                {
                    string newCountryCodeUpperCase = newCountryCode.ToUpper();

                    Uri resourceUri = new($"Pack://application:,,,/DustInTheWind.CountryFlags;component/Flags/{newCountryCodeUpperCase}.xaml");
                    string resourceName = "CountryFlag_" + newCountryCodeUpperCase;

                    try
                    {
                        ResourceDictionary resourceDictionary = new()
                        {
                            Source = resourceUri
                        };

                        object resource = resourceDictionary[resourceName];
                        countryFlagControl.FlagCanvas = resource as Canvas;
                    }
                    catch
                    {
                        countryFlagControl.FlagCanvas = null;
                    }
                }
                else
                {
                    countryFlagControl.FlagCanvas = null;
                }
            }
        }

        public string CountryCode
        {
            get => (string)GetValue(CountryCodeProperty);
            set => SetValue(CountryCodeProperty, value);
        }

        #endregion

        #region FlagCanvas

        private static readonly DependencyPropertyKey FlagCanvasPropertyKey = DependencyProperty.RegisterReadOnly(
            nameof(FlagCanvas),
            typeof(Canvas),
            typeof(CountryFlagControl),
            new FrameworkPropertyMetadata(null, flags: FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender)
        );

        public static readonly DependencyProperty FlagCanvasProperty = FlagCanvasPropertyKey.DependencyProperty;

        public Canvas? FlagCanvas
        {
            get => (Canvas)GetValue(FlagCanvasProperty);
            private set => SetValue(FlagCanvasPropertyKey, value);
        }

        #endregion

        static CountryFlagControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CountryFlagControl), new FrameworkPropertyMetadata(typeof(CountryFlagControl)));
        }
    }
}