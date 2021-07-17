using System;

namespace Division
{
	class Program
	{
		public static void Main(string[] args)
		{
			double num1, num2, div;
			Console.Write("Enter 1st number: ");
			num1=Convert.ToDouble(Console.ReadLine());
			Console.Write("Enter 2nd number: ");
			num2=Convert.ToDouble(Console.ReadLine());
			div=num1/num2;
			Console.Write("Division is: "+div);
			Console.ReadKey(true);
		}
	}
}