using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Hash_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTable table = new HashTable(9);

            table.buckets[0] = new Node("Iva", 2, null);
            table.buckets[1] = new Node("Kim", 3, null);
            table.buckets[2] = new Node("Ana", 1, null);
            table.buckets[3] = new Node("Tea", 9, null);
            table.buckets[4] = new Node("Lea", 6, null);
            table.buckets[5] = new Node("Bob", 4, new Node("Ivo", 5, null));
            table.buckets[6] = new Node("Ena", 8, null);
            table.buckets[7] = new Node("Joe", 7, null);
            table.buckets[8] = null;

            table.Display();

            Console.WriteLine();
            Console.WriteLine("Bob, 4");
            table.buckets[5] = new Node("Ivo", 5, null);
            table.buckets[7] = null;

            table.Display();

            Console.ReadLine();
        }
    }
}

