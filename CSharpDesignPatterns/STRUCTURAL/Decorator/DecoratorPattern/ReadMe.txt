Decorator
The intent of this pattern is to attach additional responsibilities to an
object dynamically. A decorator thus provides a flexible alternative to
subclassing for extending functionality

Component defines the interface
for objects that can have
responsibilities added to them
dynamically

ConcreteComponent defines an
object to which additional
responsibilities can be attached

Decorator maintains a reference
to a Component object, and
defines an interface that conforms
to Component's interface

ConcreteDecorator adds
responsibilities to the component


Use Cases for the Decorator Pattern
1.When you have a need to add responsibilities to individual objects
dynamically (at runtime) without affecting other objects

2.When you need to be able to withdraw responsibilities you
attached to an object
When extension by subclassing is impractical or impossible