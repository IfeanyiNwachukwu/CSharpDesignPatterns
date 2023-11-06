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


Use Cases for the Command Pattern
When you want to parameterize objects with an action to perform
When you want to support undo
When you want to specify, queue and execute requests at
different times
When you need to store a list of changes to potentially reapply
later on