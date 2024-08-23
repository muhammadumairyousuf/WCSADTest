using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace TestApp.Models
{
    public class LineShape : ShapeBase
    {
        private readonly Point _a;
        private readonly Point _b;
        private readonly Color _color;

        public LineShape(string a, string b, string color)
        {
            _a = SetPoint(a);
            _b = SetPoint(b);
            _color = SetColor(color);
        }

        public override Shape Draw()
        {
            Line line = new Line
            {
                X1 = _a.X,
                Y1 = _a.Y,
                X2 = _b.X,
                Y2 = _b.Y,
                Stroke = new SolidColorBrush(_color),
                StrokeThickness = 1
            };

            return line;
        }
    }
}
