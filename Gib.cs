public class Gib : ListComponent<Gib> // TypeDefIndex: 9191
{	// Fields
	public static int gibCount; // 0x0
	public MeshFilter _meshFilter; // 0x18
	public MeshRenderer _meshRenderer; // 0x20
	public MeshCollider _meshCollider; // 0x28
	public BoxCollider _boxCollider; // 0x30
	public SphereCollider _sphereCollider; // 0x38
	public CapsuleCollider _capsuleCollider; // 0x40
	public Rigidbody _rigidbody; // 0x48
	public static Vector2 InWaterDrag; // 0x4
	public static Vector2 InWaterAngularDrag; // 0xC

	// Methods

	// RVA: 0xC99D70 Offset: 0xC98370 VA: 0x180C99D70
	public void DestroyViaConvar() { }

	// RVA: 0xC99A80 Offset: 0xC98080 VA: 0x180C99A80
	private void DestroyGib() { }

	// RVA: 0xC9A170 Offset: 0xC98770 VA: 0x180C9A170
	public void SetUpDestroy(float minTime, float maxTime) { }

	// RVA: 0xC9A0F0 Offset: 0xC986F0 VA: 0x180C9A0F0 Slot: 6
	protected override void OnEnable() { }

	// RVA: 0xC9A050 Offset: 0xC98650 VA: 0x180C9A050 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0xC99840 Offset: 0xC97E40 VA: 0x180C99840
	public static Gib Create(Mesh mesh, Material[] materials, Vector3 position, Quaternion rotation) { }

	// RVA: 0xC99060 Offset: 0xC97660 VA: 0x180C99060
	private static Gib CreateGibRoot(Vector3 position, Quaternion rotation) { }

	// RVA: 0xC99260 Offset: 0xC97860 VA: 0x180C99260
	public void CreatePhysics(Mesh physicsMesh, PhysicMaterial physicsMaterial, Vector3 vel, bool inWater) { }

	// RVA: 0xC995A0 Offset: 0xC97BA0 VA: 0x180C995A0
	public void CreatePhysics(Mesh physicsMesh, PhysicMaterial physicsMaterial, Vector3 vel, Vector3 angVel, bool inWater) { }

	// RVA: 0xC99180 Offset: 0xC97780 VA: 0x180C99180
	public void CreatePhysics(Gibbable.OverrideMesh overrideMesh, PhysicMaterial physicsMaterial, Vector3 vel, float scale, bool inWater) { }

	// RVA: 0xC99310 Offset: 0xC97910 VA: 0x180C99310
	public void CreatePhysics(Gibbable.OverrideMesh overrideMesh, PhysicMaterial physicsMaterial, Vector3 vel, Vector3 angVel, float scale, bool inWater) { }

	// RVA: 0xC99EA0 Offset: 0xC984A0 VA: 0x180C99EA0
	private void EnableCollider(Gibbable.ColliderType type) { }

	// RVA: 0xC9A2A0 Offset: 0xC988A0 VA: 0x180C9A2A0
	private void SetupCollider(Gibbable.OverrideMesh overrideMesh, PhysicMaterial physicsMaterial, float scale) { }

	// RVA: 0xC99F70 Offset: 0xC98570 VA: 0x180C99F70
	public static string GetEffect(PhysicMaterial physicMaterial) { }

	// RVA: 0xC9A730 Offset: 0xC98D30 VA: 0x180C9A730
	public void .ctor() { }

	// RVA: 0xC9A660 Offset: 0xC98C60 VA: 0x180C9A660
	private static void .cctor() { }

}

