public static class GamePhysics // TypeDefIndex: 9259
{	public const int BufferLength = 8192;
	private static RaycastHit[] hitBuffer; // 0x0
	private static RaycastHit[] hitBufferB; // 0x8
	private static Collider[] colBuffer; // 0x10


	public static bool CheckSphere(Vector3 position, float radius, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 0) { }

	public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 0) { }

	public static bool CheckOBB(OBB obb, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 0) { }

	public static bool CheckOBBAndEntity(OBB obb, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 0, BaseEntity ignoreEntity) { }

	public static bool CheckBounds(Bounds bounds, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 0) { }

	public static bool CheckInsideNonConvexMesh(Vector3 point, int layerMask = -5) { }

	public static bool CheckInsideAnyCollider(Vector3 point, int layerMask = -5) { }

	public static void OverlapSphere(Vector3 position, float radius, List<Collider> list, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }

	public static void CapsuleSweep(Vector3 position0, Vector3 position1, float radius, Vector3 direction, float distance, List<RaycastHit> list, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }

	public static void OverlapCapsule(Vector3 point0, Vector3 point1, float radius, List<Collider> list, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }

	public static void OverlapOBB(OBB obb, List<Collider> list, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }

	public static void OverlapBounds(Bounds bounds, List<Collider> list, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }

	private static void BufferToList(int count, List<Collider> list) { }

	public static bool CheckSphere<T>(Vector3 pos, float radius, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125DC20 Offset: 0x125C220 VA: 0x18125DC20
	|-GamePhysics.CheckSphere<object>
	|-GamePhysics.CheckSphere<TerrainCollisionTrigger>
	|-GamePhysics.CheckSphere<WaterVisibilityTrigger>
	*/

	public static bool CheckCapsule<T>(Vector3 start, Vector3 end, float radius, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125D910 Offset: 0x125BF10 VA: 0x18125D910
	|-GamePhysics.CheckCapsule<object>
	|-GamePhysics.CheckCapsule<WaterVisibilityTrigger>
	*/

	public static bool CheckOBB<T>(OBB obb, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125DB00 Offset: 0x125C100 VA: 0x18125DB00
	|-GamePhysics.CheckOBB<object>
	*/

	public static bool CheckBounds<T>(Bounds bounds, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125D810 Offset: 0x125BE10 VA: 0x18125D810
	|-GamePhysics.CheckBounds<object>
	|-GamePhysics.CheckBounds<WaterVisibilityTrigger>
	*/

	private static bool CheckComponent<T>(List<Collider> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125DA50 Offset: 0x125C050 VA: 0x18125DA50
	|-GamePhysics.CheckComponent<object>
	*/

	public static void OverlapSphere<T>(Vector3 position, float radius, List<T> list, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15724A0 Offset: 0x1570AA0 VA: 0x1815724A0
	|-GamePhysics.OverlapSphere<EnvironmentVolume>
	|-GamePhysics.OverlapSphere<object>
	|-GamePhysics.OverlapSphere<TriggerBase>
	*/

	public static void OverlapCapsule<T>(Vector3 point0, Vector3 point1, float radius, List<T> list, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1572220 Offset: 0x1570820 VA: 0x181572220
	|-GamePhysics.OverlapCapsule<object>
	|-GamePhysics.OverlapCapsule<TriggerBase>
	*/

	public static void OverlapOBB<T>(OBB obb, List<T> list, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1572350 Offset: 0x1570950 VA: 0x181572350
	|-GamePhysics.OverlapOBB<EnvironmentVolume>
	|-GamePhysics.OverlapOBB<object>
	|-GamePhysics.OverlapOBB<TriggerBase>
	*/

	public static void OverlapBounds<T>(Bounds bounds, List<T> list, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1572070 Offset: 0x1570670 VA: 0x181572070
	|-GamePhysics.OverlapBounds<object>
	*/

	private static void BufferToList<T>(int count, List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1571E40 Offset: 0x1570440 VA: 0x181571E40
	|-GamePhysics.BufferToList<object>
	*/

	private static void HitBufferToList(int count, List<RaycastHit> list) { }

	public static bool Trace(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 0, BaseEntity ignoreEntity) { }

	public static void TraceAll(Ray ray, float radius, List<RaycastHit> hits, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 0, BaseEntity ignoreEntity) { }

	public static void TraceAllUnordered(Ray ray, float radius, List<RaycastHit> hits, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 0, BaseEntity ignoreEntity) { }

	public static bool LineOfSightRadius(Vector3 p0, Vector3 p1, int layerMask, float radius, float padding0, float padding1, BaseEntity ignoreEntity) { }

	public static bool LineOfSightRadius(Vector3 p0, Vector3 p1, int layerMask, float radius, float padding, BaseEntity ignoreEntity) { }

	public static bool LineOfSightRadius(Vector3 p0, Vector3 p1, int layerMask, float radius, BaseEntity ignoreEntity) { }

	public static bool LineOfSight(Vector3 p0, Vector3 p1, int layerMask, float padding0, float padding1, BaseEntity ignoreEntity) { }

	public static bool LineOfSight(Vector3 p0, Vector3 p1, int layerMask, float padding, BaseEntity ignoreEntity) { }

	public static bool LineOfSight(Vector3 p0, Vector3 p1, int layerMask, BaseEntity ignoreEntity) { }

	private static bool LineOfSightInternal(Vector3 p0, Vector3 p1, int layerMask, float radius, float padding0, float padding1, BaseEntity ignoreEntity) { }

	public static bool Verify(RaycastHit hitInfo, BaseEntity ignoreEntity) { }

	public static bool Verify(Collider collider, Vector3 point, BaseEntity ignoreEntity) { }

	private static bool CompareEntity(BaseEntity a, BaseEntity b) { }

	public static int HandleTerrainCollision(Vector3 position, int layerMask) { }

	public static void Sort(List<RaycastHit> hits) { }

	public static void Sort(RaycastHit[] hits) { }

	private static void .cctor() { }

}

private sealed class GamePhysics.<>c // TypeDefIndex: 9260
{	public static readonly GamePhysics.<>c <>9; // 0x0
	public static Comparison<RaycastHit> <>9__42_0; // 0x8
	public static Comparison<RaycastHit> <>9__43_0; // 0x10


	private static void .cctor() { }

	public void .ctor() { }

	internal int <Sort>b__42_0(RaycastHit a, RaycastHit b) { }

	internal int <Sort>b__43_0(RaycastHit a, RaycastHit b) { }

}

