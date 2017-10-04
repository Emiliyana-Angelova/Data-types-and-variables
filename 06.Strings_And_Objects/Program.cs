using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Strings_And_Objects
{
	class Program
	{
		static void Main(string[] args)
		{
			string word1 = "Hello";
			string word2 = "World";
			object wordAll = word1 + " " + word2;
			string word3 = (string) wordAll;

			Console.WriteLine(word3);

		}
	}
}
