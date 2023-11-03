using DecoratorPattern;
using System.ComponentModel;

Console.Title = "Decorator";

// Instantiate mails Services
var cloudMailService = new CloudMailService();
cloudMailService.SendMail("Hi there");


var onPremiseMailService = new OnPremiseMailService();
onPremiseMailService.SendMail("Hi there.");

// add behaviour
var statisticsDecorator = new StatisticsDecorator(cloudMailService);
statisticsDecorator.SendMail($"Hi there via {nameof(StatisticsDecorator)} wrapper.");

// add behavior
var messageDatabaseDecorator = new MessageDatabaseDecorator(onPremiseMailService);
messageDatabaseDecorator.SendMail(
    $"Hi there via {nameof(MessageDatabaseDecorator)} wrapper, message 1.");
messageDatabaseDecorator.SendMail(
    $"Hi there via {nameof(MessageDatabaseDecorator)} wrapper, message 2.");

foreach (var message in messageDatabaseDecorator.SentMessages)
{
    Console.WriteLine($"Stored message: \"{message}\"");
}

Console.ReadKey();

//3rd Implementation
// Creating the concrete component
CreateComponent component = new CreateComponent();

// Wrapping the component with decorators
ConcreteDecoratorA decoratedComponent = new ConcreteDecoratorA  (new  ConcreteDecoratorB  (component));

// Invoking operations
decoratedComponent.Operation();