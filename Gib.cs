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

	// RVA: 0xC9A030 Offset: 0xC98630 VA: 0x180C9A030
	public void DestroyViaConvar() { }

	// RVA: 0xC99D40 Offset: 0xC98340 VA: 0x180C99D40
	private void DestroyGib() { }

	// RVA: 0xC9A430 Offset: 0xC98A30 VA: 0x180C9A430
	public void SetUpDestroy(float minTime, float maxTime) { }

	// RVA: 0xC9A3B0 Offset: 0xC989B0 VA: 0x180C9A3B0 Slot: 6
	protected override void OnEnable() { }

	// RVA: 0xC9A310 Offset: 0xC98910 VA: 0x180C9A310 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0xC99B00 Offset: 0xC98100 VA: 0x180C99B00
	public static Gib Create(Mesh mesh, Material[] materials, Vector3 position, Quaternion rotation) { }

	// RVA: 0xC99320 Offset: 0xC97920 VA: 0x180C99320
	private static Gib CreateGibRoot(Vector3 position, Quaternion rotation) { }

	// RVA: 0xC99520 Offset: 0xC97B20 VA: 0x180C99520
	public void CreatePhysics(Mesh physicsMesh, PhysicMaterial physicsMaterial, Vector3 vel, bool inWater) { }

	// RVA: 0xC99860 Offset: 0xC97E60 VA: 0x180C99860
	public void CreatePhysics(Mesh physicsMesh, PhysicMaterial physicsMaterial, Vector3 vel, Vector3 angVel, bool inWater) { }

	// RVA: 0xC99440 Offset: 0xC97A40 VA: 0x180C99440
	public void CreatePhysics(Gibbable.OverrideMesh overrideMesh, PhysicMaterial physicsMaterial, Vector3 vel, float scale, bool inWater) { }

	// RVA: 0xC995D0 Offset: 0xC97BD0 VA: 0x180C995D0
	public void CreatePhysics(Gibbable.OverrideMesh overrideMesh, PhysicMaterial physicsMaterial, Vector3 vel, Vector3 angVel, float scale, bool inWater) { }

	// RVA: 0xC9A160 Offset: 0xC98760 VA: 0x180C9A160
	private void EnableCollider(Gibbable.ColliderType type) { }

	// RVA: 0xC9A560 Offset: 0xC98B60 VA: 0x180C9A560
	private void SetupCollider(Gibbable.OverrideMesh overrideMesh, PhysicMaterial physicsMaterial, float scale) { }

	// RVA: 0xC9A230 Offset: 0xC98830 VA: 0x180C9A230
	public static string GetEffect(PhysicMaterial physicMaterial) { }

	// RVA: 0xC9A9F0 Offset: 0xC98FF0 VA: 0x180C9A9F0
	public void .ctor() { }

	// RVA: 0xC9A920 Offset: 0xC98F20 VA: 0x180C9A920
	private static void .cctor() { }

}

