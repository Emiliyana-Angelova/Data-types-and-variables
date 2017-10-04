using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Comparing_Floats
{
	class Program
	{
		static void Main(string[] args)
		{
			double number1 = double.Parse(Console.ReadLine());
			double number2 = double.Parse(Console.ReadLine());
			double epsilon = 0.000001;

			if (Math.Abs(number1 - number2) < epsilon)
			{
				Console.WriteLine("True");
			}
			else
			{
				Console.WriteLine("False");
			}
		}
	}
}
