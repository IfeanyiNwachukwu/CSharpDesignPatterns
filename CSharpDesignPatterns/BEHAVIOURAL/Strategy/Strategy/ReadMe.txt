TStrategy
The intent of this pattern is to define a family of algorithms, encapsulate
each one, and make them interchangeable. Strategy lets the algorithm
vary independently from clients that use it.

Strategy declares an interface
common to all supported
algorithms. Context uses it to call
the algorithm defined a by
ConcreteStrategy.


ConcreteStrategy implements
the algorithm using the Strategy
interface.

Context is configured with a
ConcreteStrategy object and
maintains a reference to a
Strategy object


Use Cases for the Strategy Pattern
When many related classes differ only in their behavior
When you need different variants of an algorithm which you want to
be able to switch at runtime
When your algorithm uses data, code or dependencies that the
clients shouldn't know about
When a class defines many different behaviors which appear as a
bunch of conditional statements in its method