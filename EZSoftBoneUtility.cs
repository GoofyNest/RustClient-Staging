public static class EZSoftBoneUtility // TypeDefIndex: 7137
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x228F8C0 Offset: 0x228DEC0 VA: 0x18228F8C0
	internal static Vector3 Abs(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22904C0 Offset: 0x228EAC0 VA: 0x1822904C0
	public static float Max(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x228F970 Offset: 0x228DF70 VA: 0x18228F970
	public static bool Contains(LayerMask mask, int layer) { }

	// RVA: 0x228FFE0 Offset: 0x228E5E0 VA: 0x18228FFE0
	public static void GetCapsuleParams(CapsuleCollider collider, out Vector3 center0, out Vector3 center1, out float radius) { }

	// RVA: 0x2290330 Offset: 0x228E930 VA: 0x182290330
	public static void GetCylinderParams(Transform transform, out Vector3 center, out Vector3 direction, out float radius, out float height) { }

	// RVA: 0x2292840 Offset: 0x2290E40 VA: 0x182292840
	public static void PointOutsideSphere(ref Vector3 position, SphereCollider collider, float spacing) { }

	// RVA: 0x2292A30 Offset: 0x2291030 VA: 0x182292A30
	private static void PointOutsideSphere(ref Vector3 position, Vector3 spherePosition, float radius) { }

	// RVA: 0x2291540 Offset: 0x228FB40 VA: 0x182291540
	public static void PointInsideSphere(ref Vector3 position, SphereCollider collider, float spacing) { }

	// RVA: 0x22913C0 Offset: 0x228F9C0 VA: 0x1822913C0
	private static void PointInsideSphere(ref Vector3 position, Vector3 spherePosition, float radius) { }

	// RVA: 0x2291F80 Offset: 0x2290580 VA: 0x182291F80
	public static void PointOutsideCapsule(ref Vector3 position, CapsuleCollider collider, float spacing) { }

	// RVA: 0x2291CA0 Offset: 0x22902A0 VA: 0x182291CA0
	public static void PointOutsideCapsule(ref Vector3 position, Vector3 center0, Vector3 center1, float radius) { }

	// RVA: 0x2290EE0 Offset: 0x228F4E0 VA: 0x182290EE0
	public static void PointInsideCapsule(ref Vector3 position, CapsuleCollider collider, float spacing) { }

	// RVA: 0x2290C00 Offset: 0x228F200 VA: 0x182290C00
	private static void PointInsideCapsule(ref Vector3 position, Vector3 center0, Vector3 center1, float radius) { }

	// RVA: 0x2292670 Offset: 0x2290C70 VA: 0x182292670
	public static void PointOutsideCylinder(ref Vector3 position, Transform transform, float spacing) { }

	// RVA: 0x22923B0 Offset: 0x22909B0 VA: 0x1822923B0
	private static void PointOutsideCylinder(ref Vector3 position, Vector3 center, Vector3 direction, float radius, float height) { }

	// RVA: 0x22911F0 Offset: 0x228F7F0 VA: 0x1822911F0
	public static void PointInsideCylinder(ref Vector3 position, Transform transform, float spacing) { }

	// RVA: 0x2290F90 Offset: 0x228F590 VA: 0x182290F90
	private static void PointInsideCylinder(ref Vector3 position, Vector3 center, Vector3 direction, float radius, float height) { }

	// RVA: 0x22918E0 Offset: 0x228FEE0 VA: 0x1822918E0
	public static void PointOutsideBox(ref Vector3 position, BoxCollider collider, float spacing) { }

	// RVA: 0x2291610 Offset: 0x228FC10 VA: 0x182291610
	public static void PointOutsideBox(ref Vector3 position, Vector3 boxSize) { }

	// RVA: 0x2290700 Offset: 0x228ED00 VA: 0x182290700
	public static void PointInsideBox(ref Vector3 position, BoxCollider collider, float spacing) { }

	// RVA: 0x2290540 Offset: 0x228EB40 VA: 0x182290540
	private static void PointInsideBox(ref Vector3 position, Vector3 boxSize) { }

	// RVA: 0x2292030 Offset: 0x2290630 VA: 0x182292030
	public static void PointOutsideCollider(ref Vector3 position, Collider collider, float spacing) { }

	// RVA: 0x228F9B0 Offset: 0x228DFB0 VA: 0x18228F9B0
	public static void DrawGizmosArrow(Vector3 startPoint, Vector3 direction, float halfWidth, Vector3 normal) { }

	// RVA: 0x228FF20 Offset: 0x228E520 VA: 0x18228FF20
	public static void DrawGizmosPolyLine(Vector3[] vertices) { }

}

