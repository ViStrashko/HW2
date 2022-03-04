using System;

namespace Project2
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			double coordinateX;
			double coordinateY;
			Console.WriteLine("Введите значение координаты X");
			coordinateX = double.Parse(Console.ReadLine());
			Console.WriteLine("Введите значение координаты Y");
			coordinateY = double.Parse(Console.ReadLine());
			if (coordinateX > 0 && coordinateY > 0)
			{
				Console.WriteLine($"\nТочка с координатами X,Y принадлежит четверти '1'");
			}
			else if (coordinateX < 0 && coordinateY > 0)
			{
				Console.WriteLine($"\nТочка с координатами X,Y принадлежит четверти '2'");
			}
			else if (coordinateX < 0 && coordinateY < 0)
			{
				Console.WriteLine($"\nТочка с координатами X,Y принадлежит четверти '3'");
			}
			else if (coordinateX > 0 && coordinateY < 0)
			{
				Console.WriteLine($"\nТочка с координатами X,Y принадлежит четверти '4'");
			}
			Console.ReadKey();
		}
	}
}
