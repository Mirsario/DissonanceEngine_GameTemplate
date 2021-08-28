using Dissonance.Engine;
using ExampleGame.Common.Movement;

namespace ExampleGame.Systems
{
	[Reads(typeof(SineMovement))]
	[Writes(typeof(Transform))]
	public sealed class SineMovementSystem : GameSystem
	{
		private EntitySet entities;

		protected override void Initialize()
		{
			entities = World.GetEntitySet(e => e.Has<SineMovement>() && e.Has<Transform>());
		}

		protected override void FixedUpdate()
		{
			foreach (var entity in entities.ReadEntities()) {
				ref var sineMovement = ref entity.Get<SineMovement>();
				ref var transform = ref entity.Get<Transform>();

				float time = Time.RenderGameTime + sineMovement.TimeOffset;

				sineMovement.StartPosition ??= transform.Position;

				transform.Position = sineMovement.StartPosition.Value + new Vector3(Mathf.Sin(time * 2f), Mathf.Sin(time), Mathf.Cos(time * 0.5f));
				transform.EulerRot = new Vector3(
					Mathf.Sin(time * 2f),
					Mathf.Sin(time),
					Mathf.Cos(time * 0.5f)
				) * 20f;
			}
		}
	}
}
