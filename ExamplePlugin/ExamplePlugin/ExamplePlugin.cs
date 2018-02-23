﻿using System;
using Smod.TestPlugin;
using Smod2;
using Smod2.Attributes;
using Smod2.Events;

namespace ExamplePlugin
{
	[PluginDetails(
		author = "Courtney",
		name = "Test",
		description = "Example plugin",
		id = "courtney.example.plugin",
		version = "1.0",
		SmodMajor = 1,
		SmodMinor = 0,
		SmodRevision = 0
		)]
	class ExamplePlugin : Plugin
	{
		public override void OnDisable()
		{
		}

		public override void OnEnable()
		{
			Console.WriteLine("On enable :)");
		}

		public override void Register()
		{
			// Register Events
			this.AddEventHandler(typeof(IEventRoundStart), new RoundStartEventHandler(), Priority.Highest);
			// Register Commands
			this.AddCommand("hello", new HelloWorldCommand(this));
		}
	}
}
