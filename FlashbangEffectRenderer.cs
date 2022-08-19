public class FlashbangEffectRenderer : PostProcessEffectRenderer<FlashbangEffect> // TypeDefIndex: 10253
{	// Fields
	public static bool needsCapture; // 0x0
	private Shader flashbangEffectShader; // 0x20
	private RenderTexture screenRT; // 0x28

	// Methods

	// RVA: 0x7907F0 Offset: 0x78EDF0 VA: 0x1807907F0 Slot: 4
	public override void Init() { }

	// RVA: 0x790860 Offset: 0x78EE60 VA: 0x180790860 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x790840 Offset: 0x78EE40 VA: 0x180790840 Slot: 7
	public override void Release() { }

	// RVA: 0x790680 Offset: 0x78EC80 VA: 0x180790680
	private static void CheckCreateRenderTexture(ref RenderTexture rt, string name, int width, int height, RenderTextureFormat format) { }

	// RVA: 0x790D60 Offset: 0x78F360 VA: 0x180790D60
	private static void SafeDestroyRenderTexture(ref RenderTexture rt) { }

	// RVA: 0x790E20 Offset: 0x78F420 VA: 0x180790E20
	public void .ctor() { }

}

