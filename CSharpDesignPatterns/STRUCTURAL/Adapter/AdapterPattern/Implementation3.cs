namespace AdapterPattern
{
    /// <summary>
    /// Target Interface
    /// </summary>
    public interface ITarget
    {
        void Request();
    }

    /// <summary>
    /// Adaptee Class
    /// </summary>
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Adaptee's specific reuest");
        }
    }
    /// <summary>
    /// Adapter class
    /// </summary>
    public class Adapter : ITarget
    {
        private Adaptee __adaptee;
        public Adapter(Adaptee adaptee)
        {
            __adaptee = adaptee;
        }

        public void Request()
        {
            __adaptee.SpecificRequest();
        }
    }

    public class Client
    {
        public void ExecuteRequest(ITarget target)
        {
            target.Request();
        }
    }
}
