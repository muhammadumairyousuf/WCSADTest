using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace TestApp.Models
{
    public abstract class ShapeBase
    {
        public abstract Shape Draw();
        public Color SetColor(string colorStr)
        {
            var components = colorStr.Split(';');
            return Color.FromArgb(
                byte.Parse(components[0]),
                byte.Parse(components[1]),
                byte.Parse(components[2]),
                byte.Parse(components[3]));
        }
        public Point SetPoint(string pointStr)
        {
            var coordinates = pointStr.Split(';');
            return new Point(double.Parse(coordinates[0]), double.Parse(coordinates[1]));
        }
    }
}
