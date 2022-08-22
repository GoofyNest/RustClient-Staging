public class Physics2D // TypeDefIndex: 4080
{	// Fields
	private static List<Rigidbody2D> m_LastDisabledRigidbody2D; // 0x132D7

	// Properties
	public static PhysicsScene2D defaultPhysicsScene { get; }
	[StaticAccessorAttribute] // RVA: 0x6FA60 Offset: 0x6EE60 VA: 0x18006FA60
	public static bool queriesHitTriggers { get; }

	// Methods

	// RVA: 0xB3C2A0 Offset: 0xB3A8A0 VA: 0x180B3C2A0
	public static PhysicsScene2D get_defaultPhysicsScene() { }

	// RVA: 0x23115E0 Offset: 0x230FBE0 VA: 0x1823115E0
	public static bool get_queriesHitTriggers() { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2311420 Offset: 0x230FA20 VA: 0x182311420
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2310C60 Offset: 0x230F260 VA: 0x182310C60
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[RequiredByNativeCodeAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x2311280 Offset: 0x230F880 VA: 0x182311280
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x23110E0 Offset: 0x230F6E0 VA: 0x1823110E0
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth) { }

	// RVA: 0x2310D40 Offset: 0x230F340 VA: 0x182310D40
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2310B60 Offset: 0x230F160 VA: 0x182310B60
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0x2310EE0 Offset: 0x230F4E0 VA: 0x182310EE0
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, float distance) { }

	// RVA: 0x2310FE0 Offset: 0x230F5E0 VA: 0x182310FE0
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, float distance = ∞) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x23106C0 Offset: 0x230ECC0 VA: 0x1823106C0
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2310580 Offset: 0x230EB80 VA: 0x182310580
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2310440 Offset: 0x230EA40 VA: 0x182310440
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance, int layerMask) { }

	[StaticAccessorAttribute] // RVA: 0xF0AD0 Offset: 0xEFED0 VA: 0x1800F0AD0
	[NativeMethodAttribute] // RVA: 0xF0AD0 Offset: 0xEFED0 VA: 0x1800F0AD0
	// RVA: 0x23103A0 Offset: 0x230E9A0 VA: 0x1823103A0
	private static RaycastHit2D[] GetRayIntersectionAll_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2310A40 Offset: 0x230F040 VA: 0x182310A40
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x23107F0 Offset: 0x230EDF0 VA: 0x1823107F0
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2310910 Offset: 0x230EF10 VA: 0x182310910
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance, int layerMask) { }

	// RVA: 0x2311580 Offset: 0x230FB80 VA: 0x182311580
	private static void .cctor() { }

	// RVA: 0x2310330 Offset: 0x230E930 VA: 0x182310330
	private static RaycastHit2D[] GetRayIntersectionAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask) { }

}

