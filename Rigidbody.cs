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

	// RVA: 0x229E6A0 Offset: 0x229CCA0 VA: 0x18229E6A0
	public Vector3 get_velocity() { }

	// RVA: 0x229EBC0 Offset: 0x229D1C0 VA: 0x18229EBC0
	public void set_velocity(Vector3 value) { }

	// RVA: 0x229E790 Offset: 0x229CD90 VA: 0x18229E790
	public void set_angularVelocity(Vector3 value) { }

	// RVA: 0x229E510 Offset: 0x229CB10 VA: 0x18229E510
	public float get_drag() { }

	// RVA: 0x229E950 Offset: 0x229CF50 VA: 0x18229E950
	public void set_drag(float value) { }

	// RVA: 0x229E490 Offset: 0x229CA90 VA: 0x18229E490
	public float get_angularDrag() { }

	// RVA: 0x229E6F0 Offset: 0x229CCF0 VA: 0x18229E6F0
	public void set_angularDrag(float value) { }

	// RVA: 0x229E590 Offset: 0x229CB90 VA: 0x18229E590
	public float get_mass() { }

	// RVA: 0x229EA30 Offset: 0x229D030 VA: 0x18229EA30
	public void set_mass(float value) { }

	// RVA: 0x229E610 Offset: 0x229CC10 VA: 0x18229E610
	public bool get_useGravity() { }

	// RVA: 0x229EB20 Offset: 0x229D120 VA: 0x18229EB20
	public void set_useGravity(bool value) { }

	// RVA: 0x229E550 Offset: 0x229CB50 VA: 0x18229E550
	public bool get_isKinematic() { }

	// RVA: 0x229E9E0 Offset: 0x229CFE0 VA: 0x18229E9E0
	public void set_isKinematic(bool value) { }

	// RVA: 0x229E8C0 Offset: 0x229CEC0 VA: 0x18229E8C0
	public void set_constraints(RigidbodyConstraints value) { }

	// RVA: 0x229E4D0 Offset: 0x229CAD0 VA: 0x18229E4D0
	public CollisionDetectionMode get_collisionDetectionMode() { }

	// RVA: 0x229E880 Offset: 0x229CE80 VA: 0x18229E880
	public void set_collisionDetectionMode(CollisionDetectionMode value) { }

	// RVA: 0x229E830 Offset: 0x229CE30 VA: 0x18229E830
	public void set_centerOfMass(Vector3 value) { }

	// RVA: 0x229E900 Offset: 0x229CF00 VA: 0x18229E900
	public void set_detectCollisions(bool value) { }

	// RVA: 0x229EAD0 Offset: 0x229D0D0 VA: 0x18229EAD0
	public void set_position(Vector3 value) { }

	// RVA: 0x229E9A0 Offset: 0x229CFA0 VA: 0x18229E9A0
	public void set_interpolation(RigidbodyInterpolation value) { }

	// RVA: 0x229E5D0 Offset: 0x229CBD0 VA: 0x18229E5D0
	public float get_sleepThreshold() { }

	// RVA: 0x229E410 Offset: 0x229CA10 VA: 0x18229E410
	public bool IsSleeping() { }

	// RVA: 0x229E450 Offset: 0x229CA50 VA: 0x18229E450
	public void WakeUp() { }

	// RVA: 0x229E2F0 Offset: 0x229C8F0 VA: 0x18229E2F0
	public void AddForce(Vector3 force, ForceMode mode) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229E2A0 Offset: 0x229C8A0 VA: 0x18229E2A0
	public void AddForce(Vector3 force) { }

	// RVA: 0x229E3B0 Offset: 0x229C9B0 VA: 0x18229E3B0
	public void AddRelativeTorque(Vector3 torque, ForceMode mode) { }

	// RVA: 0x229E1D0 Offset: 0x229C7D0 VA: 0x18229E1D0
	public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode mode) { }

	// RVA: 0x18F7950 Offset: 0x18F5F50 VA: 0x1818F7950
	public void .ctor() { }

	// RVA: 0x229E650 Offset: 0x229CC50 VA: 0x18229E650
	private void get_velocity_Injected(out Vector3 ret) { }

	// RVA: 0x229EB70 Offset: 0x229D170 VA: 0x18229EB70
	private void set_velocity_Injected(ref Vector3 value) { }

	// RVA: 0x229E740 Offset: 0x229CD40 VA: 0x18229E740
	private void set_angularVelocity_Injected(ref Vector3 value) { }

	// RVA: 0x229E7E0 Offset: 0x229CDE0 VA: 0x18229E7E0
	private void set_centerOfMass_Injected(ref Vector3 value) { }

	// RVA: 0x229EA80 Offset: 0x229D080 VA: 0x18229EA80
	private void set_position_Injected(ref Vector3 value) { }

	// RVA: 0x229E240 Offset: 0x229C840 VA: 0x18229E240
	private void AddForce_Injected(ref Vector3 force, ForceMode mode) { }

	// RVA: 0x229E350 Offset: 0x229C950 VA: 0x18229E350
	private void AddRelativeTorque_Injected(ref Vector3 torque, ForceMode mode) { }

	// RVA: 0x229E160 Offset: 0x229C760 VA: 0x18229E160
	private void AddForceAtPosition_Injected(ref Vector3 force, ref Vector3 position, ForceMode mode) { }

}

