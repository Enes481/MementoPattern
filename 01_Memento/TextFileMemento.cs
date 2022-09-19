using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Memento
{
    internal class TextFileMemento
    {
        internal TextFileMemento()
        {

        }

        public string Content { get; set; }
        public string Color { get; set; }
    }
}