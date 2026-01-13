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
            int bobValue = table.Search("Bob");
            Console.WriteLine("Bob, " + bobValue);
            Console.WriteLine();
            table.Delete("Bob");
            table.Delete("Joe");
            table.Display();

            Console.ReadLine();
        }
    }
}



