public class TerrainDistanceMap : TerrainMap<byte> // TypeDefIndex: 10398
{	// Fields
	public Texture2D DistanceTexture; // 0x48

	// Methods

	// RVA: 0x113F9F0 Offset: 0x113DFF0 VA: 0x18113F9F0 Slot: 4
	public override void Setup() { }

	// RVA: 0x113F270 Offset: 0x113D870 VA: 0x18113F270
	public void GenerateTextures() { }

	// RVA: 0x883200 Offset: 0x881800 VA: 0x180883200
	public void ApplyTextures() { }

	// RVA: 0x113F4F0 Offset: 0x113DAF0 VA: 0x18113F4F0
	public Vector2i GetDistance(Vector3 worldPos) { }

	// RVA: 0x113F410 Offset: 0x113DA10 VA: 0x18113F410
	public Vector2i GetDistance(float normX, float normZ) { }

	// RVA: 0x113F6E0 Offset: 0x113DCE0 VA: 0x18113F6E0
	public Vector2i GetDistance(int x, int z) { }

	// RVA: 0x113F830 Offset: 0x113DE30 VA: 0x18113F830
	public void SetDistance(int x, int z, Vector2i v) { }

	// RVA: 0x113FC40 Offset: 0x113E240 VA: 0x18113FC40
	public void .ctor() { }

}

private sealed class TerrainDistanceMap.<>c__DisplayClass2_0 // TypeDefIndex: 10399
{	// Fields
	public Color32[] cols; // 0x10
	public TerrainDistanceMap <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1155420 Offset: 0x1153A20 VA: 0x181155420
	internal void <GenerateTextures>b__0(int z) { }

}

