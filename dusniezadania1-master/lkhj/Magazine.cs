using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lkhj
{
    internal class Magazine : Printable
    {
        public string name;

        public Magazine(string name)
        {
            this.name = name;       
        }
        public void Print()
        {
            Console.WriteLine(name);
        }
        void printMagazine (Printable[] printables)
        {
            Console.WriteLine();
        }

        public static void PrintMagazine(Printable[] printables)
        {
            if (printables is Magazine)
            {
                Console.WriteLine("это журнал");
            }
            return;
        }
    }
}
