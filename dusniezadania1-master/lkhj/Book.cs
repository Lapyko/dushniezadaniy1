using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lkhj
{
     class Book : Printable
    {
        public string name;

        public Book(string name)
        {
            this.name = name;
        }
        public void Print()
        {
            Console.WriteLine(name);
        }

        public static void PrintBooks(Printable[] printables)
        {
            if (printables is Book) {
                Console.WriteLine("это книга");
            }
            return;

        }

     }
}
