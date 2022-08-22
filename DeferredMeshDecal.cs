public class DeferredMeshDecal : MonoBehaviour, IClientComponent // TypeDefIndex: 10666
{	// Fields
	private bool isVisible; // 0x18
	private Renderer renderer; // 0x20
	private List<DeferredMeshDecal.MaterialLink> materialLinks; // 0x28
	private List<DeferredMeshDecal.InstanceData> instanceData; // 0x30

	// Methods

	// RVA: 0x84C2A0 Offset: 0x84A8A0 VA: 0x18084C2A0
	private void OnEnable() { }

	// RVA: 0x84C1A0 Offset: 0x84A7A0 VA: 0x18084C1A0
	private void OnDisable() { }

	// RVA: 0x84C0C0 Offset: 0x84A6C0 VA: 0x18084C0C0
	private void OnBecameVisible() { }

	// RVA: 0x84BFF0 Offset: 0x84A5F0 VA: 0x18084BFF0
	private void OnBecameInvisible() { }

	// RVA: 0x84BD30 Offset: 0x84A330 VA: 0x18084BD30
	private void CleanupLinks() { }

	// RVA: 0x84C3B0 Offset: 0x84A9B0 VA: 0x18084C3B0
	private void PrepareLinks(Material[] mats) { }

	// RVA: 0x84BEF0 Offset: 0x84A4F0 VA: 0x18084BEF0
	public bool IsLinkedToMaterial(Material mat) { }

	// RVA: 0x84BC50 Offset: 0x84A250 VA: 0x18084BC50
	public void AddToCommandBuffer(CommandBuffer cb) { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public List<DeferredMeshDecal.InstanceData> GetInstanceData() { }

	// RVA: 0x84C680 Offset: 0x84AC80 VA: 0x18084C680
	public void .ctor() { }

}

public class DeferredMeshDecal.MaterialReplacement // TypeDefIndex: 10667
{	// Fields
	public Material reference; // 0x10
	public Material material; // 0x18
	private int refCount; // 0x20
	private static Dictionary<Material, DeferredMeshDecal.MaterialReplacement> pool; // 0x0

	// Methods

	// RVA: 0x859470 Offset: 0x857A70 VA: 0x180859470
	private void .ctor(Material reference) { }

	// RVA: 0x8590D0 Offset: 0x8576D0 VA: 0x1808590D0
	public static DeferredMeshDecal.MaterialReplacement Allocate(Material reference) { }

	// RVA: 0x859320 Offset: 0x857920 VA: 0x180859320
	public void Release() { }

	// RVA: 0x859410 Offset: 0x857A10 VA: 0x180859410
	private static void .cctor() { }

}

public struct DeferredMeshDecal.MaterialLink // TypeDefIndex: 10668
{	// Fields
	public DeferredMeshDecal.MaterialReplacement replacement; // 0x0
	public int submeshIndex; // 0x8

	// Methods

	// RVA: 0xF9160 Offset: 0xF8560 VA: 0x1800F9160
	public void .ctor(DeferredMeshDecal.MaterialReplacement replacement, int submeshIndex) { }

}

public class DeferredMeshDecal.InstanceData // TypeDefIndex: 10669
{	// Fields
	private Transform transform; // 0x10
	private Material material; // 0x18
	private Mesh mesh; // 0x20
	private int submeshIndex; // 0x28
	private int hash; // 0x2C

	// Properties
	public Material Material { get; }
	public Mesh Mesh { get; }
	public int SubmeshIndex { get; }
	public Matrix4x4 LocalToWorld { get; }

	// Methods

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public Material get_Material() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public Mesh get_Mesh() { }

	// RVA: 0x4BE590 Offset: 0x4BCB90 VA: 0x1804BE590
	public int get_SubmeshIndex() { }

	// RVA: 0x859080 Offset: 0x857680 VA: 0x180859080
	public Matrix4x4 get_LocalToWorld() { }

	// RVA: 0x858E30 Offset: 0x857430 VA: 0x180858E30
	public void .ctor(Renderer renderer, Material material, int submeshIndex) { }

	// RVA: 0x858DB0 Offset: 0x8573B0 VA: 0x180858DB0
	private int GenerateHashCode() { }

	// RVA: 0x858C90 Offset: 0x857290 VA: 0x180858C90 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x5DE340 Offset: 0x5DC940 VA: 0x1805DE340 Slot: 2
	public override int GetHashCode() { }

}

