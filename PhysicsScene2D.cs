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

	// RVA: 0x13A5A0 Offset: 0x1399A0 VA: 0x18013A5A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x240140 Offset: 0x23F540 VA: 0x180240140 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x217710 Offset: 0x216B10 VA: 0x180217710 Slot: 4
	public bool Equals(PhysicsScene2D other) { }

	// RVA: 0x240210 Offset: 0x23F610 VA: 0x180240210
	public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask = -5) { }

	// RVA: 0x240390 Offset: 0x23F790 VA: 0x180240390
	public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter) { }

	[NativeMethodAttribute] // RVA: 0xEEC30 Offset: 0xEE030 VA: 0x1800EEC30
	[StaticAccessorAttribute] // RVA: 0xEEC30 Offset: 0xEE030 VA: 0x1800EEC30
	// RVA: 0x2310F40 Offset: 0x230F540 VA: 0x182310F40
	private static RaycastHit2D Raycast_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter) { }

	// RVA: 0x2402F0 Offset: 0x23F6F0 VA: 0x1802402F0
	public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	[NativeMethodAttribute] // RVA: 0xEEF30 Offset: 0xEE330 VA: 0x1800EEF30
	[StaticAccessorAttribute] // RVA: 0xEEF30 Offset: 0xEE330 VA: 0x1800EEF30
	// RVA: 0x2310D60 Offset: 0x230F360 VA: 0x182310D60
	private static int RaycastArray_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0x240250 Offset: 0x23F650 VA: 0x180240250
	public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	[StaticAccessorAttribute] // RVA: 0xEF290 Offset: 0xEE690 VA: 0x1800EF290
	[NativeMethodAttribute] // RVA: 0xEF290 Offset: 0xEE690 VA: 0x1800EF290
	// RVA: 0x2310E50 Offset: 0x230F450 VA: 0x182310E50
	private static int RaycastList_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	// RVA: 0x2401C0 Offset: 0x23F5C0 VA: 0x1802401C0
	public int GetRayIntersection(Ray ray, float distance, RaycastHit2D[] results, int layerMask = -5) { }

	[NativeMethodAttribute] // RVA: 0xEF8C0 Offset: 0xEECC0 VA: 0x1800EF8C0
	[StaticAccessorAttribute] // RVA: 0xEF8C0 Offset: 0xEECC0 VA: 0x1800EF8C0
	// RVA: 0x2310BA0 Offset: 0x230F1A0 VA: 0x182310BA0
	private static int GetRayIntersectionArray_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask, RaycastHit2D[] results) { }

	// RVA: 0x2310ED0 Offset: 0x230F4D0 VA: 0x182310ED0
	private static void Raycast_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, out RaycastHit2D ret) { }

	// RVA: 0x2310CF0 Offset: 0x230F2F0 VA: 0x182310CF0
	private static int RaycastArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0x2310DE0 Offset: 0x230F3E0 VA: 0x182310DE0
	private static int RaycastList_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	// RVA: 0x2310B30 Offset: 0x230F130 VA: 0x182310B30
	private static int GetRayIntersectionArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask, RaycastHit2D[] results) { }

}

