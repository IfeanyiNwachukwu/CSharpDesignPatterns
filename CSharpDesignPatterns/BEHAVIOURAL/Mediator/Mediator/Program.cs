using Mediator;
using System.Runtime;

Console.Title = "Mediator";

// Implementation 1

TeamChatRoom teamChatroom = new();

var sven = new Lawyer("Sven");
var kenneth = new Lawyer("Kenneth");
var ann = new AccountManager("Ann");
var john = new AccountManager("John");
var kylie = new AccountManager("Kylie");

teamChatroom.Register(sven);
teamChatroom.Register(kenneth);
teamChatroom.Register(ann);
teamChatroom.Register(john);
teamChatroom.Register(kylie);

ann.Send("Hi everyone, can someone have a look at file ABC123?  I need a compliance check.");
sven.Send("On it!");
sven.Send("Ann", "Could you join me in a Teams call?");
sven.Send("Ann", "All good :)");
ann.SendTo<AccountManager>("The file was approved!");


// Implementation 2

var mediator = new ConcreteMediator();
var component1 = new ConcreteComponentA();
var component2 = new ConcreteComponentB();

mediator.Register(component1);
mediator.Register(component2);

component1.Send("Hello, World!");
component2.Send("Hi there!");

Console.ReadKey();