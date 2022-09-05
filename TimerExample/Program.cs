using System.Net.Mime;
using System.Timers;
using System.Media;

namespace TimerExample
{
	class Program
	{
		static double interval = 2000;
		private static System.Timers.Timer mainTimer = new System.Timers.Timer(interval);
		static int timesToRepeat = 3;
		static System.Timers.Timer sideTimer = new System.Timers.Timer(interval * timesToRepeat);
		static void Main()
		{
			
			mainTimer.Elapsed += PrintTime;
			mainTimer.Start();
			
			
			sideTimer.Elapsed += StopTimer;
			sideTimer.Start();
			
			Console.ReadLine();
		}
		
		private static void PrintTime(object? sender, ElapsedEventArgs e)
		{
			Console.WriteLine("{0:hh:mm:ss.fff}", e.SignalTime);
		}
		
		private static void StopTimer(object? sender, ElapsedEventArgs e)
		{
			Console.WriteLine("Stopping timer");
			mainTimer.Stop();
			sideTimer.Stop();
			// exit the program
			Environment.Exit(0);
		}
	}
}

