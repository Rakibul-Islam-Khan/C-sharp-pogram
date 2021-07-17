using System;

namespace Square_Area
{
	class Program
	{
		public static void Main(string[] args)
		{
			int arm, squarearea;
			Console.Write("Enter the value of arm:");
			arm=Convert.ToInt16(Console.ReadLine());
			squarearea=arm*arm;
			Console.Write("Square area is="+squarearea);
			Console.ReadKey(true);
		}
	}
}