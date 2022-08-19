public class ProcessedTexture // TypeDefIndex: 11364
{	// Fields
	protected RenderTexture result; // 0x10
	protected Material material; // 0x18

	// Methods

	// RVA: 0x691CC0 Offset: 0x6902C0 VA: 0x180691CC0
	public void Dispose() { }

	// RVA: 0x6919A0 Offset: 0x68FFA0 VA: 0x1806919A0
	protected RenderTexture CreateRenderTexture(string name, int width, int height, bool linear) { }

	// RVA: 0x691C10 Offset: 0x690210 VA: 0x180691C10
	protected void DestroyRenderTexture(ref RenderTexture rt) { }

	// RVA: 0x691A80 Offset: 0x690080 VA: 0x180691A80
	protected RenderTexture CreateTemporary() { }

	// RVA: 0x691E00 Offset: 0x690400 VA: 0x180691E00
	protected void ReleaseTemporary(RenderTexture rt) { }

	// RVA: 0x6918B0 Offset: 0x68FEB0 VA: 0x1806918B0
	protected Material CreateMaterial(string shader) { }

	// RVA: 0x691930 Offset: 0x68FF30 VA: 0x180691930
	protected Material CreateMaterial(Shader shader) { }

	// RVA: 0x691B60 Offset: 0x690160 VA: 0x180691B60
	protected void DestroyMaterial(ref Material mat) { }

	// RVA: 0x691E10 Offset: 0x690410 VA: 0x180691E10
	public static Texture op_Implicit(ProcessedTexture t) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

