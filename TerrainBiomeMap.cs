public class TerrainBiomeMap : TerrainMap<byte> // TypeDefIndex: 10393
{	// Fields
	public Texture2D BiomeTexture; // 0x48
	internal int num; // 0x50

	// Methods

	// RVA: 0x113B070 Offset: 0x1139670 VA: 0x18113B070 Slot: 4
	public override void Setup() { }

	// RVA: 0x1139290 Offset: 0x1137890 VA: 0x181139290
	public void GenerateTextures() { }

	// RVA: 0x1136910 Offset: 0x1134F10 VA: 0x181136910
	public void ApplyTextures() { }

	// RVA: 0x1139C80 Offset: 0x1138280 VA: 0x181139C80
	public float GetBiomeMax(Vector3 worldPos, int mask = -1) { }

	// RVA: 0x1139B60 Offset: 0x1138160 VA: 0x181139B60
	public float GetBiomeMax(float normX, float normZ, int mask = -1) { }

	// RVA: 0x1139A70 Offset: 0x1138070 VA: 0x181139A70
	public float GetBiomeMax(int x, int z, int mask = -1) { }

	// RVA: 0x1139530 Offset: 0x1137B30 VA: 0x181139530
	public int GetBiomeMaxIndex(Vector3 worldPos, int mask = -1) { }

	// RVA: 0x11396C0 Offset: 0x1137CC0 VA: 0x1811396C0
	public int GetBiomeMaxIndex(float normX, float normZ, int mask = -1) { }

	// RVA: 0x1139430 Offset: 0x1137A30 VA: 0x181139430
	public int GetBiomeMaxIndex(int x, int z, int mask = -1) { }

	// RVA: 0x11397F0 Offset: 0x1137DF0 VA: 0x1811397F0
	public int GetBiomeMaxType(Vector3 worldPos, int mask = -1) { }

	// RVA: 0x1139720 Offset: 0x1137D20 VA: 0x181139720
	public int GetBiomeMaxType(float normX, float normZ, int mask = -1) { }

	// RVA: 0x11399E0 Offset: 0x1137FE0 VA: 0x1811399E0
	public int GetBiomeMaxType(int x, int z, int mask = -1) { }

	// RVA: 0x113A0E0 Offset: 0x11386E0 VA: 0x18113A0E0
	public float GetBiome(Vector3 worldPos, int mask) { }

	// RVA: 0x113A080 Offset: 0x1138680 VA: 0x18113A080
	public float GetBiome(float normX, float normZ, int mask) { }

	// RVA: 0x1139EC0 Offset: 0x11384C0 VA: 0x181139EC0
	public float GetBiome(int x, int z, int mask) { }

	// RVA: 0x113A980 Offset: 0x1138F80 VA: 0x18113A980
	public void SetBiome(Vector3 worldPos, int id) { }

	// RVA: 0x113A730 Offset: 0x1138D30 VA: 0x18113A730
	public void SetBiome(float normX, float normZ, int id) { }

	// RVA: 0x113A870 Offset: 0x1138E70 VA: 0x18113A870
	public void SetBiome(int x, int z, int id) { }

	// RVA: 0x113AD80 Offset: 0x1139380 VA: 0x18113AD80
	public void SetBiome(Vector3 worldPos, int id, float v) { }

	// RVA: 0x113AF50 Offset: 0x1139550 VA: 0x18113AF50
	public void SetBiome(float normX, float normZ, int id, float v) { }

	// RVA: 0x113B000 Offset: 0x1139600 VA: 0x18113B000
	public void SetBiome(int x, int z, int id, float v) { }

	// RVA: 0x113A270 Offset: 0x1138870 VA: 0x18113A270
	public void SetBiomeRaw(int x, int z, Vector4 v, float opacity) { }

	// RVA: 0x113ABD0 Offset: 0x11391D0 VA: 0x18113ABD0
	private void SetBiome(int x, int z, int id, float old_val, float new_val) { }

	// RVA: 0x113B3D0 Offset: 0x11399D0 VA: 0x18113B3D0
	public void .ctor() { }

}

private sealed class TerrainBiomeMap.<>c__DisplayClass3_0 // TypeDefIndex: 10394
{	// Fields
	public TerrainBiomeMap <>4__this; // 0x10
	public Color32[] col; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x11554E0 Offset: 0x1153AE0 VA: 0x1811554E0
	internal void <GenerateTextures>b__0(int z) { }

}

