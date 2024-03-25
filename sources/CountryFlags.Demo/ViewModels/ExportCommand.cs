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

using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using DustInTheWind.CountryFlags.Demo.Views;
using DustInTheWind.Flags.Core;

namespace DustInTheWind.CountryFlags.Demo.ViewModels;

public class ExportCommand : ICommand
{
    private readonly CountryFlag countryFlag;

    public ExportCommand(CountryFlag countryFlag)
    {
        this.countryFlag = countryFlag;
    }

    public event EventHandler CanExecuteChanged;

    public bool CanExecute(object parameter)
    {
        return countryFlag != null;
    }

    public void Execute(object parameter)
    {
        if (countryFlag == null)
            return;

        Canvas canvas = FlagRepositories.Repository.Get(countryFlag.FullId);

        RenderWindow window = new();

        ContentPresenter contentPresenter = new()
        {
            Content = canvas
        };

        Viewbox viewbox = new()
        {
            Stretch = Stretch.Uniform,
            Width = 1000,
            Height = 1000,
            Child = contentPresenter
        };

        window.Content = viewbox;

        window.Show();

        Rect bounds = new(new Point(), viewbox.RenderSize);
        double dpi = 96d;

        DrawingVisual drawingVisual = new();
        using (DrawingContext dc = drawingVisual.RenderOpen())
        {
            VisualBrush visualBrush = new(canvas);
            dc.DrawRectangle(visualBrush, null, bounds);
        }

        RenderTargetBitmap renderTargetBitmap = new((int)bounds.Width, (int)bounds.Height, dpi, dpi, PixelFormats.Default);

        renderTargetBitmap.Render(drawingVisual);

        BitmapEncoder bitmapEncoder = new PngBitmapEncoder();
        BitmapFrame bitmapFrame = BitmapFrame.Create(renderTargetBitmap);
        bitmapEncoder.Frames.Add(bitmapFrame);

        string fileName = GetFileNameFor(countryFlag);
        using FileStream fs = File.OpenWrite(fileName);
        bitmapEncoder.Save(fs);

        window.Close();
    }


    private static string GetFileNameFor(CountryFlag countryFlag)
    {
        StringBuilder sb = new();

        if (countryFlag.Country != null)
            sb.Append(countryFlag.Country.IsoCodeAlpha2);

        if (countryFlag.Id != null)
        {
            if (sb.Length > 0)
                sb.Append('-');

            sb.Append(countryFlag.Id);
        }

        sb.Append("-flag.png");

        return sb.ToString();
    }
}