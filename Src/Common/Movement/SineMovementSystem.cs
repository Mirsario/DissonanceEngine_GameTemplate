using System;
using Dissonance.Engine;
using ExampleGame.Common.Movement;

namespace ExampleGame.Systems
{
	[Callback<FixedUpdateCallback>]
	public sealed class SineMovementSystem : GameSystem
	{
		private EntitySet entities;

		protected override void Initialize()
		{
			entities = World.GetEntitySet(e => e.Has<SineMovement>() && e.Has<Transform>());
		}

		protected override void Execute()
		{
			foreach (var entity in entities.ReadEntities()) {
				ref var sineMovement = ref entity.Get<SineMovement>();
				ref var transform = ref entity.Get<Transform>();

				float time = Time.RenderGameTime + sineMovement.TimeOffset;

				sineMovement.StartPosition ??= transform.Position;

				var offset = new Vector3(
					MathF.Sin(time * 2f),
					MathF.Sin(time),
					MathF.Cos(time * 0.5f)
				);

				transform.Position = sineMovement.StartPosition.Value + offset;
				transform.EulerRot = offset * 20f;
			}
		}
	}
}
