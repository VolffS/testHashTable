using System;
using testHashTable.Chaining_Method;

namespace testHashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var HashTable = new ChainingHashTable<int,string>(8);
            var HashTableint = new ChainingHashTable<int, int>(8);
            HashTableint.Add(4,0);
            HashTableint.Add(5,1);
            HashTableint.Add(6,2);
            HashTableint.Add(7,3);
            HashTableint.Add(8,4);
            HashTableint.Add(9,5);
            HashTableint.Add(10,0);
            HashTableint.Add(11,0);
            HashTableint.Add(12,1);

            Console.WriteLine(HashTableint.Find(4));
            Console.WriteLine(HashTableint.Find(5));
            Console.WriteLine(HashTableint.Find(22));

            Console.WriteLine(HashTableint.Remove(4));
            Console.WriteLine(HashTableint.Remove(12));
            Console.WriteLine(HashTableint.Remove(22));

            //HashTable.Add(12,"Привет");
            //HashTable.Add(12,"Здрасте");
            //HashTable.Add(12,"Бонжур");
            //HashTable.Add(13,"Тринадцать");
            //HashTable.Add(14,"Четырнадцать");
            //HashTable.Add(15,"Четырнадцать");
            //HashTable.Add(16,"Четырнадцать");
            //HashTable.Add(17,"Четырнадцать");
            //HashTable.Add(18,"Четырнадцать");
            //HashTable.Add(19,"Четырнадцать");

            //Console.WriteLine(HashTable.Find(12));
            //Console.WriteLine(HashTable.Find(13));
            //Console.WriteLine(HashTable.Find(15));
            //Console.WriteLine(HashTable.Find(22));



            //Console.WriteLine(HashTable.Remove(4));
            //Console.WriteLine(HashTable.Remove(22));
            //Console.WriteLine(HashTable.Remove(12));
            //Console.WriteLine(HashTableint.Remove(4));
            //Console.WriteLine(HashTableint.Remove(12));
            //Console.WriteLine(HashTableint.Remove(22));
        }
    }
}
