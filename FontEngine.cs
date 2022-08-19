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

	// RVA: 0x22EEB40 Offset: 0x22ED140 VA: 0x1822EEB40
	public static FontEngineError InitializeFontEngine() { }

	[NativeMethodAttribute] // RVA: 0x8AA90 Offset: 0x89E90 VA: 0x18008AA90
	// RVA: 0x22EEB10 Offset: 0x22ED110 VA: 0x1822EEB10
	private static int InitializeFontEngine_Internal() { }

	// RVA: 0x22EEBF0 Offset: 0x22ED1F0 VA: 0x1822EEBF0
	public static FontEngineError LoadFontFace(Font font, int pointSize) { }

	[NativeMethodAttribute] // RVA: 0x8AB20 Offset: 0x89F20 VA: 0x18008AB20
	// RVA: 0x22EEBB0 Offset: 0x22ED1B0 VA: 0x1822EEBB0
	private static int LoadFontFace_With_Size_FromFont_Internal(Font font, int pointSize) { }

	// RVA: 0x22EE830 Offset: 0x22ECE30 VA: 0x1822EE830
	public static FaceInfo GetFaceInfo() { }

	[NativeMethodAttribute] // RVA: 0x8ABF0 Offset: 0x89FF0 VA: 0x18008ABF0
	// RVA: 0x22EE7F0 Offset: 0x22ECDF0 VA: 0x1822EE7F0
	private static int GetFaceInfo_Internal(ref FaceInfo faceInfo) { }

	[NativeMethodAttribute] // RVA: 0x8AD00 Offset: 0x8A100 VA: 0x18008AD00
	// RVA: 0x22EE920 Offset: 0x22ECF20 VA: 0x1822EE920
	internal static uint GetGlyphIndex(uint unicode) { }

	// RVA: 0x22F02F0 Offset: 0x22EE8F0 VA: 0x1822F02F0
	public static bool TryGetGlyphWithUnicodeValue(uint unicode, GlyphLoadFlags flags, out Glyph glyph) { }

	[NativeMethodAttribute] // RVA: 0x8AD70 Offset: 0x8A170 VA: 0x18008AD70
	// RVA: 0x22F02A0 Offset: 0x22EE8A0 VA: 0x1822F02A0
	private static bool TryGetGlyphWithUnicodeValue_Internal(uint unicode, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct) { }

	// RVA: 0x22F0130 Offset: 0x22EE730 VA: 0x1822F0130
	public static bool TryGetGlyphWithIndexValue(uint glyphIndex, GlyphLoadFlags flags, out Glyph glyph) { }

	[NativeMethodAttribute] // RVA: 0x8AE60 Offset: 0x8A260 VA: 0x18008AE60
	// RVA: 0x22F00E0 Offset: 0x22EE6E0 VA: 0x1822F00E0
	private static bool TryGetGlyphWithIndexValue_Internal(uint glyphIndex, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct) { }

	// RVA: 0x22F04C0 Offset: 0x22EEAC0 VA: 0x1822F04C0
	internal static bool TryPackGlyphInAtlas(Glyph glyph, int padding, GlyphPackingMode packingMode, GlyphRenderMode renderMode, int width, int height, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects) { }

	[NativeMethodAttribute] // RVA: 0x8AF00 Offset: 0x8A300 VA: 0x18008AF00
	// RVA: 0x22F0460 Offset: 0x22EEA60 VA: 0x1822F0460
	private static bool TryPackGlyphInAtlas_Internal(ref GlyphMarshallingStruct glyph, int padding, GlyphPackingMode packingMode, GlyphRenderMode renderMode, int width, int height, [Out] GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, [Out] GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount) { }

	// RVA: 0x22EED20 Offset: 0x22ED320 VA: 0x1822EED20
	internal static FontEngineError RenderGlyphsToTexture(List<Glyph> glyphs, int padding, GlyphRenderMode renderMode, Texture2D texture) { }

	[NativeMethodAttribute] // RVA: 0x8AF70 Offset: 0x8A370 VA: 0x18008AF70
	// RVA: 0x22EECC0 Offset: 0x22ED2C0 VA: 0x1822EECC0
	private static int RenderGlyphsToTexture_Internal(GlyphMarshallingStruct[] glyphs, int glyphCount, int padding, GlyphRenderMode renderMode, Texture2D texture) { }

	// RVA: 0x22EF040 Offset: 0x22ED640 VA: 0x1822EF040
	internal static bool TryAddGlyphToTexture(uint glyphIndex, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Glyph glyph) { }

	[NativeMethodAttribute] // RVA: 0x8AFE0 Offset: 0x8A3E0 VA: 0x18008AFE0
	// RVA: 0x22EEFE0 Offset: 0x22ED5E0 VA: 0x1822EEFE0
	private static bool TryAddGlyphToTexture_Internal(uint glyphIndex, int padding, GlyphPackingMode packingMode, [Out] GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, [Out] GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, out GlyphMarshallingStruct glyph) { }

	// RVA: 0x22EF6D0 Offset: 0x22EDCD0 VA: 0x1822EF6D0
	internal static bool TryAddGlyphsToTexture(List<uint> glyphIndexes, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Glyph[] glyphs) { }

	[NativeMethodAttribute] // RVA: 0x8B050 Offset: 0x8A450 VA: 0x18008B050
	// RVA: 0x22EF660 Offset: 0x22EDC60 VA: 0x1822EF660
	private static bool TryAddGlyphsToTexture_Internal(uint[] glyphIndex, int padding, GlyphPackingMode packingMode, [Out] GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, [Out] GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, [Out] GlyphMarshallingStruct[] glyphs, ref int glyphCount) { }

	// RVA: 0x22EE9A0 Offset: 0x22ECFA0 VA: 0x1822EE9A0
	internal static GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentTable(uint[] glyphIndexes) { }

	[NativeMethodAttribute] // RVA: 0x8B130 Offset: 0x8A530 VA: 0x18008B130
	// RVA: 0x22EEC70 Offset: 0x22ED270 VA: 0x1822EEC70
	private static int PopulatePairAdjustmentRecordMarshallingArray_from_GlyphIndexes(uint[] glyphIndexes, out int recordCount) { }

	[NativeMethodAttribute] // RVA: 0x8B1E0 Offset: 0x8A5E0 VA: 0x18008B1E0
	// RVA: 0x22EE960 Offset: 0x22ECF60 VA: 0x1822EE960
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

	[NativeMethodAttribute] // RVA: 0x8B300 Offset: 0x8A700 VA: 0x18008B300
	// RVA: 0x22EEFA0 Offset: 0x22ED5A0 VA: 0x1822EEFA0
	internal static void ResetAtlasTexture(Texture2D texture) { }

	// RVA: 0x22F0A50 Offset: 0x22EF050 VA: 0x1822F0A50
	private static void .cctor() { }

}

