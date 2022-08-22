public abstract class TerrainPlacement : PrefabAttribute // TypeDefIndex: 10595
{	// Fields
	[ReadOnlyAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public Vector3 size; // 0x98
	[ReadOnlyAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public Vector3 extents; // 0xA4
	[ReadOnlyAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public Vector3 offset; // 0xB0
	public bool HeightMap; // 0xBC
	public bool AlphaMap; // 0xBD
	public bool WaterMap; // 0xBE
	[InspectorFlagsAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public TerrainSplat.Enum SplatMask; // 0xC0
	[InspectorFlagsAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public TerrainBiome.Enum BiomeMask; // 0xC4
	[InspectorFlagsAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public TerrainTopology.Enum TopologyMask; // 0xC8
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Texture2DRef heightmap; // 0xD0
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Texture2DRef splatmap0; // 0xD8
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Texture2DRef splatmap1; // 0xE0
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Texture2DRef alphamap; // 0xE8
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Texture2DRef biomemap; // 0xF0
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Texture2DRef topologymap; // 0xF8
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Texture2DRef watermap; // 0x100
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Texture2DRef blendmap; // 0x108

	// Methods

	// RVA: 0x1151410 Offset: 0x114FA10 VA: 0x181151410
	public void Apply(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	// RVA: 0x1151960 Offset: 0x114FF60 VA: 0x181151960
	protected bool ShouldHeight() { }

	// RVA: 0x11519C0 Offset: 0x114FFC0 VA: 0x1811519C0
	protected bool ShouldSplat(int id = -1) { }

	// RVA: 0x1151890 Offset: 0x114FE90 VA: 0x181151890
	protected bool ShouldAlpha() { }

	// RVA: 0x11518F0 Offset: 0x114FEF0 VA: 0x1811518F0
	protected bool ShouldBiome(int id = -1) { }

	// RVA: 0x1151A50 Offset: 0x1150050 VA: 0x181151A50
	protected bool ShouldTopology(int id = -1) { }

	// RVA: 0x1151AC0 Offset: 0x11500C0 VA: 0x181151AC0
	protected bool ShouldWater() { }

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract void ApplyHeight(Matrix4x4 localToWorld, Matrix4x4 worldToLocal);

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract void ApplySplat(Matrix4x4 localToWorld, Matrix4x4 worldToLocal);

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void ApplyAlpha(Matrix4x4 localToWorld, Matrix4x4 worldToLocal);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void ApplyBiome(Matrix4x4 localToWorld, Matrix4x4 worldToLocal);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void ApplyTopology(Matrix4x4 localToWorld, Matrix4x4 worldToLocal);

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void ApplyWater(Matrix4x4 localToWorld, Matrix4x4 worldToLocal);

	// RVA: 0x1151830 Offset: 0x114FE30 VA: 0x181151830 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x1151B20 Offset: 0x1150120 VA: 0x181151B20
	protected void .ctor() { }

}

