using System;

namespace Rhombus
{
	class Program
	{
		public static void Main(string[] args)
		{
			double d1, d2, rhombus;
			Console.Write("Enter the value of Diagonal 1:");
			d1=Convert.ToDouble(Console.ReadLine());
			Console.Write("Enter the value of Diagonal 2:");
			d2=Convert.ToDouble(Console.ReadLine());
			rhombus=0.5*d1*d2;
			Console.Write("Rhombus area is="+rhombus);
			Console.ReadKey(true);
		}
	}
}