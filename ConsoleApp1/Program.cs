using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> list = new List<int>(){2,5,7,8,66,774,58,245,14,62,19};
			Func<int,bool>func = n => n%2==0;
			List<int> result = new List<int>();
			result = GetEvenInts(list, func);
			foreach (int i in result)
			{
				Console.WriteLine(i);
			}
		}
		static List<int> GetEvenInts(List<int> items ,Func<int,bool>func)
		{
			List<int> result = new List<int>();
			foreach (int item in items)
			{
				if (func(item))
				{
					result.Add(item);
				}
			}
			return result;
		}
	}
}
