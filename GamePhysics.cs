public static class GamePhysics // TypeDefIndex: 9259
{	// Fields
	public const int BufferLength = 8192;
	private static RaycastHit[] hitBuffer; // 0x0
	private static RaycastHit[] hitBufferB; // 0x8
	private static Collider[] colBuffer; // 0x10

	// Methods

	// RVA: 0x75A630 Offset: 0x758C30 VA: 0x18075A630
	public static bool CheckSphere(Vector3 position, float radius, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 0) { }

	// RVA: 0x759BC0 Offset: 0x7581C0 VA: 0x180759BC0
	public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 0) { }

	// RVA: 0x75A500 Offset: 0x758B00 VA: 0x18075A500
	public static bool CheckOBB(OBB obb, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 0) { }

	// RVA: 0x75A280 Offset: 0x758880 VA: 0x18075A280
	public static bool CheckOBBAndEntity(OBB obb, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 0, BaseEntity ignoreEntity) { }

	// RVA: 0x759A60 Offset: 0x758060 VA: 0x180759A60
	public static bool CheckBounds(Bounds bounds, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 0) { }

	// RVA: 0x759ED0 Offset: 0x7584D0 VA: 0x180759ED0
	public static bool CheckInsideNonConvexMesh(Vector3 point, int layerMask = -5) { }

	// RVA: 0x759D40 Offset: 0x758340 VA: 0x180759D40
	public static bool CheckInsideAnyCollider(Vector3 point, int layerMask = -5) { }

	// RVA: 0x75BA40 Offset: 0x75A040 VA: 0x18075BA40
	public static void OverlapSphere(Vector3 position, float radius, List<Collider> list, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }

	// RVA: 0x7597C0 Offset: 0x757DC0 VA: 0x1807597C0
	public static void CapsuleSweep(Vector3 position0, Vector3 position1, float radius, Vector3 direction, float distance, List<RaycastHit> list, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }

	// RVA: 0x75B7C0 Offset: 0x759DC0 VA: 0x18075B7C0
	public static void OverlapCapsule(Vector3 point0, Vector3 point1, float radius, List<Collider> list, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }

	// RVA: 0x75B8F0 Offset: 0x759EF0 VA: 0x18075B8F0
	public static void OverlapOBB(OBB obb, List<Collider> list, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }

	// RVA: 0x75B620 Offset: 0x759C20 VA: 0x18075B620
	public static void OverlapBounds(Bounds bounds, List<Collider> list, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }

	// RVA: 0x759620 Offset: 0x757C20 VA: 0x180759620
	private static void BufferToList(int count, List<Collider> list) { }

	// RVA: -1 Offset: -1
	public static bool CheckSphere<T>(Vector3 pos, float radius, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125D480 Offset: 0x125BA80 VA: 0x18125D480
	|-GamePhysics.CheckSphere<object>
	|-GamePhysics.CheckSphere<TerrainCollisionTrigger>
	|-GamePhysics.CheckSphere<WaterVisibilityTrigger>
	*/

	// RVA: -1 Offset: -1
	public static bool CheckCapsule<T>(Vector3 start, Vector3 end, float radius, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125D170 Offset: 0x125B770 VA: 0x18125D170
	|-GamePhysics.CheckCapsule<object>
	|-GamePhysics.CheckCapsule<WaterVisibilityTrigger>
	*/

	// RVA: -1 Offset: -1
	public static bool CheckOBB<T>(OBB obb, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125D360 Offset: 0x125B960 VA: 0x18125D360
	|-GamePhysics.CheckOBB<object>
	*/

	// RVA: -1 Offset: -1
	public static bool CheckBounds<T>(Bounds bounds, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125D070 Offset: 0x125B670 VA: 0x18125D070
	|-GamePhysics.CheckBounds<object>
	|-GamePhysics.CheckBounds<WaterVisibilityTrigger>
	*/

	// RVA: -1 Offset: -1
	private static bool CheckComponent<T>(List<Collider> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125D2B0 Offset: 0x125B8B0 VA: 0x18125D2B0
	|-GamePhysics.CheckComponent<object>
	*/

	// RVA: -1 Offset: -1
	public static void OverlapSphere<T>(Vector3 position, float radius, List<T> list, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15732D0 Offset: 0x15718D0 VA: 0x1815732D0
	|-GamePhysics.OverlapSphere<EnvironmentVolume>
	|-GamePhysics.OverlapSphere<object>
	|-GamePhysics.OverlapSphere<TriggerBase>
	*/

	// RVA: -1 Offset: -1
	public static void OverlapCapsule<T>(Vector3 point0, Vector3 point1, float radius, List<T> list, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1573050 Offset: 0x1571650 VA: 0x181573050
	|-GamePhysics.OverlapCapsule<object>
	|-GamePhysics.OverlapCapsule<TriggerBase>
	*/

	// RVA: -1 Offset: -1
	public static void OverlapOBB<T>(OBB obb, List<T> list, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1573180 Offset: 0x1571780 VA: 0x181573180
	|-GamePhysics.OverlapOBB<EnvironmentVolume>
	|-GamePhysics.OverlapOBB<object>
	|-GamePhysics.OverlapOBB<TriggerBase>
	*/

	// RVA: -1 Offset: -1
	public static void OverlapBounds<T>(Bounds bounds, List<T> list, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1572EA0 Offset: 0x15714A0 VA: 0x181572EA0
	|-GamePhysics.OverlapBounds<object>
	*/

	// RVA: -1 Offset: -1
	private static void BufferToList<T>(int count, List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1572C70 Offset: 0x1571270 VA: 0x181572C70
	|-GamePhysics.BufferToList<object>
	*/

	// RVA: 0x75A870 Offset: 0x758E70 VA: 0x18075A870
	private static void HitBufferToList(int count, List<RaycastHit> list) { }

	// RVA: 0x75C0F0 Offset: 0x75A6F0 VA: 0x18075C0F0
	public static bool Trace(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 0, BaseEntity ignoreEntity) { }

	// RVA: 0x75C010 Offset: 0x75A610 VA: 0x18075C010
	public static void TraceAll(Ray ray, float radius, List<RaycastHit> hits, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 0, BaseEntity ignoreEntity) { }

	// RVA: 0x75BD20 Offset: 0x75A320 VA: 0x18075BD20
	public static void TraceAllUnordered(Ray ray, float radius, List<RaycastHit> hits, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 0, BaseEntity ignoreEntity) { }

	// RVA: 0x75B200 Offset: 0x759800 VA: 0x18075B200
	public static bool LineOfSightRadius(Vector3 p0, Vector3 p1, int layerMask, float radius, float padding0, float padding1, BaseEntity ignoreEntity) { }

	// RVA: 0x75B050 Offset: 0x759650 VA: 0x18075B050
	public static bool LineOfSightRadius(Vector3 p0, Vector3 p1, int layerMask, float radius, float padding, BaseEntity ignoreEntity) { }

	// RVA: 0x75B130 Offset: 0x759730 VA: 0x18075B130
	public static bool LineOfSightRadius(Vector3 p0, Vector3 p1, int layerMask, float radius, BaseEntity ignoreEntity) { }

	// RVA: 0x75B3F0 Offset: 0x7599F0 VA: 0x18075B3F0
	public static bool LineOfSight(Vector3 p0, Vector3 p1, int layerMask, float padding0, float padding1, BaseEntity ignoreEntity) { }

	// RVA: 0x75B510 Offset: 0x759B10 VA: 0x18075B510
	public static bool LineOfSight(Vector3 p0, Vector3 p1, int layerMask, float padding, BaseEntity ignoreEntity) { }

	// RVA: 0x75B2E0 Offset: 0x7598E0 VA: 0x18075B2E0
	public static bool LineOfSight(Vector3 p0, Vector3 p1, int layerMask, BaseEntity ignoreEntity) { }

	// RVA: 0x75A9E0 Offset: 0x758FE0 VA: 0x18075A9E0
	private static bool LineOfSightInternal(Vector3 p0, Vector3 p1, int layerMask, float radius, float padding0, float padding1, BaseEntity ignoreEntity) { }

	// RVA: 0x75C300 Offset: 0x75A900 VA: 0x18075C300
	public static bool Verify(RaycastHit hitInfo, BaseEntity ignoreEntity) { }

	// RVA: 0x75C3B0 Offset: 0x75A9B0 VA: 0x18075C3B0
	public static bool Verify(Collider collider, Vector3 point, BaseEntity ignoreEntity) { }

	// RVA: 0x75A6F0 Offset: 0x758CF0 VA: 0x18075A6F0
	private static bool CompareEntity(BaseEntity a, BaseEntity b) { }

	// RVA: 0x75A760 Offset: 0x758D60 VA: 0x18075A760
	public static int HandleTerrainCollision(Vector3 position, int layerMask) { }

	// RVA: 0x75BC20 Offset: 0x75A220 VA: 0x18075BC20
	public static void Sort(List<RaycastHit> hits) { }

	// RVA: 0x75BB30 Offset: 0x75A130 VA: 0x18075BB30
	public static void Sort(RaycastHit[] hits) { }

	// RVA: 0x75C5B0 Offset: 0x75ABB0 VA: 0x18075C5B0
	private static void .cctor() { }

}

private sealed class GamePhysics.<>c // TypeDefIndex: 9260
{	// Fields
	public static readonly GamePhysics.<>c <>9; // 0x0
	public static Comparison<RaycastHit> <>9__42_0; // 0x8
	public static Comparison<RaycastHit> <>9__43_0; // 0x10

	// Methods

	// RVA: 0x763ED0 Offset: 0x7624D0 VA: 0x180763ED0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x763E90 Offset: 0x762490 VA: 0x180763E90
	internal int <Sort>b__42_0(RaycastHit a, RaycastHit b) { }

	// RVA: 0x763E90 Offset: 0x762490 VA: 0x180763E90
	internal int <Sort>b__43_0(RaycastHit a, RaycastHit b) { }

}

