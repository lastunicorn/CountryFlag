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

using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace DustInTheWind.CountryFlags.Demo;

/// <remarks>
/// The inspiration come from this post: https://stackoverflow.com/questions/741956/pan-zoom-image
/// </remarks>
public class ZoomBorder : Border
{
    private ScaleTransform childScaleTransform;
    private TranslateTransform childTranslateTransform;
    private Point origin;
    private Point start;

    public override UIElement Child
    {
        get => base.Child;
        set
        {
            if (Child != null)
                UninitializeChild();

            base.Child = value;

            if (Child != null)
                InitializeChild();
        }
    }

    private void InitializeChild()
    {
        TransformGroup transformGroup = new();

        childScaleTransform = new ScaleTransform();
        transformGroup.Children.Add(childScaleTransform);

        childTranslateTransform = new TranslateTransform();
        transformGroup.Children.Add(childTranslateTransform);

        Child.RenderTransform = transformGroup;
        Child.RenderTransformOrigin = new Point(0.0, 0.0);
    }

    private void UninitializeChild()
    {
        Child.RenderTransform = null;
    }

    protected override void OnMouseWheel(MouseWheelEventArgs e)
    {
        if (Child != null)
        {
            if (!(e.Delta > 0) && (childScaleTransform.ScaleX < .4 || childScaleTransform.ScaleY < .4))
                return;

            Point relative = e.GetPosition(Child);

            double absoluteX = relative.X * childScaleTransform.ScaleX + childTranslateTransform.X;
            double absoluteY = relative.Y * childScaleTransform.ScaleY + childTranslateTransform.Y;

            double zoom = e.Delta > 0 ? .2 : -.2;

            childScaleTransform.ScaleX += zoom;
            childScaleTransform.ScaleY += zoom;

            childTranslateTransform.X = absoluteX - relative.X * childScaleTransform.ScaleX;
            childTranslateTransform.Y = absoluteY - relative.Y * childScaleTransform.ScaleY;
        }

        base.OnMouseWheel(e);
    }

    protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
    {
        if (Child != null)
        {
            start = e.GetPosition(this);
            origin = new Point(childTranslateTransform.X, childTranslateTransform.Y);
            Cursor = Cursors.Hand;
            Child.CaptureMouse();
        }

        base.OnMouseLeftButtonDown(e);
    }

    protected override void OnMouseLeftButtonUp(MouseButtonEventArgs e)
    {
        if (Child != null)
        {
            Child.ReleaseMouseCapture();
            Cursor = Cursors.Arrow;
        }

        base.OnMouseLeftButtonUp(e);
    }

    protected override void OnPreviewMouseRightButtonDown(MouseButtonEventArgs e)
    {
        if (Child != null)
        {
            // reset zoom
            childScaleTransform.ScaleX = 1.0;
            childScaleTransform.ScaleY = 1.0;

            // reset pan
            childTranslateTransform.X = 0.0;
            childTranslateTransform.Y = 0.0;
        }

        base.OnPreviewMouseRightButtonDown(e);
    }

    protected override void OnMouseMove(MouseEventArgs e)
    {
        if (Child != null && Child.IsMouseCaptured)
        {
            Vector v = start - e.GetPosition(this);
            childTranslateTransform.X = origin.X - v.X;
            childTranslateTransform.Y = origin.Y - v.Y;
        }

        base.OnMouseMove(e);
    }
}