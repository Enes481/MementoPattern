using System;

namespace _01_Memento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextFile file = new TextFile() { Path="deneme.txt", Content="Hello World", Color="Black" };

            Console.WriteLine($"'{file.Content}' yazısı {file.Color} rengiyle yazıldı");

            TextFileCareTaker textFileCareTaker = new TextFileCareTaker();
            TextFileMemento textFileMemento = file.CreateMemento();
            textFileCareTaker.Add(textFileMemento);

            file.Content = "Merhaba Dünya";
            file.Color = "Red";
            textFileMemento = file.CreateMemento();
            textFileCareTaker.Add(textFileMemento);

            Console.WriteLine($"'{file.Content}' yazısı {file.Color} rengiyle yazıldı");
            textFileMemento = textFileCareTaker.Get();
            textFileMemento = textFileCareTaker.Get();
            file.LoadMemento(textFileMemento);

            Console.WriteLine($"'{file.Content}' yazısı {file.Color} rengiyle yazıldı");

            Console.ReadKey();
        }
    }
}