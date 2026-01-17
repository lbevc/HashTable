using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Hash_Table
{
    public class HashTable
    {

        public Node[] buckets;

        private int length;

        public HashTable(int length)
        {
            this.length = length;
            buckets = new Node[length];
        }
        public void Display()
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(i + ": ");

                Node current = buckets[i];

                while (current != null)
                {
                    Console.Write("[" + current.Name + "," + current.Value + "] ");
                    current = current.Next;
                }

                Console.WriteLine();
            }
        }



        private int Hash(string str)
        {
            int sum = 0;

            for (int i = 0; i < str.Length; i++)
            {
                sum = sum + str[i];
            }

            return sum % length;
        }


        public void Insert(string name, int value)
        {
            int index = Hash(name);

            Node current = buckets[index];
            while (current != null)
            {
                if (current.Name == name)
                    return;

                current = current.Next;
            }
            Node newNode = new Node(name, value, buckets[index]);
            buckets[index] = newNode;
        }
        public int Search(string name)
        {
            int index = Hash(name);

            Node current = buckets[index];

            while (current != null)
            {
                if (current.Name == name)
                    return current.Value;

                current = current.Next;
            }

            throw new KeyNotFoundException($"The key '{name}' was not found in the hash table.");
        }
        public void Delete(string name)
        {
            int index = Hash(name);

            Node current = buckets[index];
            Node previous = null;

            while (current != null)
            {
                if (current.Name == name)
                {
                    if (previous == null)
                        buckets[index] = current.Next;
                    else
                        previous.Next = current.Next;

                    return;
                }

                previous = current;
                current = current.Next;
            }
            throw new KeyNotFoundException($"The key '{name}' was not found and cannot be deleted.");
        }



    }
}

