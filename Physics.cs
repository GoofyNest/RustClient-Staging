public class Physics // TypeDefIndex: 3934
{	// Properties
	public static Vector3 gravity { get; }
	public static bool queriesHitBackfaces { get; set; }
	[NativePropertyAttribute] // RVA: 0x9A9E0 Offset: 0x99DE0 VA: 0x18009A9E0
	public static PhysicsScene defaultPhysicsScene { get; }
	public static bool autoSyncTransforms { get; set; }

	// Methods

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x229DB90 Offset: 0x229C190 VA: 0x18229DB90
	public static Vector3 get_gravity() { }

	// RVA: 0x229DBD0 Offset: 0x229C1D0 VA: 0x18229DBD0
	public static bool get_queriesHitBackfaces() { }

	// RVA: 0x229DC40 Offset: 0x229C240 VA: 0x18229DC40
	public static void set_queriesHitBackfaces(bool value) { }

	// RVA: 0x229DB10 Offset: 0x229C110 VA: 0x18229DB10
	public static PhysicsScene get_defaultPhysicsScene() { }

	// RVA: 0x229A3C0 Offset: 0x22989C0 VA: 0x18229A3C0
	public static void IgnoreCollision(Collider collider1, Collider collider2, bool ignore) { }

	// RVA: 0x229C330 Offset: 0x229A930 VA: 0x18229C330
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229C8A0 Offset: 0x229AEA0 VA: 0x18229C8A0
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229C090 Offset: 0x229A690 VA: 0x18229C090
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229C610 Offset: 0x229AC10 VA: 0x18229C610
	public static bool Raycast(Vector3 origin, Vector3 direction) { }

	// RVA: 0x229C250 Offset: 0x229A850 VA: 0x18229C250
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[ExcludeFromDocsAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x229CD60 Offset: 0x229B360 VA: 0x18229CD60
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229C7D0 Offset: 0x229ADD0 VA: 0x18229C7D0
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229BFC0 Offset: 0x229A5C0 VA: 0x18229BFC0
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo) { }

	// RVA: 0x229CC60 Offset: 0x229B260 VA: 0x18229CC60
	public static bool Raycast(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229C400 Offset: 0x229AA00 VA: 0x18229C400
	public static bool Raycast(Ray ray, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229C160 Offset: 0x229A760 VA: 0x18229C160
	public static bool Raycast(Ray ray, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229CB70 Offset: 0x229B170 VA: 0x18229CB70
	public static bool Raycast(Ray ray) { }

	// RVA: 0x229C500 Offset: 0x229AB00 VA: 0x18229C500
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229C6C0 Offset: 0x229ACC0 VA: 0x18229C6C0
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229CA70 Offset: 0x229B070 VA: 0x18229CA70
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229C970 Offset: 0x229AF70 VA: 0x18229C970
	public static bool Raycast(Ray ray, out RaycastHit hitInfo) { }

	// RVA: 0x229A500 Offset: 0x2298B00 VA: 0x18229A500
	public static bool Linecast(Vector3 start, Vector3 end, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229A7E0 Offset: 0x2298DE0 VA: 0x18229A7E0
	public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229A670 Offset: 0x2298C70 VA: 0x18229A670
	public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, int layerMask) { }

	// RVA: 0x2299C00 Offset: 0x2298200 VA: 0x182299C00
	public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2299AF0 Offset: 0x22980F0 VA: 0x182299AF0
	public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	// RVA: 0x229D5A0 Offset: 0x229BBA0 VA: 0x18229D5A0
	public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229D690 Offset: 0x229BC90 VA: 0x18229D690
	public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	// RVA: 0x229D8F0 Offset: 0x229BEF0 VA: 0x18229D8F0
	public static bool SphereCast(Ray ray, float radius, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229D440 Offset: 0x229BA40 VA: 0x18229D440
	public static bool SphereCast(Ray ray, float radius, float maxDistance, int layerMask) { }

	// RVA: 0x229D7C0 Offset: 0x229BDC0 VA: 0x18229D7C0
	public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229DA30 Offset: 0x229C030 VA: 0x18229DA30
	public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229D780 Offset: 0x229BD80 VA: 0x18229D780
	public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance) { }

	// RVA: 0x2299640 Offset: 0x2297C40 VA: 0x182299640
	public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22997F0 Offset: 0x2297DF0 VA: 0x1822997F0
	public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance, int layerMask) { }

	[NativeNameAttribute] // RVA: 0x95E10 Offset: 0x95210 VA: 0x180095E10
	[StaticAccessorAttribute] // RVA: 0x95E10 Offset: 0x95210 VA: 0x180095E10
	// RVA: 0x229A490 Offset: 0x2298A90 VA: 0x18229A490
	private static RaycastHit[] Internal_RaycastAll(PhysicsScene physicsScene, Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229B070 Offset: 0x2299670 VA: 0x18229B070
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229B020 Offset: 0x2299620 VA: 0x18229B020
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229B2D0 Offset: 0x22998D0 VA: 0x18229B2D0
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229B320 Offset: 0x2299920 VA: 0x18229B320
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction) { }

	// RVA: 0x229B420 Offset: 0x2299A20 VA: 0x18229B420
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[ExcludeFromDocsAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x229B380 Offset: 0x2299980 VA: 0x18229B380
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229B230 Offset: 0x2299830 VA: 0x18229B230
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229AF90 Offset: 0x2299590 VA: 0x18229AF90
	public static RaycastHit[] RaycastAll(Ray ray) { }

	// RVA: 0x229B790 Offset: 0x2299D90 VA: 0x18229B790
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[ExcludeFromDocsAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x229BD10 Offset: 0x229A310 VA: 0x18229BD10
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229B4D0 Offset: 0x2299AD0 VA: 0x18229B4D0
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229BA50 Offset: 0x229A050 VA: 0x18229BA50
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results) { }

	// RVA: 0x229B640 Offset: 0x2299C40 VA: 0x18229B640
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229BBC0 Offset: 0x229A1C0 VA: 0x18229BBC0
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229B900 Offset: 0x2299F00 VA: 0x18229B900
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229BE80 Offset: 0x229A480 VA: 0x18229BE80
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results) { }

	[NativeNameAttribute] // RVA: 0x97450 Offset: 0x96850 VA: 0x180097450
	[StaticAccessorAttribute] // RVA: 0x97450 Offset: 0x96850 VA: 0x180097450
	// RVA: 0x229AF10 Offset: 0x2299510 VA: 0x18229AF10
	private static RaycastHit[] Query_SphereCastAll(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229D010 Offset: 0x229B610 VA: 0x18229D010
	public static RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229CE40 Offset: 0x229B440 VA: 0x18229CE40
	public static RaycastHit[] SphereCastAll(Ray ray, float radius, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229DA70 Offset: 0x229C070 VA: 0x18229DA70
	public static void SyncTransforms() { }

	// RVA: 0x229DAA0 Offset: 0x229C0A0 VA: 0x18229DAA0
	public static bool get_autoSyncTransforms() { }

	// RVA: 0x229DC00 Offset: 0x229C200 VA: 0x18229DC00
	public static void set_autoSyncTransforms(bool value) { }

	// RVA: 0x229ADE0 Offset: 0x22993E0 VA: 0x18229ADE0
	public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[StaticAccessorAttribute] // RVA: 0x97F60 Offset: 0x97360 VA: 0x180097F60
	[NativeNameAttribute] // RVA: 0x97F60 Offset: 0x97360 VA: 0x180097F60
	// RVA: 0x229A1E0 Offset: 0x22987E0 VA: 0x18229A1E0
	private static bool CheckSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229A250 Offset: 0x2298850 VA: 0x18229A250
	public static bool CheckSphere(Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229A310 Offset: 0x2298910 VA: 0x18229A310
	public static bool CheckSphere(Vector3 position, float radius, int layerMask) { }

	// RVA: 0x22999A0 Offset: 0x2297FA0 VA: 0x1822999A0
	public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229D1A0 Offset: 0x229B7A0 VA: 0x18229D1A0
	public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229D2D0 Offset: 0x229B8D0 VA: 0x18229D2D0
	public static int SphereCastNonAlloc(Ray ray, float radius, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[NativeNameAttribute] // RVA: 0x98CD0 Offset: 0x980D0 VA: 0x180098CD0
	[StaticAccessorAttribute] // RVA: 0x98CD0 Offset: 0x980D0 VA: 0x180098CD0
	// RVA: 0x2299F40 Offset: 0x2298540 VA: 0x182299F40
	private static bool CheckCapsule_Internal(PhysicsScene physicsScene, Vector3 start, Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2299FB0 Offset: 0x22985B0 VA: 0x182299FB0
	public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229A090 Offset: 0x2298690 VA: 0x18229A090
	public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask) { }

	[NativeNameAttribute] // RVA: 0x99260 Offset: 0x98660 VA: 0x180099260
	[StaticAccessorAttribute] // RVA: 0x99260 Offset: 0x98660 VA: 0x180099260
	// RVA: 0x2299D80 Offset: 0x2298380 VA: 0x182299D80
	private static bool CheckBox_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2299DF0 Offset: 0x22983F0 VA: 0x182299DF0
	public static bool CheckBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction) { }

	[StaticAccessorAttribute] // RVA: 0x99B70 Offset: 0x98F70 VA: 0x180099B70
	[NativeNameAttribute] // RVA: 0x99B70 Offset: 0x98F70 VA: 0x180099B70
	// RVA: 0x229AAC0 Offset: 0x22990C0 VA: 0x18229AAC0
	private static Collider[] OverlapBox_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229AB30 Offset: 0x2299130 VA: 0x18229AB30
	public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229AC10 Offset: 0x2299210 VA: 0x18229AC10
	public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask) { }

	// RVA: 0x229A960 Offset: 0x2298F60 VA: 0x18229A960
	public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229ACF0 Offset: 0x22992F0 VA: 0x18229ACF0
	public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229DB50 Offset: 0x229C150 VA: 0x18229DB50
	private static void get_gravity_Injected(out Vector3 ret) { }

	// RVA: 0x229DAD0 Offset: 0x229C0D0 VA: 0x18229DAD0
	private static void get_defaultPhysicsScene_Injected(out PhysicsScene ret) { }

	// RVA: 0x229A420 Offset: 0x2298A20 VA: 0x18229A420
	private static RaycastHit[] Internal_RaycastAll_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229AEA0 Offset: 0x22994A0 VA: 0x18229AEA0
	private static RaycastHit[] Query_SphereCastAll_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229A170 Offset: 0x2298770 VA: 0x18229A170
	private static bool CheckSphere_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2299ED0 Offset: 0x22984D0 VA: 0x182299ED0
	private static bool CheckCapsule_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 start, ref Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2299D10 Offset: 0x2298310 VA: 0x182299D10
	private static bool CheckBox_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229AA50 Offset: 0x2299050 VA: 0x18229AA50
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

