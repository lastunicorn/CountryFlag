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
using System.Windows.Shapes;
using DustInTheWind.SvgToXaml.Tests.Utils;
using FluentAssertions;

namespace DustInTheWind.SvgToXaml.Tests.UseTests;

public class UseReferenceCircleFromDefsTests : SvgFileTestsBase
{
    [Fact]
    public void HavingUseReferencingCircleFromDefs_WhenSvgIsParsed_ThenEllipseIsCreated()
    {
        TestConvertSvgFile("use-references-defs-circle.svg", canvas =>
        {
            canvas.AssertChildren(typeof(Ellipse));
        });
    }

    [Fact]
    public void HavingUseReferencingGroupFromDefsContainingCircle_WhenSvgIsParsed_ThenOneCanvasContainingEllipseIsCreated()
    {
        TestConvertSvgFile("use-references-defs-group-circle.svg", canvas =>
        {
            canvas.Children.Count.Should().Be(1);
            Canvas canvas2 = canvas.GetElementByIndex<Canvas>(0);

            canvas2.Children.Count.Should().Be(1);
            Ellipse ellipse = canvas2.GetElementByIndex<Ellipse>(0);

            ellipse.Should().NotBeNull();
        });
    }
}