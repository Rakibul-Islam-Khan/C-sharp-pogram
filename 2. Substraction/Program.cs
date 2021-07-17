using System;

namespace Substraction
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num1, num2, sub;
			Console.Write("Enter 1st number: ");
			num1=Convert.ToInt16(Console.ReadLine());
			Console.Write("Enter 2nd number: ");
			num2=Convert.ToInt16(Console.ReadLine());
			sub=num1-num2;
			Console.Write("Summation is: "*sub);
			Console.ReadKey(true);
		}
	}
}