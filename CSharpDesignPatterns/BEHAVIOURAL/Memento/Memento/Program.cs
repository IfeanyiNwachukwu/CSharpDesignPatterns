using Memento;
using static Memento.Implementation2;

TextEditor textEditor = new  TextEditor();

// Editing the content
textEditor.Content = "This is the initial content";
textEditor.PrintContent(); // Output: Current Content: This is the initial content

    // Saving the state
TextEditorMemento memento = textEditor.Save();

// Modifying the content
textEditor.Content = "This is the modified content";
textEditor.PrintContent(); // Output: Current Content: This is the modified content

// Restoring the previous state
textEditor.Restore(memento);
textEditor.PrintContent(); // Output: Current Content: This is the initial content



// Implementation 111

Originator originator = new Originator();
Caretaker caretaker = new Caretaker();

originator.SetState("State 1");
originator.ShowState();

caretaker.SetMemento(originator.SaveState());

originator.SetState("State 2");
originator.ShowState();

originator.RestoreState(caretaker.GetMemento());
originator.ShowState();

Console.ReadKey();
