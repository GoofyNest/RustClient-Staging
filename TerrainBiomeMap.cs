public class TerrainBiomeMap : TerrainMap<byte> // TypeDefIndex: 10393
{	// Fields
	public Texture2D BiomeTexture; // 0x48
	internal int num; // 0x50

	// Methods

	// RVA: 0x113BAE0 Offset: 0x113A0E0 VA: 0x18113BAE0 Slot: 4
	public override void Setup() { }

	// RVA: 0x1139D00 Offset: 0x1138300 VA: 0x181139D00
	public void GenerateTextures() { }

	// RVA: 0x1137380 Offset: 0x1135980 VA: 0x181137380
	public void ApplyTextures() { }

	// RVA: 0x113A6F0 Offset: 0x1138CF0 VA: 0x18113A6F0
	public float GetBiomeMax(Vector3 worldPos, int mask = -1) { }

	// RVA: 0x113A5D0 Offset: 0x1138BD0 VA: 0x18113A5D0
	public float GetBiomeMax(float normX, float normZ, int mask = -1) { }

	// RVA: 0x113A4E0 Offset: 0x1138AE0 VA: 0x18113A4E0
	public float GetBiomeMax(int x, int z, int mask = -1) { }

	// RVA: 0x1139FA0 Offset: 0x11385A0 VA: 0x181139FA0
	public int GetBiomeMaxIndex(Vector3 worldPos, int mask = -1) { }

	// RVA: 0x113A130 Offset: 0x1138730 VA: 0x18113A130
	public int GetBiomeMaxIndex(float normX, float normZ, int mask = -1) { }

	// RVA: 0x1139EA0 Offset: 0x11384A0 VA: 0x181139EA0
	public int GetBiomeMaxIndex(int x, int z, int mask = -1) { }

	// RVA: 0x113A260 Offset: 0x1138860 VA: 0x18113A260
	public int GetBiomeMaxType(Vector3 worldPos, int mask = -1) { }

	// RVA: 0x113A190 Offset: 0x1138790 VA: 0x18113A190
	public int GetBiomeMaxType(float normX, float normZ, int mask = -1) { }

	// RVA: 0x113A450 Offset: 0x1138A50 VA: 0x18113A450
	public int GetBiomeMaxType(int x, int z, int mask = -1) { }

	// RVA: 0x113AB50 Offset: 0x1139150 VA: 0x18113AB50
	public float GetBiome(Vector3 worldPos, int mask) { }

	// RVA: 0x113AAF0 Offset: 0x11390F0 VA: 0x18113AAF0
	public float GetBiome(float normX, float normZ, int mask) { }

	// RVA: 0x113A930 Offset: 0x1138F30 VA: 0x18113A930
	public float GetBiome(int x, int z, int mask) { }

	// RVA: 0x113B3F0 Offset: 0x11399F0 VA: 0x18113B3F0
	public void SetBiome(Vector3 worldPos, int id) { }

	// RVA: 0x113B1A0 Offset: 0x11397A0 VA: 0x18113B1A0
	public void SetBiome(float normX, float normZ, int id) { }

	// RVA: 0x113B2E0 Offset: 0x11398E0 VA: 0x18113B2E0
	public void SetBiome(int x, int z, int id) { }

	// RVA: 0x113B7F0 Offset: 0x1139DF0 VA: 0x18113B7F0
	public void SetBiome(Vector3 worldPos, int id, float v) { }

	// RVA: 0x113B9C0 Offset: 0x1139FC0 VA: 0x18113B9C0
	public void SetBiome(float normX, float normZ, int id, float v) { }

	// RVA: 0x113BA70 Offset: 0x113A070 VA: 0x18113BA70
	public void SetBiome(int x, int z, int id, float v) { }

	// RVA: 0x113ACE0 Offset: 0x11392E0 VA: 0x18113ACE0
	public void SetBiomeRaw(int x, int z, Vector4 v, float opacity) { }

	// RVA: 0x113B640 Offset: 0x1139C40 VA: 0x18113B640
	private void SetBiome(int x, int z, int id, float old_val, float new_val) { }

	// RVA: 0x113BE40 Offset: 0x113A440 VA: 0x18113BE40
	public void .ctor() { }

}

private sealed class TerrainBiomeMap.<>c__DisplayClass3_0 // TypeDefIndex: 10394
{	// Fields
	public TerrainBiomeMap <>4__this; // 0x10
	public Color32[] col; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1155F50 Offset: 0x1154550 VA: 0x181155F50
	internal void <GenerateTextures>b__0(int z) { }

}

