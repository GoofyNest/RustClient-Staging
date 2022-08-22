public class FlashbangEffectRenderer : PostProcessEffectRenderer<FlashbangEffect> // TypeDefIndex: 10253
{	// Fields
	public static bool needsCapture; // 0x0
	private Shader flashbangEffectShader; // 0x20
	private RenderTexture screenRT; // 0x28

	// Methods

	// RVA: 0x790900 Offset: 0x78EF00 VA: 0x180790900 Slot: 4
	public override void Init() { }

	// RVA: 0x790970 Offset: 0x78EF70 VA: 0x180790970 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x790950 Offset: 0x78EF50 VA: 0x180790950 Slot: 7
	public override void Release() { }

	// RVA: 0x790790 Offset: 0x78ED90 VA: 0x180790790
	private static void CheckCreateRenderTexture(ref RenderTexture rt, string name, int width, int height, RenderTextureFormat format) { }

	// RVA: 0x790E70 Offset: 0x78F470 VA: 0x180790E70
	private static void SafeDestroyRenderTexture(ref RenderTexture rt) { }

	// RVA: 0x790F30 Offset: 0x78F530 VA: 0x180790F30
	public void .ctor() { }

}

