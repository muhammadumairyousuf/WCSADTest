using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace TestApp.Models
{
    public class CircleShape : ShapeBase
    {
        private readonly Point _center;
        private readonly double _radius;
        private readonly Color _color;
        private readonly bool _filled;

        public CircleShape(string center, double radius, bool filled, string color)
        {
            _center = SetPoint(center);
            _radius = radius;
            _color = SetColor(color);
            _filled = filled;
        }

        public override Shape Draw()
        {
            Ellipse ellipse = new Ellipse
            {
                Width = _radius * 2,
                Height = _radius * 2,
                Stroke = new SolidColorBrush(_color),
                StrokeThickness = 1
            };

            if (_filled)
            {
                ellipse.Fill = new SolidColorBrush(_color);
            }

            Canvas.SetLeft(ellipse, _center.X - _radius);
            Canvas.SetTop(ellipse, _center.Y - _radius);

            return ellipse;
        }
    }
}
