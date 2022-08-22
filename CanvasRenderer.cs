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

	// RVA: 0x2308BE0 Offset: 0x23071E0 VA: 0x182308BE0
	public void set_hasPopInstruction(bool value) { }

	// RVA: 0x2308B50 Offset: 0x2307150 VA: 0x182308B50
	public int get_materialCount() { }

	// RVA: 0x2308C30 Offset: 0x2307230 VA: 0x182308C30
	public void set_materialCount(int value) { }

	// RVA: 0x2308C70 Offset: 0x2307270 VA: 0x182308C70
	public void set_popMaterialCount(int value) { }

	// RVA: 0x2308A90 Offset: 0x2307090 VA: 0x182308A90
	public int get_absoluteDepth() { }

	// RVA: 0x2308B10 Offset: 0x2307110 VA: 0x182308B10
	public bool get_hasMoved() { }

	// RVA: 0x2308AD0 Offset: 0x23070D0 VA: 0x182308AD0
	public bool get_cull() { }

	// RVA: 0x2308B90 Offset: 0x2307190 VA: 0x182308B90
	public void set_cull(bool value) { }

	// RVA: 0x23086A0 Offset: 0x2306CA0 VA: 0x1823086A0
	public void SetColor(Color color) { }

	// RVA: 0x2308490 Offset: 0x2306A90 VA: 0x182308490
	public Color GetColor() { }

	// RVA: 0x23083F0 Offset: 0x23069F0 VA: 0x1823083F0
	public void EnableRectClipping(Rect rect) { }

	// RVA: 0x2308360 Offset: 0x2306960 VA: 0x182308360
	public void DisableRectClipping() { }

	// RVA: 0x23086F0 Offset: 0x2306CF0 VA: 0x1823086F0
	public void SetMaterial(Material material, int index) { }

	// RVA: 0x2308520 Offset: 0x2306B20 VA: 0x182308520
	public Material GetMaterial(int index) { }

	// RVA: 0x23088C0 Offset: 0x2306EC0 VA: 0x1823088C0
	public void SetPopMaterial(Material material, int index) { }

	// RVA: 0x2308920 Offset: 0x2306F20 VA: 0x182308920
	public void SetTexture(Texture texture) { }

	// RVA: 0x2308560 Offset: 0x2306B60 VA: 0x182308560
	public void SetAlphaTexture(Texture texture) { }

	// RVA: 0x2308870 Offset: 0x2306E70 VA: 0x182308870
	public void SetMesh(Mesh mesh) { }

	// RVA: 0x23082B0 Offset: 0x23068B0 VA: 0x1823082B0
	public void Clear() { }

	// RVA: 0x23085B0 Offset: 0x2306BB0 VA: 0x1823085B0
	public void SetAlpha(float alpha) { }

	// RVA: 0x2308750 Offset: 0x2306D50 VA: 0x182308750
	public void SetMaterial(Material material, Texture texture) { }

	// RVA: 0x23084E0 Offset: 0x2306AE0 VA: 0x1823084E0
	public Material GetMaterial() { }

	// RVA: 0x23089C0 Offset: 0x2306FC0 VA: 0x1823089C0
	public static void SplitUIVertexStreams(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector2> uv2S, List<Vector2> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices) { }

	// RVA: 0x23082F0 Offset: 0x23068F0 VA: 0x1823082F0
	public static void CreateUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector2> uv2S, List<Vector2> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices) { }

	// RVA: 0x2308240 Offset: 0x2306840 VA: 0x182308240
	public static void AddUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector2> uv2S, List<Vector2> uv3S, List<Vector3> normals, List<Vector4> tangents) { }

	[StaticAccessorAttribute] // RVA: 0xA4B60 Offset: 0xA3F60 VA: 0x1800A4B60
	// RVA: 0x2308970 Offset: 0x2306F70 VA: 0x182308970
	private static void SplitIndicesStreamsInternal(object verts, object indices) { }

	[StaticAccessorAttribute] // RVA: 0xA4B60 Offset: 0xA3F60 VA: 0x1800A4B60
	// RVA: 0x2308240 Offset: 0x2306840 VA: 0x182308240
	private static void SplitUIVertexStreamsInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents) { }

	[StaticAccessorAttribute] // RVA: 0xA4B60 Offset: 0xA3F60 VA: 0x1800A4B60
	// RVA: 0x23082F0 Offset: 0x23068F0 VA: 0x1823082F0
	private static void CreateUIVertexStreamInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents, object indices) { }

	// RVA: 0x2308650 Offset: 0x2306C50 VA: 0x182308650
	private void SetColor_Injected(ref Color color) { }

	// RVA: 0x2308440 Offset: 0x2306A40 VA: 0x182308440
	private void GetColor_Injected(out Color ret) { }

	// RVA: 0x23083A0 Offset: 0x23069A0 VA: 0x1823083A0
	private void EnableRectClipping_Injected(ref Rect rect) { }

}

