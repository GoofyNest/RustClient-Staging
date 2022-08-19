public class Collider : Component // TypeDefIndex: 3921
{	// Properties
	public bool enabled { get; set; }
	public Rigidbody attachedRigidbody { get; }
	public bool isTrigger { get; set; }
	public Bounds bounds { get; }
	[NativeMethodAttribute] // RVA: 0x8E7A0 Offset: 0x8DBA0 VA: 0x18008E7A0
	public PhysicMaterial sharedMaterial { get; set; }
	public PhysicMaterial material { set; }

	// Methods

	// RVA: 0x2297370 Offset: 0x2295970 VA: 0x182297370
	public bool get_enabled() { }

	// RVA: 0x2297430 Offset: 0x2295A30 VA: 0x182297430
	public void set_enabled(bool value) { }

	[NativeMethodAttribute] // RVA: 0x8E630 Offset: 0x8DA30 VA: 0x18008E630
	// RVA: 0x2297280 Offset: 0x2295880 VA: 0x182297280
	public Rigidbody get_attachedRigidbody() { }

	// RVA: 0x22973B0 Offset: 0x22959B0 VA: 0x1822973B0
	public bool get_isTrigger() { }

	// RVA: 0x2297480 Offset: 0x2295A80 VA: 0x182297480
	public void set_isTrigger(bool value) { }

	// RVA: 0x2296F80 Offset: 0x2295580 VA: 0x182296F80
	public Vector3 ClosestPoint(Vector3 position) { }

	// RVA: 0x2297310 Offset: 0x2295910 VA: 0x182297310
	public Bounds get_bounds() { }

	// RVA: 0x22973F0 Offset: 0x22959F0 VA: 0x1822973F0
	public PhysicMaterial get_sharedMaterial() { }

	// RVA: 0x2297520 Offset: 0x2295B20 VA: 0x182297520
	public void set_sharedMaterial(PhysicMaterial value) { }

	[NativeMethodAttribute] // RVA: 0x8E6E0 Offset: 0x8DAE0 VA: 0x18008E6E0
	// RVA: 0x22974D0 Offset: 0x2295AD0 VA: 0x1822974D0
	public void set_material(PhysicMaterial value) { }

	// RVA: 0x2297130 Offset: 0x2295730 VA: 0x182297130
	private RaycastHit Raycast(Ray ray, float maxDistance, ref bool hasHit) { }

	// RVA: 0x22971B0 Offset: 0x22957B0 VA: 0x1822971B0
	public bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) { }

	[NativeNameAttribute] // RVA: 0x8E740 Offset: 0x8DB40 VA: 0x18008E740
	// RVA: 0x2297050 Offset: 0x2295650 VA: 0x182297050
	private void Internal_ClosestPointOnBounds(Vector3 point, ref Vector3 outPos, ref float distance) { }

	// RVA: 0x2296E30 Offset: 0x2295430 VA: 0x182296E30
	public Vector3 ClosestPointOnBounds(Vector3 position) { }

	// RVA: 0x18F7990 Offset: 0x18F5F90 VA: 0x1818F7990
	public void .ctor() { }

	// RVA: 0x2296F20 Offset: 0x2295520 VA: 0x182296F20
	private void ClosestPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x22972C0 Offset: 0x22958C0 VA: 0x1822972C0
	private void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x22970C0 Offset: 0x22956C0 VA: 0x1822970C0
	private void Raycast_Injected(ref Ray ray, float maxDistance, ref bool hasHit, out RaycastHit ret) { }

	// RVA: 0x2296FE0 Offset: 0x22955E0 VA: 0x182296FE0
	private void Internal_ClosestPointOnBounds_Injected(ref Vector3 point, ref Vector3 outPos, ref float distance) { }

}

