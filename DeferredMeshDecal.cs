public class DeferredMeshDecal : MonoBehaviour, IClientComponent // TypeDefIndex: 10666
{	// Fields
	private bool isVisible; // 0x18
	private Renderer renderer; // 0x20
	private List<DeferredMeshDecal.MaterialLink> materialLinks; // 0x28
	private List<DeferredMeshDecal.InstanceData> instanceData; // 0x30

	// Methods

	// RVA: 0x84BC40 Offset: 0x84A240 VA: 0x18084BC40
	private void OnEnable() { }

	// RVA: 0x84BB40 Offset: 0x84A140 VA: 0x18084BB40
	private void OnDisable() { }

	// RVA: 0x84BA60 Offset: 0x84A060 VA: 0x18084BA60
	private void OnBecameVisible() { }

	// RVA: 0x84B990 Offset: 0x849F90 VA: 0x18084B990
	private void OnBecameInvisible() { }

	// RVA: 0x84B6D0 Offset: 0x849CD0 VA: 0x18084B6D0
	private void CleanupLinks() { }

	// RVA: 0x84BD50 Offset: 0x84A350 VA: 0x18084BD50
	private void PrepareLinks(Material[] mats) { }

	// RVA: 0x84B890 Offset: 0x849E90 VA: 0x18084B890
	public bool IsLinkedToMaterial(Material mat) { }

	// RVA: 0x84B5F0 Offset: 0x849BF0 VA: 0x18084B5F0
	public void AddToCommandBuffer(CommandBuffer cb) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public List<DeferredMeshDecal.InstanceData> GetInstanceData() { }

	// RVA: 0x84C020 Offset: 0x84A620 VA: 0x18084C020
	public void .ctor() { }

}

public class DeferredMeshDecal.MaterialReplacement // TypeDefIndex: 10667
{	// Fields
	public Material reference; // 0x10
	public Material material; // 0x18
	private int refCount; // 0x20
	private static Dictionary<Material, DeferredMeshDecal.MaterialReplacement> pool; // 0x0

	// Methods

	// RVA: 0x858E10 Offset: 0x857410 VA: 0x180858E10
	private void .ctor(Material reference) { }

	// RVA: 0x858A70 Offset: 0x857070 VA: 0x180858A70
	public static DeferredMeshDecal.MaterialReplacement Allocate(Material reference) { }

	// RVA: 0x858CC0 Offset: 0x8572C0 VA: 0x180858CC0
	public void Release() { }

	// RVA: 0x858DB0 Offset: 0x8573B0 VA: 0x180858DB0
	private static void .cctor() { }

}

public struct DeferredMeshDecal.MaterialLink // TypeDefIndex: 10668
{	// Fields
	public DeferredMeshDecal.MaterialReplacement replacement; // 0x0
	public int submeshIndex; // 0x8

	// Methods

	// RVA: 0xF91E0 Offset: 0xF85E0 VA: 0x1800F91E0
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

	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	public int get_SubmeshIndex() { }

	// RVA: 0x858A20 Offset: 0x857020 VA: 0x180858A20
	public Matrix4x4 get_LocalToWorld() { }

	// RVA: 0x8587D0 Offset: 0x856DD0 VA: 0x1808587D0
	public void .ctor(Renderer renderer, Material material, int submeshIndex) { }

	// RVA: 0x858750 Offset: 0x856D50 VA: 0x180858750
	private int GenerateHashCode() { }

	// RVA: 0x858630 Offset: 0x856C30 VA: 0x180858630 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x5DE3B0 Offset: 0x5DC9B0 VA: 0x1805DE3B0 Slot: 2
	public override int GetHashCode() { }

}

