using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lkhj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Printable[] printables = new Printable[5];
            printables[1] = new Book("книга первая");
            printables[2] = new Magazine("журнал первый");
            printables[3] = new Book("книга вторая");
            printables[4] = new Magazine("журнал второй");

            foreach (Printable printable in printables)
            {
                printable.Print();
            }
            
                Book.PrintBooks(printables);
                Console.WriteLine("это книга");
            
            
                Magazine.PrintMagazine(printables);
                Console.WriteLine("это журнал");
            
            Console.ReadKey();
        }
    }
}
