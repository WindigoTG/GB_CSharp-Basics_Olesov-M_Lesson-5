//Реализовать метод расширения для поиска количества символов в строке

using System.Collections.Generic;

namespace GB_CSharp_Basics_Olesov_M_Lesson_5
{
    public static class StringSymbolCountExtentionMethod
    {
        //Поскольку класс string и так содержит в себе метод для поиска количества символов,
        //изобретать велосипед, чтобы сделать то же самое иным способом, ради изобретения велосипеда кажется лишним,
        //поэтому я решил сделать методы, подсчитывающие количество уникальных символов в строке
        //и количество вхождений каждого символа в строку.

        public static int CountUniques(this string str)
        {
            HashSet<char> uniques = new HashSet<char>();

            for (int i = 0; i < str.Length; i++)
            {
                if (!uniques.Contains(str[i]))
                    uniques.Add(str[i]);
            }
            return uniques.Count;
        }

        public static Dictionary<char, int> CountUniquesQuantity(this string str)
        {
            Dictionary<char, int> uniques = new Dictionary<char, int>();

            for (int i = 0; i < str.Length; i++)
            {
                if (uniques.ContainsKey(str[i]))
                    uniques[str[i]]++;
                else
                    uniques.Add(str[i], 1);
            }

            return uniques;
        }
    }
}
