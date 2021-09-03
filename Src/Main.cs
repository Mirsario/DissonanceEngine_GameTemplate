using Dissonance.Engine;
using Dissonance.Engine.Graphics;

namespace ExampleGame
{
	public class Main : Game
	{
		public override void PreInit()
		{
			DisplayName = "Example Game";

			// DeferredRendering is currently the recommended rendering pipeline for 3D games with lighting.
			// You may want to use ForwardRendering if you're making a 2D game, or make your own custom rendering pipeline.
			// Note that shaders made for a specific pipeline are likely to misbehave in others.
			Rendering.SetRenderingPipeline<DeferredRendering>();
		}
	}
}