using System;
using System.Collections.Generic;

namespace GB_CSharp_Basics_Olesov_M_Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            StringSymbolCount();
            EntriesCount();
            DictionaryOrder();
        }

        static void StringSymbolCount()
        {
            string str = "Экстеншн методы экстендили, экстендили, да не выэкстендили";
            Console.WriteLine($"Строка: {str}\n");

            Console.WriteLine($"Количество уникальных символов {str.CountUniques()}");
            Console.WriteLine();

            foreach (var entry in str.CountUniquesQuantity())
                Console.WriteLine($"Символ «{entry.Key}» встречается {entry.Value} раз(а)");

            Console.ReadKey();
            Console.Clear();
        }

        static void EntriesCount()
        {
            CollectionEntriesCount counter = new CollectionEntriesCount();

            List<int> ints = new List<int>() { 1, 2, 3, 1, 5, 8, 4, 2, 3, 1, 5, 4 };
            List<string> strs = new List<string>() {"List", "HashSet", "Dictionary", "Queue", "Stack", "List", "Queue", "Stack", "List"};

            Console.WriteLine("Коллекция <int>:");
            foreach (var i in ints)
                Console.Write(i+"    ");
            Console.Write("\n\n");
            counter.EntriesCount(ints);
            Console.WriteLine();

            Console.WriteLine("Коллекция <string>:");
            foreach (var s in strs)
                Console.Write(s + "    ");
            Console.Write("\n\n");
            counter.EntriesCount(strs);

            Console.ReadKey();
            Console.Clear();
        }

        static void DictionaryOrder()
        {
            DictionaryOrderBy dictionary = new DictionaryOrderBy();
            dictionary.OriginalMethod();
            Console.WriteLine();
            dictionary.LambdaMethod();
            Console.WriteLine();
            dictionary.DelegateMethod();
            Console.ReadKey();
        }
    }
}
