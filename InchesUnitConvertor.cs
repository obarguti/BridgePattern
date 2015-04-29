namespace BridgePattern
{
    public class InchesUnitConvertor : IUnitConvertor
    {
        public double Convert(double value)
        {
            return value/2.54;
        }
    }
}
