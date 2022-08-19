public class TerrainBiomeMap : TerrainMap<byte> // TypeDefIndex: 10393
{	// Fields
	public Texture2D BiomeTexture; // 0x48
	internal int num; // 0x50

	// Methods

	// RVA: 0x113ADB0 Offset: 0x11393B0 VA: 0x18113ADB0 Slot: 4
	public override void Setup() { }

	// RVA: 0x1138FD0 Offset: 0x11375D0 VA: 0x181138FD0
	public void GenerateTextures() { }

	// RVA: 0x1136650 Offset: 0x1134C50 VA: 0x181136650
	public void ApplyTextures() { }

	// RVA: 0x11399C0 Offset: 0x1137FC0 VA: 0x1811399C0
	public float GetBiomeMax(Vector3 worldPos, int mask = -1) { }

	// RVA: 0x11398A0 Offset: 0x1137EA0 VA: 0x1811398A0
	public float GetBiomeMax(float normX, float normZ, int mask = -1) { }

	// RVA: 0x11397B0 Offset: 0x1137DB0 VA: 0x1811397B0
	public float GetBiomeMax(int x, int z, int mask = -1) { }

	// RVA: 0x1139270 Offset: 0x1137870 VA: 0x181139270
	public int GetBiomeMaxIndex(Vector3 worldPos, int mask = -1) { }

	// RVA: 0x1139400 Offset: 0x1137A00 VA: 0x181139400
	public int GetBiomeMaxIndex(float normX, float normZ, int mask = -1) { }

	// RVA: 0x1139170 Offset: 0x1137770 VA: 0x181139170
	public int GetBiomeMaxIndex(int x, int z, int mask = -1) { }

	// RVA: 0x1139530 Offset: 0x1137B30 VA: 0x181139530
	public int GetBiomeMaxType(Vector3 worldPos, int mask = -1) { }

	// RVA: 0x1139460 Offset: 0x1137A60 VA: 0x181139460
	public int GetBiomeMaxType(float normX, float normZ, int mask = -1) { }

	// RVA: 0x1139720 Offset: 0x1137D20 VA: 0x181139720
	public int GetBiomeMaxType(int x, int z, int mask = -1) { }

	// RVA: 0x1139E20 Offset: 0x1138420 VA: 0x181139E20
	public float GetBiome(Vector3 worldPos, int mask) { }

	// RVA: 0x1139DC0 Offset: 0x11383C0 VA: 0x181139DC0
	public float GetBiome(float normX, float normZ, int mask) { }

	// RVA: 0x1139C00 Offset: 0x1138200 VA: 0x181139C00
	public float GetBiome(int x, int z, int mask) { }

	// RVA: 0x113A6C0 Offset: 0x1138CC0 VA: 0x18113A6C0
	public void SetBiome(Vector3 worldPos, int id) { }

	// RVA: 0x113A470 Offset: 0x1138A70 VA: 0x18113A470
	public void SetBiome(float normX, float normZ, int id) { }

	// RVA: 0x113A5B0 Offset: 0x1138BB0 VA: 0x18113A5B0
	public void SetBiome(int x, int z, int id) { }

	// RVA: 0x113AAC0 Offset: 0x11390C0 VA: 0x18113AAC0
	public void SetBiome(Vector3 worldPos, int id, float v) { }

	// RVA: 0x113AC90 Offset: 0x1139290 VA: 0x18113AC90
	public void SetBiome(float normX, float normZ, int id, float v) { }

	// RVA: 0x113AD40 Offset: 0x1139340 VA: 0x18113AD40
	public void SetBiome(int x, int z, int id, float v) { }

	// RVA: 0x1139FB0 Offset: 0x11385B0 VA: 0x181139FB0
	public void SetBiomeRaw(int x, int z, Vector4 v, float opacity) { }

	// RVA: 0x113A910 Offset: 0x1138F10 VA: 0x18113A910
	private void SetBiome(int x, int z, int id, float old_val, float new_val) { }

	// RVA: 0x113B110 Offset: 0x1139710 VA: 0x18113B110
	public void .ctor() { }

}

private sealed class TerrainBiomeMap.<>c__DisplayClass3_0 // TypeDefIndex: 10394
{	// Fields
	public TerrainBiomeMap <>4__this; // 0x10
	public Color32[] col; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1155220 Offset: 0x1153820 VA: 0x181155220
	internal void <GenerateTextures>b__0(int z) { }

}

