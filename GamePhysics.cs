public static class GamePhysics // TypeDefIndex: 9259
{	// Fields
	public const int BufferLength = 8192;
	private static RaycastHit[] hitBuffer; // 0x0
	private static RaycastHit[] hitBufferB; // 0x8
	private static Collider[] colBuffer; // 0x10

	// Methods

	// RVA: 0x75A580 Offset: 0x758B80 VA: 0x18075A580
	public static bool CheckSphere(Vector3 position, float radius, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 0) { }

	// RVA: 0x759B10 Offset: 0x758110 VA: 0x180759B10
	public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 0) { }

	// RVA: 0x75A450 Offset: 0x758A50 VA: 0x18075A450
	public static bool CheckOBB(OBB obb, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 0) { }

	// RVA: 0x75A1D0 Offset: 0x7587D0 VA: 0x18075A1D0
	public static bool CheckOBBAndEntity(OBB obb, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 0, BaseEntity ignoreEntity) { }

	// RVA: 0x7599B0 Offset: 0x757FB0 VA: 0x1807599B0
	public static bool CheckBounds(Bounds bounds, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 0) { }

	// RVA: 0x759E20 Offset: 0x758420 VA: 0x180759E20
	public static bool CheckInsideNonConvexMesh(Vector3 point, int layerMask = -5) { }

	// RVA: 0x759C90 Offset: 0x758290 VA: 0x180759C90
	public static bool CheckInsideAnyCollider(Vector3 point, int layerMask = -5) { }

	// RVA: 0x75B990 Offset: 0x759F90 VA: 0x18075B990
	public static void OverlapSphere(Vector3 position, float radius, List<Collider> list, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }

	// RVA: 0x759710 Offset: 0x757D10 VA: 0x180759710
	public static void CapsuleSweep(Vector3 position0, Vector3 position1, float radius, Vector3 direction, float distance, List<RaycastHit> list, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }

	// RVA: 0x75B710 Offset: 0x759D10 VA: 0x18075B710
	public static void OverlapCapsule(Vector3 point0, Vector3 point1, float radius, List<Collider> list, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }

	// RVA: 0x75B840 Offset: 0x759E40 VA: 0x18075B840
	public static void OverlapOBB(OBB obb, List<Collider> list, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }

	// RVA: 0x75B570 Offset: 0x759B70 VA: 0x18075B570
	public static void OverlapBounds(Bounds bounds, List<Collider> list, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }

	// RVA: 0x759570 Offset: 0x757B70 VA: 0x180759570
	private static void BufferToList(int count, List<Collider> list) { }

	// RVA: -1 Offset: -1
	public static bool CheckSphere<T>(Vector3 pos, float radius, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125DB20 Offset: 0x125C120 VA: 0x18125DB20
	|-GamePhysics.CheckSphere<object>
	|-GamePhysics.CheckSphere<TerrainCollisionTrigger>
	|-GamePhysics.CheckSphere<WaterVisibilityTrigger>
	*/

	// RVA: -1 Offset: -1
	public static bool CheckCapsule<T>(Vector3 start, Vector3 end, float radius, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125D810 Offset: 0x125BE10 VA: 0x18125D810
	|-GamePhysics.CheckCapsule<object>
	|-GamePhysics.CheckCapsule<WaterVisibilityTrigger>
	*/

	// RVA: -1 Offset: -1
	public static bool CheckOBB<T>(OBB obb, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125DA00 Offset: 0x125C000 VA: 0x18125DA00
	|-GamePhysics.CheckOBB<object>
	*/

	// RVA: -1 Offset: -1
	public static bool CheckBounds<T>(Bounds bounds, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125D710 Offset: 0x125BD10 VA: 0x18125D710
	|-GamePhysics.CheckBounds<object>
	|-GamePhysics.CheckBounds<WaterVisibilityTrigger>
	*/

	// RVA: -1 Offset: -1
	private static bool CheckComponent<T>(List<Collider> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125D950 Offset: 0x125BF50 VA: 0x18125D950
	|-GamePhysics.CheckComponent<object>
	*/

	// RVA: -1 Offset: -1
	public static void OverlapSphere<T>(Vector3 position, float radius, List<T> list, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15723A0 Offset: 0x15709A0 VA: 0x1815723A0
	|-GamePhysics.OverlapSphere<EnvironmentVolume>
	|-GamePhysics.OverlapSphere<object>
	|-GamePhysics.OverlapSphere<TriggerBase>
	*/

	// RVA: -1 Offset: -1
	public static void OverlapCapsule<T>(Vector3 point0, Vector3 point1, float radius, List<T> list, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1572120 Offset: 0x1570720 VA: 0x181572120
	|-GamePhysics.OverlapCapsule<object>
	|-GamePhysics.OverlapCapsule<TriggerBase>
	*/

	// RVA: -1 Offset: -1
	public static void OverlapOBB<T>(OBB obb, List<T> list, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1572250 Offset: 0x1570850 VA: 0x181572250
	|-GamePhysics.OverlapOBB<EnvironmentVolume>
	|-GamePhysics.OverlapOBB<object>
	|-GamePhysics.OverlapOBB<TriggerBase>
	*/

	// RVA: -1 Offset: -1
	public static void OverlapBounds<T>(Bounds bounds, List<T> list, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1571F70 Offset: 0x1570570 VA: 0x181571F70
	|-GamePhysics.OverlapBounds<object>
	*/

	// RVA: -1 Offset: -1
	private static void BufferToList<T>(int count, List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1571D40 Offset: 0x1570340 VA: 0x181571D40
	|-GamePhysics.BufferToList<object>
	*/

	// RVA: 0x75A7C0 Offset: 0x758DC0 VA: 0x18075A7C0
	private static void HitBufferToList(int count, List<RaycastHit> list) { }

	// RVA: 0x75C040 Offset: 0x75A640 VA: 0x18075C040
	public static bool Trace(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 0, BaseEntity ignoreEntity) { }

	// RVA: 0x75BF60 Offset: 0x75A560 VA: 0x18075BF60
	public static void TraceAll(Ray ray, float radius, List<RaycastHit> hits, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 0, BaseEntity ignoreEntity) { }

	// RVA: 0x75BC70 Offset: 0x75A270 VA: 0x18075BC70
	public static void TraceAllUnordered(Ray ray, float radius, List<RaycastHit> hits, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 0, BaseEntity ignoreEntity) { }

	// RVA: 0x75B150 Offset: 0x759750 VA: 0x18075B150
	public static bool LineOfSightRadius(Vector3 p0, Vector3 p1, int layerMask, float radius, float padding0, float padding1, BaseEntity ignoreEntity) { }

	// RVA: 0x75AFA0 Offset: 0x7595A0 VA: 0x18075AFA0
	public static bool LineOfSightRadius(Vector3 p0, Vector3 p1, int layerMask, float radius, float padding, BaseEntity ignoreEntity) { }

	// RVA: 0x75B080 Offset: 0x759680 VA: 0x18075B080
	public static bool LineOfSightRadius(Vector3 p0, Vector3 p1, int layerMask, float radius, BaseEntity ignoreEntity) { }

	// RVA: 0x75B340 Offset: 0x759940 VA: 0x18075B340
	public static bool LineOfSight(Vector3 p0, Vector3 p1, int layerMask, float padding0, float padding1, BaseEntity ignoreEntity) { }

	// RVA: 0x75B460 Offset: 0x759A60 VA: 0x18075B460
	public static bool LineOfSight(Vector3 p0, Vector3 p1, int layerMask, float padding, BaseEntity ignoreEntity) { }

	// RVA: 0x75B230 Offset: 0x759830 VA: 0x18075B230
	public static bool LineOfSight(Vector3 p0, Vector3 p1, int layerMask, BaseEntity ignoreEntity) { }

	// RVA: 0x75A930 Offset: 0x758F30 VA: 0x18075A930
	private static bool LineOfSightInternal(Vector3 p0, Vector3 p1, int layerMask, float radius, float padding0, float padding1, BaseEntity ignoreEntity) { }

	// RVA: 0x75C250 Offset: 0x75A850 VA: 0x18075C250
	public static bool Verify(RaycastHit hitInfo, BaseEntity ignoreEntity) { }

	// RVA: 0x75C300 Offset: 0x75A900 VA: 0x18075C300
	public static bool Verify(Collider collider, Vector3 point, BaseEntity ignoreEntity) { }

	// RVA: 0x75A640 Offset: 0x758C40 VA: 0x18075A640
	private static bool CompareEntity(BaseEntity a, BaseEntity b) { }

	// RVA: 0x75A6B0 Offset: 0x758CB0 VA: 0x18075A6B0
	public static int HandleTerrainCollision(Vector3 position, int layerMask) { }

	// RVA: 0x75BB70 Offset: 0x75A170 VA: 0x18075BB70
	public static void Sort(List<RaycastHit> hits) { }

	// RVA: 0x75BA80 Offset: 0x75A080 VA: 0x18075BA80
	public static void Sort(RaycastHit[] hits) { }

	// RVA: 0x75C500 Offset: 0x75AB00 VA: 0x18075C500
	private static void .cctor() { }

}

private sealed class GamePhysics.<>c // TypeDefIndex: 9260
{	// Fields
	public static readonly GamePhysics.<>c <>9; // 0x0
	public static Comparison<RaycastHit> <>9__42_0; // 0x8
	public static Comparison<RaycastHit> <>9__43_0; // 0x10

	// Methods

	// RVA: 0x763E20 Offset: 0x762420 VA: 0x180763E20
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x763DE0 Offset: 0x7623E0 VA: 0x180763DE0
	internal int <Sort>b__42_0(RaycastHit a, RaycastHit b) { }

	// RVA: 0x763DE0 Offset: 0x7623E0 VA: 0x180763DE0
	internal int <Sort>b__43_0(RaycastHit a, RaycastHit b) { }

}

