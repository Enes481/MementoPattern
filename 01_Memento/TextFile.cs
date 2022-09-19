using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Memento
{
    internal class TextFile
    {
        public string Path { get; set; }
        public string Content { get; set; }
        public string Color { get; set; }

        public TextFileMemento CreateMemento()
        {
            return new TextFileMemento() { Content=this.Content, Color=this.Color };
        }

        //public static TextFileMemento CreateMemento(TextFile textFile)
        //{

        //}

        public void LoadMemento(TextFileMemento textFileMemento)
        {
            this.Color = textFileMemento.Color;
            this.Content = textFileMemento.Content;
        }
    }
}
