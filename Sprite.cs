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


	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void .ctor() { }

	internal int GetPackingMode() { }

	internal int GetPacked() { }

	internal Rect GetTextureRect() { }

	internal Vector4 GetInnerUVs() { }

	internal Vector4 GetOuterUVs() { }

	internal Vector4 GetPadding() { }

	[FreeFunctionAttribute] // RVA: 0xD24E0 Offset: 0xD18E0 VA: 0x1800D24E0
	internal static Sprite CreateSprite(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape) { }

	public Bounds get_bounds() { }

	public Rect get_rect() { }

	public Vector4 get_border() { }

	public Texture2D get_texture() { }

	[NativeMethodAttribute] // RVA: 0xD25A0 Offset: 0xD19A0 VA: 0x1800D25A0
	public float get_pixelsPerUnit() { }

	[NativeMethodAttribute] // RVA: 0xD2760 Offset: 0xD1B60 VA: 0x1800D2760
	public Texture2D get_associatedAlphaSplitTexture() { }

	[NativeMethodAttribute] // RVA: 0xD2850 Offset: 0xD1C50 VA: 0x1800D2850
	public Vector2 get_pivot() { }

	public bool get_packed() { }

	public SpritePackingMode get_packingMode() { }

	public Rect get_textureRect() { }

	[FreeFunctionAttribute] // RVA: 0xD2940 Offset: 0xD1D40 VA: 0x1800D2940
	public Vector2[] get_vertices() { }

	[FreeFunctionAttribute] // RVA: 0xD2B40 Offset: 0xD1F40 VA: 0x1800D2B40
	public ushort[] get_triangles() { }

	[FreeFunctionAttribute] // RVA: 0xD3F30 Offset: 0xD3330 VA: 0x1800D3F30
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

