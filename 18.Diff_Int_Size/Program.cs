using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Diff_Int_Size
{
	class Program
	{
		static void Main(string[] args)
		{
			string N = Console.ReadLine();
			bool match = false;
			string dataType = null;

			try
			{
				Convert.ToSByte(N);				
				dataType += "* sbyte\n";
				match = true;
			}
			catch (Exception)
			{

			}

			try
			{
				Convert.ToByte(N);
				dataType += "* byte\n";
				match = true;
			}
			catch (Exception)
			{

			}

			try
			{
				Convert.ToInt16(N);
				dataType += "* short\n";
				match = true;
			}
			catch (Exception)
			{

			}

			try
			{
				Convert.ToUInt16(N);
				dataType += "* ushort\n";
				match = true;
			}
			catch (Exception)
			{

			}

			try
			{
				Convert.ToInt32(N);
				dataType += "* int\n";
				match = true;
			}
			catch (Exception)
			{

			}

			try
			{
				Convert.ToUInt32(N);
				dataType += "* uint\n";
				match = true;
			}
			catch (Exception)
			{

			}

			try
			{
				Convert.ToInt64(N);
				dataType += "* long\n";
				match = true;
			}
			catch (Exception)
			{

			}

			if (match)
			{
				Console.WriteLine($"{N} can fit in:");
				Console.WriteLine(dataType);
			}
			else
			{
				Console.WriteLine($"{N} can't fit in any type");
			}
		}


	}
}
