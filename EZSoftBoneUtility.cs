public static class EZSoftBoneUtility // TypeDefIndex: 7137
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x228FA80 Offset: 0x228E080 VA: 0x18228FA80
	internal static Vector3 Abs(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2290680 Offset: 0x228EC80 VA: 0x182290680
	public static float Max(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x228FB30 Offset: 0x228E130 VA: 0x18228FB30
	public static bool Contains(LayerMask mask, int layer) { }

	// RVA: 0x22901A0 Offset: 0x228E7A0 VA: 0x1822901A0
	public static void GetCapsuleParams(CapsuleCollider collider, out Vector3 center0, out Vector3 center1, out float radius) { }

	// RVA: 0x22904F0 Offset: 0x228EAF0 VA: 0x1822904F0
	public static void GetCylinderParams(Transform transform, out Vector3 center, out Vector3 direction, out float radius, out float height) { }

	// RVA: 0x2292A00 Offset: 0x2291000 VA: 0x182292A00
	public static void PointOutsideSphere(ref Vector3 position, SphereCollider collider, float spacing) { }

	// RVA: 0x2292BF0 Offset: 0x22911F0 VA: 0x182292BF0
	private static void PointOutsideSphere(ref Vector3 position, Vector3 spherePosition, float radius) { }

	// RVA: 0x2291700 Offset: 0x228FD00 VA: 0x182291700
	public static void PointInsideSphere(ref Vector3 position, SphereCollider collider, float spacing) { }

	// RVA: 0x2291580 Offset: 0x228FB80 VA: 0x182291580
	private static void PointInsideSphere(ref Vector3 position, Vector3 spherePosition, float radius) { }

	// RVA: 0x2292140 Offset: 0x2290740 VA: 0x182292140
	public static void PointOutsideCapsule(ref Vector3 position, CapsuleCollider collider, float spacing) { }

	// RVA: 0x2291E60 Offset: 0x2290460 VA: 0x182291E60
	public static void PointOutsideCapsule(ref Vector3 position, Vector3 center0, Vector3 center1, float radius) { }

	// RVA: 0x22910A0 Offset: 0x228F6A0 VA: 0x1822910A0
	public static void PointInsideCapsule(ref Vector3 position, CapsuleCollider collider, float spacing) { }

	// RVA: 0x2290DC0 Offset: 0x228F3C0 VA: 0x182290DC0
	private static void PointInsideCapsule(ref Vector3 position, Vector3 center0, Vector3 center1, float radius) { }

	// RVA: 0x2292830 Offset: 0x2290E30 VA: 0x182292830
	public static void PointOutsideCylinder(ref Vector3 position, Transform transform, float spacing) { }

	// RVA: 0x2292570 Offset: 0x2290B70 VA: 0x182292570
	private static void PointOutsideCylinder(ref Vector3 position, Vector3 center, Vector3 direction, float radius, float height) { }

	// RVA: 0x22913B0 Offset: 0x228F9B0 VA: 0x1822913B0
	public static void PointInsideCylinder(ref Vector3 position, Transform transform, float spacing) { }

	// RVA: 0x2291150 Offset: 0x228F750 VA: 0x182291150
	private static void PointInsideCylinder(ref Vector3 position, Vector3 center, Vector3 direction, float radius, float height) { }

	// RVA: 0x2291AA0 Offset: 0x22900A0 VA: 0x182291AA0
	public static void PointOutsideBox(ref Vector3 position, BoxCollider collider, float spacing) { }

	// RVA: 0x22917D0 Offset: 0x228FDD0 VA: 0x1822917D0
	public static void PointOutsideBox(ref Vector3 position, Vector3 boxSize) { }

	// RVA: 0x22908C0 Offset: 0x228EEC0 VA: 0x1822908C0
	public static void PointInsideBox(ref Vector3 position, BoxCollider collider, float spacing) { }

	// RVA: 0x2290700 Offset: 0x228ED00 VA: 0x182290700
	private static void PointInsideBox(ref Vector3 position, Vector3 boxSize) { }

	// RVA: 0x22921F0 Offset: 0x22907F0 VA: 0x1822921F0
	public static void PointOutsideCollider(ref Vector3 position, Collider collider, float spacing) { }

	// RVA: 0x228FB70 Offset: 0x228E170 VA: 0x18228FB70
	public static void DrawGizmosArrow(Vector3 startPoint, Vector3 direction, float halfWidth, Vector3 normal) { }

	// RVA: 0x22900E0 Offset: 0x228E6E0 VA: 0x1822900E0
	public static void DrawGizmosPolyLine(Vector3[] vertices) { }

}

