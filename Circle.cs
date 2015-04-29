using System;

namespace BridgePattern
{
    public class Circle : Shape
    {
        public int RadiusCm { get; set; }
        private const double Inch = 2.54;

        public Circle(int radius, IUnitConvertor unitConvertor) : base(unitConvertor)
        {
            RadiusCm = radius;
        }

        public override double CalculateArea()
        {
            return UnitConvertor.Convert(RadiusCm) * UnitConvertor.Convert(RadiusCm) * Math.PI;
        }
    }
}
