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

	// RVA: 0x22EE980 Offset: 0x22ECF80 VA: 0x1822EE980
	public static FontEngineError InitializeFontEngine() { }

	[NativeMethodAttribute] // RVA: 0x8AB50 Offset: 0x89F50 VA: 0x18008AB50
	// RVA: 0x22EE950 Offset: 0x22ECF50 VA: 0x1822EE950
	private static int InitializeFontEngine_Internal() { }

	// RVA: 0x22EEA30 Offset: 0x22ED030 VA: 0x1822EEA30
	public static FontEngineError LoadFontFace(Font font, int pointSize) { }

	[NativeMethodAttribute] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	// RVA: 0x22EE9F0 Offset: 0x22ECFF0 VA: 0x1822EE9F0
	private static int LoadFontFace_With_Size_FromFont_Internal(Font font, int pointSize) { }

	// RVA: 0x22EE670 Offset: 0x22ECC70 VA: 0x1822EE670
	public static FaceInfo GetFaceInfo() { }

	[NativeMethodAttribute] // RVA: 0x8AC30 Offset: 0x8A030 VA: 0x18008AC30
	// RVA: 0x22EE630 Offset: 0x22ECC30 VA: 0x1822EE630
	private static int GetFaceInfo_Internal(ref FaceInfo faceInfo) { }

	[NativeMethodAttribute] // RVA: 0x8AD40 Offset: 0x8A140 VA: 0x18008AD40
	// RVA: 0x22EE760 Offset: 0x22ECD60 VA: 0x1822EE760
	internal static uint GetGlyphIndex(uint unicode) { }

	// RVA: 0x22F0130 Offset: 0x22EE730 VA: 0x1822F0130
	public static bool TryGetGlyphWithUnicodeValue(uint unicode, GlyphLoadFlags flags, out Glyph glyph) { }

	[NativeMethodAttribute] // RVA: 0x8ADE0 Offset: 0x8A1E0 VA: 0x18008ADE0
	// RVA: 0x22F00E0 Offset: 0x22EE6E0 VA: 0x1822F00E0
	private static bool TryGetGlyphWithUnicodeValue_Internal(uint unicode, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct) { }

	// RVA: 0x22EFF70 Offset: 0x22EE570 VA: 0x1822EFF70
	public static bool TryGetGlyphWithIndexValue(uint glyphIndex, GlyphLoadFlags flags, out Glyph glyph) { }

	[NativeMethodAttribute] // RVA: 0x8AED0 Offset: 0x8A2D0 VA: 0x18008AED0
	// RVA: 0x22EFF20 Offset: 0x22EE520 VA: 0x1822EFF20
	private static bool TryGetGlyphWithIndexValue_Internal(uint glyphIndex, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct) { }

	// RVA: 0x22F0300 Offset: 0x22EE900 VA: 0x1822F0300
	internal static bool TryPackGlyphInAtlas(Glyph glyph, int padding, GlyphPackingMode packingMode, GlyphRenderMode renderMode, int width, int height, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects) { }

	[NativeMethodAttribute] // RVA: 0x8AF70 Offset: 0x8A370 VA: 0x18008AF70
	// RVA: 0x22F02A0 Offset: 0x22EE8A0 VA: 0x1822F02A0
	private static bool TryPackGlyphInAtlas_Internal(ref GlyphMarshallingStruct glyph, int padding, GlyphPackingMode packingMode, GlyphRenderMode renderMode, int width, int height, [Out] GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, [Out] GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount) { }

	// RVA: 0x22EEB60 Offset: 0x22ED160 VA: 0x1822EEB60
	internal static FontEngineError RenderGlyphsToTexture(List<Glyph> glyphs, int padding, GlyphRenderMode renderMode, Texture2D texture) { }

	[NativeMethodAttribute] // RVA: 0x8AFE0 Offset: 0x8A3E0 VA: 0x18008AFE0
	// RVA: 0x22EEB00 Offset: 0x22ED100 VA: 0x1822EEB00
	private static int RenderGlyphsToTexture_Internal(GlyphMarshallingStruct[] glyphs, int glyphCount, int padding, GlyphRenderMode renderMode, Texture2D texture) { }

	// RVA: 0x22EEE80 Offset: 0x22ED480 VA: 0x1822EEE80
	internal static bool TryAddGlyphToTexture(uint glyphIndex, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Glyph glyph) { }

	[NativeMethodAttribute] // RVA: 0x8B050 Offset: 0x8A450 VA: 0x18008B050
	// RVA: 0x22EEE20 Offset: 0x22ED420 VA: 0x1822EEE20
	private static bool TryAddGlyphToTexture_Internal(uint glyphIndex, int padding, GlyphPackingMode packingMode, [Out] GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, [Out] GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, out GlyphMarshallingStruct glyph) { }

	// RVA: 0x22EF510 Offset: 0x22EDB10 VA: 0x1822EF510
	internal static bool TryAddGlyphsToTexture(List<uint> glyphIndexes, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Glyph[] glyphs) { }

	[NativeMethodAttribute] // RVA: 0x8B130 Offset: 0x8A530 VA: 0x18008B130
	// RVA: 0x22EF4A0 Offset: 0x22EDAA0 VA: 0x1822EF4A0
	private static bool TryAddGlyphsToTexture_Internal(uint[] glyphIndex, int padding, GlyphPackingMode packingMode, [Out] GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, [Out] GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, [Out] GlyphMarshallingStruct[] glyphs, ref int glyphCount) { }

	// RVA: 0x22EE7E0 Offset: 0x22ECDE0 VA: 0x1822EE7E0
	internal static GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentTable(uint[] glyphIndexes) { }

	[NativeMethodAttribute] // RVA: 0x8B1A0 Offset: 0x8A5A0 VA: 0x18008B1A0
	// RVA: 0x22EEAB0 Offset: 0x22ED0B0 VA: 0x1822EEAB0
	private static int PopulatePairAdjustmentRecordMarshallingArray_from_GlyphIndexes(uint[] glyphIndexes, out int recordCount) { }

	[NativeMethodAttribute] // RVA: 0x8B250 Offset: 0x8A650 VA: 0x18008B250
	// RVA: 0x22EE7A0 Offset: 0x22ECDA0 VA: 0x1822EE7A0
	private static int GetGlyphPairAdjustmentRecordsFromMarshallingArray([Out] GlyphPairAdjustmentRecord[] glyphPairAdjustmentRecords) { }

	// RVA: -1 Offset: -1
	private static void SetMarshallingArraySize<T>(ref T[] marshallingArray, int recordCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CDE30 Offset: 0x5CC430 VA: 0x1805CDE30
	|-FontEngine.SetMarshallingArraySize<object>
	|
	|-RVA: 0x5CDD60 Offset: 0x5CC360 VA: 0x1805CDD60
	|-FontEngine.SetMarshallingArraySize<GlyphPairAdjustmentRecord>
	*/

	[NativeMethodAttribute] // RVA: 0x8B370 Offset: 0x8A770 VA: 0x18008B370
	// RVA: 0x22EEDE0 Offset: 0x22ED3E0 VA: 0x1822EEDE0
	internal static void ResetAtlasTexture(Texture2D texture) { }

	// RVA: 0x22F0890 Offset: 0x22EEE90 VA: 0x1822F0890
	private static void .cctor() { }

}

