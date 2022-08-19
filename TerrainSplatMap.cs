public class TerrainSplatMap : TerrainMap<byte> // TypeDefIndex: 10413
{	// Fields
	public Texture2D SplatTexture0; // 0x48
	public Texture2D SplatTexture1; // 0x50
	internal int num; // 0x58

	// Methods

	// RVA: 0x1154770 Offset: 0x1152D70 VA: 0x181154770 Slot: 4
	public override void Setup() { }

	// RVA: 0x1152160 Offset: 0x1150760 VA: 0x181152160
	public void GenerateTextures() { }

	// RVA: 0x1152110 Offset: 0x1150710 VA: 0x181152110
	public void ApplyTextures() { }

	// RVA: 0x1152A20 Offset: 0x1151020 VA: 0x181152A20
	public float GetSplatMax(Vector3 worldPos, int mask = -1) { }

	// RVA: 0x1152900 Offset: 0x1150F00 VA: 0x181152900
	public float GetSplatMax(float normX, float normZ, int mask = -1) { }

	// RVA: 0x1152C60 Offset: 0x1151260 VA: 0x181152C60
	public float GetSplatMax(int x, int z, int mask = -1) { }

	// RVA: 0x1152580 Offset: 0x1150B80 VA: 0x181152580
	public int GetSplatMaxIndex(Vector3 worldPos, int mask = -1) { }

	// RVA: 0x1152520 Offset: 0x1150B20 VA: 0x181152520
	public int GetSplatMaxIndex(float normX, float normZ, int mask = -1) { }

	// RVA: 0x1152420 Offset: 0x1150A20 VA: 0x181152420
	public int GetSplatMaxIndex(int x, int z, int mask = -1) { }

	// RVA: 0x11527E0 Offset: 0x1150DE0 VA: 0x1811527E0
	public int GetSplatMaxType(Vector3 worldPos, int mask = -1) { }

	// RVA: 0x1152710 Offset: 0x1150D10 VA: 0x181152710
	public int GetSplatMaxType(float normX, float normZ, int mask = -1) { }

	// RVA: 0x1152870 Offset: 0x1150E70 VA: 0x181152870
	public int GetSplatMaxType(int x, int z, int mask = -1) { }

	// RVA: 0x1152D50 Offset: 0x1151350 VA: 0x181152D50
	public float GetSplat(Vector3 worldPos, int mask) { }

	// RVA: 0x1152EB0 Offset: 0x11514B0 VA: 0x181152EB0
	public float GetSplat(float normX, float normZ, int mask) { }

	// RVA: 0x1153070 Offset: 0x1151670 VA: 0x181153070
	public float GetSplat(int x, int z, int mask) { }

	// RVA: 0x1154520 Offset: 0x1152B20 VA: 0x181154520
	public void SetSplat(Vector3 worldPos, int id) { }

	// RVA: 0x1153E00 Offset: 0x1152400 VA: 0x181153E00
	public void SetSplat(float normX, float normZ, int id) { }

	// RVA: 0x1153CF0 Offset: 0x11522F0 VA: 0x181153CF0
	public void SetSplat(int x, int z, int id) { }

	// RVA: 0x1153B20 Offset: 0x1152120 VA: 0x181153B20
	public void SetSplat(Vector3 worldPos, int id, float v) { }

	// RVA: 0x1154190 Offset: 0x1152790 VA: 0x181154190
	public void SetSplat(float normX, float normZ, int id, float v) { }

	// RVA: 0x1153AB0 Offset: 0x11520B0 VA: 0x181153AB0
	public void SetSplat(int x, int z, int id, float v) { }

	// RVA: 0x1153230 Offset: 0x1151830 VA: 0x181153230
	public void SetSplatRaw(int x, int z, Vector4 v1, Vector4 v2, float opacity) { }

	// RVA: 0x1153F40 Offset: 0x1152540 VA: 0x181153F40
	public void SetSplat(Vector3 worldPos, int id, float opacity, float radius, float fade = 0) { }

	// RVA: 0x1154240 Offset: 0x1152840 VA: 0x181154240
	public void SetSplat(float normX, float normZ, int id, float opacity, float radius, float fade = 0) { }

	// RVA: 0x1151D90 Offset: 0x1150390 VA: 0x181151D90
	public void AddSplat(Vector3 worldPos, int id, float delta, float radius, float fade = 0) { }

	// RVA: 0x1151FE0 Offset: 0x11505E0 VA: 0x181151FE0
	public void AddSplat(float normX, float normZ, int id, float delta, float radius, float fade = 0) { }

	// RVA: 0x1154370 Offset: 0x1152970 VA: 0x181154370
	private void SetSplat(int x, int z, int id, float old_val, float new_val) { }

	// RVA: 0x1154DA0 Offset: 0x11533A0 VA: 0x181154DA0
	public void .ctor() { }

}

private sealed class TerrainSplatMap.<>c__DisplayClass4_0 // TypeDefIndex: 10414
{	// Fields
	public Color32[] cols; // 0x10
	public TerrainSplatMap <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x890030 Offset: 0x88E630 VA: 0x180890030
	internal void <GenerateTextures>b__0(int z) { }

}

private sealed class TerrainSplatMap.<>c__DisplayClass4_1 // TypeDefIndex: 10415
{	// Fields
	public Color32[] cols; // 0x10
	public TerrainSplatMap <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x890240 Offset: 0x88E840 VA: 0x180890240
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

	// RVA: 0x88F430 Offset: 0x88DA30 VA: 0x18088F430
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

	// RVA: 0x88FD50 Offset: 0x88E350 VA: 0x18088FD50
	internal void <AddSplat>b__0(int x, int z, float lerp) { }

}

