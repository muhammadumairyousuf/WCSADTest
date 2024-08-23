using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace TestApp.Models
{
    public class TriangleShape : ShapeBase
    {
        private readonly Point _a;
        private readonly Point _b;
        private readonly Point _c;
        private readonly Color _color;
        private readonly bool _filled;

        public TriangleShape(string a, string b, string c, bool filled, string color)
        {
            _a = SetPoint(a);
            _b = SetPoint(b);
            _c = SetPoint(c);
            _color = SetColor(color);
            _filled = filled;
        }

        public override Shape Draw()
        {
            Polygon triangle = new Polygon
            {
                Points = new PointCollection { _a, _b, _c },
                Stroke = new SolidColorBrush(_color),
                StrokeThickness = 1
            };

            if (_filled)
            {
                triangle.Fill = new SolidColorBrush(_color);
            }

            return triangle;
        }
    }
}
