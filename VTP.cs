public class VTP : MonoBehaviour // TypeDefIndex: 11527
{	// Methods

	// RVA: 0xACC870 Offset: 0xACAE70 VA: 0x180ACC870
	public static Color getSingleVertexColorAtHit(Transform transform, RaycastHit hit) { }

	// RVA: 0xACC670 Offset: 0xACAC70 VA: 0x180ACC670
	public static Color getFaceVerticesColorAtHit(Transform transform, RaycastHit hit) { }

	// RVA: 0xACCE50 Offset: 0xACB450 VA: 0x180ACCE50
	public static void paintSingleVertexOnHit(Transform transform, RaycastHit hit, Color color, float strength) { }

	// RVA: 0xACCB90 Offset: 0xACB190 VA: 0x180ACCB90
	public static void paintFaceVerticesOnHit(Transform transform, RaycastHit hit, Color color, float strength) { }

	// RVA: 0xACC0E0 Offset: 0xACA6E0 VA: 0x180ACC0E0
	public static void deformSingleVertexOnHit(Transform transform, RaycastHit hit, bool up, float strength, bool recalculateNormals, bool recalculateCollider, bool recalculateFlow) { }

	// RVA: 0xACBC70 Offset: 0xACA270 VA: 0x180ACBC70
	public static void deformFaceVerticesOnHit(Transform transform, RaycastHit hit, bool up, float strength, bool recalculateNormals, bool recalculateCollider, bool recalculateFlow) { }

	// RVA: 0xACD210 Offset: 0xACB810 VA: 0x180ACD210
	private static void recalculateMeshForFlow(Transform transform, Vector3[] currentVertices, Vector3[] currentNormals, Vector4[] currentTangents) { }

	// RVA: 0xACB210 Offset: 0xAC9810 VA: 0x180ACB210
	private static Vector4[] calculateMeshTangents(int[] triangles, Vector3[] vertices, Vector2[] uv, Vector3[] normals) { }

	// RVA: 0xACB100 Offset: 0xAC9700 VA: 0x180ACB100
	public static Color VertexColorLerp(Color colorA, Color colorB, float value) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

