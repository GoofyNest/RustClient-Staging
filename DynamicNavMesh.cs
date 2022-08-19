public class DynamicNavMesh : SingletonComponent<DynamicNavMesh>, IServerComponent // TypeDefIndex: 8957
{	// Fields
	public int NavMeshAgentTypeIndex; // 0x18
	[TooltipAttribute] // RVA: 0xC6EA0 Offset: 0xC62A0 VA: 0x1800C6EA0
	public string DefaultAreaName; // 0x20
	public int AsyncTerrainNavMeshBakeCellSize; // 0x28
	public int AsyncTerrainNavMeshBakeCellHeight; // 0x2C
	public Bounds Bounds; // 0x30
	public NavMeshData NavMeshData; // 0x48
	public NavMeshDataInstance NavMeshDataInstance; // 0x50
	public LayerMask LayerMask; // 0x54
	public NavMeshCollectGeometry NavMeshCollectGeometry; // 0x58

	// Methods

	// RVA: 0xAB5EB0 Offset: 0xAB44B0 VA: 0x180AB5EB0
	public void .ctor() { }

}

