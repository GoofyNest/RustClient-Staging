public struct PhysicsScene2D : IEquatable<PhysicsScene2D> // TypeDefIndex: 4079
{
// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0xEE9F0 Offset: 0xEDDF0 VA: 0x1800EE9F0
public struct PhysicsScene2D : IEquatable<PhysicsScene2D> // TypeDefIndex: 4079
	// Fields
	private int m_Handle; // 0x0

	// Methods

	// RVA: 0x240400 Offset: 0x23F800 VA: 0x180240400 Slot: 3
	public override string ToString() { }

	// RVA: 0x13A3C0 Offset: 0x1397C0 VA: 0x18013A3C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x240140 Offset: 0x23F540 VA: 0x180240140 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x217DE0 Offset: 0x2171E0 VA: 0x180217DE0 Slot: 4
	public bool Equals(PhysicsScene2D other) { }

	// RVA: 0x240210 Offset: 0x23F610 VA: 0x180240210
	public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask = -5) { }

	// RVA: 0x240390 Offset: 0x23F790 VA: 0x180240390
	public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter) { }

	[NativeMethodAttribute] // RVA: 0xEEC30 Offset: 0xEE030 VA: 0x1800EEC30
	[StaticAccessorAttribute] // RVA: 0xEEC30 Offset: 0xEE030 VA: 0x1800EEC30
	// RVA: 0x2311A20 Offset: 0x2310020 VA: 0x182311A20
	private static RaycastHit2D Raycast_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter) { }

	// RVA: 0x2402F0 Offset: 0x23F6F0 VA: 0x1802402F0
	public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	[NativeMethodAttribute] // RVA: 0xEEF30 Offset: 0xEE330 VA: 0x1800EEF30
	[StaticAccessorAttribute] // RVA: 0xEEF30 Offset: 0xEE330 VA: 0x1800EEF30
	// RVA: 0x2311840 Offset: 0x230FE40 VA: 0x182311840
	private static int RaycastArray_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0x240250 Offset: 0x23F650 VA: 0x180240250
	public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	[StaticAccessorAttribute] // RVA: 0xEF290 Offset: 0xEE690 VA: 0x1800EF290
	[NativeMethodAttribute] // RVA: 0xEF290 Offset: 0xEE690 VA: 0x1800EF290
	// RVA: 0x2311930 Offset: 0x230FF30 VA: 0x182311930
	private static int RaycastList_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	// RVA: 0x2401C0 Offset: 0x23F5C0 VA: 0x1802401C0
	public int GetRayIntersection(Ray ray, float distance, RaycastHit2D[] results, int layerMask = -5) { }

	[NativeMethodAttribute] // RVA: 0xEF8C0 Offset: 0xEECC0 VA: 0x1800EF8C0
	[StaticAccessorAttribute] // RVA: 0xEF8C0 Offset: 0xEECC0 VA: 0x1800EF8C0
	// RVA: 0x2311680 Offset: 0x230FC80 VA: 0x182311680
	private static int GetRayIntersectionArray_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask, RaycastHit2D[] results) { }

	// RVA: 0x23119B0 Offset: 0x230FFB0 VA: 0x1823119B0
	private static void Raycast_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, out RaycastHit2D ret) { }

	// RVA: 0x23117D0 Offset: 0x230FDD0 VA: 0x1823117D0
	private static int RaycastArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0x23118C0 Offset: 0x230FEC0 VA: 0x1823118C0
	private static int RaycastList_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	// RVA: 0x2311610 Offset: 0x230FC10 VA: 0x182311610
	private static int GetRayIntersectionArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask, RaycastHit2D[] results) { }

}

