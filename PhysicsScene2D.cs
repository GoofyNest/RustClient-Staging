public struct PhysicsScene2D : IEquatable<PhysicsScene2D> // TypeDefIndex: 4079
{
// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0xEE920 Offset: 0xEDD20 VA: 0x1800EE920
public struct PhysicsScene2D : IEquatable<PhysicsScene2D> // TypeDefIndex: 4079
	// Fields
	private int m_Handle; // 0x0

	// Methods

	// RVA: 0x240480 Offset: 0x23F880 VA: 0x180240480 Slot: 3
	public override string ToString() { }

	// RVA: 0x13A620 Offset: 0x139A20 VA: 0x18013A620 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2401C0 Offset: 0x23F5C0 VA: 0x1802401C0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x217790 Offset: 0x216B90 VA: 0x180217790 Slot: 4
	public bool Equals(PhysicsScene2D other) { }

	// RVA: 0x240290 Offset: 0x23F690 VA: 0x180240290
	public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask = -5) { }

	// RVA: 0x240410 Offset: 0x23F810 VA: 0x180240410
	public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter) { }

	[NativeMethodAttribute] // RVA: 0xEEBB0 Offset: 0xEDFB0 VA: 0x1800EEBB0
	[StaticAccessorAttribute] // RVA: 0xEEBB0 Offset: 0xEDFB0 VA: 0x1800EEBB0
	// RVA: 0x2311100 Offset: 0x230F700 VA: 0x182311100
	private static RaycastHit2D Raycast_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter) { }

	// RVA: 0x240370 Offset: 0x23F770 VA: 0x180240370
	public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	[NativeMethodAttribute] // RVA: 0xEEEB0 Offset: 0xEE2B0 VA: 0x1800EEEB0
	[StaticAccessorAttribute] // RVA: 0xEEEB0 Offset: 0xEE2B0 VA: 0x1800EEEB0
	// RVA: 0x2310F20 Offset: 0x230F520 VA: 0x182310F20
	private static int RaycastArray_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0x2402D0 Offset: 0x23F6D0 VA: 0x1802402D0
	public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	[StaticAccessorAttribute] // RVA: 0xEF290 Offset: 0xEE690 VA: 0x1800EF290
	[NativeMethodAttribute] // RVA: 0xEF290 Offset: 0xEE690 VA: 0x1800EF290
	// RVA: 0x2311010 Offset: 0x230F610 VA: 0x182311010
	private static int RaycastList_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	// RVA: 0x240240 Offset: 0x23F640 VA: 0x180240240
	public int GetRayIntersection(Ray ray, float distance, RaycastHit2D[] results, int layerMask = -5) { }

	[NativeMethodAttribute] // RVA: 0xEF850 Offset: 0xEEC50 VA: 0x1800EF850
	[StaticAccessorAttribute] // RVA: 0xEF850 Offset: 0xEEC50 VA: 0x1800EF850
	// RVA: 0x2310D60 Offset: 0x230F360 VA: 0x182310D60
	private static int GetRayIntersectionArray_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask, RaycastHit2D[] results) { }

	// RVA: 0x2311090 Offset: 0x230F690 VA: 0x182311090
	private static void Raycast_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, out RaycastHit2D ret) { }

	// RVA: 0x2310EB0 Offset: 0x230F4B0 VA: 0x182310EB0
	private static int RaycastArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0x2310FA0 Offset: 0x230F5A0 VA: 0x182310FA0
	private static int RaycastList_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	// RVA: 0x2310CF0 Offset: 0x230F2F0 VA: 0x182310CF0
	private static int GetRayIntersectionArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask, RaycastHit2D[] results) { }

}

