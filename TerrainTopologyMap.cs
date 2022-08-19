public class TerrainTopologyMap : TerrainMap<int> // TypeDefIndex: 10418
{	// Fields
	public Texture2D TopologyTexture; // 0x48

	// Methods

	// RVA: 0x882C20 Offset: 0x881220 VA: 0x180882C20 Slot: 4
	public override void Setup() { }

	// RVA: 0x881F10 Offset: 0x880510 VA: 0x180881F10
	public void GenerateTextures() { }

	// RVA: 0x881EE0 Offset: 0x8804E0 VA: 0x180881EE0
	public void ApplyTextures() { }

	// RVA: 0x882180 Offset: 0x880780 VA: 0x180882180
	public bool GetTopology(Vector3 worldPos, int mask) { }

	// RVA: 0x882670 Offset: 0x880C70 VA: 0x180882670
	public bool GetTopology(float normX, float normZ, int mask) { }

	// RVA: 0x8825B0 Offset: 0x880BB0 VA: 0x1808825B0
	public bool GetTopology(int x, int z, int mask) { }

	// RVA: 0x882240 Offset: 0x880840 VA: 0x180882240
	public int GetTopology(Vector3 worldPos) { }

	// RVA: 0x882600 Offset: 0x880C00 VA: 0x180882600
	public int GetTopology(float normX, float normZ) { }

	// RVA: 0x8820B0 Offset: 0x8806B0 VA: 0x1808820B0
	public int GetTopologyFast(Vector2 uv) { }

	// RVA: 0x882140 Offset: 0x880740 VA: 0x180882140
	public int GetTopology(int x, int z) { }

	// RVA: 0x882980 Offset: 0x880F80 VA: 0x180882980
	public void SetTopology(Vector3 worldPos, int mask) { }

	// RVA: 0x882A30 Offset: 0x881030 VA: 0x180882A30
	public void SetTopology(float normX, float normZ, int mask) { }

	// RVA: 0x882AB0 Offset: 0x8810B0 VA: 0x180882AB0
	public void SetTopology(int x, int z, int mask) { }

	// RVA: 0x881E30 Offset: 0x880430 VA: 0x180881E30
	public void AddTopology(Vector3 worldPos, int mask) { }

	// RVA: 0x881B40 Offset: 0x880140 VA: 0x180881B40
	public void AddTopology(float normX, float normZ, int mask) { }

	// RVA: 0x881BC0 Offset: 0x8801C0 VA: 0x180881BC0
	public void AddTopology(int x, int z, int mask) { }

	// RVA: 0x8826F0 Offset: 0x880CF0 VA: 0x1808826F0
	public void RemoveTopology(Vector3 worldPos, int mask) { }

	// RVA: 0x882800 Offset: 0x880E00 VA: 0x180882800
	public void RemoveTopology(float normX, float normZ, int mask) { }

	// RVA: 0x8827B0 Offset: 0x880DB0 VA: 0x1808827B0
	public void RemoveTopology(int x, int z, int mask) { }

	// RVA: 0x882440 Offset: 0x880A40 VA: 0x180882440
	public int GetTopology(Vector3 worldPos, float radius) { }

	// RVA: 0x8822F0 Offset: 0x8808F0 VA: 0x1808822F0
	public int GetTopology(float normX, float normZ, float radius) { }

	// RVA: 0x882AF0 Offset: 0x8810F0 VA: 0x180882AF0
	public void SetTopology(Vector3 worldPos, int mask, float radius, float fade = 0) { }

	// RVA: 0x882880 Offset: 0x880E80 VA: 0x180882880
	public void SetTopology(float normX, float normZ, int mask, float radius, float fade = 0) { }

	// RVA: 0x881C00 Offset: 0x880200 VA: 0x180881C00
	public void AddTopology(Vector3 worldPos, int mask, float radius, float fade = 0) { }

	// RVA: 0x881D30 Offset: 0x880330 VA: 0x180881D30
	public void AddTopology(float normX, float normZ, int mask, float radius, float fade = 0) { }

	// RVA: 0x882EC0 Offset: 0x8814C0 VA: 0x180882EC0
	public void .ctor() { }

}

private sealed class TerrainTopologyMap.<>c__DisplayClass2_0 // TypeDefIndex: 10419
{	// Fields
	public Color32[] col; // 0x10
	public TerrainTopologyMap <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x88FE90 Offset: 0x88E490 VA: 0x18088FE90
	internal void <GenerateTextures>b__0(int z) { }

}

private sealed class TerrainTopologyMap.<>c__DisplayClass23_0 // TypeDefIndex: 10420
{	// Fields
	public TerrainTopologyMap <>4__this; // 0x10
	public int mask; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x88F370 Offset: 0x88D970 VA: 0x18088F370
	internal void <SetTopology>b__0(int x, int z, float lerp) { }

}

private sealed class TerrainTopologyMap.<>c__DisplayClass25_0 // TypeDefIndex: 10421
{	// Fields
	public TerrainTopologyMap <>4__this; // 0x10
	public int mask; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x88F3D0 Offset: 0x88D9D0 VA: 0x18088F3D0
	internal void <AddTopology>b__0(int x, int z, float lerp) { }

}

