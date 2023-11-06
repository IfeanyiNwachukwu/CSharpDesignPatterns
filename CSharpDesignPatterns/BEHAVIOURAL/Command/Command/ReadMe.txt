Command
The intent of this pattern is to encapsulate a request as an object,
thereby letting you parameterize clients with different requests, queue
or log requests, and support undoable operations.


Invoker asks Command to cary
out a request.

Command declares an interface
for executing an operation.

ConcreteCommand defines a
binding between a Receiver and
and action. It implements Execute
by invoking the corresponding
operation(s) on Receiver.

Receiver knows how to perform
the operations associated with
carrying out a request.

Client creates the
ConcreteCommand and sets its
Receiver


The **Command Design Pattern** is a **behavioral design pattern** that allows you to encapsulate a request as an object, thereby letting you parameterize other objects with different requests, queue or log requests, and support undoable operations. The pattern consists of four main components: **Command**, **Receiver**, **Invoker**, and **Client**. The **Command** object encapsulates a request by binding together a set of actions on a specific **Receiver**. It does so by exposing just one method `execute()` that causes some actions to be invoked on the **Receiver**. The **Invoker** object is responsible for invoking the **Command** object. The **Client** object creates the **Command** object and sets its **Receiver**. The **Client** then passes the **Command** object to the **Invoker** object, which invokes the **Command** object's `execute()` method. The **Command** pattern is useful when you want to decouple an object that invokes an operation from the object that knows how to perform it, or when you want to be able to undo or redo changes to an object ¹²³.

Source: Conversation with Bing, 11/6/2023
(1) Command Pattern - GeeksforGeeks. https://www.geeksforgeeks.org/command-pattern/.
(2) Command Design Pattern - Scaler Topics. https://www.scaler.com/topics/design-patterns/command-design-pattern/.
(3) The Command Pattern in Java | Baeldung. https://www.baeldung.com/java-command-pattern.
(4) Mastering Design Patterns with Examples — Command Pattern. https://medium.com/must-know-computer-science/mastering-design-patterns-with-examples-command-pattern-2dc68803f9ce.
(5) Command pattern - Wikipedia. https://en.wikipedia.org/wiki/Command_pattern.

The Command design pattern is a behavioral design pattern that decouples the sender of a request from the object that performs the action. It encapsulates a request as an object, allowing you to parameterize clients with different requests, queue or log requests, and support undoable operations.

Think of it as a way to encapsulate a request or an action into an object. This object represents the command and can be passed around and executed at a later time. This pattern promotes loose coupling between the sender and the receiver of a request.

In simpler terms, imagine you have a remote control that can control multiple devices like a TV, stereo, and lights. Instead of directly invoking the operations on each device, you can encapsulate those operations into separate objects called commands. Each command represents a specific action, such as turning on the TV or adjusting the volume on the stereo. The remote control then holds and executes these commands based on user input.

The Command pattern allows you to encapsulate the request as an object, which can be stored, passed around, and executed at a later time. It provides a way to decouple the sender and receiver, as the sender does not need to know the specifics of how the request is handled or which objects are involved. This promotes flexibility, extensibility, and the ability to support additional operations like undo/redo functionality.

To summarize, the Command pattern allows you to encapsulate a request or an action into an object, decoupling the sender from the receiver. It promotes loose coupling, flexibility, and extensibility, and provides support for queuing, logging, and undoable operations.


Use Cases for the Command Pattern
When you want to parameterize objects with an action to perform
When you want to support undo
When you want to specify, queue and execute requests at
different times
When you need to store a list of changes to potentially reapply
later on