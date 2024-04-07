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

using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DustInTheWind.CountryFlags.Demo;

public static class TreeViewItemExtensions
{
    public static int GetDepth(this TreeViewItem item)
    {
        while (GetParent(item) is { } parent)
            return GetDepth(parent) + 1;

        return 0;
    }

    private static TreeViewItem GetParent(TreeViewItem item)
    {
        DependencyObject parent = VisualTreeHelper.GetParent(item);
        
        while (parent is not (TreeViewItem or TreeView)) 
            parent = VisualTreeHelper.GetParent(parent);

        return parent as TreeViewItem;
    }
}