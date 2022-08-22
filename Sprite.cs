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
	// RVA: 0x19A5710 Offset: 0x19A3D10 VA: 0x1819A5710
	private void .ctor() { }

	// RVA: 0x19A5590 Offset: 0x19A3B90 VA: 0x1819A5590
	internal int GetPackingMode() { }

	// RVA: 0x19A5550 Offset: 0x19A3B50 VA: 0x1819A5550
	internal int GetPacked() { }

	// RVA: 0x19A56C0 Offset: 0x19A3CC0 VA: 0x1819A56C0
	internal Rect GetTextureRect() { }

	// RVA: 0x19A5460 Offset: 0x19A3A60 VA: 0x1819A5460
	internal Vector4 GetInnerUVs() { }

	// RVA: 0x19A5500 Offset: 0x19A3B00 VA: 0x1819A5500
	internal Vector4 GetOuterUVs() { }

	// RVA: 0x19A5620 Offset: 0x19A3C20 VA: 0x1819A5620
	internal Vector4 GetPadding() { }

	[FreeFunctionAttribute] // RVA: 0xD23B0 Offset: 0xD17B0 VA: 0x1800D23B0
	// RVA: 0x19A4BB0 Offset: 0x19A31B0 VA: 0x1819A4BB0
	internal static Sprite CreateSprite(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape) { }

	// RVA: 0x19A58A0 Offset: 0x19A3EA0 VA: 0x1819A58A0
	public Bounds get_bounds() { }

	// RVA: 0x19A5A70 Offset: 0x19A4070 VA: 0x1819A5A70
	public Rect get_rect() { }

	// RVA: 0x19A5800 Offset: 0x19A3E00 VA: 0x1819A5800
	public Vector4 get_border() { }

	// RVA: 0x19A5B90 Offset: 0x19A4190 VA: 0x1819A5B90
	public Texture2D get_texture() { }

	[NativeMethodAttribute] // RVA: 0xD2470 Offset: 0xD1870 VA: 0x1800D2470
	// RVA: 0x19A59E0 Offset: 0x19A3FE0 VA: 0x1819A59E0
	public float get_pixelsPerUnit() { }

	[NativeMethodAttribute] // RVA: 0xD2630 Offset: 0xD1A30 VA: 0x1800D2630
	// RVA: 0x19A5770 Offset: 0x19A3D70 VA: 0x1819A5770
	public Texture2D get_associatedAlphaSplitTexture() { }

	[NativeMethodAttribute] // RVA: 0xD2720 Offset: 0xD1B20 VA: 0x1800D2720
	// RVA: 0x19A5990 Offset: 0x19A3F90 VA: 0x1819A5990
	public Vector2 get_pivot() { }

	// RVA: 0x19A5900 Offset: 0x19A3F00 VA: 0x1819A5900
	public bool get_packed() { }

	// RVA: 0x19A5590 Offset: 0x19A3B90 VA: 0x1819A5590
	public SpritePackingMode get_packingMode() { }

	// RVA: 0x19A5AC0 Offset: 0x19A40C0 VA: 0x1819A5AC0
	public Rect get_textureRect() { }

	[FreeFunctionAttribute] // RVA: 0xD2810 Offset: 0xD1C10 VA: 0x1800D2810
	// RVA: 0x19A5C50 Offset: 0x19A4250 VA: 0x1819A5C50
	public Vector2[] get_vertices() { }

	[FreeFunctionAttribute] // RVA: 0xD2A10 Offset: 0xD1E10 VA: 0x1800D2A10
	// RVA: 0x19A5BD0 Offset: 0x19A41D0 VA: 0x1819A5BD0
	public ushort[] get_triangles() { }

	[FreeFunctionAttribute] // RVA: 0xD3E00 Offset: 0xD3200 VA: 0x1800D3E00
	// RVA: 0x19A5C10 Offset: 0x19A4210 VA: 0x1819A5C10
	public Vector2[] get_uv() { }

	// RVA: 0x19A5000 Offset: 0x19A3600 VA: 0x1819A5000
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape) { }

	// RVA: 0x19A4C40 Offset: 0x19A3240 VA: 0x1819A4C40
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border) { }

	// RVA: 0x19A4E40 Offset: 0x19A3440 VA: 0x1819A4E40
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType) { }

	// RVA: 0x19A4F20 Offset: 0x19A3520 VA: 0x1819A4F20
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude) { }

	// RVA: 0x19A4CA0 Offset: 0x19A32A0 VA: 0x1819A4CA0
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit) { }

	// RVA: 0x19A4D70 Offset: 0x19A3370 VA: 0x1819A4D70
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot) { }

	// RVA: 0x19A5670 Offset: 0x19A3C70 VA: 0x1819A5670
	private void GetTextureRect_Injected(out Rect ret) { }

	// RVA: 0x19A5410 Offset: 0x19A3A10 VA: 0x1819A5410
	private void GetInnerUVs_Injected(out Vector4 ret) { }

	// RVA: 0x19A54B0 Offset: 0x19A3AB0 VA: 0x1819A54B0
	private void GetOuterUVs_Injected(out Vector4 ret) { }

	// RVA: 0x19A55D0 Offset: 0x19A3BD0 VA: 0x1819A55D0
	private void GetPadding_Injected(out Vector4 ret) { }

	// RVA: 0x19A4B30 Offset: 0x19A3130 VA: 0x1819A4B30
	private static Sprite CreateSprite_Injected(Texture2D texture, ref Rect rect, ref Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, ref Vector4 border, bool generateFallbackPhysicsShape) { }

	// RVA: 0x19A5850 Offset: 0x19A3E50 VA: 0x1819A5850
	private void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x19A5A20 Offset: 0x19A4020 VA: 0x1819A5A20
	private void get_rect_Injected(out Rect ret) { }

	// RVA: 0x19A57B0 Offset: 0x19A3DB0 VA: 0x1819A57B0
	private void get_border_Injected(out Vector4 ret) { }

	// RVA: 0x19A5940 Offset: 0x19A3F40 VA: 0x1819A5940
	private void get_pivot_Injected(out Vector2 ret) { }

}

