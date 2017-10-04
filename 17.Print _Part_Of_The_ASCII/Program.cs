using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Print__Part_Of_The_ASCII
{
	class Program
	{
		static void Main(string[] args)
		{
			sbyte start = sbyte.Parse(Console.ReadLine());
			sbyte end = sbyte.Parse(Console.ReadLine());

			for (int i = start; i <= end; i++)
			{
				Console.Write((char) i + " ");
			}
			Console.WriteLine();
		}
	}
}
