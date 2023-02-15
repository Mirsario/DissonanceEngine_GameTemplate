using Dissonance.Engine;
using Dissonance.Engine.Graphics;
using Dissonance.Engine.Input;

namespace ExampleGame.Common.Meta;

public static partial class GameExiting
{
	/// <summary>
	/// Quits the game whenever the escape key is pressed twice. Optionally controls cursor focus.
	/// </summary>
	[System, CalledIn<FixedUpdate>]
	static partial void CheckForGameExit()
	{
		if (InputEngine.GetMouseButton(MouseButton.Left)) {
			Screen.CursorState = CursorState.Disabled;
			return;
		}

		if (InputEngine.GetKeyDown(Keys.Escape)) {
			if (Screen.CursorState != CursorState.Normal) {
				Screen.CursorState = CursorState.Normal;
			} else {
				Game.Quit();
			}
		}
	}
}
