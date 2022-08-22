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

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19B8310 Offset: 0x19B6910 VA: 0x1819B8310
	private void .ctor() { }

	// RVA: 0x19B8190 Offset: 0x19B6790 VA: 0x1819B8190
	internal int GetPackingMode() { }

	// RVA: 0x19B8150 Offset: 0x19B6750 VA: 0x1819B8150
	internal int GetPacked() { }

	// RVA: 0x19B82C0 Offset: 0x19B68C0 VA: 0x1819B82C0
	internal Rect GetTextureRect() { }

	// RVA: 0x19B8060 Offset: 0x19B6660 VA: 0x1819B8060
	internal Vector4 GetInnerUVs() { }

	// RVA: 0x19B8100 Offset: 0x19B6700 VA: 0x1819B8100
	internal Vector4 GetOuterUVs() { }

	// RVA: 0x19B8220 Offset: 0x19B6820 VA: 0x1819B8220
	internal Vector4 GetPadding() { }

	[FreeFunctionAttribute] // RVA: 0xD23B0 Offset: 0xD17B0 VA: 0x1800D23B0
	// RVA: 0x19B77B0 Offset: 0x19B5DB0 VA: 0x1819B77B0
	internal static Sprite CreateSprite(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape) { }

	// RVA: 0x19B84A0 Offset: 0x19B6AA0 VA: 0x1819B84A0
	public Bounds get_bounds() { }

	// RVA: 0x19B8670 Offset: 0x19B6C70 VA: 0x1819B8670
	public Rect get_rect() { }

	// RVA: 0x19B8400 Offset: 0x19B6A00 VA: 0x1819B8400
	public Vector4 get_border() { }

	// RVA: 0x19B8790 Offset: 0x19B6D90 VA: 0x1819B8790
	public Texture2D get_texture() { }

	[NativeMethodAttribute] // RVA: 0xD2470 Offset: 0xD1870 VA: 0x1800D2470
	// RVA: 0x19B85E0 Offset: 0x19B6BE0 VA: 0x1819B85E0
	public float get_pixelsPerUnit() { }

	[NativeMethodAttribute] // RVA: 0xD2630 Offset: 0xD1A30 VA: 0x1800D2630
	// RVA: 0x19B8370 Offset: 0x19B6970 VA: 0x1819B8370
	public Texture2D get_associatedAlphaSplitTexture() { }

	[NativeMethodAttribute] // RVA: 0xD2720 Offset: 0xD1B20 VA: 0x1800D2720
	// RVA: 0x19B8590 Offset: 0x19B6B90 VA: 0x1819B8590
	public Vector2 get_pivot() { }

	// RVA: 0x19B8500 Offset: 0x19B6B00 VA: 0x1819B8500
	public bool get_packed() { }

	// RVA: 0x19B8190 Offset: 0x19B6790 VA: 0x1819B8190
	public SpritePackingMode get_packingMode() { }

	// RVA: 0x19B86C0 Offset: 0x19B6CC0 VA: 0x1819B86C0
	public Rect get_textureRect() { }

	[FreeFunctionAttribute] // RVA: 0xD2810 Offset: 0xD1C10 VA: 0x1800D2810
	// RVA: 0x19B8850 Offset: 0x19B6E50 VA: 0x1819B8850
	public Vector2[] get_vertices() { }

	[FreeFunctionAttribute] // RVA: 0xD2A10 Offset: 0xD1E10 VA: 0x1800D2A10
	// RVA: 0x19B87D0 Offset: 0x19B6DD0 VA: 0x1819B87D0
	public ushort[] get_triangles() { }

	[FreeFunctionAttribute] // RVA: 0xD3E00 Offset: 0xD3200 VA: 0x1800D3E00
	// RVA: 0x19B8810 Offset: 0x19B6E10 VA: 0x1819B8810
	public Vector2[] get_uv() { }

	// RVA: 0x19B7C00 Offset: 0x19B6200 VA: 0x1819B7C00
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape) { }

	// RVA: 0x19B7840 Offset: 0x19B5E40 VA: 0x1819B7840
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border) { }

	// RVA: 0x19B7A40 Offset: 0x19B6040 VA: 0x1819B7A40
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType) { }

	// RVA: 0x19B7B20 Offset: 0x19B6120 VA: 0x1819B7B20
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude) { }

	// RVA: 0x19B78A0 Offset: 0x19B5EA0 VA: 0x1819B78A0
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit) { }

	// RVA: 0x19B7970 Offset: 0x19B5F70 VA: 0x1819B7970
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot) { }

	// RVA: 0x19B8270 Offset: 0x19B6870 VA: 0x1819B8270
	private void GetTextureRect_Injected(out Rect ret) { }

	// RVA: 0x19B8010 Offset: 0x19B6610 VA: 0x1819B8010
	private void GetInnerUVs_Injected(out Vector4 ret) { }

	// RVA: 0x19B80B0 Offset: 0x19B66B0 VA: 0x1819B80B0
	private void GetOuterUVs_Injected(out Vector4 ret) { }

	// RVA: 0x19B81D0 Offset: 0x19B67D0 VA: 0x1819B81D0
	private void GetPadding_Injected(out Vector4 ret) { }

	// RVA: 0x19B7730 Offset: 0x19B5D30 VA: 0x1819B7730
	private static Sprite CreateSprite_Injected(Texture2D texture, ref Rect rect, ref Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, ref Vector4 border, bool generateFallbackPhysicsShape) { }

	// RVA: 0x19B8450 Offset: 0x19B6A50 VA: 0x1819B8450
	private void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x19B8620 Offset: 0x19B6C20 VA: 0x1819B8620
	private void get_rect_Injected(out Rect ret) { }

	// RVA: 0x19B83B0 Offset: 0x19B69B0 VA: 0x1819B83B0
	private void get_border_Injected(out Vector4 ret) { }

	// RVA: 0x19B8540 Offset: 0x19B6B40 VA: 0x1819B8540
	private void get_pivot_Injected(out Vector2 ret) { }

}

