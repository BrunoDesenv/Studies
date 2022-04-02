namespace BridgeExercise
{
    public class Red
    {
        public virtual string Operation()
        {
            return "Abstract: Base operation with:\n" +
                _implementation.OperationImplementation();
        }
    }
}
