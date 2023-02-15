using Dissonance.Engine;
using Dissonance.Engine.Graphics;

namespace ExampleGame.Common.Meta;

public static partial class FramerateDisplay
{
	[System, CalledIn<RenderUpdate>]
	static unsafe partial void DisplayFramerate()
	{
		uint logicFps = Time.FixedFramerate;
		uint logicFpsTarget = (uint)Time.TargetUpdateFrequency;
		uint renderFps = Time.RenderFramerate;
		uint renderFpsTarget = (uint)Time.TargetRenderFrequency;

		var windowing = ModuleManagement.GetModule<GlfwWindowing>();

		GlfwApi.GLFW.SetWindowTitle(windowing.WindowHandle, $"{nameof(ExampleGame)} - Logic FPS: {logicFps} / {logicFpsTarget}, Render FPS: {renderFps} / {renderFpsTarget}");
	}
}
