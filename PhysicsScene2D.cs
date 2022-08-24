public struct PhysicsScene2D : IEquatable<PhysicsScene2D> // TypeDefIndex: 4079
{
[NativeHeaderAttribute] // RVA: 0xEEAA0 Offset: 0xEDEA0 VA: 0x1800EEAA0
public struct PhysicsScene2D : IEquatable<PhysicsScene2D> // TypeDefIndex: 4079
	private int m_Handle; // 0x0


	public override string ToString() { }

	public override int GetHashCode() { }

	public override bool Equals(object other) { }

	public bool Equals(PhysicsScene2D other) { }

	public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask = -5) { }

	public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter) { }

	[NativeMethodAttribute] // RVA: 0xEECF0 Offset: 0xEE0F0 VA: 0x1800EECF0
	[StaticAccessorAttribute] // RVA: 0xEECF0 Offset: 0xEE0F0 VA: 0x1800EECF0
	private static RaycastHit2D Raycast_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter) { }

	public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	[NativeMethodAttribute] // RVA: 0xEEF50 Offset: 0xEE350 VA: 0x1800EEF50
	[StaticAccessorAttribute] // RVA: 0xEEF50 Offset: 0xEE350 VA: 0x1800EEF50
	private static int RaycastArray_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	[StaticAccessorAttribute] // RVA: 0xEF2E0 Offset: 0xEE6E0 VA: 0x1800EF2E0
	[NativeMethodAttribute] // RVA: 0xEF2E0 Offset: 0xEE6E0 VA: 0x1800EF2E0
	private static int RaycastList_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	public int GetRayIntersection(Ray ray, float distance, RaycastHit2D[] results, int layerMask = -5) { }

	[NativeMethodAttribute] // RVA: 0xEF950 Offset: 0xEED50 VA: 0x1800EF950
	[StaticAccessorAttribute] // RVA: 0xEF950 Offset: 0xEED50 VA: 0x1800EF950
	private static int GetRayIntersectionArray_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask, RaycastHit2D[] results) { }

	private static void Raycast_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, out RaycastHit2D ret) { }

	private static int RaycastArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	private static int RaycastList_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	private static int GetRayIntersectionArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask, RaycastHit2D[] results) { }

}

