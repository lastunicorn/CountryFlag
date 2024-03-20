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

using System.Windows.Controls;
using System.Windows.Media;
using DustInTheWind.SvgToXaml.Svg;

namespace DustInTheWind.SvgToXaml.ConversionExtensions;

internal static class SvgExtensions
{
    public static Canvas? ToXaml(this Svg.Svg? svg)
    {
        if (svg == null)
            return null;

        Canvas? canvas = ((SvgGroup)svg).ToXaml();

        if (canvas == null)
            return null;

        if (svg.ViewBox == null)
        {
            if (svg.Width != null)
                canvas.Width = svg.Width.Value;

            if (svg.Height != null)
                canvas.Height = svg.Height.Value;
        }
        else
        {
            canvas.Width = svg.ViewBox.Width.Value;
            canvas.Height = svg.ViewBox.Height.Value;

            bool viewBoxIsTranslated = svg.ViewBox.OriginX is { Value: not 0 } ||
                                       svg.ViewBox.OriginY is { Value: not 0 };

            if (viewBoxIsTranslated) 
                canvas.RenderTransform = CreateRenderTransform(svg);
        }

        return canvas;
    }

    private static TranslateTransform CreateRenderTransform(Svg.Svg svg)
    {
        TranslateTransform canvasRenderTransform = new();

        if (svg.ViewBox.OriginX != null && svg.ViewBox.OriginX.Value != 0)
            canvasRenderTransform.X = -svg.ViewBox.OriginX.Value;

        if (svg.ViewBox.OriginY != null && svg.ViewBox.OriginY.Value != 0)
            canvasRenderTransform.Y = -svg.ViewBox.OriginY.Value;

        return canvasRenderTransform;
    }
}