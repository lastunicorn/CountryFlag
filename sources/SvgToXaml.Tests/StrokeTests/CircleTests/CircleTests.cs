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

using System.Windows.Media;
using System.Windows.Shapes;
using DustInTheWind.SvgToXaml.Tests.Utils;
using FluentAssertions;

namespace DustInTheWind.SvgToXaml.Tests.StrokeTests.CircleTests;

public class CircleTests : SvgFileTestsBase
{
    [Fact]
    public void HavingNoStrokeDeclaredOnCircle_WhenSvgIsParsed_ThenResultedEllipseHasStrokeNull()
    {
        TestConvertSvgFile("stroke-circle.svg", canvas =>
        {
            Ellipse ellipse = canvas.GetElementByIndex<Ellipse>(0);

            ellipse.Stroke.Should().BeNull();
        });
    }

    [Fact]
    public void HavingStrokeDeclaredOnCircle_WhenSvgIsParsed_ThenResultedEllipseHasStrokeColorFromCircle()
    {
        TestConvertSvgFile("stroke-circle^.svg", canvas =>
        {
            Ellipse ellipse = canvas.GetElementByIndex<Ellipse>(0);

            Color expectedColor = Color.FromArgb(0xff, 0x11, 0x22, 0x33);
            SolidColorBrush expectedBrush = new(expectedColor);
            ellipse.Stroke.Should().Be(expectedBrush, new SolidColorBrushComparer());
        });
    }

    [Fact]
    public void HavingStrokeDeclaredOnSvgRootContainingCircle_WhenSvgIsParsed_ThenResultedEllipseHasStrokeColorFromSvgRoot()
    {
        TestConvertSvgFile("stroke-circle-svgroot^.svg", canvas =>
        {
            Ellipse ellipse = canvas.GetElementByIndex<Ellipse>(0);

            Color expectedColor = Color.FromArgb(0xff, 0xaa, 0xbb, 0xcc);
            SolidColorBrush expectedBrush = new(expectedColor);
            ellipse.Stroke.Should().Be(expectedBrush, new SolidColorBrushComparer());
        });
    }

    [Fact]
    public void HavingStrokeDeclaredOnBothSvgRootAndOnCircle_WhenSvgIsParsed_ThenResultedEllipseHasStrokeColorFromCircle()
    {
        TestConvertSvgFile("stroke-circle^-svgroot^.svg", canvas =>
        {
            Ellipse ellipse = canvas.GetElementByIndex<Ellipse>(0);

            Color expectedColor = Color.FromArgb(0xff, 0x11, 0x22, 0x33);
            SolidColorBrush expectedBrush = new(expectedColor);
            ellipse.Stroke.Should().Be(expectedBrush, new SolidColorBrushComparer());
        });
    }
}