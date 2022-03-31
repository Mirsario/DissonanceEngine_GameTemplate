using Dissonance.Engine;
using Dissonance.Engine.Graphics;
using Dissonance.Engine.Input;

namespace ExampleGame.Common.Meta
{
	/// <summary>
	/// Quits the game whenever the escape key is pressed twice. Optionally controls cursor focus.
	/// </summary>
	[Callback<EndFixedUpdateCallback>]
	public sealed partial class QuitSystem : GameSystem
	{
		[Subsystem]
		private partial void Update()
		{
			/*
			if (InputEngine.GetMouseButton(MouseButton.Left)) {
				Screen.CursorState = CursorState.Disabled;
				return;
			}
			*/

			if (InputEngine.GetKeyDown(Keys.Escape)) {
				if (Screen.CursorState != CursorState.Normal) {
					Screen.CursorState = CursorState.Normal;
				} else {
					Game.Quit();
				}
			}
		}
	}
}
