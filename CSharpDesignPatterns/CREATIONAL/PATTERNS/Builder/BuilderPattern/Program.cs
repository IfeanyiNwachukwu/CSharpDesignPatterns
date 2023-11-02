


using BuilderPattern;
Console.Title = "Builder";


   
    // Implementation 1
    var garage = new Garage();

    var miniBuilder = new MiniBuilder();
    var bmwBuilder = new BMWBuilder();

    garage.Construct(miniBuilder);
    Console.WriteLine(miniBuilder.Car.ToString());
    // or: 
    garage.Show();

    garage.Construct(bmwBuilder);
    Console.WriteLine(bmwBuilder.Car.ToString());
    // or: 
    garage.Show();

  

    // Implementation 2
    // Create a pizza maker
    var pizzaMaker = new PizzaMaker();

    // Create a Margherita pizza builder
    var margheritaBuilder = new MargheritaPizzaBuilder();

    // Build a Margherita pizza
    pizzaMaker.BuildPizza(margheritaBuilder);
    var margheritaPizza = margheritaBuilder.GetPizza();
    margheritaPizza.Display();

    // Create a Pepperoni pizza builder
    var pepperoniBuilder = new  PepperoniPizzaBuilder ();

    // Build a Pepperoni pizza
    pizzaMaker.BuildPizza(pepperoniBuilder);
    var pepperoniPizza = pepperoniBuilder.GetPizza();
    pepperoniPizza.Display();






Console.ReadKey();



