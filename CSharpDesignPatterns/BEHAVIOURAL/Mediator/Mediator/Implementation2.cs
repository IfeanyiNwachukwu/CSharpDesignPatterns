using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    using System;
    using System.Collections.Generic;

    // Mediator interface
    public interface IMediator
    {
        void Notify(object sender, string ev);
    }

    // Concrete Mediator
    public class ConcreteMediator : IMediator
    {
        private List<Component> components = new List<Component>();

        public void Register(Component component)
        {
            components.Add(component);
            component.SetMediator(this);
        }

        public void Notify(object sender, string ev)
        {
            foreach (var component in components)
            {
                if (component != sender)
                {
                    component.Receive(ev);
                }
            }
        }
    }

    // Base Component
    public class Component
    {
        protected IMediator mediator;

        public void SetMediator(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public void Send(string message)
        {
            mediator.Notify(this, message);
        }

        public virtual void Receive(string message)
        {
            Console.WriteLine($"Component received message: {message}");
        }
    }

    // Concrete Components
    public class ConcreteComponentA : Component
    {
        public override void Receive(string message)
        {
            Console.WriteLine($"Component A received message: {message}");
        }
    }

    public class ConcreteComponentB : Component
    {
        public override void Receive(string message)
        {
            Console.WriteLine($"Component B received message: {message}");
        }
    }

   

}
