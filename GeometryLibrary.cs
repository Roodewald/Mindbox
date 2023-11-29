using System;

namespace GeometryLibrary
{
    public interface IShape
    {
        double GetArea();
    }

    public class Circle : IShape
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * _radius * _radius;
        }
    }

    public class Triangle : IShape
    {
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public double GetArea()
        {
            double semiPerimeter = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - _sideA) * (semiPerimeter - _sideB) * (semiPerimeter - _sideC));
        }

        public bool IsRightAngled()
        {
            double[] sides = {_sideA, _sideB, _sideC};
            Array.Sort(sides);

            return sides[2] * sides[2] == sides[0] * sides[0] + sides[1] * sides[1];
        }
    }
}
