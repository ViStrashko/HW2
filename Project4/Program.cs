using System;

namespace Project4
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int valueA;
			int valueB;
			int valueC;
			int discriminant;
			Console.WriteLine("Введите значение числа 'а' в уравнении ax2+bx+c=0");
			valueA = int.Parse(Console.ReadLine());
			Console.WriteLine("Введите значение числа 'b' в уравнении ax2+bx+c=0");
			valueB= int.Parse(Console.ReadLine());
			Console.WriteLine("Введите значение числа 'c' в уравнении ax2+bx+c=0");
			valueC= int.Parse(Console.ReadLine());
			discriminant = valueB * valueB - (4 * valueA * valueC);
			if (valueA != 0 && discriminant > 0) {Console.WriteLine($"\nРешение уравнения: x1={((-valueB-Math.Sqrt(discriminant))/(2*valueA))}, x2={((-valueB + Math.Sqrt(discriminant)) / (2 * valueA))}"); }
			else if (valueA != 0 && discriminant == 0){Console.WriteLine($"\nРешение уравнения: x1={(-valueB)/(2*valueA)}");}
			else if (valueA != 0 && discriminant < 0) { Console.WriteLine($"\nРешение уравнения: Корней нет"); }
			Console.ReadKey();
		}
	}
}
