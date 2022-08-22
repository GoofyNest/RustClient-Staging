public class ImpostorAsset : ScriptableObject // TypeDefIndex: 10678
{	// Fields
	public ImpostorAsset.TextureEntry[] textures; // 0x18
	public Vector2 size; // 0x20
	public Vector2 pivot; // 0x28
	public Mesh mesh; // 0x30

	// Methods

	// RVA: 0x80FD50 Offset: 0x80E350 VA: 0x18080FD50
	public Texture2D FindTexture(string name) { }

	// RVA: 0x4C3A70 Offset: 0x4C2070 VA: 0x1804C3A70
	public void .ctor() { }

}

public class ImpostorAsset.TextureEntry // TypeDefIndex: 10679
{	// Fields
	public string name; // 0x10
	public Texture2D texture; // 0x18

	// Methods

	// RVA: 0x522C40 Offset: 0x521240 VA: 0x180522C40
	public void .ctor(string name, Texture2D texture) { }

}

