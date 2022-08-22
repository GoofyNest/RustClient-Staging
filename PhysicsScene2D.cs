public struct PhysicsScene2D : IEquatable<PhysicsScene2D> // TypeDefIndex: 4079
{
[NativeHeaderAttribute] // RVA: 0xEE9F0 Offset: 0xEDDF0 VA: 0x1800EE9F0
public struct PhysicsScene2D : IEquatable<PhysicsScene2D> // TypeDefIndex: 4079
	private int m_Handle; // 0x0


	public override string ToString() { }

	public override int GetHashCode() { }

	public override bool Equals(object other) { }

	public bool Equals(PhysicsScene2D other) { }

	public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask = -5) { }

	public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter) { }

	[NativeMethodAttribute] // RVA: 0xEEC30 Offset: 0xEE030 VA: 0x1800EEC30
	[StaticAccessorAttribute] // RVA: 0xEEC30 Offset: 0xEE030 VA: 0x1800EEC30
	private static RaycastHit2D Raycast_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter) { }

	public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	[NativeMethodAttribute] // RVA: 0xEEF30 Offset: 0xEE330 VA: 0x1800EEF30
	[StaticAccessorAttribute] // RVA: 0xEEF30 Offset: 0xEE330 VA: 0x1800EEF30
	private static int RaycastArray_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	[StaticAccessorAttribute] // RVA: 0xEF290 Offset: 0xEE690 VA: 0x1800EF290
	[NativeMethodAttribute] // RVA: 0xEF290 Offset: 0xEE690 VA: 0x1800EF290
	private static int RaycastList_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	public int GetRayIntersection(Ray ray, float distance, RaycastHit2D[] results, int layerMask = -5) { }

	[NativeMethodAttribute] // RVA: 0xEF8C0 Offset: 0xEECC0 VA: 0x1800EF8C0
	[StaticAccessorAttribute] // RVA: 0xEF8C0 Offset: 0xEECC0 VA: 0x1800EF8C0
	private static int GetRayIntersectionArray_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask, RaycastHit2D[] results) { }

	private static void Raycast_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, out RaycastHit2D ret) { }

	private static int RaycastArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	private static int RaycastList_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	private static int GetRayIntersectionArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask, RaycastHit2D[] results) { }

}

