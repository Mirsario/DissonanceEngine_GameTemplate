using System;

namespace ExampleGame;

public static class Program
{
	public static void Main(string[] args)
	{
#if SYSTEM_DEBUG
		typeof(SystemDebugging.Communication).ToString();
#endif

		// Run the game
		using var main = new Main();

		main.Run(args: args);
	}
}

