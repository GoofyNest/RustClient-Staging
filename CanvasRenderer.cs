public sealed class CanvasRenderer : Component // TypeDefIndex: 4732
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	[DebuggerBrowsableAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	private bool <isMask>k__BackingField; // 0x18

	// Properties
	public bool hasPopInstruction { set; }
	public int materialCount { get; set; }
	public int popMaterialCount { set; }
	public int absoluteDepth { get; }
	public bool hasMoved { get; }
	[NativePropertyAttribute] // RVA: 0xA4CA0 Offset: 0xA40A0 VA: 0x1800A4CA0
	public bool cull { get; set; }

	// Methods

	// RVA: 0x2308AE0 Offset: 0x23070E0 VA: 0x182308AE0
	public void set_hasPopInstruction(bool value) { }

	// RVA: 0x2308A50 Offset: 0x2307050 VA: 0x182308A50
	public int get_materialCount() { }

	// RVA: 0x2308B30 Offset: 0x2307130 VA: 0x182308B30
	public void set_materialCount(int value) { }

	// RVA: 0x2308B70 Offset: 0x2307170 VA: 0x182308B70
	public void set_popMaterialCount(int value) { }

	// RVA: 0x2308990 Offset: 0x2306F90 VA: 0x182308990
	public int get_absoluteDepth() { }

	// RVA: 0x2308A10 Offset: 0x2307010 VA: 0x182308A10
	public bool get_hasMoved() { }

	// RVA: 0x23089D0 Offset: 0x2306FD0 VA: 0x1823089D0
	public bool get_cull() { }

	// RVA: 0x2308A90 Offset: 0x2307090 VA: 0x182308A90
	public void set_cull(bool value) { }

	// RVA: 0x23085A0 Offset: 0x2306BA0 VA: 0x1823085A0
	public void SetColor(Color color) { }

	// RVA: 0x2308390 Offset: 0x2306990 VA: 0x182308390
	public Color GetColor() { }

	// RVA: 0x23082F0 Offset: 0x23068F0 VA: 0x1823082F0
	public void EnableRectClipping(Rect rect) { }

	// RVA: 0x2308260 Offset: 0x2306860 VA: 0x182308260
	public void DisableRectClipping() { }

	// RVA: 0x23085F0 Offset: 0x2306BF0 VA: 0x1823085F0
	public void SetMaterial(Material material, int index) { }

	// RVA: 0x2308420 Offset: 0x2306A20 VA: 0x182308420
	public Material GetMaterial(int index) { }

	// RVA: 0x23087C0 Offset: 0x2306DC0 VA: 0x1823087C0
	public void SetPopMaterial(Material material, int index) { }

	// RVA: 0x2308820 Offset: 0x2306E20 VA: 0x182308820
	public void SetTexture(Texture texture) { }

	// RVA: 0x2308460 Offset: 0x2306A60 VA: 0x182308460
	public void SetAlphaTexture(Texture texture) { }

	// RVA: 0x2308770 Offset: 0x2306D70 VA: 0x182308770
	public void SetMesh(Mesh mesh) { }

	// RVA: 0x23081B0 Offset: 0x23067B0 VA: 0x1823081B0
	public void Clear() { }

	// RVA: 0x23084B0 Offset: 0x2306AB0 VA: 0x1823084B0
	public void SetAlpha(float alpha) { }

	// RVA: 0x2308650 Offset: 0x2306C50 VA: 0x182308650
	public void SetMaterial(Material material, Texture texture) { }

	// RVA: 0x23083E0 Offset: 0x23069E0 VA: 0x1823083E0
	public Material GetMaterial() { }

	// RVA: 0x23088C0 Offset: 0x2306EC0 VA: 0x1823088C0
	public static void SplitUIVertexStreams(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector2> uv2S, List<Vector2> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices) { }

	// RVA: 0x23081F0 Offset: 0x23067F0 VA: 0x1823081F0
	public static void CreateUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector2> uv2S, List<Vector2> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices) { }

	// RVA: 0x2308140 Offset: 0x2306740 VA: 0x182308140
	public static void AddUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector2> uv2S, List<Vector2> uv3S, List<Vector3> normals, List<Vector4> tangents) { }

	[StaticAccessorAttribute] // RVA: 0xA4AD0 Offset: 0xA3ED0 VA: 0x1800A4AD0
	// RVA: 0x2308870 Offset: 0x2306E70 VA: 0x182308870
	private static void SplitIndicesStreamsInternal(object verts, object indices) { }

	[StaticAccessorAttribute] // RVA: 0xA4AD0 Offset: 0xA3ED0 VA: 0x1800A4AD0
	// RVA: 0x2308140 Offset: 0x2306740 VA: 0x182308140
	private static void SplitUIVertexStreamsInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents) { }

	[StaticAccessorAttribute] // RVA: 0xA4AD0 Offset: 0xA3ED0 VA: 0x1800A4AD0
	// RVA: 0x23081F0 Offset: 0x23067F0 VA: 0x1823081F0
	private static void CreateUIVertexStreamInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents, object indices) { }

	// RVA: 0x2308550 Offset: 0x2306B50 VA: 0x182308550
	private void SetColor_Injected(ref Color color) { }

	// RVA: 0x2308340 Offset: 0x2306940 VA: 0x182308340
	private void GetColor_Injected(out Color ret) { }

	// RVA: 0x23082A0 Offset: 0x23068A0 VA: 0x1823082A0
	private void EnableRectClipping_Injected(ref Rect rect) { }

}

