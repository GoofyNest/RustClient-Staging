public class GodRaysRenderer : PostProcessEffectRenderer<GodRays> // TypeDefIndex: 10261
{	// Fields
	private const int PASS_SCREEN = 0;
	private const int PASS_ADD = 1;
	public Shader GodRayShader; // 0x20
	public Shader ScreenClearShader; // 0x28
	public Shader SkyMaskShader; // 0x30

	// Methods

	// RVA: 0xCA3150 Offset: 0xCA1750 VA: 0x180CA3150 Slot: 4
	public override void Init() { }

	// RVA: 0xCA2390 Offset: 0xCA0990 VA: 0x180CA2390
	private void DrawBorder(PostProcessRenderContext context, RenderTargetIdentifier buffer1) { }

	// RVA: 0xCA2820 Offset: 0xCA0E20 VA: 0x180CA2820
	private int GetSkyMask(PostProcessRenderContext context, ResolutionType resolution, Vector3 lightPos, int blurIterations, float blurRadius, float maxRadius) { }

	// RVA: 0xCA3280 Offset: 0xCA1880 VA: 0x180CA3280 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0xCA3750 Offset: 0xCA1D50 VA: 0x180CA3750
	public void .ctor() { }

}

