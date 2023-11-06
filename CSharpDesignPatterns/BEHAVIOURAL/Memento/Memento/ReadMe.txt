The intent of the factory method pattern is to define an interface for creating an object but to let subclasses decide which class to instantiate.


The Memento pattern is a behavioral design pattern that allows you to save and restore the state of an object without exposing its internal details. It provides a way to capture the object's current state and store it externally, so that it can be restored later if needed.

Think of it as taking a snapshot of an object's state and being able to revert back to that snapshot whenever necessary. This pattern is useful when you want to implement undo/redo functionality or need to restore an object to a previous state.

In simpler terms, imagine you have a text editor where you can make changes to a document. Before making any changes, you can save the current state of the document. If you later decide to undo the changes, you can restore the document to the previously saved state.

The Memento pattern allows you to encapsulate the state of an object into a separate object called the "memento". This memento can be stored and managed externally, providing a way to save and restore the object's state without exposing its internal details.

To summarize, the Memento pattern provides a way to save and restore the state of an object without exposing its internals. It allows you to take snapshots of an object's state, store them externally, and restore the object to a previous state when needed.


The **Memento Design Pattern** is a **behavioral design pattern** that allows an object to capture its internal state and save it externally without violating encapsulation. Later, the object can be restored to that state. The pattern consists of three main components: **Originator**, **Memento**, and **Caretaker**. The **Originator** is the object whose state needs to be saved. The **Memento** is an object that stores the state of the Originator. The **Caretaker** is responsible for the safekeeping of the Memento. It can request the Originator to save its state or restore its state from a previously saved Memento. The Memento pattern is useful when you want to be able to undo or redo changes to an object, or when you want to be able to save and restore the state of an object at a later time ¹²³.





Factory method lets a class defer instantiation to subclasses.

USE CASES

1. When a class can't anticipate the class of objects it must create.

2. When a class wants its subclasses to specify the object it creates.

3. As a way to enable reusing of existing objects