internal sealed class MotionBlurRenderer : PostProcessEffectRenderer<MotionBlur> // TypeDefIndex: 13555
{

	public override DepthTextureMode GetCameraFlags() { }

	public override void Render(PostProcessRenderContext context) { }

	public void .ctor() { }

}

private enum MotionBlurRenderer.Pass // TypeDefIndex: 13556
{
	public int value__; 
	public const MotionBlurRenderer.Pass VelocitySetup = 0;
	public const MotionBlurRenderer.Pass TileMax1 = 1;
	public const MotionBlurRenderer.Pass TileMax2 = 2;
	public const MotionBlurRenderer.Pass TileMaxV = 3;
	public const MotionBlurRenderer.Pass NeighborMax = 4;
	public const MotionBlurRenderer.Pass Reconstruction = 5;

}

