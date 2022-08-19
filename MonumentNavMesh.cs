public class MonumentNavMesh : FacepunchBehaviour, IServerComponent // TypeDefIndex: 8958
{	// Fields
	public int NavMeshAgentTypeIndex; // 0x18
	[TooltipAttribute] // RVA: 0xC6EA0 Offset: 0xC62A0 VA: 0x1800C6EA0
	public string DefaultAreaName; // 0x20
	[TooltipAttribute] // RVA: 0xC8770 Offset: 0xC7B70 VA: 0x1800C8770
	public int CellCount; // 0x28
	[TooltipAttribute] // RVA: 0xC8890 Offset: 0xC7C90 VA: 0x1800C8890
	public int CellSize; // 0x2C
	public int Height; // 0x30
	public float NavmeshResolutionModifier; // 0x34
	[TooltipAttribute] // RVA: 0xC8970 Offset: 0xC7D70 VA: 0x1800C8970
	public bool overrideAutoBounds; // 0x38
	[TooltipAttribute] // RVA: 0xC6F40 Offset: 0xC6340 VA: 0x1800C6F40
	public Bounds Bounds; // 0x3C
	public NavMeshData NavMeshData; // 0x58
	public NavMeshDataInstance NavMeshDataInstance; // 0x60
	public LayerMask LayerMask; // 0x64
	public NavMeshCollectGeometry NavMeshCollectGeometry; // 0x68
	public bool forceCollectTerrain; // 0x6C
	public Transform CustomNavMeshRoot; // 0x70

	// Methods

	// RVA: 0x7B5BA0 Offset: 0x7B41A0 VA: 0x1807B5BA0
	public void .ctor() { }

}

