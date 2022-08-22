public class Physics // TypeDefIndex: 3934
{	// Properties
	public static Vector3 gravity { get; }
	public static bool queriesHitBackfaces { get; set; }
	[NativePropertyAttribute] // RVA: 0x9A9E0 Offset: 0x99DE0 VA: 0x18009A9E0
	public static PhysicsScene defaultPhysicsScene { get; }
	public static bool autoSyncTransforms { get; set; }

	// Methods

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x229D8D0 Offset: 0x229BED0 VA: 0x18229D8D0
	public static Vector3 get_gravity() { }

	// RVA: 0x229D910 Offset: 0x229BF10 VA: 0x18229D910
	public static bool get_queriesHitBackfaces() { }

	// RVA: 0x229D980 Offset: 0x229BF80 VA: 0x18229D980
	public static void set_queriesHitBackfaces(bool value) { }

	// RVA: 0x229D850 Offset: 0x229BE50 VA: 0x18229D850
	public static PhysicsScene get_defaultPhysicsScene() { }

	// RVA: 0x229A100 Offset: 0x2298700 VA: 0x18229A100
	public static void IgnoreCollision(Collider collider1, Collider collider2, bool ignore) { }

	// RVA: 0x229C070 Offset: 0x229A670 VA: 0x18229C070
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229C5E0 Offset: 0x229ABE0 VA: 0x18229C5E0
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229BDD0 Offset: 0x229A3D0 VA: 0x18229BDD0
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229C350 Offset: 0x229A950 VA: 0x18229C350
	public static bool Raycast(Vector3 origin, Vector3 direction) { }

	// RVA: 0x229BF90 Offset: 0x229A590 VA: 0x18229BF90
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[ExcludeFromDocsAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x229CAA0 Offset: 0x229B0A0 VA: 0x18229CAA0
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229C510 Offset: 0x229AB10 VA: 0x18229C510
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229BD00 Offset: 0x229A300 VA: 0x18229BD00
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo) { }

	// RVA: 0x229C9A0 Offset: 0x229AFA0 VA: 0x18229C9A0
	public static bool Raycast(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229C140 Offset: 0x229A740 VA: 0x18229C140
	public static bool Raycast(Ray ray, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229BEA0 Offset: 0x229A4A0 VA: 0x18229BEA0
	public static bool Raycast(Ray ray, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229C8B0 Offset: 0x229AEB0 VA: 0x18229C8B0
	public static bool Raycast(Ray ray) { }

	// RVA: 0x229C240 Offset: 0x229A840 VA: 0x18229C240
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229C400 Offset: 0x229AA00 VA: 0x18229C400
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229C7B0 Offset: 0x229ADB0 VA: 0x18229C7B0
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229C6B0 Offset: 0x229ACB0 VA: 0x18229C6B0
	public static bool Raycast(Ray ray, out RaycastHit hitInfo) { }

	// RVA: 0x229A240 Offset: 0x2298840 VA: 0x18229A240
	public static bool Linecast(Vector3 start, Vector3 end, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229A520 Offset: 0x2298B20 VA: 0x18229A520
	public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229A3B0 Offset: 0x22989B0 VA: 0x18229A3B0
	public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, int layerMask) { }

	// RVA: 0x2299940 Offset: 0x2297F40 VA: 0x182299940
	public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2299830 Offset: 0x2297E30 VA: 0x182299830
	public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	// RVA: 0x229D2E0 Offset: 0x229B8E0 VA: 0x18229D2E0
	public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229D3D0 Offset: 0x229B9D0 VA: 0x18229D3D0
	public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	// RVA: 0x229D630 Offset: 0x229BC30 VA: 0x18229D630
	public static bool SphereCast(Ray ray, float radius, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229D180 Offset: 0x229B780 VA: 0x18229D180
	public static bool SphereCast(Ray ray, float radius, float maxDistance, int layerMask) { }

	// RVA: 0x229D500 Offset: 0x229BB00 VA: 0x18229D500
	public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229D770 Offset: 0x229BD70 VA: 0x18229D770
	public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229D4C0 Offset: 0x229BAC0 VA: 0x18229D4C0
	public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance) { }

	// RVA: 0x2299380 Offset: 0x2297980 VA: 0x182299380
	public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2299530 Offset: 0x2297B30 VA: 0x182299530
	public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance, int layerMask) { }

	[NativeNameAttribute] // RVA: 0x95E10 Offset: 0x95210 VA: 0x180095E10
	[StaticAccessorAttribute] // RVA: 0x95E10 Offset: 0x95210 VA: 0x180095E10
	// RVA: 0x229A1D0 Offset: 0x22987D0 VA: 0x18229A1D0
	private static RaycastHit[] Internal_RaycastAll(PhysicsScene physicsScene, Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229ADB0 Offset: 0x22993B0 VA: 0x18229ADB0
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229AD60 Offset: 0x2299360 VA: 0x18229AD60
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229B010 Offset: 0x2299610 VA: 0x18229B010
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229B060 Offset: 0x2299660 VA: 0x18229B060
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction) { }

	// RVA: 0x229B160 Offset: 0x2299760 VA: 0x18229B160
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[ExcludeFromDocsAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x229B0C0 Offset: 0x22996C0 VA: 0x18229B0C0
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229AF70 Offset: 0x2299570 VA: 0x18229AF70
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229ACD0 Offset: 0x22992D0 VA: 0x18229ACD0
	public static RaycastHit[] RaycastAll(Ray ray) { }

	// RVA: 0x229B4D0 Offset: 0x2299AD0 VA: 0x18229B4D0
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[ExcludeFromDocsAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x229BA50 Offset: 0x229A050 VA: 0x18229BA50
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229B210 Offset: 0x2299810 VA: 0x18229B210
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229B790 Offset: 0x2299D90 VA: 0x18229B790
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results) { }

	// RVA: 0x229B380 Offset: 0x2299980 VA: 0x18229B380
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229B900 Offset: 0x2299F00 VA: 0x18229B900
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229B640 Offset: 0x2299C40 VA: 0x18229B640
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229BBC0 Offset: 0x229A1C0 VA: 0x18229BBC0
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results) { }

	[NativeNameAttribute] // RVA: 0x97450 Offset: 0x96850 VA: 0x180097450
	[StaticAccessorAttribute] // RVA: 0x97450 Offset: 0x96850 VA: 0x180097450
	// RVA: 0x229AC50 Offset: 0x2299250 VA: 0x18229AC50
	private static RaycastHit[] Query_SphereCastAll(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229CD50 Offset: 0x229B350 VA: 0x18229CD50
	public static RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229CB80 Offset: 0x229B180 VA: 0x18229CB80
	public static RaycastHit[] SphereCastAll(Ray ray, float radius, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229D7B0 Offset: 0x229BDB0 VA: 0x18229D7B0
	public static void SyncTransforms() { }

	// RVA: 0x229D7E0 Offset: 0x229BDE0 VA: 0x18229D7E0
	public static bool get_autoSyncTransforms() { }

	// RVA: 0x229D940 Offset: 0x229BF40 VA: 0x18229D940
	public static void set_autoSyncTransforms(bool value) { }

	// RVA: 0x229AB20 Offset: 0x2299120 VA: 0x18229AB20
	public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[StaticAccessorAttribute] // RVA: 0x97F60 Offset: 0x97360 VA: 0x180097F60
	[NativeNameAttribute] // RVA: 0x97F60 Offset: 0x97360 VA: 0x180097F60
	// RVA: 0x2299F20 Offset: 0x2298520 VA: 0x182299F20
	private static bool CheckSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2299F90 Offset: 0x2298590 VA: 0x182299F90
	public static bool CheckSphere(Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229A050 Offset: 0x2298650 VA: 0x18229A050
	public static bool CheckSphere(Vector3 position, float radius, int layerMask) { }

	// RVA: 0x22996E0 Offset: 0x2297CE0 VA: 0x1822996E0
	public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229CEE0 Offset: 0x229B4E0 VA: 0x18229CEE0
	public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229D010 Offset: 0x229B610 VA: 0x18229D010
	public static int SphereCastNonAlloc(Ray ray, float radius, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[NativeNameAttribute] // RVA: 0x98CD0 Offset: 0x980D0 VA: 0x180098CD0
	[StaticAccessorAttribute] // RVA: 0x98CD0 Offset: 0x980D0 VA: 0x180098CD0
	// RVA: 0x2299C80 Offset: 0x2298280 VA: 0x182299C80
	private static bool CheckCapsule_Internal(PhysicsScene physicsScene, Vector3 start, Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2299CF0 Offset: 0x22982F0 VA: 0x182299CF0
	public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2299DD0 Offset: 0x22983D0 VA: 0x182299DD0
	public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask) { }

	[NativeNameAttribute] // RVA: 0x99260 Offset: 0x98660 VA: 0x180099260
	[StaticAccessorAttribute] // RVA: 0x99260 Offset: 0x98660 VA: 0x180099260
	// RVA: 0x2299AC0 Offset: 0x22980C0 VA: 0x182299AC0
	private static bool CheckBox_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2299B30 Offset: 0x2298130 VA: 0x182299B30
	public static bool CheckBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction) { }

	[StaticAccessorAttribute] // RVA: 0x99B70 Offset: 0x98F70 VA: 0x180099B70
	[NativeNameAttribute] // RVA: 0x99B70 Offset: 0x98F70 VA: 0x180099B70
	// RVA: 0x229A800 Offset: 0x2298E00 VA: 0x18229A800
	private static Collider[] OverlapBox_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229A870 Offset: 0x2298E70 VA: 0x18229A870
	public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229A950 Offset: 0x2298F50 VA: 0x18229A950
	public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask) { }

	// RVA: 0x229A6A0 Offset: 0x2298CA0 VA: 0x18229A6A0
	public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229AA30 Offset: 0x2299030 VA: 0x18229AA30
	public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229D890 Offset: 0x229BE90 VA: 0x18229D890
	private static void get_gravity_Injected(out Vector3 ret) { }

	// RVA: 0x229D810 Offset: 0x229BE10 VA: 0x18229D810
	private static void get_defaultPhysicsScene_Injected(out PhysicsScene ret) { }

	// RVA: 0x229A160 Offset: 0x2298760 VA: 0x18229A160
	private static RaycastHit[] Internal_RaycastAll_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229ABE0 Offset: 0x22991E0 VA: 0x18229ABE0
	private static RaycastHit[] Query_SphereCastAll_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2299EB0 Offset: 0x22984B0 VA: 0x182299EB0
	private static bool CheckSphere_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2299C10 Offset: 0x2298210 VA: 0x182299C10
	private static bool CheckCapsule_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 start, ref Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2299A50 Offset: 0x2298050 VA: 0x182299A50
	private static bool CheckBox_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x229A790 Offset: 0x2298D90 VA: 0x18229A790
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

