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

	// RVA: 0xC9A4D0 Offset: 0xC98AD0 VA: 0x180C9A4D0
	public void DestroyViaConvar() { }

	// RVA: 0xC9A1E0 Offset: 0xC987E0 VA: 0x180C9A1E0
	private void DestroyGib() { }

	// RVA: 0xC9A8D0 Offset: 0xC98ED0 VA: 0x180C9A8D0
	public void SetUpDestroy(float minTime, float maxTime) { }

	// RVA: 0xC9A850 Offset: 0xC98E50 VA: 0x180C9A850 Slot: 6
	protected override void OnEnable() { }

	// RVA: 0xC9A7B0 Offset: 0xC98DB0 VA: 0x180C9A7B0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0xC99FA0 Offset: 0xC985A0 VA: 0x180C99FA0
	public static Gib Create(Mesh mesh, Material[] materials, Vector3 position, Quaternion rotation) { }

	// RVA: 0xC997C0 Offset: 0xC97DC0 VA: 0x180C997C0
	private static Gib CreateGibRoot(Vector3 position, Quaternion rotation) { }

	// RVA: 0xC999C0 Offset: 0xC97FC0 VA: 0x180C999C0
	public void CreatePhysics(Mesh physicsMesh, PhysicMaterial physicsMaterial, Vector3 vel, bool inWater) { }

	// RVA: 0xC99D00 Offset: 0xC98300 VA: 0x180C99D00
	public void CreatePhysics(Mesh physicsMesh, PhysicMaterial physicsMaterial, Vector3 vel, Vector3 angVel, bool inWater) { }

	// RVA: 0xC998E0 Offset: 0xC97EE0 VA: 0x180C998E0
	public void CreatePhysics(Gibbable.OverrideMesh overrideMesh, PhysicMaterial physicsMaterial, Vector3 vel, float scale, bool inWater) { }

	// RVA: 0xC99A70 Offset: 0xC98070 VA: 0x180C99A70
	public void CreatePhysics(Gibbable.OverrideMesh overrideMesh, PhysicMaterial physicsMaterial, Vector3 vel, Vector3 angVel, float scale, bool inWater) { }

	// RVA: 0xC9A600 Offset: 0xC98C00 VA: 0x180C9A600
	private void EnableCollider(Gibbable.ColliderType type) { }

	// RVA: 0xC9AA00 Offset: 0xC99000 VA: 0x180C9AA00
	private void SetupCollider(Gibbable.OverrideMesh overrideMesh, PhysicMaterial physicsMaterial, float scale) { }

	// RVA: 0xC9A6D0 Offset: 0xC98CD0 VA: 0x180C9A6D0
	public static string GetEffect(PhysicMaterial physicMaterial) { }

	// RVA: 0xC9AE90 Offset: 0xC99490 VA: 0x180C9AE90
	public void .ctor() { }

	// RVA: 0xC9ADC0 Offset: 0xC993C0 VA: 0x180C9ADC0
	private static void .cctor() { }

}

