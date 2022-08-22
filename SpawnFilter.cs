public class SpawnFilter // TypeDefIndex: 10309
{	[InspectorFlagsAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public TerrainSplat.Enum SplatType; // 0x10
	[InspectorFlagsAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public TerrainBiome.Enum BiomeType; // 0x14
	[InspectorFlagsAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public TerrainTopology.Enum TopologyAny; // 0x18
	[InspectorFlagsAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public TerrainTopology.Enum TopologyAll; // 0x1C
	[InspectorFlagsAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public TerrainTopology.Enum TopologyNot; // 0x20


	public bool Test(Vector3 worldPos) { }

	public bool Test(float normX, float normZ) { }

	public float GetFactor(Vector3 worldPos, bool checkPlacementMap = True) { }

	public float GetFactor(float normX, float normZ, bool checkPlacementMap = True) { }

	public void .ctor() { }

}

