using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Memento
{
    class Originator
    {
        private string state;

        public void SetState(string state)
        {
            Console.WriteLine($"Setting state to {state}");
            this.state = state;
        }

        public Memento SaveState()
        {
            Console.WriteLine("Saving state...");
            return new Memento(state);
        }

        public void RestoreState(Memento memento)
        {
            Console.WriteLine("Restoring state...");
            state = memento.GetState();
        }

        public void ShowState()
        {
            Console.WriteLine($"Current state: {state}");
        }
    }

    class Memento
    {
        private readonly string state;

        public Memento(string state)
        {
            this.state = state;
        }

        public string GetState()
        {
            return state;
        }
    }

    class Caretaker
    {
        private Memento memento;

        public void SetMemento(Memento memento)
        {
            Console.WriteLine("Setting memento...");
            this.memento = memento;
        }

        public Memento GetMemento()
        {
            Console.WriteLine("Getting memento...");
            return memento;
        }
    }

   
}
