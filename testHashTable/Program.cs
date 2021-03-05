using System;
using testHashTable.Chaining_Method;

namespace testHashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var HashTable = new ChainingHashTable<int,string>(8);
            HashTable.Add(4,"Привет");
            HashTable.Add(5,"Привет");
            HashTable.Add(6,"Привет");
            HashTable.Add(7,"Привет");
            HashTable.Add(8,"Привет");
            HashTable.Add(9,"Привет");
            HashTable.Add(10,"Привет");
            HashTable.Add(11,"Привет");
            HashTable.Add(12,"Привет");
            HashTable.Add(12,"Здрасте");
            HashTable.Add(12,"Бонжур");
            HashTable.Add(13,"Тринадцать");
            HashTable.Add(14,"Четырнадцать");
            HashTable.Add(15,"Четырнадцать");
            HashTable.Add(16,"Четырнадцать");
            HashTable.Add(17,"Четырнадцать");
            HashTable.Add(18,"Четырнадцать");
            HashTable.Add(19,"Четырнадцать");

            Console.WriteLine(HashTable.Sheart(12));
            Console.WriteLine(HashTable.Sheart(13));

            Console.WriteLine(HashTable.Remove(4));
            Console.WriteLine(HashTable.Remove(22));
        }
    }
}
