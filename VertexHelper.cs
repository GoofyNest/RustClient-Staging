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

	// RVA: 0x2249A00 Offset: 0x2248000 VA: 0x182249A00
	public void .ctor(Mesh m) { }

	// RVA: 0x22492D0 Offset: 0x22478D0 VA: 0x1822492D0
	private void InitializeListIfRequired() { }

	// RVA: 0x2248EC0 Offset: 0x22474C0 VA: 0x182248EC0 Slot: 4
	public void Dispose() { }

	// RVA: 0x2248DB0 Offset: 0x22473B0 VA: 0x182248DB0
	public void Clear() { }

	// RVA: 0x2249C10 Offset: 0x2248210 VA: 0x182249C10
	public int get_currentVertCount() { }

	// RVA: 0x2249BD0 Offset: 0x22481D0 VA: 0x182249BD0
	public int get_currentIndexCount() { }

	// RVA: 0x22494A0 Offset: 0x2247AA0 VA: 0x1822494A0
	public void PopulateUIVertex(ref UIVertex vertex, int i) { }

	// RVA: 0x2249690 Offset: 0x2247C90 VA: 0x182249690
	public void SetUIVertex(UIVertex vertex, int i) { }

	// RVA: 0x2249100 Offset: 0x2247700 VA: 0x182249100
	public void FillMesh(Mesh mesh) { }

	// RVA: 0x2248B00 Offset: 0x2247100 VA: 0x182248B00
	public void AddVert(Vector3 position, Color32 color, Vector2 uv0, Vector2 uv1, Vector2 uv2, Vector2 uv3, Vector3 normal, Vector4 tangent) { }

	// RVA: 0x2248C90 Offset: 0x2247290 VA: 0x182248C90
	public void AddVert(Vector3 position, Color32 color, Vector2 uv0, Vector2 uv1, Vector3 normal, Vector4 tangent) { }

	// RVA: 0x2248950 Offset: 0x2246F50 VA: 0x182248950
	public void AddVert(Vector3 position, Color32 color, Vector2 uv0) { }

	// RVA: 0x22487E0 Offset: 0x2246DE0 VA: 0x1822487E0
	public void AddVert(UIVertex v) { }

	// RVA: 0x2248210 Offset: 0x2246810 VA: 0x182248210
	public void AddTriangle(int idx0, int idx1, int idx2) { }

	// RVA: 0x22482C0 Offset: 0x22468C0 VA: 0x1822482C0
	public void AddUIVertexQuad(UIVertex[] verts) { }

	// RVA: 0x22486A0 Offset: 0x2246CA0 VA: 0x1822486A0
	public void AddUIVertexStream(List<UIVertex> verts, List<int> indices) { }

	// RVA: 0x2248760 Offset: 0x2246D60 VA: 0x182248760
	public void AddUIVertexTriangleStream(List<UIVertex> verts) { }

	// RVA: 0x2249250 Offset: 0x2247850 VA: 0x182249250
	public void GetUIVertexStream(List<UIVertex> stream) { }

	// RVA: 0x2249940 Offset: 0x2247F40 VA: 0x182249940
	private static void .cctor() { }

}

