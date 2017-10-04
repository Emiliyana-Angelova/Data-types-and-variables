using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
	class Program
	{
		static void Main(string[] args)
		{
			int distanceInMeters = int.Parse(Console.ReadLine());
			byte hoursForDistance = byte.Parse(Console.ReadLine());
			byte minutesForDistance = byte.Parse(Console.ReadLine());
			byte secondsForDistance = byte.Parse(Console.ReadLine());

			int totalTimeInSeconds = hoursForDistance * 3600 + minutesForDistance * 60 + secondsForDistance;

			float totalTimeInHours = (float)totalTimeInSeconds / 3600;

			float distanceInKilometers = (float)distanceInMeters / 1000;
			float distanceInMiles = (float)distanceInMeters / 1609;

			float metersPerSecound = (float)distanceInMeters / totalTimeInSeconds;
			float kilometersPerHour = distanceInKilometers / totalTimeInHours;
			float milesPerHour = distanceInMiles / totalTimeInHours;

			Console.WriteLine(metersPerSecound);
			Console.WriteLine(kilometersPerHour);
			Console.WriteLine(milesPerHour);
		}
	}
}
