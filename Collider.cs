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

	// RVA: 0x2297C90 Offset: 0x2296290 VA: 0x182297C90
	public bool get_enabled() { }

	// RVA: 0x2297D50 Offset: 0x2296350 VA: 0x182297D50
	public void set_enabled(bool value) { }

	[NativeMethodAttribute] // RVA: 0x8E6B0 Offset: 0x8DAB0 VA: 0x18008E6B0
	// RVA: 0x2297BA0 Offset: 0x22961A0 VA: 0x182297BA0
	public Rigidbody get_attachedRigidbody() { }

	// RVA: 0x2297CD0 Offset: 0x22962D0 VA: 0x182297CD0
	public bool get_isTrigger() { }

	// RVA: 0x2297DA0 Offset: 0x22963A0 VA: 0x182297DA0
	public void set_isTrigger(bool value) { }

	// RVA: 0x22978A0 Offset: 0x2295EA0 VA: 0x1822978A0
	public Vector3 ClosestPoint(Vector3 position) { }

	// RVA: 0x2297C30 Offset: 0x2296230 VA: 0x182297C30
	public Bounds get_bounds() { }

	// RVA: 0x2297D10 Offset: 0x2296310 VA: 0x182297D10
	public PhysicMaterial get_sharedMaterial() { }

	// RVA: 0x2297E40 Offset: 0x2296440 VA: 0x182297E40
	public void set_sharedMaterial(PhysicMaterial value) { }

	[NativeMethodAttribute] // RVA: 0x8E760 Offset: 0x8DB60 VA: 0x18008E760
	// RVA: 0x2297DF0 Offset: 0x22963F0 VA: 0x182297DF0
	public void set_material(PhysicMaterial value) { }

	// RVA: 0x2297A50 Offset: 0x2296050 VA: 0x182297A50
	private RaycastHit Raycast(Ray ray, float maxDistance, ref bool hasHit) { }

	// RVA: 0x2297AD0 Offset: 0x22960D0 VA: 0x182297AD0
	public bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) { }

	[NativeNameAttribute] // RVA: 0x8E7C0 Offset: 0x8DBC0 VA: 0x18008E7C0
	// RVA: 0x2297970 Offset: 0x2295F70 VA: 0x182297970
	private void Internal_ClosestPointOnBounds(Vector3 point, ref Vector3 outPos, ref float distance) { }

	// RVA: 0x2297750 Offset: 0x2295D50 VA: 0x182297750
	public Vector3 ClosestPointOnBounds(Vector3 position) { }

	// RVA: 0x18F7330 Offset: 0x18F5930 VA: 0x1818F7330
	public void .ctor() { }

	// RVA: 0x2297840 Offset: 0x2295E40 VA: 0x182297840
	private void ClosestPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x2297BE0 Offset: 0x22961E0 VA: 0x182297BE0
	private void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x22979E0 Offset: 0x2295FE0 VA: 0x1822979E0
	private void Raycast_Injected(ref Ray ray, float maxDistance, ref bool hasHit, out RaycastHit ret) { }

	// RVA: 0x2297900 Offset: 0x2295F00 VA: 0x182297900
	private void Internal_ClosestPointOnBounds_Injected(ref Vector3 point, ref Vector3 outPos, ref float distance) { }

}

