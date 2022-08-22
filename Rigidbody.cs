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

	// RVA: 0x229E960 Offset: 0x229CF60 VA: 0x18229E960
	public Vector3 get_velocity() { }

	// RVA: 0x229EE80 Offset: 0x229D480 VA: 0x18229EE80
	public void set_velocity(Vector3 value) { }

	// RVA: 0x229EA50 Offset: 0x229D050 VA: 0x18229EA50
	public void set_angularVelocity(Vector3 value) { }

	// RVA: 0x229E7D0 Offset: 0x229CDD0 VA: 0x18229E7D0
	public float get_drag() { }

	// RVA: 0x229EC10 Offset: 0x229D210 VA: 0x18229EC10
	public void set_drag(float value) { }

	// RVA: 0x229E750 Offset: 0x229CD50 VA: 0x18229E750
	public float get_angularDrag() { }

	// RVA: 0x229E9B0 Offset: 0x229CFB0 VA: 0x18229E9B0
	public void set_angularDrag(float value) { }

	// RVA: 0x229E850 Offset: 0x229CE50 VA: 0x18229E850
	public float get_mass() { }

	// RVA: 0x229ECF0 Offset: 0x229D2F0 VA: 0x18229ECF0
	public void set_mass(float value) { }

	// RVA: 0x229E8D0 Offset: 0x229CED0 VA: 0x18229E8D0
	public bool get_useGravity() { }

	// RVA: 0x229EDE0 Offset: 0x229D3E0 VA: 0x18229EDE0
	public void set_useGravity(bool value) { }

	// RVA: 0x229E810 Offset: 0x229CE10 VA: 0x18229E810
	public bool get_isKinematic() { }

	// RVA: 0x229ECA0 Offset: 0x229D2A0 VA: 0x18229ECA0
	public void set_isKinematic(bool value) { }

	// RVA: 0x229EB80 Offset: 0x229D180 VA: 0x18229EB80
	public void set_constraints(RigidbodyConstraints value) { }

	// RVA: 0x229E790 Offset: 0x229CD90 VA: 0x18229E790
	public CollisionDetectionMode get_collisionDetectionMode() { }

	// RVA: 0x229EB40 Offset: 0x229D140 VA: 0x18229EB40
	public void set_collisionDetectionMode(CollisionDetectionMode value) { }

	// RVA: 0x229EAF0 Offset: 0x229D0F0 VA: 0x18229EAF0
	public void set_centerOfMass(Vector3 value) { }

	// RVA: 0x229EBC0 Offset: 0x229D1C0 VA: 0x18229EBC0
	public void set_detectCollisions(bool value) { }

	// RVA: 0x229ED90 Offset: 0x229D390 VA: 0x18229ED90
	public void set_position(Vector3 value) { }

	// RVA: 0x229EC60 Offset: 0x229D260 VA: 0x18229EC60
	public void set_interpolation(RigidbodyInterpolation value) { }

	// RVA: 0x229E890 Offset: 0x229CE90 VA: 0x18229E890
	public float get_sleepThreshold() { }

	// RVA: 0x229E6D0 Offset: 0x229CCD0 VA: 0x18229E6D0
	public bool IsSleeping() { }

	// RVA: 0x229E710 Offset: 0x229CD10 VA: 0x18229E710
	public void WakeUp() { }

	// RVA: 0x229E5B0 Offset: 0x229CBB0 VA: 0x18229E5B0
	public void AddForce(Vector3 force, ForceMode mode) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229E560 Offset: 0x229CB60 VA: 0x18229E560
	public void AddForce(Vector3 force) { }

	// RVA: 0x229E670 Offset: 0x229CC70 VA: 0x18229E670
	public void AddRelativeTorque(Vector3 torque, ForceMode mode) { }

	// RVA: 0x229E490 Offset: 0x229CA90 VA: 0x18229E490
	public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode mode) { }

	// RVA: 0x18F7C10 Offset: 0x18F6210 VA: 0x1818F7C10
	public void .ctor() { }

	// RVA: 0x229E910 Offset: 0x229CF10 VA: 0x18229E910
	private void get_velocity_Injected(out Vector3 ret) { }

	// RVA: 0x229EE30 Offset: 0x229D430 VA: 0x18229EE30
	private void set_velocity_Injected(ref Vector3 value) { }

	// RVA: 0x229EA00 Offset: 0x229D000 VA: 0x18229EA00
	private void set_angularVelocity_Injected(ref Vector3 value) { }

	// RVA: 0x229EAA0 Offset: 0x229D0A0 VA: 0x18229EAA0
	private void set_centerOfMass_Injected(ref Vector3 value) { }

	// RVA: 0x229ED40 Offset: 0x229D340 VA: 0x18229ED40
	private void set_position_Injected(ref Vector3 value) { }

	// RVA: 0x229E500 Offset: 0x229CB00 VA: 0x18229E500
	private void AddForce_Injected(ref Vector3 force, ForceMode mode) { }

	// RVA: 0x229E610 Offset: 0x229CC10 VA: 0x18229E610
	private void AddRelativeTorque_Injected(ref Vector3 torque, ForceMode mode) { }

	// RVA: 0x229E420 Offset: 0x229CA20 VA: 0x18229E420
	private void AddForceAtPosition_Injected(ref Vector3 force, ref Vector3 position, ForceMode mode) { }

}

