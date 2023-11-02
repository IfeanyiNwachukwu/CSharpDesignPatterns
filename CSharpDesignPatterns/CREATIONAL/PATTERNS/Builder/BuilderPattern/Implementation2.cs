using System.Net.NetworkInformation;

namespace BuilderPattern
{
    /// <summary>
    /// Product
    /// </summary>
    public class Pizza
    {
        public string Name { get; set; }
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public string Topping { get; set; }

        public void Display()
        {
            Console.WriteLine($"{Name} with {Dough} dough, {Sauce} sauce, and {Topping} topping.");
        }
    }
    /// <summary>
    /// Builder interface
    /// </summary>
    public interface IPizzaBuilder
    {
        void Name();
        void BuildDough();
        void BuildSauce();
        void BuildTopping();
        Pizza GetPizza();
    }
    /// <summary>
    /// Concrete Builder
    /// </summary>
    public class MargheritaPizzaBuilder : IPizzaBuilder
    {
        private Pizza _pizza;
        
        
        public MargheritaPizzaBuilder()
        {
            _pizza = new Pizza();
        }
        public void BuildDough()
        {
            _pizza.Dough = "Thin crust";
        }

        public void BuildSauce()
        {
            _pizza.Sauce = "Tomato";
        }

        public void BuildTopping()
        {
            _pizza.Topping = "Mozzarella cheese";
        }
        public void Name()
        {
            _pizza.Name = "Margherita Pizza";
        }
        public Pizza GetPizza() => _pizza;

        
    }
    /// <summary>
    /// Concrete Builder
    /// </summary>
    public class PepperoniPizzaBuilder : IPizzaBuilder
    {
        private Pizza _pizza;

        public PepperoniPizzaBuilder()
        {
            _pizza = new Pizza();
        }
        public void BuildDough()
        {
            _pizza.Dough = "Thick crust";
        }

        public void BuildSauce()
        {
            _pizza.Sauce = "Tomato";
        }

        public void BuildTopping()
        {
            _pizza.Topping = "Pepperoni";
        }
        public void Name()
        {
            _pizza.Name = "Pepperoni Pizza";
        }
        public Pizza GetPizza() => _pizza;
    }
    /// <summary>
    /// Director CLass
    /// </summary>
    public class PizzaMaker
    {
        public void BuildPizza(IPizzaBuilder pizzaBuilder)
        {
            pizzaBuilder.BuildDough();
            pizzaBuilder.BuildSauce();
            pizzaBuilder.BuildTopping();
            pizzaBuilder.Name();
        }
    }


}
