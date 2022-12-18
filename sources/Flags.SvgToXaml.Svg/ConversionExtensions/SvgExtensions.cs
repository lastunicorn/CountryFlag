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

using DustInTheWind.Flags.SvgToXaml.Svg.Serialization;
using Path = DustInTheWind.Flags.SvgToXaml.Svg.Serialization.Path;

namespace DustInTheWind.Flags.SvgToXaml.Svg.ConversionExtensions;

internal static class SvgExtensions
{
    public static Svg? ToEntity(this Serialization.Svg? serializationSvg)
    {
        if (serializationSvg == null)
            return null;

        Svg entity = new();
        entity.Width = serializationSvg.Width;
        entity.Height = serializationSvg.Height;

        entity.Fill = serializationSvg.Fill;
        entity.Stroke = serializationSvg.Stroke;

        if (serializationSvg.Children != null && serializationSvg.Children.Any())
        {
            entity.Children = new List<SvgElement>();

            foreach (object svgObjectChild in serializationSvg.Children)
            {
                if (svgObjectChild is Circle serializationCircle)
                {
                    SvgCircle circle = serializationCircle.ToEntity(entity);
                    entity.Children.Add(circle);
                }
                else if (svgObjectChild is Ellipse serializationEllipse)
                {
                    SvgEllipse ellipse = serializationEllipse.ToEntity(entity);
                    entity.Children.Add(ellipse);
                }
                else if (svgObjectChild is Path serializationPath)
                {
                    SvgPath path = serializationPath.ToEntity(entity);
                    entity.Children.Add(path);
                }
                else if (svgObjectChild is Rect serializationRect)
                {
                    SvgRectangle rectangle = serializationRect.ToEntity(entity);
                    entity.Children.Add(rectangle);
                }
                else if (svgObjectChild is G serializationG)
                {
                    SvgGroup? g = serializationG.ToEntity(entity);

                    if (g != null)
                        entity.Children.Add(g);
                }
            }
        }

        return entity;
    }
}