using Dissonance.Engine;
using Dissonance.Engine.Graphics;
using Dissonance.Engine.Input;

namespace ExampleGame.Common.Meta
{
	/// <summary>
	/// Enables framebuffer debugging whenever the 'F' key is held.
	/// </summary>
	[Callback<RenderUpdateCallback>]
	public sealed partial class FramebufferDebugSystem : GameSystem
	{
		[Subsystem]
		private partial void Update()
        {
			Rendering.DebugFramebuffers = InputEngine.GetKey(Keys.F);
		}
	}
}
