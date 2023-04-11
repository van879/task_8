using System;

namespace task_8
{
	class Program
	{
		static void Main(string[] args)
		{

			int persons;
			int timePerPerson = 10;
			Console.WriteLine("сколько человек в очереди?");
			persons = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine($"Вы должны отстоять в очереди {persons * timePerPerson / 60} часа и {persons * timePerPerson % 60} минут.");
		}
	}
}
