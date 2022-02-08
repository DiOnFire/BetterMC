using System.Windows.Media;

namespace BetterMC.Frontend.Util
{
    public sealed class GlobalColors
    {
        public static readonly SolidColorBrush EMPTY = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
        public static readonly SolidColorBrush GRAY = new SolidColorBrush(Color.FromRgb(40, 40, 40));
        public static readonly SolidColorBrush LIGHT_GRAY = new SolidColorBrush(Color.FromRgb(50, 50, 50));
    }
}
