public class Physics // TypeDefIndex: 3934
{	// Properties
	public static Vector3 gravity { get; }
	public static bool queriesHitBackfaces { get; set; }
	[NativePropertyAttribute] // RVA: 0x9A950 Offset: 0x99D50 VA: 0x18009A950
	public static PhysicsScene defaultPhysicsScene { get; }
	public static bool autoSyncTransforms { get; set; }

	// Methods

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x229DA90 Offset: 0x229C090 VA: 0x18229DA90
	public static Vector3 get_gravity() { }

	// RVA: 0x229DAD0 Offset: 0x229C0D0 VA: 0x18229DAD0
	public static bool get_queriesHitBackfaces() { }

	// RVA: 0x229DB40 Offset: 0x229C140 VA: 0x18229DB40
	public static void set_queriesHitBackfaces(bool value) { }

	// RVA: 0x229DA10 Offset: 0x229C010 VA: 0x18229DA10
	public static PhysicsScene get_defaultPhysicsScene() { }

	// RVA: 0x229A2C0 Offset: 0x22988C0 VA: 0x18229A2C0
	public static void IgnoreCollision(Collider collider1, Collider collider2, bool ignore) { }

	// RVA: 0x229C230 Offset: 0x229A830 VA: 0x18229C230
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x229C7A0 Offset: 0x229ADA0 VA: 0x18229C7A0
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x229BF90 Offset: 0x229A590 VA: 0x18229BF90
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x229C510 Offset: 0x229AB10 VA: 0x18229C510
	public static bool Raycast(Vector3 origin, Vector3 direction) { }

	// RVA: 0x229C150 Offset: 0x229A750 VA: 0x18229C150
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	[ExcludeFromDocsAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	// RVA: 0x229CC60 Offset: 0x229B260 VA: 0x18229CC60
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x229C6D0 Offset: 0x229ACD0 VA: 0x18229C6D0
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x229BEC0 Offset: 0x229A4C0 VA: 0x18229BEC0
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo) { }

