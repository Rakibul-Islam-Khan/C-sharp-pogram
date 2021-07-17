using System;

namespace Remainder
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num1, num2, remainder;
			Console.Write("Enter 1st number: ");
			num1=Convert.ToInt16(Console.ReadLine());
			Console.Write("Enter 2nd number: ");
			num2=Convert.ToInt16(Console.ReadLine());
			remainder=num1%num2;
			Console.Write("Remainder is: "+remainder);
			Console.ReadKey(true);
		}
	}
}