public class VertexHelper : IDisposable // TypeDefIndex: 5029
{	// Fields
	private List<Vector3> m_Positions; // 0x10
	private List<Color32> m_Colors; // 0x18
	private List<Vector2> m_Uv0S; // 0x20
	private List<Vector2> m_Uv1S; // 0x28
	private List<Vector2> m_Uv2S; // 0x30
	private List<Vector2> m_Uv3S; // 0x38
	private List<Vector3> m_Normals; // 0x40
	private List<Vector4> m_Tangents; // 0x48
	private List<int> m_Indices; // 0x50
	private static readonly Vector4 s_DefaultTangent; // 0x0
	private static readonly Vector3 s_DefaultNormal; // 0x10
	private bool m_ListsInitalized; // 0x58

	// Properties
	public int currentVertCount { get; }
	public int currentIndexCount { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x2249B00 Offset: 0x2248100 VA: 0x182249B00
	public void .ctor(Mesh m) { }

	// RVA: 0x22493D0 Offset: 0x22479D0 VA: 0x1822493D0
	private void InitializeListIfRequired() { }

	// RVA: 0x2248FC0 Offset: 0x22475C0 VA: 0x182248FC0 Slot: 4
	public void Dispose() { }

	// RVA: 0x2248EB0 Offset: 0x22474B0 VA: 0x182248EB0
	public void Clear() { }

	// RVA: 0x2249D10 Offset: 0x2248310 VA: 0x182249D10
	public int get_currentVertCount() { }

	// RVA: 0x2249CD0 Offset: 0x22482D0 VA: 0x182249CD0
	public int get_currentIndexCount() { }

	// RVA: 0x22495A0 Offset: 0x2247BA0 VA: 0x1822495A0
	public void PopulateUIVertex(ref UIVertex vertex, int i) { }

	// RVA: 0x2249790 Offset: 0x2247D90 VA: 0x182249790
	public void SetUIVertex(UIVertex vertex, int i) { }

	// RVA: 0x2249200 Offset: 0x2247800 VA: 0x182249200
	public void FillMesh(Mesh mesh) { }

	// RVA: 0x2248C00 Offset: 0x2247200 VA: 0x182248C00
	public void AddVert(Vector3 position, Color32 color, Vector2 uv0, Vector2 uv1, Vector2 uv2, Vector2 uv3, Vector3 normal, Vector4 tangent) { }

	// RVA: 0x2248D90 Offset: 0x2247390 VA: 0x182248D90
	public void AddVert(Vector3 position, Color32 color, Vector2 uv0, Vector2 uv1, Vector3 normal, Vector4 tangent) { }

	// RVA: 0x2248A50 Offset: 0x2247050 VA: 0x182248A50
	public void AddVert(Vector3 position, Color32 color, Vector2 uv0) { }

	// RVA: 0x22488E0 Offset: 0x2246EE0 VA: 0x1822488E0
	public void AddVert(UIVertex v) { }

	// RVA: 0x2248310 Offset: 0x2246910 VA: 0x182248310
	public void AddTriangle(int idx0, int idx1, int idx2) { }

	// RVA: 0x22483C0 Offset: 0x22469C0 VA: 0x1822483C0
	public void AddUIVertexQuad(UIVertex[] verts) { }

	// RVA: 0x22487A0 Offset: 0x2246DA0 VA: 0x1822487A0
	public void AddUIVertexStream(List<UIVertex> verts, List<int> indices) { }

	// RVA: 0x2248860 Offset: 0x2246E60 VA: 0x182248860
	public void AddUIVertexTriangleStream(List<UIVertex> verts) { }

	// RVA: 0x2249350 Offset: 0x2247950 VA: 0x182249350
	public void GetUIVertexStream(List<UIVertex> stream) { }

	// RVA: 0x2249A40 Offset: 0x2248040 VA: 0x182249A40
	private static void .cctor() { }

}

