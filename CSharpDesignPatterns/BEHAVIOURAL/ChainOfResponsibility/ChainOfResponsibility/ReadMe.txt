Chain of Responsibility
The intent of this pattern is to avoid coupling the sender of a request to
its receiver by giving more than one object a chance to handle the
request. It does that by chaining the receiving objects and passing the
request along the chain until an object handles it.


Handler defines an interface for
handling requests, and optionally
inmplements the successor link


ConcreteHandler handles
requests it’s responsible for. It ca
access the successor and
potentially pass the request on.

Client initiates the request to a
ConcreteHandler object on
the chain

Use Cases for the Chain of Responsibility Pattern
When more than one object may handle a request and the handler
isn’t known beforehand
When you want to issue a request to one of several objects
(handlers) without specifying the receiver explicitly
When the set of objects that handle a request should be specified
dynamically


The Chain of Responsibility Design Pattern is a behavioral pattern that allows multiple objects to handle a request in a sequential manner. It decouples the sender of the request from the receiver, and each receiver has the ability to either handle the request or pass it on to the next receiver in the chain.

In this pattern, a chain of receiver objects is created, and each receiver has a reference to the next receiver in the chain. When a request is made, it is passed along the chain until a receiver is found that can handle the request. This receiver then processes the request and decides whether to pass it to the next receiver or stop the chain.

The key components of the Chain of Responsibility pattern are:

Handler Interface/Abstract Class: Defines the common interface for all handlers in the chain.
Concrete Handlers: Implement the handler interface and handle specific types of requests. They have a reference to the next handler in the chain.
Client: Initiates the request and sends it to the first handler in the chain.

Here's a simplified example to illustrate the Chain of Responsibility Design Pattern in C#:

// Handler interface
public interface IRequestHandler
{
    void SetNextHandler(IRequestHandler handler);
    void HandleRequest(Request request);
}

// Concrete handler A
public class ConcreteHandlerA : IRequestHandler
{
    private IRequestHandler nextHandler;

    public void SetNextHandler(IRequestHandler handler)
    {
        nextHandler = handler;
    }

    public void HandleRequest(Request request)
    {
        if (request.Type == RequestType.TypeA)
        {
            // Handle the request
            Console.WriteLine("ConcreteHandlerA handled the request.");
        }
        else if (nextHandler != null)
        {
            // Pass the request to the next handler
            nextHandler.HandleRequest(request);
        }
        else
        {
            // No handler can process the request
            Console.WriteLine("No handler can process the request.");
        }
    }
}

// Concrete handler B
public class ConcreteHandlerB : IRequestHandler
{
    private IRequestHandler nextHandler;

    public void SetNextHandler(IRequestHandler handler)
    {
        nextHandler = handler;
    }

    public void HandleRequest(Request request)
    {
        if (request.Type == RequestType.TypeB)
        {
            // Handle the request
            Console.WriteLine("ConcreteHandlerB handled the request.");
        }
        else if (nextHandler != null)
        {
            // Pass the request to the next handler
            nextHandler.HandleRequest(request);
        }
        else
        {
            // No handler can process the request
            Console.WriteLine("No handler can process the request.");
        }
    }
}

// Request class
public class Request
{
    public RequestType Type { get; set; }
}

// Enum for request types
public enum RequestType
{
    TypeA,
    TypeB
}

// Client code
public class Program
{
    public static void Main(string[] args)
    {
        // Create the handler chain
        IRequestHandler handlerA = new ConcreteHandlerA();
        IRequestHandler handlerB = new ConcreteHandlerB();

        handlerA.SetNextHandler(handlerB);

        // Create the request
        Request request = new Request { Type = RequestType.TypeB };

        // Send the request to the first handler
        handlerA.HandleRequest(request);

        // Wait for user input to exit
        Console.ReadLine();
    }
}

In this example, we have two concrete handlers, ConcreteHandlerA and ConcreteHandlerB, which implement the IRequestHandler interface. Each handler checks if it can handle the request based on its criteria. If it can handle the request, it processes it. Otherwise, it passes the request to the next handler in the chain. The chain continues until a handler can handle the request or until the end of the chain is reached.

The client code creates the handler chain by setting the next handler for each handler. It then creates a request and sends it to the first handler in the chain. The chain of responsibility ensures that the request is handled by the appropriate handler or indicates if no handler can process the request.

This pattern promotes loose coupling between objects and provides flexibility in dynamically configuring the chain of handlers. It allows for the separation of responsibilities and promotes extensibility.

I hope this explanation helps! Let me know if you have any further questions.