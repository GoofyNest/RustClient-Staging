public class VertexColorStream : MonoBehaviour // TypeDefIndex: 11531
{	// Fields
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Mesh originalMesh; // 0x18
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Mesh paintedMesh; // 0x20
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public MeshHolder meshHold; // 0x28
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Vector3[] _vertices; // 0x30
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Vector3[] _normals; // 0x38
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int[] _triangles; // 0x40
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int[][] _Subtriangles; // 0x48
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Matrix4x4[] _bindPoses; // 0x50
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public BoneWeight[] _boneWeights; // 0x58
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Bounds _bounds; // 0x60
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int _subMeshCount; // 0x78
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Vector4[] _tangents; // 0x80
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Vector2[] _uv; // 0x88
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Vector2[] _uv2; // 0x90
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Vector2[] _uv3; // 0x98
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Color[] _colors; // 0xA0
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Vector2[] _uv4; // 0xA8

	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void OnDidApplyAnimationProperties() { }

	// RVA: 0xADE320 Offset: 0xADC920 VA: 0x180ADE320
	public void init(Mesh origMesh, bool destroyOld) { }

	// RVA: 0xADF230 Offset: 0xADD830 VA: 0x180ADF230
	public void setWholeMesh(Mesh tmpMesh) { }

	// RVA: 0xADF090 Offset: 0xADD690 VA: 0x180ADF090
	public Vector3[] setVertices(Vector3[] _deformedVertices) { }

	// RVA: 0xADE300 Offset: 0xADC900 VA: 0x180ADE300
	public Vector3[] getVertices() { }

	// RVA: 0xADE260 Offset: 0xADC860 VA: 0x180ADE260
	public Vector3[] getNormals() { }

	// RVA: 0xADE2A0 Offset: 0xADC8A0 VA: 0x180ADE2A0
	public int[] getTriangles() { }

	// RVA: 0xADEFF0 Offset: 0xADD5F0 VA: 0x180ADEFF0
	public void setTangents(Vector4[] _meshTangents) { }

	// RVA: 0xADE280 Offset: 0xADC880 VA: 0x180ADE280
	public Vector4[] getTangents() { }

	// RVA: 0xADEFA0 Offset: 0xADD5A0 VA: 0x180ADEFA0
	public void setColors(Color[] _vertexColors) { }

	// RVA: 0xADE240 Offset: 0xADC840 VA: 0x180ADE240
	public Color[] getColors() { }

	// RVA: 0xADE2E0 Offset: 0xADC8E0 VA: 0x180ADE2E0
	public Vector2[] getUVs() { }

	// RVA: 0xADF040 Offset: 0xADD640 VA: 0x180ADF040
	public void setUV4s(Vector2[] _uv4s) { }

	// RVA: 0xADE2C0 Offset: 0xADC8C0 VA: 0x180ADE2C0
	public Vector2[] getUV4s() { }

	// RVA: 0xADF470 Offset: 0xADDA70 VA: 0x180ADF470
	public void unlink() { }

	// RVA: 0xADE8F0 Offset: 0xADCEF0 VA: 0x180ADE8F0
	public void rebuild() { }

	// RVA: 0xADE1C0 Offset: 0xADC7C0 VA: 0x180ADE1C0
	private void Start() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

