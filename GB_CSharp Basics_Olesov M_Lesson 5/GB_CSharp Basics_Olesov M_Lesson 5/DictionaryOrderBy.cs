//Дан фрагмент программы:
//а. Свернуть обращение к OrderBy с использованием лямбда-выражения =>.
//b. * Развернуть обращение к OrderBy с использованием делегата

using System;
using System.Collections.Generic;
using System.Linq;

namespace GB_CSharp_Basics_Olesov_M_Lesson_5
{
	class DictionaryOrderBy
	{
		Dictionary<string, int> dict = new Dictionary<string, int>()
		{
			{"four",4 },
			{"two",2 },
			{ "one",1 },
			{"three",3 },
		};
		public void OriginalMethod()
		{
			var d = dict.OrderBy(delegate (KeyValuePair<string, int> pair) { return pair.Value; });
			foreach (var pair in d)
			{
				Console.WriteLine($"{pair.Key} - {pair.Value}");
			}
		}

		public void LambdaMethod()
		{
			var d = dict.OrderBy(x => x.Value);
			foreach (var pair in d)
			{
				Console.WriteLine($"{pair.Key} - {pair.Value}");
			}
		}

		public void DelegateMethod()
		{
			Func<KeyValuePair<string, int>, int> valueGetter = new Func<KeyValuePair<string, int>, int>(GetPairValue);
			var d = dict.OrderBy(valueGetter);
			foreach (var pair in d)
			{
				Console.WriteLine($"{pair.Key} - {pair.Value}");
			}
		}

		private  int GetPairValue(KeyValuePair<string, int> pair)
		{
			return pair.Value;
		}
	}
}
