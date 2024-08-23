using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Models;

namespace TestApp
{
    public static class ShapeFactory
    {
        public static ShapeBase CreateShape(dynamic shapeData)
        {
            switch ((string)shapeData.type)
            {
                case "line":
                    return new LineShape((string)shapeData.a, (string)shapeData.b, (string)shapeData.color);
                case "triangle":
                    return new TriangleShape((string)shapeData.a, (string)shapeData.b, (string)shapeData.c, (bool)shapeData.filled, (string)shapeData.color);
                case "circle":
                    return new CircleShape((string)shapeData.center, (double)shapeData.radius, (bool)shapeData.filled, (string)shapeData.color);
                default:
                    throw new NotSupportedException("Shape type not supported");
            }
        }
    }
}
