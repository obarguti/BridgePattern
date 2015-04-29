namespace BridgePattern
{
    public class Triangle : Shape
    {
        public int BaseCm { get; set; }
        public int HeightCm { get; set; }

        public Triangle(int @base, int height, IUnitConvertor unitConvertor) : base(unitConvertor)
        {
            BaseCm = @base;
            HeightCm = height;
        }

        public override double CalculateArea()
        {
            return 0.5 * UnitConvertor.Convert(BaseCm) * UnitConvertor.Convert(HeightCm);
        }
    }
}
