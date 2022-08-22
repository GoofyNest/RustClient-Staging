public class DeferredMeshDecal : MonoBehaviour, IClientComponent // TypeDefIndex: 10666
{	// Fields
	private bool isVisible; // 0x18
	private Renderer renderer; // 0x20
	private List<DeferredMeshDecal.MaterialLink> materialLinks; // 0x28
	private List<DeferredMeshDecal.InstanceData> instanceData; // 0x30

	// Methods

	// RVA: 0x84BD50 Offset: 0x84A350 VA: 0x18084BD50
	private void OnEnable() { }

	// RVA: 0x84BC50 Offset: 0x84A250 VA: 0x18084BC50
	private void OnDisable() { }

	// RVA: 0x84BB70 Offset: 0x84A170 VA: 0x18084BB70
	private void OnBecameVisible() { }

	// RVA: 0x84BAA0 Offset: 0x84A0A0 VA: 0x18084BAA0
	private void OnBecameInvisible() { }

	// RVA: 0x84B7E0 Offset: 0x849DE0 VA: 0x18084B7E0
	private void CleanupLinks() { }

	// RVA: 0x84BE60 Offset: 0x84A460 VA: 0x18084BE60
	private void PrepareLinks(Material[] mats) { }

	// RVA: 0x84B9A0 Offset: 0x849FA0 VA: 0x18084B9A0
	public bool IsLinkedToMaterial(Material mat) { }

	// RVA: 0x84B700 Offset: 0x849D00 VA: 0x18084B700
	public void AddToCommandBuffer(CommandBuffer cb) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public List<DeferredMeshDecal.InstanceData> GetInstanceData() { }

	// RVA: 0x84C130 Offset: 0x84A730 VA: 0x18084C130
	public void .ctor() { }

}

public class DeferredMeshDecal.MaterialReplacement // TypeDefIndex: 10667
{	// Fields
	public Material reference; // 0x10
	public Material material; // 0x18
	private int refCount; // 0x20
	private static Dictionary<Material, DeferredMeshDecal.MaterialReplacement> pool; // 0x0

	// Methods

	// RVA: 0x858F20 Offset: 0x857520 VA: 0x180858F20
	private void .ctor(Material reference) { }

	// RVA: 0x858B80 Offset: 0x857180 VA: 0x180858B80
	public static DeferredMeshDecal.MaterialReplacement Allocate(Material reference) { }

	// RVA: 0x858DD0 Offset: 0x8573D0 VA: 0x180858DD0
	public void Release() { }

	// RVA: 0x858EC0 Offset: 0x8574C0 VA: 0x180858EC0
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

	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	public int get_SubmeshIndex() { }

	// RVA: 0x858B30 Offset: 0x857130 VA: 0x180858B30
	public Matrix4x4 get_LocalToWorld() { }

	// RVA: 0x8588E0 Offset: 0x856EE0 VA: 0x1808588E0
	public void .ctor(Renderer renderer, Material material, int submeshIndex) { }

	// RVA: 0x858860 Offset: 0x856E60 VA: 0x180858860
	private int GenerateHashCode() { }

	// RVA: 0x858740 Offset: 0x856D40 VA: 0x180858740 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x5DE3B0 Offset: 0x5DC9B0 VA: 0x1805DE3B0 Slot: 2
	public override int GetHashCode() { }

}

