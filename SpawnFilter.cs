public class SpawnFilter // TypeDefIndex: 10309
{	// Fields
	[InspectorFlagsAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public TerrainSplat.Enum SplatType; // 0x10
	[InspectorFlagsAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public TerrainBiome.Enum BiomeType; // 0x14
	[InspectorFlagsAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public TerrainTopology.Enum TopologyAny; // 0x18
	[InspectorFlagsAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public TerrainTopology.Enum TopologyAll; // 0x1C
	[InspectorFlagsAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public TerrainTopology.Enum TopologyNot; // 0x20

	// Methods

	// RVA: 0xA7DCA0 Offset: 0xA7C2A0 VA: 0x180A7DCA0
	public bool Test(Vector3 worldPos) { }

	// RVA: 0xA7DD20 Offset: 0xA7C320 VA: 0x180A7DD20
	public bool Test(float normX, float normZ) { }

	// RVA: 0xA7DC30 Offset: 0xA7C230 VA: 0x180A7DC30
	public float GetFactor(Vector3 worldPos, bool checkPlacementMap = True) { }

	// RVA: 0xA7D8C0 Offset: 0xA7BEC0 VA: 0x180A7D8C0
	public float GetFactor(float normX, float normZ, bool checkPlacementMap = True) { }

	// RVA: 0x9D0890 Offset: 0x9CEE90 VA: 0x1809D0890
	public void .ctor() { }

}

