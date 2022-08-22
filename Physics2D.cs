public class Physics2D // TypeDefIndex: 4080
{	// Fields
	private static List<Rigidbody2D> m_LastDisabledRigidbody2D; // 0x2B111C0

	// Properties
	public static PhysicsScene2D defaultPhysicsScene { get; }
	[StaticAccessorAttribute] // RVA: 0x6FA60 Offset: 0x6EE60 VA: 0x18006FA60
	public static bool queriesHitTriggers { get; }

	// Methods

	// RVA: 0xB3BDD0 Offset: 0xB3A3D0 VA: 0x180B3BDD0
	public static PhysicsScene2D get_defaultPhysicsScene() { }

	// RVA: 0x2310DC0 Offset: 0x230F3C0 VA: 0x182310DC0
	public static bool get_queriesHitTriggers() { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2310C00 Offset: 0x230F200 VA: 0x182310C00
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2310440 Offset: 0x230EA40 VA: 0x182310440
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[RequiredByNativeCodeAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x2310A60 Offset: 0x230F060 VA: 0x182310A60
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x23108C0 Offset: 0x230EEC0 VA: 0x1823108C0
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth) { }

	// RVA: 0x2310520 Offset: 0x230EB20 VA: 0x182310520
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2310340 Offset: 0x230E940 VA: 0x182310340
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0x23106C0 Offset: 0x230ECC0 VA: 0x1823106C0
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, float distance) { }

	// RVA: 0x23107C0 Offset: 0x230EDC0 VA: 0x1823107C0
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, float distance = ∞) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x230FEA0 Offset: 0x230E4A0 VA: 0x18230FEA0
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x230FD60 Offset: 0x230E360 VA: 0x18230FD60
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x230FC20 Offset: 0x230E220 VA: 0x18230FC20
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance, int layerMask) { }

	[StaticAccessorAttribute] // RVA: 0xF0AD0 Offset: 0xEFED0 VA: 0x1800F0AD0
	[NativeMethodAttribute] // RVA: 0xF0AD0 Offset: 0xEFED0 VA: 0x1800F0AD0
	// RVA: 0x230FB80 Offset: 0x230E180 VA: 0x18230FB80
	private static RaycastHit2D[] GetRayIntersectionAll_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2310220 Offset: 0x230E820 VA: 0x182310220
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x230FFD0 Offset: 0x230E5D0 VA: 0x18230FFD0
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x23100F0 Offset: 0x230E6F0 VA: 0x1823100F0
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance, int layerMask) { }

	// RVA: 0x2310D60 Offset: 0x230F360 VA: 0x182310D60
	private static void .cctor() { }

	// RVA: 0x230FB10 Offset: 0x230E110 VA: 0x18230FB10
	private static RaycastHit2D[] GetRayIntersectionAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask) { }

}

