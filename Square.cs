namespace BridgePattern
{
    public class Square : Shape
    {
        public int SideCm { get; set; }

        public Square(int side, IUnitConvertor unitConvertor) : base(unitConvertor)
        {
            SideCm = side;
        }

        public override double CalculateArea()
        {
            return UnitConvertor.Convert(SideCm) * UnitConvertor.Convert(SideCm);
        }
    }
}
