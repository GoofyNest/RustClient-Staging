public struct PhysicsScene : IEquatable<PhysicsScene> // TypeDefIndex: 3933
{	// Fields
	private int m_Handle; // 0x0

	// Methods

	// RVA: 0x239490 Offset: 0x238890 VA: 0x180239490 Slot: 3
	public override string ToString() { }

	// RVA: 0x13A3C0 Offset: 0x1397C0 VA: 0x18013A3C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x238F50 Offset: 0x238350 VA: 0x180238F50 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x217DE0 Offset: 0x2171E0 VA: 0x180217DE0 Slot: 4
	public bool Equals(PhysicsScene other) { }

	// RVA: 0x239220 Offset: 0x238620 VA: 0x180239220
	public bool Raycast(Vector3 origin, Vector3 direction, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[NativeNameAttribute] // RVA: 0x90310 Offset: 0x8F710 VA: 0x180090310
	[StaticAccessorAttribute] // RVA: 0x90310 Offset: 0x8F710 VA: 0x180090310
	// RVA: 0x2298EE0 Offset: 0x22974E0 VA: 0x182298EE0
	private static bool Internal_RaycastTest(PhysicsScene physicsScene, Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2391A0 Offset: 0x2385A0 VA: 0x1802391A0
	public bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[StaticAccessorAttribute] // RVA: 0x907F0 Offset: 0x8FBF0 VA: 0x1800907F0
	[NativeNameAttribute] // RVA: 0x907F0 Offset: 0x8FBF0 VA: 0x1800907F0
	// RVA: 0x2298FC0 Offset: 0x22975C0 VA: 0x182298FC0
	private static bool Internal_Raycast(PhysicsScene physicsScene, Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x239290 Offset: 0x238690 VA: 0x180239290
	public int Raycast(Vector3 origin, Vector3 direction, RaycastHit[] raycastHits, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[NativeNameAttribute] // RVA: 0x90DE0 Offset: 0x901E0 VA: 0x180090DE0
	[StaticAccessorAttribute] // RVA: 0x90DE0 Offset: 0x901E0 VA: 0x180090DE0
	// RVA: 0x2298E00 Offset: 0x2297400 VA: 0x182298E00
	private static int Internal_RaycastNonAlloc(PhysicsScene physicsScene, Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	[StaticAccessorAttribute] // RVA: 0x90EF0 Offset: 0x902F0 VA: 0x180090EF0
	[NativeNameAttribute] // RVA: 0x90EF0 Offset: 0x902F0 VA: 0x180090EF0
	// RVA: 0x22996F0 Offset: 0x2297CF0 VA: 0x1822996F0
	private static bool Query_CapsuleCast(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2298BE0 Offset: 0x22971E0 VA: 0x182298BE0
	private static bool Internal_CapsuleCast(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x238EA0 Offset: 0x2382A0 VA: 0x180238EA0
	public bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[NativeNameAttribute] // RVA: 0x912A0 Offset: 0x906A0 VA: 0x1800912A0
	[StaticAccessorAttribute] // RVA: 0x912A0 Offset: 0x906A0 VA: 0x1800912A0
	// RVA: 0x2298B40 Offset: 0x2297140 VA: 0x182298B40
	private static int Internal_CapsuleCastNonAlloc(PhysicsScene physicsScene, Vector3 p0, Vector3 p1, float radius, Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x238D70 Offset: 0x238170 VA: 0x180238D70
	public int CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[StaticAccessorAttribute] // RVA: 0x914F0 Offset: 0x908F0 VA: 0x1800914F0
	[NativeNameAttribute] // RVA: 0x914F0 Offset: 0x908F0 VA: 0x1800914F0
	// RVA: 0x2299410 Offset: 0x2297A10 VA: 0x182299410
	private static int OverlapCapsuleNonAlloc_Internal(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x239080 Offset: 0x238480 VA: 0x180239080
	public int OverlapCapsule(Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask = -1, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[NativeNameAttribute] // RVA: 0x918B0 Offset: 0x90CB0 VA: 0x1800918B0
	[StaticAccessorAttribute] // RVA: 0x918B0 Offset: 0x90CB0 VA: 0x1800918B0
	// RVA: 0x2299800 Offset: 0x2297E00 VA: 0x182299800
	private static bool Query_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2299130 Offset: 0x2297730 VA: 0x182299130
	private static bool Internal_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x239310 Offset: 0x238710 VA: 0x180239310
	public bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[NativeNameAttribute] // RVA: 0x92FC0 Offset: 0x923C0 VA: 0x180092FC0
	[StaticAccessorAttribute] // RVA: 0x92FC0 Offset: 0x923C0 VA: 0x180092FC0
	// RVA: 0x22990A0 Offset: 0x22976A0 VA: 0x1822990A0
	private static int Internal_SphereCastNonAlloc(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x239390 Offset: 0x238790 VA: 0x180239390
	public int SphereCast(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[StaticAccessorAttribute] // RVA: 0x93270 Offset: 0x92670 VA: 0x180093270
	[NativeNameAttribute] // RVA: 0x93270 Offset: 0x92670 VA: 0x180093270
	// RVA: 0x2299500 Offset: 0x2297B00 VA: 0x182299500
	private static int OverlapSphereNonAlloc_Internal(PhysicsScene physicsScene, Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x239120 Offset: 0x238520 VA: 0x180239120
	public int OverlapSphere(Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[NativeNameAttribute] // RVA: 0x93520 Offset: 0x92920 VA: 0x180093520
	[StaticAccessorAttribute] // RVA: 0x93520 Offset: 0x92920 VA: 0x180093520
	// RVA: 0x22995E0 Offset: 0x2297BE0 VA: 0x1822995E0
	private static bool Query_BoxCast(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, ref RaycastHit outHit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2298910 Offset: 0x2296F10 VA: 0x182298910
	private static bool Internal_BoxCast(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x238CB0 Offset: 0x2380B0 VA: 0x180238CB0
	public bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[NativeNameAttribute] // RVA: 0x93920 Offset: 0x92D20 VA: 0x180093920
	[StaticAccessorAttribute] // RVA: 0x93920 Offset: 0x92D20 VA: 0x180093920
	// RVA: 0x2299320 Offset: 0x2297920 VA: 0x182299320
	private static int OverlapBoxNonAlloc_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x238FD0 Offset: 0x2383D0 VA: 0x180238FD0
	public int OverlapBox(Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	// RVA: 0x2298E70 Offset: 0x2297470 VA: 0x182298E70
	private static bool Internal_RaycastTest_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2298F50 Offset: 0x2297550 VA: 0x182298F50
	private static bool Internal_Raycast_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2298D90 Offset: 0x2297390 VA: 0x182298D90
	private static int Internal_RaycastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2299680 Offset: 0x2297C80 VA: 0x182299680
	private static bool Query_CapsuleCast_Injected(ref PhysicsScene physicsScene, ref Vector3 point1, ref Vector3 point2, float radius, ref Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2298AD0 Offset: 0x22970D0 VA: 0x182298AD0
	private static int Internal_CapsuleCastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Vector3 p0, ref Vector3 p1, float radius, ref Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x22993A0 Offset: 0x22979A0 VA: 0x1822993A0
	private static int OverlapCapsuleNonAlloc_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 point0, ref Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2299790 Offset: 0x2297D90 VA: 0x182299790
	private static bool Query_SphereCast_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2299030 Offset: 0x2297630 VA: 0x182299030
	private static int Internal_SphereCastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2299490 Offset: 0x2297A90 VA: 0x182299490
	private static int OverlapSphereNonAlloc_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2299570 Offset: 0x2297B70 VA: 0x182299570
	private static bool Query_BoxCast_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Vector3 direction, ref Quaternion orientation, float maxDistance, ref RaycastHit outHit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x22992B0 Offset: 0x22978B0 VA: 0x1822992B0
	private static int OverlapBoxNonAlloc_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, Collider[] results, ref Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

}

