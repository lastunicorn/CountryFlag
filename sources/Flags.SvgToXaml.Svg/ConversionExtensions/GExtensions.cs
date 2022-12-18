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

internal static class GExtensions
{
    public static SvgGroup? ToEntity(this G? serializationG, SvgGroup? parent = null)
    {
        if (serializationG == null)
            return null;

        SvgGroup entityGroup = new();

        entityGroup.Fill = serializationG.Fill;
        entityGroup.Stroke = serializationG.Stroke;
        entityGroup.Parent = parent;

        if (serializationG.Children != null && serializationG.Children.Any())
        {
            entityGroup.Children = new List<SvgElement>();

            foreach (object serializationChild in serializationG.Children)
            {
                if (serializationChild is Circle serializationCircle)
                {
                    SvgCircle circle = serializationCircle.ToEntity(entityGroup);
                    entityGroup.Children.Add(circle);
                }
                else if (serializationChild is Ellipse serializationEllipse)
                {
                    SvgEllipse ellipse = serializationEllipse.ToEntity(entityGroup);
                    entityGroup.Children.Add(ellipse);
                }
                else if (serializationChild is Path serializationPath)
                {
                    SvgPath path = serializationPath.ToEntity(entityGroup);
                    entityGroup.Children.Add(path);
                }
                else if (serializationChild is Rect serializationRect)
                {
                    SvgRectangle rectangle = serializationRect.ToEntity(entityGroup);
                    entityGroup.Children.Add(rectangle);
                }
                else if (serializationChild is G serializationGChild)
                {
                    SvgGroup? svgGroupChild = serializationGChild.ToEntity(entityGroup);

                    if (svgGroupChild != null)
                        entityGroup.Children.Add(svgGroupChild);
                }
            }
        }

        return entityGroup;
    }
}