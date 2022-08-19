public class GodRaysRenderer : PostProcessEffectRenderer<GodRays> // TypeDefIndex: 10261
{	// Fields
	private const int PASS_SCREEN = 0;
	private const int PASS_ADD = 1;
	public Shader GodRayShader; // 0x20
	public Shader ScreenClearShader; // 0x28
	public Shader SkyMaskShader; // 0x30

	// Methods

	// RVA: 0xCA2E90 Offset: 0xCA1490 VA: 0x180CA2E90 Slot: 4
	public override void Init() { }

	// RVA: 0xCA20D0 Offset: 0xCA06D0 VA: 0x180CA20D0
	private void DrawBorder(PostProcessRenderContext context, RenderTargetIdentifier buffer1) { }

	// RVA: 0xCA2560 Offset: 0xCA0B60 VA: 0x180CA2560
	private int GetSkyMask(PostProcessRenderContext context, ResolutionType resolution, Vector3 lightPos, int blurIterations, float blurRadius, float maxRadius) { }

	// RVA: 0xCA2FC0 Offset: 0xCA15C0 VA: 0x180CA2FC0 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0xCA3490 Offset: 0xCA1A90 VA: 0x180CA3490
	public void .ctor() { }

}

