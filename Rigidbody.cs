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

	// RVA: 0x229F180 Offset: 0x229D780 VA: 0x18229F180
	public Vector3 get_velocity() { }

	// RVA: 0x229F6A0 Offset: 0x229DCA0 VA: 0x18229F6A0
	public void set_velocity(Vector3 value) { }

	// RVA: 0x229F270 Offset: 0x229D870 VA: 0x18229F270
	public void set_angularVelocity(Vector3 value) { }

	// RVA: 0x229EFF0 Offset: 0x229D5F0 VA: 0x18229EFF0
	public float get_drag() { }

	// RVA: 0x229F430 Offset: 0x229DA30 VA: 0x18229F430
	public void set_drag(float value) { }

	// RVA: 0x229EF70 Offset: 0x229D570 VA: 0x18229EF70
	public float get_angularDrag() { }

	// RVA: 0x229F1D0 Offset: 0x229D7D0 VA: 0x18229F1D0
	public void set_angularDrag(float value) { }

	// RVA: 0x229F070 Offset: 0x229D670 VA: 0x18229F070
	public float get_mass() { }

	// RVA: 0x229F510 Offset: 0x229DB10 VA: 0x18229F510
	public void set_mass(float value) { }

	// RVA: 0x229F0F0 Offset: 0x229D6F0 VA: 0x18229F0F0
	public bool get_useGravity() { }

	// RVA: 0x229F600 Offset: 0x229DC00 VA: 0x18229F600
	public void set_useGravity(bool value) { }

	// RVA: 0x229F030 Offset: 0x229D630 VA: 0x18229F030
	public bool get_isKinematic() { }

	// RVA: 0x229F4C0 Offset: 0x229DAC0 VA: 0x18229F4C0
	public void set_isKinematic(bool value) { }

	// RVA: 0x229F3A0 Offset: 0x229D9A0 VA: 0x18229F3A0
	public void set_constraints(RigidbodyConstraints value) { }

	// RVA: 0x229EFB0 Offset: 0x229D5B0 VA: 0x18229EFB0
	public CollisionDetectionMode get_collisionDetectionMode() { }

	// RVA: 0x229F360 Offset: 0x229D960 VA: 0x18229F360
	public void set_collisionDetectionMode(CollisionDetectionMode value) { }

	// RVA: 0x229F310 Offset: 0x229D910 VA: 0x18229F310
	public void set_centerOfMass(Vector3 value) { }

	// RVA: 0x229F3E0 Offset: 0x229D9E0 VA: 0x18229F3E0
	public void set_detectCollisions(bool value) { }

	// RVA: 0x229F5B0 Offset: 0x229DBB0 VA: 0x18229F5B0
	public void set_position(Vector3 value) { }

	// RVA: 0x229F480 Offset: 0x229DA80 VA: 0x18229F480
	public void set_interpolation(RigidbodyInterpolation value) { }

	// RVA: 0x229F0B0 Offset: 0x229D6B0 VA: 0x18229F0B0
	public float get_sleepThreshold() { }

	// RVA: 0x229EEF0 Offset: 0x229D4F0 VA: 0x18229EEF0
	public bool IsSleeping() { }

	// RVA: 0x229EF30 Offset: 0x229D530 VA: 0x18229EF30
	public void WakeUp() { }

	// RVA: 0x229EDD0 Offset: 0x229D3D0 VA: 0x18229EDD0
	public void AddForce(Vector3 force, ForceMode mode) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229ED80 Offset: 0x229D380 VA: 0x18229ED80
	public void AddForce(Vector3 force) { }

	// RVA: 0x229EE90 Offset: 0x229D490 VA: 0x18229EE90
	public void AddRelativeTorque(Vector3 torque, ForceMode mode) { }

	// RVA: 0x229ECB0 Offset: 0x229D2B0 VA: 0x18229ECB0
	public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode mode) { }

	// RVA: 0x18F7330 Offset: 0x18F5930 VA: 0x1818F7330
	public void .ctor() { }

	// RVA: 0x229F130 Offset: 0x229D730 VA: 0x18229F130
	private void get_velocity_Injected(out Vector3 ret) { }

	// RVA: 0x229F650 Offset: 0x229DC50 VA: 0x18229F650
	private void set_velocity_Injected(ref Vector3 value) { }

	// RVA: 0x229F220 Offset: 0x229D820 VA: 0x18229F220
	private void set_angularVelocity_Injected(ref Vector3 value) { }

	// RVA: 0x229F2C0 Offset: 0x229D8C0 VA: 0x18229F2C0
	private void set_centerOfMass_Injected(ref Vector3 value) { }

	// RVA: 0x229F560 Offset: 0x229DB60 VA: 0x18229F560
	private void set_position_Injected(ref Vector3 value) { }

	// RVA: 0x229ED20 Offset: 0x229D320 VA: 0x18229ED20
	private void AddForce_Injected(ref Vector3 force, ForceMode mode) { }

	// RVA: 0x229EE30 Offset: 0x229D430 VA: 0x18229EE30
	private void AddRelativeTorque_Injected(ref Vector3 torque, ForceMode mode) { }

	// RVA: 0x229EC40 Offset: 0x229D240 VA: 0x18229EC40
	private void AddForceAtPosition_Injected(ref Vector3 force, ref Vector3 position, ForceMode mode) { }

}

