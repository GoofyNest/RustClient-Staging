public static class EZSoftBoneUtility // TypeDefIndex: 7137
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x228FB80 Offset: 0x228E180 VA: 0x18228FB80
	internal static Vector3 Abs(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2290780 Offset: 0x228ED80 VA: 0x182290780
	public static float Max(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x228FC30 Offset: 0x228E230 VA: 0x18228FC30
	public static bool Contains(LayerMask mask, int layer) { }

	// RVA: 0x22902A0 Offset: 0x228E8A0 VA: 0x1822902A0
	public static void GetCapsuleParams(CapsuleCollider collider, out Vector3 center0, out Vector3 center1, out float radius) { }

	// RVA: 0x22905F0 Offset: 0x228EBF0 VA: 0x1822905F0
	public static void GetCylinderParams(Transform transform, out Vector3 center, out Vector3 direction, out float radius, out float height) { }

	// RVA: 0x2292B00 Offset: 0x2291100 VA: 0x182292B00
	public static void PointOutsideSphere(ref Vector3 position, SphereCollider collider, float spacing) { }

	// RVA: 0x2292CF0 Offset: 0x22912F0 VA: 0x182292CF0
	private static void PointOutsideSphere(ref Vector3 position, Vector3 spherePosition, float radius) { }

	// RVA: 0x2291800 Offset: 0x228FE00 VA: 0x182291800
	public static void PointInsideSphere(ref Vector3 position, SphereCollider collider, float spacing) { }

	// RVA: 0x2291680 Offset: 0x228FC80 VA: 0x182291680
	private static void PointInsideSphere(ref Vector3 position, Vector3 spherePosition, float radius) { }

	// RVA: 0x2292240 Offset: 0x2290840 VA: 0x182292240
	public static void PointOutsideCapsule(ref Vector3 position, CapsuleCollider collider, float spacing) { }

	// RVA: 0x2291F60 Offset: 0x2290560 VA: 0x182291F60
	public static void PointOutsideCapsule(ref Vector3 position, Vector3 center0, Vector3 center1, float radius) { }

	// RVA: 0x22911A0 Offset: 0x228F7A0 VA: 0x1822911A0
	public static void PointInsideCapsule(ref Vector3 position, CapsuleCollider collider, float spacing) { }

	// RVA: 0x2290EC0 Offset: 0x228F4C0 VA: 0x182290EC0
	private static void PointInsideCapsule(ref Vector3 position, Vector3 center0, Vector3 center1, float radius) { }

	// RVA: 0x2292930 Offset: 0x2290F30 VA: 0x182292930
	public static void PointOutsideCylinder(ref Vector3 position, Transform transform, float spacing) { }

	// RVA: 0x2292670 Offset: 0x2290C70 VA: 0x182292670
	private static void PointOutsideCylinder(ref Vector3 position, Vector3 center, Vector3 direction, float radius, float height) { }

	// RVA: 0x22914B0 Offset: 0x228FAB0 VA: 0x1822914B0
	public static void PointInsideCylinder(ref Vector3 position, Transform transform, float spacing) { }

	// RVA: 0x2291250 Offset: 0x228F850 VA: 0x182291250
	private static void PointInsideCylinder(ref Vector3 position, Vector3 center, Vector3 direction, float radius, float height) { }

	// RVA: 0x2291BA0 Offset: 0x22901A0 VA: 0x182291BA0
	public static void PointOutsideBox(ref Vector3 position, BoxCollider collider, float spacing) { }

	// RVA: 0x22918D0 Offset: 0x228FED0 VA: 0x1822918D0
	public static void PointOutsideBox(ref Vector3 position, Vector3 boxSize) { }

	// RVA: 0x22909C0 Offset: 0x228EFC0 VA: 0x1822909C0
	public static void PointInsideBox(ref Vector3 position, BoxCollider collider, float spacing) { }

	// RVA: 0x2290800 Offset: 0x228EE00 VA: 0x182290800
	private static void PointInsideBox(ref Vector3 position, Vector3 boxSize) { }

	// RVA: 0x22922F0 Offset: 0x22908F0 VA: 0x1822922F0
	public static void PointOutsideCollider(ref Vector3 position, Collider collider, float spacing) { }

	// RVA: 0x228FC70 Offset: 0x228E270 VA: 0x18228FC70
	public static void DrawGizmosArrow(Vector3 startPoint, Vector3 direction, float halfWidth, Vector3 normal) { }

	// RVA: 0x22901E0 Offset: 0x228E7E0 VA: 0x1822901E0
	public static void DrawGizmosPolyLine(Vector3[] vertices) { }

}

