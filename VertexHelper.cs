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

	// RVA: 0x224A320 Offset: 0x2248920 VA: 0x18224A320
	public void .ctor(Mesh m) { }

	// RVA: 0x2249BF0 Offset: 0x22481F0 VA: 0x182249BF0
	private void InitializeListIfRequired() { }

	// RVA: 0x22497E0 Offset: 0x2247DE0 VA: 0x1822497E0 Slot: 4
	public void Dispose() { }

	// RVA: 0x22496D0 Offset: 0x2247CD0 VA: 0x1822496D0
	public void Clear() { }

	// RVA: 0x224A530 Offset: 0x2248B30 VA: 0x18224A530
	public int get_currentVertCount() { }

	// RVA: 0x224A4F0 Offset: 0x2248AF0 VA: 0x18224A4F0
	public int get_currentIndexCount() { }

	// RVA: 0x2249DC0 Offset: 0x22483C0 VA: 0x182249DC0
	public void PopulateUIVertex(ref UIVertex vertex, int i) { }

	// RVA: 0x2249FB0 Offset: 0x22485B0 VA: 0x182249FB0
	public void SetUIVertex(UIVertex vertex, int i) { }

	// RVA: 0x2249A20 Offset: 0x2248020 VA: 0x182249A20
	public void FillMesh(Mesh mesh) { }

	// RVA: 0x2249420 Offset: 0x2247A20 VA: 0x182249420
	public void AddVert(Vector3 position, Color32 color, Vector2 uv0, Vector2 uv1, Vector2 uv2, Vector2 uv3, Vector3 normal, Vector4 tangent) { }

	// RVA: 0x22495B0 Offset: 0x2247BB0 VA: 0x1822495B0
	public void AddVert(Vector3 position, Color32 color, Vector2 uv0, Vector2 uv1, Vector3 normal, Vector4 tangent) { }

	// RVA: 0x2249270 Offset: 0x2247870 VA: 0x182249270
	public void AddVert(Vector3 position, Color32 color, Vector2 uv0) { }

	// RVA: 0x2249100 Offset: 0x2247700 VA: 0x182249100
	public void AddVert(UIVertex v) { }

	// RVA: 0x2248B30 Offset: 0x2247130 VA: 0x182248B30
	public void AddTriangle(int idx0, int idx1, int idx2) { }

	// RVA: 0x2248BE0 Offset: 0x22471E0 VA: 0x182248BE0
	public void AddUIVertexQuad(UIVertex[] verts) { }

	// RVA: 0x2248FC0 Offset: 0x22475C0 VA: 0x182248FC0
	public void AddUIVertexStream(List<UIVertex> verts, List<int> indices) { }

	// RVA: 0x2249080 Offset: 0x2247680 VA: 0x182249080
	public void AddUIVertexTriangleStream(List<UIVertex> verts) { }

	// RVA: 0x2249B70 Offset: 0x2248170 VA: 0x182249B70
	public void GetUIVertexStream(List<UIVertex> stream) { }

	// RVA: 0x224A260 Offset: 0x2248860 VA: 0x18224A260
	private static void .cctor() { }

}

