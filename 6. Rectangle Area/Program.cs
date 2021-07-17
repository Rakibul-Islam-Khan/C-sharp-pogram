using System;

namespace Rectangle_Area
{
	class Program
	{
		public static void Main(string[] args)
		{
			int length, width, r_area;
			Console.Write("Enter the value of Length: ");
			length=Convert.ToInt16(Console.ReadLine());
			Console.Write("Enter the value of Width: ");
			width=Convert.ToInt16(Console.ReadLine());
			r_area=length*width;
			Console.Write("Rectangle Area is : "+r_area);
			Console.ReadKey(true);
		}
	}
}