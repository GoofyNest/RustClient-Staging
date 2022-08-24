public struct PhysicsScene2D : IEquatable<PhysicsScene2D> // TypeDefIndex: 4079
{
[NativeHeaderAttribute] // RVA: 0xEEC50 Offset: 0xEE050 VA: 0x1800EEC50
public struct PhysicsScene2D : IEquatable<PhysicsScene2D> // TypeDefIndex: 4079
	private int m_Handle; // 0x0


	public override string ToString() { }

	public override int GetHashCode() { }

	public override bool Equals(object other) { }

	public bool Equals(PhysicsScene2D other) { }

	public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask = -5) { }

	public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter) { }

	[NativeMethodAttribute] // RVA: 0xEEF00 Offset: 0xEE300 VA: 0x1800EEF00
	[StaticAccessorAttribute] // RVA: 0xEEF00 Offset: 0xEE300 VA: 0x1800EEF00
	private static RaycastHit2D Raycast_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter) { }

	public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	[NativeMethodAttribute] // RVA: 0xEF150 Offset: 0xEE550 VA: 0x1800EF150
	[StaticAccessorAttribute] // RVA: 0xEF150 Offset: 0xEE550 VA: 0x1800EF150
	private static int RaycastArray_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	[StaticAccessorAttribute] // RVA: 0xEF590 Offset: 0xEE990 VA: 0x1800EF590
	[NativeMethodAttribute] // RVA: 0xEF590 Offset: 0xEE990 VA: 0x1800EF590
	private static int RaycastList_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	public int GetRayIntersection(Ray ray, float distance, RaycastHit2D[] results, int layerMask = -5) { }

	[NativeMethodAttribute] // RVA: 0xEFB80 Offset: 0xEEF80 VA: 0x1800EFB80
	[StaticAccessorAttribute] // RVA: 0xEFB80 Offset: 0xEEF80 VA: 0x1800EFB80
	private static int GetRayIntersectionArray_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask, RaycastHit2D[] results) { }

	private static void Raycast_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, out RaycastHit2D ret) { }

	private static int RaycastArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	private static int RaycastList_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	private static int GetRayIntersectionArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask, RaycastHit2D[] results) { }

}

