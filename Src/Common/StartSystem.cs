using Dissonance.Engine;
using Dissonance.Engine.Graphics;
using Dissonance.Engine.IO;
using ExampleGame.Common.Movement;

namespace ExampleGame.Common
{
	/// <summary>
	/// Initializes the game.
	/// </summary>
	public sealed class StartSystem : GameSystem
	{
		protected override void Initialize()
		{
			var cameraEntity = World.CreateEntity();

			cameraEntity.Set(new Camera(fov: 90f));
			cameraEntity.Set(new Transform(-Vector3.UnitZ * 5f));

			for (int i = 0; i < 5; i++) {
				var cube = World.CreateEntity();

				cube.Set(new Transform(Vector3.Zero));
				cube.Set(new Light(Light.LightType.Point, Vector3.Normalize(new Vector3(Rand.Next(1f), Rand.Next(1f), Rand.Next(1f)))));
				cube.Set(new MeshRenderer(PrimitiveMeshes.Cube, Resources.Find<Material>("TestCube")));
				cube.Set(new SineMovement {
					TimeOffset = i / 5f * Mathf.TwoPI
				});
			}
		}
	}
}
