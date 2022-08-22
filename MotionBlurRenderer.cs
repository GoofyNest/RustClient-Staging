internal sealed class MotionBlurRenderer : PostProcessEffectRenderer<MotionBlur> // TypeDefIndex: 11793
{
	public override DepthTextureMode GetCameraFlags() { }

	public override void Render(PostProcessRenderContext context) { }

	public void .ctor() { }

}

private enum MotionBlurRenderer.Pass // TypeDefIndex: 11794
{	public int value__; // 0x0
	public const MotionBlurRenderer.Pass VelocitySetup = 0;
	public const MotionBlurRenderer.Pass TileMax1 = 1;
	public const MotionBlurRenderer.Pass TileMax2 = 2;
	public const MotionBlurRenderer.Pass TileMaxV = 3;
	public const MotionBlurRenderer.Pass NeighborMax = 4;
	public const MotionBlurRenderer.Pass Reconstruction = 5;

}

