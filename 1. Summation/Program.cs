using System;

namespace Add
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num1, num2, add;
			Console.Write("Enter 1st number: ");
			num1=Convert.ToInt16(Console.ReadLine());
			Console.Write("Enter 2nd number: ");
			num2=Convert.ToInt16(Console.ReadLine());
			add=num1+num2;
			Console.Write("Summation is: " + add);
			Console.ReadKey(true);
		}
	}
}