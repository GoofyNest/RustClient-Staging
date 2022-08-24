public class SpawnFilter // TypeDefIndex: 10313
{	[InspectorFlagsAttribute] // RVA: 0x70C90 Offset: 0x70090 VA: 0x180070C90
	public TerrainSplat.Enum SplatType; // 0x10
	[InspectorFlagsAttribute] // RVA: 0x70C90 Offset: 0x70090 VA: 0x180070C90
	public TerrainBiome.Enum BiomeType; // 0x14
	[InspectorFlagsAttribute] // RVA: 0x70C90 Offset: 0x70090 VA: 0x180070C90
	public TerrainTopology.Enum TopologyAny; // 0x18
	[InspectorFlagsAttribute] // RVA: 0x70C90 Offset: 0x70090 VA: 0x180070C90
	public TerrainTopology.Enum TopologyAll; // 0x1C
	[InspectorFlagsAttribute] // RVA: 0x70C90 Offset: 0x70090 VA: 0x180070C90
	public TerrainTopology.Enum TopologyNot; // 0x20


	public bool Test(Vector3 worldPos) { }

	public bool Test(float normX, float normZ) { }

	public float GetFactor(Vector3 worldPos, bool checkPlacementMap = True) { }

	public float GetFactor(float normX, float normZ, bool checkPlacementMap = True) { }

	public void .ctor() { }

}

