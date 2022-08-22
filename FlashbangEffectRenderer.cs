public class FlashbangEffectRenderer : PostProcessEffectRenderer<FlashbangEffect> // TypeDefIndex: 10253
{	// Fields
	public static bool needsCapture; // 0x0
	private Shader flashbangEffectShader; // 0x20
	private RenderTexture screenRT; // 0x28

	// Methods

	// RVA: 0x790810 Offset: 0x78EE10 VA: 0x180790810 Slot: 4
	public override void Init() { }

	// RVA: 0x790880 Offset: 0x78EE80 VA: 0x180790880 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x790860 Offset: 0x78EE60 VA: 0x180790860 Slot: 7
	public override void Release() { }

	// RVA: 0x7906A0 Offset: 0x78ECA0 VA: 0x1807906A0
	private static void CheckCreateRenderTexture(ref RenderTexture rt, string name, int width, int height, RenderTextureFormat format) { }

	// RVA: 0x790D80 Offset: 0x78F380 VA: 0x180790D80
	private static void SafeDestroyRenderTexture(ref RenderTexture rt) { }

	// RVA: 0x790E40 Offset: 0x78F440 VA: 0x180790E40
	public void .ctor() { }

}

