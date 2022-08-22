public class GodRaysRenderer : PostProcessEffectRenderer<GodRays> // TypeDefIndex: 10261
{	// Fields
	private const int PASS_SCREEN = 0;
	private const int PASS_ADD = 1;
	public Shader GodRayShader; // 0x20
	public Shader ScreenClearShader; // 0x28
	public Shader SkyMaskShader; // 0x30

	// Methods

	// RVA: 0xCA35F0 Offset: 0xCA1BF0 VA: 0x180CA35F0 Slot: 4
	public override void Init() { }

	// RVA: 0xCA2830 Offset: 0xCA0E30 VA: 0x180CA2830
	private void DrawBorder(PostProcessRenderContext context, RenderTargetIdentifier buffer1) { }

	// RVA: 0xCA2CC0 Offset: 0xCA12C0 VA: 0x180CA2CC0
	private int GetSkyMask(PostProcessRenderContext context, ResolutionType resolution, Vector3 lightPos, int blurIterations, float blurRadius, float maxRadius) { }

	// RVA: 0xCA3720 Offset: 0xCA1D20 VA: 0x180CA3720 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0xCA3BF0 Offset: 0xCA21F0 VA: 0x180CA3BF0
	public void .ctor() { }

}

