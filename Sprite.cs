public sealed class Sprite : Object // TypeDefIndex: 3574
{	public Bounds bounds { get; }
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


	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void .ctor() { }

	internal int GetPackingMode() { }

	internal int GetPacked() { }

	internal Rect GetTextureRect() { }

	internal Vector4 GetInnerUVs() { }

	internal Vector4 GetOuterUVs() { }

	internal Vector4 GetPadding() { }

	[FreeFunctionAttribute] // RVA: 0xD23B0 Offset: 0xD17B0 VA: 0x1800D23B0
	internal static Sprite CreateSprite(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape) { }

	public Bounds get_bounds() { }

	public Rect get_rect() { }

	public Vector4 get_border() { }

	public Texture2D get_texture() { }

	[NativeMethodAttribute] // RVA: 0xD2470 Offset: 0xD1870 VA: 0x1800D2470
	public float get_pixelsPerUnit() { }

	[NativeMethodAttribute] // RVA: 0xD2630 Offset: 0xD1A30 VA: 0x1800D2630
	public Texture2D get_associatedAlphaSplitTexture() { }

	[NativeMethodAttribute] // RVA: 0xD2720 Offset: 0xD1B20 VA: 0x1800D2720
	public Vector2 get_pivot() { }

	public bool get_packed() { }

	public SpritePackingMode get_packingMode() { }

	public Rect get_textureRect() { }

	[FreeFunctionAttribute] // RVA: 0xD2810 Offset: 0xD1C10 VA: 0x1800D2810
	public Vector2[] get_vertices() { }

	[FreeFunctionAttribute] // RVA: 0xD2A10 Offset: 0xD1E10 VA: 0x1800D2A10
	public ushort[] get_triangles() { }

	[FreeFunctionAttribute] // RVA: 0xD3E00 Offset: 0xD3200 VA: 0x1800D3E00
	public Vector2[] get_uv() { }

	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape) { }

	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border) { }

	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType) { }

	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude) { }

	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit) { }

	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot) { }

	private void GetTextureRect_Injected(out Rect ret) { }

	private void GetInnerUVs_Injected(out Vector4 ret) { }

	private void GetOuterUVs_Injected(out Vector4 ret) { }

	private void GetPadding_Injected(out Vector4 ret) { }

	private static Sprite CreateSprite_Injected(Texture2D texture, ref Rect rect, ref Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, ref Vector4 border, bool generateFallbackPhysicsShape) { }

	private void get_bounds_Injected(out Bounds ret) { }

	private void get_rect_Injected(out Rect ret) { }

	private void get_border_Injected(out Vector4 ret) { }

	private void get_pivot_Injected(out Vector2 ret) { }

}