	// RVA: 0x229CB60 Offset: 0x229B160 VA: 0x18229CB60
	public static bool Raycast(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x229C300 Offset: 0x229A900 VA: 0x18229C300
	public static bool Raycast(Ray ray, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x229C060 Offset: 0x229A660 VA: 0x18229C060
	public static bool Raycast(Ray ray, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x229CA70 Offset: 0x229B070 VA: 0x18229CA70
	public static bool Raycast(Ray ray) { }

	// RVA: 0x229C400 Offset: 0x229AA00 VA: 0x18229C400
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x229C5C0 Offset: 0x229ABC0 VA: 0x18229C5C0
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x229C970 Offset: 0x229AF70 VA: 0x18229C970
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x229C870 Offset: 0x229AE70 VA: 0x18229C870
	public static bool Raycast(Ray ray, out RaycastHit hitInfo) { }

	// RVA: 0x229A400 Offset: 0x2298A00 VA: 0x18229A400
	public static bool Linecast(Vector3 start, Vector3 end, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229A6E0 Offset: 0x2298CE0 VA: 0x18229A6E0
	public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x229A570 Offset: 0x2298B70 VA: 0x18229A570
	public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, int layerMask) { }

	// RVA: 0x2299B00 Offset: 0x2298100 VA: 0x182299B00
	public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22999F0 Offset: 0x2297FF0 VA: 0x1822999F0
	public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	// RVA: 0x229D4A0 Offset: 0x229BAA0 VA: 0x18229D4A0
	public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x229D590 Offset: 0x229BB90 VA: 0x18229D590
	public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	// RVA: 0x229D7F0 Offset: 0x229BDF0 VA: 0x18229D7F0
	public static bool SphereCast(Ray ray, float radius, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x229D340 Offset: 0x229B940 VA: 0x18229D340
	public static bool SphereCast(Ray ray, float radius, float maxDistance, int layerMask) { }

	// RVA: 0x229D6C0 Offset: 0x229BCC0 VA: 0x18229D6C0
	public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x229D930 Offset: 0x229BF30 VA: 0x18229D930
	public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x229D680 Offset: 0x229BC80 VA: 0x18229D680
	public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance) { }

	// RVA: 0x2299540 Offset: 0x2297B40 VA: 0x182299540
	public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22996F0 Offset: 0x2297CF0 VA: 0x1822996F0
	public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance, int layerMask) { }

	[NativeNameAttribute] // RVA: 0x95D40 Offset: 0x95140 VA: 0x180095D40
	[StaticAccessorAttribute] // RVA: 0x95D40 Offset: 0x95140 VA: 0x180095D40
	// RVA: 0x229A390 Offset: 0x2298990 VA: 0x18229A390
	private static RaycastHit[] Internal_RaycastAll(PhysicsScene physicsScene, Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229AF70 Offset: 0x2299570 VA: 0x18229AF70
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x229AF20 Offset: 0x2299520 VA: 0x18229AF20
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x229B1D0 Offset: 0x22997D0 VA: 0x18229B1D0
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x229B220 Offset: 0x2299820 VA: 0x18229B220
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction) { }

	// RVA: 0x229B320 Offset: 0x2299920 VA: 0x18229B320
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	[ExcludeFromDocsAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	// RVA: 0x229B280 Offset: 0x2299880 VA: 0x18229B280
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x229B130 Offset: 0x2299730 VA: 0x18229B130
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x229AE90 Offset: 0x2299490 VA: 0x18229AE90
	public static RaycastHit[] RaycastAll(Ray ray) { }

	// RVA: 0x229B690 Offset: 0x2299C90 VA: 0x18229B690
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	[ExcludeFromDocsAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	// RVA: 0x229BC10 Offset: 0x229A210 VA: 0x18229BC10
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x229B3D0 Offset: 0x22999D0 VA: 0x18229B3D0
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x229B950 Offset: 0x2299F50 VA: 0x18229B950
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results) { }

	// RVA: 0x229B540 Offset: 0x2299B40 VA: 0x18229B540
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x229BAC0 Offset: 0x229A0C0 VA: 0x18229BAC0
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x229B800 Offset: 0x2299E00 VA: 0x18229B800
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x229BD80 Offset: 0x229A380 VA: 0x18229BD80
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results) { }

	[NativeNameAttribute] // RVA: 0x97290 Offset: 0x96690 VA: 0x180097290
	[StaticAccessorAttribute] // RVA: 0x97290 Offset: 0x96690 VA: 0x180097290
	// RVA: 0x229AE10 Offset: 0x2299410 VA: 0x18229AE10
	private static RaycastHit[] Query_SphereCastAll(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229CF10 Offset: 0x229B510 VA: 0x18229CF10
	public static RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229CD40 Offset: 0x229B340 VA: 0x18229CD40
	public static RaycastHit[] SphereCastAll(Ray ray, float radius, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229D970 Offset: 0x229BF70 VA: 0x18229D970
	public static void SyncTransforms() { }

	// RVA: 0x229D9A0 Offset: 0x229BFA0 VA: 0x18229D9A0
	public static bool get_autoSyncTransforms() { }

	// RVA: 0x229DB00 Offset: 0x229C100 VA: 0x18229DB00
	public static void set_autoSyncTransforms(bool value) { }

	// RVA: 0x229ACE0 Offset: 0x22992E0 VA: 0x18229ACE0
	public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[StaticAccessorAttribute] // RVA: 0x97DE0 Offset: 0x971E0 VA: 0x180097DE0
	[NativeNameAttribute] // RVA: 0x97DE0 Offset: 0x971E0 VA: 0x180097DE0
	// RVA: 0x229A0E0 Offset: 0x22986E0 VA: 0x18229A0E0
	private static bool CheckSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229A150 Offset: 0x2298750 VA: 0x18229A150
	public static bool CheckSphere(Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x229A210 Offset: 0x2298810 VA: 0x18229A210
	public static bool CheckSphere(Vector3 position, float radius, int layerMask) { }

	// RVA: 0x22998A0 Offset: 0x2297EA0 VA: 0x1822998A0
	public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229D0A0 Offset: 0x229B6A0 VA: 0x18229D0A0
	public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229D1D0 Offset: 0x229B7D0 VA: 0x18229D1D0
	public static int SphereCastNonAlloc(Ray ray, float radius, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[NativeNameAttribute] // RVA: 0x98C40 Offset: 0x98040 VA: 0x180098C40
	[StaticAccessorAttribute] // RVA: 0x98C40 Offset: 0x98040 VA: 0x180098C40
	// RVA: 0x2299E40 Offset: 0x2298440 VA: 0x182299E40
	private static bool CheckCapsule_Internal(PhysicsScene physicsScene, Vector3 start, Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2299EB0 Offset: 0x22984B0 VA: 0x182299EB0
	public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2299F90 Offset: 0x2298590 VA: 0x182299F90
	public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask) { }

	[NativeNameAttribute] // RVA: 0x99250 Offset: 0x98650 VA: 0x180099250
	[StaticAccessorAttribute] // RVA: 0x99250 Offset: 0x98650 VA: 0x180099250
	// RVA: 0x2299C80 Offset: 0x2298280 VA: 0x182299C80
	private static bool CheckBox_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2299CF0 Offset: 0x22982F0 VA: 0x182299CF0
	public static bool CheckBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction) { }

	[StaticAccessorAttribute] // RVA: 0x99AE0 Offset: 0x98EE0 VA: 0x180099AE0
	[NativeNameAttribute] // RVA: 0x99AE0 Offset: 0x98EE0 VA: 0x180099AE0
	// RVA: 0x229A9C0 Offset: 0x2298FC0 VA: 0x18229A9C0
	private static Collider[] OverlapBox_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229AA30 Offset: 0x2299030 VA: 0x18229AA30
	public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x229AB10 Offset: 0x2299110 VA: 0x18229AB10
	public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask) { }

	// RVA: 0x229A860 Offset: 0x2298E60 VA: 0x18229A860
	public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229ABF0 Offset: 0x22991F0 VA: 0x18229ABF0
	public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229DA50 Offset: 0x229C050 VA: 0x18229DA50
	private static void get_gravity_Injected(out Vector3 ret) { }

	// RVA: 0x229D9D0 Offset: 0x229BFD0 VA: 0x18229D9D0
	private static void get_defaultPhysicsScene_Injected(out PhysicsScene ret) { }

	// RVA: 0x229A320 Offset: 0x2298920 VA: 0x18229A320
	private static RaycastHit[] Internal_RaycastAll_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229ADA0 Offset: 0x22993A0 VA: 0x18229ADA0
	private static RaycastHit[] Query_SphereCastAll_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229A070 Offset: 0x2298670 VA: 0x18229A070
	private static bool CheckSphere_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2299DD0 Offset: 0x22983D0 VA: 0x182299DD0
	private static bool CheckCapsule_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 start, ref Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2299C10 Offset: 0x2298210 VA: 0x182299C10
	private static bool CheckBox_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229A950 Offset: 0x2298F50 VA: 0x18229A950
	private static Collider[] OverlapBox_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

}

public class Physics : ConsoleSystem // TypeDefIndex: 11952
{	// Fields
	[ClientVar] // RVA: 0xAE860 Offset: 0xADC60 VA: 0x1800AE860
	public static int ragdollmode; // 0x0
	[ClientVar] // RVA: 0x935D0 Offset: 0x929D0 VA: 0x1800935D0
	[ServerVar] // RVA: 0x935D0 Offset: 0x929D0 VA: 0x1800935D0
	public static bool batchsynctransforms; // 0x4

	// Properties
	[ClientVar] // RVA: 0xAFD70 Offset: 0xAF170 VA: 0x1800AFD70
	[ServerVar] // RVA: 0xAFD70 Offset: 0xAF170 VA: 0x1800AFD70
	public static float steps { get; set; }
	[ClientVar] // RVA: 0xAFEB0 Offset: 0xAF2B0 VA: 0x1800AFEB0
	[ServerVar] // RVA: 0xAFEB0 Offset: 0xAF2B0 VA: 0x1800AFEB0
	public static float minsteps { get; set; }
	[ClientVar] // RVA: 0x935D0 Offset: 0x929D0 VA: 0x1800935D0
	[ServerVar] // RVA: 0x935D0 Offset: 0x929D0 VA: 0x1800935D0
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

