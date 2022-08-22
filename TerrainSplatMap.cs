public class TerrainSplatMap : TerrainMap<byte> // TypeDefIndex: 10413
{	// Fields
	public Texture2D SplatTexture0; // 0x48
	public Texture2D SplatTexture1; // 0x50
	internal int num; // 0x58

	// Methods

	// RVA: 0x1154A30 Offset: 0x1153030 VA: 0x181154A30 Slot: 4
	public override void Setup() { }

	// RVA: 0x1152420 Offset: 0x1150A20 VA: 0x181152420
	public void GenerateTextures() { }

	// RVA: 0x11523D0 Offset: 0x11509D0 VA: 0x1811523D0
	public void ApplyTextures() { }

	// RVA: 0x1152CE0 Offset: 0x11512E0 VA: 0x181152CE0
	public float GetSplatMax(Vector3 worldPos, int mask = -1) { }

	// RVA: 0x1152BC0 Offset: 0x11511C0 VA: 0x181152BC0
	public float GetSplatMax(float normX, float normZ, int mask = -1) { }

	// RVA: 0x1152F20 Offset: 0x1151520 VA: 0x181152F20
	public float GetSplatMax(int x, int z, int mask = -1) { }

	// RVA: 0x1152840 Offset: 0x1150E40 VA: 0x181152840
	public int GetSplatMaxIndex(Vector3 worldPos, int mask = -1) { }

	// RVA: 0x11527E0 Offset: 0x1150DE0 VA: 0x1811527E0
	public int GetSplatMaxIndex(float normX, float normZ, int mask = -1) { }

	// RVA: 0x11526E0 Offset: 0x1150CE0 VA: 0x1811526E0
	public int GetSplatMaxIndex(int x, int z, int mask = -1) { }

	// RVA: 0x1152AA0 Offset: 0x11510A0 VA: 0x181152AA0
	public int GetSplatMaxType(Vector3 worldPos, int mask = -1) { }

	// RVA: 0x11529D0 Offset: 0x1150FD0 VA: 0x1811529D0
	public int GetSplatMaxType(float normX, float normZ, int mask = -1) { }

	// RVA: 0x1152B30 Offset: 0x1151130 VA: 0x181152B30
	public int GetSplatMaxType(int x, int z, int mask = -1) { }

	// RVA: 0x1153010 Offset: 0x1151610 VA: 0x181153010
	public float GetSplat(Vector3 worldPos, int mask) { }

	// RVA: 0x1153170 Offset: 0x1151770 VA: 0x181153170
	public float GetSplat(float normX, float normZ, int mask) { }

	// RVA: 0x1153330 Offset: 0x1151930 VA: 0x181153330
	public float GetSplat(int x, int z, int mask) { }

	// RVA: 0x11547E0 Offset: 0x1152DE0 VA: 0x1811547E0
	public void SetSplat(Vector3 worldPos, int id) { }

	// RVA: 0x11540C0 Offset: 0x11526C0 VA: 0x1811540C0
	public void SetSplat(float normX, float normZ, int id) { }

	// RVA: 0x1153FB0 Offset: 0x11525B0 VA: 0x181153FB0
	public void SetSplat(int x, int z, int id) { }

	// RVA: 0x1153DE0 Offset: 0x11523E0 VA: 0x181153DE0
	public void SetSplat(Vector3 worldPos, int id, float v) { }

	// RVA: 0x1154450 Offset: 0x1152A50 VA: 0x181154450
	public void SetSplat(float normX, float normZ, int id, float v) { }

	// RVA: 0x1153D70 Offset: 0x1152370 VA: 0x181153D70
	public void SetSplat(int x, int z, int id, float v) { }

	// RVA: 0x11534F0 Offset: 0x1151AF0 VA: 0x1811534F0
	public void SetSplatRaw(int x, int z, Vector4 v1, Vector4 v2, float opacity) { }

	// RVA: 0x1154200 Offset: 0x1152800 VA: 0x181154200
	public void SetSplat(Vector3 worldPos, int id, float opacity, float radius, float fade = 0) { }

	// RVA: 0x1154500 Offset: 0x1152B00 VA: 0x181154500
	public void SetSplat(float normX, float normZ, int id, float opacity, float radius, float fade = 0) { }

	// RVA: 0x1152050 Offset: 0x1150650 VA: 0x181152050
	public void AddSplat(Vector3 worldPos, int id, float delta, float radius, float fade = 0) { }

	// RVA: 0x11522A0 Offset: 0x11508A0 VA: 0x1811522A0
	public void AddSplat(float normX, float normZ, int id, float delta, float radius, float fade = 0) { }

	// RVA: 0x1154630 Offset: 0x1152C30 VA: 0x181154630
	private void SetSplat(int x, int z, int id, float old_val, float new_val) { }

	// RVA: 0x1155060 Offset: 0x1153660 VA: 0x181155060
	public void .ctor() { }

}

private sealed class TerrainSplatMap.<>c__DisplayClass4_0 // TypeDefIndex: 10414
{	// Fields
	public Color32[] cols; // 0x10
	public TerrainSplatMap <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x890140 Offset: 0x88E740 VA: 0x180890140
	internal void <GenerateTextures>b__0(int z) { }

}

private sealed class TerrainSplatMap.<>c__DisplayClass4_1 // TypeDefIndex: 10415
{	// Fields
	public Color32[] cols; // 0x10
	public TerrainSplatMap <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x890350 Offset: 0x88E950 VA: 0x180890350
	internal void <GenerateTextures>b__1(int z) { }

}

private sealed class TerrainSplatMap.<>c__DisplayClass26_0 // TypeDefIndex: 10416
{	// Fields
	public TerrainSplatMap <>4__this; // 0x10
	public int idx; // 0x18
	public float opacity; // 0x1C
	public int id; // 0x20

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x88F540 Offset: 0x88DB40 VA: 0x18088F540
	internal void <SetSplat>b__0(int x, int z, float lerp) { }

}

private sealed class TerrainSplatMap.<>c__DisplayClass28_0 // TypeDefIndex: 10417
{	// Fields
	public TerrainSplatMap <>4__this; // 0x10
	public int idx; // 0x18
	public float delta; // 0x1C
	public int id; // 0x20

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x88FE60 Offset: 0x88E460 VA: 0x18088FE60
	internal void <AddSplat>b__0(int x, int z, float lerp) { }

}

