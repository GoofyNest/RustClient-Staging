internal sealed class MotionBlurRenderer : PostProcessEffectRenderer<MotionBlur> // TypeDefIndex: 11793
{	// Methods

	// RVA: 0x6F35A0 Offset: 0x6F1BA0 VA: 0x1806F35A0 Slot: 5
	public override DepthTextureMode GetCameraFlags() { }

	// RVA: 0x101A4C0 Offset: 0x1018AC0 VA: 0x18101A4C0 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x101B070 Offset: 0x1019670 VA: 0x18101B070
	public void .ctor() { }

}

private enum MotionBlurRenderer.Pass // TypeDefIndex: 11794
{	// Fields
	public int value__; // 0x0
	public const MotionBlurRenderer.Pass VelocitySetup = 0;
	public const MotionBlurRenderer.Pass TileMax1 = 1;
	public const MotionBlurRenderer.Pass TileMax2 = 2;
	public const MotionBlurRenderer.Pass TileMaxV = 3;
	public const MotionBlurRenderer.Pass NeighborMax = 4;
	public const MotionBlurRenderer.Pass Reconstruction = 5;

}

