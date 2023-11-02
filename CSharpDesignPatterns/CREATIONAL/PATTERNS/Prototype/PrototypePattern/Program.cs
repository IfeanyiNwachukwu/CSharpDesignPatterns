using PrototypePattern;

Console.Title = "Prototype";

var manager = new Manager("Cindy");
var managerClone = (Manager)manager.Clone();
Console.WriteLine($"Manager was cloned: {managerClone.Name}");

var employee = new Employee("Kevin", managerClone);
var employeeClone = (Employee)employee.Clone(true);
Console.WriteLine($"Employee was cloned: {employeeClone.Name}," +
    $" with manager {employeeClone.Manager.Name}");

// change the manager name
managerClone.Name = "Karen";
Console.WriteLine($"Employee was cloned: {employeeClone.Name}, " +
    $"with manager {employeeClone.Manager.Name}");



// Implementation 2
// Create a concrete prototype
ConcretePrototype prototype = new ConcretePrototype("Prototype 1");

// Create a client and pass the prototype
Client client = new Client(prototype);

// Run the client
client.Run();





Console.ReadKey();