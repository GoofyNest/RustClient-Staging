public class VTP : MonoBehaviour // TypeDefIndex: 11527
{	// Methods

	// RVA: 0xACCD40 Offset: 0xACB340 VA: 0x180ACCD40
	public static Color getSingleVertexColorAtHit(Transform transform, RaycastHit hit) { }

	// RVA: 0xACCB40 Offset: 0xACB140 VA: 0x180ACCB40
	public static Color getFaceVerticesColorAtHit(Transform transform, RaycastHit hit) { }

	// RVA: 0xACD320 Offset: 0xACB920 VA: 0x180ACD320
	public static void paintSingleVertexOnHit(Transform transform, RaycastHit hit, Color color, float strength) { }

	// RVA: 0xACD060 Offset: 0xACB660 VA: 0x180ACD060
	public static void paintFaceVerticesOnHit(Transform transform, RaycastHit hit, Color color, float strength) { }

	// RVA: 0xACC5B0 Offset: 0xACABB0 VA: 0x180ACC5B0
	public static void deformSingleVertexOnHit(Transform transform, RaycastHit hit, bool up, float strength, bool recalculateNormals, bool recalculateCollider, bool recalculateFlow) { }

	// RVA: 0xACC140 Offset: 0xACA740 VA: 0x180ACC140
	public static void deformFaceVerticesOnHit(Transform transform, RaycastHit hit, bool up, float strength, bool recalculateNormals, bool recalculateCollider, bool recalculateFlow) { }

	// RVA: 0xACD6E0 Offset: 0xACBCE0 VA: 0x180ACD6E0
	private static void recalculateMeshForFlow(Transform transform, Vector3[] currentVertices, Vector3[] currentNormals, Vector4[] currentTangents) { }

	// RVA: 0xACB6E0 Offset: 0xAC9CE0 VA: 0x180ACB6E0
	private static Vector4[] calculateMeshTangents(int[] triangles, Vector3[] vertices, Vector2[] uv, Vector3[] normals) { }

	// RVA: 0xACB5D0 Offset: 0xAC9BD0 VA: 0x180ACB5D0
	public static Color VertexColorLerp(Color colorA, Color colorB, float value) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

