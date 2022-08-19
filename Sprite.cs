public sealed class Sprite : Object // TypeDefIndex: 3574
{	// Properties
	public Bounds bounds { get; }
	public Rect rect { get; }
	public Vector4 border { get; }
	public Texture2D texture { get; }
	public float pixelsPerUnit { get; }
	public Texture2D associatedAlphaSplitTexture { get; }
	public Vector2 pivot { get; }
	public bool packed { get; }
	public SpritePackingMode packingMode { get; }
	public Rect textureRect { get; }
	public Vector2[] vertices { get; }
	public ushort[] triangles { get; }
	public Vector2[] uv { get; }

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19B8090 Offset: 0x19B6690 VA: 0x1819B8090
	private void .ctor() { }

	// RVA: 0x19B7F10 Offset: 0x19B6510 VA: 0x1819B7F10
	internal int GetPackingMode() { }

	// RVA: 0x19B7ED0 Offset: 0x19B64D0 VA: 0x1819B7ED0
	internal int GetPacked() { }

	// RVA: 0x19B8040 Offset: 0x19B6640 VA: 0x1819B8040
	internal Rect GetTextureRect() { }

	// RVA: 0x19B7DE0 Offset: 0x19B63E0 VA: 0x1819B7DE0
	internal Vector4 GetInnerUVs() { }

	// RVA: 0x19B7E80 Offset: 0x19B6480 VA: 0x1819B7E80
	internal Vector4 GetOuterUVs() { }

	// RVA: 0x19B7FA0 Offset: 0x19B65A0 VA: 0x1819B7FA0
	internal Vector4 GetPadding() { }

	[FreeFunctionAttribute] // RVA: 0xD2320 Offset: 0xD1720 VA: 0x1800D2320
	// RVA: 0x19B7530 Offset: 0x19B5B30 VA: 0x1819B7530
	internal static Sprite CreateSprite(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape) { }

	// RVA: 0x19B8220 Offset: 0x19B6820 VA: 0x1819B8220
	public Bounds get_bounds() { }

	// RVA: 0x19B83F0 Offset: 0x19B69F0 VA: 0x1819B83F0
	public Rect get_rect() { }

	// RVA: 0x19B8180 Offset: 0x19B6780 VA: 0x1819B8180
	public Vector4 get_border() { }

	// RVA: 0x19B8510 Offset: 0x19B6B10 VA: 0x1819B8510
	public Texture2D get_texture() { }

	[NativeMethodAttribute] // RVA: 0xD23E0 Offset: 0xD17E0 VA: 0x1800D23E0
	// RVA: 0x19B8360 Offset: 0x19B6960 VA: 0x1819B8360
	public float get_pixelsPerUnit() { }

	[NativeMethodAttribute] // RVA: 0xD25A0 Offset: 0xD19A0 VA: 0x1800D25A0
	// RVA: 0x19B80F0 Offset: 0x19B66F0 VA: 0x1819B80F0
	public Texture2D get_associatedAlphaSplitTexture() { }

	[NativeMethodAttribute] // RVA: 0xD2660 Offset: 0xD1A60 VA: 0x1800D2660
	// RVA: 0x19B8310 Offset: 0x19B6910 VA: 0x1819B8310
	public Vector2 get_pivot() { }

	// RVA: 0x19B8280 Offset: 0x19B6880 VA: 0x1819B8280
	public bool get_packed() { }

	// RVA: 0x19B7F10 Offset: 0x19B6510 VA: 0x1819B7F10
	public SpritePackingMode get_packingMode() { }

	// RVA: 0x19B8440 Offset: 0x19B6A40 VA: 0x1819B8440
	public Rect get_textureRect() { }

	[FreeFunctionAttribute] // RVA: 0xD2750 Offset: 0xD1B50 VA: 0x1800D2750
	// RVA: 0x19B85D0 Offset: 0x19B6BD0 VA: 0x1819B85D0
	public Vector2[] get_vertices() { }

	[FreeFunctionAttribute] // RVA: 0xD2980 Offset: 0xD1D80 VA: 0x1800D2980
	// RVA: 0x19B8550 Offset: 0x19B6B50 VA: 0x1819B8550
	public ushort[] get_triangles() { }

	[FreeFunctionAttribute] // RVA: 0xD3CF0 Offset: 0xD30F0 VA: 0x1800D3CF0
	// RVA: 0x19B8590 Offset: 0x19B6B90 VA: 0x1819B8590
	public Vector2[] get_uv() { }

	// RVA: 0x19B7980 Offset: 0x19B5F80 VA: 0x1819B7980
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape) { }

	// RVA: 0x19B75C0 Offset: 0x19B5BC0 VA: 0x1819B75C0
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border) { }

	// RVA: 0x19B77C0 Offset: 0x19B5DC0 VA: 0x1819B77C0
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType) { }

	// RVA: 0x19B78A0 Offset: 0x19B5EA0 VA: 0x1819B78A0
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude) { }

	// RVA: 0x19B7620 Offset: 0x19B5C20 VA: 0x1819B7620
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit) { }

	// RVA: 0x19B76F0 Offset: 0x19B5CF0 VA: 0x1819B76F0
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot) { }

	// RVA: 0x19B7FF0 Offset: 0x19B65F0 VA: 0x1819B7FF0
	private void GetTextureRect_Injected(out Rect ret) { }

	// RVA: 0x19B7D90 Offset: 0x19B6390 VA: 0x1819B7D90
	private void GetInnerUVs_Injected(out Vector4 ret) { }

	// RVA: 0x19B7E30 Offset: 0x19B6430 VA: 0x1819B7E30
	private void GetOuterUVs_Injected(out Vector4 ret) { }

	// RVA: 0x19B7F50 Offset: 0x19B6550 VA: 0x1819B7F50
	private void GetPadding_Injected(out Vector4 ret) { }

	// RVA: 0x19B74B0 Offset: 0x19B5AB0 VA: 0x1819B74B0
	private static Sprite CreateSprite_Injected(Texture2D texture, ref Rect rect, ref Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, ref Vector4 border, bool generateFallbackPhysicsShape) { }

	// RVA: 0x19B81D0 Offset: 0x19B67D0 VA: 0x1819B81D0
	private void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x19B83A0 Offset: 0x19B69A0 VA: 0x1819B83A0
	private void get_rect_Injected(out Rect ret) { }

	// RVA: 0x19B8130 Offset: 0x19B6730 VA: 0x1819B8130
	private void get_border_Injected(out Vector4 ret) { }

	// RVA: 0x19B82C0 Offset: 0x19B68C0 VA: 0x1819B82C0
	private void get_pivot_Injected(out Vector2 ret) { }

}

