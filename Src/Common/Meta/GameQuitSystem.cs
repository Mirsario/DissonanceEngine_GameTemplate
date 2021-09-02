using Dissonance.Engine;
using Dissonance.Engine.Graphics;
using Dissonance.Engine.Input;
using Dissonance.Framework.Windowing;
using Dissonance.Framework.Windowing.Input;

namespace ExampleGame.Common.Meta
{
	/// <summary>
	/// Quits the game whenever the escape key is pressed twice. Also controls cursor focus.
	/// </summary>
	public sealed class GameQuitSystem : GameSystem
	{
		protected override void FixedUpdate()
		{
			if (InputEngine.GetMouseButton(MouseButton.Left)) {
				Screen.CursorState = CursorState.Disabled;
			} else if (InputEngine.GetKeyDown(Keys.Escape)) {
				if (Screen.CursorState != CursorState.Normal) {
					Screen.CursorState = CursorState.Normal;
				} else {
					Game.Quit();
				}
			}
		}
	}
}
