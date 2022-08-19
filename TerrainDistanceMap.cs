public class TerrainDistanceMap : TerrainMap<byte> // TypeDefIndex: 10398
{	// Fields
	public Texture2D DistanceTexture; // 0x48

	// Methods

	// RVA: 0x113F730 Offset: 0x113DD30 VA: 0x18113F730 Slot: 4
	public override void Setup() { }

	// RVA: 0x113EFB0 Offset: 0x113D5B0 VA: 0x18113EFB0
	public void GenerateTextures() { }

	// RVA: 0x8830F0 Offset: 0x8816F0 VA: 0x1808830F0
	public void ApplyTextures() { }

	// RVA: 0x113F230 Offset: 0x113D830 VA: 0x18113F230
	public Vector2i GetDistance(Vector3 worldPos) { }

	// RVA: 0x113F150 Offset: 0x113D750 VA: 0x18113F150
	public Vector2i GetDistance(float normX, float normZ) { }

	// RVA: 0x113F420 Offset: 0x113DA20 VA: 0x18113F420
	public Vector2i GetDistance(int x, int z) { }

	// RVA: 0x113F570 Offset: 0x113DB70 VA: 0x18113F570
	public void SetDistance(int x, int z, Vector2i v) { }

	// RVA: 0x113F980 Offset: 0x113DF80 VA: 0x18113F980
	public void .ctor() { }

}

private sealed class TerrainDistanceMap.<>c__DisplayClass2_0 // TypeDefIndex: 10399
{	// Fields
	public Color32[] cols; // 0x10
	public TerrainDistanceMap <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1155160 Offset: 0x1153760 VA: 0x181155160
	internal void <GenerateTextures>b__0(int z) { }

}

