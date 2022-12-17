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

using System.IO;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Xml;
using System.Xml.Serialization;
using Flags.SvgToXaml.SvgModel;
using Path = System.Windows.Shapes.Path;

namespace Flags.SvgToXaml;

public class MainViewModel : ViewModelBase
{
    private string? svgText;
    private string? xamlText;

    public string? SvgText
    {
        get => svgText;
        set
        {
            svgText = value;
            OnPropertyChanged();

            TransformSvgToXaml();
        }
    }

    public string? XamlText
    {
        get => xamlText;
        set
        {
            xamlText = value;
            OnPropertyChanged();
        }
    }

    private void TransformSvgToXaml()
    {
        if (string.IsNullOrEmpty(svgText))
        {
            XamlText = null;
            return;
        }

        StringReader sr = new(svgText);

        XmlSerializer xmlSerializer = new(typeof(Svg));

        Svg? svg = (Svg?)xmlSerializer.Deserialize(sr);

        Canvas canvas = new();

        foreach (object svgElement in svg.Elements)
        {
            if (svgElement is SvgCircle svgCircle)
            {
                Ellipse ellipse = svgCircle.ToXaml();
                canvas.Children.Add(ellipse);
            }
            else if (svgElement is SvgEllipse svgEllipse)
            {
                Ellipse ellipse = svgEllipse.ToXaml();
                canvas.Children.Add(ellipse);
            }
            else if (svgElement is SvgPath svgPath)
            {
                Path xamlPath = svgPath.ToXaml();
                canvas.Children.Add(xamlPath);
            }
            else if (svgElement is SvgRect svgRect)
            {
                Rectangle xamlRectangle = svgRect.ToXaml();
                canvas.Children.Add(xamlRectangle);
            }
        }

        XamlText = Serialize(canvas);
    }

    private static string Serialize(Canvas canvas)
    {
        using MemoryStream ms = new();
        XmlWriterSettings xmlWriterSettings = new()
        {
            Indent = true,
            NewLineOnAttributes = true
        };
        XmlWriter xmlWriter = XmlWriter.Create(ms, xmlWriterSettings);

        System.Windows.Markup.XamlWriter.Save(canvas, xmlWriter);

        ms.Position = 0;
        using StreamReader sr = new(ms);

        return sr.ReadToEnd();
    }
}