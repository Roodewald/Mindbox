using GeometryLibrary;

namespace GeometryLibrary.Tests
{
    class Program
    {
        static void Main(){
            Triangle triangle = new Triangle(3, 4, 5);
            Console.WriteLine(triangle.GetArea());
            Console.WriteLine(triangle.IsRightAngled()? "Прямоугольный": "Не прямогуольный");
            Console.WriteLine("=================\n");

            Circle circle = new Circle(10);
            Console.WriteLine($"{circle.GetArea()}");
        }
    }
}
