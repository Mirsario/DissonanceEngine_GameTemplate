using Dissonance.Engine;
using Dissonance.Engine.Graphics;
using Dissonance.Engine.Input;
using Dissonance.Framework.Windowing.Input;

namespace ExampleGame.Common.Meta
{
	/// <summary>
	/// Enables framebuffer debugging whenever the 'F' key is held.
	/// </summary>
	[Callback<RenderUpdateCallback>]
	public sealed class FramebufferDebugSystem : GameSystem
	{
		protected override void Execute()
		{
			Rendering.DebugFramebuffers = InputEngine.GetKey(Keys.F);
		}
	}
}
