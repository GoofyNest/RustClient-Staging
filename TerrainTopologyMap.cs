public class TerrainTopologyMap : TerrainMap<int> // TypeDefIndex: 10418
{	// Fields
	public Texture2D TopologyTexture; // 0x48

	// Methods

	// RVA: 0x866070 Offset: 0x864670 VA: 0x180866070 Slot: 4
	public override void Setup() { }

	// RVA: 0x865360 Offset: 0x863960 VA: 0x180865360
	public void GenerateTextures() { }

	// RVA: 0x865330 Offset: 0x863930 VA: 0x180865330
	public void ApplyTextures() { }

	// RVA: 0x8655D0 Offset: 0x863BD0 VA: 0x1808655D0
	public bool GetTopology(Vector3 worldPos, int mask) { }

	// RVA: 0x865AC0 Offset: 0x8640C0 VA: 0x180865AC0
	public bool GetTopology(float normX, float normZ, int mask) { }

	// RVA: 0x865A00 Offset: 0x864000 VA: 0x180865A00
	public bool GetTopology(int x, int z, int mask) { }

	// RVA: 0x865690 Offset: 0x863C90 VA: 0x180865690
	public int GetTopology(Vector3 worldPos) { }

	// RVA: 0x865A50 Offset: 0x864050 VA: 0x180865A50
	public int GetTopology(float normX, float normZ) { }

	// RVA: 0x865500 Offset: 0x863B00 VA: 0x180865500
	public int GetTopologyFast(Vector2 uv) { }

	// RVA: 0x865590 Offset: 0x863B90 VA: 0x180865590
	public int GetTopology(int x, int z) { }

	// RVA: 0x865DD0 Offset: 0x8643D0 VA: 0x180865DD0
	public void SetTopology(Vector3 worldPos, int mask) { }

	// RVA: 0x865E80 Offset: 0x864480 VA: 0x180865E80
	public void SetTopology(float normX, float normZ, int mask) { }

	// RVA: 0x865F00 Offset: 0x864500 VA: 0x180865F00
	public void SetTopology(int x, int z, int mask) { }

	// RVA: 0x865280 Offset: 0x863880 VA: 0x180865280
	public void AddTopology(Vector3 worldPos, int mask) { }

	// RVA: 0x864F90 Offset: 0x863590 VA: 0x180864F90
	public void AddTopology(float normX, float normZ, int mask) { }

	// RVA: 0x865010 Offset: 0x863610 VA: 0x180865010
	public void AddTopology(int x, int z, int mask) { }

	// RVA: 0x865B40 Offset: 0x864140 VA: 0x180865B40
	public void RemoveTopology(Vector3 worldPos, int mask) { }

	// RVA: 0x865C50 Offset: 0x864250 VA: 0x180865C50
	public void RemoveTopology(float normX, float normZ, int mask) { }

	// RVA: 0x865C00 Offset: 0x864200 VA: 0x180865C00
	public void RemoveTopology(int x, int z, int mask) { }

	// RVA: 0x865890 Offset: 0x863E90 VA: 0x180865890
	public int GetTopology(Vector3 worldPos, float radius) { }

	// RVA: 0x865740 Offset: 0x863D40 VA: 0x180865740
	public int GetTopology(float normX, float normZ, float radius) { }

	// RVA: 0x865F40 Offset: 0x864540 VA: 0x180865F40
	public void SetTopology(Vector3 worldPos, int mask, float radius, float fade = 0) { }

	// RVA: 0x865CD0 Offset: 0x8642D0 VA: 0x180865CD0
	public void SetTopology(float normX, float normZ, int mask, float radius, float fade = 0) { }

	// RVA: 0x865050 Offset: 0x863650 VA: 0x180865050
	public void AddTopology(Vector3 worldPos, int mask, float radius, float fade = 0) { }

	// RVA: 0x865180 Offset: 0x863780 VA: 0x180865180
	public void AddTopology(float normX, float normZ, int mask, float radius, float fade = 0) { }

	// RVA: 0x866310 Offset: 0x864910 VA: 0x180866310
	public void .ctor() { }

}

private sealed class TerrainTopologyMap.<>c__DisplayClass2_0 // TypeDefIndex: 10419
{	// Fields
	public Color32[] col; // 0x10
	public TerrainTopologyMap <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x8732E0 Offset: 0x8718E0 VA: 0x1808732E0
	internal void <GenerateTextures>b__0(int z) { }

}

private sealed class TerrainTopologyMap.<>c__DisplayClass23_0 // TypeDefIndex: 10420
{	// Fields
	public TerrainTopologyMap <>4__this; // 0x10
	public int mask; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x8727C0 Offset: 0x870DC0 VA: 0x1808727C0
	internal void <SetTopology>b__0(int x, int z, float lerp) { }

}

private sealed class TerrainTopologyMap.<>c__DisplayClass25_0 // TypeDefIndex: 10421
{	// Fields
	public TerrainTopologyMap <>4__this; // 0x10
	public int mask; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x872820 Offset: 0x870E20 VA: 0x180872820
	internal void <AddTopology>b__0(int x, int z, float lerp) { }

}

