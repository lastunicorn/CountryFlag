using System.Windows.Media;

namespace DustInTheWind.SvgToXaml.Tests.Utils;

public class SolidColorBrushComparer : IEqualityComparer<SolidColorBrush>
{
    public bool Equals(SolidColorBrush x, SolidColorBrush y)
    {
        return x.Color == y.Color && x.Opacity == y.Opacity;
    }

    public int GetHashCode(SolidColorBrush obj)
    {
        var o = new
        {
            C = obj.Color,
            O = obj.Opacity
        };

        return o.GetHashCode();
    }
}