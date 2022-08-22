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

	// RVA: 0xADDB90 Offset: 0xADC190 VA: 0x180ADDB90
	public void init(Mesh origMesh, bool destroyOld) { }

	// RVA: 0xADEAA0 Offset: 0xADD0A0 VA: 0x180ADEAA0
	public void setWholeMesh(Mesh tmpMesh) { }

	// RVA: 0xADE900 Offset: 0xADCF00 VA: 0x180ADE900
	public Vector3[] setVertices(Vector3[] _deformedVertices) { }

	// RVA: 0xADDB70 Offset: 0xADC170 VA: 0x180ADDB70
	public Vector3[] getVertices() { }

	// RVA: 0xADDAD0 Offset: 0xADC0D0 VA: 0x180ADDAD0
	public Vector3[] getNormals() { }

	// RVA: 0xADDB10 Offset: 0xADC110 VA: 0x180ADDB10
	public int[] getTriangles() { }

	// RVA: 0xADE860 Offset: 0xADCE60 VA: 0x180ADE860
	public void setTangents(Vector4[] _meshTangents) { }

	// RVA: 0xADDAF0 Offset: 0xADC0F0 VA: 0x180ADDAF0
	public Vector4[] getTangents() { }

	// RVA: 0xADE810 Offset: 0xADCE10 VA: 0x180ADE810
	public void setColors(Color[] _vertexColors) { }

	// RVA: 0xADDAB0 Offset: 0xADC0B0 VA: 0x180ADDAB0
	public Color[] getColors() { }

	// RVA: 0xADDB50 Offset: 0xADC150 VA: 0x180ADDB50
	public Vector2[] getUVs() { }

	// RVA: 0xADE8B0 Offset: 0xADCEB0 VA: 0x180ADE8B0
	public void setUV4s(Vector2[] _uv4s) { }

	// RVA: 0xADDB30 Offset: 0xADC130 VA: 0x180ADDB30
	public Vector2[] getUV4s() { }

	// RVA: 0xADECE0 Offset: 0xADD2E0 VA: 0x180ADECE0
	public void unlink() { }

	// RVA: 0xADE160 Offset: 0xADC760 VA: 0x180ADE160
	public void rebuild() { }

	// RVA: 0xADDA30 Offset: 0xADC030 VA: 0x180ADDA30
	private void Start() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

