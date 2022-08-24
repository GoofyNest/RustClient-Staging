public class MonumentNavMesh : FacepunchBehaviour, IServerComponent // TypeDefIndex: 8958
{	public int NavMeshAgentTypeIndex; // 0x18
	[TooltipAttribute] // RVA: 0xC7030 Offset: 0xC6430 VA: 0x1800C7030
	public string DefaultAreaName; // 0x20
	[TooltipAttribute] // RVA: 0xC89B0 Offset: 0xC7DB0 VA: 0x1800C89B0
	public int CellCount; // 0x28
	[TooltipAttribute] // RVA: 0xC8AB0 Offset: 0xC7EB0 VA: 0x1800C8AB0
	public int CellSize; // 0x2C
	public int Height; // 0x30
	public float NavmeshResolutionModifier; // 0x34
	[TooltipAttribute] // RVA: 0xC8B90 Offset: 0xC7F90 VA: 0x1800C8B90
	public bool overrideAutoBounds; // 0x38
	[TooltipAttribute] // RVA: 0xC70E0 Offset: 0xC64E0 VA: 0x1800C70E0
	public Bounds Bounds; // 0x3C
	public NavMeshData NavMeshData; // 0x58
	public NavMeshDataInstance NavMeshDataInstance; // 0x60
	public LayerMask LayerMask; // 0x64
	public NavMeshCollectGeometry NavMeshCollectGeometry; // 0x68
	public bool forceCollectTerrain; // 0x6C
	public Transform CustomNavMeshRoot; // 0x70


	public void .ctor() { }

}

