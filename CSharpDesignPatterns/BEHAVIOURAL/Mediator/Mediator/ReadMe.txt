Mediator
The intent of this pattern is to define an object - the mediator - that
encapsulates how a set of objects interact. It does that by forcing
objects to communicate via that mediator.

Objects hold references to each
other. Management & keeping
communication in sync is an issue.


A central object, the mediator,
holds references of objects that
want to communicate with each
other. It handles communication
between them.


Mediator defines an interface for
communicating with Colleague
objects

Colleague knows its Mediator
and communicates with it instead
of with another Colleague


ConcreteMediator knows and
maintains its Colleagues, and it
implements cooperative behavior
by coordinating Colleague objects

The Mediator Design Pattern is a behavioral pattern that helps objects communicate with each other without being directly coupled. In this pattern, a mediator object acts as a central hub that controls the communication between different objects. Instead of objects directly interacting with each other, they communicate through the mediator.

In simple terms, think of a mediator as a coordinator or a middleman. When an object wants to communicate with another object, it sends a message or request to the mediator, which then handles the communication and passes the message to the appropriate object. The mediator encapsulates the interaction logic and promotes loose coupling between objects.

By using the Mediator Design Pattern, the objects don't need to know about each other explicitly, which reduces dependencies and makes the system more flexible and maintainable. It promotes better organization and simplifies complex communication scenarios.

To summarize, the Mediator Design Pattern facilitates communication between objects by introducing a mediator that handles the interaction. This promotes loose coupling, improves system flexibility, and simplifies object interactions.





Use Cases for the Mediator Pattern
When a set of object communicate in well-defined but
complex ways
When, because an object refers to and communicates with many
other objects, the object is difficult to reuse
When behavior that's distributed between several classes should
be customizable without a lot of subclassing