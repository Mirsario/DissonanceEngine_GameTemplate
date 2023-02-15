using Dissonance.Engine;
using Dissonance.Engine.Audio;
using ExampleGame.Common.Movement;

namespace ExampleGame.Common;

public static partial class GameStartup
{
	/// <summary>
	/// Initializes the game.
	/// </summary>
	[System, CalledIn<GameInitialization>, Tags("SpawnsEntities")]
	static partial void StartGame()
	{
		var world = WorldManager.DefaultWorld;

		// Create 3 moving boxes
		for (int i = 0; i < 3; i++) {
			float timeOffset = i * 2f;

			world.SendMessage(new SpawnEntityMessage("TestBox", e => {
				e.Get<SineMovement>().TimeOffset = timeOffset;
			}));
		}

		// Create a camera
		world.SendMessage(new SpawnEntityMessage("Camera", e => {
			e.Get<Transform>().Position = new Vector3(0f, 0f, -10f);
		}));
	}
}
