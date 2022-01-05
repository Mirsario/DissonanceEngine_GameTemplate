using Dissonance.Engine;

namespace ExampleGame.Common
{
	/// <summary>
	/// Initializes the game.
	/// </summary>
	[Callback<BeginFixedUpdateCallback>]
	public sealed class StartSystem : GameSystem
	{
		protected override void Initialize()
		{
			SendMessage(new SpawnEntityMessage("Camera", e => {
				e.Get<Transform>().Position = new Vector3(0f, 0f, -5f);
			}));

			SendMessage(new SpawnEntityMessage("TestBox"));
		}
	}
}
