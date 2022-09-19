using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Memento
{
    internal class TextFileCareTaker
    {
        Stack<TextFileMemento> textFiles;

        public TextFileCareTaker()
        {
            textFiles = new Stack<TextFileMemento>();
        }

        public void Add(TextFileMemento textFileMemento)
        {
            textFiles.Push(textFileMemento);
        }

        public TextFileMemento Get()
        {
            return textFiles.Pop();
        }
    }
}
