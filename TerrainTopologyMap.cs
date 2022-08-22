public class TerrainTopologyMap : TerrainMap<int> // TypeDefIndex: 10418
{	// Fields
	public Texture2D TopologyTexture; // 0x48

	// Methods

	// RVA: 0x882D30 Offset: 0x881330 VA: 0x180882D30 Slot: 4
	public override void Setup() { }

	// RVA: 0x882020 Offset: 0x880620 VA: 0x180882020
	public void GenerateTextures() { }

	// RVA: 0x881FF0 Offset: 0x8805F0 VA: 0x180881FF0
	public void ApplyTextures() { }

	// RVA: 0x882290 Offset: 0x880890 VA: 0x180882290
	public bool GetTopology(Vector3 worldPos, int mask) { }

	// RVA: 0x882780 Offset: 0x880D80 VA: 0x180882780
	public bool GetTopology(float normX, float normZ, int mask) { }

	// RVA: 0x8826C0 Offset: 0x880CC0 VA: 0x1808826C0
	public bool GetTopology(int x, int z, int mask) { }

	// RVA: 0x882350 Offset: 0x880950 VA: 0x180882350
	public int GetTopology(Vector3 worldPos) { }

	// RVA: 0x882710 Offset: 0x880D10 VA: 0x180882710
	public int GetTopology(float normX, float normZ) { }

	// RVA: 0x8821C0 Offset: 0x8807C0 VA: 0x1808821C0
	public int GetTopologyFast(Vector2 uv) { }

	// RVA: 0x882250 Offset: 0x880850 VA: 0x180882250
	public int GetTopology(int x, int z) { }

	// RVA: 0x882A90 Offset: 0x881090 VA: 0x180882A90
	public void SetTopology(Vector3 worldPos, int mask) { }

	// RVA: 0x882B40 Offset: 0x881140 VA: 0x180882B40
	public void SetTopology(float normX, float normZ, int mask) { }

	// RVA: 0x882BC0 Offset: 0x8811C0 VA: 0x180882BC0
	public void SetTopology(int x, int z, int mask) { }

	// RVA: 0x881F40 Offset: 0x880540 VA: 0x180881F40
	public void AddTopology(Vector3 worldPos, int mask) { }

	// RVA: 0x881C50 Offset: 0x880250 VA: 0x180881C50
	public void AddTopology(float normX, float normZ, int mask) { }

	// RVA: 0x881CD0 Offset: 0x8802D0 VA: 0x180881CD0
	public void AddTopology(int x, int z, int mask) { }

	// RVA: 0x882800 Offset: 0x880E00 VA: 0x180882800
	public void RemoveTopology(Vector3 worldPos, int mask) { }

	// RVA: 0x882910 Offset: 0x880F10 VA: 0x180882910
	public void RemoveTopology(float normX, float normZ, int mask) { }

	// RVA: 0x8828C0 Offset: 0x880EC0 VA: 0x1808828C0
	public void RemoveTopology(int x, int z, int mask) { }

	// RVA: 0x882550 Offset: 0x880B50 VA: 0x180882550
	public int GetTopology(Vector3 worldPos, float radius) { }

	// RVA: 0x882400 Offset: 0x880A00 VA: 0x180882400
	public int GetTopology(float normX, float normZ, float radius) { }

	// RVA: 0x882C00 Offset: 0x881200 VA: 0x180882C00
	public void SetTopology(Vector3 worldPos, int mask, float radius, float fade = 0) { }

	// RVA: 0x882990 Offset: 0x880F90 VA: 0x180882990
	public void SetTopology(float normX, float normZ, int mask, float radius, float fade = 0) { }

	// RVA: 0x881D10 Offset: 0x880310 VA: 0x180881D10
	public void AddTopology(Vector3 worldPos, int mask, float radius, float fade = 0) { }

	// RVA: 0x881E40 Offset: 0x880440 VA: 0x180881E40
	public void AddTopology(float normX, float normZ, int mask, float radius, float fade = 0) { }

	// RVA: 0x882FD0 Offset: 0x8815D0 VA: 0x180882FD0
	public void .ctor() { }

}

private sealed class TerrainTopologyMap.<>c__DisplayClass2_0 // TypeDefIndex: 10419
{	// Fields
	public Color32[] col; // 0x10
	public TerrainTopologyMap <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x88FFA0 Offset: 0x88E5A0 VA: 0x18088FFA0
	internal void <GenerateTextures>b__0(int z) { }

}

private sealed class TerrainTopologyMap.<>c__DisplayClass23_0 // TypeDefIndex: 10420
{	// Fields
	public TerrainTopologyMap <>4__this; // 0x10
	public int mask; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x88F480 Offset: 0x88DA80 VA: 0x18088F480
	internal void <SetTopology>b__0(int x, int z, float lerp) { }

}

private sealed class TerrainTopologyMap.<>c__DisplayClass25_0 // TypeDefIndex: 10421
{	// Fields
	public TerrainTopologyMap <>4__this; // 0x10
	public int mask; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x88F4E0 Offset: 0x88DAE0 VA: 0x18088F4E0
	internal void <AddTopology>b__0(int x, int z, float lerp) { }

}

