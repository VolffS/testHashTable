using System;
using testHashTable.Chaining_Method;
using testHashTable.HashTable;

namespace testHashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var HashTableInt = new ChainingHashTablInt();
            var HashTableString = new ChainingHashTablString();
            var OpenHashTableInt = new OpenAdddressingHashTableInt();
            var OpenHashTableString = new OpenAdddressingHashTableString();
            //HashTableInt.Realize();
            //HashTableString.Realize();
            OpenHashTableInt.Realize();
            OpenHashTableString.Realize();
            Console.WriteLine("Готово");

        }
    }
    class ChainingHashTablInt
    {
        public void Realize()
        {
            var HashTableint = new ChainingHashTable<int, int>(8);
            HashTableint.Add(1, 0);
            HashTableint.Add(2, 0);
            HashTableint.Add(3, 0);
            HashTableint.Add(4, 0);
            HashTableint.Add(5, 1);
            HashTableint.Add(6, 2);
            HashTableint.Add(7, 3);
            HashTableint.Add(8, 4);
            HashTableint.Add(9, 5);
            HashTableint.Add(10, 0);
            HashTableint.Add(11, 0);
            HashTableint.Add(12, 1);
            HashTableint.Add(13, 13);
            HashTableint.Add(14, 14);
            HashTableint.Add(15, 15);
            HashTableint.Add(16, 16);
            Console.WriteLine("Проводиться поиск");
            Console.WriteLine(HashTableint.Find(4));
            Console.WriteLine(HashTableint.Find(5));
            Console.WriteLine(HashTableint.Find(8));
            Console.WriteLine(HashTableint.Find(9));
            Console.WriteLine(HashTableint.Find(22));
            Console.WriteLine("Проводиться удаление");
            Console.WriteLine(HashTableint.Remove(4));
            Console.WriteLine(HashTableint.Remove(12));
            Console.WriteLine(HashTableint.Remove(22));
        }
    }
    class ChainingHashTablString
    {
        public void Realize()
        {
            var HashTable = new ChainingHashTable<int, string>(8);

            HashTable.Add(12, "Привет");
            HashTable.Add(12, "Здрасте");
            HashTable.Add(12, "Бонжур");
            HashTable.Add(13, "Тринадцать");
            HashTable.Add(14, "Четырнадцать");
            HashTable.Add(15, "Четырнадцать");
            HashTable.Add(16, "Четырнадцать");
            HashTable.Add(17, "Четырнадцать");
            HashTable.Add(18, "Четырнадцать");
            HashTable.Add(19, "Четырнадцать");
            Console.WriteLine("Проводиться поиск");
            Console.WriteLine(HashTable.Find(12));
            Console.WriteLine(HashTable.Find(13));
            Console.WriteLine(HashTable.Find(15));
            Console.WriteLine(HashTable.Find(22));
            Console.WriteLine("Проводиться удаление");
            Console.WriteLine(HashTable.Remove(4));
            Console.WriteLine(HashTable.Remove(22));
            Console.WriteLine(HashTable.Remove(12));
        }
    }
    class OpenAdddressingHashTableInt
    {
        public void Realize()
        {
            var HashTable = new OpenAddressingHashTable<int, int>(8);

            HashTable.Add(1, 1);
            HashTable.Add(2, 2);
            HashTable.Add(3, 3);
            HashTable.Add(4, 4);
            HashTable.Add(5, 5);
            HashTable.Add(6, 6);
            HashTable.Add(7, 7);
            HashTable.Add(8, 8);
            HashTable.Add(9, 9);
            HashTable.Add(10, 10);
            HashTable.Add(11, 11);
            HashTable.Add(12, 12);
            HashTable.Add(13, 13);
            HashTable.Add(14, 14);
            HashTable.Add(15, 15);
            HashTable.Add(16, 16);
            HashTable.Add(17, 17);
            Console.WriteLine("Проводиться поиск");
            Console.WriteLine(HashTable.Find(4));
            Console.WriteLine(HashTable.Find(5));
            Console.WriteLine(HashTable.Find(8));
            Console.WriteLine(HashTable.Find(9));
            Console.WriteLine(HashTable.Find(22));
            Console.WriteLine("Проводиться удаление");
            Console.WriteLine(HashTable.Remove(4));
            Console.WriteLine(HashTable.Remove(12));
            Console.WriteLine(HashTable.Remove(22));
        }
    }
    class OpenAdddressingHashTableString
    {
        public void Realize()
        {
            var HashTable = new OpenAddressingHashTable<string, int>(8);

            for (int i = 0; i < 99; i++)
            {
                HashTable.Add(i.ToString(), i);
            }
            for (int i = 0; i < 99; i++)
            {
                Console.WriteLine( HashTable.Find(i.ToString()));
            }
        }
    }
}
