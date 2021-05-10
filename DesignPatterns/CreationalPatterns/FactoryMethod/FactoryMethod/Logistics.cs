namespace FactoryMethod
{
    public abstract class Logistics
    {
        public abstract ITransport CreateTransport();

        public string SomeOperation()
        {
            return CreateTransport().Deliver();
        }
    }
}
