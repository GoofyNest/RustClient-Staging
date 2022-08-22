public class Gibbable : PrefabAttribute, IClientComponent // TypeDefIndex: 9890
{	// Fields
	public GameObject gibSource; // 0x98
	public Material[] customMaterials; // 0xA0
	public GameObject materialSource; // 0xA8
	public bool copyMaterialBlock; // 0xB0
	public bool applyDamageTexture; // 0xB1
	public PhysicMaterial physicsMaterial; // 0xB8
	public GameObjectRef fxPrefab; // 0xC0
	public bool spawnFxPrefab; // 0xC8
	[TooltipAttribute] // RVA: 0xA5350 Offset: 0xA4750 VA: 0x1800A5350
	public bool important; // 0xC9
	public float explodeScale; // 0xCC
	public float scaleOverride; // 0xD0
	[ReadOnlyAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public int uniqueId; // 0xD4
	public Gibbable.BoundsEffectType boundsEffectType; // 0xD8
	public bool isConditional; // 0xDC
	[ReadOnlyAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public Bounds effectBounds; // 0xE0
	public List<Gibbable.OverrideMesh> MeshOverrides; // 0xF8
	private static MaterialPropertyBlock propertyBlock; // 0x0
	private static Material copyMaterial; // 0x8
	private Gib newGib; // 0x100
	private Gibbable.GibMesh[] gibRenderers; // 0x108

	// Methods

	// RVA: 0xC9AEF0 Offset: 0xC994F0 VA: 0x180C9AEF0 Slot: 6
	protected override void AttributeSetup(GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0xC9B210 Offset: 0xC99810 VA: 0x180C9B210
	public void CreateGibs(Transform forObject, Gibbable.ParentingType parentingType, Vector3 initialVelocity) { }

	// RVA: 0xC9B2F0 Offset: 0xC998F0 VA: 0x180C9B2F0
	public void CreateGibs(Transform forObject, Gibbable.ParentingType parentingType, Vector3 initialVelocity, Vector3 fxPos, Quaternion fxRotation) { }

	// RVA: 0xC9CB80 Offset: 0xC9B180 VA: 0x180C9CB80
	private Vector3 Position(Vector3 position, Quaternion rotation) { }

	// RVA: 0xC9CA00 Offset: 0xC9B000 VA: 0x180C9CA00
	private Material[] GetMaterialsForGib(Gibbable.GibMesh mesh) { }

	// RVA: 0xC9CA70 Offset: 0xC9B070 VA: 0x180C9CA70
	public bool GetMeshOverride(int index, out Gibbable.OverrideMesh m) { }

	// RVA: 0xC9CB50 Offset: 0xC9B150 VA: 0x180C9CB50
	private string GetPathForEffect(Gibbable.BoundsEffectType type) { }

	// RVA: 0xC9C9A0 Offset: 0xC9AFA0 VA: 0x180C9C9A0 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0xC9CCF0 Offset: 0xC9B2F0 VA: 0x180C9CCF0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

public struct Gibbable.OverrideMesh // TypeDefIndex: 9891
{	// Fields
	public bool enabled; // 0x0
	public Gibbable.ColliderType ColliderType; // 0x4
	public Vector3 BoxSize; // 0x8
	public Vector3 ColliderCentre; // 0x14
	public float ColliderRadius; // 0x20
	public float CapsuleHeight; // 0x24
	public int CapsuleDirection; // 0x28
	public bool BlockMaterialCopy; // 0x2C

}

public enum Gibbable.ColliderType // TypeDefIndex: 9892
{	// Fields
	public int value__; // 0x0
	public const Gibbable.ColliderType Box = 0;
	public const Gibbable.ColliderType Sphere = 1;
	public const Gibbable.ColliderType Capsule = 2;

}

public enum Gibbable.ParentingType // TypeDefIndex: 9893
{	// Fields
	public int value__; // 0x0
	public const Gibbable.ParentingType None = 0;
	public const Gibbable.ParentingType GibsOnly = 1;
	public const Gibbable.ParentingType FXOnly = 2;
	public const Gibbable.ParentingType All = 3;

}

public enum Gibbable.BoundsEffectType // TypeDefIndex: 9894
{	// Fields
	public int value__; // 0x0
	public const Gibbable.BoundsEffectType None = 0;
	public const Gibbable.BoundsEffectType Electrical = 1;
	public const Gibbable.BoundsEffectType Glass = 2;
	public const Gibbable.BoundsEffectType Scrap = 3;
	public const Gibbable.BoundsEffectType Stone = 4;
	public const Gibbable.BoundsEffectType Wood = 5;

}

private struct Gibbable.GibMesh // TypeDefIndex: 9895
{	// Fields
	public Transform transform; // 0x0
	public MeshFilter filter; // 0x8
	public MeshCollider collider; // 0x10
	public Vector3 localPosition; // 0x18
	public Quaternion localRotation; // 0x24
	public Material[] materials; // 0x38

}

