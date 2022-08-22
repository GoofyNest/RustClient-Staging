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

	// RVA: 0xA7E170 Offset: 0xA7C770 VA: 0x180A7E170
	public bool Test(Vector3 worldPos) { }

	// RVA: 0xA7E1F0 Offset: 0xA7C7F0 VA: 0x180A7E1F0
	public bool Test(float normX, float normZ) { }

	// RVA: 0xA7E100 Offset: 0xA7C700 VA: 0x180A7E100
	public float GetFactor(Vector3 worldPos, bool checkPlacementMap = True) { }

	// RVA: 0xA7DD90 Offset: 0xA7C390 VA: 0x180A7DD90
	public float GetFactor(float normX, float normZ, bool checkPlacementMap = True) { }

	// RVA: 0x9D0D80 Offset: 0x9CF380 VA: 0x1809D0D80
	public void .ctor() { }

}

