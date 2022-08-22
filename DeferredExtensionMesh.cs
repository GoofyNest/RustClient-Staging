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

	// RVA: 0x847D60 Offset: 0x846360 VA: 0x180847D60
	private MaterialPropertyBlock get_block() { }

	// RVA: 0x847DD0 Offset: 0x8463D0 VA: 0x180847DD0
	private Renderer get_renderer() { }

	// RVA: 0x847810 Offset: 0x845E10 VA: 0x180847810
	private void OnEnable() { }

	// RVA: 0x8476E0 Offset: 0x845CE0 VA: 0x1808476E0
	private void OnDisable() { }

	// RVA: 0x847BD0 Offset: 0x8461D0 VA: 0x180847BD0
	public void UpdatePropertyBlock() { }

	// RVA: 0x847600 Offset: 0x845C00 VA: 0x180847600
	private void OnBecameVisible() { }

	// RVA: 0x847530 Offset: 0x845B30 VA: 0x180847530
	private void OnBecameInvisible() { }

	// RVA: 0x8474E0 Offset: 0x845AE0 VA: 0x1808474E0
	private void CleanupMaterials() { }

	// RVA: 0x847A10 Offset: 0x846010 VA: 0x180847A10
	private void PrepareMaterials(Material[] mats) { }

	// RVA: 0x847370 Offset: 0x845970 VA: 0x180847370
	public void AddToCommandBuffer(CommandBuffer cb) { }

	// RVA: 0x847CF0 Offset: 0x8462F0 VA: 0x180847CF0
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

