namespace PrototypePattern
{
    /// <summary>
    /// Prototype Interface
    /// </summary>
    public interface IPrototype
    {
        IPrototype Clone();
        void Display();
    }
    /// <summary>
    /// Concrete Prototype
    /// </summary>
    public class ConcretePrototype : IPrototype
    {
        private string _name;

        public ConcretePrototype(string name)
        {
            _name = name;
        }

        public IPrototype Clone()
        {
            return new ConcretePrototype(_name);
        }

        public void Display()
        {
            Console.WriteLine("Prototype Name: " + _name);
        }
    }
    /// <summary>
    /// Client Class
    /// </summary>
    public class Client
    {
        private IPrototype _prototype;

        public Client(IPrototype prototype)
        {
            _prototype = prototype;
        }

        public void Run()
        {
            // Clone the prototype
            IPrototype clonedPrototype = _prototype.Clone();

            // Display the cloned prototype
            clonedPrototype.Display();
        }
    }
}
