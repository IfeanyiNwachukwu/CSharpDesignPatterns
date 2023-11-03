using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    /// <summary>
    /// An interface that defines the common functionality
    /// </summary>
   public interface IComponent
    {
        void Operation();
    }
    /// <summary>
    /// A Comcrete componenet that implements the interface
    /// </summary>
    public class CreateComponent : IComponent
    {
        public void Operation()
        {
            Console.WriteLine("Executing operation in concrete component.");
        }
    }
    /// <summary>
    /// Base Decorator that implements the interface and has a reference to the component
    /// </summary>
    public abstract class BaseDecorator : IComponent
    {
        protected IComponent component;

        public BaseDecorator(IComponent component)
        {
            this.component = component;
        }

        public virtual void Operation()
        {
            component.Operation();
        }
    }
    /// <summary>
    /// Concrete Decorator class that extends the Base Decorator
    /// </summary>
    public class ConcreteDecoratorA : BaseDecorator
    {
        public ConcreteDecoratorA(IComponent component):base(component)
        {

        }

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("Executing extra operation in COncreteDecoratorA");
        }
    }
    /// <summary>
    /// Concrete Decorator class that extends the Base Decorator
    /// </summary>
    public class ConcreteDecoratorB : BaseDecorator
    {
        public ConcreteDecoratorB(IComponent component) : base(component)
        {
        }

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("Executing extra operation in ConcreteDecoratorB.");
        }
    }
}
