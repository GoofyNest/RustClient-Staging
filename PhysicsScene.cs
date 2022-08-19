public struct PhysicsScene : IEquatable<PhysicsScene> // TypeDefIndex: 3933
{	// Fields
	private int m_Handle; // 0x0

	// Methods

	// RVA: 0x239510 Offset: 0x238910 VA: 0x180239510 Slot: 3
	public override string ToString() { }

	// RVA: 0x13A620 Offset: 0x139A20 VA: 0x18013A620 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x238FD0 Offset: 0x2383D0 VA: 0x180238FD0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x217790 Offset: 0x216B90 VA: 0x180217790 Slot: 4
	public bool Equals(PhysicsScene other) { }

	// RVA: 0x2392A0 Offset: 0x2386A0 VA: 0x1802392A0
	public bool Raycast(Vector3 origin, Vector3 direction, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[NativeNameAttribute] // RVA: 0x90250 Offset: 0x8F650 VA: 0x180090250
	[StaticAccessorAttribute] // RVA: 0x90250 Offset: 0x8F650 VA: 0x180090250
	// RVA: 0x22985C0 Offset: 0x2296BC0 VA: 0x1822985C0
	private static bool Internal_RaycastTest(PhysicsScene physicsScene, Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x239220 Offset: 0x238620 VA: 0x180239220
	public bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[StaticAccessorAttribute] // RVA: 0x90770 Offset: 0x8FB70 VA: 0x180090770
	[NativeNameAttribute] // RVA: 0x90770 Offset: 0x8FB70 VA: 0x180090770
	// RVA: 0x22986A0 Offset: 0x2296CA0 VA: 0x1822986A0
	private static bool Internal_Raycast(PhysicsScene physicsScene, Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x239310 Offset: 0x238710 VA: 0x180239310
	public int Raycast(Vector3 origin, Vector3 direction, RaycastHit[] raycastHits, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[NativeNameAttribute] // RVA: 0x90C50 Offset: 0x90050 VA: 0x180090C50
	[StaticAccessorAttribute] // RVA: 0x90C50 Offset: 0x90050 VA: 0x180090C50
	// RVA: 0x22984E0 Offset: 0x2296AE0 VA: 0x1822984E0
	private static int Internal_RaycastNonAlloc(PhysicsScene physicsScene, Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	[StaticAccessorAttribute] // RVA: 0x90EA0 Offset: 0x902A0 VA: 0x180090EA0
	[NativeNameAttribute] // RVA: 0x90EA0 Offset: 0x902A0 VA: 0x180090EA0
	// RVA: 0x2298DD0 Offset: 0x22973D0 VA: 0x182298DD0
	private static bool Query_CapsuleCast(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x22982C0 Offset: 0x22968C0 VA: 0x1822982C0
	private static bool Internal_CapsuleCast(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x238F20 Offset: 0x238320 VA: 0x180238F20
	public bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[NativeNameAttribute] // RVA: 0x91220 Offset: 0x90620 VA: 0x180091220
	[StaticAccessorAttribute] // RVA: 0x91220 Offset: 0x90620 VA: 0x180091220
	// RVA: 0x2298220 Offset: 0x2296820 VA: 0x182298220
	private static int Internal_CapsuleCastNonAlloc(PhysicsScene physicsScene, Vector3 p0, Vector3 p1, float radius, Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x238DF0 Offset: 0x2381F0 VA: 0x180238DF0
	public int CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[StaticAccessorAttribute] // RVA: 0x91470 Offset: 0x90870 VA: 0x180091470
	[NativeNameAttribute] // RVA: 0x91470 Offset: 0x90870 VA: 0x180091470
	// RVA: 0x2298AF0 Offset: 0x22970F0 VA: 0x182298AF0
	private static int OverlapCapsuleNonAlloc_Internal(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x239100 Offset: 0x238500 VA: 0x180239100
	public int OverlapCapsule(Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask = -1, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[NativeNameAttribute] // RVA: 0x91800 Offset: 0x90C00 VA: 0x180091800
	[StaticAccessorAttribute] // RVA: 0x91800 Offset: 0x90C00 VA: 0x180091800
	// RVA: 0x2298EE0 Offset: 0x22974E0 VA: 0x182298EE0
	private static bool Query_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2298810 Offset: 0x2296E10 VA: 0x182298810
	private static bool Internal_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x239390 Offset: 0x238790 VA: 0x180239390
	public bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[NativeNameAttribute] // RVA: 0x92EE0 Offset: 0x922E0 VA: 0x180092EE0
	[StaticAccessorAttribute] // RVA: 0x92EE0 Offset: 0x922E0 VA: 0x180092EE0
	// RVA: 0x2298780 Offset: 0x2296D80 VA: 0x182298780
	private static int Internal_SphereCastNonAlloc(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x239410 Offset: 0x238810 VA: 0x180239410
	public int SphereCast(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[StaticAccessorAttribute] // RVA: 0x931C0 Offset: 0x925C0 VA: 0x1800931C0
	[NativeNameAttribute] // RVA: 0x931C0 Offset: 0x925C0 VA: 0x1800931C0
	// RVA: 0x2298BE0 Offset: 0x22971E0 VA: 0x182298BE0
	private static int OverlapSphereNonAlloc_Internal(PhysicsScene physicsScene, Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2391A0 Offset: 0x2385A0 VA: 0x1802391A0
	public int OverlapSphere(Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[NativeNameAttribute] // RVA: 0x934A0 Offset: 0x928A0 VA: 0x1800934A0
	[StaticAccessorAttribute] // RVA: 0x934A0 Offset: 0x928A0 VA: 0x1800934A0
	// RVA: 0x2298CC0 Offset: 0x22972C0 VA: 0x182298CC0
	private static bool Query_BoxCast(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, ref RaycastHit outHit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2297FF0 Offset: 0x22965F0 VA: 0x182297FF0
	private static bool Internal_BoxCast(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x238D30 Offset: 0x238130 VA: 0x180238D30
	public bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[NativeNameAttribute] // RVA: 0x938A0 Offset: 0x92CA0 VA: 0x1800938A0
	[StaticAccessorAttribute] // RVA: 0x938A0 Offset: 0x92CA0 VA: 0x1800938A0
	// RVA: 0x2298A00 Offset: 0x2297000 VA: 0x182298A00
	private static int OverlapBoxNonAlloc_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x239050 Offset: 0x238450 VA: 0x180239050
	public int OverlapBox(Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	// RVA: 0x2298550 Offset: 0x2296B50 VA: 0x182298550
	private static bool Internal_RaycastTest_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2298630 Offset: 0x2296C30 VA: 0x182298630
	private static bool Internal_Raycast_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2298470 Offset: 0x2296A70 VA: 0x182298470
	private static int Internal_RaycastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2298D60 Offset: 0x2297360 VA: 0x182298D60
	private static bool Query_CapsuleCast_Injected(ref PhysicsScene physicsScene, ref Vector3 point1, ref Vector3 point2, float radius, ref Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x22981B0 Offset: 0x22967B0 VA: 0x1822981B0
	private static int Internal_CapsuleCastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Vector3 p0, ref Vector3 p1, float radius, ref Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2298A80 Offset: 0x2297080 VA: 0x182298A80
	private static int OverlapCapsuleNonAlloc_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 point0, ref Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2298E70 Offset: 0x2297470 VA: 0x182298E70
	private static bool Query_SphereCast_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2298710 Offset: 0x2296D10 VA: 0x182298710
	private static int Internal_SphereCastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2298B70 Offset: 0x2297170 VA: 0x182298B70
	private static int OverlapSphereNonAlloc_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2298C50 Offset: 0x2297250 VA: 0x182298C50
	private static bool Query_BoxCast_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Vector3 direction, ref Quaternion orientation, float maxDistance, ref RaycastHit outHit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2298990 Offset: 0x2296F90 VA: 0x182298990
	private static int OverlapBoxNonAlloc_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, Collider[] results, ref Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

}

