public class Physics2D // TypeDefIndex: 4080
{	// Fields
	private static List<Rigidbody2D> m_LastDisabledRigidbody2D; // 0x2B11160

	// Properties
	public static PhysicsScene2D defaultPhysicsScene { get; }
	[StaticAccessorAttribute] // RVA: 0x6F710 Offset: 0x6EB10 VA: 0x18006F710
	public static bool queriesHitTriggers { get; }

	// Methods

	// RVA: 0xB3BB10 Offset: 0xB3A110 VA: 0x180B3BB10
	public static PhysicsScene2D get_defaultPhysicsScene() { }

	// RVA: 0x2310CC0 Offset: 0x230F2C0 VA: 0x182310CC0
	public static bool get_queriesHitTriggers() { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2310B00 Offset: 0x230F100 VA: 0x182310B00
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2310340 Offset: 0x230E940 VA: 0x182310340
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	[RequiredByNativeCodeAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	// RVA: 0x2310960 Offset: 0x230EF60 VA: 0x182310960
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x23107C0 Offset: 0x230EDC0 VA: 0x1823107C0
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth) { }

	// RVA: 0x2310420 Offset: 0x230EA20 VA: 0x182310420
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2310240 Offset: 0x230E840 VA: 0x182310240
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0x23105C0 Offset: 0x230EBC0 VA: 0x1823105C0
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, float distance) { }

	// RVA: 0x23106C0 Offset: 0x230ECC0 VA: 0x1823106C0
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, float distance = ∞) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x230FDA0 Offset: 0x230E3A0 VA: 0x18230FDA0
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x230FC60 Offset: 0x230E260 VA: 0x18230FC60
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x230FB20 Offset: 0x230E120 VA: 0x18230FB20
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance, int layerMask) { }

	[StaticAccessorAttribute] // RVA: 0xF0A50 Offset: 0xEFE50 VA: 0x1800F0A50
	[NativeMethodAttribute] // RVA: 0xF0A50 Offset: 0xEFE50 VA: 0x1800F0A50
	// RVA: 0x230FA80 Offset: 0x230E080 VA: 0x18230FA80
	private static RaycastHit2D[] GetRayIntersectionAll_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2310120 Offset: 0x230E720 VA: 0x182310120
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x230FED0 Offset: 0x230E4D0 VA: 0x18230FED0
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x230FFF0 Offset: 0x230E5F0 VA: 0x18230FFF0
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance, int layerMask) { }

	// RVA: 0x2310C60 Offset: 0x230F260 VA: 0x182310C60
	private static void .cctor() { }

	// RVA: 0x230FA10 Offset: 0x230E010 VA: 0x18230FA10
	private static RaycastHit2D[] GetRayIntersectionAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask) { }

}

