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

	// RVA: 0xADDE50 Offset: 0xADC450 VA: 0x180ADDE50
	public void init(Mesh origMesh, bool destroyOld) { }

	// RVA: 0xADED60 Offset: 0xADD360 VA: 0x180ADED60
	public void setWholeMesh(Mesh tmpMesh) { }

	// RVA: 0xADEBC0 Offset: 0xADD1C0 VA: 0x180ADEBC0
	public Vector3[] setVertices(Vector3[] _deformedVertices) { }

	// RVA: 0xADDE30 Offset: 0xADC430 VA: 0x180ADDE30
	public Vector3[] getVertices() { }

	// RVA: 0xADDD90 Offset: 0xADC390 VA: 0x180ADDD90
	public Vector3[] getNormals() { }

	// RVA: 0xADDDD0 Offset: 0xADC3D0 VA: 0x180ADDDD0
	public int[] getTriangles() { }

	// RVA: 0xADEB20 Offset: 0xADD120 VA: 0x180ADEB20
	public void setTangents(Vector4[] _meshTangents) { }

	// RVA: 0xADDDB0 Offset: 0xADC3B0 VA: 0x180ADDDB0
	public Vector4[] getTangents() { }

	// RVA: 0xADEAD0 Offset: 0xADD0D0 VA: 0x180ADEAD0
	public void setColors(Color[] _vertexColors) { }

	// RVA: 0xADDD70 Offset: 0xADC370 VA: 0x180ADDD70
	public Color[] getColors() { }

	// RVA: 0xADDE10 Offset: 0xADC410 VA: 0x180ADDE10
	public Vector2[] getUVs() { }

	// RVA: 0xADEB70 Offset: 0xADD170 VA: 0x180ADEB70
	public void setUV4s(Vector2[] _uv4s) { }

	// RVA: 0xADDDF0 Offset: 0xADC3F0 VA: 0x180ADDDF0
	public Vector2[] getUV4s() { }

	// RVA: 0xADEFA0 Offset: 0xADD5A0 VA: 0x180ADEFA0
	public void unlink() { }

	// RVA: 0xADE420 Offset: 0xADCA20 VA: 0x180ADE420
	public void rebuild() { }

	// RVA: 0xADDCF0 Offset: 0xADC2F0 VA: 0x180ADDCF0
	private void Start() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

