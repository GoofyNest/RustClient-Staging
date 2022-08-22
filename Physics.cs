public class Physics // TypeDefIndex: 3934
{	// Properties
	public static Vector3 gravity { get; }
	public static bool queriesHitBackfaces { get; set; }
	[NativePropertyAttribute] // RVA: 0x9A9E0 Offset: 0x99DE0 VA: 0x18009A9E0
	public static PhysicsScene defaultPhysicsScene { get; }
	public static bool autoSyncTransforms { get; set; }

	// Methods

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x229E3B0 Offset: 0x229C9B0 VA: 0x18229E3B0
	public static Vector3 get_gravity() { }

	// RVA: 0x229E3F0 Offset: 0x229C9F0 VA: 0x18229E3F0
	public static bool get_queriesHitBackfaces() { }

	// RVA: 0x229E460 Offset: 0x229CA60 VA: 0x18229E460
	public static void set_queriesHitBackfaces(bool value) { }

	// RVA: 0x229E330 Offset: 0x229C930 VA: 0x18229E330
	public static PhysicsScene get_defaultPhysicsScene() { }

	// RVA: 0x229ABE0 Offset: 0x22991E0 VA: 0x18229ABE0
	public static void IgnoreCollision(Collider collider1, Collider collider2, bool ignore) { }

	// RVA: 0x229CB50 Offset: 0x229B150 VA: 0x18229CB50
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229D0C0 Offset: 0x229B6C0 VA: 0x18229D0C0
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229C8B0 Offset: 0x229AEB0 VA: 0x18229C8B0
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229CE30 Offset: 0x229B430 VA: 0x18229CE30
	public static bool Raycast(Vector3 origin, Vector3 direction) { }

	// RVA: 0x229CA70 Offset: 0x229B070 VA: 0x18229CA70
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[ExcludeFromDocsAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x229D580 Offset: 0x229BB80 VA: 0x18229D580
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229CFF0 Offset: 0x229B5F0 VA: 0x18229CFF0
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229C7E0 Offset: 0x229ADE0 VA: 0x18229C7E0
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo) { }

	// RVA: 0x229D480 Offset: 0x229BA80 VA: 0x18229D480
	public static bool Raycast(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229CC20 Offset: 0x229B220 VA: 0x18229CC20
	public static bool Raycast(Ray ray, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229C980 Offset: 0x229AF80 VA: 0x18229C980
	public static bool Raycast(Ray ray, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229D390 Offset: 0x229B990 VA: 0x18229D390
	public static bool Raycast(Ray ray) { }

	// RVA: 0x229CD20 Offset: 0x229B320 VA: 0x18229CD20
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229CEE0 Offset: 0x229B4E0 VA: 0x18229CEE0
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229D290 Offset: 0x229B890 VA: 0x18229D290
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229D190 Offset: 0x229B790 VA: 0x18229D190
	public static bool Raycast(Ray ray, out RaycastHit hitInfo) { }

	// RVA: 0x229AD20 Offset: 0x2299320 VA: 0x18229AD20
	public static bool Linecast(Vector3 start, Vector3 end, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229B000 Offset: 0x2299600 VA: 0x18229B000
	public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229AE90 Offset: 0x2299490 VA: 0x18229AE90
	public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, int layerMask) { }

	// RVA: 0x229A420 Offset: 0x2298A20 VA: 0x18229A420
	public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229A310 Offset: 0x2298910 VA: 0x18229A310
	public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	// RVA: 0x229DDC0 Offset: 0x229C3C0 VA: 0x18229DDC0
	public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229DEB0 Offset: 0x229C4B0 VA: 0x18229DEB0
	public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	// RVA: 0x229E110 Offset: 0x229C710 VA: 0x18229E110
	public static bool SphereCast(Ray ray, float radius, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229DC60 Offset: 0x229C260 VA: 0x18229DC60
	public static bool SphereCast(Ray ray, float radius, float maxDistance, int layerMask) { }

	// RVA: 0x229DFE0 Offset: 0x229C5E0 VA: 0x18229DFE0
	public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229E250 Offset: 0x229C850 VA: 0x18229E250
	public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229DFA0 Offset: 0x229C5A0 VA: 0x18229DFA0
	public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance) { }

	// RVA: 0x2299E60 Offset: 0x2298460 VA: 0x182299E60
	public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229A010 Offset: 0x2298610 VA: 0x18229A010
	public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance, int layerMask) { }

	[NativeNameAttribute] // RVA: 0x95E10 Offset: 0x95210 VA: 0x180095E10
	[StaticAccessorAttribute] // RVA: 0x95E10 Offset: 0x95210 VA: 0x180095E10
	// RVA: 0x229ACB0 Offset: 0x22992B0 VA: 0x18229ACB0
	private static RaycastHit[] Internal_RaycastAll(PhysicsScene physicsScene, Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229B890 Offset: 0x2299E90 VA: 0x18229B890
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229B840 Offset: 0x2299E40 VA: 0x18229B840
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229BAF0 Offset: 0x229A0F0 VA: 0x18229BAF0
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229BB40 Offset: 0x229A140 VA: 0x18229BB40
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction) { }

	// RVA: 0x229BC40 Offset: 0x229A240 VA: 0x18229BC40
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[ExcludeFromDocsAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x229BBA0 Offset: 0x229A1A0 VA: 0x18229BBA0
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229BA50 Offset: 0x229A050 VA: 0x18229BA50
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229B7B0 Offset: 0x2299DB0 VA: 0x18229B7B0
	public static RaycastHit[] RaycastAll(Ray ray) { }

	// RVA: 0x229BFB0 Offset: 0x229A5B0 VA: 0x18229BFB0
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[ExcludeFromDocsAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x229C530 Offset: 0x229AB30 VA: 0x18229C530
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229BCF0 Offset: 0x229A2F0 VA: 0x18229BCF0
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229C270 Offset: 0x229A870 VA: 0x18229C270
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results) { }

	// RVA: 0x229BE60 Offset: 0x229A460 VA: 0x18229BE60
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229C3E0 Offset: 0x229A9E0 VA: 0x18229C3E0
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229C120 Offset: 0x229A720 VA: 0x18229C120
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229C6A0 Offset: 0x229ACA0 VA: 0x18229C6A0
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results) { }

	[NativeNameAttribute] // RVA: 0x97450 Offset: 0x96850 VA: 0x180097450
	[StaticAccessorAttribute] // RVA: 0x97450 Offset: 0x96850 VA: 0x180097450
	// RVA: 0x229B730 Offset: 0x2299D30 VA: 0x18229B730
	private static RaycastHit[] Query_SphereCastAll(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229D830 Offset: 0x229BE30 VA: 0x18229D830
	public static RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229D660 Offset: 0x229BC60 VA: 0x18229D660
	public static RaycastHit[] SphereCastAll(Ray ray, float radius, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229E290 Offset: 0x229C890 VA: 0x18229E290
	public static void SyncTransforms() { }

	// RVA: 0x229E2C0 Offset: 0x229C8C0 VA: 0x18229E2C0
	public static bool get_autoSyncTransforms() { }

	// RVA: 0x229E420 Offset: 0x229CA20 VA: 0x18229E420
	public static void set_autoSyncTransforms(bool value) { }

	// RVA: 0x229B600 Offset: 0x2299C00 VA: 0x18229B600
	public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[StaticAccessorAttribute] // RVA: 0x97F60 Offset: 0x97360 VA: 0x180097F60
	[NativeNameAttribute] // RVA: 0x97F60 Offset: 0x97360 VA: 0x180097F60
	// RVA: 0x229AA00 Offset: 0x2299000 VA: 0x18229AA00
	private static bool CheckSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229AA70 Offset: 0x2299070 VA: 0x18229AA70
	public static bool CheckSphere(Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229AB30 Offset: 0x2299130 VA: 0x18229AB30
	public static bool CheckSphere(Vector3 position, float radius, int layerMask) { }

	// RVA: 0x229A1C0 Offset: 0x22987C0 VA: 0x18229A1C0
	public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229D9C0 Offset: 0x229BFC0 VA: 0x18229D9C0
	public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229DAF0 Offset: 0x229C0F0 VA: 0x18229DAF0
	public static int SphereCastNonAlloc(Ray ray, float radius, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[NativeNameAttribute] // RVA: 0x98CD0 Offset: 0x980D0 VA: 0x180098CD0
	[StaticAccessorAttribute] // RVA: 0x98CD0 Offset: 0x980D0 VA: 0x180098CD0
	// RVA: 0x229A760 Offset: 0x2298D60 VA: 0x18229A760
	private static bool CheckCapsule_Internal(PhysicsScene physicsScene, Vector3 start, Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229A7D0 Offset: 0x2298DD0 VA: 0x18229A7D0
	public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229A8B0 Offset: 0x2298EB0 VA: 0x18229A8B0
	public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask) { }

	[NativeNameAttribute] // RVA: 0x99260 Offset: 0x98660 VA: 0x180099260
	[StaticAccessorAttribute] // RVA: 0x99260 Offset: 0x98660 VA: 0x180099260
	// RVA: 0x229A5A0 Offset: 0x2298BA0 VA: 0x18229A5A0
	private static bool CheckBox_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229A610 Offset: 0x2298C10 VA: 0x18229A610
	public static bool CheckBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction) { }

	[StaticAccessorAttribute] // RVA: 0x99B70 Offset: 0x98F70 VA: 0x180099B70
	[NativeNameAttribute] // RVA: 0x99B70 Offset: 0x98F70 VA: 0x180099B70
	// RVA: 0x229B2E0 Offset: 0x22998E0 VA: 0x18229B2E0
	private static Collider[] OverlapBox_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229B350 Offset: 0x2299950 VA: 0x18229B350
	public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229B430 Offset: 0x2299A30 VA: 0x18229B430
	public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask) { }

	// RVA: 0x229B180 Offset: 0x2299780 VA: 0x18229B180
	public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229B510 Offset: 0x2299B10 VA: 0x18229B510
	public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229E370 Offset: 0x229C970 VA: 0x18229E370
	private static void get_gravity_Injected(out Vector3 ret) { }

	// RVA: 0x229E2F0 Offset: 0x229C8F0 VA: 0x18229E2F0
	private static void get_defaultPhysicsScene_Injected(out PhysicsScene ret) { }

	// RVA: 0x229AC40 Offset: 0x2299240 VA: 0x18229AC40
	private static RaycastHit[] Internal_RaycastAll_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229B6C0 Offset: 0x2299CC0 VA: 0x18229B6C0
	private static RaycastHit[] Query_SphereCastAll_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229A990 Offset: 0x2298F90 VA: 0x18229A990
	private static bool CheckSphere_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229A6F0 Offset: 0x2298CF0 VA: 0x18229A6F0
	private static bool CheckCapsule_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 start, ref Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229A530 Offset: 0x2298B30 VA: 0x18229A530
	private static bool CheckBox_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229B270 Offset: 0x2299870 VA: 0x18229B270
	private static Collider[] OverlapBox_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

}

public class Physics : ConsoleSystem // TypeDefIndex: 11952
{	// Fields
	[ClientVar] // RVA: 0xAE960 Offset: 0xADD60 VA: 0x1800AE960
	public static int ragdollmode; // 0x0
	[ClientVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	[ServerVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	public static bool batchsynctransforms; // 0x4

	// Properties
	[ClientVar] // RVA: 0xAFE10 Offset: 0xAF210 VA: 0x1800AFE10
	[ServerVar] // RVA: 0xAFE10 Offset: 0xAF210 VA: 0x1800AFE10
	public static float steps { get; set; }
	[ClientVar] // RVA: 0xAFF80 Offset: 0xAF380 VA: 0x1800AFF80
	[ServerVar] // RVA: 0xAFF80 Offset: 0xAF380 VA: 0x1800AFF80
	public static float minsteps { get; set; }
	[ClientVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	[ServerVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	public static bool autosynctransforms { get; set; }

	// Methods

	// RVA: 0x367BE0 Offset: 0x3661E0 VA: 0x180367BE0
	internal static void ApplyRagdoll(Rigidbody rigidBody) { }

	// RVA: 0x367E10 Offset: 0x366410 VA: 0x180367E10
	public static float get_steps() { }

	// RVA: 0x367E70 Offset: 0x366470 VA: 0x180367E70
	public static void set_steps(float value) { }

	// RVA: 0x367DF0 Offset: 0x3663F0 VA: 0x180367DF0
	public static float get_minsteps() { }

	// RVA: 0x367E40 Offset: 0x366440 VA: 0x180367E40
	public static void set_minsteps(float value) { }

	// RVA: 0x367DE0 Offset: 0x3663E0 VA: 0x180367DE0
	public static bool get_autosynctransforms() { }

	// RVA: 0x367E30 Offset: 0x366430 VA: 0x180367E30
	public static void set_autosynctransforms(bool value) { }

	// RVA: 0x367D80 Offset: 0x366380 VA: 0x180367D80
	public void .ctor() { }

	// RVA: 0x367D30 Offset: 0x366330 VA: 0x180367D30
	private static void .cctor() { }

}

