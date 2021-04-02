//Дана коллекция List<T>. Требуется подсчитать, сколько раз каждый элемент встречается в данной коллекции:
//a. для целых чисел;
//b. *для обобщенной коллекции;
//c. **используя Linq.


using System;
using System.Collections.Generic;
using System.Linq;

namespace GB_CSharp_Basics_Olesov_M_Lesson_5
{
    class CollectionEntriesCount
    {
        public void EntriesCount<T>(List<T> collection)
        {
            var entriesCount = from entry in collection
                               group entry by entry;
            

            foreach (IGrouping<T, T> g in entriesCount)
            {
                Console.WriteLine($"Элемент «{g.Key}» встречается {g.Count<T>()} раз(а)");
            }
        }
    }
}
