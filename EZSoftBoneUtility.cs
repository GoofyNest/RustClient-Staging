public static class EZSoftBoneUtility // TypeDefIndex: 7137
{
	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal static Vector3 Abs(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static float Max(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static bool Contains(LayerMask mask, int layer) { }

	public static void GetCapsuleParams(CapsuleCollider collider, out Vector3 center0, out Vector3 center1, out float radius) { }

	public static void GetCylinderParams(Transform transform, out Vector3 center, out Vector3 direction, out float radius, out float height) { }

	public static void PointOutsideSphere(ref Vector3 position, SphereCollider collider, float spacing) { }

	private static void PointOutsideSphere(ref Vector3 position, Vector3 spherePosition, float radius) { }

	public static void PointInsideSphere(ref Vector3 position, SphereCollider collider, float spacing) { }

	private static void PointInsideSphere(ref Vector3 position, Vector3 spherePosition, float radius) { }

	public static void PointOutsideCapsule(ref Vector3 position, CapsuleCollider collider, float spacing) { }

	public static void PointOutsideCapsule(ref Vector3 position, Vector3 center0, Vector3 center1, float radius) { }

	public static void PointInsideCapsule(ref Vector3 position, CapsuleCollider collider, float spacing) { }

	private static void PointInsideCapsule(ref Vector3 position, Vector3 center0, Vector3 center1, float radius) { }

	public static void PointOutsideCylinder(ref Vector3 position, Transform transform, float spacing) { }

	private static void PointOutsideCylinder(ref Vector3 position, Vector3 center, Vector3 direction, float radius, float height) { }

	public static void PointInsideCylinder(ref Vector3 position, Transform transform, float spacing) { }

	private static void PointInsideCylinder(ref Vector3 position, Vector3 center, Vector3 direction, float radius, float height) { }

	public static void PointOutsideBox(ref Vector3 position, BoxCollider collider, float spacing) { }

	public static void PointOutsideBox(ref Vector3 position, Vector3 boxSize) { }

	public static void PointInsideBox(ref Vector3 position, BoxCollider collider, float spacing) { }

	private static void PointInsideBox(ref Vector3 position, Vector3 boxSize) { }

	public static void PointOutsideCollider(ref Vector3 position, Collider collider, float spacing) { }

	public static void DrawGizmosArrow(Vector3 startPoint, Vector3 direction, float halfWidth, Vector3 normal) { }

	public static void DrawGizmosPolyLine(Vector3[] vertices) { }

}

