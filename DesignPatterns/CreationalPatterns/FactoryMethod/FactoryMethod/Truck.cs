namespace FactoryMethod
{
    public class Truck : ITransport
    {
        public string Deliver()
        {
            return "Deliver by land in a box.";
        }
    }
}
