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

	// RVA: 0x22971B0 Offset: 0x22957B0 VA: 0x1822971B0
	public bool get_enabled() { }

	// RVA: 0x2297270 Offset: 0x2295870 VA: 0x182297270
	public void set_enabled(bool value) { }

	[NativeMethodAttribute] // RVA: 0x8E6B0 Offset: 0x8DAB0 VA: 0x18008E6B0
	// RVA: 0x22970C0 Offset: 0x22956C0 VA: 0x1822970C0
	public Rigidbody get_attachedRigidbody() { }

	// RVA: 0x22971F0 Offset: 0x22957F0 VA: 0x1822971F0
	public bool get_isTrigger() { }

	// RVA: 0x22972C0 Offset: 0x22958C0 VA: 0x1822972C0
	public void set_isTrigger(bool value) { }

	// RVA: 0x2296DC0 Offset: 0x22953C0 VA: 0x182296DC0
	public Vector3 ClosestPoint(Vector3 position) { }

	// RVA: 0x2297150 Offset: 0x2295750 VA: 0x182297150
	public Bounds get_bounds() { }

	// RVA: 0x2297230 Offset: 0x2295830 VA: 0x182297230
	public PhysicMaterial get_sharedMaterial() { }

	// RVA: 0x2297360 Offset: 0x2295960 VA: 0x182297360
	public void set_sharedMaterial(PhysicMaterial value) { }

	[NativeMethodAttribute] // RVA: 0x8E760 Offset: 0x8DB60 VA: 0x18008E760
	// RVA: 0x2297310 Offset: 0x2295910 VA: 0x182297310
	public void set_material(PhysicMaterial value) { }

	// RVA: 0x2296F70 Offset: 0x2295570 VA: 0x182296F70
	private RaycastHit Raycast(Ray ray, float maxDistance, ref bool hasHit) { }

	// RVA: 0x2296FF0 Offset: 0x22955F0 VA: 0x182296FF0
	public bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) { }

	[NativeNameAttribute] // RVA: 0x8E7C0 Offset: 0x8DBC0 VA: 0x18008E7C0
	// RVA: 0x2296E90 Offset: 0x2295490 VA: 0x182296E90
	private void Internal_ClosestPointOnBounds(Vector3 point, ref Vector3 outPos, ref float distance) { }

	// RVA: 0x2296C70 Offset: 0x2295270 VA: 0x182296C70
	public Vector3 ClosestPointOnBounds(Vector3 position) { }

	// RVA: 0x18F7950 Offset: 0x18F5F50 VA: 0x1818F7950
	public void .ctor() { }

	// RVA: 0x2296D60 Offset: 0x2295360 VA: 0x182296D60
	private void ClosestPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x2297100 Offset: 0x2295700 VA: 0x182297100
	private void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x2296F00 Offset: 0x2295500 VA: 0x182296F00
	private void Raycast_Injected(ref Ray ray, float maxDistance, ref bool hasHit, out RaycastHit ret) { }

	// RVA: 0x2296E20 Offset: 0x2295420 VA: 0x182296E20
	private void Internal_ClosestPointOnBounds_Injected(ref Vector3 point, ref Vector3 outPos, ref float distance) { }

}

