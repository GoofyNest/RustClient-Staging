public class Collider : Component // TypeDefIndex: 3921
{	public bool enabled { get; set; }
	public Rigidbody attachedRigidbody { get; }
	public bool isTrigger { get; set; }
	public Bounds bounds { get; }
	[NativeMethodAttribute] // RVA: 0x8E960 Offset: 0x8DD60 VA: 0x18008E960
	public PhysicMaterial sharedMaterial { get; set; }
	public PhysicMaterial material { set; }


	public bool get_enabled() { }

	public void set_enabled(bool value) { }

	[NativeMethodAttribute] // RVA: 0x8E7C0 Offset: 0x8DBC0 VA: 0x18008E7C0
	public Rigidbody get_attachedRigidbody() { }

	public bool get_isTrigger() { }

	public void set_isTrigger(bool value) { }

	public Vector3 ClosestPoint(Vector3 position) { }

	public Bounds get_bounds() { }

	public PhysicMaterial get_sharedMaterial() { }

	public void set_sharedMaterial(PhysicMaterial value) { }

	[NativeMethodAttribute] // RVA: 0x8E8A0 Offset: 0x8DCA0 VA: 0x18008E8A0
	public void set_material(PhysicMaterial value) { }

	private RaycastHit Raycast(Ray ray, float maxDistance, ref bool hasHit) { }

	public bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) { }

	[NativeNameAttribute] // RVA: 0x8E900 Offset: 0x8DD00 VA: 0x18008E900
	private void Internal_ClosestPointOnBounds(Vector3 point, ref Vector3 outPos, ref float distance) { }

	public Vector3 ClosestPointOnBounds(Vector3 position) { }

	public void .ctor() { }

	private void ClosestPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	private void get_bounds_Injected(out Bounds ret) { }

	private void Raycast_Injected(ref Ray ray, float maxDistance, ref bool hasHit, out RaycastHit ret) { }

	private void Internal_ClosestPointOnBounds_Injected(ref Vector3 point, ref Vector3 outPos, ref float distance) { }

}

