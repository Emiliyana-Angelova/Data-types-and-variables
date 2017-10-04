using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Int_To_Hex_And_Binary
{
	class Program
	{
		static void Main(string[] args)
		{
			int input = int.Parse(Console.ReadLine());
			string hex = Convert.ToString(input, 16).ToUpper();
			string binary = Convert.ToString(input, 2);

			Console.WriteLine(hex);
			Console.WriteLine(binary);
		}
	}
}
