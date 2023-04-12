using System;

namespace task_8
{
	class Program
	{
		static void Main(string[] args)
		{
			int persons;
			int timePerPerson = 10;
			int hours;
			int minutes;
			int minutesInHour = 60;

			Console.WriteLine("сколько человек в очереди?");
			persons = Convert.ToInt32(Console.ReadLine());
			hours = persons * timePerPerson / minutesInHour;
			minutes = persons * timePerPerson % minutesInHour;

			Console.WriteLine($"Вы должны отстоять в очереди {hours} часа и {minutes} минут.");
		}
	}
}
