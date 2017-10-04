using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Exchange_Var_Values
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 5;
			int b = 10;

			int aNew = b;
			int bNew = a;

			Console.WriteLine($"Before:\na = 5\nb = 10\nAfter:\na = {aNew}\nb = {bNew}");
		}
	}
}
