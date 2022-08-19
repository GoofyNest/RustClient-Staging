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

	// RVA: 0x847C50 Offset: 0x846250 VA: 0x180847C50
	private MaterialPropertyBlock get_block() { }

	// RVA: 0x847CC0 Offset: 0x8462C0 VA: 0x180847CC0
	private Renderer get_renderer() { }

	// RVA: 0x847700 Offset: 0x845D00 VA: 0x180847700
	private void OnEnable() { }

	// RVA: 0x8475D0 Offset: 0x845BD0 VA: 0x1808475D0
	private void OnDisable() { }

	// RVA: 0x847AC0 Offset: 0x8460C0 VA: 0x180847AC0
	public void UpdatePropertyBlock() { }

	// RVA: 0x8474F0 Offset: 0x845AF0 VA: 0x1808474F0
	private void OnBecameVisible() { }

	// RVA: 0x847420 Offset: 0x845A20 VA: 0x180847420
	private void OnBecameInvisible() { }

	// RVA: 0x8473D0 Offset: 0x8459D0 VA: 0x1808473D0
	private void CleanupMaterials() { }

	// RVA: 0x847900 Offset: 0x845F00 VA: 0x180847900
	private void PrepareMaterials(Material[] mats) { }

	// RVA: 0x847260 Offset: 0x845860 VA: 0x180847260
	public void AddToCommandBuffer(CommandBuffer cb) { }

	// RVA: 0x847BE0 Offset: 0x8461E0 VA: 0x180847BE0
	public void .ctor() { }

}

public struct DeferredExtensionMesh.MaterialLink // TypeDefIndex: 10660
{	// Fields
	public Material material; // 0x0
	public int submeshIndex; // 0x8
	public int passIndex; // 0xC

	// Methods

	// RVA: 0xF91A0 Offset: 0xF85A0 VA: 0x1800F91A0
	public void .ctor(Material material, int submeshIndex, int passIndex) { }

}

