public class Collider : Component // TypeDefIndex: 3921
{	// Properties
	public bool enabled { get; set; }
	public Rigidbody attachedRigidbody { get; }
	public bool isTrigger { get; set; }
	public Bounds bounds { get; }
	[NativeMethodAttribute] // RVA: 0x8E820 Offset: 0x8DC20 VA: 0x18008E820
	public PhysicMaterial sharedMaterial { get; set; }
	public PhysicMaterial material { set; }

	// Methods

	// RVA: 0x2297470 Offset: 0x2295A70 VA: 0x182297470
	public bool get_enabled() { }

	// RVA: 0x2297530 Offset: 0x2295B30 VA: 0x182297530
	public void set_enabled(bool value) { }

	[NativeMethodAttribute] // RVA: 0x8E6B0 Offset: 0x8DAB0 VA: 0x18008E6B0
	// RVA: 0x2297380 Offset: 0x2295980 VA: 0x182297380
	public Rigidbody get_attachedRigidbody() { }

	// RVA: 0x22974B0 Offset: 0x2295AB0 VA: 0x1822974B0
	public bool get_isTrigger() { }

	// RVA: 0x2297580 Offset: 0x2295B80 VA: 0x182297580
	public void set_isTrigger(bool value) { }

	// RVA: 0x2297080 Offset: 0x2295680 VA: 0x182297080
	public Vector3 ClosestPoint(Vector3 position) { }

	// RVA: 0x2297410 Offset: 0x2295A10 VA: 0x182297410
	public Bounds get_bounds() { }

	// RVA: 0x22974F0 Offset: 0x2295AF0 VA: 0x1822974F0
	public PhysicMaterial get_sharedMaterial() { }

	// RVA: 0x2297620 Offset: 0x2295C20 VA: 0x182297620
	public void set_sharedMaterial(PhysicMaterial value) { }

	[NativeMethodAttribute] // RVA: 0x8E760 Offset: 0x8DB60 VA: 0x18008E760
	// RVA: 0x22975D0 Offset: 0x2295BD0 VA: 0x1822975D0
	public void set_material(PhysicMaterial value) { }

	// RVA: 0x2297230 Offset: 0x2295830 VA: 0x182297230
	private RaycastHit Raycast(Ray ray, float maxDistance, ref bool hasHit) { }

	// RVA: 0x22972B0 Offset: 0x22958B0 VA: 0x1822972B0
	public bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) { }

	[NativeNameAttribute] // RVA: 0x8E7C0 Offset: 0x8DBC0 VA: 0x18008E7C0
	// RVA: 0x2297150 Offset: 0x2295750 VA: 0x182297150
	private void Internal_ClosestPointOnBounds(Vector3 point, ref Vector3 outPos, ref float distance) { }

	// RVA: 0x2296F30 Offset: 0x2295530 VA: 0x182296F30
	public Vector3 ClosestPointOnBounds(Vector3 position) { }

	// RVA: 0x18F7C10 Offset: 0x18F6210 VA: 0x1818F7C10
	public void .ctor() { }

	// RVA: 0x2297020 Offset: 0x2295620 VA: 0x182297020
	private void ClosestPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x22973C0 Offset: 0x22959C0 VA: 0x1822973C0
	private void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x22971C0 Offset: 0x22957C0 VA: 0x1822971C0
	private void Raycast_Injected(ref Ray ray, float maxDistance, ref bool hasHit, out RaycastHit ret) { }

	// RVA: 0x22970E0 Offset: 0x22956E0 VA: 0x1822970E0
	private void Internal_ClosestPointOnBounds_Injected(ref Vector3 point, ref Vector3 outPos, ref float distance) { }

}

