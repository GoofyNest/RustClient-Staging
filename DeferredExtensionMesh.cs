public class DeferredExtensionMesh : MonoBehaviour // TypeDefIndex: 10659
{	// Fields
	public SubsurfaceProfile subsurfaceProfile; // 0x18
	private bool isVisible; // 0x20
	private List<DeferredExtensionMesh.MaterialLink> materialLinks; // 0x28
	private MaterialPropertyBlock _block; // 0x30
	private Renderer _renderer; // 0x38

	// Properties
	private MaterialPropertyBlock block { get; }
	private Renderer renderer { get; }

	// Methods

	// RVA: 0x8482B0 Offset: 0x8468B0 VA: 0x1808482B0
	private MaterialPropertyBlock get_block() { }

	// RVA: 0x848320 Offset: 0x846920 VA: 0x180848320
	private Renderer get_renderer() { }

	// RVA: 0x847D60 Offset: 0x846360 VA: 0x180847D60
	private void OnEnable() { }

	// RVA: 0x847C30 Offset: 0x846230 VA: 0x180847C30
	private void OnDisable() { }

	// RVA: 0x848120 Offset: 0x846720 VA: 0x180848120
	public void UpdatePropertyBlock() { }

	// RVA: 0x847B50 Offset: 0x846150 VA: 0x180847B50
	private void OnBecameVisible() { }

	// RVA: 0x847A80 Offset: 0x846080 VA: 0x180847A80
	private void OnBecameInvisible() { }

	// RVA: 0x847A30 Offset: 0x846030 VA: 0x180847A30
	private void CleanupMaterials() { }

	// RVA: 0x847F60 Offset: 0x846560 VA: 0x180847F60
	private void PrepareMaterials(Material[] mats) { }

	// RVA: 0x8478C0 Offset: 0x845EC0 VA: 0x1808478C0
	public void AddToCommandBuffer(CommandBuffer cb) { }

	// RVA: 0x848240 Offset: 0x846840 VA: 0x180848240
	public void .ctor() { }

}

public struct DeferredExtensionMesh.MaterialLink // TypeDefIndex: 10660
{	// Fields
	public Material material; // 0x0
	public int submeshIndex; // 0x8
	public int passIndex; // 0xC

	// Methods

	// RVA: 0xF9120 Offset: 0xF8520 VA: 0x1800F9120
	public void .ctor(Material material, int submeshIndex, int passIndex) { }

}

