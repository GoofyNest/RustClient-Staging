public class ImpostorAsset : ScriptableObject // TypeDefIndex: 10678
{	// Fields
	public ImpostorAsset.TextureEntry[] textures; // 0x18
	public Vector2 size; // 0x20
	public Vector2 pivot; // 0x28
	public Mesh mesh; // 0x30

	// Methods

	// RVA: 0x80F7C0 Offset: 0x80DDC0 VA: 0x18080F7C0
	public Texture2D FindTexture(string name) { }

	// RVA: 0x4C3AE0 Offset: 0x4C20E0 VA: 0x1804C3AE0
	public void .ctor() { }

}

public class ImpostorAsset.TextureEntry // TypeDefIndex: 10679
{	// Fields
	public string name; // 0x10
	public Texture2D texture; // 0x18

	// Methods

	// RVA: 0x522CB0 Offset: 0x5212B0 VA: 0x180522CB0
	public void .ctor(string name, Texture2D texture) { }

}

