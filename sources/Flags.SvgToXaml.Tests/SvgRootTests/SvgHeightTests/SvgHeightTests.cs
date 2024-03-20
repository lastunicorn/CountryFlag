// Country Flags
// Copyright (C) 2022-2023 Dust in the Wind
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
using DustInTheWind.SvgToXaml.ConversionExtensions;
using DustInTheWind.SvgToXaml.Svg;
using DustInTheWind.SvgToXaml.Tests.Utils;
using FluentAssertions;

namespace DustInTheWind.SvgToXaml.Tests.SvgRootTests.SvgHeightTests;

public class SvgHeightTests
{
    [Fact]
    public void HavingSvgHeightNotSet_WhenSvgIsParsed_ThenCanvasHasHeightNaN()
    {
        string svg = TestResources.ReadTextFile("svg-height-none.svg");
        SvgDocument svgDocument = SvgDocument.Parse(svg);

        StaEnvironment.Run(() =>
        {
            Canvas canvas = svgDocument.Content.ToXaml();
            canvas.Height.Should().Be(double.NaN);
        });
    }

    [Fact]
    public void HavingSvgHeightSetToZero_WhenSvgIsParsed_ThenCanvasHasHeightZero()
    {
        string svg = TestResources.ReadTextFile("svg-height-zero.svg");
        SvgDocument svgDocument = SvgDocument.Parse(svg);

        StaEnvironment.Run(() =>
        {
            Canvas canvas = svgDocument.Content.ToXaml();
            canvas.Height.Should().Be(0);
        });
    }

    [Fact]
    public void HavingSvgHeightSetToPositiveValue_WhenSvgIsParsed_ThenCanvasHasHeightSpecified()
    {
        string svg = TestResources.ReadTextFile("svg-height-positive-value.svg");
        SvgDocument svgDocument = SvgDocument.Parse(svg);

        StaEnvironment.Run(() =>
        {
            Canvas canvas = svgDocument.Content.ToXaml();
            canvas.Height.Should().Be(142);
        });
    }

    [Fact]
    public void HavingSvgHeightSetToNegativeValue_WhenSvgIsParsed_ThenThrows()
    {
        string svg = TestResources.ReadTextFile("svg-height-negative-value.svg");
        SvgDocument svgDocument = SvgDocument.Parse(svg);

        Assert.ThrowsAny<Exception>(() =>
        {
            StaEnvironment.Run(() =>
            {
                Canvas canvas = svgDocument.Content.ToXaml();
                canvas.Height.Should().Be(142);
            });
        });
    }
}