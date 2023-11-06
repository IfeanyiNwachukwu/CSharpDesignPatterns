Template method
The intent of this pattern is to define the skeleton of an algorithm in an
operation, deferring some steps to subclasses. It lets subclasses
redefine certain steps of an algorithm without changing the algorithm's
structure.



AbstractClass defines abstract
primitive operations that concrete
subclasses define to implement
steps of an algorithm

AbstractClass implements a
template method defining the
skeleton of an algorithm


Use Cases for the Template Method Pattern
When you want to implement invariant parts of an algorithm only
once, and want to leave it to subclasses to implement the rest of
the behavior
When you want to control which part of an algorithm subclasses
can vary
When you have a set of algorithms that don’t vary much