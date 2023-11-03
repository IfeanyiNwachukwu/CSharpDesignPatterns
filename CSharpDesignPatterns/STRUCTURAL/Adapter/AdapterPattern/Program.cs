using AdapterPattern;


Console.Title = "Adapter";

// object adapter example
ICityAdapter adapter = new CityAdapter();
var city = adapter.GetCity();

Console.WriteLine($"{city.FullName}, {city.Inhabitants}");
Console.ReadKey();


// Implementation 2
// Create an instance of the <link>Adaptee</link>
    Adaptee adaptee = new Adaptee();

// Create an instance of the <link>Adapter</link>, passing the <link>Adaptee</link> to its constructor
    Adapter adapter1 = new Adapter(adaptee);

    // Create an instance of the <link>Client</link>
    Client  client = new  Client ();

// Execute the request through the <link>Adapter</link>
client.ExecuteRequest(adapter1);