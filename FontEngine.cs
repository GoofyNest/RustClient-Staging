public sealed class FontEngine // TypeDefIndex: 4120
{	// Fields
	private static Glyph[] s_Glyphs; // 0x0
	private static uint[] s_GlyphIndexes_MarshallingArray_A; // 0x8
	private static GlyphMarshallingStruct[] s_GlyphMarshallingStruct_IN; // 0x10
	private static GlyphMarshallingStruct[] s_GlyphMarshallingStruct_OUT; // 0x18
	private static GlyphRect[] s_FreeGlyphRects; // 0x20
	private static GlyphRect[] s_UsedGlyphRects; // 0x28
	private static GlyphPairAdjustmentRecord[] s_PairAdjustmentRecords_MarshallingArray; // 0x30
	private static Dictionary<uint, Glyph> s_GlyphLookupDictionary; // 0x38

	// Methods

	// RVA: 0x22EF460 Offset: 0x22EDA60 VA: 0x1822EF460
	public static FontEngineError InitializeFontEngine() { }

	[NativeMethodAttribute] // RVA: 0x8AB50 Offset: 0x89F50 VA: 0x18008AB50
	// RVA: 0x22EF430 Offset: 0x22EDA30 VA: 0x1822EF430
	private static int InitializeFontEngine_Internal() { }

	// RVA: 0x22EF510 Offset: 0x22EDB10 VA: 0x1822EF510
	public static FontEngineError LoadFontFace(Font font, int pointSize) { }

	[NativeMethodAttribute] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	// RVA: 0x22EF4D0 Offset: 0x22EDAD0 VA: 0x1822EF4D0
	private static int LoadFontFace_With_Size_FromFont_Internal(Font font, int pointSize) { }

	// RVA: 0x22EF150 Offset: 0x22ED750 VA: 0x1822EF150
	public static FaceInfo GetFaceInfo() { }

	[NativeMethodAttribute] // RVA: 0x8AC30 Offset: 0x8A030 VA: 0x18008AC30
	// RVA: 0x22EF110 Offset: 0x22ED710 VA: 0x1822EF110
	private static int GetFaceInfo_Internal(ref FaceInfo faceInfo) { }

	[NativeMethodAttribute] // RVA: 0x8AD40 Offset: 0x8A140 VA: 0x18008AD40
	// RVA: 0x22EF240 Offset: 0x22ED840 VA: 0x1822EF240
	internal static uint GetGlyphIndex(uint unicode) { }

	// RVA: 0x22F0C10 Offset: 0x22EF210 VA: 0x1822F0C10
	public static bool TryGetGlyphWithUnicodeValue(uint unicode, GlyphLoadFlags flags, out Glyph glyph) { }

	[NativeMethodAttribute] // RVA: 0x8ADE0 Offset: 0x8A1E0 VA: 0x18008ADE0
	// RVA: 0x22F0BC0 Offset: 0x22EF1C0 VA: 0x1822F0BC0
	private static bool TryGetGlyphWithUnicodeValue_Internal(uint unicode, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct) { }

	// RVA: 0x22F0A50 Offset: 0x22EF050 VA: 0x1822F0A50
	public static bool TryGetGlyphWithIndexValue(uint glyphIndex, GlyphLoadFlags flags, out Glyph glyph) { }

	[NativeMethodAttribute] // RVA: 0x8AED0 Offset: 0x8A2D0 VA: 0x18008AED0
	// RVA: 0x22F0A00 Offset: 0x22EF000 VA: 0x1822F0A00
	private static bool TryGetGlyphWithIndexValue_Internal(uint glyphIndex, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct) { }

	// RVA: 0x22F0DE0 Offset: 0x22EF3E0 VA: 0x1822F0DE0
	internal static bool TryPackGlyphInAtlas(Glyph glyph, int padding, GlyphPackingMode packingMode, GlyphRenderMode renderMode, int width, int height, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects) { }

	[NativeMethodAttribute] // RVA: 0x8AF70 Offset: 0x8A370 VA: 0x18008AF70
	// RVA: 0x22F0D80 Offset: 0x22EF380 VA: 0x1822F0D80
	private static bool TryPackGlyphInAtlas_Internal(ref GlyphMarshallingStruct glyph, int padding, GlyphPackingMode packingMode, GlyphRenderMode renderMode, int width, int height, [Out] GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, [Out] GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount) { }

	// RVA: 0x22EF640 Offset: 0x22EDC40 VA: 0x1822EF640
	internal static FontEngineError RenderGlyphsToTexture(List<Glyph> glyphs, int padding, GlyphRenderMode renderMode, Texture2D texture) { }

	[NativeMethodAttribute] // RVA: 0x8AFE0 Offset: 0x8A3E0 VA: 0x18008AFE0
	// RVA: 0x22EF5E0 Offset: 0x22EDBE0 VA: 0x1822EF5E0
	private static int RenderGlyphsToTexture_Internal(GlyphMarshallingStruct[] glyphs, int glyphCount, int padding, GlyphRenderMode renderMode, Texture2D texture) { }

	// RVA: 0x22EF960 Offset: 0x22EDF60 VA: 0x1822EF960
	internal static bool TryAddGlyphToTexture(uint glyphIndex, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Glyph glyph) { }

	[NativeMethodAttribute] // RVA: 0x8B050 Offset: 0x8A450 VA: 0x18008B050
	// RVA: 0x22EF900 Offset: 0x22EDF00 VA: 0x1822EF900
	private static bool TryAddGlyphToTexture_Internal(uint glyphIndex, int padding, GlyphPackingMode packingMode, [Out] GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, [Out] GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, out GlyphMarshallingStruct glyph) { }

	// RVA: 0x22EFFF0 Offset: 0x22EE5F0 VA: 0x1822EFFF0
	internal static bool TryAddGlyphsToTexture(List<uint> glyphIndexes, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Glyph[] glyphs) { }

	[NativeMethodAttribute] // RVA: 0x8B130 Offset: 0x8A530 VA: 0x18008B130
	// RVA: 0x22EFF80 Offset: 0x22EE580 VA: 0x1822EFF80
	private static bool TryAddGlyphsToTexture_Internal(uint[] glyphIndex, int padding, GlyphPackingMode packingMode, [Out] GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, [Out] GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, [Out] GlyphMarshallingStruct[] glyphs, ref int glyphCount) { }

	// RVA: 0x22EF2C0 Offset: 0x22ED8C0 VA: 0x1822EF2C0
	internal static GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentTable(uint[] glyphIndexes) { }

	[NativeMethodAttribute] // RVA: 0x8B1A0 Offset: 0x8A5A0 VA: 0x18008B1A0
	// RVA: 0x22EF590 Offset: 0x22EDB90 VA: 0x1822EF590
	private static int PopulatePairAdjustmentRecordMarshallingArray_from_GlyphIndexes(uint[] glyphIndexes, out int recordCount) { }

	[NativeMethodAttribute] // RVA: 0x8B250 Offset: 0x8A650 VA: 0x18008B250
	// RVA: 0x22EF280 Offset: 0x22ED880 VA: 0x1822EF280
	private static int GetGlyphPairAdjustmentRecordsFromMarshallingArray([Out] GlyphPairAdjustmentRecord[] glyphPairAdjustmentRecords) { }

	// RVA: -1 Offset: -1
	private static void SetMarshallingArraySize<T>(ref T[] marshallingArray, int recordCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CDDC0 Offset: 0x5CC3C0 VA: 0x1805CDDC0
	|-FontEngine.SetMarshallingArraySize<object>
	|
	|-RVA: 0x5CDCF0 Offset: 0x5CC2F0 VA: 0x1805CDCF0
	|-FontEngine.SetMarshallingArraySize<GlyphPairAdjustmentRecord>
	*/

	[NativeMethodAttribute] // RVA: 0x8B370 Offset: 0x8A770 VA: 0x18008B370
	// RVA: 0x22EF8C0 Offset: 0x22EDEC0 VA: 0x1822EF8C0
	internal static void ResetAtlasTexture(Texture2D texture) { }

	// RVA: 0x22F1370 Offset: 0x22EF970 VA: 0x1822F1370
	private static void .cctor() { }

}

