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

			cameraEntity.Set(new Camera {
				FieldOfView = 90
			});
			cameraEntity.Set(new Transform(-Vector3.UnitZ * 5f));

			for (int i = 0; i < 5; i++) {
				var cube = World.CreateEntity();

				cube.Set(new Transform(Vector3.Zero));
				cube.Set(new MeshRenderer(PrimitiveMeshes.Cube, Assets.Get<Material>("Resources/Materials/TestCube.material")));
				cube.Set(new SineMovement {
					TimeOffset = i / 5f * MathHelper.TwoPI
				});
				cube.Set(new Light {
					Color = Vector3.Normalize(new Vector3(Rand.Next(1f), Rand.Next(1f), Rand.Next(1f)))
				});
			}
		}
	}
}
