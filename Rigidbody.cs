public class Rigidbody : Component // TypeDefIndex: 3920
{	// Properties
	public Vector3 velocity { get; set; }
	public Vector3 angularVelocity { set; }
	public float drag { get; set; }
	public float angularDrag { get; set; }
	public float mass { get; set; }
	public bool useGravity { get; set; }
	public bool isKinematic { get; set; }
	public RigidbodyConstraints constraints { set; }
	public CollisionDetectionMode collisionDetectionMode { get; set; }
	public Vector3 centerOfMass { set; }
	public bool detectCollisions { set; }
	public Vector3 position { set; }
	public RigidbodyInterpolation interpolation { set; }
	public float sleepThreshold { get; }

	// Methods

	// RVA: 0x229E860 Offset: 0x229CE60 VA: 0x18229E860
	public Vector3 get_velocity() { }

	// RVA: 0x229ED80 Offset: 0x229D380 VA: 0x18229ED80
	public void set_velocity(Vector3 value) { }

	// RVA: 0x229E950 Offset: 0x229CF50 VA: 0x18229E950
	public void set_angularVelocity(Vector3 value) { }

	// RVA: 0x229E6D0 Offset: 0x229CCD0 VA: 0x18229E6D0
	public float get_drag() { }

	// RVA: 0x229EB10 Offset: 0x229D110 VA: 0x18229EB10
	public void set_drag(float value) { }

	// RVA: 0x229E650 Offset: 0x229CC50 VA: 0x18229E650
	public float get_angularDrag() { }

	// RVA: 0x229E8B0 Offset: 0x229CEB0 VA: 0x18229E8B0
	public void set_angularDrag(float value) { }

	// RVA: 0x229E750 Offset: 0x229CD50 VA: 0x18229E750
	public float get_mass() { }

	// RVA: 0x229EBF0 Offset: 0x229D1F0 VA: 0x18229EBF0
	public void set_mass(float value) { }

	// RVA: 0x229E7D0 Offset: 0x229CDD0 VA: 0x18229E7D0
	public bool get_useGravity() { }

	// RVA: 0x229ECE0 Offset: 0x229D2E0 VA: 0x18229ECE0
	public void set_useGravity(bool value) { }

	// RVA: 0x229E710 Offset: 0x229CD10 VA: 0x18229E710
	public bool get_isKinematic() { }

	// RVA: 0x229EBA0 Offset: 0x229D1A0 VA: 0x18229EBA0
	public void set_isKinematic(bool value) { }

	// RVA: 0x229EA80 Offset: 0x229D080 VA: 0x18229EA80
	public void set_constraints(RigidbodyConstraints value) { }

	// RVA: 0x229E690 Offset: 0x229CC90 VA: 0x18229E690
	public CollisionDetectionMode get_collisionDetectionMode() { }

	// RVA: 0x229EA40 Offset: 0x229D040 VA: 0x18229EA40
	public void set_collisionDetectionMode(CollisionDetectionMode value) { }

	// RVA: 0x229E9F0 Offset: 0x229CFF0 VA: 0x18229E9F0
	public void set_centerOfMass(Vector3 value) { }

	// RVA: 0x229EAC0 Offset: 0x229D0C0 VA: 0x18229EAC0
	public void set_detectCollisions(bool value) { }

	// RVA: 0x229EC90 Offset: 0x229D290 VA: 0x18229EC90
	public void set_position(Vector3 value) { }

	// RVA: 0x229EB60 Offset: 0x229D160 VA: 0x18229EB60
	public void set_interpolation(RigidbodyInterpolation value) { }

	// RVA: 0x229E790 Offset: 0x229CD90 VA: 0x18229E790
	public float get_sleepThreshold() { }

	// RVA: 0x229E5D0 Offset: 0x229CBD0 VA: 0x18229E5D0
	public bool IsSleeping() { }

	// RVA: 0x229E610 Offset: 0x229CC10 VA: 0x18229E610
	public void WakeUp() { }

	// RVA: 0x229E4B0 Offset: 0x229CAB0 VA: 0x18229E4B0
	public void AddForce(Vector3 force, ForceMode mode) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x229E460 Offset: 0x229CA60 VA: 0x18229E460
	public void AddForce(Vector3 force) { }

	// RVA: 0x229E570 Offset: 0x229CB70 VA: 0x18229E570
	public void AddRelativeTorque(Vector3 torque, ForceMode mode) { }

	// RVA: 0x229E390 Offset: 0x229C990 VA: 0x18229E390
	public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode mode) { }

	// RVA: 0x18F7990 Offset: 0x18F5F90 VA: 0x1818F7990
	public void .ctor() { }

	// RVA: 0x229E810 Offset: 0x229CE10 VA: 0x18229E810
	private void get_velocity_Injected(out Vector3 ret) { }

	// RVA: 0x229ED30 Offset: 0x229D330 VA: 0x18229ED30
	private void set_velocity_Injected(ref Vector3 value) { }

	// RVA: 0x229E900 Offset: 0x229CF00 VA: 0x18229E900
	private void set_angularVelocity_Injected(ref Vector3 value) { }

	// RVA: 0x229E9A0 Offset: 0x229CFA0 VA: 0x18229E9A0
	private void set_centerOfMass_Injected(ref Vector3 value) { }

	// RVA: 0x229EC40 Offset: 0x229D240 VA: 0x18229EC40
	private void set_position_Injected(ref Vector3 value) { }

	// RVA: 0x229E400 Offset: 0x229CA00 VA: 0x18229E400
	private void AddForce_Injected(ref Vector3 force, ForceMode mode) { }

	// RVA: 0x229E510 Offset: 0x229CB10 VA: 0x18229E510
	private void AddRelativeTorque_Injected(ref Vector3 torque, ForceMode mode) { }

	// RVA: 0x229E320 Offset: 0x229C920 VA: 0x18229E320
	private void AddForceAtPosition_Injected(ref Vector3 force, ref Vector3 position, ForceMode mode) { }

}

