public class Physics // TypeDefIndex: 3934
{	public static Vector3 gravity { get; }
	public static bool queriesHitBackfaces { get; set; }
	[NativePropertyAttribute] // RVA: 0x9AA50 Offset: 0x99E50 VA: 0x18009AA50
	public static PhysicsScene defaultPhysicsScene { get; }
	public static bool autoSyncTransforms { get; set; }


	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static Vector3 get_gravity() { }

	public static bool get_queriesHitBackfaces() { }

	public static void set_queriesHitBackfaces(bool value) { }

	public static PhysicsScene get_defaultPhysicsScene() { }

	public static void IgnoreCollision(Collider collider1, Collider collider2, bool ignore) { }

	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static bool Raycast(Vector3 origin, Vector3 direction) { }

	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x71870 Offset: 0x70C70 VA: 0x180071870
	[ExcludeFromDocsAttribute] // RVA: 0x71870 Offset: 0x70C70 VA: 0x180071870
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo) { }

	public static bool Raycast(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static bool Raycast(Ray ray, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static bool Raycast(Ray ray, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static bool Raycast(Ray ray) { }

	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static bool Raycast(Ray ray, out RaycastHit hitInfo) { }

	public static bool Linecast(Vector3 start, Vector3 end, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, int layerMask) { }

	public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	public static bool SphereCast(Ray ray, float radius, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static bool SphereCast(Ray ray, float radius, float maxDistance, int layerMask) { }

	public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance) { }

	public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance, int layerMask) { }

	[NativeNameAttribute] // RVA: 0x95F70 Offset: 0x95370 VA: 0x180095F70
	[StaticAccessorAttribute] // RVA: 0x95F70 Offset: 0x95370 VA: 0x180095F70
	private static RaycastHit[] Internal_RaycastAll(PhysicsScene physicsScene, Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction) { }

	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x71870 Offset: 0x70C70 VA: 0x180071870
	[ExcludeFromDocsAttribute] // RVA: 0x71870 Offset: 0x70C70 VA: 0x180071870
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static RaycastHit[] RaycastAll(Ray ray) { }

	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x71870 Offset: 0x70C70 VA: 0x180071870
	[ExcludeFromDocsAttribute] // RVA: 0x71870 Offset: 0x70C70 VA: 0x180071870
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results) { }

	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results) { }

	[NativeNameAttribute] // RVA: 0x97520 Offset: 0x96920 VA: 0x180097520
	[StaticAccessorAttribute] // RVA: 0x97520 Offset: 0x96920 VA: 0x180097520
	private static RaycastHit[] Query_SphereCastAll(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	public static RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	public static RaycastHit[] SphereCastAll(Ray ray, float radius, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	public static void SyncTransforms() { }

	public static bool get_autoSyncTransforms() { }

	public static void set_autoSyncTransforms(bool value) { }

	public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[StaticAccessorAttribute] // RVA: 0x98110 Offset: 0x97510 VA: 0x180098110
	[NativeNameAttribute] // RVA: 0x98110 Offset: 0x97510 VA: 0x180098110
	private static bool CheckSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	public static bool CheckSphere(Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static bool CheckSphere(Vector3 position, float radius, int layerMask) { }

	public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	public static int SphereCastNonAlloc(Ray ray, float radius, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[NativeNameAttribute] // RVA: 0x98E40 Offset: 0x98240 VA: 0x180098E40
	[StaticAccessorAttribute] // RVA: 0x98E40 Offset: 0x98240 VA: 0x180098E40
	private static bool CheckCapsule_Internal(PhysicsScene physicsScene, Vector3 start, Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask) { }

	[NativeNameAttribute] // RVA: 0x99560 Offset: 0x98960 VA: 0x180099560
	[StaticAccessorAttribute] // RVA: 0x99560 Offset: 0x98960 VA: 0x180099560
	private static bool CheckBox_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction) { }

	public static bool CheckBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction) { }

	[StaticAccessorAttribute] // RVA: 0x99D90 Offset: 0x99190 VA: 0x180099D90
	[NativeNameAttribute] // RVA: 0x99D90 Offset: 0x99190 VA: 0x180099D90
	private static Collider[] OverlapBox_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask) { }

	public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	private static void get_gravity_Injected(out Vector3 ret) { }

	private static void get_defaultPhysicsScene_Injected(out PhysicsScene ret) { }

	private static RaycastHit[] Internal_RaycastAll_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	private static RaycastHit[] Query_SphereCastAll_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	private static bool CheckSphere_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	private static bool CheckCapsule_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 start, ref Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	private static bool CheckBox_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction) { }

	private static Collider[] OverlapBox_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

}

public class Physics : ConsoleSystem // TypeDefIndex: 11956
{	[ClientVar] // RVA: 0xAD050 Offset: 0xAC450 VA: 0x1800AD050
	public static int ragdollmode; // 0x0
	[ClientVar] // RVA: 0x93230 Offset: 0x92630 VA: 0x180093230
	[ServerVar] // RVA: 0x93230 Offset: 0x92630 VA: 0x180093230
	public static bool batchsynctransforms; // 0x4

	[ClientVar] // RVA: 0xAD170 Offset: 0xAC570 VA: 0x1800AD170
	[ServerVar] // RVA: 0xAD170 Offset: 0xAC570 VA: 0x1800AD170
	public static float steps { get; set; }
	[ClientVar] // RVA: 0xAD360 Offset: 0xAC760 VA: 0x1800AD360
	[ServerVar] // RVA: 0xAD360 Offset: 0xAC760 VA: 0x1800AD360
	public static float minsteps { get; set; }
	[ClientVar] // RVA: 0x93230 Offset: 0x92630 VA: 0x180093230
	[ServerVar] // RVA: 0x93230 Offset: 0x92630 VA: 0x180093230
	public static bool autosynctransforms { get; set; }


	internal static void ApplyRagdoll(Rigidbody rigidBody) { }

	public static float get_steps() { }

	public static void set_steps(float value) { }

	public static float get_minsteps() { }

	public static void set_minsteps(float value) { }

	public static bool get_autosynctransforms() { }

	public static void set_autosynctransforms(bool value) { }

	public void .ctor() { }

	private static void .cctor() { }

}

