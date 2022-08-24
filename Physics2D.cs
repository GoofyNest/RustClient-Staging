public class Physics2D // TypeDefIndex: 4080
{	private static List<Rigidbody2D> m_LastDisabledRigidbody2D; // 0x13640

	public static PhysicsScene2D defaultPhysicsScene { get; }
	[StaticAccessorAttribute] // RVA: 0x6FB50 Offset: 0x6EF50 VA: 0x18006FB50
	public static bool queriesHitTriggers { get; }


	public static PhysicsScene2D get_defaultPhysicsScene() { }

	public static bool get_queriesHitTriggers() { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x71870 Offset: 0x70C70 VA: 0x180071870
	[RequiredByNativeCodeAttribute] // RVA: 0x71870 Offset: 0x70C70 VA: 0x180071870
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth) { }

	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, float distance) { }

	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, float distance = ∞) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance, int layerMask) { }

	[StaticAccessorAttribute] // RVA: 0xF0C20 Offset: 0xF0020 VA: 0x1800F0C20
	[NativeMethodAttribute] // RVA: 0xF0C20 Offset: 0xF0020 VA: 0x1800F0C20
	private static RaycastHit2D[] GetRayIntersectionAll_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance, int layerMask) { }

	private static void .cctor() { }

	private static RaycastHit2D[] GetRayIntersectionAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask) { }

}

