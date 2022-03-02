using System;

namespace Project5
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int number;
			Console.Write("Введите любое двузначное число: ");
			number = int.Parse(Console.ReadLine());
			if (number > 10 && number < 20)
			{
				switch (number)
				{
					case 11: Console.WriteLine("\nодинадцать"); break;
					case 12: Console.WriteLine("\nдвенадцать"); break;
					case 13: Console.WriteLine("\nтринадцать"); break;
					case 14: Console.WriteLine("\nчетырнадцать"); break;
					case 15: Console.WriteLine("\nпятнадцать"); break;
					case 16: Console.WriteLine("\nшеснадцать"); break;
					case 17: Console.WriteLine("\nсемнадцать"); break;
					case 18: Console.WriteLine("\nвосемьнадцать"); break;
					case 19: Console.WriteLine("\nдевятнадцать"); break;
				}
				Console.ReadKey();
				return;
			}
			switch (number/10)
			{
			    case 1: Console.WriteLine("\nдеcять"); break;
				case 2: Console.WriteLine("\nдвадцать"); break;
				case 3: Console.WriteLine("\nтридцать"); break;
				case 4: Console.WriteLine("\nсорок"); break;
				case 5: Console.WriteLine("\nпятьдесят"); break;
				case 6: Console.WriteLine("\nшестьдесят"); break;
				case 7: Console.WriteLine("\nсемьдесят"); break;
				case 8: Console.WriteLine("\nвосемьдесят"); break;
				case 9: Console.WriteLine("\nдевяносто"); break;
				default: break;	
			}
			if (number % 10 >=1 )
			{
				switch (number % 10)
				{
					case 1: Console.Write("один"); break;
					case 2: Console.Write("два"); break;
					case 3: Console.Write("три"); break;
					case 4: Console.Write("четыре"); break;
					case 5: Console.Write("пять"); break;
					case 6: Console.Write("шесть"); break;
					case 7: Console.Write("семь"); break;
					case 8: Console.Write("восемь"); break;
					case 9: Console.Write("девять"); break;
					default:break;	
				}
			}
			Console.ReadKey();
		}
	}
}
