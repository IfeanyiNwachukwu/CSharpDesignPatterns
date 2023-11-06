Adapter
The intent of this pattern is to convert the interface of a class into
another interface clients expect. Adapter lets classes work together
that couldn’t otherwise because of incompatible interfaces.


Adaptee defines an existing
interface that needs to be
adapted

Target defines the domainspecific interface that the Client
uses

Client collaborates with objects
conforming to the Target
interface

Adapter adapts the interface of
the Adaptee to the Target
interface



Use Cases for the Adapter Pattern
1.When you want to use an existing class but the interface does not
match the one you need

2.When you want to create a reusable class (the adapter) that works
with classes that don’t have compatible interfaces

3.When you need to use several existing subclasses, don’t want
create additional subclasses for each of them, but still need to
adapt their interface