using System;

namespace Project1
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int valueA;
			int valueB;
			Console.WriteLine("Введите значение числа A");
			valueA = int.Parse(Console.ReadLine());
			Console.WriteLine("Введите значение числа B");
			valueB = int.Parse(Console.ReadLine());
			if (valueA > valueB)
			{
				Console.WriteLine($"\nСумма чисел: {valueA + valueB}");
			}
			else if (valueA == valueB)
			{
				Console.WriteLine($"\nПроизведение чисел: {valueA * valueB}");
			}
			else if (valueA < valueB)
			{
				Console.WriteLine($"\nРазность чисел: {valueA - valueB}");
			}
			Console.ReadKey();
		}
	}
}
