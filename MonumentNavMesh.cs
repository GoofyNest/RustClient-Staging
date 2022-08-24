public class MonumentNavMesh : FacepunchBehaviour, IServerComponent // TypeDefIndex: 8958
{	public int NavMeshAgentTypeIndex; // 0x18
	[TooltipAttribute] // RVA: 0xC7070 Offset: 0xC6470 VA: 0x1800C7070
	public string DefaultAreaName; // 0x20
	[TooltipAttribute] // RVA: 0xC8970 Offset: 0xC7D70 VA: 0x1800C8970
	public int CellCount; // 0x28
	[TooltipAttribute] // RVA: 0xC8A30 Offset: 0xC7E30 VA: 0x1800C8A30
	public int CellSize; // 0x2C
	public int Height; // 0x30
	public float NavmeshResolutionModifier; // 0x34
	[TooltipAttribute] // RVA: 0xC8AD0 Offset: 0xC7ED0 VA: 0x1800C8AD0
	public bool overrideAutoBounds; // 0x38
	[TooltipAttribute] // RVA: 0xC7110 Offset: 0xC6510 VA: 0x1800C7110
	public Bounds Bounds; // 0x3C
	public NavMeshData NavMeshData; // 0x58
	public NavMeshDataInstance NavMeshDataInstance; // 0x60
	public LayerMask LayerMask; // 0x64
	public NavMeshCollectGeometry NavMeshCollectGeometry; // 0x68
	public bool forceCollectTerrain; // 0x6C
	public Transform CustomNavMeshRoot; // 0x70


	public void .ctor() { }

}

