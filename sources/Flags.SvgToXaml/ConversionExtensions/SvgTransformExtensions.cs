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
using System.Windows.Media;
using DustInTheWind.Flags.SvgToXaml.Svg;

namespace DustInTheWind.Flags.SvgToXaml.ConversionExtensions;

internal static class SvgTransformExtensions
{
    public static Transform? ToXaml(this SvgTransformList svgTransformList)
    {
        switch (svgTransformList.Count)
        {
            case 1:
                return svgTransformList[0].ToXaml();

            case > 1:
            {
                TransformGroup transformGroup = new();

                for (int i = svgTransformList.Count - 1; i >= 0; i--)
                {
                    ISvgTransform svgTransform = svgTransformList[i];
                    
                    Transform transform = svgTransform.ToXaml();
                    transformGroup.Children.Add(transform);
                }

                return transformGroup;
            }

            default:
                return null;
        }
    }

    public static Transform ToXaml(this ISvgTransform svgTransform)
    {
        switch (svgTransform)
        {
            case SvgTranslateTransform svgTranslateTransform:
                return new TranslateTransform
                {
                    X = svgTranslateTransform.X,
                    Y = svgTranslateTransform.Y
                };

            case SvgScaleTransform svgScaleTransform:
                return new ScaleTransform
                {
                    CenterX = svgScaleTransform.CenterX,
                    CenterY = svgScaleTransform.CenterY,
                    ScaleX = svgScaleTransform.ScaleX,
                    ScaleY = svgScaleTransform.ScaleY
                };

            case SvgRotateTransform svgRotateTransform:
                return new RotateTransform
                {
                    Angle = svgRotateTransform.Angle,
                    CenterX = svgRotateTransform.CenterX,
                    CenterY = svgRotateTransform.CenterY
                };

            default:
                throw new ArgumentException("Unrecognized transformation object.", nameof(svgTransform));
        }
    }
}