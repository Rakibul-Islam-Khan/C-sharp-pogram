using System;

namespace Multiply
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num1, num2, mul;
			Console.Write("Enter 1st number: ");
			num1=Convert.ToInt16(Console.ReadLine());
			Console.Write("Enter 2nd number: ");
			num2=Convert.ToInt16(Console.ReadLine());
			mul=num1*num2;
			Console.Write("Multipication is: "+mul);
			Console.ReadKey(true);
		}
	}
}