﻿using System;

namespace Project3
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			double valueA;
			double valueB;
			double valueC;
			Console.WriteLine("Введите значение числа A");
			valueA = double.Parse(Console.ReadLine());
			Console.WriteLine("Введите значение числа B");
			valueB = double.Parse(Console.ReadLine());
			Console.WriteLine("Введите значение числа C");
			valueC = double.Parse(Console.ReadLine());
			Console.WriteLine("\nЧисла в порядке возрастания:");
			if (valueA < valueB && valueB < valueC)
			{
				Console.WriteLine($"{valueA}, {valueB}, {valueC}");
			}
			else if (valueA < valueC && valueC < valueB)
			{
				Console.WriteLine($"{valueA}, {valueC}, {valueB}");
			}
			else if (valueB < valueA && valueA < valueC)
			{
				Console.WriteLine($"{valueB}, {valueA}, {valueC}");
			}
			else if (valueB < valueC && valueC < valueA)
			{
				Console.WriteLine($"{valueB}, {valueC}, {valueA}");
			}
			else if (valueC < valueA && valueA < valueB)
			{
				Console.WriteLine($"{valueC}, {valueA}, {valueB}");
			}
			else if (valueC < valueB && valueB < valueA)
			{
				Console.WriteLine($"{valueC}, {valueB}, {valueA}");
			}
			Console.ReadKey();
		}
	}
}
