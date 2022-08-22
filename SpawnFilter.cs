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

	// RVA: 0xA7D9E0 Offset: 0xA7BFE0 VA: 0x180A7D9E0
	public bool Test(Vector3 worldPos) { }

	// RVA: 0xA7DA60 Offset: 0xA7C060 VA: 0x180A7DA60
	public bool Test(float normX, float normZ) { }

	// RVA: 0xA7D970 Offset: 0xA7BF70 VA: 0x180A7D970
	public float GetFactor(Vector3 worldPos, bool checkPlacementMap = True) { }

	// RVA: 0xA7D600 Offset: 0xA7BC00 VA: 0x180A7D600
	public float GetFactor(float normX, float normZ, bool checkPlacementMap = True) { }

	// RVA: 0x9D05D0 Offset: 0x9CEBD0 VA: 0x1809D05D0
	public void .ctor() { }

}

