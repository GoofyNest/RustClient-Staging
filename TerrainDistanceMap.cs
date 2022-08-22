public class TerrainDistanceMap : TerrainMap<byte> // TypeDefIndex: 10398
{	// Fields
	public Texture2D DistanceTexture; // 0x48

	// Methods

	// RVA: 0x1140460 Offset: 0x113EA60 VA: 0x181140460 Slot: 4
	public override void Setup() { }

	// RVA: 0x113FCE0 Offset: 0x113E2E0 VA: 0x18113FCE0
	public void GenerateTextures() { }

	// RVA: 0x866540 Offset: 0x864B40 VA: 0x180866540
	public void ApplyTextures() { }

	// RVA: 0x113FF60 Offset: 0x113E560 VA: 0x18113FF60
	public Vector2i GetDistance(Vector3 worldPos) { }

	// RVA: 0x113FE80 Offset: 0x113E480 VA: 0x18113FE80
	public Vector2i GetDistance(float normX, float normZ) { }

	// RVA: 0x1140150 Offset: 0x113E750 VA: 0x181140150
	public Vector2i GetDistance(int x, int z) { }

	// RVA: 0x11402A0 Offset: 0x113E8A0 VA: 0x1811402A0
	public void SetDistance(int x, int z, Vector2i v) { }

	// RVA: 0x11406B0 Offset: 0x113ECB0 VA: 0x1811406B0
	public void .ctor() { }

}

private sealed class TerrainDistanceMap.<>c__DisplayClass2_0 // TypeDefIndex: 10399
{	// Fields
	public Color32[] cols; // 0x10
	public TerrainDistanceMap <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1155E90 Offset: 0x1154490 VA: 0x181155E90
	internal void <GenerateTextures>b__0(int z) { }

}

