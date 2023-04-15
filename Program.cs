using System;

namespace task_8
{
	class Program
	{
		static void Main(string[] args)
		{
			int persons;
			int timePerPerson = 10;
			int hoursInLine;
			int minutesInLine;
			int minutesInHour = 60;
			int waitingTime;

			Console.WriteLine("сколько человек в очереди?");
			persons = Convert.ToInt32(Console.ReadLine());
			waitingTime = persons* timePerPerson;
			hoursInLine = waitingTime / minutesInHour;
			minutesInLine = waitingTime % minutesInHour;

			Console.WriteLine($"Вы должны отстоять в очереди {hoursInLine} часа и {minutesInLine} минут.");
		}
	}
}
