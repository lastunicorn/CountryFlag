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

using System.Windows.Controls;
using DustInTheWind.SvgToXaml.Conversion;
using DustInTheWind.SvgToXaml.Svg;
using DustInTheWind.SvgToXaml.Tests.Utils;
using FluentAssertions;

namespace DustInTheWind.SvgToXaml.Tests.Conversion.SvgRootTests.SvgWidthTests;

public class SvgWidthTests : SvgFileTestsBase
{
    [Fact]
    public void HavingSvgWidthNotSet_WhenSvgIsParsed_ThenCanvasHasWidthNaN()
    {
        TestConvertSvgFile("svg-width-none.svg", canvas =>
        {
            canvas.Width.Should().Be(double.NaN);
        });
    }

    [Fact]
    public void HavingSvgWidthSetToZero_WhenSvgIsParsed_ThenCanvasHasWidthZero()
    {
        TestConvertSvgFile("svg-width-zero.svg", canvas =>
        {
            canvas.Width.Should().Be(0);
        });
    }

    [Fact]
    public void HavingSvgWidthSetToPositiveValue_WhenSvgIsParsed_ThenCanvasHasWidthSpecified()
    {
        TestConvertSvgFile("svg-width-positive-value.svg", canvas =>
        {
            canvas.Width.Should().Be(142);
        });
    }

    [Fact]
    public void HavingSvgWidthSetToNegativeValue_WhenSvgIsParsed_ThenThrows()
    {
        string svg = TestResources.ReadTextFile("svg-width-negative-value.svg", GetType());
        SvgDocument svgDocument = SvgDocument.Parse(svg);

        Assert.ThrowsAny<Exception>(() =>
        {
            StaEnvironment.Run(() =>
            {
                Canvas canvas = svgDocument.Content.ToXaml();
                canvas.Width.Should().Be(142);
            });
        });
    }
}