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
	// RVA: 0x19B8050 Offset: 0x19B6650 VA: 0x1819B8050
	private void .ctor() { }

	// RVA: 0x19B7ED0 Offset: 0x19B64D0 VA: 0x1819B7ED0
	internal int GetPackingMode() { }

	// RVA: 0x19B7E90 Offset: 0x19B6490 VA: 0x1819B7E90
	internal int GetPacked() { }

	// RVA: 0x19B8000 Offset: 0x19B6600 VA: 0x1819B8000
	internal Rect GetTextureRect() { }

	// RVA: 0x19B7DA0 Offset: 0x19B63A0 VA: 0x1819B7DA0
	internal Vector4 GetInnerUVs() { }

	// RVA: 0x19B7E40 Offset: 0x19B6440 VA: 0x1819B7E40
	internal Vector4 GetOuterUVs() { }

	// RVA: 0x19B7F60 Offset: 0x19B6560 VA: 0x1819B7F60
	internal Vector4 GetPadding() { }

	[FreeFunctionAttribute] // RVA: 0xD23B0 Offset: 0xD17B0 VA: 0x1800D23B0
	// RVA: 0x19B74F0 Offset: 0x19B5AF0 VA: 0x1819B74F0
	internal static Sprite CreateSprite(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape) { }

	// RVA: 0x19B81E0 Offset: 0x19B67E0 VA: 0x1819B81E0
	public Bounds get_bounds() { }

	// RVA: 0x19B83B0 Offset: 0x19B69B0 VA: 0x1819B83B0
	public Rect get_rect() { }

	// RVA: 0x19B8140 Offset: 0x19B6740 VA: 0x1819B8140
	public Vector4 get_border() { }

	// RVA: 0x19B84D0 Offset: 0x19B6AD0 VA: 0x1819B84D0
	public Texture2D get_texture() { }

	[NativeMethodAttribute] // RVA: 0xD2470 Offset: 0xD1870 VA: 0x1800D2470
	// RVA: 0x19B8320 Offset: 0x19B6920 VA: 0x1819B8320
	public float get_pixelsPerUnit() { }

	[NativeMethodAttribute] // RVA: 0xD2630 Offset: 0xD1A30 VA: 0x1800D2630
	// RVA: 0x19B80B0 Offset: 0x19B66B0 VA: 0x1819B80B0
	public Texture2D get_associatedAlphaSplitTexture() { }

	[NativeMethodAttribute] // RVA: 0xD2720 Offset: 0xD1B20 VA: 0x1800D2720
	// RVA: 0x19B82D0 Offset: 0x19B68D0 VA: 0x1819B82D0
	public Vector2 get_pivot() { }

	// RVA: 0x19B8240 Offset: 0x19B6840 VA: 0x1819B8240
	public bool get_packed() { }

	// RVA: 0x19B7ED0 Offset: 0x19B64D0 VA: 0x1819B7ED0
	public SpritePackingMode get_packingMode() { }

	// RVA: 0x19B8400 Offset: 0x19B6A00 VA: 0x1819B8400
	public Rect get_textureRect() { }

	[FreeFunctionAttribute] // RVA: 0xD2810 Offset: 0xD1C10 VA: 0x1800D2810
	// RVA: 0x19B8590 Offset: 0x19B6B90 VA: 0x1819B8590
	public Vector2[] get_vertices() { }

	[FreeFunctionAttribute] // RVA: 0xD2A10 Offset: 0xD1E10 VA: 0x1800D2A10
	// RVA: 0x19B8510 Offset: 0x19B6B10 VA: 0x1819B8510
	public ushort[] get_triangles() { }

	[FreeFunctionAttribute] // RVA: 0xD3E00 Offset: 0xD3200 VA: 0x1800D3E00
	// RVA: 0x19B8550 Offset: 0x19B6B50 VA: 0x1819B8550
	public Vector2[] get_uv() { }

	// RVA: 0x19B7940 Offset: 0x19B5F40 VA: 0x1819B7940
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape) { }

	// RVA: 0x19B7580 Offset: 0x19B5B80 VA: 0x1819B7580
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border) { }

	// RVA: 0x19B7780 Offset: 0x19B5D80 VA: 0x1819B7780
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType) { }

	// RVA: 0x19B7860 Offset: 0x19B5E60 VA: 0x1819B7860
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude) { }

	// RVA: 0x19B75E0 Offset: 0x19B5BE0 VA: 0x1819B75E0
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit) { }

	// RVA: 0x19B76B0 Offset: 0x19B5CB0 VA: 0x1819B76B0
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot) { }

	// RVA: 0x19B7FB0 Offset: 0x19B65B0 VA: 0x1819B7FB0
	private void GetTextureRect_Injected(out Rect ret) { }

	// RVA: 0x19B7D50 Offset: 0x19B6350 VA: 0x1819B7D50
	private void GetInnerUVs_Injected(out Vector4 ret) { }

	// RVA: 0x19B7DF0 Offset: 0x19B63F0 VA: 0x1819B7DF0
	private void GetOuterUVs_Injected(out Vector4 ret) { }

	// RVA: 0x19B7F10 Offset: 0x19B6510 VA: 0x1819B7F10
	private void GetPadding_Injected(out Vector4 ret) { }

	// RVA: 0x19B7470 Offset: 0x19B5A70 VA: 0x1819B7470
	private static Sprite CreateSprite_Injected(Texture2D texture, ref Rect rect, ref Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, ref Vector4 border, bool generateFallbackPhysicsShape) { }

	// RVA: 0x19B8190 Offset: 0x19B6790 VA: 0x1819B8190
	private void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x19B8360 Offset: 0x19B6960 VA: 0x1819B8360
	private void get_rect_Injected(out Rect ret) { }

	// RVA: 0x19B80F0 Offset: 0x19B66F0 VA: 0x1819B80F0
	private void get_border_Injected(out Vector4 ret) { }

	// RVA: 0x19B8280 Offset: 0x19B6880 VA: 0x1819B8280
	private void get_pivot_Injected(out Vector2 ret) { }

}

