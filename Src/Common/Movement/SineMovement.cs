using System;
using Dissonance.Engine;

namespace ExampleGame.Common.Movement;

public struct SineMovement
{
	public Vector3? StartPosition;
	public float TimeOffset;
	public float TranslationIntensity = 1f;
	public float RotationIntensity = 10f;

	public SineMovement() { }
}

internal static partial class SineMovementImplementation
{
	[EntitySystem, CalledIn<FixedUpdate>]
	static partial void HandleSineMovement(ref SineMovement sineMovement, ref Transform transform)
	{
		float time = Time.RenderGameTime + sineMovement.TimeOffset;

		sineMovement.StartPosition ??= transform.Position;

		var offset = new Vector3(
			MathF.Sin(time),
			MathF.Sin(time * 0.5f),
			MathF.Cos(time * 0.25f)
		);

		transform.Position = sineMovement.StartPosition.Value + offset * sineMovement.TranslationIntensity;
		transform.EulerRot = offset * sineMovement.RotationIntensity;
	}
}
