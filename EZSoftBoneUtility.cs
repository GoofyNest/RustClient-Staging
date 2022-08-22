public static class EZSoftBoneUtility // TypeDefIndex: 7137
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22903A0 Offset: 0x228E9A0 VA: 0x1822903A0
	internal static Vector3 Abs(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2290FA0 Offset: 0x228F5A0 VA: 0x182290FA0
	public static float Max(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2290450 Offset: 0x228EA50 VA: 0x182290450
	public static bool Contains(LayerMask mask, int layer) { }

	// RVA: 0x2290AC0 Offset: 0x228F0C0 VA: 0x182290AC0
	public static void GetCapsuleParams(CapsuleCollider collider, out Vector3 center0, out Vector3 center1, out float radius) { }

	// RVA: 0x2290E10 Offset: 0x228F410 VA: 0x182290E10
	public static void GetCylinderParams(Transform transform, out Vector3 center, out Vector3 direction, out float radius, out float height) { }

	// RVA: 0x2293320 Offset: 0x2291920 VA: 0x182293320
	public static void PointOutsideSphere(ref Vector3 position, SphereCollider collider, float spacing) { }

	// RVA: 0x2293510 Offset: 0x2291B10 VA: 0x182293510
	private static void PointOutsideSphere(ref Vector3 position, Vector3 spherePosition, float radius) { }

	// RVA: 0x2292020 Offset: 0x2290620 VA: 0x182292020
	public static void PointInsideSphere(ref Vector3 position, SphereCollider collider, float spacing) { }

	// RVA: 0x2291EA0 Offset: 0x22904A0 VA: 0x182291EA0
	private static void PointInsideSphere(ref Vector3 position, Vector3 spherePosition, float radius) { }

	// RVA: 0x2292A60 Offset: 0x2291060 VA: 0x182292A60
	public static void PointOutsideCapsule(ref Vector3 position, CapsuleCollider collider, float spacing) { }

	// RVA: 0x2292780 Offset: 0x2290D80 VA: 0x182292780
	public static void PointOutsideCapsule(ref Vector3 position, Vector3 center0, Vector3 center1, float radius) { }

	// RVA: 0x22919C0 Offset: 0x228FFC0 VA: 0x1822919C0
	public static void PointInsideCapsule(ref Vector3 position, CapsuleCollider collider, float spacing) { }

	// RVA: 0x22916E0 Offset: 0x228FCE0 VA: 0x1822916E0
	private static void PointInsideCapsule(ref Vector3 position, Vector3 center0, Vector3 center1, float radius) { }

	// RVA: 0x2293150 Offset: 0x2291750 VA: 0x182293150
	public static void PointOutsideCylinder(ref Vector3 position, Transform transform, float spacing) { }

	// RVA: 0x2292E90 Offset: 0x2291490 VA: 0x182292E90
	private static void PointOutsideCylinder(ref Vector3 position, Vector3 center, Vector3 direction, float radius, float height) { }

	// RVA: 0x2291CD0 Offset: 0x22902D0 VA: 0x182291CD0
	public static void PointInsideCylinder(ref Vector3 position, Transform transform, float spacing) { }

	// RVA: 0x2291A70 Offset: 0x2290070 VA: 0x182291A70
	private static void PointInsideCylinder(ref Vector3 position, Vector3 center, Vector3 direction, float radius, float height) { }

	// RVA: 0x22923C0 Offset: 0x22909C0 VA: 0x1822923C0
	public static void PointOutsideBox(ref Vector3 position, BoxCollider collider, float spacing) { }

	// RVA: 0x22920F0 Offset: 0x22906F0 VA: 0x1822920F0
	public static void PointOutsideBox(ref Vector3 position, Vector3 boxSize) { }

	// RVA: 0x22911E0 Offset: 0x228F7E0 VA: 0x1822911E0
	public static void PointInsideBox(ref Vector3 position, BoxCollider collider, float spacing) { }

	// RVA: 0x2291020 Offset: 0x228F620 VA: 0x182291020
	private static void PointInsideBox(ref Vector3 position, Vector3 boxSize) { }

	// RVA: 0x2292B10 Offset: 0x2291110 VA: 0x182292B10
	public static void PointOutsideCollider(ref Vector3 position, Collider collider, float spacing) { }

	// RVA: 0x2290490 Offset: 0x228EA90 VA: 0x182290490
	public static void DrawGizmosArrow(Vector3 startPoint, Vector3 direction, float halfWidth, Vector3 normal) { }

	// RVA: 0x2290A00 Offset: 0x228F000 VA: 0x182290A00
	public static void DrawGizmosPolyLine(Vector3[] vertices) { }

}

