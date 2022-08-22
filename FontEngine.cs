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

	// RVA: 0x22EEC40 Offset: 0x22ED240 VA: 0x1822EEC40
	public static FontEngineError InitializeFontEngine() { }

	[NativeMethodAttribute] // RVA: 0x8AB50 Offset: 0x89F50 VA: 0x18008AB50
	// RVA: 0x22EEC10 Offset: 0x22ED210 VA: 0x1822EEC10
	private static int InitializeFontEngine_Internal() { }

	// RVA: 0x22EECF0 Offset: 0x22ED2F0 VA: 0x1822EECF0
	public static FontEngineError LoadFontFace(Font font, int pointSize) { }

	[NativeMethodAttribute] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	// RVA: 0x22EECB0 Offset: 0x22ED2B0 VA: 0x1822EECB0
	private static int LoadFontFace_With_Size_FromFont_Internal(Font font, int pointSize) { }

	// RVA: 0x22EE930 Offset: 0x22ECF30 VA: 0x1822EE930
	public static FaceInfo GetFaceInfo() { }

	[NativeMethodAttribute] // RVA: 0x8AC30 Offset: 0x8A030 VA: 0x18008AC30
	// RVA: 0x22EE8F0 Offset: 0x22ECEF0 VA: 0x1822EE8F0
	private static int GetFaceInfo_Internal(ref FaceInfo faceInfo) { }

	[NativeMethodAttribute] // RVA: 0x8AD40 Offset: 0x8A140 VA: 0x18008AD40
	// RVA: 0x22EEA20 Offset: 0x22ED020 VA: 0x1822EEA20
	internal static uint GetGlyphIndex(uint unicode) { }

	// RVA: 0x22F03F0 Offset: 0x22EE9F0 VA: 0x1822F03F0
	public static bool TryGetGlyphWithUnicodeValue(uint unicode, GlyphLoadFlags flags, out Glyph glyph) { }

	[NativeMethodAttribute] // RVA: 0x8ADE0 Offset: 0x8A1E0 VA: 0x18008ADE0
	// RVA: 0x22F03A0 Offset: 0x22EE9A0 VA: 0x1822F03A0
	private static bool TryGetGlyphWithUnicodeValue_Internal(uint unicode, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct) { }

	// RVA: 0x22F0230 Offset: 0x22EE830 VA: 0x1822F0230
	public static bool TryGetGlyphWithIndexValue(uint glyphIndex, GlyphLoadFlags flags, out Glyph glyph) { }

	[NativeMethodAttribute] // RVA: 0x8AED0 Offset: 0x8A2D0 VA: 0x18008AED0
	// RVA: 0x22F01E0 Offset: 0x22EE7E0 VA: 0x1822F01E0
	private static bool TryGetGlyphWithIndexValue_Internal(uint glyphIndex, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct) { }

	// RVA: 0x22F05C0 Offset: 0x22EEBC0 VA: 0x1822F05C0
	internal static bool TryPackGlyphInAtlas(Glyph glyph, int padding, GlyphPackingMode packingMode, GlyphRenderMode renderMode, int width, int height, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects) { }

	[NativeMethodAttribute] // RVA: 0x8AF70 Offset: 0x8A370 VA: 0x18008AF70
	// RVA: 0x22F0560 Offset: 0x22EEB60 VA: 0x1822F0560
	private static bool TryPackGlyphInAtlas_Internal(ref GlyphMarshallingStruct glyph, int padding, GlyphPackingMode packingMode, GlyphRenderMode renderMode, int width, int height, [Out] GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, [Out] GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount) { }

	// RVA: 0x22EEE20 Offset: 0x22ED420 VA: 0x1822EEE20
	internal static FontEngineError RenderGlyphsToTexture(List<Glyph> glyphs, int padding, GlyphRenderMode renderMode, Texture2D texture) { }

	[NativeMethodAttribute] // RVA: 0x8AFE0 Offset: 0x8A3E0 VA: 0x18008AFE0
	// RVA: 0x22EEDC0 Offset: 0x22ED3C0 VA: 0x1822EEDC0
	private static int RenderGlyphsToTexture_Internal(GlyphMarshallingStruct[] glyphs, int glyphCount, int padding, GlyphRenderMode renderMode, Texture2D texture) { }

	// RVA: 0x22EF140 Offset: 0x22ED740 VA: 0x1822EF140
	internal static bool TryAddGlyphToTexture(uint glyphIndex, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Glyph glyph) { }

	[NativeMethodAttribute] // RVA: 0x8B050 Offset: 0x8A450 VA: 0x18008B050
	// RVA: 0x22EF0E0 Offset: 0x22ED6E0 VA: 0x1822EF0E0
	private static bool TryAddGlyphToTexture_Internal(uint glyphIndex, int padding, GlyphPackingMode packingMode, [Out] GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, [Out] GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, out GlyphMarshallingStruct glyph) { }

	// RVA: 0x22EF7D0 Offset: 0x22EDDD0 VA: 0x1822EF7D0
	internal static bool TryAddGlyphsToTexture(List<uint> glyphIndexes, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Glyph[] glyphs) { }

	[NativeMethodAttribute] // RVA: 0x8B130 Offset: 0x8A530 VA: 0x18008B130
	// RVA: 0x22EF760 Offset: 0x22EDD60 VA: 0x1822EF760
	private static bool TryAddGlyphsToTexture_Internal(uint[] glyphIndex, int padding, GlyphPackingMode packingMode, [Out] GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, [Out] GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, [Out] GlyphMarshallingStruct[] glyphs, ref int glyphCount) { }

	// RVA: 0x22EEAA0 Offset: 0x22ED0A0 VA: 0x1822EEAA0
	internal static GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentTable(uint[] glyphIndexes) { }

	[NativeMethodAttribute] // RVA: 0x8B1A0 Offset: 0x8A5A0 VA: 0x18008B1A0
	// RVA: 0x22EED70 Offset: 0x22ED370 VA: 0x1822EED70
	private static int PopulatePairAdjustmentRecordMarshallingArray_from_GlyphIndexes(uint[] glyphIndexes, out int recordCount) { }

	[NativeMethodAttribute] // RVA: 0x8B250 Offset: 0x8A650 VA: 0x18008B250
	// RVA: 0x22EEA60 Offset: 0x22ED060 VA: 0x1822EEA60
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
	// RVA: 0x22EF0A0 Offset: 0x22ED6A0 VA: 0x1822EF0A0
	internal static void ResetAtlasTexture(Texture2D texture) { }

	// RVA: 0x22F0B50 Offset: 0x22EF150 VA: 0x1822F0B50
	private static void .cctor() { }

}

