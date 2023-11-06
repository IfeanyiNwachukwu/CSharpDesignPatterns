using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Implementation2
    {
        public class TextEditor
        {
            private string content;

            public string Content
            {
                get { return content; }
                set { content = value; }
            }

            public TextEditorMemento Save()
            {
                return  new TextEditorMemento(content);
            }

            public void Restore(TextEditorMemento memento)
            {
                content = memento.GetContent();
            }

            public void PrintContent()
            {
                Console.WriteLine("Current Content: " + content);
            }


        }
    }

    public class TextEditorMemento
    {
        private string content;

        public TextEditorMemento(string content)
        {
            this.content = content;
        }

        public string GetContent()
        {
            return content;
        }
    }
}
