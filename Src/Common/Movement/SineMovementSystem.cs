using System;
using Dissonance.Engine;
using ExampleGame.Common.Movement;

namespace ExampleGame.Systems
{
	[Callback<FixedUpdateCallback>]
	public sealed partial class SineMovementSystem : GameSystem
	{
		[EntitySubsystem]
		private partial void UpdateEntities(ref SineMovement sineMovement, ref Transform transform)
		{
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
