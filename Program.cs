using System;

namespace BridgePattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IUnitConvertor defaultUnitConvertor = new DefaultUnitConvertor();

            Shape triangleCm = new Triangle(2, 3, defaultUnitConvertor);
            Console.WriteLine(triangleCm.CalculateArea());

            Shape squareCm = new Square(4, defaultUnitConvertor);
            Console.WriteLine(squareCm.CalculateArea());

            Shape circleCm = new Circle(3, defaultUnitConvertor);
            Console.WriteLine(circleCm.CalculateArea());

            IUnitConvertor InchesUnitConvertor = new InchesUnitConvertor();

            Shape triangleInc = new Triangle(2, 3, InchesUnitConvertor);
            Console.WriteLine(triangleInc.CalculateArea());

            Shape squareInc = new Square(4, InchesUnitConvertor);
            Console.WriteLine(squareInc.CalculateArea());

            Shape circleInc = new Circle(3, InchesUnitConvertor);
            Console.WriteLine(circleInc.CalculateArea());

            Console.Read();
        }
    }
}
