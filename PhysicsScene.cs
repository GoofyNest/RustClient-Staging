public struct PhysicsScene : IEquatable<PhysicsScene> // TypeDefIndex: 3933
{	// Fields
	private int m_Handle; // 0x0

	// Methods

	// RVA: 0x239490 Offset: 0x238890 VA: 0x180239490 Slot: 3
	public override string ToString() { }

	// RVA: 0x13A5A0 Offset: 0x1399A0 VA: 0x18013A5A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x238F50 Offset: 0x238350 VA: 0x180238F50 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x217710 Offset: 0x216B10 VA: 0x180217710 Slot: 4
	public bool Equals(PhysicsScene other) { }

	// RVA: 0x239220 Offset: 0x238620 VA: 0x180239220
	public bool Raycast(Vector3 origin, Vector3 direction, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[NativeNameAttribute] // RVA: 0x90310 Offset: 0x8F710 VA: 0x180090310
	[StaticAccessorAttribute] // RVA: 0x90310 Offset: 0x8F710 VA: 0x180090310
	// RVA: 0x22986C0 Offset: 0x2296CC0 VA: 0x1822986C0
	private static bool Internal_RaycastTest(PhysicsScene physicsScene, Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2391A0 Offset: 0x2385A0 VA: 0x1802391A0
	public bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[StaticAccessorAttribute] // RVA: 0x907F0 Offset: 0x8FBF0 VA: 0x1800907F0
	[NativeNameAttribute] // RVA: 0x907F0 Offset: 0x8FBF0 VA: 0x1800907F0
	// RVA: 0x22987A0 Offset: 0x2296DA0 VA: 0x1822987A0
	private static bool Internal_Raycast(PhysicsScene physicsScene, Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x239290 Offset: 0x238690 VA: 0x180239290
	public int Raycast(Vector3 origin, Vector3 direction, RaycastHit[] raycastHits, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[NativeNameAttribute] // RVA: 0x90DE0 Offset: 0x901E0 VA: 0x180090DE0
	[StaticAccessorAttribute] // RVA: 0x90DE0 Offset: 0x901E0 VA: 0x180090DE0
	// RVA: 0x22985E0 Offset: 0x2296BE0 VA: 0x1822985E0
	private static int Internal_RaycastNonAlloc(PhysicsScene physicsScene, Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	[StaticAccessorAttribute] // RVA: 0x90EF0 Offset: 0x902F0 VA: 0x180090EF0
	[NativeNameAttribute] // RVA: 0x90EF0 Offset: 0x902F0 VA: 0x180090EF0
	// RVA: 0x2298ED0 Offset: 0x22974D0 VA: 0x182298ED0
	private static bool Query_CapsuleCast(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x22983C0 Offset: 0x22969C0 VA: 0x1822983C0
	private static bool Internal_CapsuleCast(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x238EA0 Offset: 0x2382A0 VA: 0x180238EA0
	public bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[NativeNameAttribute] // RVA: 0x912A0 Offset: 0x906A0 VA: 0x1800912A0
	[StaticAccessorAttribute] // RVA: 0x912A0 Offset: 0x906A0 VA: 0x1800912A0
	// RVA: 0x2298320 Offset: 0x2296920 VA: 0x182298320
	private static int Internal_CapsuleCastNonAlloc(PhysicsScene physicsScene, Vector3 p0, Vector3 p1, float radius, Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x238D70 Offset: 0x238170 VA: 0x180238D70
	public int CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[StaticAccessorAttribute] // RVA: 0x914F0 Offset: 0x908F0 VA: 0x1800914F0
	[NativeNameAttribute] // RVA: 0x914F0 Offset: 0x908F0 VA: 0x1800914F0
	// RVA: 0x2298BF0 Offset: 0x22971F0 VA: 0x182298BF0
	private static int OverlapCapsuleNonAlloc_Internal(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x239080 Offset: 0x238480 VA: 0x180239080
	public int OverlapCapsule(Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask = -1, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[NativeNameAttribute] // RVA: 0x918B0 Offset: 0x90CB0 VA: 0x1800918B0
	[StaticAccessorAttribute] // RVA: 0x918B0 Offset: 0x90CB0 VA: 0x1800918B0
	// RVA: 0x2298FE0 Offset: 0x22975E0 VA: 0x182298FE0
	private static bool Query_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2298910 Offset: 0x2296F10 VA: 0x182298910
	private static bool Internal_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x239310 Offset: 0x238710 VA: 0x180239310
	public bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[NativeNameAttribute] // RVA: 0x92FC0 Offset: 0x923C0 VA: 0x180092FC0
	[StaticAccessorAttribute] // RVA: 0x92FC0 Offset: 0x923C0 VA: 0x180092FC0
	// RVA: 0x2298880 Offset: 0x2296E80 VA: 0x182298880
	private static int Internal_SphereCastNonAlloc(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x239390 Offset: 0x238790 VA: 0x180239390
	public int SphereCast(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[StaticAccessorAttribute] // RVA: 0x93270 Offset: 0x92670 VA: 0x180093270
	[NativeNameAttribute] // RVA: 0x93270 Offset: 0x92670 VA: 0x180093270
	// RVA: 0x2298CE0 Offset: 0x22972E0 VA: 0x182298CE0
	private static int OverlapSphereNonAlloc_Internal(PhysicsScene physicsScene, Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x239120 Offset: 0x238520 VA: 0x180239120
	public int OverlapSphere(Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[NativeNameAttribute] // RVA: 0x93520 Offset: 0x92920 VA: 0x180093520
	[StaticAccessorAttribute] // RVA: 0x93520 Offset: 0x92920 VA: 0x180093520
	// RVA: 0x2298DC0 Offset: 0x22973C0 VA: 0x182298DC0
	private static bool Query_BoxCast(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, ref RaycastHit outHit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x22980F0 Offset: 0x22966F0 VA: 0x1822980F0
	private static bool Internal_BoxCast(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x238CB0 Offset: 0x2380B0 VA: 0x180238CB0
	public bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[NativeNameAttribute] // RVA: 0x93920 Offset: 0x92D20 VA: 0x180093920
	[StaticAccessorAttribute] // RVA: 0x93920 Offset: 0x92D20 VA: 0x180093920
	// RVA: 0x2298B00 Offset: 0x2297100 VA: 0x182298B00
	private static int OverlapBoxNonAlloc_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x238FD0 Offset: 0x2383D0 VA: 0x180238FD0
	public int OverlapBox(Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	// RVA: 0x2298650 Offset: 0x2296C50 VA: 0x182298650
	private static bool Internal_RaycastTest_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2298730 Offset: 0x2296D30 VA: 0x182298730
	private static bool Internal_Raycast_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2298570 Offset: 0x2296B70 VA: 0x182298570
	private static int Internal_RaycastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2298E60 Offset: 0x2297460 VA: 0x182298E60
	private static bool Query_CapsuleCast_Injected(ref PhysicsScene physicsScene, ref Vector3 point1, ref Vector3 point2, float radius, ref Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x22982B0 Offset: 0x22968B0 VA: 0x1822982B0
	private static int Internal_CapsuleCastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Vector3 p0, ref Vector3 p1, float radius, ref Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2298B80 Offset: 0x2297180 VA: 0x182298B80
	private static int OverlapCapsuleNonAlloc_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 point0, ref Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2298F70 Offset: 0x2297570 VA: 0x182298F70
	private static bool Query_SphereCast_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2298810 Offset: 0x2296E10 VA: 0x182298810
	private static int Internal_SphereCastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2298C70 Offset: 0x2297270 VA: 0x182298C70
	private static int OverlapSphereNonAlloc_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2298D50 Offset: 0x2297350 VA: 0x182298D50
	private static bool Query_BoxCast_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Vector3 direction, ref Quaternion orientation, float maxDistance, ref RaycastHit outHit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2298A90 Offset: 0x2297090 VA: 0x182298A90
	private static int OverlapBoxNonAlloc_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, Collider[] results, ref Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

}

