using Dissonance.Engine;
using Dissonance.Engine.Graphics;
using Dissonance.Engine.Input;

namespace ExampleGame.Common.Meta;

public static partial class FramebufferDebugging
{
	/// <summary>
	/// Enables framebuffer debugging whenever the 'F' key is held.
	/// </summary>
	[System, CalledIn<Render>]
	static partial void ControlFramebufferDebugging()
	{
		Rendering.DebugFramebuffers = InputEngine.GetKey(Keys.F);
	}
}
