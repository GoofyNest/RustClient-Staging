public static class GamePhysics // TypeDefIndex: 9259
{	// Fields
	public const int BufferLength = 8192;
	private static RaycastHit[] hitBuffer; // 0x0
	private static RaycastHit[] hitBufferB; // 0x8
	private static Collider[] colBuffer; // 0x10

	// Methods

	// RVA: 0x75A520 Offset: 0x758B20 VA: 0x18075A520
	public static bool CheckSphere(Vector3 position, float radius, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 0) { }

	// RVA: 0x759AB0 Offset: 0x7580B0 VA: 0x180759AB0
	public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 0) { }

	// RVA: 0x75A3F0 Offset: 0x7589F0 VA: 0x18075A3F0
	public static bool CheckOBB(OBB obb, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 0) { }

	// RVA: 0x75A170 Offset: 0x758770 VA: 0x18075A170
	public static bool CheckOBBAndEntity(OBB obb, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 0, BaseEntity ignoreEntity) { }

	// RVA: 0x759950 Offset: 0x757F50 VA: 0x180759950
	public static bool CheckBounds(Bounds bounds, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 0) { }

	// RVA: 0x759DC0 Offset: 0x7583C0 VA: 0x180759DC0
	public static bool CheckInsideNonConvexMesh(Vector3 point, int layerMask = -5) { }

	// RVA: 0x759C30 Offset: 0x758230 VA: 0x180759C30
	public static bool CheckInsideAnyCollider(Vector3 point, int layerMask = -5) { }

	// RVA: 0x75B930 Offset: 0x759F30 VA: 0x18075B930
	public static void OverlapSphere(Vector3 position, float radius, List<Collider> list, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }

	// RVA: 0x7596B0 Offset: 0x757CB0 VA: 0x1807596B0
	public static void CapsuleSweep(Vector3 position0, Vector3 position1, float radius, Vector3 direction, float distance, List<RaycastHit> list, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }

	// RVA: 0x75B6B0 Offset: 0x759CB0 VA: 0x18075B6B0
	public static void OverlapCapsule(Vector3 point0, Vector3 point1, float radius, List<Collider> list, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }

	// RVA: 0x75B7E0 Offset: 0x759DE0 VA: 0x18075B7E0
	public static void OverlapOBB(OBB obb, List<Collider> list, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }

	// RVA: 0x75B510 Offset: 0x759B10 VA: 0x18075B510
	public static void OverlapBounds(Bounds bounds, List<Collider> list, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }

	// RVA: 0x759510 Offset: 0x757B10 VA: 0x180759510
	private static void BufferToList(int count, List<Collider> list) { }

	// RVA: -1 Offset: -1
	public static bool CheckSphere<T>(Vector3 pos, float radius, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125D1C0 Offset: 0x125B7C0 VA: 0x18125D1C0
	|-GamePhysics.CheckSphere<object>
	|-GamePhysics.CheckSphere<TerrainCollisionTrigger>
	|-GamePhysics.CheckSphere<WaterVisibilityTrigger>
	*/

	// RVA: -1 Offset: -1
	public static bool CheckCapsule<T>(Vector3 start, Vector3 end, float radius, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125CEB0 Offset: 0x125B4B0 VA: 0x18125CEB0
	|-GamePhysics.CheckCapsule<object>
	|-GamePhysics.CheckCapsule<WaterVisibilityTrigger>
	*/

	// RVA: -1 Offset: -1
	public static bool CheckOBB<T>(OBB obb, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125D0A0 Offset: 0x125B6A0 VA: 0x18125D0A0
	|-GamePhysics.CheckOBB<object>
	*/

	// RVA: -1 Offset: -1
	public static bool CheckBounds<T>(Bounds bounds, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125CDB0 Offset: 0x125B3B0 VA: 0x18125CDB0
	|-GamePhysics.CheckBounds<object>
	|-GamePhysics.CheckBounds<WaterVisibilityTrigger>
	*/

	// RVA: -1 Offset: -1
	private static bool CheckComponent<T>(List<Collider> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125CFF0 Offset: 0x125B5F0 VA: 0x18125CFF0
	|-GamePhysics.CheckComponent<object>
	*/

	// RVA: -1 Offset: -1
	public static void OverlapSphere<T>(Vector3 position, float radius, List<T> list, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1573010 Offset: 0x1571610 VA: 0x181573010
	|-GamePhysics.OverlapSphere<EnvironmentVolume>
	|-GamePhysics.OverlapSphere<object>
	|-GamePhysics.OverlapSphere<TriggerBase>
	*/

	// RVA: -1 Offset: -1
	public static void OverlapCapsule<T>(Vector3 point0, Vector3 point1, float radius, List<T> list, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1572D90 Offset: 0x1571390 VA: 0x181572D90
	|-GamePhysics.OverlapCapsule<object>
	|-GamePhysics.OverlapCapsule<TriggerBase>
	*/

	// RVA: -1 Offset: -1
	public static void OverlapOBB<T>(OBB obb, List<T> list, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1572EC0 Offset: 0x15714C0 VA: 0x181572EC0
	|-GamePhysics.OverlapOBB<EnvironmentVolume>
	|-GamePhysics.OverlapOBB<object>
	|-GamePhysics.OverlapOBB<TriggerBase>
	*/

	// RVA: -1 Offset: -1
	public static void OverlapBounds<T>(Bounds bounds, List<T> list, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1572BE0 Offset: 0x15711E0 VA: 0x181572BE0
	|-GamePhysics.OverlapBounds<object>
	*/

	// RVA: -1 Offset: -1
	private static void BufferToList<T>(int count, List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15729B0 Offset: 0x1570FB0 VA: 0x1815729B0
	|-GamePhysics.BufferToList<object>
	*/

	// RVA: 0x75A760 Offset: 0x758D60 VA: 0x18075A760
	private static void HitBufferToList(int count, List<RaycastHit> list) { }

	// RVA: 0x75BFE0 Offset: 0x75A5E0 VA: 0x18075BFE0
	public static bool Trace(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 0, BaseEntity ignoreEntity) { }

	// RVA: 0x75BF00 Offset: 0x75A500 VA: 0x18075BF00
	public static void TraceAll(Ray ray, float radius, List<RaycastHit> hits, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 0, BaseEntity ignoreEntity) { }

	// RVA: 0x75BC10 Offset: 0x75A210 VA: 0x18075BC10
	public static void TraceAllUnordered(Ray ray, float radius, List<RaycastHit> hits, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 0, BaseEntity ignoreEntity) { }

	// RVA: 0x75B0F0 Offset: 0x7596F0 VA: 0x18075B0F0
	public static bool LineOfSightRadius(Vector3 p0, Vector3 p1, int layerMask, float radius, float padding0, float padding1, BaseEntity ignoreEntity) { }

	// RVA: 0x75AF40 Offset: 0x759540 VA: 0x18075AF40
	public static bool LineOfSightRadius(Vector3 p0, Vector3 p1, int layerMask, float radius, float padding, BaseEntity ignoreEntity) { }

	// RVA: 0x75B020 Offset: 0x759620 VA: 0x18075B020
	public static bool LineOfSightRadius(Vector3 p0, Vector3 p1, int layerMask, float radius, BaseEntity ignoreEntity) { }

	// RVA: 0x75B2E0 Offset: 0x7598E0 VA: 0x18075B2E0
	public static bool LineOfSight(Vector3 p0, Vector3 p1, int layerMask, float padding0, float padding1, BaseEntity ignoreEntity) { }

	// RVA: 0x75B400 Offset: 0x759A00 VA: 0x18075B400
	public static bool LineOfSight(Vector3 p0, Vector3 p1, int layerMask, float padding, BaseEntity ignoreEntity) { }

	// RVA: 0x75B1D0 Offset: 0x7597D0 VA: 0x18075B1D0
	public static bool LineOfSight(Vector3 p0, Vector3 p1, int layerMask, BaseEntity ignoreEntity) { }

	// RVA: 0x75A8D0 Offset: 0x758ED0 VA: 0x18075A8D0
	private static bool LineOfSightInternal(Vector3 p0, Vector3 p1, int layerMask, float radius, float padding0, float padding1, BaseEntity ignoreEntity) { }

	// RVA: 0x75C1F0 Offset: 0x75A7F0 VA: 0x18075C1F0
	public static bool Verify(RaycastHit hitInfo, BaseEntity ignoreEntity) { }

	// RVA: 0x75C2A0 Offset: 0x75A8A0 VA: 0x18075C2A0
	public static bool Verify(Collider collider, Vector3 point, BaseEntity ignoreEntity) { }

	// RVA: 0x75A5E0 Offset: 0x758BE0 VA: 0x18075A5E0
	private static bool CompareEntity(BaseEntity a, BaseEntity b) { }

	// RVA: 0x75A650 Offset: 0x758C50 VA: 0x18075A650
	public static int HandleTerrainCollision(Vector3 position, int layerMask) { }

	// RVA: 0x75BB10 Offset: 0x75A110 VA: 0x18075BB10
	public static void Sort(List<RaycastHit> hits) { }

	// RVA: 0x75BA20 Offset: 0x75A020 VA: 0x18075BA20
	public static void Sort(RaycastHit[] hits) { }

	// RVA: 0x75C4A0 Offset: 0x75AAA0 VA: 0x18075C4A0
	private static void .cctor() { }

}

private sealed class GamePhysics.<>c // TypeDefIndex: 9260
{	// Fields
	public static readonly GamePhysics.<>c <>9; // 0x0
	public static Comparison<RaycastHit> <>9__42_0; // 0x8
	public static Comparison<RaycastHit> <>9__43_0; // 0x10

	// Methods

	// RVA: 0x763DC0 Offset: 0x7623C0 VA: 0x180763DC0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x763D80 Offset: 0x762380 VA: 0x180763D80
	internal int <Sort>b__42_0(RaycastHit a, RaycastHit b) { }

	// RVA: 0x763D80 Offset: 0x762380 VA: 0x180763D80
	internal int <Sort>b__43_0(RaycastHit a, RaycastHit b) { }

}

