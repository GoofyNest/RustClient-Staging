public class ProcessedTexture // TypeDefIndex: 11364
{	// Fields
	protected RenderTexture result; // 0x10
	protected Material material; // 0x18

	// Methods

	// RVA: 0x691DD0 Offset: 0x6903D0 VA: 0x180691DD0
	public void Dispose() { }

	// RVA: 0x691AB0 Offset: 0x6900B0 VA: 0x180691AB0
	protected RenderTexture CreateRenderTexture(string name, int width, int height, bool linear) { }

	// RVA: 0x691D20 Offset: 0x690320 VA: 0x180691D20
	protected void DestroyRenderTexture(ref RenderTexture rt) { }

	// RVA: 0x691B90 Offset: 0x690190 VA: 0x180691B90
	protected RenderTexture CreateTemporary() { }

	// RVA: 0x691F10 Offset: 0x690510 VA: 0x180691F10
	protected void ReleaseTemporary(RenderTexture rt) { }

	// RVA: 0x6919C0 Offset: 0x68FFC0 VA: 0x1806919C0
	protected Material CreateMaterial(string shader) { }

	// RVA: 0x691A40 Offset: 0x690040 VA: 0x180691A40
	protected Material CreateMaterial(Shader shader) { }

	// RVA: 0x691C70 Offset: 0x690270 VA: 0x180691C70
	protected void DestroyMaterial(ref Material mat) { }

	// RVA: 0x691F20 Offset: 0x690520 VA: 0x180691F20
	public static Texture op_Implicit(ProcessedTexture t) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

