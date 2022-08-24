public sealed class FontEngine // TypeDefIndex: 4120
{	private static Glyph[] s_Glyphs; // 0x0
	private static uint[] s_GlyphIndexes_MarshallingArray_A; // 0x8
	private static GlyphMarshallingStruct[] s_GlyphMarshallingStruct_IN; // 0x10
	private static GlyphMarshallingStruct[] s_GlyphMarshallingStruct_OUT; // 0x18
	private static GlyphRect[] s_FreeGlyphRects; // 0x20
	private static GlyphRect[] s_UsedGlyphRects; // 0x28
	private static GlyphPairAdjustmentRecord[] s_PairAdjustmentRecords_MarshallingArray; // 0x30
	private static Dictionary<uint, Glyph> s_GlyphLookupDictionary; // 0x38


	public static FontEngineError InitializeFontEngine() { }

	[NativeMethodAttribute] // RVA: 0x8AC30 Offset: 0x8A030 VA: 0x18008AC30
	private static int InitializeFontEngine_Internal() { }

	public static FontEngineError LoadFontFace(Font font, int pointSize) { }

	[NativeMethodAttribute] // RVA: 0x8ACA0 Offset: 0x8A0A0 VA: 0x18008ACA0
	private static int LoadFontFace_With_Size_FromFont_Internal(Font font, int pointSize) { }

	public static FaceInfo GetFaceInfo() { }

	[NativeMethodAttribute] // RVA: 0x8AD10 Offset: 0x8A110 VA: 0x18008AD10
	private static int GetFaceInfo_Internal(ref FaceInfo faceInfo) { }

	[NativeMethodAttribute] // RVA: 0x8ADF0 Offset: 0x8A1F0 VA: 0x18008ADF0
	internal static uint GetGlyphIndex(uint unicode) { }

	public static bool TryGetGlyphWithUnicodeValue(uint unicode, GlyphLoadFlags flags, out Glyph glyph) { }

	[NativeMethodAttribute] // RVA: 0x8AE60 Offset: 0x8A260 VA: 0x18008AE60
	private static bool TryGetGlyphWithUnicodeValue_Internal(uint unicode, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct) { }

	public static bool TryGetGlyphWithIndexValue(uint glyphIndex, GlyphLoadFlags flags, out Glyph glyph) { }

	[NativeMethodAttribute] // RVA: 0x8AED0 Offset: 0x8A2D0 VA: 0x18008AED0
	private static bool TryGetGlyphWithIndexValue_Internal(uint glyphIndex, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct) { }

	internal static bool TryPackGlyphInAtlas(Glyph glyph, int padding, GlyphPackingMode packingMode, GlyphRenderMode renderMode, int width, int height, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects) { }

	[NativeMethodAttribute] // RVA: 0x8AF40 Offset: 0x8A340 VA: 0x18008AF40
	private static bool TryPackGlyphInAtlas_Internal(ref GlyphMarshallingStruct glyph, int padding, GlyphPackingMode packingMode, GlyphRenderMode renderMode, int width, int height, [Out] GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, [Out] GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount) { }

	internal static FontEngineError RenderGlyphsToTexture(List<Glyph> glyphs, int padding, GlyphRenderMode renderMode, Texture2D texture) { }

	[NativeMethodAttribute] // RVA: 0x8AFB0 Offset: 0x8A3B0 VA: 0x18008AFB0
	private static int RenderGlyphsToTexture_Internal(GlyphMarshallingStruct[] glyphs, int glyphCount, int padding, GlyphRenderMode renderMode, Texture2D texture) { }

	internal static bool TryAddGlyphToTexture(uint glyphIndex, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Glyph glyph) { }

	[NativeMethodAttribute] // RVA: 0x8B020 Offset: 0x8A420 VA: 0x18008B020
	private static bool TryAddGlyphToTexture_Internal(uint glyphIndex, int padding, GlyphPackingMode packingMode, [Out] GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, [Out] GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, out GlyphMarshallingStruct glyph) { }

	internal static bool TryAddGlyphsToTexture(List<uint> glyphIndexes, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Glyph[] glyphs) { }

	[NativeMethodAttribute] // RVA: 0x8B100 Offset: 0x8A500 VA: 0x18008B100
	private static bool TryAddGlyphsToTexture_Internal(uint[] glyphIndex, int padding, GlyphPackingMode packingMode, [Out] GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, [Out] GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, [Out] GlyphMarshallingStruct[] glyphs, ref int glyphCount) { }

	internal static GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentTable(uint[] glyphIndexes) { }

	[NativeMethodAttribute] // RVA: 0x8B1C0 Offset: 0x8A5C0 VA: 0x18008B1C0
	private static int PopulatePairAdjustmentRecordMarshallingArray_from_GlyphIndexes(uint[] glyphIndexes, out int recordCount) { }

	[NativeMethodAttribute] // RVA: 0x8B270 Offset: 0x8A670 VA: 0x18008B270
	private static int GetGlyphPairAdjustmentRecordsFromMarshallingArray([Out] GlyphPairAdjustmentRecord[] glyphPairAdjustmentRecords) { }

	private static void SetMarshallingArraySize<T>(ref T[] marshallingArray, int recordCount) { }
	/* GenericInstMethod :
	|
	|-FontEngine.SetMarshallingArraySize<object>
	|
	|-FontEngine.SetMarshallingArraySize<GlyphPairAdjustmentRecord>
	*/

	[NativeMethodAttribute] // RVA: 0x8B390 Offset: 0x8A790 VA: 0x18008B390
	internal static void ResetAtlasTexture(Texture2D texture) { }

	private static void .cctor() { }

}

