public class TerrainSplatMap : TerrainMap<byte> // TypeDefIndex: 10413
{	// Fields
	public Texture2D SplatTexture0; // 0x48
	public Texture2D SplatTexture1; // 0x50
	internal int num; // 0x58

	// Methods

	// RVA: 0x11554A0 Offset: 0x1153AA0 VA: 0x1811554A0 Slot: 4
	public override void Setup() { }

	// RVA: 0x1152E90 Offset: 0x1151490 VA: 0x181152E90
	public void GenerateTextures() { }

	// RVA: 0x1152E40 Offset: 0x1151440 VA: 0x181152E40
	public void ApplyTextures() { }

	// RVA: 0x1153750 Offset: 0x1151D50 VA: 0x181153750
	public float GetSplatMax(Vector3 worldPos, int mask = -1) { }

	// RVA: 0x1153630 Offset: 0x1151C30 VA: 0x181153630
	public float GetSplatMax(float normX, float normZ, int mask = -1) { }

	// RVA: 0x1153990 Offset: 0x1151F90 VA: 0x181153990
	public float GetSplatMax(int x, int z, int mask = -1) { }

	// RVA: 0x11532B0 Offset: 0x11518B0 VA: 0x1811532B0
	public int GetSplatMaxIndex(Vector3 worldPos, int mask = -1) { }

	// RVA: 0x1153250 Offset: 0x1151850 VA: 0x181153250
	public int GetSplatMaxIndex(float normX, float normZ, int mask = -1) { }

	// RVA: 0x1153150 Offset: 0x1151750 VA: 0x181153150
	public int GetSplatMaxIndex(int x, int z, int mask = -1) { }

	// RVA: 0x1153510 Offset: 0x1151B10 VA: 0x181153510
	public int GetSplatMaxType(Vector3 worldPos, int mask = -1) { }

	// RVA: 0x1153440 Offset: 0x1151A40 VA: 0x181153440
	public int GetSplatMaxType(float normX, float normZ, int mask = -1) { }

	// RVA: 0x11535A0 Offset: 0x1151BA0 VA: 0x1811535A0
	public int GetSplatMaxType(int x, int z, int mask = -1) { }

	// RVA: 0x1153A80 Offset: 0x1152080 VA: 0x181153A80
	public float GetSplat(Vector3 worldPos, int mask) { }

	// RVA: 0x1153BE0 Offset: 0x11521E0 VA: 0x181153BE0
	public float GetSplat(float normX, float normZ, int mask) { }

	// RVA: 0x1153DA0 Offset: 0x11523A0 VA: 0x181153DA0
	public float GetSplat(int x, int z, int mask) { }

	// RVA: 0x1155250 Offset: 0x1153850 VA: 0x181155250
	public void SetSplat(Vector3 worldPos, int id) { }

	// RVA: 0x1154B30 Offset: 0x1153130 VA: 0x181154B30
	public void SetSplat(float normX, float normZ, int id) { }

	// RVA: 0x1154A20 Offset: 0x1153020 VA: 0x181154A20
	public void SetSplat(int x, int z, int id) { }

	// RVA: 0x1154850 Offset: 0x1152E50 VA: 0x181154850
	public void SetSplat(Vector3 worldPos, int id, float v) { }

	// RVA: 0x1154EC0 Offset: 0x11534C0 VA: 0x181154EC0
	public void SetSplat(float normX, float normZ, int id, float v) { }

	// RVA: 0x11547E0 Offset: 0x1152DE0 VA: 0x1811547E0
	public void SetSplat(int x, int z, int id, float v) { }

	// RVA: 0x1153F60 Offset: 0x1152560 VA: 0x181153F60
	public void SetSplatRaw(int x, int z, Vector4 v1, Vector4 v2, float opacity) { }

	// RVA: 0x1154C70 Offset: 0x1153270 VA: 0x181154C70
	public void SetSplat(Vector3 worldPos, int id, float opacity, float radius, float fade = 0) { }

	// RVA: 0x1154F70 Offset: 0x1153570 VA: 0x181154F70
	public void SetSplat(float normX, float normZ, int id, float opacity, float radius, float fade = 0) { }

	// RVA: 0x1152AC0 Offset: 0x11510C0 VA: 0x181152AC0
	public void AddSplat(Vector3 worldPos, int id, float delta, float radius, float fade = 0) { }

	// RVA: 0x1152D10 Offset: 0x1151310 VA: 0x181152D10
	public void AddSplat(float normX, float normZ, int id, float delta, float radius, float fade = 0) { }

	// RVA: 0x11550A0 Offset: 0x11536A0 VA: 0x1811550A0
	private void SetSplat(int x, int z, int id, float old_val, float new_val) { }

	// RVA: 0x1155AD0 Offset: 0x11540D0 VA: 0x181155AD0
	public void .ctor() { }

}

private sealed class TerrainSplatMap.<>c__DisplayClass4_0 // TypeDefIndex: 10414
{	// Fields
	public Color32[] cols; // 0x10
	public TerrainSplatMap <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x873480 Offset: 0x871A80 VA: 0x180873480
	internal void <GenerateTextures>b__0(int z) { }

}

private sealed class TerrainSplatMap.<>c__DisplayClass4_1 // TypeDefIndex: 10415
{	// Fields
	public Color32[] cols; // 0x10
	public TerrainSplatMap <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x873690 Offset: 0x871C90 VA: 0x180873690
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

	// RVA: 0x872880 Offset: 0x870E80 VA: 0x180872880
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

	// RVA: 0x8731A0 Offset: 0x8717A0 VA: 0x1808731A0
	internal void <AddSplat>b__0(int x, int z, float lerp) { }

}

