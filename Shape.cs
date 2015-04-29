namespace BridgePattern
{
    public abstract class Shape
    {
        public IUnitConvertor UnitConvertor { get; set; }

        protected Shape(IUnitConvertor unitConvertor)
        {
            UnitConvertor = unitConvertor;
        }

        public abstract double CalculateArea();
    }
}
