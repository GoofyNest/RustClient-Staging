public class Physics2D // TypeDefIndex: 4080
{	// Fields
	private static List<Rigidbody2D> m_LastDisabledRigidbody2D; // 0x2B10180

	// Properties
	public static PhysicsScene2D defaultPhysicsScene { get; }
	[StaticAccessorAttribute] // RVA: 0x6FA60 Offset: 0x6EE60 VA: 0x18006FA60
	public static bool queriesHitTriggers { get; }

	// Methods

	// RVA: 0xB3BB10 Offset: 0xB3A110 VA: 0x180B3BB10
	public static PhysicsScene2D get_defaultPhysicsScene() { }

	// RVA: 0x2310B00 Offset: 0x230F100 VA: 0x182310B00
	public static bool get_queriesHitTriggers() { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2310940 Offset: 0x230EF40 VA: 0x182310940
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2310180 Offset: 0x230E780 VA: 0x182310180
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[RequiredByNativeCodeAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x23107A0 Offset: 0x230EDA0 VA: 0x1823107A0
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2310600 Offset: 0x230EC00 VA: 0x182310600
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth) { }

	// RVA: 0x2310260 Offset: 0x230E860 VA: 0x182310260
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2310080 Offset: 0x230E680 VA: 0x182310080
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0x2310400 Offset: 0x230EA00 VA: 0x182310400
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, float distance) { }

	// RVA: 0x2310500 Offset: 0x230EB00 VA: 0x182310500
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, float distance = ∞) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x230FBE0 Offset: 0x230E1E0 VA: 0x18230FBE0
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x230FAA0 Offset: 0x230E0A0 VA: 0x18230FAA0
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x230F960 Offset: 0x230DF60 VA: 0x18230F960
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance, int layerMask) { }

	[StaticAccessorAttribute] // RVA: 0xF0AD0 Offset: 0xEFED0 VA: 0x1800F0AD0
	[NativeMethodAttribute] // RVA: 0xF0AD0 Offset: 0xEFED0 VA: 0x1800F0AD0
	// RVA: 0x230F8C0 Offset: 0x230DEC0 VA: 0x18230F8C0
	private static RaycastHit2D[] GetRayIntersectionAll_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x230FF60 Offset: 0x230E560 VA: 0x18230FF60
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x230FD10 Offset: 0x230E310 VA: 0x18230FD10
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x230FE30 Offset: 0x230E430 VA: 0x18230FE30
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance, int layerMask) { }

	// RVA: 0x2310AA0 Offset: 0x230F0A0 VA: 0x182310AA0
	private static void .cctor() { }

	// RVA: 0x230F850 Offset: 0x230DE50 VA: 0x18230F850
	private static RaycastHit2D[] GetRayIntersectionAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask) { }

}

