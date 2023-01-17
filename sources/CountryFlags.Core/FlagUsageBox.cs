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

namespace DustInTheWind.CountryFlags;

public class FlagUsageBox : Control
{
    #region Value

    public static readonly DependencyProperty ValueProperty = DependencyProperty.Register(
        nameof(Value),
        typeof(FlagUsage),
        typeof(FlagUsageBox),
        new PropertyMetadata(FlagUsage.None, ValuePropertyChanged));

    private static void ValuePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is FlagUsageBox flagUsageBox)
        {
            if (e.NewValue is FlagUsage flagUsage)
            {
                flagUsageBox.IsCivilFlag = (flagUsage & FlagUsage.CivilFlag) != 0;
                flagUsageBox.IsStateFlag = (flagUsage & FlagUsage.StateFlag) != 0;
                flagUsageBox.IsWarFlag = (flagUsage & FlagUsage.WarFlag) != 0;
                flagUsageBox.IsCivilEnsign = (flagUsage & FlagUsage.CivilEnsign) != 0;
                flagUsageBox.IsStateEnsign = (flagUsage & FlagUsage.StateEnsign) != 0;
                flagUsageBox.IsWarEnsign = (flagUsage & FlagUsage.WarEnsign) != 0;
            }
        }
    }

    public FlagUsage Value
    {
        get => (FlagUsage)GetValue(ValueProperty);
        set => SetValue(ValueProperty, value);
    }

    #endregion

    #region IsCivilFlag

    private static readonly DependencyPropertyKey IsCivilFlagPropertyKey = DependencyProperty.RegisterReadOnly(
        nameof(IsCivilFlag),
        typeof(bool),
        typeof(FlagUsageBox),
        new FrameworkPropertyMetadata(false, flags: FrameworkPropertyMetadataOptions.AffectsRender)
    );

    public static readonly DependencyProperty IsCivilFlagProperty = IsCivilFlagPropertyKey.DependencyProperty;

    public bool? IsCivilFlag
    {
        get => (bool)GetValue(IsCivilFlagProperty);
        private set => SetValue(IsCivilFlagPropertyKey, value);
    }

    #endregion

    #region IsStateFlag

    private static readonly DependencyPropertyKey IsStateFlagPropertyKey = DependencyProperty.RegisterReadOnly(
        nameof(IsStateFlag),
        typeof(bool),
        typeof(FlagUsageBox),
        new FrameworkPropertyMetadata(false, flags: FrameworkPropertyMetadataOptions.AffectsRender)
    );

    public static readonly DependencyProperty IsStateFlagProperty = IsStateFlagPropertyKey.DependencyProperty;

    public bool? IsStateFlag
    {
        get => (bool)GetValue(IsStateFlagProperty);
        private set => SetValue(IsStateFlagPropertyKey, value);
    }

    #endregion

    #region IsWarFlag

    private static readonly DependencyPropertyKey IsWarFlagPropertyKey = DependencyProperty.RegisterReadOnly(
        nameof(IsWarFlag),
        typeof(bool),
        typeof(FlagUsageBox),
        new FrameworkPropertyMetadata(false, flags: FrameworkPropertyMetadataOptions.AffectsRender)
    );

    public static readonly DependencyProperty IsWarFlagProperty = IsWarFlagPropertyKey.DependencyProperty;

    public bool? IsWarFlag
    {
        get => (bool)GetValue(IsWarFlagProperty);
        private set => SetValue(IsWarFlagPropertyKey, value);
    }

    #endregion

    #region IsCivilEnsign

    private static readonly DependencyPropertyKey IsCivilEnsignPropertyKey = DependencyProperty.RegisterReadOnly(
        nameof(IsCivilEnsign),
        typeof(bool),
        typeof(FlagUsageBox),
        new FrameworkPropertyMetadata(false, flags: FrameworkPropertyMetadataOptions.AffectsRender)
    );

    public static readonly DependencyProperty IsCivilEnsignProperty = IsCivilEnsignPropertyKey.DependencyProperty;

    public bool? IsCivilEnsign
    {
        get => (bool)GetValue(IsCivilEnsignProperty);
        private set => SetValue(IsCivilEnsignPropertyKey, value);
    }

    #endregion

    #region IsStateEnsign

    private static readonly DependencyPropertyKey IsStateEnsignPropertyKey = DependencyProperty.RegisterReadOnly(
        nameof(IsStateEnsign),
        typeof(bool),
        typeof(FlagUsageBox),
        new FrameworkPropertyMetadata(false, flags: FrameworkPropertyMetadataOptions.AffectsRender)
    );

    public static readonly DependencyProperty IsStateEnsignProperty = IsStateEnsignPropertyKey.DependencyProperty;

    public bool? IsStateEnsign
    {
        get => (bool)GetValue(IsStateEnsignProperty);
        private set => SetValue(IsStateEnsignPropertyKey, value);
    }

    #endregion

    #region IsWarEnsign

    private static readonly DependencyPropertyKey IsWarEnsignPropertyKey = DependencyProperty.RegisterReadOnly(
        nameof(IsWarEnsign),
        typeof(bool),
        typeof(FlagUsageBox),
        new FrameworkPropertyMetadata(false, flags: FrameworkPropertyMetadataOptions.AffectsRender)
    );

    public static readonly DependencyProperty IsWarEnsignProperty = IsWarEnsignPropertyKey.DependencyProperty;

    public bool? IsWarEnsign
    {
        get => (bool)GetValue(IsWarEnsignProperty);
        private set => SetValue(IsWarEnsignPropertyKey, value);
    }

    #endregion


    static FlagUsageBox()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(FlagUsageBox), new FrameworkPropertyMetadata(typeof(FlagUsageBox)));
    }
}