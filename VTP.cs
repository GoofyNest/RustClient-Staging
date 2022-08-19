public class VTP : MonoBehaviour // TypeDefIndex: 11527
{	// Methods

	// RVA: 0xACC5B0 Offset: 0xACABB0 VA: 0x180ACC5B0
	public static Color getSingleVertexColorAtHit(Transform transform, RaycastHit hit) { }

	// RVA: 0xACC3B0 Offset: 0xACA9B0 VA: 0x180ACC3B0
	public static Color getFaceVerticesColorAtHit(Transform transform, RaycastHit hit) { }

	// RVA: 0xACCB90 Offset: 0xACB190 VA: 0x180ACCB90
	public static void paintSingleVertexOnHit(Transform transform, RaycastHit hit, Color color, float strength) { }

	// RVA: 0xACC8D0 Offset: 0xACAED0 VA: 0x180ACC8D0
	public static void paintFaceVerticesOnHit(Transform transform, RaycastHit hit, Color color, float strength) { }

	// RVA: 0xACBE20 Offset: 0xACA420 VA: 0x180ACBE20
	public static void deformSingleVertexOnHit(Transform transform, RaycastHit hit, bool up, float strength, bool recalculateNormals, bool recalculateCollider, bool recalculateFlow) { }

	// RVA: 0xACB9B0 Offset: 0xAC9FB0 VA: 0x180ACB9B0
	public static void deformFaceVerticesOnHit(Transform transform, RaycastHit hit, bool up, float strength, bool recalculateNormals, bool recalculateCollider, bool recalculateFlow) { }

	// RVA: 0xACCF50 Offset: 0xACB550 VA: 0x180ACCF50
	private static void recalculateMeshForFlow(Transform transform, Vector3[] currentVertices, Vector3[] currentNormals, Vector4[] currentTangents) { }

	// RVA: 0xACAF50 Offset: 0xAC9550 VA: 0x180ACAF50
	private static Vector4[] calculateMeshTangents(int[] triangles, Vector3[] vertices, Vector2[] uv, Vector3[] normals) { }

	// RVA: 0xACAE40 Offset: 0xAC9440 VA: 0x180ACAE40
	public static Color VertexColorLerp(Color colorA, Color colorB, float value) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

