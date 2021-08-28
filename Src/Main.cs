using Dissonance.Engine;
using Dissonance.Engine.Graphics;

namespace ExampleGame
{
	public class Main : Game
	{
		public override void PreInit()
		{
			DisplayName = "Example Game";

			Rendering.SetRenderingPipeline<DeferredRendering>();
		}
	}
}