﻿namespace Travel
{
    using System;
    using System.IO;
	using System.Linq;
	using Core;
	using Core.Contracts;
	using Core.Controllers;
	using Core.Controllers.Contracts;
	using Core.IO;
	using Core.IO.Contracts;
	using Entities;
	using Entities.Airplanes;
	using Entities.Contracts;

	// god loves ugly
	public static class StartUp
	{
		public static void Main(string[] args)
		{
			IReader reader;

			if (args.Length == 1)
			{
				var testPath = args.First();
				reader = new Core.IO.StringReader(File.ReadAllText(testPath));
			}
			else
			{
				reader = new ConsoleReader();
			}

			IWriter writer = new ConsoleWriter();

			var airport = new Airport();
			var airportController = new AirportController(airport);
			var flightController = new FlightController(airport);

			var engine = new Engine(reader, writer, airportController, flightController);

			engine.Run();
		}
	}
}