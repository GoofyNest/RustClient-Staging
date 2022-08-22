public class ProcessedTexture // TypeDefIndex: 11364
{	// Fields
	protected RenderTexture result; // 0x10
	protected Material material; // 0x18

	// Methods

	// RVA: 0x691D60 Offset: 0x690360 VA: 0x180691D60
	public void Dispose() { }

	// RVA: 0x691A40 Offset: 0x690040 VA: 0x180691A40
	protected RenderTexture CreateRenderTexture(string name, int width, int height, bool linear) { }

	// RVA: 0x691CB0 Offset: 0x6902B0 VA: 0x180691CB0
	protected void DestroyRenderTexture(ref RenderTexture rt) { }

	// RVA: 0x691B20 Offset: 0x690120 VA: 0x180691B20
	protected RenderTexture CreateTemporary() { }

	// RVA: 0x691EA0 Offset: 0x6904A0 VA: 0x180691EA0
	protected void ReleaseTemporary(RenderTexture rt) { }

	// RVA: 0x691950 Offset: 0x68FF50 VA: 0x180691950
	protected Material CreateMaterial(string shader) { }

	// RVA: 0x6919D0 Offset: 0x68FFD0 VA: 0x1806919D0
	protected Material CreateMaterial(Shader shader) { }

	// RVA: 0x691C00 Offset: 0x690200 VA: 0x180691C00
	protected void DestroyMaterial(ref Material mat) { }

	// RVA: 0x691EB0 Offset: 0x6904B0 VA: 0x180691EB0
	public static Texture op_Implicit(ProcessedTexture t) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

