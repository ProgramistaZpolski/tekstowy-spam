using System;
using System.IO;
using System.Linq;

namespace ProdukcjaAtomowek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Atomówki do skopiowania! Wpisz tekst który chcesz żeby spamiło");
            string fileName = Console.ReadLine();
            for (int i = 0; i < 5; i++)
            {
              Console.WriteLine("fileName" + i);
            }
        }
    }
}
