using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Vowel_Or_Digit
{
	class Program
	{
		static void Main(string[] args)
		{
			char input = char.Parse(Console.ReadLine());

			if (input == 'a' || input == 'o' || input == 'u' || input == 'e' || input == 'i')
			{
				Console.WriteLine("vowel");
			}

			else if (input >= '0' && input <= '9')
			{
				Console.WriteLine("digit");
			}

			else
			{
				Console.WriteLine("other");
			}
		}
	}
}
