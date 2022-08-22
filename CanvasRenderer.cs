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

	// RVA: 0x2309400 Offset: 0x2307A00 VA: 0x182309400
	public void set_hasPopInstruction(bool value) { }

	// RVA: 0x2309370 Offset: 0x2307970 VA: 0x182309370
	public int get_materialCount() { }

	// RVA: 0x2309450 Offset: 0x2307A50 VA: 0x182309450
	public void set_materialCount(int value) { }

	// RVA: 0x2309490 Offset: 0x2307A90 VA: 0x182309490
	public void set_popMaterialCount(int value) { }

	// RVA: 0x23092B0 Offset: 0x23078B0 VA: 0x1823092B0
	public int get_absoluteDepth() { }

	// RVA: 0x2309330 Offset: 0x2307930 VA: 0x182309330
	public bool get_hasMoved() { }

	// RVA: 0x23092F0 Offset: 0x23078F0 VA: 0x1823092F0
	public bool get_cull() { }

	// RVA: 0x23093B0 Offset: 0x23079B0 VA: 0x1823093B0
	public void set_cull(bool value) { }

	// RVA: 0x2308EC0 Offset: 0x23074C0 VA: 0x182308EC0
	public void SetColor(Color color) { }

	// RVA: 0x2308CB0 Offset: 0x23072B0 VA: 0x182308CB0
	public Color GetColor() { }

	// RVA: 0x2308C10 Offset: 0x2307210 VA: 0x182308C10
	public void EnableRectClipping(Rect rect) { }

	// RVA: 0x2308B80 Offset: 0x2307180 VA: 0x182308B80
	public void DisableRectClipping() { }

	// RVA: 0x2308F10 Offset: 0x2307510 VA: 0x182308F10
	public void SetMaterial(Material material, int index) { }

	// RVA: 0x2308D40 Offset: 0x2307340 VA: 0x182308D40
	public Material GetMaterial(int index) { }

	// RVA: 0x23090E0 Offset: 0x23076E0 VA: 0x1823090E0
	public void SetPopMaterial(Material material, int index) { }

	// RVA: 0x2309140 Offset: 0x2307740 VA: 0x182309140
	public void SetTexture(Texture texture) { }

	// RVA: 0x2308D80 Offset: 0x2307380 VA: 0x182308D80
	public void SetAlphaTexture(Texture texture) { }

	// RVA: 0x2309090 Offset: 0x2307690 VA: 0x182309090
	public void SetMesh(Mesh mesh) { }

	// RVA: 0x2308AD0 Offset: 0x23070D0 VA: 0x182308AD0
	public void Clear() { }

	// RVA: 0x2308DD0 Offset: 0x23073D0 VA: 0x182308DD0
	public void SetAlpha(float alpha) { }

	// RVA: 0x2308F70 Offset: 0x2307570 VA: 0x182308F70
	public void SetMaterial(Material material, Texture texture) { }

	// RVA: 0x2308D00 Offset: 0x2307300 VA: 0x182308D00
	public Material GetMaterial() { }

	// RVA: 0x23091E0 Offset: 0x23077E0 VA: 0x1823091E0
	public static void SplitUIVertexStreams(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector2> uv2S, List<Vector2> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices) { }

	// RVA: 0x2308B10 Offset: 0x2307110 VA: 0x182308B10
	public static void CreateUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector2> uv2S, List<Vector2> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices) { }

	// RVA: 0x2308A60 Offset: 0x2307060 VA: 0x182308A60
	public static void AddUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector2> uv2S, List<Vector2> uv3S, List<Vector3> normals, List<Vector4> tangents) { }

	[StaticAccessorAttribute] // RVA: 0xA4B60 Offset: 0xA3F60 VA: 0x1800A4B60
	// RVA: 0x2309190 Offset: 0x2307790 VA: 0x182309190
	private static void SplitIndicesStreamsInternal(object verts, object indices) { }

	[StaticAccessorAttribute] // RVA: 0xA4B60 Offset: 0xA3F60 VA: 0x1800A4B60
	// RVA: 0x2308A60 Offset: 0x2307060 VA: 0x182308A60
	private static void SplitUIVertexStreamsInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents) { }

	[StaticAccessorAttribute] // RVA: 0xA4B60 Offset: 0xA3F60 VA: 0x1800A4B60
	// RVA: 0x2308B10 Offset: 0x2307110 VA: 0x182308B10
	private static void CreateUIVertexStreamInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents, object indices) { }

	// RVA: 0x2308E70 Offset: 0x2307470 VA: 0x182308E70
	private void SetColor_Injected(ref Color color) { }

	// RVA: 0x2308C60 Offset: 0x2307260 VA: 0x182308C60
	private void GetColor_Injected(out Color ret) { }

	// RVA: 0x2308BC0 Offset: 0x23071C0 VA: 0x182308BC0
	private void EnableRectClipping_Injected(ref Rect rect) { }

}

