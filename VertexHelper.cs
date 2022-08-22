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

	// RVA: 0x2249840 Offset: 0x2247E40 VA: 0x182249840
	public void .ctor(Mesh m) { }

	// RVA: 0x2249110 Offset: 0x2247710 VA: 0x182249110
	private void InitializeListIfRequired() { }

	// RVA: 0x2248D00 Offset: 0x2247300 VA: 0x182248D00 Slot: 4
	public void Dispose() { }

	// RVA: 0x2248BF0 Offset: 0x22471F0 VA: 0x182248BF0
	public void Clear() { }

	// RVA: 0x2249A50 Offset: 0x2248050 VA: 0x182249A50
	public int get_currentVertCount() { }

	// RVA: 0x2249A10 Offset: 0x2248010 VA: 0x182249A10
	public int get_currentIndexCount() { }

	// RVA: 0x22492E0 Offset: 0x22478E0 VA: 0x1822492E0
	public void PopulateUIVertex(ref UIVertex vertex, int i) { }

	// RVA: 0x22494D0 Offset: 0x2247AD0 VA: 0x1822494D0
	public void SetUIVertex(UIVertex vertex, int i) { }

	// RVA: 0x2248F40 Offset: 0x2247540 VA: 0x182248F40
	public void FillMesh(Mesh mesh) { }

	// RVA: 0x2248940 Offset: 0x2246F40 VA: 0x182248940
	public void AddVert(Vector3 position, Color32 color, Vector2 uv0, Vector2 uv1, Vector2 uv2, Vector2 uv3, Vector3 normal, Vector4 tangent) { }

	// RVA: 0x2248AD0 Offset: 0x22470D0 VA: 0x182248AD0
	public void AddVert(Vector3 position, Color32 color, Vector2 uv0, Vector2 uv1, Vector3 normal, Vector4 tangent) { }

	// RVA: 0x2248790 Offset: 0x2246D90 VA: 0x182248790
	public void AddVert(Vector3 position, Color32 color, Vector2 uv0) { }

	// RVA: 0x2248620 Offset: 0x2246C20 VA: 0x182248620
	public void AddVert(UIVertex v) { }

	// RVA: 0x2248050 Offset: 0x2246650 VA: 0x182248050
	public void AddTriangle(int idx0, int idx1, int idx2) { }

	// RVA: 0x2248100 Offset: 0x2246700 VA: 0x182248100
	public void AddUIVertexQuad(UIVertex[] verts) { }

	// RVA: 0x22484E0 Offset: 0x2246AE0 VA: 0x1822484E0
	public void AddUIVertexStream(List<UIVertex> verts, List<int> indices) { }

	// RVA: 0x22485A0 Offset: 0x2246BA0 VA: 0x1822485A0
	public void AddUIVertexTriangleStream(List<UIVertex> verts) { }

	// RVA: 0x2249090 Offset: 0x2247690 VA: 0x182249090
	public void GetUIVertexStream(List<UIVertex> stream) { }

	// RVA: 0x2249780 Offset: 0x2247D80 VA: 0x182249780
	private static void .cctor() { }

}

