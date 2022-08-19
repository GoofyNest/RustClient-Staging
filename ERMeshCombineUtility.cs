public class ERMeshCombineUtility // TypeDefIndex: 7239
{	// Methods

	// RVA: 0x45F740 Offset: 0x45DD40 VA: 0x18045F740
	public static Mesh Combine(Transform container, ERMeshCombineUtility.MeshInstance[] combines, bool generateStrips) { }

	// RVA: 0x460FD0 Offset: 0x45F5D0 VA: 0x180460FD0
	private static void Copy(int vertexcount, Vector3[] src, Vector3[] dst, ref int offset, Matrix4x4 transform) { }

	// RVA: 0x460CF0 Offset: 0x45F2F0 VA: 0x180460CF0
	private static void CopyNormal(int vertexcount, Vector3[] src, Vector3[] dst, ref int offset, Matrix4x4 transform) { }

	// RVA: 0x4610D0 Offset: 0x45F6D0 VA: 0x1804610D0
	private static void Copy(int vertexcount, Vector2[] src, Vector2[] dst, ref int offset) { }

	// RVA: 0x460E30 Offset: 0x45F430 VA: 0x180460E30
	private static void CopyTangents(int vertexcount, Vector4[] src, Vector4[] dst, ref int offset, Matrix4x4 transform) { }

	// RVA: 0x45E900 Offset: 0x45CF00 VA: 0x18045E900
	public static void CombineMesh(GameObject go, Mesh mesh, Transform container, bool isSideObject) { }

	// RVA: 0x461160 Offset: 0x45F760 VA: 0x180461160
	public static List<ERMeshCombineUtility.MeshInstance> GetCombinedInstances(List<CombineClass> mToMesh, Material m) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public struct ERMeshCombineUtility.MeshInstance // TypeDefIndex: 7240
{	// Fields
	public Mesh mesh; // 0x0
	public int subMeshIndex; // 0x8
	public Matrix4x4 transform; // 0xC
	public int vertexCount; // 0x4C
	public bool flipTriangles; // 0x50

}

