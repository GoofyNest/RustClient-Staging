public sealed class CanvasRenderer : Component // TypeDefIndex: 4732
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private bool <isMask>k__BackingField; // 0x18

	// Properties
	public bool hasPopInstruction { set; }
	public int materialCount { get; set; }
	public int popMaterialCount { set; }
	public int absoluteDepth { get; }
	public bool hasMoved { get; }
	[NativePropertyAttribute] // RVA: 0xA4D30 Offset: 0xA4130 VA: 0x1800A4D30
	public bool cull { get; set; }

	// Methods

	// RVA: 0x2308920 Offset: 0x2306F20 VA: 0x182308920
	public void set_hasPopInstruction(bool value) { }

	// RVA: 0x2308890 Offset: 0x2306E90 VA: 0x182308890
	public int get_materialCount() { }

	// RVA: 0x2308970 Offset: 0x2306F70 VA: 0x182308970
	public void set_materialCount(int value) { }

	// RVA: 0x23089B0 Offset: 0x2306FB0 VA: 0x1823089B0
	public void set_popMaterialCount(int value) { }

	// RVA: 0x23087D0 Offset: 0x2306DD0 VA: 0x1823087D0
	public int get_absoluteDepth() { }

	// RVA: 0x2308850 Offset: 0x2306E50 VA: 0x182308850
	public bool get_hasMoved() { }

	// RVA: 0x2308810 Offset: 0x2306E10 VA: 0x182308810
	public bool get_cull() { }

	// RVA: 0x23088D0 Offset: 0x2306ED0 VA: 0x1823088D0
	public void set_cull(bool value) { }

	// RVA: 0x23083E0 Offset: 0x23069E0 VA: 0x1823083E0
	public void SetColor(Color color) { }

	// RVA: 0x23081D0 Offset: 0x23067D0 VA: 0x1823081D0
	public Color GetColor() { }

	// RVA: 0x2308130 Offset: 0x2306730 VA: 0x182308130
	public void EnableRectClipping(Rect rect) { }

	// RVA: 0x23080A0 Offset: 0x23066A0 VA: 0x1823080A0
	public void DisableRectClipping() { }

	// RVA: 0x2308430 Offset: 0x2306A30 VA: 0x182308430
	public void SetMaterial(Material material, int index) { }

	// RVA: 0x2308260 Offset: 0x2306860 VA: 0x182308260
	public Material GetMaterial(int index) { }

	// RVA: 0x2308600 Offset: 0x2306C00 VA: 0x182308600
	public void SetPopMaterial(Material material, int index) { }

	// RVA: 0x2308660 Offset: 0x2306C60 VA: 0x182308660
	public void SetTexture(Texture texture) { }

	// RVA: 0x23082A0 Offset: 0x23068A0 VA: 0x1823082A0
	public void SetAlphaTexture(Texture texture) { }

	// RVA: 0x23085B0 Offset: 0x2306BB0 VA: 0x1823085B0
	public void SetMesh(Mesh mesh) { }

	// RVA: 0x2307FF0 Offset: 0x23065F0 VA: 0x182307FF0
	public void Clear() { }

	// RVA: 0x23082F0 Offset: 0x23068F0 VA: 0x1823082F0
	public void SetAlpha(float alpha) { }

	// RVA: 0x2308490 Offset: 0x2306A90 VA: 0x182308490
	public void SetMaterial(Material material, Texture texture) { }

	// RVA: 0x2308220 Offset: 0x2306820 VA: 0x182308220
	public Material GetMaterial() { }

	// RVA: 0x2308700 Offset: 0x2306D00 VA: 0x182308700
	public static void SplitUIVertexStreams(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector2> uv2S, List<Vector2> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices) { }

	// RVA: 0x2308030 Offset: 0x2306630 VA: 0x182308030
	public static void CreateUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector2> uv2S, List<Vector2> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices) { }

	// RVA: 0x2307F80 Offset: 0x2306580 VA: 0x182307F80
	public static void AddUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector2> uv2S, List<Vector2> uv3S, List<Vector3> normals, List<Vector4> tangents) { }

	[StaticAccessorAttribute] // RVA: 0xA4B60 Offset: 0xA3F60 VA: 0x1800A4B60
	// RVA: 0x23086B0 Offset: 0x2306CB0 VA: 0x1823086B0
	private static void SplitIndicesStreamsInternal(object verts, object indices) { }

	[StaticAccessorAttribute] // RVA: 0xA4B60 Offset: 0xA3F60 VA: 0x1800A4B60
	// RVA: 0x2307F80 Offset: 0x2306580 VA: 0x182307F80
	private static void SplitUIVertexStreamsInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents) { }

	[StaticAccessorAttribute] // RVA: 0xA4B60 Offset: 0xA3F60 VA: 0x1800A4B60
	// RVA: 0x2308030 Offset: 0x2306630 VA: 0x182308030
	private static void CreateUIVertexStreamInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents, object indices) { }

	// RVA: 0x2308390 Offset: 0x2306990 VA: 0x182308390
	private void SetColor_Injected(ref Color color) { }

	// RVA: 0x2308180 Offset: 0x2306780 VA: 0x182308180
	private void GetColor_Injected(out Color ret) { }

	// RVA: 0x23080E0 Offset: 0x23066E0 VA: 0x1823080E0
	private void EnableRectClipping_Injected(ref Rect rect) { }

}

