Memento
The intent of this pattern is to capture and externalize an object's
internal state so that the object can be restored to this state later,
without violating encapsulation.


Memento stores the internal state
of the originator. The state should
be protected against access by
other objects as much as possible.

Originator creates a Memento
with a snapshot of its internal
state. It also uses the Memento
to restore its internal state.

Caretaker keeps the Memento
safe, and shouldn’t operate on or
examine its contents.

Use Cases for the Memento Pattern
When part of an object’s state must be saved so it can be restored
later on
AND when a direct interface to obtaining the state would expose
implementation details and break encapsulation