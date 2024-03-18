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
using System.Windows.Controls;

namespace DustInTheWind.Flags.Core;

public class FlagBox : Control
{
    #region FlagRepository

    public static readonly DependencyProperty FlagRepositoryProperty = DependencyProperty.Register(
        nameof(FlagRepository),
        typeof(IFlagRepository),
        typeof(FlagBox),
        new PropertyMetadata(null, FlagRepositoryChangedCallback));

    private static void FlagRepositoryChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is FlagBox flagBox)
        {
            if (flagBox.CountryCode == null)
            {
                flagBox.FlagCanvas = EmptyFlagRepository.MissingFlag;
            }
            else
            {
                IFlagRepository flagRepository = e.NewValue as IFlagRepository
                                                 ?? FlagRepositories.Repository
                                                 ?? new EmptyFlagRepository();

                flagBox.FlagCanvas = flagRepository.Get(flagBox.CountryCode) ?? EmptyFlagRepository.MissingFlag;
            }
        }
    }

    public IFlagRepository? FlagRepository
    {
        get => (IFlagRepository)GetValue(FlagRepositoryProperty);
        set => SetValue(FlagRepositoryProperty, value);
    }

    #endregion

    #region CountryCode

    public static readonly DependencyProperty CountryCodeProperty = DependencyProperty.Register(
        nameof(CountryCode),
        typeof(string),
        typeof(FlagBox),
        new PropertyMetadata(null, CountryCodeChangedCallback)
    );

    private static void CountryCodeChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is FlagBox flagBox)
        {
            if (e.NewValue is string newCountryCode)
            {
                IFlagRepository flagRepository = flagBox.FlagRepository
                                                 ?? FlagRepositories.Repository
                                                 ?? new EmptyFlagRepository();

                flagBox.FlagCanvas = flagRepository.Get(newCountryCode) ?? EmptyFlagRepository.MissingFlag;
            }
            else
            {
                flagBox.FlagCanvas = EmptyFlagRepository.MissingFlag;
            }
        }
    }

    public string? CountryCode
    {
        get => (string)GetValue(CountryCodeProperty);
        set => SetValue(CountryCodeProperty, value);
    }

    #endregion

    #region FlagCanvas

    private static readonly DependencyPropertyKey FlagCanvasPropertyKey = DependencyProperty.RegisterReadOnly(
        nameof(FlagCanvas),
        typeof(Canvas),
        typeof(FlagBox),
        new FrameworkPropertyMetadata(null, flags: FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender)
    );

    public static readonly DependencyProperty FlagCanvasProperty = FlagCanvasPropertyKey.DependencyProperty;

    public Canvas? FlagCanvas
    {
        get => (Canvas)GetValue(FlagCanvasProperty);
        private set => SetValue(FlagCanvasPropertyKey, value);
    }

    #endregion

    #region CornerRadius

    public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.Register(
        nameof(CornerRadius),
        typeof(CornerRadius),
        typeof(FlagBox),
        new FrameworkPropertyMetadata(new CornerRadius(), FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender));

    public CornerRadius CornerRadius
    {
        get => (CornerRadius)GetValue(CornerRadiusProperty);
        set => SetValue(CornerRadiusProperty, value);
    }

    #endregion

    static FlagBox()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(FlagBox), new FrameworkPropertyMetadata(typeof(FlagBox)));
    }
}