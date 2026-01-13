using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTable table = new HashTable(9);

            table.Insert("Iva", 2);
            table.Insert("Kim", 3);
            table.Insert("Ana", 1);
            table.Insert("Tea", 9);
            table.Insert("Lea", 6);
            table.Insert("Bob", 4);
            table.Insert("Ivo", 5);
            table.Insert("Ena", 8);
            table.Insert("Joe", 7);

            table.Display();

            Console.WriteLine();
            Console.WriteLine("Bob, 4");
            table.Insert("Ivo", 5); 
            HashTable table2 = new HashTable(9);

            table2.Insert("Iva", 2);
            table2.Insert("Kim", 3);
            table2.Insert("Ana", 1);
            table2.Insert("Tea", 9);
            table2.Insert("Lea", 6);
            table2.Insert("Ivo", 5);
            table2.Insert("Ena", 8);

            table2.Display();
            Console.WriteLine();
        }
    }
}


