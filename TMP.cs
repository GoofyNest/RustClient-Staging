public class TMP_Asset : ScriptableObject // TypeDefIndex: 6743
{	// Fields
	public int hashCode; // 0x18
	public Material material; // 0x20
	public int materialHashCode; // 0x28

	// Methods

	// RVA: 0x4C3A70 Offset: 0x4C2070 VA: 0x1804C3A70
	public void .ctor() { }

}

public class TMP_Character : TMP_TextElement // TypeDefIndex: 6744
{	// Methods

	// RVA: 0xC6AC10 Offset: 0xC69210 VA: 0x180C6AC10
	public void .ctor() { }

	// RVA: 0xC6AB40 Offset: 0xC69140 VA: 0x180C6AB40
	public void .ctor(uint unicode, Glyph glyph) { }

	// RVA: 0xC6ABB0 Offset: 0xC691B0 VA: 0x180C6ABB0
	internal void .ctor(uint unicode, uint glyphIndex) { }

}

public struct TMP_Vertex // TypeDefIndex: 6745
{	// Fields
	public Vector3 position; // 0x0
	public Vector2 uv; // 0xC
	public Vector2 uv2; // 0x14
	public Vector2 uv4; // 0x1C
	public Color32 color; // 0x24

}

public struct TMP_CharacterInfo // TypeDefIndex: 6746
{	// Fields
	public char character; // 0x0
	public int index; // 0x4
	public int stringLength; // 0x8
	public TMP_TextElementType elementType; // 0xC
	public TMP_TextElement textElement; // 0x10
	public TMP_FontAsset fontAsset; // 0x18
	public Material material; // 0x20
	public int materialReferenceIndex; // 0x28
	public bool isUsingAlternateTypeface; // 0x2C
	public float pointSize; // 0x30
	public int lineNumber; // 0x34
	public int pageNumber; // 0x38
	public int vertexIndex; // 0x3C
	public TMP_Vertex vertex_BL; // 0x40
	public TMP_Vertex vertex_TL; // 0x68
	public TMP_Vertex vertex_TR; // 0x90
	public TMP_Vertex vertex_BR; // 0xB8
	public Vector3 topLeft; // 0xE0
	public Vector3 bottomLeft; // 0xEC
	public Vector3 topRight; // 0xF8
	public Vector3 bottomRight; // 0x104
	public float origin; // 0x110
	public float ascender; // 0x114
	public float baseLine; // 0x118
	public float descender; // 0x11C
	public float xAdvance; // 0x120
	public float aspectRatio; // 0x124
	public float scale; // 0x128
	public Color32 color; // 0x12C
	public Color32 underlineColor; // 0x130
	public Color32 strikethroughColor; // 0x134
	public Color32 highlightColor; // 0x138
	public FontStyles style; // 0x13C
	public bool isVisible; // 0x140

}

public class TMP_ColorGradient : ScriptableObject // TypeDefIndex: 6748
{	// Fields
	public ColorMode colorMode; // 0x18
	public Color topLeft; // 0x1C
	public Color topRight; // 0x2C
	public Color bottomLeft; // 0x3C
	public Color bottomRight; // 0x4C
	private const ColorMode k_DefaultColorMode = 3;
	private static readonly Color k_DefaultColor; // 0x0

	// Methods

	// RVA: 0xC6AC90 Offset: 0xC69290 VA: 0x180C6AC90
	public void .ctor() { }

	// RVA: 0xC6ADC0 Offset: 0xC693C0 VA: 0x180C6ADC0
	public void .ctor(Color color) { }

	// RVA: 0xC6AD50 Offset: 0xC69350 VA: 0x180C6AD50
	public void .ctor(Color color0, Color color1, Color color2, Color color3) { }

	// RVA: 0xC6AC40 Offset: 0xC69240 VA: 0x180C6AC40
	private static void .cctor() { }

}

public static class TMP_DefaultControls // TypeDefIndex: 6757
{	// Fields
	private const float kWidth = 160;
	private const float kThickHeight = 30;
	private const float kThinHeight = 20;
	private static Vector2 s_ThickElementSize; // 0x0
	private static Vector2 s_ThinElementSize; // 0x8
	private static Color s_DefaultSelectableColor; // 0x10
	private static Color s_TextColor; // 0x20

	// Methods

	// RVA: 0xC6BDA0 Offset: 0xC6A3A0 VA: 0x180C6BDA0
	private static GameObject CreateUIElementRoot(string name, Vector2 size) { }

	// RVA: 0xC6BE40 Offset: 0xC6A440 VA: 0x180C6BE40
	private static GameObject CreateUIObject(string name, GameObject parent) { }

	// RVA: 0xC6BF90 Offset: 0xC6A590 VA: 0x180C6BF90
	private static void SetDefaultTextValues(TMP_Text lbl) { }

	// RVA: 0xC6BEF0 Offset: 0xC6A4F0 VA: 0x180C6BEF0
	private static void SetDefaultColorTransitionValues(Selectable slider) { }

	// RVA: 0xC6C110 Offset: 0xC6A710 VA: 0x180C6C110
	private static void SetParentAndAlign(GameObject child, GameObject parent) { }

	// RVA: 0xC6C030 Offset: 0xC6A630 VA: 0x180C6C030
	private static void SetLayerRecursively(GameObject go, int layer) { }

	// RVA: 0xC6B8F0 Offset: 0xC69EF0 VA: 0x180C6B8F0
	public static GameObject CreateScrollbar(TMP_DefaultControls.Resources resources) { }

	// RVA: 0xC6AE10 Offset: 0xC69410 VA: 0x180C6AE10
	public static GameObject CreateButton(TMP_DefaultControls.Resources resources) { }

	// RVA: 0xC6BC50 Offset: 0xC6A250 VA: 0x180C6BC50
	public static GameObject CreateText(TMP_DefaultControls.Resources resources) { }

	// RVA: 0xC6B150 Offset: 0xC69750 VA: 0x180C6B150
	public static GameObject CreateInputField(TMP_DefaultControls.Resources resources) { }

	// RVA: 0xC6C200 Offset: 0xC6A800 VA: 0x180C6C200
	private static void .cctor() { }

}

public struct TMP_DefaultControls.Resources // TypeDefIndex: 6758
{	// Fields
	public Sprite standard; // 0x0
	public Sprite background; // 0x8
	public Sprite inputField; // 0x10
	public Sprite knob; // 0x18
	public Sprite checkmark; // 0x20
	public Sprite dropdown; // 0x28
	public Sprite mask; // 0x30

}

public class TMP_FontAsset : TMP_Asset // TypeDefIndex: 6760
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string m_Version; // 0x30
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal string m_SourceFontFileGUID; // 0x38
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Font m_SourceFontFile; // 0x40
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private AtlasPopulationMode m_AtlasPopulationMode; // 0x48
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private FaceInfo m_FaceInfo; // 0x50
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private List<Glyph> m_GlyphTable; // 0xA8
	private Dictionary<uint, Glyph> m_GlyphLookupDictionary; // 0xB0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private List<TMP_Character> m_CharacterTable; // 0xB8
	private Dictionary<uint, TMP_Character> m_CharacterLookupDictionary; // 0xC0
	private Texture2D m_AtlasTexture; // 0xC8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Texture2D[] m_AtlasTextures; // 0xD0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal int m_AtlasTextureIndex; // 0xD8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private List<GlyphRect> m_UsedGlyphRects; // 0xE0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private List<GlyphRect> m_FreeGlyphRects; // 0xE8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private FaceInfo_Legacy m_fontInfo; // 0xF0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Texture2D atlas; // 0xF8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int m_AtlasWidth; // 0x100
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int m_AtlasHeight; // 0x104
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int m_AtlasPadding; // 0x108
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GlyphRenderMode m_AtlasRenderMode; // 0x10C
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal List<TMP_Glyph> m_glyphInfoList; // 0x110
	[SerializeField] // RVA: 0xCB7A0 Offset: 0xCABA0 VA: 0x1800CB7A0
	[FormerlySerializedAsAttribute] // RVA: 0xCB7A0 Offset: 0xCABA0 VA: 0x1800CB7A0
	internal KerningTable m_KerningTable; // 0x118
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TMP_FontFeatureTable m_FontFeatureTable; // 0x120
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private List<TMP_FontAsset> fallbackFontAssets; // 0x128
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public List<TMP_FontAsset> m_FallbackFontAssetTable; // 0x130
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal FontAssetCreationSettings m_CreationSettings; // 0x138
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TMP_FontWeightPair[] m_FontWeightTable; // 0x190
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TMP_FontWeightPair[] fontWeights; // 0x198
	public float normalStyle; // 0x1A0
	public float normalSpacingOffset; // 0x1A4
	public float boldStyle; // 0x1A8
	public float boldSpacing; // 0x1AC
	public byte italicStyle; // 0x1B0
	public byte tabSize; // 0x1B1
	private byte m_oldTabSize; // 0x1B2
	internal bool m_IsFontAssetLookupTablesDirty; // 0x1B3
	private List<Glyph> m_GlyphsToPack; // 0x1B8
	private List<Glyph> m_GlyphsPacked; // 0x1C0
	private List<Glyph> m_GlyphsToRender; // 0x1C8
	private List<uint> m_GlyphIndexList; // 0x1D0
	private List<TMP_Character> m_CharactersToAdd; // 0x1D8
	internal static uint[] s_GlyphIndexArray; // 0x0
	internal static List<uint> s_MissingCharacterList; // 0x8

	// Properties
	public string version { get; set; }
	public Font sourceFontFile { get; set; }
	public AtlasPopulationMode atlasPopulationMode { get; set; }
	public FaceInfo faceInfo { get; set; }
	public List<Glyph> glyphTable { get; set; }
	public Dictionary<uint, Glyph> glyphLookupTable { get; }
	public List<TMP_Character> characterTable { get; set; }
	public Dictionary<uint, TMP_Character> characterLookupTable { get; }
	public Texture2D atlasTexture { get; }
	public Texture2D[] atlasTextures { get; set; }
	internal List<GlyphRect> usedGlyphRects { get; set; }
	internal List<GlyphRect> freeGlyphRects { get; set; }
	[ObsoleteAttribute] // RVA: 0xCC170 Offset: 0xCB570 VA: 0x1800CC170
	public FaceInfo_Legacy fontInfo { get; }
	public int atlasWidth { get; set; }
	public int atlasHeight { get; set; }
	public int atlasPadding { get; set; }
	public GlyphRenderMode atlasRenderMode { get; set; }
	public TMP_FontFeatureTable fontFeatureTable { get; set; }
	public List<TMP_FontAsset> fallbackFontAssetTable { get; set; }
	public FontAssetCreationSettings creationSettings { get; set; }
	public TMP_FontWeightPair[] fontWeightTable { get; set; }

	// Methods

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public string get_version() { }

	// RVA: 0x4A6010 Offset: 0x4A4610 VA: 0x1804A6010
	internal void set_version(string value) { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	public Font get_sourceFontFile() { }

	// RVA: 0x4BC5A0 Offset: 0x4BABA0 VA: 0x1804BC5A0
	internal void set_sourceFontFile(Font value) { }

	// RVA: 0x5983B0 Offset: 0x5969B0 VA: 0x1805983B0
	public AtlasPopulationMode get_atlasPopulationMode() { }

	// RVA: 0x5983C0 Offset: 0x5969C0 VA: 0x1805983C0
	public void set_atlasPopulationMode(AtlasPopulationMode value) { }

	// RVA: 0xC742A0 Offset: 0xC728A0 VA: 0x180C742A0
	public FaceInfo get_faceInfo() { }

	// RVA: 0xC743A0 Offset: 0xC729A0 VA: 0x180C743A0
	internal void set_faceInfo(FaceInfo value) { }

	// RVA: 0x79BDE0 Offset: 0x79A3E0 VA: 0x18079BDE0
	public List<Glyph> get_glyphTable() { }

	// RVA: 0x79BE60 Offset: 0x79A460 VA: 0x18079BE60
	internal void set_glyphTable(List<Glyph> value) { }

	// RVA: 0xC74300 Offset: 0xC72900 VA: 0x180C74300
	public Dictionary<uint, Glyph> get_glyphLookupTable() { }

	// RVA: 0x79BDD0 Offset: 0x79A3D0 VA: 0x18079BDD0
	public List<TMP_Character> get_characterTable() { }

	// RVA: 0x79BE50 Offset: 0x79A450 VA: 0x18079BE50
	internal void set_characterTable(List<TMP_Character> value) { }

	// RVA: 0xC74220 Offset: 0xC72820 VA: 0x180C74220
	public Dictionary<uint, TMP_Character> get_characterLookupTable() { }

	// RVA: 0xC74150 Offset: 0xC72750 VA: 0x180C74150
	public Texture2D get_atlasTexture() { }

	// RVA: 0x79BDF0 Offset: 0x79A3F0 VA: 0x18079BDF0
	public Texture2D[] get_atlasTextures() { }

	// RVA: 0x79BE70 Offset: 0x79A470 VA: 0x18079BE70
	public void set_atlasTextures(Texture2D[] value) { }

	// RVA: 0x4EF330 Offset: 0x4ED930 VA: 0x1804EF330
	internal List<GlyphRect> get_usedGlyphRects() { }

	// RVA: 0x4EF340 Offset: 0x4ED940 VA: 0x1804EF340
	internal void set_usedGlyphRects(List<GlyphRect> value) { }

	// RVA: 0x88D970 Offset: 0x88BF70 VA: 0x18088D970
	internal List<GlyphRect> get_freeGlyphRects() { }

	// RVA: 0x88D9F0 Offset: 0x88BFF0 VA: 0x18088D9F0
	internal void set_freeGlyphRects(List<GlyphRect> value) { }

	// RVA: 0xC742E0 Offset: 0xC728E0 VA: 0x180C742E0
	public FaceInfo_Legacy get_fontInfo() { }

	// RVA: 0xC74210 Offset: 0xC72810 VA: 0x180C74210
	public int get_atlasWidth() { }

	// RVA: 0xC74350 Offset: 0xC72950 VA: 0x180C74350
	internal void set_atlasWidth(int value) { }

	// RVA: 0xC74130 Offset: 0xC72730 VA: 0x180C74130
	public int get_atlasHeight() { }

	// RVA: 0xC74330 Offset: 0xC72930 VA: 0x180C74330
	internal void set_atlasHeight(int value) { }

	// RVA: 0x88D820 Offset: 0x88BE20 VA: 0x18088D820
	public int get_atlasPadding() { }

	// RVA: 0x88D9C0 Offset: 0x88BFC0 VA: 0x18088D9C0
	internal void set_atlasPadding(int value) { }

	// RVA: 0xC74140 Offset: 0xC72740 VA: 0x180C74140
	public GlyphRenderMode get_atlasRenderMode() { }

	// RVA: 0xC74340 Offset: 0xC72940 VA: 0x180C74340
	internal void set_atlasRenderMode(GlyphRenderMode value) { }

	// RVA: 0x7A9690 Offset: 0x7A7C90 VA: 0x1807A9690
	public TMP_FontFeatureTable get_fontFeatureTable() { }

	// RVA: 0xC743E0 Offset: 0xC729E0 VA: 0x180C743E0
	internal void set_fontFeatureTable(TMP_FontFeatureTable value) { }

	// RVA: 0x701870 Offset: 0x6FFE70 VA: 0x180701870
	public List<TMP_FontAsset> get_fallbackFontAssetTable() { }

	// RVA: 0x701900 Offset: 0x6FFF00 VA: 0x180701900
	public void set_fallbackFontAssetTable(List<TMP_FontAsset> value) { }

	// RVA: 0xC74250 Offset: 0xC72850 VA: 0x180C74250
	public FontAssetCreationSettings get_creationSettings() { }

	// RVA: 0xC74360 Offset: 0xC72960 VA: 0x180C74360
	public void set_creationSettings(FontAssetCreationSettings value) { }

	// RVA: 0xC742F0 Offset: 0xC728F0 VA: 0x180C742F0
	public TMP_FontWeightPair[] get_fontWeightTable() { }

	// RVA: 0xC743F0 Offset: 0xC729F0 VA: 0x180C743F0
	internal void set_fontWeightTable(TMP_FontWeightPair[] value) { }

	// RVA: 0xC6E360 Offset: 0xC6C960 VA: 0x180C6E360
	public static TMP_FontAsset CreateFontAsset(Font font) { }

	// RVA: 0xC6E3E0 Offset: 0xC6C9E0 VA: 0x180C6E3E0
	public static TMP_FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = 1) { }

	// RVA: 0xC6DC50 Offset: 0xC6C250 VA: 0x180C6DC50
	private void Awake() { }

	// RVA: 0xC6F590 Offset: 0xC6DB90 VA: 0x180C6F590
	internal void InitializeDictionaryLookupTables() { }

	// RVA: 0xC6F9D0 Offset: 0xC6DFD0 VA: 0x180C6F9D0
	public void ReadFontAssetDefinition() { }

	// RVA: 0xC703C0 Offset: 0xC6E9C0 VA: 0x180C703C0
	internal void SortCharacterTable() { }

	// RVA: 0xC70750 Offset: 0xC6ED50 VA: 0x180C70750
	internal void SortGlyphTable() { }

	// RVA: 0xC70500 Offset: 0xC6EB00 VA: 0x180C70500
	internal void SortGlyphAndCharacterTables() { }

	// RVA: 0xC6F340 Offset: 0xC6D940 VA: 0x180C6F340
	public bool HasCharacter(int character) { }

	// RVA: 0xC6EEC0 Offset: 0xC6D4C0 VA: 0x180C6EEC0
	public bool HasCharacter(char character) { }

	// RVA: 0xC6EF30 Offset: 0xC6D530 VA: 0x180C6EF30
	public bool HasCharacter(char character, bool searchFallbacks) { }

	// RVA: 0xC6ED40 Offset: 0xC6D340 VA: 0x180C6ED40
	private bool HasCharacter_Internal(char character, bool searchFallbacks) { }

	// RVA: 0xC6F460 Offset: 0xC6DA60 VA: 0x180C6F460
	public bool HasCharacters(string text, out List<char> missingCharacters) { }

	// RVA: 0xC6F3B0 Offset: 0xC6D9B0 VA: 0x180C6F3B0
	public bool HasCharacters(string text) { }

	// RVA: 0xC6EBB0 Offset: 0xC6D1B0 VA: 0x180C6EBB0
	public static string GetCharacters(TMP_FontAsset fontAsset) { }

	// RVA: 0xC6EAC0 Offset: 0xC6D0C0 VA: 0x180C6EAC0
	public static int[] GetCharactersArray(TMP_FontAsset fontAsset) { }

	// RVA: 0xC71500 Offset: 0xC6FB00 VA: 0x180C71500
	public bool TryAddCharacters(uint[] unicodes) { }

	// RVA: 0xC71520 Offset: 0xC6FB20 VA: 0x180C71520
	public bool TryAddCharacters(uint[] unicodes, out uint[] missingUnicodes) { }

	// RVA: 0xC714E0 Offset: 0xC6FAE0 VA: 0x180C714E0
	public bool TryAddCharacters(string characters) { }

	// RVA: 0xC71D60 Offset: 0xC70360 VA: 0x180C71D60
	public bool TryAddCharacters(string characters, out string missingCharacters) { }

	// RVA: 0xC710D0 Offset: 0xC6F6D0 VA: 0x180C710D0
	internal bool TryAddCharacter_Internal(uint unicode) { }

	// RVA: 0xC6D850 Offset: 0xC6BE50 VA: 0x180C6D850
	internal TMP_Character AddCharacter_Internal(uint unicode, Glyph glyph) { }

	// RVA: 0xC70890 Offset: 0xC6EE90 VA: 0x180C70890
	internal bool TryAddCharacterInternal(uint unicode, out TMP_Character character) { }

	// RVA: 0xC6EC80 Offset: 0xC6D280 VA: 0x180C6EC80
	internal uint GetGlyphIndex(uint unicode) { }

	// RVA: 0xC724E0 Offset: 0xC70AE0 VA: 0x180C724E0
	internal void UpdateAtlasTexture() { }

	// RVA: 0xC72890 Offset: 0xC70E90 VA: 0x180C72890
	internal void UpdateGlyphAdjustmentRecords(uint unicode, uint glyphIndex) { }

	// RVA: 0xC6DCD0 Offset: 0xC6C2D0 VA: 0x180C6DCD0
	public void ClearFontAssetData(bool setAtlasSizeToZero = False) { }

	// RVA: 0xC72D40 Offset: 0xC71340 VA: 0x180C72D40
	private void UpgradeFontAsset() { }

	// RVA: 0xC73A80 Offset: 0xC72080 VA: 0x180C73A80
	private void UpgradeGlyphAdjustmentTableToFontFeatureTable() { }

	// RVA: 0xC73EB0 Offset: 0xC724B0 VA: 0x180C73EB0
	public void .ctor() { }

	// RVA: 0xC73E20 Offset: 0xC72420 VA: 0x180C73E20
	private static void .cctor() { }

}

private sealed class TMP_FontAsset.<>c // TypeDefIndex: 6761
{	// Fields
	public static readonly TMP_FontAsset.<>c <>9; // 0x0
	public static Func<TMP_Character, uint> <>9__100_0; // 0x8
	public static Func<Glyph, uint> <>9__101_0; // 0x10

	// Methods

	// RVA: 0xC855D0 Offset: 0xC83BD0 VA: 0x180C855D0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x970F70 Offset: 0x96F570 VA: 0x180970F70
	internal uint <SortCharacterTable>b__100_0(TMP_Character c) { }

	// RVA: 0xC85540 Offset: 0xC83B40 VA: 0x180C85540
	internal uint <SortGlyphTable>b__101_0(Glyph c) { }

}

public class TMP_Glyph : TMP_TextElement_Legacy // TypeDefIndex: 6763
{	// Methods

	// RVA: 0xC750C0 Offset: 0xC736C0 VA: 0x180C750C0
	public static TMP_Glyph Clone(TMP_Glyph source) { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

}

public struct TMP_FontWeightPair // TypeDefIndex: 6765
{	// Fields
	public TMP_FontAsset regularTypeface; // 0x0
	public TMP_FontAsset italicTypeface; // 0x8

}

public static class TMP_FontUtilities // TypeDefIndex: 6774
{	// Fields
	private static List<int> k_searchedFontAssets; // 0x3550

	// Methods

	// RVA: 0xC74B90 Offset: 0xC73190 VA: 0x180C74B90
	public static TMP_FontAsset SearchForCharacter(TMP_FontAsset font, uint unicode, out TMP_Character character) { }

	// RVA: 0xC74C60 Offset: 0xC73260 VA: 0x180C74C60
	public static TMP_FontAsset SearchForCharacter(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character) { }

	// RVA: 0xC74940 Offset: 0xC72F40 VA: 0x180C74940
	private static TMP_FontAsset SearchForCharacterInternal(TMP_FontAsset font, uint unicode, out TMP_Character character) { }

	// RVA: 0xC74850 Offset: 0xC72E50 VA: 0x180C74850
	private static TMP_FontAsset SearchForCharacterInternal(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character) { }

}

public class TMP_FontAssetUtilities // TypeDefIndex: 6775
{	// Fields
	private static readonly TMP_FontAssetUtilities s_Instance; // 0x0
	private static List<int> k_SearchedFontAssets; // 0x8
	private static bool k_IsFontEngineInitialized; // 0x10

	// Properties
	public static TMP_FontAssetUtilities instance { get; }

	// Methods

	// RVA: 0xC6D790 Offset: 0xC6BD90 VA: 0x180C6D790
	private static void .cctor() { }

	// RVA: 0xC6D7F0 Offset: 0xC6BDF0 VA: 0x180C6D7F0
	public static TMP_FontAssetUtilities get_instance() { }

	// RVA: 0xC6C810 Offset: 0xC6AE10 VA: 0x180C6C810
	public static TMP_Character GetCharacterFromFontAsset(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface, out TMP_FontAsset fontAsset) { }

	// RVA: 0xC6C350 Offset: 0xC6A950 VA: 0x180C6C350
	private static TMP_Character GetCharacterFromFontAsset_Internal(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface, out TMP_FontAsset fontAsset) { }

	// RVA: 0xC6C990 Offset: 0xC6AF90 VA: 0x180C6C990
	public static TMP_Character GetCharacterFromFontAssets(uint unicode, List<TMP_FontAsset> fontAssets, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface, out TMP_FontAsset fontAsset) { }

	// RVA: 0xC6CC10 Offset: 0xC6B210 VA: 0x180C6CC10
	private static bool TryGetCharacterFromFontFile(uint unicode, TMP_FontAsset fontAsset, out TMP_Character character) { }

	// RVA: 0xC6D5B0 Offset: 0xC6BBB0 VA: 0x180C6D5B0
	public static bool TryGetGlyphFromFontFile(uint glyphIndex, TMP_FontAsset fontAsset, out Glyph glyph) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class TMP_FontFeatureTable // TypeDefIndex: 6776
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal List<TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords; // 0x10
	internal Dictionary<long, TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookupDictionary; // 0x18

	// Properties
	internal List<TMP_GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords { get; set; }

	// Methods

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	internal List<TMP_GlyphPairAdjustmentRecord> get_glyphPairAdjustmentRecords() { }

	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	internal void set_glyphPairAdjustmentRecords(List<TMP_GlyphPairAdjustmentRecord> value) { }

	// RVA: 0xC74600 Offset: 0xC72C00 VA: 0x180C74600
	public void .ctor() { }

	// RVA: 0xC74400 Offset: 0xC72A00 VA: 0x180C74400
	public void SortGlyphPairAdjustmentRecords() { }

}

private sealed class TMP_FontFeatureTable.<>c // TypeDefIndex: 6777
{	// Fields
	public static readonly TMP_FontFeatureTable.<>c <>9; // 0x0
	public static Func<TMP_GlyphPairAdjustmentRecord, uint> <>9__6_0; // 0x8
	public static Func<TMP_GlyphPairAdjustmentRecord, uint> <>9__6_1; // 0x10

	// Methods

	// RVA: 0xC85690 Offset: 0xC83C90 VA: 0x180C85690
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xC85500 Offset: 0xC83B00 VA: 0x180C85500
	internal uint <SortGlyphPairAdjustmentRecords>b__6_0(TMP_GlyphPairAdjustmentRecord s) { }

	// RVA: 0xC85520 Offset: 0xC83B20 VA: 0x180C85520
	internal uint <SortGlyphPairAdjustmentRecords>b__6_1(TMP_GlyphPairAdjustmentRecord s) { }

}

public struct TMP_GlyphValueRecord // TypeDefIndex: 6779
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_XPlacement; // 0x0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_YPlacement; // 0x4
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_XAdvance; // 0x8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_YAdvance; // 0xC

	// Properties
	public float xPlacement { get; set; }
	public float yPlacement { get; set; }
	public float xAdvance { get; set; }
	public float yAdvance { get; set; }

	// Methods

	// RVA: 0xF2380 Offset: 0xF1780 VA: 0x1800F2380
	public float get_xPlacement() { }

	// RVA: 0xF2390 Offset: 0xF1790 VA: 0x1800F2390
	public void set_xPlacement(float value) { }

	// RVA: 0x117910 Offset: 0x116D10 VA: 0x180117910
	public float get_yPlacement() { }

	// RVA: 0x117920 Offset: 0x116D20 VA: 0x180117920
	public void set_yPlacement(float value) { }

	// RVA: 0x117100 Offset: 0x116500 VA: 0x180117100
	public float get_xAdvance() { }

	// RVA: 0x117140 Offset: 0x116540 VA: 0x180117140
	public void set_xAdvance(float value) { }

	// RVA: 0x117110 Offset: 0x116510 VA: 0x180117110
	public float get_yAdvance() { }

	// RVA: 0x117150 Offset: 0x116550 VA: 0x180117150
	public void set_yAdvance(float value) { }

	// RVA: 0xF2AC0 Offset: 0xF1EC0 VA: 0x1800F2AC0
	public void .ctor(float xPlacement, float yPlacement, float xAdvance, float yAdvance) { }

	// RVA: 0x1178E0 Offset: 0x116CE0 VA: 0x1801178E0
	internal void .ctor(GlyphValueRecord_Legacy valueRecord) { }

	// RVA: 0x1174D0 Offset: 0x1168D0 VA: 0x1801174D0
	internal void .ctor(GlyphValueRecord valueRecord) { }

	// RVA: 0xC750A0 Offset: 0xC736A0 VA: 0x180C750A0
	public static TMP_GlyphValueRecord op_Addition(TMP_GlyphValueRecord a, TMP_GlyphValueRecord b) { }

}

public struct TMP_GlyphAdjustmentRecord // TypeDefIndex: 6780
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private uint m_GlyphIndex; // 0x0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TMP_GlyphValueRecord m_GlyphValueRecord; // 0x4

	// Properties
	public uint glyphIndex { get; set; }
	public TMP_GlyphValueRecord glyphValueRecord { get; set; }

	// Methods

	// RVA: 0xF3720 Offset: 0xF2B20 VA: 0x1800F3720
	public uint get_glyphIndex() { }

	// RVA: 0xF3850 Offset: 0xF2C50 VA: 0x1800F3850
	public void set_glyphIndex(uint value) { }

	// RVA: 0x1178C0 Offset: 0x116CC0 VA: 0x1801178C0
	public TMP_GlyphValueRecord get_glyphValueRecord() { }

	// RVA: 0x1178D0 Offset: 0x116CD0 VA: 0x1801178D0
	public void set_glyphValueRecord(TMP_GlyphValueRecord value) { }

	// RVA: 0x117880 Offset: 0x116C80 VA: 0x180117880
	public void .ctor(uint glyphIndex, TMP_GlyphValueRecord glyphValueRecord) { }

	// RVA: 0x117890 Offset: 0x116C90 VA: 0x180117890
	internal void .ctor(GlyphAdjustmentRecord adjustmentRecord) { }

}

public class TMP_GlyphPairAdjustmentRecord // TypeDefIndex: 6781
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TMP_GlyphAdjustmentRecord m_FirstAdjustmentRecord; // 0x10
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TMP_GlyphAdjustmentRecord m_SecondAdjustmentRecord; // 0x24
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private FontFeatureLookupFlags m_FeatureLookupFlags; // 0x38

	// Properties
	public TMP_GlyphAdjustmentRecord firstAdjustmentRecord { get; set; }
	public TMP_GlyphAdjustmentRecord secondAdjustmentRecord { get; set; }
	public FontFeatureLookupFlags featureLookupFlags { get; set; }

	// Methods

	// RVA: 0xC75030 Offset: 0xC73630 VA: 0x180C75030
	public TMP_GlyphAdjustmentRecord get_firstAdjustmentRecord() { }

	// RVA: 0xC75080 Offset: 0xC73680 VA: 0x180C75080
	public void set_firstAdjustmentRecord(TMP_GlyphAdjustmentRecord value) { }

	// RVA: 0xC75050 Offset: 0xC73650 VA: 0x180C75050
	public TMP_GlyphAdjustmentRecord get_secondAdjustmentRecord() { }

	// RVA: 0xC75090 Offset: 0xC73690 VA: 0x180C75090
	public void set_secondAdjustmentRecord(TMP_GlyphAdjustmentRecord value) { }

	// RVA: 0x6BB9E0 Offset: 0x6B9FE0 VA: 0x1806BB9E0
	public FontFeatureLookupFlags get_featureLookupFlags() { }

	// RVA: 0xC75070 Offset: 0xC73670 VA: 0x180C75070
	public void set_featureLookupFlags(FontFeatureLookupFlags value) { }

	// RVA: 0xC74E20 Offset: 0xC73420 VA: 0x180C74E20
	public void .ctor(TMP_GlyphAdjustmentRecord firstAdjustmentRecord, TMP_GlyphAdjustmentRecord secondAdjustmentRecord) { }

	// RVA: 0xC74E70 Offset: 0xC73470 VA: 0x180C74E70
	internal void .ctor(GlyphPairAdjustmentRecord glyphPairAdjustmentRecord) { }

}

public class TMP_InputField : Selectable, IUpdateSelectedHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement, IScrollHandler // TypeDefIndex: 6783
{	// Fields
	protected TouchScreenKeyboard m_SoftKeyboard; // 0xE8
	private static readonly char[] kSeparators; // 0x0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected RectTransform m_TextViewport; // 0xF0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected TMP_Text m_TextComponent; // 0xF8
	protected RectTransform m_TextComponentRectTransform; // 0x100
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected Graphic m_Placeholder; // 0x108
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected Scrollbar m_VerticalScrollbar; // 0x110
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected TMP_ScrollbarEventHandler m_VerticalScrollbarEventHandler; // 0x118
	private bool m_IsDrivenByLayoutComponents; // 0x120
	private float m_ScrollPosition; // 0x124
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected float m_ScrollSensitivity; // 0x128
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TMP_InputField.ContentType m_ContentType; // 0x12C
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TMP_InputField.InputType m_InputType; // 0x130
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private char m_AsteriskChar; // 0x134
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TouchScreenKeyboardType m_KeyboardType; // 0x138
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TMP_InputField.LineType m_LineType; // 0x13C
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_HideMobileInput; // 0x140
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_HideSoftKeyboard; // 0x141
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TMP_InputField.CharacterValidation m_CharacterValidation; // 0x144
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string m_RegexValue; // 0x148
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_GlobalPointSize; // 0x150
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int m_CharacterLimit; // 0x154
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TMP_InputField.SubmitEvent m_OnEndEdit; // 0x158
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TMP_InputField.SubmitEvent m_OnSubmit; // 0x160
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TMP_InputField.SelectionEvent m_OnSelect; // 0x168
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TMP_InputField.SelectionEvent m_OnDeselect; // 0x170
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TMP_InputField.TextSelectionEvent m_OnTextSelection; // 0x178
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TMP_InputField.TextSelectionEvent m_OnEndTextSelection; // 0x180
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TMP_InputField.OnChangeEvent m_OnValueChanged; // 0x188
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TMP_InputField.TouchScreenKeyboardEvent m_OnTouchScreenKeyboardStatusChanged; // 0x190
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TMP_InputField.OnValidateInput m_OnValidateInput; // 0x198
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Color m_CaretColor; // 0x1A0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_CustomCaretColor; // 0x1B0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Color m_SelectionColor; // 0x1B4
	[SerializeField] // RVA: 0xD0860 Offset: 0xCFC60 VA: 0x1800D0860
	[TextAreaAttribute] // RVA: 0xD0860 Offset: 0xCFC60 VA: 0x1800D0860
	protected string m_Text; // 0x1C8
	[SerializeField] // RVA: 0xD08E0 Offset: 0xCFCE0 VA: 0x1800D08E0
	[RangeAttribute] // RVA: 0xD08E0 Offset: 0xCFCE0 VA: 0x1800D08E0
	private float m_CaretBlinkRate; // 0x1D0
	[SerializeField] // RVA: 0xD09B0 Offset: 0xCFDB0 VA: 0x1800D09B0
	[RangeAttribute] // RVA: 0xD09B0 Offset: 0xCFDB0 VA: 0x1800D09B0
	private int m_CaretWidth; // 0x1D4
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_ReadOnly; // 0x1D8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_RichText; // 0x1D9
	protected int m_StringPosition; // 0x1DC
	protected int m_StringSelectPosition; // 0x1E0
	protected int m_CaretPosition; // 0x1E4
	protected int m_CaretSelectPosition; // 0x1E8
	private RectTransform caretRectTrans; // 0x1F0
	protected UIVertex[] m_CursorVerts; // 0x1F8
	private CanvasRenderer m_CachedInputRenderer; // 0x200
	private Vector2 m_LastPosition; // 0x208
	protected Mesh m_Mesh; // 0x210
	private bool m_AllowInput; // 0x218
	private bool m_ShouldActivateNextUpdate; // 0x219
	private bool m_UpdateDrag; // 0x21A
	private bool m_DragPositionOutOfBounds; // 0x21B
	private const float kHScrollSpeed = 0,05;
	private const float kVScrollSpeed = 0,1;
	protected bool m_CaretVisible; // 0x21C
	private Coroutine m_BlinkCoroutine; // 0x220
	private float m_BlinkStartTime; // 0x228
	private Coroutine m_DragCoroutine; // 0x230
	private string m_OriginalText; // 0x238
	private bool m_WasCanceled; // 0x240
	private bool m_HasDoneFocusTransition; // 0x241
	private WaitForSecondsRealtime m_WaitForSecondsRealtime; // 0x248
	private bool m_PreventCallback; // 0x250
	private bool m_TouchKeyboardAllowsInPlaceEditing; // 0x251
	private bool m_IsTextComponentUpdateRequired; // 0x252
	private bool m_IsScrollbarUpdateRequired; // 0x253
	private bool m_IsUpdatingScrollbarValues; // 0x254
	private bool m_isLastKeyBackspace; // 0x255
	private float m_PointerDownClickStartTime; // 0x258
	private float m_KeyDownStartTime; // 0x25C
	private float m_DoubleClickDelay; // 0x260
	private const string kEmailSpecialCharacters = "!#$%&\'*+-/=?^_`{|}~";
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected TMP_FontAsset m_GlobalFontAsset; // 0x268
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected bool m_OnFocusSelectAll; // 0x270
	protected bool m_isSelectAll; // 0x271
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected bool m_ResetOnDeActivation; // 0x272
	private bool m_SelectionStillActive; // 0x273
	private bool m_ReleaseSelection; // 0x274
	private GameObject m_SelectedObject; // 0x278
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_RestoreOriginalTextOnEscape; // 0x280
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected bool m_isRichTextEditingAllowed; // 0x281
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected int m_LineLimit; // 0x284
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected TMP_InputValidator m_InputValidator; // 0x288
	private bool m_isSelected; // 0x290
	private bool m_IsStringPositionDirty; // 0x291
	private bool m_IsCaretPositionDirty; // 0x292
	private bool m_forceRectTransformAdjustment; // 0x293
	private Event m_ProcessingEvent; // 0x298

	// Properties
	private BaseInput inputSystem { get; }
	private string compositionString { get; }
	protected Mesh mesh { get; }
	public bool shouldHideMobileInput { get; set; }
	public bool shouldHideSoftKeyboard { get; set; }
	public string text { get; set; }
	public bool isFocused { get; }
	public float caretBlinkRate { get; set; }
	public int caretWidth { get; set; }
	public RectTransform textViewport { get; set; }
	public TMP_Text textComponent { get; set; }
	public Graphic placeholder { get; set; }
	public Scrollbar verticalScrollbar { get; set; }
	public float scrollSensitivity { get; set; }
	public Color caretColor { get; set; }
	public bool customCaretColor { get; set; }
	public Color selectionColor { get; set; }
	public TMP_InputField.SubmitEvent onEndEdit { get; set; }
	public TMP_InputField.SubmitEvent onSubmit { get; set; }
	public TMP_InputField.SelectionEvent onSelect { get; set; }
	public TMP_InputField.SelectionEvent onDeselect { get; set; }
	public TMP_InputField.TextSelectionEvent onTextSelection { get; set; }
	public TMP_InputField.TextSelectionEvent onEndTextSelection { get; set; }
	public TMP_InputField.OnChangeEvent onValueChanged { get; set; }
	public TMP_InputField.TouchScreenKeyboardEvent onTouchScreenKeyboardStatusChanged { get; set; }
	public TMP_InputField.OnValidateInput onValidateInput { get; set; }
	public int characterLimit { get; set; }
	public float pointSize { get; set; }
	public TMP_FontAsset fontAsset { get; set; }
	public bool onFocusSelectAll { get; set; }
	public bool resetOnDeActivation { get; set; }
	public bool restoreOriginalTextOnEscape { get; set; }
	public bool isRichTextEditingAllowed { get; set; }
	public TMP_InputField.ContentType contentType { get; set; }
	public TMP_InputField.LineType lineType { get; set; }
	public int lineLimit { get; set; }
	public TMP_InputField.InputType inputType { get; set; }
	public TouchScreenKeyboardType keyboardType { get; set; }
	public TMP_InputField.CharacterValidation characterValidation { get; set; }
	public TMP_InputValidator inputValidator { get; set; }
	public bool readOnly { get; set; }
	public bool richText { get; set; }
	public bool multiLine { get; }
	public char asteriskChar { get; set; }
	public bool wasCanceled { get; }
	protected int caretPositionInternal { get; set; }
	protected int stringPositionInternal { get; set; }
	protected int caretSelectPositionInternal { get; set; }
	protected int stringSelectPositionInternal { get; set; }
	private bool hasSelection { get; }
	public int caretPosition { get; set; }
	public int selectionAnchorPosition { get; set; }
	public int selectionFocusPosition { get; set; }
	public int stringPosition { get; set; }
	public int selectionStringAnchorPosition { get; set; }
	public int selectionStringFocusPosition { get; set; }
	private static string clipboard { get; set; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }

	// Methods

	// RVA: 0xC83680 Offset: 0xC81C80 VA: 0x180C83680
	private BaseInput get_inputSystem() { }

	// RVA: 0xC83520 Offset: 0xC81B20 VA: 0x180C83520
	private string get_compositionString() { }

	// RVA: 0xC830E0 Offset: 0xC816E0 VA: 0x180C830E0
	protected void .ctor() { }

	// RVA: 0xC83800 Offset: 0xC81E00 VA: 0x180C83800
	protected Mesh get_mesh() { }

	// RVA: 0xC83B40 Offset: 0xC82140 VA: 0x180C83B40
	public bool get_shouldHideMobileInput() { }

	// RVA: 0xC84FC0 Offset: 0xC835C0 VA: 0x180C84FC0
	public void set_shouldHideMobileInput(bool value) { }

	// RVA: 0xC83B70 Offset: 0xC82170 VA: 0x180C83B70
	public bool get_shouldHideSoftKeyboard() { }

	// RVA: 0xC85040 Offset: 0xC83640 VA: 0x180C85040
	public void set_shouldHideSoftKeyboard(bool value) { }

	// RVA: 0xC83BD0 Offset: 0xC821D0 VA: 0x180C83BD0
	private bool isKeyboardUsingEvents() { }

	// RVA: 0xC83BC0 Offset: 0xC821C0 VA: 0x180C83BC0
	public string get_text() { }

	// RVA: 0xC85360 Offset: 0xC83960 VA: 0x180C85360
	public void set_text(string value) { }

	// RVA: 0xC81E30 Offset: 0xC80430 VA: 0x180C81E30
	public void SetTextWithoutNotify(string input) { }

	// RVA: 0xC81E40 Offset: 0xC80440 VA: 0x180C81E40
	private void SetText(string value, bool sendCallback = True) { }

	// RVA: 0xC837C0 Offset: 0xC81DC0 VA: 0x180C837C0
	public bool get_isFocused() { }

	// RVA: 0x745BD0 Offset: 0x7441D0 VA: 0x180745BD0
	public float get_caretBlinkRate() { }

	// RVA: 0xC83C60 Offset: 0xC82260 VA: 0x180C83C60
	public void set_caretBlinkRate(float value) { }

	// RVA: 0xC834E0 Offset: 0xC81AE0 VA: 0x180C834E0
	public int get_caretWidth() { }

	// RVA: 0xC83F30 Offset: 0xC82530 VA: 0x180C83F30
	public void set_caretWidth(int value) { }

	// RVA: 0xC742E0 Offset: 0xC728E0 VA: 0x180C742E0
	public RectTransform get_textViewport() { }

	// RVA: 0xC85310 Offset: 0xC83910 VA: 0x180C85310
	public void set_textViewport(RectTransform value) { }

	// RVA: 0xB0F550 Offset: 0xB0DB50 VA: 0x180B0F550
	public TMP_Text get_textComponent() { }

	// RVA: 0xC852B0 Offset: 0xC838B0 VA: 0x180C852B0
	public void set_textComponent(TMP_Text value) { }

	// RVA: 0xC83900 Offset: 0xC81F00 VA: 0x180C83900
	public Graphic get_placeholder() { }

	// RVA: 0xC849E0 Offset: 0xC82FE0 VA: 0x180C849E0
	public void set_placeholder(Graphic value) { }

	// RVA: 0x88D560 Offset: 0x88BB60 VA: 0x18088D560
	public Scrollbar get_verticalScrollbar() { }

	// RVA: 0xC85370 Offset: 0xC83970 VA: 0x180C85370
	public void set_verticalScrollbar(Scrollbar value) { }

	// RVA: 0xC83AC0 Offset: 0xC820C0 VA: 0x180C83AC0
	public float get_scrollSensitivity() { }

	// RVA: 0xC84C50 Offset: 0xC83250 VA: 0x180C84C50
	public void set_scrollSensitivity(float value) { }

	// RVA: 0xC83420 Offset: 0xC81A20 VA: 0x180C83420
	public Color get_caretColor() { }

	// RVA: 0xC83CD0 Offset: 0xC822D0 VA: 0x180C83CD0
	public void set_caretColor(Color value) { }

	// RVA: 0xC835E0 Offset: 0xC81BE0 VA: 0x180C835E0
	public bool get_customCaretColor() { }

	// RVA: 0xC842B0 Offset: 0xC828B0 VA: 0x180C842B0
	public void set_customCaretColor(bool value) { }

	// RVA: 0xC83AD0 Offset: 0xC820D0 VA: 0x180C83AD0
	public Color get_selectionColor() { }

	// RVA: 0xC84D80 Offset: 0xC83380 VA: 0x180C84D80
	public void set_selectionColor(Color value) { }

	// RVA: 0xC838C0 Offset: 0xC81EC0 VA: 0x180C838C0
	public TMP_InputField.SubmitEvent get_onEndEdit() { }

	// RVA: 0xC84750 Offset: 0xC82D50 VA: 0x180C84750
	public void set_onEndEdit(TMP_InputField.SubmitEvent value) { }

	// RVA: 0x7B27D0 Offset: 0x7B0DD0 VA: 0x1807B27D0
	public TMP_InputField.SubmitEvent get_onSubmit() { }

	// RVA: 0xC84850 Offset: 0xC82E50 VA: 0x180C84850
	public void set_onSubmit(TMP_InputField.SubmitEvent value) { }

	// RVA: 0xA3CEA0 Offset: 0xA3B4A0 VA: 0x180A3CEA0
	public TMP_InputField.SelectionEvent get_onSelect() { }

	// RVA: 0xC84800 Offset: 0xC82E00 VA: 0x180C84800
	public void set_onSelect(TMP_InputField.SelectionEvent value) { }

	// RVA: 0x900630 Offset: 0x8FEC30 VA: 0x180900630
	public TMP_InputField.SelectionEvent get_onDeselect() { }

	// RVA: 0xC84700 Offset: 0xC82D00 VA: 0x180C84700
	public void set_onDeselect(TMP_InputField.SelectionEvent value) { }

	// RVA: 0xC838F0 Offset: 0xC81EF0 VA: 0x180C838F0
	public TMP_InputField.TextSelectionEvent get_onTextSelection() { }

	// RVA: 0xC848A0 Offset: 0xC82EA0 VA: 0x180C848A0
	public void set_onTextSelection(TMP_InputField.TextSelectionEvent value) { }

	// RVA: 0xC838D0 Offset: 0xC81ED0 VA: 0x180C838D0
	public TMP_InputField.TextSelectionEvent get_onEndTextSelection() { }

	// RVA: 0xC847A0 Offset: 0xC82DA0 VA: 0x180C847A0
	public void set_onEndTextSelection(TMP_InputField.TextSelectionEvent value) { }

	// RVA: 0xB0EE20 Offset: 0xB0D420 VA: 0x180B0EE20
	public TMP_InputField.OnChangeEvent get_onValueChanged() { }

	// RVA: 0xC84990 Offset: 0xC82F90 VA: 0x180C84990
	public void set_onValueChanged(TMP_InputField.OnChangeEvent value) { }

	// RVA: 0xC742F0 Offset: 0xC728F0 VA: 0x180C742F0
	public TMP_InputField.TouchScreenKeyboardEvent get_onTouchScreenKeyboardStatusChanged() { }

	// RVA: 0xC848F0 Offset: 0xC82EF0 VA: 0x180C848F0
	public void set_onTouchScreenKeyboardStatusChanged(TMP_InputField.TouchScreenKeyboardEvent value) { }

	// RVA: 0xAD92C0 Offset: 0xAD78C0 VA: 0x180AD92C0
	public TMP_InputField.OnValidateInput get_onValidateInput() { }

	// RVA: 0xC84940 Offset: 0xC82F40 VA: 0x180C84940
	public void set_onValidateInput(TMP_InputField.OnValidateInput value) { }

	// RVA: 0xC834F0 Offset: 0xC81AF0 VA: 0x180C834F0
	public int get_characterLimit() { }

	// RVA: 0xC83FD0 Offset: 0xC825D0 VA: 0x180C83FD0
	public void set_characterLimit(int value) { }

	// RVA: 0xC83910 Offset: 0xC81F10 VA: 0x180C83910
	public float get_pointSize() { }

	// RVA: 0xC84A30 Offset: 0xC83030 VA: 0x180C84A30
	public void set_pointSize(float value) { }

	// RVA: 0xC83600 Offset: 0xC81C00 VA: 0x180C83600
	public TMP_FontAsset get_fontAsset() { }

	// RVA: 0xC84320 Offset: 0xC82920 VA: 0x180C84320
	public void set_fontAsset(TMP_FontAsset value) { }

	// RVA: 0xC838E0 Offset: 0xC81EE0 VA: 0x180C838E0
	public bool get_onFocusSelectAll() { }

	// RVA: 0xC847F0 Offset: 0xC82DF0 VA: 0x180C847F0
	public void set_onFocusSelectAll(bool value) { }

	// RVA: 0xC83AA0 Offset: 0xC820A0 VA: 0x180C83AA0
	public bool get_resetOnDeActivation() { }

	// RVA: 0xC84BA0 Offset: 0xC831A0 VA: 0x180C84BA0
	public void set_resetOnDeActivation(bool value) { }

	// RVA: 0xC83AB0 Offset: 0xC820B0 VA: 0x180C83AB0
	public bool get_restoreOriginalTextOnEscape() { }

	// RVA: 0xC84BB0 Offset: 0xC831B0 VA: 0x180C84BB0
	public void set_restoreOriginalTextOnEscape(bool value) { }

	// RVA: 0xC837D0 Offset: 0xC81DD0 VA: 0x180C837D0
	public bool get_isRichTextEditingAllowed() { }

	// RVA: 0xC84530 Offset: 0xC82B30 VA: 0x180C84530
	public void set_isRichTextEditingAllowed(bool value) { }

	// RVA: 0xC835D0 Offset: 0xC81BD0 VA: 0x180C835D0
	public TMP_InputField.ContentType get_contentType() { }

	// RVA: 0xC84100 Offset: 0xC82700 VA: 0x180C84100
	public void set_contentType(TMP_InputField.ContentType value) { }

	// RVA: 0x88D550 Offset: 0x88BB50 VA: 0x18088D550
	public TMP_InputField.LineType get_lineType() { }

	// RVA: 0xC84620 Offset: 0xC82C20 VA: 0x180C84620
	public void set_lineType(TMP_InputField.LineType value) { }

	// RVA: 0xC837F0 Offset: 0xC81DF0 VA: 0x180C837F0
	public int get_lineLimit() { }

	// RVA: 0xC845B0 Offset: 0xC82BB0 VA: 0x180C845B0
	public void set_lineLimit(int value) { }

	// RVA: 0xC837A0 Offset: 0xC81DA0 VA: 0x180C837A0
	public TMP_InputField.InputType get_inputType() { }

	// RVA: 0xC84450 Offset: 0xC82A50 VA: 0x180C84450
	public void set_inputType(TMP_InputField.InputType value) { }

	// RVA: 0xC837E0 Offset: 0xC81DE0 VA: 0x180C837E0
	public TouchScreenKeyboardType get_keyboardType() { }

	// RVA: 0xC84540 Offset: 0xC82B40 VA: 0x180C84540
	public void set_keyboardType(TouchScreenKeyboardType value) { }

	// RVA: 0xC83500 Offset: 0xC81B00 VA: 0x180C83500
	public TMP_InputField.CharacterValidation get_characterValidation() { }

	// RVA: 0xC84080 Offset: 0xC82680 VA: 0x180C84080
	public void set_characterValidation(TMP_InputField.CharacterValidation value) { }

	// RVA: 0xC837B0 Offset: 0xC81DB0 VA: 0x180C837B0
	public TMP_InputValidator get_inputValidator() { }

	// RVA: 0xC844C0 Offset: 0xC82AC0 VA: 0x180C844C0
	public void set_inputValidator(TMP_InputValidator value) { }

	// RVA: 0xC83A90 Offset: 0xC82090 VA: 0x180C83A90
	public bool get_readOnly() { }

	// RVA: 0xC84B90 Offset: 0xC83190 VA: 0x180C84B90
	public void set_readOnly(bool value) { }

	// RVA: 0xBC8110 Offset: 0xBC6710 VA: 0x180BC8110
	public bool get_richText() { }

	// RVA: 0xC84BC0 Offset: 0xC831C0 VA: 0x180C84BC0
	public void set_richText(bool value) { }

	// RVA: 0xC838A0 Offset: 0xC81EA0 VA: 0x180C838A0
	public bool get_multiLine() { }

	// RVA: 0xC83410 Offset: 0xC81A10 VA: 0x180C83410
	public char get_asteriskChar() { }

	// RVA: 0xC83C00 Offset: 0xC82200 VA: 0x180C83C00
	public void set_asteriskChar(char value) { }

	// RVA: 0x8FA580 Offset: 0x8F8B80 VA: 0x1808FA580
	public bool get_wasCanceled() { }

	// RVA: 0xC77330 Offset: 0xC75930 VA: 0x180C77330
	protected void ClampStringPos(ref int pos) { }

	// RVA: 0xC772E0 Offset: 0xC758E0 VA: 0x180C772E0
	protected void ClampCaretPos(ref int pos) { }

	// RVA: 0xC83480 Offset: 0xC81A80 VA: 0x180C83480
	protected int get_caretPositionInternal() { }

	// RVA: 0xC83D80 Offset: 0xC82380 VA: 0x180C83D80
	protected void set_caretPositionInternal(int value) { }

	// RVA: 0xC83AE0 Offset: 0xC820E0 VA: 0x180C83AE0
	protected int get_stringPositionInternal() { }

	// RVA: 0xC85140 Offset: 0xC83740 VA: 0x180C85140
	protected void set_stringPositionInternal(int value) { }

	// RVA: 0xC834B0 Offset: 0xC81AB0 VA: 0x180C834B0
	protected int get_caretSelectPositionInternal() { }

	// RVA: 0xC83ED0 Offset: 0xC824D0 VA: 0x180C83ED0
	protected void set_caretSelectPositionInternal(int value) { }

	// RVA: 0xC83B10 Offset: 0xC82110 VA: 0x180C83B10
	protected int get_stringSelectPositionInternal() { }

	// RVA: 0xC85260 Offset: 0xC83860 VA: 0x180C85260
	protected void set_stringSelectPositionInternal(int value) { }

	// RVA: 0xC83610 Offset: 0xC81C10 VA: 0x180C83610
	private bool get_hasSelection() { }

	// RVA: 0xC834B0 Offset: 0xC81AB0 VA: 0x180C834B0
	public int get_caretPosition() { }

	// RVA: 0xC83DE0 Offset: 0xC823E0 VA: 0x180C83DE0
	public void set_caretPosition(int value) { }

	// RVA: 0xC83480 Offset: 0xC81A80 VA: 0x180C83480
	public int get_selectionAnchorPosition() { }

	// RVA: 0xC84CF0 Offset: 0xC832F0 VA: 0x180C84CF0
	public void set_selectionAnchorPosition(int value) { }

	// RVA: 0xC834B0 Offset: 0xC81AB0 VA: 0x180C834B0
	public int get_selectionFocusPosition() { }

	// RVA: 0xC84E30 Offset: 0xC83430 VA: 0x180C84E30
	public void set_selectionFocusPosition(int value) { }

	// RVA: 0xC83B10 Offset: 0xC82110 VA: 0x180C83B10
	public int get_stringPosition() { }

	// RVA: 0xC85190 Offset: 0xC83790 VA: 0x180C85190
	public void set_stringPosition(int value) { }

	// RVA: 0xC83AE0 Offset: 0xC820E0 VA: 0x180C83AE0
	public int get_selectionStringAnchorPosition() { }

	// RVA: 0xC84EC0 Offset: 0xC834C0 VA: 0x180C84EC0
	public void set_selectionStringAnchorPosition(int value) { }

	// RVA: 0xC83B10 Offset: 0xC82110 VA: 0x180C83B10
	public int get_selectionStringFocusPosition() { }

	// RVA: 0xC84F40 Offset: 0xC83540 VA: 0x180C84F40
	public void set_selectionStringFocusPosition(int value) { }

	// RVA: 0xC7F060 Offset: 0xC7D660 VA: 0x180C7F060 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0xC7E770 Offset: 0xC7CD70 VA: 0x180C7E770 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0xC7E4F0 Offset: 0xC7CAF0 VA: 0x180C7E4F0
	private void ON_TEXT_CHANGED(Object obj) { }

	[IteratorStateMachineAttribute] // RVA: 0xD11F0 Offset: 0xD05F0 VA: 0x1800D11F0
	// RVA: 0xC77270 Offset: 0xC75870 VA: 0x180C77270
	private IEnumerator CaretBlink() { }

	// RVA: 0xC81AC0 Offset: 0xC800C0 VA: 0x180C81AC0
	private void SetCaretVisible() { }

	// RVA: 0xC819F0 Offset: 0xC7FFF0 VA: 0x180C819F0
	private void SetCaretActive() { }

	// RVA: 0xC7FC80 Offset: 0xC7E280 VA: 0x180C7FC80
	protected void OnFocus() { }

	// RVA: 0xC81580 Offset: 0xC7FB80 VA: 0x180C81580
	protected void SelectAll() { }

	// RVA: 0xC7D790 Offset: 0xC7BD90 VA: 0x180C7D790
	public void MoveTextEnd(bool shift) { }

	// RVA: 0xC7D9E0 Offset: 0xC7BFE0 VA: 0x180C7D9E0
	public void MoveTextStart(bool shift) { }

	// RVA: 0xC7DC10 Offset: 0xC7C210 VA: 0x180C7DC10
	public void MoveToEndOfLine(bool shift, bool ctrl) { }

	// RVA: 0xC7DEC0 Offset: 0xC7C4C0 VA: 0x180C7DEC0
	public void MoveToStartOfLine(bool shift, bool ctrl) { }

	// RVA: 0xC83510 Offset: 0xC81B10 VA: 0x180C83510
	private static string get_clipboard() { }

	// RVA: 0xC840F0 Offset: 0xC826F0 VA: 0x180C840F0
	private static void set_clipboard(string value) { }

	// RVA: 0xC7A140 Offset: 0xC78740 VA: 0x180C7A140
	private bool InPlaceEditing() { }

	// RVA: 0xC82640 Offset: 0xC80C40 VA: 0x180C82640
	private void UpdateStringPositionFromKeyboard() { }

	// RVA: 0xC7A920 Offset: 0xC78F20 VA: 0x180C7A920 Slot: 60
	protected virtual void LateUpdate() { }

	// RVA: 0xC7B630 Offset: 0xC79C30 VA: 0x180C7B630
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0xC7E6D0 Offset: 0xC7CCD0 VA: 0x180C7E6D0 Slot: 61
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0xC7EAA0 Offset: 0xC7D0A0 VA: 0x180C7EAA0 Slot: 62
	public virtual void OnDrag(PointerEventData eventData) { }

	[IteratorStateMachineAttribute] // RVA: 0xD1330 Offset: 0xD0730 VA: 0x1800D1330
	// RVA: 0xC7B740 Offset: 0xC79D40 VA: 0x180C7B740
	private IEnumerator MouseDragOutsideRect(PointerEventData eventData) { }

	// RVA: 0xC7F6C0 Offset: 0xC7DCC0 VA: 0x180C7F6C0 Slot: 63
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0xC7FD20 Offset: 0xC7E320 VA: 0x180C7FD20 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0xC7A4C0 Offset: 0xC78AC0 VA: 0x180C7A4C0
	protected TMP_InputField.EditState KeyPressed(Event evt) { }

	// RVA: 0xC7A4B0 Offset: 0xC78AB0 VA: 0x180C7A4B0 Slot: 64
	protected virtual bool IsValidChar(char c) { }

	// RVA: 0xC81440 Offset: 0xC7FA40 VA: 0x180C81440
	public void ProcessEvent(Event e) { }

	// RVA: 0xC80B40 Offset: 0xC7F140 VA: 0x180C80B40 Slot: 65
	public virtual void OnUpdateSelected(BaseEventData eventData) { }

	// RVA: 0xC80840 Offset: 0xC7EE40 VA: 0x180C80840 Slot: 66
	public virtual void OnScroll(PointerEventData eventData) { }

	// RVA: 0xC79FC0 Offset: 0xC785C0 VA: 0x180C79FC0
	private string GetSelectedString() { }

	// RVA: 0xC78430 Offset: 0xC76A30 VA: 0x180C78430
	private int FindNextWordBegin() { }

	// RVA: 0xC7CF30 Offset: 0xC7B530 VA: 0x180C7CF30
	private void MoveRight(bool shift, bool ctrl) { }

	// RVA: 0xC78540 Offset: 0xC76B40 VA: 0x180C78540
	private int FindPrevWordBegin() { }

	// RVA: 0xC7BB80 Offset: 0xC7A180 VA: 0x180C7BB80
	private void MoveLeft(bool shift, bool ctrl) { }

	// RVA: 0xC7B2D0 Offset: 0xC798D0 VA: 0x180C7B2D0
	private int LineUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	// RVA: 0xC7AFD0 Offset: 0xC795D0 VA: 0x180C7AFD0
	private int LineDownCharacterPosition(int originalPos, bool goToLastChar) { }

	// RVA: 0xC81080 Offset: 0xC7F680 VA: 0x180C81080
	private int PageUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	// RVA: 0xC80CA0 Offset: 0xC7F2A0 VA: 0x180C80CA0
	private int PageDownCharacterPosition(int originalPos, bool goToLastChar) { }

	// RVA: 0xC7BB70 Offset: 0xC7A170 VA: 0x180C7BB70
	private void MoveDown(bool shift) { }

	// RVA: 0xC7B7D0 Offset: 0xC79DD0 VA: 0x180C7B7D0
	private void MoveDown(bool shift, bool goToLastChar) { }

	// RVA: 0xC7E4E0 Offset: 0xC7CAE0 VA: 0x180C7E4E0
	private void MoveUp(bool shift) { }

	// RVA: 0xC7E160 Offset: 0xC7C760 VA: 0x180C7E160
	private void MoveUp(bool shift, bool goToFirstChar) { }

	// RVA: 0xC7CF20 Offset: 0xC7B520 VA: 0x180C7CF20
	private void MovePageUp(bool shift) { }

	// RVA: 0xC7C980 Offset: 0xC7AF80 VA: 0x180C7C980
	private void MovePageUp(bool shift, bool goToFirstChar) { }

	// RVA: 0xC7C970 Offset: 0xC7AF70 VA: 0x180C7C970
	private void MovePageDown(bool shift) { }

	// RVA: 0xC7C3B0 Offset: 0xC7A9B0 VA: 0x180C7C3B0
	private void MovePageDown(bool shift, bool goToLastChar) { }

	// RVA: 0xC77AD0 Offset: 0xC760D0 VA: 0x180C77AD0
	private void Delete() { }

	// RVA: 0xC77760 Offset: 0xC75D60 VA: 0x180C77760
	private void DeleteKey() { }

	// RVA: 0xC76CC0 Offset: 0xC752C0 VA: 0x180C76CC0
	private void Backspace() { }

	// RVA: 0xC76470 Offset: 0xC74A70 VA: 0x180C76470 Slot: 67
	protected virtual void Append(string input) { }

	// RVA: 0xC76300 Offset: 0xC74900 VA: 0x180C76300 Slot: 68
	protected virtual void Append(char input) { }

	// RVA: 0xC7A230 Offset: 0xC78830 VA: 0x180C7A230
	private void Insert(char c) { }

	// RVA: 0xC82920 Offset: 0xC80F20 VA: 0x180C82920
	private void UpdateTouchKeyboardFromEditChanges() { }

	// RVA: 0xC818D0 Offset: 0xC7FED0 VA: 0x180C818D0
	private void SendOnValueChangedAndUpdateLabel() { }

	// RVA: 0xC81930 Offset: 0xC7FF30 VA: 0x180C81930
	private void SendOnValueChanged() { }

	// RVA: 0xC815E0 Offset: 0xC7FBE0 VA: 0x180C815E0
	protected void SendOnEndEdit() { }

	// RVA: 0xC817B0 Offset: 0xC7FDB0 VA: 0x180C817B0
	protected void SendOnSubmit() { }

	// RVA: 0xC81760 Offset: 0xC7FD60 VA: 0x180C81760
	protected void SendOnFocus() { }

	// RVA: 0xC81710 Offset: 0xC7FD10 VA: 0x180C81710
	protected void SendOnFocusLost() { }

	// RVA: 0xC81800 Offset: 0xC7FE00 VA: 0x180C81800
	protected void SendOnTextSelection() { }

	// RVA: 0xC81630 Offset: 0xC7FC30 VA: 0x180C81630
	protected void SendOnEndTextSelection() { }

	// RVA: 0xC81980 Offset: 0xC7FF80 VA: 0x180C81980
	protected void SendTouchScreenKeyboardStatusChanged() { }

	// RVA: 0xC820F0 Offset: 0xC806F0 VA: 0x180C820F0
	protected void UpdateLabel() { }

	// RVA: 0xC82490 Offset: 0xC80A90 VA: 0x180C82490
	private void UpdateScrollbar() { }

	// RVA: 0xC809F0 Offset: 0xC7EFF0 VA: 0x180C809F0
	private void OnScrollbarValueChange(float value) { }

	// RVA: 0xC76150 Offset: 0xC74750 VA: 0x180C76150
	private void AdjustTextPositionRelativeToViewport(float relativePosition) { }

	// RVA: 0xC79EC0 Offset: 0xC784C0 VA: 0x180C79EC0
	private int GetCaretPositionFromStringIndex(int stringIndex) { }

	// RVA: 0xC79F40 Offset: 0xC78540 VA: 0x180C79F40
	private int GetMinCaretPositionFromStringIndex(int stringIndex) { }

	// RVA: 0xC79EC0 Offset: 0xC784C0 VA: 0x180C79EC0
	private int GetMaxCaretPositionFromStringIndex(int stringIndex) { }

	// RVA: 0xC7A0C0 Offset: 0xC786C0 VA: 0x180C7A0C0
	private int GetStringIndexFromCaretPosition(int caretPosition) { }

	// RVA: 0xC78630 Offset: 0xC76C30 VA: 0x180C78630
	public void ForceLabelUpdate() { }

	// RVA: 0xC7B5D0 Offset: 0xC79BD0 VA: 0x180C7B5D0
	private void MarkGeometryAsDirty() { }

	// RVA: 0xC81450 Offset: 0xC7FA50 VA: 0x180C81450 Slot: 69
	public virtual void Rebuild(CanvasUpdate update) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 70
	public virtual void LayoutComplete() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 71
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0xC82030 Offset: 0xC80630 VA: 0x180C82030
	private void UpdateGeometry() { }

	// RVA: 0xC76520 Offset: 0xC74B20 VA: 0x180C76520
	private void AssignPositioningIfNeeded() { }

	// RVA: 0xC7F6F0 Offset: 0xC7DCF0 VA: 0x180C7F6F0
	private void OnFillVBO(Mesh vbo) { }

	// RVA: 0xC78640 Offset: 0xC76C40 VA: 0x180C78640
	private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0xC77370 Offset: 0xC75970 VA: 0x180C77370
	private void CreateCursorVerts() { }

	// RVA: 0xC790D0 Offset: 0xC776D0 VA: 0x180C790D0
	private void GenerateHightlight(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0xC75850 Offset: 0xC73E50 VA: 0x180C75850
	private void AdjustRectTransformRelativeToViewport(Vector2 startPosition, float height, bool isCharVisible) { }

	// RVA: 0xC82970 Offset: 0xC80F70 VA: 0x180C82970
	protected char Validate(string text, int pos, char ch) { }

	// RVA: 0xC75700 Offset: 0xC73D00 VA: 0x180C75700
	public void ActivateInputField() { }

	// RVA: 0xC75160 Offset: 0xC73760 VA: 0x180C75160
	private void ActivateInputFieldInternal() { }

	// RVA: 0xC80A50 Offset: 0xC7F050 VA: 0x180C80A50 Slot: 36
	public override void OnSelect(BaseEventData eventData) { }

	// RVA: 0xC7FCF0 Offset: 0xC7E2F0 VA: 0x180C7FCF0 Slot: 72
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void OnControlClick() { }

	// RVA: 0xC81520 Offset: 0xC7FB20 VA: 0x180C81520
	public void ReleaseSelection() { }

	// RVA: 0xC77510 Offset: 0xC75B10 VA: 0x180C77510
	public void DeactivateInputField(bool clearSelection = False) { }

	// RVA: 0xC7E700 Offset: 0xC7CD00 VA: 0x180C7E700 Slot: 37
	public override void OnDeselect(BaseEventData eventData) { }

	// RVA: 0xC80AB0 Offset: 0xC7F0B0 VA: 0x180C80AB0 Slot: 73
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0xC782C0 Offset: 0xC768C0 VA: 0x180C782C0
	private void EnforceContentType() { }

	// RVA: 0xC81D70 Offset: 0xC80370 VA: 0x180C81D70
	private void SetTextComponentWrapMode() { }

	// RVA: 0xC81CE0 Offset: 0xC802E0 VA: 0x180C81CE0
	private void SetTextComponentRichTextMode() { }

	// RVA: 0xC81FA0 Offset: 0xC805A0 VA: 0x180C81FA0
	private void SetToCustomIfContentTypeIsNot(TMP_InputField.ContentType[] allowedContentTypes) { }

	// RVA: 0xC82010 Offset: 0xC80610 VA: 0x180C82010
	private void SetToCustom() { }

	// RVA: 0xC82010 Offset: 0xC80610 VA: 0x180C82010
	private void SetToCustom(TMP_InputField.CharacterValidation characterValidation) { }

	// RVA: 0xC78290 Offset: 0xC76890 VA: 0x180C78290 Slot: 26
	protected override void DoStateTransition(Selectable.SelectionState state, bool instant) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 74
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 75
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x568670 Offset: 0x566C70 VA: 0x180568670 Slot: 76
	public virtual float get_minWidth() { }

	// RVA: 0xC839D0 Offset: 0xC81FD0 VA: 0x180C839D0 Slot: 77
	public virtual float get_preferredWidth() { }

	// RVA: 0xC835F0 Offset: 0xC81BF0 VA: 0x180C835F0 Slot: 78
	public virtual float get_flexibleWidth() { }

	// RVA: 0x568670 Offset: 0x566C70 VA: 0x180568670 Slot: 79
	public virtual float get_minHeight() { }

	// RVA: 0xC83920 Offset: 0xC81F20 VA: 0x180C83920 Slot: 80
	public virtual float get_preferredHeight() { }

	// RVA: 0xC835F0 Offset: 0xC81BF0 VA: 0x180C835F0 Slot: 81
	public virtual float get_flexibleHeight() { }

	// RVA: 0x5B1870 Offset: 0x5AFE70 VA: 0x1805B1870 Slot: 82
	public virtual int get_layoutPriority() { }

	// RVA: 0xC81BF0 Offset: 0xC801F0 VA: 0x180C81BF0
	public void SetGlobalPointSize(float pointSize) { }

	// RVA: 0xC81B00 Offset: 0xC80100 VA: 0x180C81B00
	public void SetGlobalFontAsset(TMP_FontAsset fontAsset) { }

	// RVA: 0xC83070 Offset: 0xC81670 VA: 0x180C83070
	private static void .cctor() { }

	// RVA: 0xABDAA0 Offset: 0xABC0A0 VA: 0x180ABDAA0 Slot: 46
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }

}

public enum TMP_InputField.ContentType // TypeDefIndex: 6784
{	// Fields
	public int value__; // 0x0
	public const TMP_InputField.ContentType Standard = 0;
	public const TMP_InputField.ContentType Autocorrected = 1;
	public const TMP_InputField.ContentType IntegerNumber = 2;
	public const TMP_InputField.ContentType DecimalNumber = 3;
	public const TMP_InputField.ContentType Alphanumeric = 4;
	public const TMP_InputField.ContentType Name = 5;
	public const TMP_InputField.ContentType EmailAddress = 6;
	public const TMP_InputField.ContentType Password = 7;
	public const TMP_InputField.ContentType Pin = 8;
	public const TMP_InputField.ContentType Custom = 9;

}

public enum TMP_InputField.InputType // TypeDefIndex: 6785
{	// Fields
	public int value__; // 0x0
	public const TMP_InputField.InputType Standard = 0;
	public const TMP_InputField.InputType AutoCorrect = 1;
	public const TMP_InputField.InputType Password = 2;

}

public enum TMP_InputField.CharacterValidation // TypeDefIndex: 6786
{	// Fields
	public int value__; // 0x0
	public const TMP_InputField.CharacterValidation None = 0;
	public const TMP_InputField.CharacterValidation Digit = 1;
	public const TMP_InputField.CharacterValidation Integer = 2;
	public const TMP_InputField.CharacterValidation Decimal = 3;
	public const TMP_InputField.CharacterValidation Alphanumeric = 4;
	public const TMP_InputField.CharacterValidation Name = 5;
	public const TMP_InputField.CharacterValidation Regex = 6;
	public const TMP_InputField.CharacterValidation EmailAddress = 7;
	public const TMP_InputField.CharacterValidation CustomValidator = 8;

}

public enum TMP_InputField.LineType // TypeDefIndex: 6787
{	// Fields
	public int value__; // 0x0
	public const TMP_InputField.LineType SingleLine = 0;
	public const TMP_InputField.LineType MultiLineSubmit = 1;
	public const TMP_InputField.LineType MultiLineNewline = 2;

}

public sealed class TMP_InputField.OnValidateInput : MulticastDelegate // TypeDefIndex: 6788
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xD985C0 Offset: 0xD96BC0 VA: 0x180D985C0 Slot: 12
	public virtual char Invoke(string text, int charIndex, char addedChar) { }

	// RVA: 0xD984F0 Offset: 0xD96AF0 VA: 0x180D984F0 Slot: 13
	public virtual IAsyncResult BeginInvoke(string text, int charIndex, char addedChar, AsyncCallback callback, object object) { }

	// RVA: 0xD98590 Offset: 0xD96B90 VA: 0x180D98590 Slot: 14
	public virtual char EndInvoke(IAsyncResult result) { }

}

public class TMP_InputField.SubmitEvent : UnityEvent<string> // TypeDefIndex: 6789
{	// Methods

	// RVA: 0xD98BA0 Offset: 0xD971A0 VA: 0x180D98BA0
	public void .ctor() { }

}

public class TMP_InputField.OnChangeEvent : UnityEvent<string> // TypeDefIndex: 6790
{	// Methods

	// RVA: 0xD984B0 Offset: 0xD96AB0 VA: 0x180D984B0
	public void .ctor() { }

}

public class TMP_InputField.SelectionEvent : UnityEvent<string> // TypeDefIndex: 6791
{	// Methods

	// RVA: 0xD98B60 Offset: 0xD97160 VA: 0x180D98B60
	public void .ctor() { }

}

public class TMP_InputField.TextSelectionEvent : UnityEvent<string, int, int> // TypeDefIndex: 6792
{	// Methods

	// RVA: 0xDB6700 Offset: 0xDB4D00 VA: 0x180DB6700
	public void .ctor() { }

}

public class TMP_InputField.TouchScreenKeyboardEvent : UnityEvent<TouchScreenKeyboard.Status> // TypeDefIndex: 6793
{	// Methods

	// RVA: 0xDB6740 Offset: 0xDB4D40 VA: 0x180DB6740
	public void .ctor() { }

}

private sealed class TMP_InputField.<CaretBlink>d__267 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 6795
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public TMP_InputField <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xDB6780 Offset: 0xDB4D80 VA: 0x180DB6780 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDB68D0 Offset: 0xDB4ED0 VA: 0x180DB68D0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class TMP_InputField.<MouseDragOutsideRect>d__285 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 6796
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public TMP_InputField <>4__this; // 0x20
	public PointerEventData eventData; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xDB6920 Offset: 0xDB4F20 VA: 0x180DB6920 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDB6BD0 Offset: 0xDB51D0 VA: 0x180DB6BD0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

public abstract class TMP_InputValidator : ScriptableObject // TypeDefIndex: 6798
{	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract char Validate(ref string text, ref int pos, char ch);

	// RVA: 0x4C3A70 Offset: 0x4C2070 VA: 0x1804C3A70
	protected void .ctor() { }

}

public struct TMP_LineInfo // TypeDefIndex: 6799
{	// Fields
	internal int controlCharacterCount; // 0x0
	public int characterCount; // 0x4
	public int visibleCharacterCount; // 0x8
	public int spaceCount; // 0xC
	public int wordCount; // 0x10
	public int firstCharacterIndex; // 0x14
	public int firstVisibleCharacterIndex; // 0x18
	public int lastCharacterIndex; // 0x1C
	public int lastVisibleCharacterIndex; // 0x20
	public float length; // 0x24
	public float lineHeight; // 0x28
	public float ascender; // 0x2C
	public float baseline; // 0x30
	public float descender; // 0x34
	public float maxAdvance; // 0x38
	public float width; // 0x3C
	public float marginLeft; // 0x40
	public float marginRight; // 0x44
	public TextAlignmentOptions alignment; // 0x48
	public Extents lineExtents; // 0x4C

}

internal static class TMP_ListPool<T> // TypeDefIndex: 6800
{	// Fields
	private static readonly TMP_ObjectPool<List<T>> s_ListPool; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static List<T> Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17B01C0 Offset: 0x17AE7C0 VA: 0x1817B01C0
	|-TMP_ListPool<object>.Get
	|-TMP_ListPool<Canvas>.Get
	|-TMP_ListPool<IMaterialModifier>.Get
	|-TMP_ListPool<Mask>.Get
	*/

	// RVA: -1 Offset: -1
	public static void Release(List<T> toRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17B0330 Offset: 0x17AE930 VA: 0x1817B0330
	|-TMP_ListPool<object>.Release
	|-TMP_ListPool<Canvas>.Release
	|-TMP_ListPool<IMaterialModifier>.Release
	|-TMP_ListPool<Mask>.Release
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17B04B0 Offset: 0x17AEAB0 VA: 0x1817B04B0
	|-TMP_ListPool<object>..cctor
	*/

}

private sealed class TMP_ListPool.<>c<T> // TypeDefIndex: 6801
{	// Fields
	public static readonly TMP_ListPool.<>c<T> <>9; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD66290 Offset: 0xD64890 VA: 0x180D66290
	|-TMP_ListPool.<>c<object>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BAD0 Offset: 0xD5A0D0 VA: 0x180D5BAD0
	|-TMP_ListPool.<>c<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <.cctor>b__3_0(List<T> l) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16509E0 Offset: 0x164EFE0 VA: 0x1816509E0
	|-TMP_ListPool.<>c<object>.<.cctor>b__3_0
	*/

}

public static class TMP_MaterialManager // TypeDefIndex: 6802
{	// Fields
	private static List<TMP_MaterialManager.MaskingMaterial> m_materialList; // 0x0
	private static Dictionary<long, TMP_MaterialManager.FallbackMaterial> m_fallbackMaterials; // 0x8
	private static Dictionary<int, long> m_fallbackMaterialLookup; // 0x10
	private static List<TMP_MaterialManager.FallbackMaterial> m_fallbackCleanupList; // 0x18
	private static bool isFallbackListDirty; // 0x20

	// Methods

	// RVA: 0xD9B980 Offset: 0xD99F80 VA: 0x180D9B980
	private static void .cctor() { }

	// RVA: 0xD9A8F0 Offset: 0xD98EF0 VA: 0x180D9A8F0
	private static void OnPreRender(Camera cam) { }

	// RVA: 0xD9A860 Offset: 0xD98E60 VA: 0x180D9A860
	private static void OnPreRenderCanvas() { }

	// RVA: 0xD9A490 Offset: 0xD98A90 VA: 0x180D9A490
	public static Material GetStencilMaterial(Material baseMaterial, int stencilID) { }

	// RVA: 0xD9B340 Offset: 0xD99940 VA: 0x180D9B340
	public static void ReleaseStencilMaterial(Material stencilMaterial) { }

	// RVA: 0xD99900 Offset: 0xD97F00 VA: 0x180D99900
	public static Material GetBaseMaterial(Material stencilMaterial) { }

	// RVA: 0xD9B870 Offset: 0xD99E70 VA: 0x180D9B870
	public static Material SetStencil(Material material, int stencilID) { }

	// RVA: 0xD98E90 Offset: 0xD97490 VA: 0x180D98E90
	public static void AddMaskingMaterial(Material baseMaterial, Material stencilMaterial, int stencilID) { }

	// RVA: 0xD9B730 Offset: 0xD99D30 VA: 0x180D9B730
	public static void RemoveStencilMaterial(Material stencilMaterial) { }

	// RVA: 0xD9A980 Offset: 0xD98F80 VA: 0x180D9A980
	public static void ReleaseBaseMaterial(Material baseMaterial) { }

	// RVA: 0xD99310 Offset: 0xD97910 VA: 0x180D99310
	public static void ClearMaterials() { }

	// RVA: 0xD9A0A0 Offset: 0xD986A0 VA: 0x180D9A0A0
	public static int GetStencilID(GameObject obj) { }

	// RVA: 0xD99ED0 Offset: 0xD984D0 VA: 0x180D99ED0
	public static Material GetMaterialForRendering(MaskableGraphic graphic, Material baseMaterial) { }

	// RVA: 0xD997A0 Offset: 0xD97DA0 VA: 0x180D997A0
	private static Transform FindRootSortOverrideCanvas(Transform start) { }

	// RVA: 0xD99A60 Offset: 0xD98060 VA: 0x180D99A60
	public static Material GetFallbackMaterial(Material sourceMaterial, Material targetMaterial) { }

	// RVA: 0xD98D60 Offset: 0xD97360 VA: 0x180D98D60
	public static void AddFallbackMaterialReference(Material targetMaterial) { }

	// RVA: 0xD9B590 Offset: 0xD99B90 VA: 0x180D9B590
	public static void RemoveFallbackMaterialReference(Material targetMaterial) { }

	// RVA: 0xD990E0 Offset: 0xD976E0 VA: 0x180D990E0
	public static void CleanupFallbackMaterials() { }

	// RVA: 0xD9B170 Offset: 0xD99770 VA: 0x180D9B170
	public static void ReleaseFallbackMaterial(Material fallackMaterial) { }

	// RVA: 0xD994B0 Offset: 0xD97AB0 VA: 0x180D994B0
	public static void CopyMaterialPresetProperties(Material source, Material destination) { }

}

private class TMP_MaterialManager.FallbackMaterial // TypeDefIndex: 6803
{	// Fields
	public int baseID; // 0x10
	public Material baseMaterial; // 0x18
	public long fallbackID; // 0x20
	public Material fallbackMaterial; // 0x28
	public int count; // 0x30

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private class TMP_MaterialManager.MaskingMaterial // TypeDefIndex: 6804
{	// Fields
	public Material baseMaterial; // 0x10
	public Material stencilMaterial; // 0x18
	public int count; // 0x20
	public int stencilID; // 0x24

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class TMP_MaterialManager.<>c__DisplayClass10_0 // TypeDefIndex: 6805
{	// Fields
	public Material stencilMaterial; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xDB6C20 Offset: 0xDB5220 VA: 0x180DB6C20
	internal bool <GetBaseMaterial>b__0(TMP_MaterialManager.MaskingMaterial item) { }

}

private sealed class TMP_MaterialManager.<>c__DisplayClass12_0 // TypeDefIndex: 6806
{	// Fields
	public Material stencilMaterial; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xDB6CA0 Offset: 0xDB52A0 VA: 0x180DB6CA0
	internal bool <AddMaskingMaterial>b__0(TMP_MaterialManager.MaskingMaterial item) { }

}

private sealed class TMP_MaterialManager.<>c__DisplayClass13_0 // TypeDefIndex: 6807
{	// Fields
	public Material stencilMaterial; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xDB6D20 Offset: 0xDB5320 VA: 0x180DB6D20
	internal bool <RemoveStencilMaterial>b__0(TMP_MaterialManager.MaskingMaterial item) { }

}

private sealed class TMP_MaterialManager.<>c__DisplayClass14_0 // TypeDefIndex: 6808
{	// Fields
	public Material baseMaterial; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xDB6DA0 Offset: 0xDB53A0 VA: 0x180DB6DA0
	internal bool <ReleaseBaseMaterial>b__0(TMP_MaterialManager.MaskingMaterial item) { }

}

public struct TMP_MeshInfo // TypeDefIndex: 6810
{	// Fields
	private static readonly Color32 s_DefaultColor; // 0x0
	private static readonly Vector3 s_DefaultNormal; // 0x4
	private static readonly Vector4 s_DefaultTangent; // 0x10
	private static readonly Bounds s_DefaultBounds; // 0x20
	public Mesh mesh; // 0x0
	public int vertexCount; // 0x8
	public Vector3[] vertices; // 0x10
	public Vector3[] normals; // 0x18
	public Vector4[] tangents; // 0x20
	public Vector2[] uvs0; // 0x28
	public Vector2[] uvs2; // 0x30
	public Color32[] colors32; // 0x38
	public int[] triangles; // 0x40

	// Methods

	// RVA: 0x1224A0 Offset: 0x1218A0 VA: 0x1801224A0
	public void .ctor(Mesh mesh, int size) { }

	// RVA: 0x1224B0 Offset: 0x1218B0 VA: 0x1801224B0
	public void .ctor(Mesh mesh, int size, bool isVolumetric) { }

	// RVA: 0x1222A0 Offset: 0x1216A0 VA: 0x1801222A0
	public void ResizeMeshInfo(int size) { }

	// RVA: 0x1222B0 Offset: 0x1216B0 VA: 0x1801222B0
	public void ResizeMeshInfo(int size, bool isVolumetric) { }

	// RVA: 0x1221F0 Offset: 0x1215F0 VA: 0x1801221F0
	public void Clear() { }

	// RVA: 0x1220B0 Offset: 0x1214B0 VA: 0x1801220B0
	public void Clear(bool uploadChanges) { }

	// RVA: 0x122070 Offset: 0x121470 VA: 0x180122070
	public void ClearUnusedVertices() { }

	// RVA: 0x121F80 Offset: 0x121380 VA: 0x180121F80
	public void ClearUnusedVertices(int startIndex) { }

	// RVA: 0x121FB0 Offset: 0x1213B0 VA: 0x180121FB0
	public void ClearUnusedVertices(int startIndex, bool updateMesh) { }

	// RVA: 0x1222C0 Offset: 0x1216C0 VA: 0x1801222C0
	public void SortGeometry(VertexSortingOrder order) { }

	// RVA: 0x122340 Offset: 0x121740 VA: 0x180122340
	public void SortGeometry(IList<int> sortingOrder) { }

	// RVA: 0x122490 Offset: 0x121890 VA: 0x180122490
	public void SwapVertexData(int src, int dst) { }

	// RVA: 0xD9DCC0 Offset: 0xD9C2C0 VA: 0x180D9DCC0
	private static void .cctor() { }

}

internal class TMP_ObjectPool<T> // TypeDefIndex: 6811
{	// Fields
	private readonly Stack<T> m_Stack; // 0x0
	private readonly UnityAction<T> m_ActionOnGet; // 0x0
	private readonly UnityAction<T> m_ActionOnRelease; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <countAll>k__BackingField; // 0x0

	// Properties
	public int countAll { get; set; }
	public int countActive { get; }
	public int countInactive { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public int get_countAll() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4BE590 Offset: 0x4BCB90 VA: 0x1804BE590
	|-TMP_ObjectPool<object>.get_countAll
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	private void set_countAll(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x79C680 Offset: 0x79AC80 VA: 0x18079C680
	|-TMP_ObjectPool<object>.set_countAll
	*/

	// RVA: -1 Offset: -1
	public int get_countActive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17B0A00 Offset: 0x17AF000 VA: 0x1817B0A00
	|-TMP_ObjectPool<object>.get_countActive
	*/

	// RVA: -1 Offset: -1
	public int get_countInactive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE08880 Offset: 0xE06E80 VA: 0x180E08880
	|-TMP_ObjectPool<object>.get_countInactive
	*/

	// RVA: -1 Offset: -1
	public void .ctor(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17B0940 Offset: 0x17AEF40 VA: 0x1817B0940
	|-TMP_ObjectPool<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public T Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17B0750 Offset: 0x17AED50 VA: 0x1817B0750
	|-TMP_ObjectPool<object>.Get
	*/

	// RVA: -1 Offset: -1
	public void Release(T element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17B0840 Offset: 0x17AEE40 VA: 0x1817B0840
	|-TMP_ObjectPool<object>.Release
	*/

}

public struct TMP_FontStyleStack // TypeDefIndex: 6812
{	// Fields
	public byte bold; // 0x0
	public byte italic; // 0x1
	public byte underline; // 0x2
	public byte strikethrough; // 0x3
	public byte highlight; // 0x4
	public byte superscript; // 0x5
	public byte subscript; // 0x6
	public byte uppercase; // 0x7
	public byte lowercase; // 0x8
	public byte smallcaps; // 0x9

	// Methods

	// RVA: 0x117740 Offset: 0x116B40 VA: 0x180117740
	public void Clear() { }

	// RVA: 0x1176C0 Offset: 0x116AC0 VA: 0x1801176C0
	public byte Add(FontStyles style) { }

	// RVA: 0x117750 Offset: 0x116B50 VA: 0x180117750
	public byte Remove(FontStyles style) { }

}

public struct TMP_RichTextTagStack<T> // TypeDefIndex: 6813
{	// Fields
	public T[] m_ItemStack; // 0x0
	public int m_Index; // 0x0
	private int m_Capacity; // 0x0
	private T m_DefaultItem; // 0x0
	private const int k_DefaultCapacity = 4;

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T[] tagStack) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2100B0 Offset: 0x20F4B0 VA: 0x1802100B0
	|-TMP_RichTextTagStack<int>..ctor
	|-TMP_RichTextTagStack<Int32Enum>..ctor
	|-TMP_RichTextTagStack<float>..ctor
	|-TMP_RichTextTagStack<TextAlignmentOptions>..ctor
	|-TMP_RichTextTagStack<Color32>..ctor
	|
	|-RVA: 0x210200 Offset: 0x20F600 VA: 0x180210200
	|-TMP_RichTextTagStack<object>..ctor
	|-TMP_RichTextTagStack<TMP_ColorGradient>..ctor
	|
	|-RVA: 0x2102E0 Offset: 0x20F6E0 VA: 0x1802102E0
	|-TMP_RichTextTagStack<MaterialReference>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x210100 Offset: 0x20F500 VA: 0x180210100
	|-TMP_RichTextTagStack<int>..ctor
	|-TMP_RichTextTagStack<Int32Enum>..ctor
	|-TMP_RichTextTagStack<float>..ctor
	|-TMP_RichTextTagStack<FontWeight>..ctor
	|-TMP_RichTextTagStack<Color32>..ctor
	|
	|-RVA: 0x210180 Offset: 0x20F580 VA: 0x180210180
	|-TMP_RichTextTagStack<object>..ctor
	|
	|-RVA: 0x210250 Offset: 0x20F650 VA: 0x180210250
	|-TMP_RichTextTagStack<MaterialReference>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20F150 Offset: 0x20E550 VA: 0x18020F150
	|-TMP_RichTextTagStack<int>.Clear
	|-TMP_RichTextTagStack<Int32Enum>.Clear
	|-TMP_RichTextTagStack<object>.Clear
	|-TMP_RichTextTagStack<float>.Clear
	|-TMP_RichTextTagStack<MaterialReference>.Clear
	|-TMP_RichTextTagStack<Color32>.Clear
	*/

	// RVA: -1 Offset: -1
	public void SetDefault(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20FF80 Offset: 0x20F380 VA: 0x18020FF80
	|-TMP_RichTextTagStack<int>.SetDefault
	|-TMP_RichTextTagStack<Int32Enum>.SetDefault
	|-TMP_RichTextTagStack<FontWeight>.SetDefault
	|-TMP_RichTextTagStack<TextAlignmentOptions>.SetDefault
	|-TMP_RichTextTagStack<Color32>.SetDefault
	|
	|-RVA: 0x20FFC0 Offset: 0x20F3C0 VA: 0x18020FFC0
	|-TMP_RichTextTagStack<object>.SetDefault
	|-TMP_RichTextTagStack<TMP_ColorGradient>.SetDefault
	|
	|-RVA: 0x210070 Offset: 0x20F470 VA: 0x180210070
	|-TMP_RichTextTagStack<float>.SetDefault
	|
	|-RVA: 0x210010 Offset: 0x20F410 VA: 0x180210010
	|-TMP_RichTextTagStack<MaterialReference>.SetDefault
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20F010 Offset: 0x20E410 VA: 0x18020F010
	|-TMP_RichTextTagStack<int>.Add
	|-TMP_RichTextTagStack<Int32Enum>.Add
	|-TMP_RichTextTagStack<FontWeight>.Add
	|-TMP_RichTextTagStack<TextAlignmentOptions>.Add
	|-TMP_RichTextTagStack<Color32>.Add
	|
	|-RVA: 0x20F050 Offset: 0x20E450 VA: 0x18020F050
	|-TMP_RichTextTagStack<object>.Add
	|-TMP_RichTextTagStack<TMP_ColorGradient>.Add
	|
	|-RVA: 0x20F0A0 Offset: 0x20E4A0 VA: 0x18020F0A0
	|-TMP_RichTextTagStack<float>.Add
	|
	|-RVA: 0x20F0E0 Offset: 0x20E4E0 VA: 0x18020F0E0
	|-TMP_RichTextTagStack<MaterialReference>.Add
	*/

	// RVA: -1 Offset: -1
	public T Remove() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20FEA0 Offset: 0x20F2A0 VA: 0x18020FEA0
	|-TMP_RichTextTagStack<int>.Remove
	|-TMP_RichTextTagStack<Int32Enum>.Remove
	|-TMP_RichTextTagStack<FontWeight>.Remove
	|-TMP_RichTextTagStack<TextAlignmentOptions>.Remove
	|-TMP_RichTextTagStack<Color32>.Remove
	|
	|-RVA: 0x20FF10 Offset: 0x20F310 VA: 0x18020FF10
	|-TMP_RichTextTagStack<object>.Remove
	|-TMP_RichTextTagStack<TMP_ColorGradient>.Remove
	|
	|-RVA: 0x20FD70 Offset: 0x20F170 VA: 0x18020FD70
	|-TMP_RichTextTagStack<float>.Remove
	|
	|-RVA: 0x20FDF0 Offset: 0x20F1F0 VA: 0x18020FDF0
	|-TMP_RichTextTagStack<MaterialReference>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Push(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20F8C0 Offset: 0x20ECC0 VA: 0x18020F8C0
	|-TMP_RichTextTagStack<int>.Push
	|-TMP_RichTextTagStack<Int32Enum>.Push
	|
	|-RVA: 0x20FB90 Offset: 0x20EF90 VA: 0x18020FB90
	|-TMP_RichTextTagStack<object>.Push
	|
	|-RVA: 0x20FC80 Offset: 0x20F080 VA: 0x18020FC80
	|-TMP_RichTextTagStack<float>.Push
	|
	|-RVA: 0x20F9A0 Offset: 0x20EDA0 VA: 0x18020F9A0
	|-TMP_RichTextTagStack<MaterialReference>.Push
	|
	|-RVA: 0x20FAB0 Offset: 0x20EEB0 VA: 0x18020FAB0
	|-TMP_RichTextTagStack<Color32>.Push
	*/

	// RVA: -1 Offset: -1
	public T Pop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20F5A0 Offset: 0x20E9A0 VA: 0x18020F5A0
	|-TMP_RichTextTagStack<int>.Pop
	|-TMP_RichTextTagStack<Int32Enum>.Pop
	|-TMP_RichTextTagStack<Color32>.Pop
	|
	|-RVA: 0x20F600 Offset: 0x20EA00 VA: 0x18020F600
	|-TMP_RichTextTagStack<object>.Pop
	|
	|-RVA: 0x20F670 Offset: 0x20EA70 VA: 0x18020F670
	|-TMP_RichTextTagStack<float>.Pop
	|
	|-RVA: 0x20F4B0 Offset: 0x20E8B0 VA: 0x18020F4B0
	|-TMP_RichTextTagStack<MaterialReference>.Pop
	*/

	// RVA: -1 Offset: -1
	public T Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20F340 Offset: 0x20E740 VA: 0x18020F340
	|-TMP_RichTextTagStack<int>.Peek
	|-TMP_RichTextTagStack<Int32Enum>.Peek
	|-TMP_RichTextTagStack<FontWeight>.Peek
	|-TMP_RichTextTagStack<Color32>.Peek
	|
	|-RVA: 0x20F410 Offset: 0x20E810 VA: 0x18020F410
	|-TMP_RichTextTagStack<object>.Peek
	|
	|-RVA: 0x20F460 Offset: 0x20E860 VA: 0x18020F460
	|-TMP_RichTextTagStack<float>.Peek
	|
	|-RVA: 0x20F390 Offset: 0x20E790 VA: 0x18020F390
	|-TMP_RichTextTagStack<MaterialReference>.Peek
	*/

	// RVA: -1 Offset: -1
	public T CurrentItem() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20F160 Offset: 0x20E560 VA: 0x18020F160
	|-TMP_RichTextTagStack<int>.CurrentItem
	|-TMP_RichTextTagStack<Int32Enum>.CurrentItem
	|-TMP_RichTextTagStack<Color32>.CurrentItem
	|
	|-RVA: 0x20F2D0 Offset: 0x20E6D0 VA: 0x18020F2D0
	|-TMP_RichTextTagStack<object>.CurrentItem
	|
	|-RVA: 0x20F260 Offset: 0x20E660 VA: 0x18020F260
	|-TMP_RichTextTagStack<float>.CurrentItem
	|
	|-RVA: 0x20F1C0 Offset: 0x20E5C0 VA: 0x18020F1C0
	|-TMP_RichTextTagStack<MaterialReference>.CurrentItem
	*/

	// RVA: -1 Offset: -1
	public T PreviousItem() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20F6D0 Offset: 0x20EAD0 VA: 0x18020F6D0
	|-TMP_RichTextTagStack<int>.PreviousItem
	|-TMP_RichTextTagStack<Int32Enum>.PreviousItem
	|-TMP_RichTextTagStack<Color32>.PreviousItem
	|
	|-RVA: 0x20F740 Offset: 0x20EB40 VA: 0x18020F740
	|-TMP_RichTextTagStack<object>.PreviousItem
	|
	|-RVA: 0x20F850 Offset: 0x20EC50 VA: 0x18020F850
	|-TMP_RichTextTagStack<float>.PreviousItem
	|
	|-RVA: 0x20F7B0 Offset: 0x20EBB0 VA: 0x18020F7B0
	|-TMP_RichTextTagStack<MaterialReference>.PreviousItem
	*/

}

public class TMP_ScrollbarEventHandler : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, ISelectHandler, IDeselectHandler // TypeDefIndex: 6818
{	// Fields
	public bool isSelected; // 0x18

	// Methods

	// RVA: 0xD9F110 Offset: 0xD9D710 VA: 0x180D9F110 Slot: 4
	public void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0xD9F160 Offset: 0xD9D760 VA: 0x180D9F160 Slot: 5
	public void OnSelect(BaseEventData eventData) { }

	// RVA: 0xD9F0B0 Offset: 0xD9D6B0 VA: 0x180D9F0B0 Slot: 6
	public void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class TMP_SelectionCaret : MaskableGraphic // TypeDefIndex: 6819
{	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 58
	public override void Cull(Rect clipRect, bool validRect) { }

	// RVA: 0xD9F1C0 Offset: 0xD9D7C0 VA: 0x180D9F1C0
	public void .ctor() { }

}

public class TMP_Settings : ScriptableObject // TypeDefIndex: 6820
{	// Fields
	private static TMP_Settings s_Instance; // 0x0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_enableWordWrapping; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_enableKerning; // 0x19
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_enableExtraPadding; // 0x1A
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_enableTintAllSprites; // 0x1B
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_EnableRaycastTarget; // 0x1C
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_GetFontFeaturesAtRuntime; // 0x1D
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int m_missingGlyphCharacter; // 0x20
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_warningsDisabled; // 0x24
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TMP_FontAsset m_defaultFontAsset; // 0x28
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string m_defaultFontAssetPath; // 0x30
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_defaultFontSize; // 0x38
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_defaultAutoSizeMinRatio; // 0x3C
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_defaultAutoSizeMaxRatio; // 0x40
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector2 m_defaultTextMeshProTextContainerSize; // 0x44
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector2 m_defaultTextMeshProUITextContainerSize; // 0x4C
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_autoSizeTextContainer; // 0x54
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private List<TMP_FontAsset> m_fallbackFontAssets; // 0x58
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_matchMaterialPreset; // 0x60
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string m_defaultColorGradientPresetsPath; // 0x68
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_enableEmojiSupport; // 0x70
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TextAsset m_leadingCharacters; // 0x78
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TextAsset m_followingCharacters; // 0x80
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TMP_Settings.LineBreakingTable m_linebreakingRules; // 0x88

	// Properties
	public static string version { get; }
	public static bool enableWordWrapping { get; }
	public static bool enableKerning { get; }
	public static bool enableExtraPadding { get; }
	public static bool enableTintAllSprites { get; }
	public static bool enableRaycastTarget { get; }
	public static bool getFontFeaturesAtRuntime { get; }
	public static int missingGlyphCharacter { get; set; }
	public static bool warningsDisabled { get; }
	public static TMP_FontAsset defaultFontAsset { get; }
	public static string defaultFontAssetPath { get; }
	public static float defaultFontSize { get; }
	public static float defaultTextAutoSizingMinRatio { get; }
	public static float defaultTextAutoSizingMaxRatio { get; }
	public static Vector2 defaultTextMeshProTextContainerSize { get; }
	public static Vector2 defaultTextMeshProUITextContainerSize { get; }
	public static bool autoSizeTextContainer { get; }
	public static List<TMP_FontAsset> fallbackFontAssets { get; }
	public static bool matchMaterialPreset { get; }
	public static string defaultColorGradientPresetsPath { get; }
	public static bool enableEmojiSupport { get; set; }
	public static TextAsset leadingCharacters { get; }
	public static TextAsset followingCharacters { get; }
	public static TMP_Settings.LineBreakingTable linebreakingRules { get; }
	public static TMP_Settings instance { get; }

	// Methods

	// RVA: 0xD9FAD0 Offset: 0xD9E0D0 VA: 0x180D9FAD0
	public static string get_version() { }

	// RVA: 0xD9F7B0 Offset: 0xD9DDB0 VA: 0x180D9F7B0
	public static bool get_enableWordWrapping() { }

	// RVA: 0xD9F750 Offset: 0xD9DD50 VA: 0x180D9F750
	public static bool get_enableKerning() { }

	// RVA: 0xD9F730 Offset: 0xD9DD30 VA: 0x180D9F730
	public static bool get_enableExtraPadding() { }

	// RVA: 0xD9F790 Offset: 0xD9DD90 VA: 0x180D9F790
	public static bool get_enableTintAllSprites() { }

	// RVA: 0xD9F770 Offset: 0xD9DD70 VA: 0x180D9F770
	public static bool get_enableRaycastTarget() { }

	// RVA: 0xD9F820 Offset: 0xD9DE20 VA: 0x180D9F820
	public static bool get_getFontFeaturesAtRuntime() { }

	// RVA: 0xD9FAB0 Offset: 0xD9E0B0 VA: 0x180D9FAB0
	public static int get_missingGlyphCharacter() { }

	// RVA: 0xD9FB50 Offset: 0xD9E150 VA: 0x180D9FB50
	public static void set_missingGlyphCharacter(int value) { }

	// RVA: 0xD9FB00 Offset: 0xD9E100 VA: 0x180D9FB00
	public static bool get_warningsDisabled() { }

	// RVA: 0xD9F630 Offset: 0xD9DC30 VA: 0x180D9F630
	public static TMP_FontAsset get_defaultFontAsset() { }

	// RVA: 0xD9F610 Offset: 0xD9DC10 VA: 0x180D9F610
	public static string get_defaultFontAssetPath() { }

	// RVA: 0xD9F650 Offset: 0xD9DC50 VA: 0x180D9F650
	public static float get_defaultFontSize() { }

	// RVA: 0xD9F690 Offset: 0xD9DC90 VA: 0x180D9F690
	public static float get_defaultTextAutoSizingMinRatio() { }

	// RVA: 0xD9F670 Offset: 0xD9DC70 VA: 0x180D9F670
	public static float get_defaultTextAutoSizingMaxRatio() { }

	// RVA: 0xD9F6B0 Offset: 0xD9DCB0 VA: 0x180D9F6B0
	public static Vector2 get_defaultTextMeshProTextContainerSize() { }

	// RVA: 0xD9F6E0 Offset: 0xD9DCE0 VA: 0x180D9F6E0
	public static Vector2 get_defaultTextMeshProUITextContainerSize() { }

	// RVA: 0xD9F5D0 Offset: 0xD9DBD0 VA: 0x180D9F5D0
	public static bool get_autoSizeTextContainer() { }

	// RVA: 0xD9F7D0 Offset: 0xD9DDD0 VA: 0x180D9F7D0
	public static List<TMP_FontAsset> get_fallbackFontAssets() { }

	// RVA: 0xD9FA90 Offset: 0xD9E090 VA: 0x180D9FA90
	public static bool get_matchMaterialPreset() { }

	// RVA: 0xD9F5F0 Offset: 0xD9DBF0 VA: 0x180D9F5F0
	public static string get_defaultColorGradientPresetsPath() { }

	// RVA: 0xD9F710 Offset: 0xD9DD10 VA: 0x180D9F710
	public static bool get_enableEmojiSupport() { }

	// RVA: 0xD9FB20 Offset: 0xD9E120 VA: 0x180D9FB20
	public static void set_enableEmojiSupport(bool value) { }

	// RVA: 0xD9F8F0 Offset: 0xD9DEF0 VA: 0x180D9F8F0
	public static TextAsset get_leadingCharacters() { }

	// RVA: 0xD9F7F0 Offset: 0xD9DDF0 VA: 0x180D9F7F0
	public static TextAsset get_followingCharacters() { }

	// RVA: 0xD9F910 Offset: 0xD9DF10 VA: 0x180D9F910
	public static TMP_Settings.LineBreakingTable get_linebreakingRules() { }

	// RVA: 0xD9F840 Offset: 0xD9DE40 VA: 0x180D9F840
	public static TMP_Settings get_instance() { }

	// RVA: 0xD9F3A0 Offset: 0xD9D9A0 VA: 0x180D9F3A0
	public static TMP_Settings LoadDefaultSettings() { }

	// RVA: 0xD9F330 Offset: 0xD9D930 VA: 0x180D9F330
	public static TMP_Settings GetSettings() { }

	// RVA: 0xD9F2B0 Offset: 0xD9D8B0 VA: 0x180D9F2B0
	public static TMP_FontAsset GetFontAsset() { }

	// RVA: 0xD9F480 Offset: 0xD9DA80 VA: 0x180D9F480
	public static void LoadLinebreakingRules() { }

	// RVA: 0xD9F1D0 Offset: 0xD9D7D0 VA: 0x180D9F1D0
	private static Dictionary<int, char> GetCharacters(TextAsset file) { }

	// RVA: 0xD9F5C0 Offset: 0xD9DBC0 VA: 0x180D9F5C0
	public void .ctor() { }

}

public class TMP_Settings.LineBreakingTable // TypeDefIndex: 6821
{	// Fields
	public Dictionary<int, char> leadingCharacters; // 0x10
	public Dictionary<int, char> followingCharacters; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class TMP_SubMesh : MonoBehaviour // TypeDefIndex: 6823
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TMP_FontAsset m_fontAsset; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Material m_material; // 0x20
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Material m_sharedMaterial; // 0x28
	private Material m_fallbackMaterial; // 0x30
	private Material m_fallbackSourceMaterial; // 0x38
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_isDefaultMaterial; // 0x40
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_padding; // 0x44
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Renderer m_renderer; // 0x48
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private MeshFilter m_meshFilter; // 0x50
	private Mesh m_mesh; // 0x58
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TextMeshPro m_TextComponent; // 0x60
	private bool m_isRegisteredForEvents; // 0x68

	// Properties
	public TMP_FontAsset fontAsset { get; set; }
	public Material material { get; set; }
	public Material sharedMaterial { get; set; }
	public Material fallbackMaterial { get; set; }
	public Material fallbackSourceMaterial { get; set; }
	public bool isDefaultMaterial { get; set; }
	public float padding { get; set; }
	public Renderer renderer { get; }
	public MeshFilter meshFilter { get; }
	public Mesh mesh { get; set; }

	// Methods

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public TMP_FontAsset get_fontAsset() { }

	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	public void set_fontAsset(TMP_FontAsset value) { }

	// RVA: 0xDA2240 Offset: 0xDA0840 VA: 0x180DA2240
	public Material get_material() { }

	// RVA: 0xDA25F0 Offset: 0xDA0BF0 VA: 0x180DA25F0
	public void set_material(Material value) { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public Material get_sharedMaterial() { }

	// RVA: 0xDA20A0 Offset: 0xDA06A0 VA: 0x180DA20A0
	public void set_sharedMaterial(Material value) { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public Material get_fallbackMaterial() { }

	// RVA: 0xDA2470 Offset: 0xDA0A70 VA: 0x180DA2470
	public void set_fallbackMaterial(Material value) { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public Material get_fallbackSourceMaterial() { }

	// RVA: 0x6AD650 Offset: 0x6ABC50 VA: 0x1806AD650
	public void set_fallbackSourceMaterial(Material value) { }

	// RVA: 0x805B90 Offset: 0x804190 VA: 0x180805B90
	public bool get_isDefaultMaterial() { }

	// RVA: 0x810590 Offset: 0x80EB90 VA: 0x180810590
	public void set_isDefaultMaterial(bool value) { }

	// RVA: 0x805B80 Offset: 0x804180 VA: 0x180805B80
	public float get_padding() { }

	// RVA: 0x86DEE0 Offset: 0x86C4E0 VA: 0x18086DEE0
	public void set_padding(float value) { }

	// RVA: 0xDA23D0 Offset: 0xDA09D0 VA: 0x180DA23D0
	public Renderer get_renderer() { }

	// RVA: 0xDA2250 Offset: 0xDA0850 VA: 0x180DA2250
	public MeshFilter get_meshFilter() { }

	// RVA: 0xDA22F0 Offset: 0xDA08F0 VA: 0x180DA22F0
	public Mesh get_mesh() { }

	// RVA: 0x4CF810 Offset: 0x4CDE10 VA: 0x1804CF810
	public void set_mesh(Mesh value) { }

	// RVA: 0xDA1D90 Offset: 0xDA0390 VA: 0x180DA1D90
	private void OnEnable() { }

	// RVA: 0xDA1CC0 Offset: 0xDA02C0 VA: 0x180DA1CC0
	private void OnDisable() { }

	// RVA: 0xDA1BA0 Offset: 0xDA01A0 VA: 0x180DA1BA0
	private void OnDestroy() { }

	// RVA: 0xDA1380 Offset: 0xD9F980 VA: 0x180DA1380
	public static TMP_SubMesh AddSubTextObject(TextMeshPro textComponent, MaterialReference materialReference) { }

	// RVA: 0xDA1810 Offset: 0xD9FE10 VA: 0x180DA1810
	public void DestroySelf() { }

	// RVA: 0xDA1880 Offset: 0xD9FE80 VA: 0x180DA1880
	private Material GetMaterial(Material mat) { }

	// RVA: 0xDA1760 Offset: 0xD9FD60 VA: 0x180DA1760
	private Material CreateMaterialInstance(Material source) { }

	// RVA: 0xDA1AF0 Offset: 0xDA00F0 VA: 0x180DA1AF0
	private Material GetSharedMaterial() { }

	// RVA: 0xDA20A0 Offset: 0xDA06A0 VA: 0x180DA20A0
	private void SetSharedMaterial(Material mat) { }

	// RVA: 0xDA1A60 Offset: 0xDA0060 VA: 0x180DA1A60
	public float GetPaddingForMaterial() { }

	// RVA: 0xDA21B0 Offset: 0xDA07B0 VA: 0x180DA21B0
	public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold) { }

	// RVA: 0xDA20E0 Offset: 0xDA06E0 VA: 0x180DA20E0
	public void SetVerticesDirty() { }

	// RVA: 0xDA1F90 Offset: 0xDA0590 VA: 0x180DA1F90
	public void SetMaterialDirty() { }

	// RVA: 0xDA1F90 Offset: 0xDA0590 VA: 0x180DA1F90
	protected void UpdateMaterial() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class TMP_SubMeshUI : MaskableGraphic, IClippable, IMaskable, IMaterialModifier // TypeDefIndex: 6824
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TMP_FontAsset m_fontAsset; // 0xC8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Material m_material; // 0xD0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Material m_sharedMaterial; // 0xD8
	private Material m_fallbackMaterial; // 0xE0
	private Material m_fallbackSourceMaterial; // 0xE8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_isDefaultMaterial; // 0xF0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_padding; // 0xF4
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private CanvasRenderer m_canvasRenderer; // 0xF8
	private Mesh m_mesh; // 0x100
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TextMeshProUGUI m_TextComponent; // 0x108
	private bool m_isRegisteredForEvents; // 0x110
	private bool m_materialDirty; // 0x111
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int m_materialReferenceIndex; // 0x114

	// Properties
	public TMP_FontAsset fontAsset { get; set; }
	public override Texture mainTexture { get; }
	public override Material material { get; set; }
	public Material sharedMaterial { get; set; }
	public Material fallbackMaterial { get; set; }
	public Material fallbackSourceMaterial { get; set; }
	public override Material materialForRendering { get; }
	public bool isDefaultMaterial { get; set; }
	public float padding { get; set; }
	public CanvasRenderer canvasRenderer { get; }
	public Mesh mesh { get; set; }

	// Methods

	// RVA: 0xDA0E50 Offset: 0xD9F450 VA: 0x180DA0E50
	public TMP_FontAsset get_fontAsset() { }

	// RVA: 0xDA1230 Offset: 0xD9F830 VA: 0x180DA1230
	public void set_fontAsset(TMP_FontAsset value) { }

	// RVA: 0xDA0E70 Offset: 0xD9F470 VA: 0x180DA0E70 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0xDA0FB0 Offset: 0xD9F5B0 VA: 0x180DA0FB0 Slot: 32
	public override Material get_material() { }

	// RVA: 0xDA1250 Offset: 0xD9F850 VA: 0x180DA1250 Slot: 33
	public override void set_material(Material value) { }

	// RVA: 0xDA01E0 Offset: 0xD9E7E0 VA: 0x180DA01E0
	public Material get_sharedMaterial() { }

	// RVA: 0xDA0A20 Offset: 0xD9F020 VA: 0x180DA0A20
	public void set_sharedMaterial(Material value) { }

	// RVA: 0x4EF330 Offset: 0x4ED930 VA: 0x1804EF330
	public Material get_fallbackMaterial() { }

	// RVA: 0xDA1090 Offset: 0xD9F690 VA: 0x180DA1090
	public void set_fallbackMaterial(Material value) { }

	// RVA: 0x88D970 Offset: 0x88BF70 VA: 0x18088D970
	public Material get_fallbackSourceMaterial() { }

	// RVA: 0x88D9F0 Offset: 0x88BFF0 VA: 0x18088D9F0
	public void set_fallbackSourceMaterial(Material value) { }

	// RVA: 0xDA0F40 Offset: 0xD9F540 VA: 0x180DA0F40 Slot: 34
	public override Material get_materialForRendering() { }

	// RVA: 0xDA0E60 Offset: 0xD9F460 VA: 0x180DA0E60
	public bool get_isDefaultMaterial() { }

	// RVA: 0xDA1240 Offset: 0xD9F840 VA: 0x180DA1240
	public void set_isDefaultMaterial(bool value) { }

	// RVA: 0xDA1080 Offset: 0xD9F680 VA: 0x180DA1080
	public float get_padding() { }

	// RVA: 0xDA1370 Offset: 0xD9F970 VA: 0x180DA1370
	public void set_padding(float value) { }

	// RVA: 0xDA0DB0 Offset: 0xD9F3B0 VA: 0x180DA0DB0
	public CanvasRenderer get_canvasRenderer() { }

	// RVA: 0xDA0FC0 Offset: 0xD9F5C0 VA: 0x180DA0FC0
	public Mesh get_mesh() { }

	// RVA: 0xA2B3D0 Offset: 0xA299D0 VA: 0x180A2B3D0
	public void set_mesh(Mesh value) { }

	// RVA: 0xD9FB80 Offset: 0xD9E180 VA: 0x180D9FB80
	public static TMP_SubMeshUI AddSubTextObject(TextMeshProUGUI textComponent, MaterialReference materialReference) { }

	// RVA: 0xDA0820 Offset: 0xD9EE20 VA: 0x180DA0820 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0xDA06D0 Offset: 0xD9ECD0 VA: 0x180DA06D0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0xDA0530 Offset: 0xD9EB30 VA: 0x180DA0530 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0xDA0870 Offset: 0xD9EE70 VA: 0x180DA0870 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0xDA01F0 Offset: 0xD9E7F0 VA: 0x180DA01F0 Slot: 57
	public override Material GetModifiedMaterial(Material baseMaterial) { }

	// RVA: 0xDA0350 Offset: 0xD9E950 VA: 0x180DA0350
	public float GetPaddingForMaterial() { }

	// RVA: 0xDA03F0 Offset: 0xD9E9F0 VA: 0x180DA03F0
	public float GetPaddingForMaterial(Material mat) { }

	// RVA: 0xDA0D20 Offset: 0xD9F320 VA: 0x180DA0D20
	public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 26
	public override void SetAllDirty() { }

	// RVA: 0xDA0A90 Offset: 0xD9F090 VA: 0x180DA0A90 Slot: 28
	public override void SetVerticesDirty() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 27
	public override void SetLayoutDirty() { }

	// RVA: 0xDA0960 Offset: 0xD9EF60 VA: 0x180DA0960 Slot: 29
	public override void SetMaterialDirty() { }

	// RVA: 0xDA09A0 Offset: 0xD9EFA0 VA: 0x180DA09A0
	public void SetPivotDirty() { }

	// RVA: 0xD9FFE0 Offset: 0xD9E5E0 VA: 0x180D9FFE0 Slot: 58
	public override void Cull(Rect clipRect, bool validRect) { }

	// RVA: 0xDA0B70 Offset: 0xD9F170 VA: 0x180DA0B70 Slot: 41
	protected override void UpdateGeometry() { }

	// RVA: 0xDA08D0 Offset: 0xD9EED0 VA: 0x180DA08D0 Slot: 37
	public override void Rebuild(CanvasUpdate update) { }

	// RVA: 0xDA0940 Offset: 0xD9EF40 VA: 0x180DA0940
	public void RefreshMaterial() { }

	// RVA: 0xDA0BC0 Offset: 0xD9F1C0 VA: 0x180DA0BC0 Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0xDA0910 Offset: 0xD9EF10 VA: 0x180DA0910 Slot: 61
	public override void RecalculateClipping() { }

	// RVA: 0xDA0920 Offset: 0xD9EF20 VA: 0x180DA0920 Slot: 62
	public override void RecalculateMasking() { }

	// RVA: 0xDA01E0 Offset: 0xD9E7E0 VA: 0x180DA01E0
	private Material GetMaterial() { }

	// RVA: 0xDA0020 Offset: 0xD9E620 VA: 0x180DA0020
	private Material GetMaterial(Material mat) { }

	// RVA: 0xD9FF30 Offset: 0xD9E530 VA: 0x180D9FF30
	private Material CreateMaterialInstance(Material source) { }

	// RVA: 0xDA0480 Offset: 0xD9EA80 VA: 0x180DA0480
	private Material GetSharedMaterial() { }

	// RVA: 0xDA0A20 Offset: 0xD9F020 VA: 0x180DA0A20
	private void SetSharedMaterial(Material mat) { }

	// RVA: 0xD9F1C0 Offset: 0xD9D7C0 VA: 0x180D9F1C0
	public void .ctor() { }

}

public enum TMP_TextElementType // TypeDefIndex: 6830
{	// Fields
	public int value__; // 0x0
	public const TMP_TextElementType Character = 0;
	public const TMP_TextElementType Unused = 1;

}

public abstract class TMP_Text : MaskableGraphic // TypeDefIndex: 6837
{	// Fields
	[SerializeField] // RVA: 0xD0860 Offset: 0xCFC60 VA: 0x1800D0860
	[TextAreaAttribute] // RVA: 0xD0860 Offset: 0xCFC60 VA: 0x1800D0860
	protected string m_text; // 0xC8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected bool m_isRightToLeft; // 0xD0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected TMP_FontAsset m_fontAsset; // 0xD8
	protected TMP_FontAsset m_currentFontAsset; // 0xE0
	protected bool m_isSDFShader; // 0xE8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected Material m_sharedMaterial; // 0xF0
	protected Material m_currentMaterial; // 0xF8
	protected MaterialReference[] m_materialReferences; // 0x100
	protected Dictionary<int, int> m_materialReferenceIndexLookup; // 0x108
	protected TMP_RichTextTagStack<MaterialReference> m_materialReferenceStack; // 0x110
	protected int m_currentMaterialIndex; // 0x150
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected Material[] m_fontSharedMaterials; // 0x158
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected Material m_fontMaterial; // 0x160
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected Material[] m_fontMaterials; // 0x168
	protected bool m_isMaterialDirty; // 0x170
	[SerializeField] // RVA: 0xD70A0 Offset: 0xD64A0 VA: 0x1800D70A0
	[ColorUsageAttribute] // RVA: 0xD70A0 Offset: 0xD64A0 VA: 0x1800D70A0
	protected Color32 m_fontColor32; // 0x174
	[SerializeField] // RVA: 0xD70A0 Offset: 0xD64A0 VA: 0x1800D70A0
	[ColorUsageAttribute] // RVA: 0xD70A0 Offset: 0xD64A0 VA: 0x1800D70A0
	protected Color m_fontColor; // 0x178
	protected static Color32 s_colorWhite; // 0x0
	protected Color32 m_underlineColor; // 0x188
	protected Color32 m_strikethroughColor; // 0x18C
	protected Color32 m_highlightColor; // 0x190
	protected Vector4 m_highlightPadding; // 0x194
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected bool m_enableVertexGradient; // 0x1A4
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected ColorMode m_colorMode; // 0x1A8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected VertexGradient m_fontColorGradient; // 0x1AC
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected TMP_ColorGradient m_fontColorGradientPreset; // 0x1F0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected bool m_overrideHtmlColors; // 0x1F8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected Color32 m_faceColor; // 0x1FC
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected Color32 m_outlineColor; // 0x200
	protected float m_outlineWidth; // 0x204
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected float m_fontSize; // 0x208
	protected float m_currentFontSize; // 0x20C
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected float m_fontSizeBase; // 0x210
	protected TMP_RichTextTagStack<float> m_sizeStack; // 0x218
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected FontWeight m_fontWeight; // 0x230
	protected FontWeight m_FontWeightInternal; // 0x234
	protected TMP_RichTextTagStack<FontWeight> m_FontWeightStack; // 0x238
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected bool m_enableAutoSizing; // 0x250
	protected float m_maxFontSize; // 0x254
	protected float m_minFontSize; // 0x258
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected float m_fontSizeMin; // 0x25C
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected float m_fontSizeMax; // 0x260
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected FontStyles m_fontStyle; // 0x264
	protected FontStyles m_FontStyleInternal; // 0x268
	protected TMP_FontStyleStack m_fontStyleStack; // 0x26C
	protected bool m_isUsingBold; // 0x276
	[SerializeField] // RVA: 0xD8E70 Offset: 0xD8270 VA: 0x1800D8E70
	[FormerlySerializedAsAttribute] // RVA: 0xD8E70 Offset: 0xD8270 VA: 0x1800D8E70
	protected TextAlignmentOptions m_textAlignment; // 0x278
	protected TextAlignmentOptions m_lineJustification; // 0x27C
	protected TMP_RichTextTagStack<TextAlignmentOptions> m_lineJustificationStack; // 0x280
	protected Vector3[] m_textContainerLocalCorners; // 0x298
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected float m_characterSpacing; // 0x2A0
	protected float m_cSpacing; // 0x2A4
	protected float m_monoSpacing; // 0x2A8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected float m_wordSpacing; // 0x2AC
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected float m_lineSpacing; // 0x2B0
	protected float m_lineSpacingDelta; // 0x2B4
	protected float m_lineHeight; // 0x2B8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected float m_lineSpacingMax; // 0x2BC
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected float m_paragraphSpacing; // 0x2C0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected float m_charWidthMaxAdj; // 0x2C4
	protected float m_charWidthAdjDelta; // 0x2C8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected bool m_enableWordWrapping; // 0x2CC
	protected bool m_isCharacterWrappingEnabled; // 0x2CD
	protected bool m_isNonBreakingSpace; // 0x2CE
	protected bool m_isIgnoringAlignment; // 0x2CF
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected float m_wordWrappingRatios; // 0x2D0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected TextOverflowModes m_overflowMode; // 0x2D4
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected int m_firstOverflowCharacterIndex; // 0x2D8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected TMP_Text m_linkedTextComponent; // 0x2E0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected bool m_isLinkedTextComponent; // 0x2E8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected bool m_isTextTruncated; // 0x2E9
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected bool m_enableKerning; // 0x2EA
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected bool m_enableExtraPadding; // 0x2EB
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected bool checkPaddingRequired; // 0x2EC
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected bool m_isRichText; // 0x2ED
	protected bool m_isOverlay; // 0x2EE
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected bool m_isOrthographic; // 0x2EF
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected bool m_isCullingEnabled; // 0x2F0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected bool m_ignoreRectMaskCulling; // 0x2F1
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected bool m_ignoreCulling; // 0x2F2
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected TextureMappingOptions m_horizontalMapping; // 0x2F4
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected TextureMappingOptions m_verticalMapping; // 0x2F8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected float m_uvLineOffset; // 0x2FC
	protected TextRenderFlags m_renderMode; // 0x300
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected VertexSortingOrder m_geometrySortingOrder; // 0x304
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected bool m_VertexBufferAutoSizeReduction; // 0x308
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected int m_firstVisibleCharacter; // 0x30C
	protected int m_maxVisibleCharacters; // 0x310
	protected int m_maxVisibleWords; // 0x314
	protected int m_maxVisibleLines; // 0x318
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected bool m_useMaxVisibleDescender; // 0x31C
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected int m_pageToDisplay; // 0x320
	protected bool m_isNewPage; // 0x324
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected Vector4 m_margin; // 0x328
	protected float m_marginLeft; // 0x338
	protected float m_marginRight; // 0x33C
	protected float m_marginWidth; // 0x340
	protected float m_marginHeight; // 0x344
	protected float m_width; // 0x348
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected TMP_TextInfo m_textInfo; // 0x350
	protected bool m_havePropertiesChanged; // 0x358
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected bool m_isUsingLegacyAnimationComponent; // 0x359
	protected Transform m_transform; // 0x360
	protected RectTransform m_rectTransform; // 0x368
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <autoSizeTextContainer>k__BackingField; // 0x370
	protected bool m_autoSizeTextContainer; // 0x371
	protected Mesh m_mesh; // 0x378
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected bool m_isVolumetricText; // 0x380
	protected float m_flexibleHeight; // 0x384
	protected float m_flexibleWidth; // 0x388
	protected float m_minWidth; // 0x38C
	protected float m_minHeight; // 0x390
	protected float m_maxWidth; // 0x394
	protected float m_maxHeight; // 0x398
	protected LayoutElement m_LayoutElement; // 0x3A0
	protected float m_preferredWidth; // 0x3A8
	protected float m_renderedWidth; // 0x3AC
	protected bool m_isPreferredWidthDirty; // 0x3B0
	protected float m_preferredHeight; // 0x3B4
	protected float m_renderedHeight; // 0x3B8
	protected bool m_isPreferredHeightDirty; // 0x3BC
	protected bool m_isCalculatingPreferredValues; // 0x3BD
	private int m_recursiveCount; // 0x3C0
	protected int m_layoutPriority; // 0x3C4
	protected bool m_isCalculateSizeRequired; // 0x3C8
	protected bool m_isLayoutDirty; // 0x3C9
	protected bool m_verticesAlreadyDirty; // 0x3CA
	protected bool m_layoutAlreadyDirty; // 0x3CB
	protected bool m_isAwake; // 0x3CC
	internal bool m_isWaitingOnResourceLoad; // 0x3CD
	internal bool m_isInputParsingRequired; // 0x3CE
	protected string old_text; // 0x3D0
	protected float m_fontScale; // 0x3D8
	protected float m_fontScaleMultiplier; // 0x3DC
	protected char[] m_htmlTag; // 0x3E0
	protected RichTextTagAttribute[] m_xmlAttribute; // 0x3E8
	protected float[] m_attributeParameterValues; // 0x3F0
	protected float tag_LineIndent; // 0x3F8
	protected float tag_Indent; // 0x3FC
	protected TMP_RichTextTagStack<float> m_indentStack; // 0x400
	protected bool tag_NoParsing; // 0x418
	protected bool m_isParsingText; // 0x419
	protected Matrix4x4 m_FXMatrix; // 0x41C
	protected bool m_isFXMatrixSet; // 0x45C
	protected TMP_Text.UnicodeChar[] m_TextParsingBuffer; // 0x460
	private TMP_CharacterInfo[] m_internalCharacterInfo; // 0x468
	protected int m_totalCharacterCount; // 0x470
	protected WordWrapState m_SavedWordWrapState; // 0x478
	protected WordWrapState m_SavedLineState; // 0x6F8
	protected int m_characterCount; // 0x978
	protected int m_firstCharacterOfLine; // 0x97C
	protected int m_firstVisibleCharacterOfLine; // 0x980
	protected int m_lastCharacterOfLine; // 0x984
	protected int m_lastVisibleCharacterOfLine; // 0x988
	protected int m_lineNumber; // 0x98C
	protected int m_lineVisibleCharacterCount; // 0x990
	protected int m_pageNumber; // 0x994
	protected float m_maxAscender; // 0x998
	protected float m_maxCapHeight; // 0x99C
	protected float m_maxDescender; // 0x9A0
	protected float m_maxLineAscender; // 0x9A4
	protected float m_maxLineDescender; // 0x9A8
	protected float m_startOfLineAscender; // 0x9AC
	protected float m_lineOffset; // 0x9B0
	protected Extents m_meshExtents; // 0x9B4
	protected Color32 m_htmlColor; // 0x9C4
	protected TMP_RichTextTagStack<Color32> m_colorStack; // 0x9C8
	protected TMP_RichTextTagStack<Color32> m_underlineColorStack; // 0x9E0
	protected TMP_RichTextTagStack<Color32> m_strikethroughColorStack; // 0x9F8
	protected TMP_RichTextTagStack<Color32> m_highlightColorStack; // 0xA10
	protected TMP_ColorGradient m_colorGradientPreset; // 0xA28
	protected TMP_RichTextTagStack<TMP_ColorGradient> m_colorGradientStack; // 0xA30
	protected float m_tabSpacing; // 0xA48
	protected float m_spacing; // 0xA4C
	protected TMP_RichTextTagStack<int> m_styleStack; // 0xA50
	protected TMP_RichTextTagStack<int> m_actionStack; // 0xA68
	protected float m_padding; // 0xA80
	protected float m_baselineOffset; // 0xA84
	protected TMP_RichTextTagStack<float> m_baselineOffsetStack; // 0xA88
	protected float m_xAdvance; // 0xAA0
	protected TMP_TextElementType m_textElementType; // 0xAA4
	protected TMP_TextElement m_cached_TextElement; // 0xAA8
	protected TMP_Character m_cached_Underline_Character; // 0xAB0
	protected TMP_Character m_cached_Ellipsis_Character; // 0xAB8
	protected int m_spriteCount; // 0xAC0
	protected int m_spriteIndex; // 0xAC4
	protected int m_spriteAnimationID; // 0xAC8
	protected bool m_ignoreActiveState; // 0xACC
	protected static Vector2 k_LargePositiveVector2; // 0x4
	protected static Vector2 k_LargeNegativeVector2; // 0xC
	protected static float k_LargePositiveFloat; // 0x14
	protected static float k_LargeNegativeFloat; // 0x18
	protected static int k_LargePositiveInt; // 0x1C
	protected static int k_LargeNegativeInt; // 0x20

	// Properties
	public string text { get; set; }
	public bool isRightToLeftText { get; set; }
	public TMP_FontAsset font { get; set; }
	public virtual Material fontSharedMaterial { get; set; }
	public virtual Material[] fontSharedMaterials { get; set; }
	public Material fontMaterial { get; set; }
	public virtual Material[] fontMaterials { get; set; }
	public override Color color { get; set; }
	public float alpha { get; set; }
	public bool enableVertexGradient { get; set; }
	public VertexGradient colorGradient { get; set; }
	public TMP_ColorGradient colorGradientPreset { get; set; }
	public bool overrideColorTags { get; set; }
	public Color32 faceColor { get; set; }
	public Color32 outlineColor { get; set; }
	public float outlineWidth { get; set; }
	public float fontSize { get; set; }
	public float fontScale { get; }
	public FontWeight fontWeight { get; set; }
	public float pixelsPerUnit { get; }
	public bool enableAutoSizing { get; set; }
	public float fontSizeMin { get; set; }
	public float fontSizeMax { get; set; }
	public FontStyles fontStyle { get; set; }
	public bool isUsingBold { get; }
	public TextAlignmentOptions alignment { get; set; }
	public float characterSpacing { get; set; }
	public float wordSpacing { get; set; }
	public float lineSpacing { get; set; }
	public float lineSpacingAdjustment { get; set; }
	public float paragraphSpacing { get; set; }
	public float characterWidthAdjustment { get; set; }
	public bool enableWordWrapping { get; set; }
	public float wordWrappingRatios { get; set; }
	public TextOverflowModes overflowMode { get; set; }
	public bool isTextOverflowing { get; }
	public int firstOverflowCharacterIndex { get; }
	public TMP_Text linkedTextComponent { get; set; }
	public bool isLinkedTextComponent { get; set; }
	public bool isTextTruncated { get; }
	public bool enableKerning { get; set; }
	public bool extraPadding { get; set; }
	public bool richText { get; set; }
	public bool isOverlay { get; set; }
	public bool isOrthographic { get; set; }
	public bool enableCulling { get; set; }
	public bool ignoreRectMaskCulling { get; set; }
	public bool ignoreVisibility { get; set; }
	public TextureMappingOptions horizontalMapping { get; set; }
	public TextureMappingOptions verticalMapping { get; set; }
	public float mappingUvLineOffset { get; set; }
	public TextRenderFlags renderMode { get; set; }
	public VertexSortingOrder geometrySortingOrder { get; set; }
	public bool vertexBufferAutoSizeReduction { get; set; }
	public int firstVisibleCharacter { get; set; }
	public int maxVisibleCharacters { get; set; }
	public int maxVisibleWords { get; set; }
	public int maxVisibleLines { get; set; }
	public bool useMaxVisibleDescender { get; set; }
	public int pageToDisplay { get; set; }
	public virtual Vector4 margin { get; set; }
	public TMP_TextInfo textInfo { get; }
	public bool havePropertiesChanged { get; set; }
	public bool isUsingLegacyAnimationComponent { get; set; }
	public Transform transform { get; }
	public RectTransform rectTransform { get; }
	public virtual bool autoSizeTextContainer { get; set; }
	public virtual Mesh mesh { get; }
	public bool isVolumetricText { get; set; }
	public Bounds bounds { get; }
	public Bounds textBounds { get; }
	public float flexibleHeight { get; }
	public float flexibleWidth { get; }
	public float minWidth { get; }
	public float minHeight { get; }
	public float maxWidth { get; }
	public float maxHeight { get; }
	protected LayoutElement layoutElement { get; }
	public virtual float preferredWidth { get; }
	public virtual float preferredHeight { get; }
	public virtual float renderedWidth { get; }
	public virtual float renderedHeight { get; }
	public int layoutPriority { get; }

	// Methods

	// RVA: 0xDA0E50 Offset: 0xD9F450 VA: 0x180DA0E50
	public string get_text() { }

	// RVA: 0xDB6520 Offset: 0xDB4B20 VA: 0x180DB6520
	public void set_text(string value) { }

	// RVA: 0xDB49E0 Offset: 0xDB2FE0 VA: 0x180DB49E0
	public bool get_isRightToLeftText() { }

	// RVA: 0xDB5D50 Offset: 0xDB4350 VA: 0x180DB5D50
	public void set_isRightToLeftText(bool value) { }

	// RVA: 0xDA01E0 Offset: 0xD9E7E0 VA: 0x180DA01E0
	public TMP_FontAsset get_font() { }

	// RVA: 0xDB5AC0 Offset: 0xDB40C0 VA: 0x180DB5AC0
	public void set_font(TMP_FontAsset value) { }

	// RVA: 0xC742E0 Offset: 0xC728E0 VA: 0x180C742E0 Slot: 63
	public virtual Material get_fontSharedMaterial() { }

	// RVA: 0xDB5820 Offset: 0xDB3E20 VA: 0x180DB5820 Slot: 64
	public virtual void set_fontSharedMaterial(Material value) { }

	// RVA: 0xDB4910 Offset: 0xDB2F10 VA: 0x180DB4910 Slot: 65
	public virtual Material[] get_fontSharedMaterials() { }

	// RVA: 0xDB57C0 Offset: 0xDB3DC0 VA: 0x180DB57C0 Slot: 66
	public virtual void set_fontSharedMaterials(Material[] value) { }

	// RVA: 0xDB48C0 Offset: 0xDB2EC0 VA: 0x180DB48C0
	public Material get_fontMaterial() { }

	// RVA: 0xDB56A0 Offset: 0xDB3CA0 VA: 0x180DB56A0
	public void set_fontMaterial(Material value) { }

	// RVA: 0xDB48E0 Offset: 0xDB2EE0 VA: 0x180DB48E0 Slot: 67
	public virtual Material[] get_fontMaterials() { }

	// RVA: 0xDB57C0 Offset: 0xDB3DC0 VA: 0x180DB57C0 Slot: 68
	public virtual void set_fontMaterials(Material[] value) { }

	// RVA: 0xDB4720 Offset: 0xDB2D20 VA: 0x180DB4720 Slot: 22
	public override Color get_color() { }

	// RVA: 0xDB53B0 Offset: 0xDB39B0 VA: 0x180DB53B0 Slot: 23
	public override void set_color(Color value) { }

	// RVA: 0xDB45D0 Offset: 0xDB2BD0 VA: 0x180DB45D0
	public float get_alpha() { }

	// RVA: 0xDB5220 Offset: 0xDB3820 VA: 0x180DB5220
	public void set_alpha(float value) { }

	// RVA: 0xDB4760 Offset: 0xDB2D60 VA: 0x180DB4760
	public bool get_enableVertexGradient() { }

	// RVA: 0xDB5510 Offset: 0xDB3B10 VA: 0x180DB5510
	public void set_enableVertexGradient(bool value) { }

	// RVA: 0xDB46F0 Offset: 0xDB2CF0 VA: 0x180DB46F0
	public VertexGradient get_colorGradient() { }

	// RVA: 0xDB5360 Offset: 0xDB3960 VA: 0x180DB5360
	public void set_colorGradient(VertexGradient value) { }

	// RVA: 0xDB46E0 Offset: 0xDB2CE0 VA: 0x180DB46E0
	public TMP_ColorGradient get_colorGradientPreset() { }

	// RVA: 0xDB5320 Offset: 0xDB3920 VA: 0x180DB5320
	public void set_colorGradientPreset(TMP_ColorGradient value) { }

	// RVA: 0xDB4D30 Offset: 0xDB3330 VA: 0x180DB4D30
	public bool get_overrideColorTags() { }

	// RVA: 0xDB63E0 Offset: 0xDB49E0 VA: 0x180DB63E0
	public void set_overrideColorTags(bool value) { }

	// RVA: 0xDB4790 Offset: 0xDB2D90 VA: 0x180DB4790
	public Color32 get_faceColor() { }

	// RVA: 0xDB55F0 Offset: 0xDB3BF0 VA: 0x180DB55F0
	public void set_faceColor(Color32 value) { }

	// RVA: 0xDB4B50 Offset: 0xDB3150 VA: 0x180DB4B50
	public Color32 get_outlineColor() { }

	// RVA: 0xDB62B0 Offset: 0xDB48B0 VA: 0x180DB62B0
	public void set_outlineColor(Color32 value) { }

	// RVA: 0xDB4C40 Offset: 0xDB3240 VA: 0x180DB4C40
	public float get_outlineWidth() { }

	// RVA: 0xDB6320 Offset: 0xDB4920 VA: 0x180DB6320
	public void set_outlineWidth(float value) { }

	// RVA: 0xDB4940 Offset: 0xDB2F40 VA: 0x180DB4940
	public float get_fontSize() { }

	// RVA: 0xDB5990 Offset: 0xDB3F90 VA: 0x180DB5990
	public void set_fontSize(float value) { }

	// RVA: 0xDB4900 Offset: 0xDB2F00 VA: 0x180DB4900
	public float get_fontScale() { }

	// RVA: 0xDB4960 Offset: 0xDB2F60 VA: 0x180DB4960
	public FontWeight get_fontWeight() { }

	// RVA: 0xDB5A60 Offset: 0xDB4060 VA: 0x180DB5A60
	public void set_fontWeight(FontWeight value) { }

	// RVA: 0xDB4D60 Offset: 0xDB3360 VA: 0x180DB4D60
	public float get_pixelsPerUnit() { }

	// RVA: 0xDB4730 Offset: 0xDB2D30 VA: 0x180DB4730
	public bool get_enableAutoSizing() { }

	// RVA: 0xDB5420 Offset: 0xDB3A20 VA: 0x180DB5420
	public void set_enableAutoSizing(bool value) { }

	// RVA: 0xDB4930 Offset: 0xDB2F30 VA: 0x180DB4930
	public float get_fontSizeMin() { }

	// RVA: 0xDB5940 Offset: 0xDB3F40 VA: 0x180DB5940
	public void set_fontSizeMin(float value) { }

	// RVA: 0x8F9BC0 Offset: 0x8F81C0 VA: 0x1808F9BC0
	public float get_fontSizeMax() { }

	// RVA: 0xDB58F0 Offset: 0xDB3EF0 VA: 0x180DB58F0
	public void set_fontSizeMax(float value) { }

	// RVA: 0xDB4950 Offset: 0xDB2F50 VA: 0x180DB4950
	public FontStyles get_fontStyle() { }

	// RVA: 0xDB5A00 Offset: 0xDB4000 VA: 0x180DB5A00
	public void set_fontStyle(FontStyles value) { }

	// RVA: 0xDB4A10 Offset: 0xDB3010 VA: 0x180DB4A10
	public bool get_isUsingBold() { }

	// RVA: 0xDB45C0 Offset: 0xDB2BC0 VA: 0x180DB45C0
	public TextAlignmentOptions get_alignment() { }

	// RVA: 0xDB51F0 Offset: 0xDB37F0 VA: 0x180DB51F0
	public void set_alignment(TextAlignmentOptions value) { }

	// RVA: 0xDB46C0 Offset: 0xDB2CC0 VA: 0x180DB46C0
	public float get_characterSpacing() { }

	// RVA: 0xDB5260 Offset: 0xDB3860 VA: 0x180DB5260
	public void set_characterSpacing(float value) { }

	// RVA: 0xDB51D0 Offset: 0xDB37D0 VA: 0x180DB51D0
	public float get_wordSpacing() { }

	// RVA: 0xDB6640 Offset: 0xDB4C40 VA: 0x180DB6640
	public void set_wordSpacing(float value) { }

	// RVA: 0xDB4B00 Offset: 0xDB3100 VA: 0x180DB4B00
	public float get_lineSpacing() { }

	// RVA: 0xDB5E90 Offset: 0xDB4490 VA: 0x180DB5E90
	public void set_lineSpacing(float value) { }

	// RVA: 0xDB4AF0 Offset: 0xDB30F0 VA: 0x180DB4AF0
	public float get_lineSpacingAdjustment() { }

	// RVA: 0xDB5E30 Offset: 0xDB4430 VA: 0x180DB5E30
	public void set_lineSpacingAdjustment(float value) { }

	// RVA: 0xDB4D50 Offset: 0xDB3350 VA: 0x180DB4D50
	public float get_paragraphSpacing() { }

	// RVA: 0xDB6440 Offset: 0xDB4A40 VA: 0x180DB6440
	public void set_paragraphSpacing(float value) { }

	// RVA: 0xDB46D0 Offset: 0xDB2CD0 VA: 0x180DB46D0
	public float get_characterWidthAdjustment() { }

	// RVA: 0xDB52C0 Offset: 0xDB38C0 VA: 0x180DB52C0
	public void set_characterWidthAdjustment(float value) { }

	// RVA: 0xDB4770 Offset: 0xDB2D70 VA: 0x180DB4770
	public bool get_enableWordWrapping() { }

	// RVA: 0xDB5540 Offset: 0xDB3B40 VA: 0x180DB5540
	public void set_enableWordWrapping(bool value) { }

	// RVA: 0xDB51E0 Offset: 0xDB37E0 VA: 0x180DB51E0
	public float get_wordWrappingRatios() { }

	// RVA: 0xDB66A0 Offset: 0xDB4CA0 VA: 0x180DB66A0
	public void set_wordWrappingRatios(float value) { }

	// RVA: 0xDB4D20 Offset: 0xDB3320 VA: 0x180DB4D20
	public TextOverflowModes get_overflowMode() { }

	// RVA: 0xDB6380 Offset: 0xDB4980 VA: 0x180DB6380
	public void set_overflowMode(TextOverflowModes value) { }

	// RVA: 0xDB49F0 Offset: 0xDB2FF0 VA: 0x180DB49F0
	public bool get_isTextOverflowing() { }

	// RVA: 0xDB4880 Offset: 0xDB2E80 VA: 0x180DB4880
	public int get_firstOverflowCharacterIndex() { }

	// RVA: 0x9A0600 Offset: 0x99EC00 VA: 0x1809A0600
	public TMP_Text get_linkedTextComponent() { }

	// RVA: 0xDB5EF0 Offset: 0xDB44F0 VA: 0x180DB5EF0
	public void set_linkedTextComponent(TMP_Text value) { }

	// RVA: 0xDB49B0 Offset: 0xDB2FB0 VA: 0x180DB49B0
	public bool get_isLinkedTextComponent() { }

	// RVA: 0xDB5C70 Offset: 0xDB4270 VA: 0x180DB5C70
	public void set_isLinkedTextComponent(bool value) { }

	// RVA: 0xDB4A00 Offset: 0xDB3000 VA: 0x180DB4A00
	public bool get_isTextTruncated() { }

	// RVA: 0xDB4750 Offset: 0xDB2D50 VA: 0x180DB4750
	public bool get_enableKerning() { }

	// RVA: 0xDB54B0 Offset: 0xDB3AB0 VA: 0x180DB54B0
	public void set_enableKerning(bool value) { }

	// RVA: 0xDB4780 Offset: 0xDB2D80 VA: 0x180DB4780
	public bool get_extraPadding() { }

	// RVA: 0xDB55A0 Offset: 0xDB3BA0 VA: 0x180DB55A0
	public void set_extraPadding(bool value) { }

	// RVA: 0xDB5090 Offset: 0xDB3690 VA: 0x180DB5090
	public bool get_richText() { }

	// RVA: 0xDB64C0 Offset: 0xDB4AC0 VA: 0x180DB64C0
	public void set_richText(bool value) { }

	// RVA: 0xDB49D0 Offset: 0xDB2FD0 VA: 0x180DB49D0
	public bool get_isOverlay() { }

	// RVA: 0xDB5D00 Offset: 0xDB4300 VA: 0x180DB5D00
	public void set_isOverlay(bool value) { }

	// RVA: 0xDB49C0 Offset: 0xDB2FC0 VA: 0x180DB49C0
	public bool get_isOrthographic() { }

	// RVA: 0xDB5CD0 Offset: 0xDB42D0 VA: 0x180DB5CD0
	public void set_isOrthographic(bool value) { }

	// RVA: 0xDB4740 Offset: 0xDB2D40 VA: 0x180DB4740
	public bool get_enableCulling() { }

	// RVA: 0xDB5470 Offset: 0xDB3A70 VA: 0x180DB5470
	public void set_enableCulling(bool value) { }

	// RVA: 0xDB4990 Offset: 0xDB2F90 VA: 0x180DB4990
	public bool get_ignoreRectMaskCulling() { }

	// RVA: 0xDB5C30 Offset: 0xDB4230 VA: 0x180DB5C30
	public void set_ignoreRectMaskCulling(bool value) { }

	// RVA: 0xDB49A0 Offset: 0xDB2FA0 VA: 0x180DB49A0
	public bool get_ignoreVisibility() { }

	// RVA: 0xDB5C50 Offset: 0xDB4250 VA: 0x180DB5C50
	public void set_ignoreVisibility(bool value) { }

	// RVA: 0x838A00 Offset: 0x837000 VA: 0x180838A00
	public TextureMappingOptions get_horizontalMapping() { }

	// RVA: 0xDB5C00 Offset: 0xDB4200 VA: 0x180DB5C00
	public void set_horizontalMapping(TextureMappingOptions value) { }

	// RVA: 0x8389F0 Offset: 0x836FF0 VA: 0x1808389F0
	public TextureMappingOptions get_verticalMapping() { }

	// RVA: 0xDB6610 Offset: 0xDB4C10 VA: 0x180DB6610
	public void set_verticalMapping(TextureMappingOptions value) { }

	// RVA: 0xDB4B10 Offset: 0xDB3110 VA: 0x180DB4B10
	public float get_mappingUvLineOffset() { }

	// RVA: 0xDB6130 Offset: 0xDB4730 VA: 0x180DB6130
	public void set_mappingUvLineOffset(float value) { }

	// RVA: 0xAC5E00 Offset: 0xAC4400 VA: 0x180AC5E00
	public TextRenderFlags get_renderMode() { }

	// RVA: 0xDB64A0 Offset: 0xDB4AA0 VA: 0x180DB64A0
	public void set_renderMode(TextRenderFlags value) { }

	// RVA: 0xDB4970 Offset: 0xDB2F70 VA: 0x180DB4970
	public VertexSortingOrder get_geometrySortingOrder() { }

	// RVA: 0xDB5BB0 Offset: 0xDB41B0 VA: 0x180DB5BB0
	public void set_geometrySortingOrder(VertexSortingOrder value) { }

	// RVA: 0xDB51C0 Offset: 0xDB37C0 VA: 0x180DB51C0
	public bool get_vertexBufferAutoSizeReduction() { }

	// RVA: 0xDB65F0 Offset: 0xDB4BF0 VA: 0x180DB65F0
	public void set_vertexBufferAutoSizeReduction(bool value) { }

	// RVA: 0xDB4890 Offset: 0xDB2E90 VA: 0x180DB4890
	public int get_firstVisibleCharacter() { }

	// RVA: 0xDB5670 Offset: 0xDB3C70 VA: 0x180DB5670
	public void set_firstVisibleCharacter(int value) { }

	// RVA: 0xDB4B30 Offset: 0xDB3130 VA: 0x180DB4B30
	public int get_maxVisibleCharacters() { }

	// RVA: 0xDB6220 Offset: 0xDB4820 VA: 0x180DB6220
	public void set_maxVisibleCharacters(int value) { }

	// RVA: 0xA4B680 Offset: 0xA49C80 VA: 0x180A4B680
	public int get_maxVisibleWords() { }

	// RVA: 0xDB6280 Offset: 0xDB4880 VA: 0x180DB6280
	public void set_maxVisibleWords(int value) { }

	// RVA: 0xDB4B40 Offset: 0xDB3140 VA: 0x180DB4B40
	public int get_maxVisibleLines() { }

	// RVA: 0xDB6250 Offset: 0xDB4850 VA: 0x180DB6250
	public void set_maxVisibleLines(int value) { }

	// RVA: 0xDB51B0 Offset: 0xDB37B0 VA: 0x180DB51B0
	public bool get_useMaxVisibleDescender() { }

	// RVA: 0xDB65C0 Offset: 0xDB4BC0 VA: 0x180DB65C0
	public void set_useMaxVisibleDescender(bool value) { }

	// RVA: 0xDB4D40 Offset: 0xDB3340 VA: 0x180DB4D40
	public int get_pageToDisplay() { }

	// RVA: 0xDB6410 Offset: 0xDB4A10 VA: 0x180DB6410
	public void set_pageToDisplay(int value) { }

	// RVA: 0xDB4B20 Offset: 0xDB3120 VA: 0x180DB4B20 Slot: 69
	public virtual Vector4 get_margin() { }

	// RVA: 0xDB6160 Offset: 0xDB4760 VA: 0x180DB6160 Slot: 70
	public virtual void set_margin(Vector4 value) { }

	// RVA: 0xDB5100 Offset: 0xDB3700 VA: 0x180DB5100
	public TMP_TextInfo get_textInfo() { }

	// RVA: 0xDB4980 Offset: 0xDB2F80 VA: 0x180DB4980
	public bool get_havePropertiesChanged() { }

	// RVA: 0xDB5BD0 Offset: 0xDB41D0 VA: 0x180DB5BD0
	public void set_havePropertiesChanged(bool value) { }

	// RVA: 0xDB4A20 Offset: 0xDB3020 VA: 0x180DB4A20
	public bool get_isUsingLegacyAnimationComponent() { }

	// RVA: 0xDB5DB0 Offset: 0xDB43B0 VA: 0x180DB5DB0
	public void set_isUsingLegacyAnimationComponent(bool value) { }

	// RVA: 0xDB5110 Offset: 0xDB3710 VA: 0x180DB5110
	public Transform get_transform() { }

	// RVA: 0xDB4FF0 Offset: 0xDB35F0 VA: 0x180DB4FF0
	public RectTransform get_rectTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDB45E0 Offset: 0xDB2BE0 VA: 0x180DB45E0 Slot: 71
	public virtual bool get_autoSizeTextContainer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDB5250 Offset: 0xDB3850 VA: 0x180DB5250 Slot: 72
	public virtual void set_autoSizeTextContainer(bool value) { }

	// RVA: 0x7BBE40 Offset: 0x7BA440 VA: 0x1807BBE40 Slot: 73
	public virtual Mesh get_mesh() { }

	// RVA: 0xDB4A30 Offset: 0xDB3030 VA: 0x180DB4A30
	public bool get_isVolumetricText() { }

	// RVA: 0xDB5DC0 Offset: 0xDB43C0 VA: 0x180DB5DC0
	public void set_isVolumetricText(bool value) { }

	// RVA: 0xDB45F0 Offset: 0xDB2BF0 VA: 0x180DB45F0
	public Bounds get_bounds() { }

	// RVA: 0xDB50A0 Offset: 0xDB36A0 VA: 0x180DB50A0
	public Bounds get_textBounds() { }

	// RVA: 0xDB48A0 Offset: 0xDB2EA0 VA: 0x180DB48A0 Slot: 74
	public float get_flexibleHeight() { }

	// RVA: 0xDB48B0 Offset: 0xDB2EB0 VA: 0x180DB48B0 Slot: 75
	public float get_flexibleWidth() { }

	// RVA: 0x72FF80 Offset: 0x72E580 VA: 0x18072FF80 Slot: 76
	public float get_minWidth() { }

	// RVA: 0x7302A0 Offset: 0x72E8A0 VA: 0x1807302A0 Slot: 77
	public float get_minHeight() { }

	// RVA: 0x7300D0 Offset: 0x72E6D0 VA: 0x1807300D0
	public float get_maxWidth() { }

	// RVA: 0x7303E0 Offset: 0x72E9E0 VA: 0x1807303E0
	public float get_maxHeight() { }

	// RVA: 0xDB4A40 Offset: 0xDB3040 VA: 0x180DB4A40
	protected LayoutElement get_layoutElement() { }

	// RVA: 0xDB4FB0 Offset: 0xDB35B0 VA: 0x180DB4FB0 Slot: 78
	public virtual float get_preferredWidth() { }

	// RVA: 0xDB4F70 Offset: 0xDB3570 VA: 0x180DB4F70 Slot: 79
	public virtual float get_preferredHeight() { }

	// RVA: 0xDA9CA0 Offset: 0xDA82A0 VA: 0x180DA9CA0 Slot: 80
	public virtual float get_renderedWidth() { }

	// RVA: 0xDA9B10 Offset: 0xDA8110 VA: 0x180DA9B10 Slot: 81
	public virtual float get_renderedHeight() { }

	// RVA: 0xDB4AE0 Offset: 0xDB30E0 VA: 0x180DB4AE0 Slot: 82
	public int get_layoutPriority() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 83
	protected virtual void LoadFontAsset() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 84
	protected virtual void SetSharedMaterial(Material mat) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 85
	protected virtual Material GetMaterial(Material mat) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 86
	protected virtual void SetFontBaseMaterial(Material mat) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 87
	protected virtual Material[] GetSharedMaterials() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 88
	protected virtual void SetSharedMaterials(Material[] materials) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 89
	protected virtual Material[] GetMaterials(Material[] mats) { }

	// RVA: 0xDA4E80 Offset: 0xDA3480 VA: 0x180DA4E80 Slot: 90
	protected virtual Material CreateMaterialInstance(Material source) { }

	// RVA: 0xDAE110 Offset: 0xDAC710 VA: 0x180DAE110
	protected void SetVertexColorGradient(TMP_ColorGradient gradient) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	protected void SetTextSortingOrder(VertexSortingOrder order) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	protected void SetTextSortingOrder(int[] order) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 91
	protected virtual void SetFaceColor(Color32 color) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 92
	protected virtual void SetOutlineColor(Color32 color) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 93
	protected virtual void SetOutlineThickness(float thickness) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 94
	protected virtual void SetShaderDepth() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 95
	protected virtual void SetCulling() { }

	// RVA: 0x568670 Offset: 0x566C70 VA: 0x180568670 Slot: 96
	protected virtual float GetPaddingForMaterial() { }

	// RVA: 0x568670 Offset: 0x566C70 VA: 0x180568670 Slot: 97
	protected virtual float GetPaddingForMaterial(Material mat) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 98
	protected virtual Vector3[] GetTextContainerLocalCorners() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 99
	public virtual void ForceMeshUpdate() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 100
	public virtual void ForceMeshUpdate(bool ignoreActiveState) { }

	// RVA: 0xDAE0C0 Offset: 0xDAC6C0 VA: 0x180DAE0C0
	internal void SetTextInternal(string text) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 101
	public virtual void UpdateGeometry(Mesh mesh, int index) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 102
	public virtual void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 103
	public virtual void UpdateVertexData() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 104
	public virtual void SetVertices(Vector3[] vertices) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 105
	public virtual void UpdateMeshPadding() { }

	// RVA: 0xDA4FA0 Offset: 0xDA35A0 VA: 0x180DA4FA0 Slot: 47
	public override void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0xDA4F30 Offset: 0xDA3530 VA: 0x180DA4F30 Slot: 49
	public override void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 106
	protected virtual void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 107
	protected virtual void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0xDAC4B0 Offset: 0xDAAAB0 VA: 0x180DAC4B0
	protected void ParseInputText() { }

	// RVA: 0xDAE550 Offset: 0xDACB50 VA: 0x180DAE550
	protected void StringToCharArray(string sourceText, ref TMP_Text.UnicodeChar[] charBuffer) { }

	// RVA: 0xDAE1C0 Offset: 0xDAC7C0 VA: 0x180DAE1C0
	protected void StringBuilderToIntArray(StringBuilder sourceText, ref TMP_Text.UnicodeChar[] charBuffer) { }

	// RVA: 0xDAC000 Offset: 0xDAA600 VA: 0x180DAC000
	private bool IsTagName(ref string text, string tag, int index) { }

	// RVA: 0xDABE00 Offset: 0xDAA400 VA: 0x180DABE00
	private bool IsTagName(ref char[] text, string tag, int index) { }

	// RVA: 0xDABF00 Offset: 0xDAA500 VA: 0x180DABF00
	private bool IsTagName(ref int[] text, string tag, int index) { }

	// RVA: 0xDAC0F0 Offset: 0xDAA6F0 VA: 0x180DAC0F0
	private bool IsTagName(ref StringBuilder text, string tag, int index) { }

	// RVA: 0xDAA070 Offset: 0xDA8670 VA: 0x180DAA070
	private int GetTagHashCode(ref string text, int index, out int closeIndex) { }

	// RVA: 0xDAA120 Offset: 0xDA8720 VA: 0x180DAA120
	private int GetTagHashCode(ref char[] text, int index, out int closeIndex) { }

	// RVA: 0xDAA190 Offset: 0xDA8790 VA: 0x180DAA190
	private int GetTagHashCode(ref int[] text, int index, out int closeIndex) { }

	// RVA: 0xDA9FA0 Offset: 0xDA85A0 VA: 0x180DA9FA0
	private int GetTagHashCode(ref StringBuilder text, int index, out int closeIndex) { }

	// RVA: -1 Offset: -1
	private void ResizeInternalArray<T>(ref T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D41F0 Offset: 0x5D27F0 VA: 0x1805D41F0
	|-TMP_Text.ResizeInternalArray<object>
	|
	|-RVA: 0x5D4280 Offset: 0x5D2880 VA: 0x1805D4280
	|-TMP_Text.ResizeInternalArray<TMP_Text.UnicodeChar>
	*/

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 108
	protected virtual int SetArraySizes(TMP_Text.UnicodeChar[] chars) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 109
	protected virtual void GenerateTextMesh() { }

	// RVA: 0xDA9610 Offset: 0xDA7C10 VA: 0x180DA9610
	public Vector2 GetPreferredValues() { }

	// RVA: 0xDA97D0 Offset: 0xDA7DD0 VA: 0x180DA97D0
	public Vector2 GetPreferredValues(float width, float height) { }

	// RVA: 0xDA96C0 Offset: 0xDA7CC0 VA: 0x180DA96C0
	public Vector2 GetPreferredValues(string text) { }

	// RVA: 0xDA9540 Offset: 0xDA7B40 VA: 0x180DA9540
	public Vector2 GetPreferredValues(string text, float width, float height) { }

	// RVA: 0xDA9940 Offset: 0xDA7F40 VA: 0x180DA9940
	protected float GetPreferredWidth() { }

	// RVA: 0xDA98C0 Offset: 0xDA7EC0 VA: 0x180DA98C0
	protected float GetPreferredWidth(Vector2 margin) { }

	// RVA: 0xDA92C0 Offset: 0xDA78C0 VA: 0x180DA92C0
	protected float GetPreferredHeight() { }

	// RVA: 0xDA94C0 Offset: 0xDA7AC0 VA: 0x180DA94C0
	protected float GetPreferredHeight(Vector2 margin) { }

	// RVA: 0xDA9BF0 Offset: 0xDA81F0 VA: 0x180DA9BF0
	public Vector2 GetRenderedValues() { }

	// RVA: 0xDA9B30 Offset: 0xDA8130 VA: 0x180DA9B30
	public Vector2 GetRenderedValues(bool onlyVisibleCharacters) { }

	// RVA: 0xDA9CA0 Offset: 0xDA82A0 VA: 0x180DA9CA0
	protected float GetRenderedWidth() { }

	// RVA: 0xDA9CC0 Offset: 0xDA82C0 VA: 0x180DA9CC0
	protected float GetRenderedWidth(bool onlyVisibleCharacters) { }

	// RVA: 0xDA9B10 Offset: 0xDA8110 VA: 0x180DA9B10
	protected float GetRenderedHeight() { }

	// RVA: 0xDA9AF0 Offset: 0xDA80F0 VA: 0x180DA9AF0
	protected float GetRenderedHeight(bool onlyVisibleCharacters) { }

	// RVA: 0xDA2690 Offset: 0xDA0C90 VA: 0x180DA2690 Slot: 110
	protected virtual Vector2 CalculatePreferredValues(float defaultFontSize, Vector2 marginSize, bool ignoreTextAutoSizing) { }

	// RVA: 0xDA9100 Offset: 0xDA7700 VA: 0x180DA9100 Slot: 111
	protected virtual Bounds GetCompoundBounds() { }

	// RVA: 0xDAA200 Offset: 0xDA8800 VA: 0x180DAA200
	protected Bounds GetTextBounds() { }

	// RVA: 0xDAA610 Offset: 0xDA8C10 VA: 0x180DAA610
	protected Bounds GetTextBounds(bool onlyVisibleCharacters) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 112
	protected virtual void AdjustLineOffset(int startIndex, int endIndex, float offset) { }

	// RVA: 0xDAC580 Offset: 0xDAAB80 VA: 0x180DAC580
	protected void ResizeLineExtents(int size) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 113
	public virtual TMP_TextInfo GetTextInfo(string text) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 114
	public virtual void ComputeMarginSize() { }

	// RVA: 0xDADC70 Offset: 0xDAC270 VA: 0x180DADC70
	protected void SaveWordWrappingState(ref WordWrapState state, int index, int count) { }

	// RVA: 0xDAC810 Offset: 0xDAAE10 VA: 0x180DAC810
	protected int RestoreWordWrappingState(ref WordWrapState state) { }

	// RVA: 0xDACC60 Offset: 0xDAB260 VA: 0x180DACC60 Slot: 115
	protected virtual void SaveGlyphVertexInfo(float padding, float style_padding, Color32 vertexColor) { }

	// RVA: 0xDA8610 Offset: 0xDA6C10 VA: 0x180DA8610 Slot: 116
	protected virtual void FillCharacterVertexBuffers(int i, int index_X4) { }

	// RVA: 0xDA7100 Offset: 0xDA5700 VA: 0x180DA7100 Slot: 117
	protected virtual void FillCharacterVertexBuffers(int i, int index_X4, bool isVolumetric) { }

	// RVA: 0xDA57D0 Offset: 0xDA3DD0 VA: 0x180DA57D0 Slot: 118
	protected virtual void DrawUnderlineMesh(Vector3 start, Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor) { }

	// RVA: 0xDA5040 Offset: 0xDA3640 VA: 0x180DA5040 Slot: 119
	protected virtual void DrawTextHighlight(Vector3 start, Vector3 end, ref int index, Color32 highlightColor) { }

	// RVA: 0xDAC1E0 Offset: 0xDAA7E0 VA: 0x180DAC1E0
	protected void LoadDefaultSettings() { }

	// RVA: 0xDA9CE0 Offset: 0xDA82E0 VA: 0x180DA9CE0
	protected void GetSpecialCharacters(TMP_FontAsset fontAsset) { }

	// RVA: 0xDAC500 Offset: 0xDAAB00 VA: 0x180DAC500
	protected void ReplaceTagWithCharacter(int[] chars, int insertionIndex, int tagLength, char c) { }

	// RVA: 0xDA9110 Offset: 0xDA7710 VA: 0x180DA9110
	protected TMP_FontAsset GetFontAssetForWeight(int fontWeight) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 120
	protected virtual void SetActiveSubMeshes(bool state) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 121
	protected virtual void ClearSubMeshObjects() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 122
	public virtual void ClearMesh() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 123
	public virtual void ClearMesh(bool uploadGeometry) { }

	// RVA: 0xDA91D0 Offset: 0xDA77D0 VA: 0x180DA91D0 Slot: 124
	public virtual string GetParsedText() { }

	// RVA: 0xDAC470 Offset: 0xDAAA70 VA: 0x180DAC470
	protected Vector2 PackUV(float x, float y, float scale) { }

	// RVA: 0xDAC430 Offset: 0xDAAA30 VA: 0x180DAC430
	protected float PackUV(float x, float y) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 125
	internal virtual void InternalUpdate() { }

	// RVA: 0xDABCF0 Offset: 0xDAA2F0 VA: 0x180DABCF0
	protected int HexToInt(char hex) { }

	// RVA: 0xDAAAB0 Offset: 0xDA90B0 VA: 0x180DAAAB0
	protected int GetUTF16(string text, int i) { }

	// RVA: 0xDAAB90 Offset: 0xDA9190 VA: 0x180DAAB90
	protected int GetUTF16(StringBuilder text, int i) { }

	// RVA: 0xDAAE00 Offset: 0xDA9400 VA: 0x180DAAE00
	protected int GetUTF32(string text, int i) { }

	// RVA: 0xDAAC70 Offset: 0xDA9270 VA: 0x180DAAC70
	protected int GetUTF32(StringBuilder text, int i) { }

	// RVA: 0xDAAF90 Offset: 0xDA9590 VA: 0x180DAAF90
	protected Color32 HexCharsToColor(char[] hexChars, int tagCount) { }

	// RVA: 0xDAB900 Offset: 0xDA9F00 VA: 0x180DAB900
	protected Color32 HexCharsToColor(char[] hexChars, int startIndex, int length) { }

	// RVA: 0xDA9020 Offset: 0xDA7620 VA: 0x180DA9020
	private int GetAttributeParameters(char[] chars, int startIndex, int length, ref float[] parameters) { }

	// RVA: 0xDA4E50 Offset: 0xDA3450 VA: 0x180DA4E50
	protected float ConvertToFloat(char[] chars, int startIndex, int length) { }

	// RVA: 0xDA4CA0 Offset: 0xDA32A0 VA: 0x180DA4CA0
	protected float ConvertToFloat(char[] chars, int startIndex, int length, out int lastIndex) { }

	// RVA: 0xDAEA30 Offset: 0xDAD030 VA: 0x180DAEA30
	protected bool ValidateHtmlTag(TMP_Text.UnicodeChar[] chars, int startIndex, out int endIndex) { }

	// RVA: 0xDB3D90 Offset: 0xDB2390 VA: 0x180DB3D90
	protected void .ctor() { }

	// RVA: 0xDB3C50 Offset: 0xDB2250 VA: 0x180DB3C50
	private static void .cctor() { }

}

public class TMP_TextElement // TypeDefIndex: 6840
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected TextElementType m_ElementType; // 0x10
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private uint m_Unicode; // 0x14
	private Glyph m_Glyph; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private uint m_GlyphIndex; // 0x20
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_Scale; // 0x24

	// Properties
	public TextElementType elementType { get; }
	public uint unicode { get; set; }
	public Glyph glyph { get; set; }
	public uint glyphIndex { get; set; }
	public float scale { get; set; }

	// Methods

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public TextElementType get_elementType() { }

	// RVA: 0x57C960 Offset: 0x57AF60 VA: 0x18057C960
	public uint get_unicode() { }

	// RVA: 0x57C980 Offset: 0x57AF80 VA: 0x18057C980
	public void set_unicode(uint value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public Glyph get_glyph() { }

	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	public void set_glyph(Glyph value) { }

	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760
	public uint get_glyphIndex() { }

	// RVA: 0x69D6C0 Offset: 0x69BCC0 VA: 0x18069D6C0
	public void set_glyphIndex(uint value) { }

	// RVA: 0x79B800 Offset: 0x799E00 VA: 0x18079B800
	public float get_scale() { }

	// RVA: 0x4A0590 Offset: 0x49EB90 VA: 0x1804A0590
	public void set_scale(float value) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class TMP_TextElement_Legacy // TypeDefIndex: 6841
{	// Fields
	public int id; // 0x10
	public float x; // 0x14
	public float y; // 0x18
	public float width; // 0x1C
	public float height; // 0x20
	public float xOffset; // 0x24
	public float yOffset; // 0x28
	public float xAdvance; // 0x2C
	public float scale; // 0x30

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class TMP_TextInfo // TypeDefIndex: 6842
{	// Fields
	private static Vector2 k_InfinityVectorPositive; // 0x0
	private static Vector2 k_InfinityVectorNegative; // 0x8
	public TMP_Text textComponent; // 0x10
	public int characterCount; // 0x18
	public int spriteCount; // 0x1C
	public int spaceCount; // 0x20
	public int wordCount; // 0x24
	public int linkCount; // 0x28
	public int lineCount; // 0x2C
	public int pageCount; // 0x30
	public int materialCount; // 0x34
	public TMP_CharacterInfo[] characterInfo; // 0x38
	public TMP_WordInfo[] wordInfo; // 0x40
	public TMP_LinkInfo[] linkInfo; // 0x48
	public TMP_LineInfo[] lineInfo; // 0x50
	public TMP_PageInfo[] pageInfo; // 0x58
	public TMP_MeshInfo[] meshInfo; // 0x60
	private TMP_MeshInfo[] m_CachedMeshInfo; // 0x68

	// Methods

	// RVA: 0x1157580 Offset: 0x1155B80 VA: 0x181157580
	public void .ctor() { }

	// RVA: 0x1157410 Offset: 0x1155A10 VA: 0x181157410
	public void .ctor(TMP_Text textComponent) { }

	// RVA: 0x1156CD0 Offset: 0x11552D0 VA: 0x181156CD0
	public void Clear() { }

	// RVA: 0x1156BC0 Offset: 0x11551C0 VA: 0x181156BC0
	public void ClearMeshInfo(bool updateMesh) { }

	// RVA: 0x1156860 Offset: 0x1154E60 VA: 0x181156860
	public void ClearAllMeshInfo() { }

	// RVA: 0x11572D0 Offset: 0x11558D0 VA: 0x1811572D0
	public void ResetVertexLayout(bool isVolumetric) { }

	// RVA: 0x1156C50 Offset: 0x1155250 VA: 0x181156C50
	public void ClearUnusedVertices(MaterialReference[] materials) { }

	// RVA: 0x11568E0 Offset: 0x1154EE0 VA: 0x1811568E0
	public void ClearLineInfo() { }

	// RVA: 0x1156D50 Offset: 0x1155350 VA: 0x181156D50
	public TMP_MeshInfo[] CopyMeshInfoVertexData() { }

	// RVA: -1 Offset: -1
	public static void Resize<T>(ref T[] array, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3D40 Offset: 0x5D2340 VA: 0x1805D3D40
	|-TMP_TextInfo.Resize<object>
	|-TMP_TextInfo.Resize<TMP_SubMesh>
	|-TMP_TextInfo.Resize<TMP_SubMeshUI>
	|
	|-RVA: 0x5D3F50 Offset: 0x5D2550 VA: 0x1805D3F50
	|-TMP_TextInfo.Resize<TMP_LinkInfo>
	|
	|-RVA: 0x5D4160 Offset: 0x5D2760 VA: 0x1805D4160
	|-TMP_TextInfo.Resize<TMP_WordInfo>
	*/

	// RVA: -1 Offset: -1
	public static void Resize<T>(ref T[] array, int size, bool isBlockAllocated) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3DD0 Offset: 0x5D23D0 VA: 0x1805D3DD0
	|-TMP_TextInfo.Resize<object>
	|-TMP_TextInfo.Resize<Material>
	|
	|-RVA: 0x5D3E90 Offset: 0x5D2490 VA: 0x1805D3E90
	|-TMP_TextInfo.Resize<TMP_CharacterInfo>
	|
	|-RVA: 0x5D3FE0 Offset: 0x5D25E0 VA: 0x1805D3FE0
	|-TMP_TextInfo.Resize<TMP_MeshInfo>
	|
	|-RVA: 0x5D40A0 Offset: 0x5D26A0 VA: 0x1805D40A0
	|-TMP_TextInfo.Resize<TMP_PageInfo>
	*/

	// RVA: 0x1157360 Offset: 0x1155960 VA: 0x181157360
	private static void .cctor() { }

}

public class TMP_TextParsingUtilities // TypeDefIndex: 6843
{	// Fields
	private static readonly TMP_TextParsingUtilities s_Instance; // 0x35C6
	private const string k_LookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-";
	private const string k_LookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-";

	// Properties
	public static TMP_TextParsingUtilities instance { get; }

	// Methods

	// RVA: 0x1157940 Offset: 0x1155F40 VA: 0x181157940
	private static void .cctor() { }

	// RVA: 0x11579A0 Offset: 0x1155FA0 VA: 0x1811579A0
	public static TMP_TextParsingUtilities get_instance() { }

	// RVA: 0x11576D0 Offset: 0x1155CD0 VA: 0x1811576D0
	public static uint GetHashCode(string s) { }

	// RVA: 0x1157670 Offset: 0x1155C70 VA: 0x181157670
	public static int GetHashCodeCaseSensitive(string s) { }

	// RVA: 0x1157820 Offset: 0x1155E20 VA: 0x181157820
	public static char ToLowerASCIIFast(char c) { }

	// RVA: 0x1157880 Offset: 0x1155E80 VA: 0x181157880
	public static char ToUpperASCIIFast(char c) { }

	// RVA: 0x11578E0 Offset: 0x1155EE0 VA: 0x1811578E0
	public static uint ToUpperASCIIFast(uint c) { }

	// RVA: 0x11577C0 Offset: 0x1155DC0 VA: 0x1811577C0
	public static uint ToLowerASCIIFast(uint c) { }

	// RVA: 0x1157780 Offset: 0x1155D80 VA: 0x181157780
	public static bool IsHighSurrogate(uint c) { }

	// RVA: 0x11577A0 Offset: 0x1155DA0 VA: 0x1811577A0
	public static bool IsLowSurrogate(uint c) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public static class TMP_TextUtilities // TypeDefIndex: 6846
{	// Fields
	private static Vector3[] m_rectWorldCorners; // 0x2B1073C
	private const string k_lookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-";
	private const string k_lookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-";

	// Methods

	// RVA: 0x115C230 Offset: 0x115A830 VA: 0x18115C230
	public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera) { }

	// RVA: 0x115C430 Offset: 0x115AA30 VA: 0x18115C430
	public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera, out CaretPosition cursor) { }

	// RVA: 0x115A460 Offset: 0x1158A60 VA: 0x18115A460
	public static int FindNearestLine(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x11599A0 Offset: 0x1157FA0 VA: 0x1811599A0
	public static int FindNearestCharacterOnLine(TMP_Text text, Vector3 position, int line, Camera camera, bool visibleOnly) { }

	// RVA: 0x115CB30 Offset: 0x115B130 VA: 0x18115CB30
	public static bool IsIntersectingRectTransform(RectTransform rectTransform, Vector3 position, Camera camera) { }

	// RVA: 0x1157D00 Offset: 0x1156300 VA: 0x181157D00
	public static int FindIntersectingCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly) { }

	// RVA: 0x1159F20 Offset: 0x1158520 VA: 0x181159F20
	public static int FindNearestCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly) { }

	// RVA: 0x1158B30 Offset: 0x1157130 VA: 0x181158B30
	public static int FindIntersectingWord(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x115B4D0 Offset: 0x1159AD0 VA: 0x18115B4D0
	public static int FindNearestWord(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x1158070 Offset: 0x1156670 VA: 0x181158070
	public static int FindIntersectingLine(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x11582D0 Offset: 0x11568D0 VA: 0x1811582D0
	public static int FindIntersectingLink(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x115A780 Offset: 0x1158D80 VA: 0x18115A780
	public static int FindNearestLink(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x115CD40 Offset: 0x115B340 VA: 0x18115CD40
	private static bool PointIntersectRectangle(Vector3 m, Vector3 a, Vector3 b, Vector3 c, Vector3 d) { }

	// RVA: 0x115CFD0 Offset: 0x115B5D0 VA: 0x18115CFD0
	public static bool ScreenPointToWorldPointInRectangle(Transform transform, Vector2 screenPoint, Camera cam, out Vector3 worldPoint) { }

	// RVA: 0x115C890 Offset: 0x115AE90 VA: 0x18115C890
	private static bool IntersectLinePlane(TMP_TextUtilities.LineSegment line, Vector3 point, Vector3 normal, out Vector3 intersectingPoint) { }

	// RVA: 0x1157A00 Offset: 0x1156000 VA: 0x181157A00
	public static float DistanceToLine(Vector3 a, Vector3 b, Vector3 point) { }

	// RVA: 0x115D320 Offset: 0x115B920 VA: 0x18115D320
	public static char ToLowerFast(char c) { }

	// RVA: 0x115D380 Offset: 0x115B980 VA: 0x18115D380
	public static char ToUpperFast(char c) { }

	// RVA: 0x1157670 Offset: 0x1155C70 VA: 0x181157670
	public static int GetSimpleHashCode(string s) { }

	// RVA: 0x115C6D0 Offset: 0x115ACD0 VA: 0x18115C6D0
	public static uint GetSimpleHashCodeLowercase(string s) { }

	// RVA: 0x115C780 Offset: 0x115AD80 VA: 0x18115C780
	public static int HexToInt(char hex) { }

	// RVA: 0x115D210 Offset: 0x115B810 VA: 0x18115D210
	public static int StringHexToInt(string s) { }

	// RVA: 0x115D3E0 Offset: 0x115B9E0 VA: 0x18115D3E0
	private static void .cctor() { }

}

private struct TMP_TextUtilities.LineSegment // TypeDefIndex: 6847
{	// Fields
	public Vector3 Point1; // 0x0
	public Vector3 Point2; // 0xC

	// Methods

	// RVA: 0x1BD3E0 Offset: 0x1BC7E0 VA: 0x1801BD3E0
	public void .ctor(Vector3 p1, Vector3 p2) { }

}

public class TMP_UpdateManager // TypeDefIndex: 6848
{	// Fields
	private static TMP_UpdateManager s_Instance; // 0x0
	private readonly List<TMP_Text> m_LayoutRebuildQueue; // 0x10
	private Dictionary<int, int> m_LayoutQueueLookup; // 0x18
	private readonly List<TMP_Text> m_GraphicRebuildQueue; // 0x20
	private Dictionary<int, int> m_GraphicQueueLookup; // 0x28
	private readonly List<TMP_Text> m_InternalUpdateQueue; // 0x30
	private Dictionary<int, int> m_InternalUpdateLookup; // 0x38

	// Properties
	public static TMP_UpdateManager instance { get; }

	// Methods

	// RVA: 0x115E110 Offset: 0x115C710 VA: 0x18115E110
	public static TMP_UpdateManager get_instance() { }

	// RVA: 0x115DEE0 Offset: 0x115C4E0 VA: 0x18115DEE0
	protected void .ctor() { }

	// RVA: 0x115DBD0 Offset: 0x115C1D0 VA: 0x18115DBD0
	internal static void RegisterTextObjectForUpdate(TMP_Text textObject) { }

	// RVA: 0x115D7B0 Offset: 0x115BDB0 VA: 0x18115D7B0
	private void InternalRegisterTextObjectForUpdate(TMP_Text textObject) { }

	// RVA: 0x115DB10 Offset: 0x115C110 VA: 0x18115DB10
	public static void RegisterTextElementForLayoutRebuild(TMP_Text element) { }

	// RVA: 0x115D6F0 Offset: 0x115BCF0 VA: 0x18115D6F0
	private bool InternalRegisterTextElementForLayoutRebuild(TMP_Text element) { }

	// RVA: 0x115DA50 Offset: 0x115C050 VA: 0x18115DA50
	public static void RegisterTextElementForGraphicRebuild(TMP_Text element) { }

	// RVA: 0x115D630 Offset: 0x115BC30 VA: 0x18115D630
	private bool InternalRegisterTextElementForGraphicRebuild(TMP_Text element) { }

	// RVA: 0x115DA40 Offset: 0x115C040 VA: 0x18115DA40
	private void OnBeginFrameRendering(ScriptableRenderContext renderContext, Camera[] cameras) { }

	// RVA: 0x115DA40 Offset: 0x115C040 VA: 0x18115DA40
	private void OnCameraPreCull(Camera cam) { }

	// RVA: 0x115D430 Offset: 0x115BA30 VA: 0x18115D430
	private void DoRebuilds() { }

	// RVA: 0x115DE40 Offset: 0x115C440 VA: 0x18115DE40
	internal static void UnRegisterTextObjectForUpdate(TMP_Text textObject) { }

	// RVA: 0x115DC90 Offset: 0x115C290 VA: 0x18115DC90
	public static void UnRegisterTextElementForRebuild(TMP_Text element) { }

	// RVA: 0x115D860 Offset: 0x115BE60 VA: 0x18115D860
	private void InternalUnRegisterTextElementForGraphicRebuild(TMP_Text element) { }

	// RVA: 0x115D900 Offset: 0x115BF00 VA: 0x18115D900
	private void InternalUnRegisterTextElementForLayoutRebuild(TMP_Text element) { }

	// RVA: 0x115D9A0 Offset: 0x115BFA0 VA: 0x18115D9A0
	private void InternalUnRegisterTextObjectForUpdate(TMP_Text textObject) { }

}

public class TMP_UpdateRegistry // TypeDefIndex: 6849
{	// Fields
	private static TMP_UpdateRegistry s_Instance; // 0x0
	private readonly List<ICanvasElement> m_LayoutRebuildQueue; // 0x10
	private Dictionary<int, int> m_LayoutQueueLookup; // 0x18
	private readonly List<ICanvasElement> m_GraphicRebuildQueue; // 0x20
	private Dictionary<int, int> m_GraphicQueueLookup; // 0x28

	// Properties
	public static TMP_UpdateRegistry instance { get; }

	// Methods

	// RVA: 0x115EE70 Offset: 0x115D470 VA: 0x18115EE70
	public static TMP_UpdateRegistry get_instance() { }

	// RVA: 0x115ED50 Offset: 0x115D350 VA: 0x18115ED50
	protected void .ctor() { }

	// RVA: 0x115EA10 Offset: 0x115D010 VA: 0x18115EA10
	public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x115E2C0 Offset: 0x115C8C0 VA: 0x18115E2C0
	private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x115E8E0 Offset: 0x115CEE0 VA: 0x18115E8E0
	public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x115E190 Offset: 0x115C790 VA: 0x18115E190
	private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x115E5F0 Offset: 0x115CBF0 VA: 0x18115E5F0
	private void PerformUpdateForCanvasRendererObjects() { }

	// RVA: 0x115E890 Offset: 0x115CE90 VA: 0x18115E890
	private void PerformUpdateForMeshRendererObjects() { }

	// RVA: 0x115EB40 Offset: 0x115D140 VA: 0x18115EB40
	public static void UnRegisterCanvasElementForRebuild(ICanvasElement element) { }

	// RVA: 0x115E4F0 Offset: 0x115CAF0 VA: 0x18115E4F0
	private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x115E3F0 Offset: 0x115C9F0 VA: 0x18115E3F0
	private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

}

public static class TMP_Math // TypeDefIndex: 6854
{	// Fields
	public const float FLOAT_MAX = 32767;
	public const float FLOAT_MIN = -32767;
	public const int INT_MAX = 2147483647;
	public const int INT_MIN = -2147483647;
	public const float FLOAT_UNSET = -32767;
	public const int INT_UNSET = -32767;
	public static Vector2 MAX_16BIT; // 0x0
	public static Vector2 MIN_16BIT; // 0x8

	// Methods

	// RVA: 0xD9BB50 Offset: 0xD9A150 VA: 0x180D9BB50
	public static bool Approximately(float a, float b) { }

	// RVA: 0xD9BB80 Offset: 0xD9A180 VA: 0x180D9BB80
	private static void .cctor() { }

}

public enum TMP_VertexDataUpdateFlags // TypeDefIndex: 6855
{	// Fields
	public int value__; // 0x0
	public const TMP_VertexDataUpdateFlags None = 0;
	public const TMP_VertexDataUpdateFlags Vertices = 1;
	public const TMP_VertexDataUpdateFlags Uv0 = 2;
	public const TMP_VertexDataUpdateFlags Uv2 = 4;
	public const TMP_VertexDataUpdateFlags Uv4 = 8;
	public const TMP_VertexDataUpdateFlags Colors32 = 16;
	public const TMP_VertexDataUpdateFlags All = 255;

}

public struct TMP_PageInfo // TypeDefIndex: 6857
{	// Fields
	public int firstCharacterIndex; // 0x0
	public int lastCharacterIndex; // 0x4
	public float ascender; // 0x8
	public float baseLine; // 0xC
	public float descender; // 0x10

}

public struct TMP_LinkInfo // TypeDefIndex: 6858
{	// Fields
	public TMP_Text textComponent; // 0x0
	public int hashCode; // 0x8
	public int linkIdFirstCharacterIndex; // 0xC
	public int linkIdLength; // 0x10
	public int linkTextfirstCharacterIndex; // 0x14
	public int linkTextLength; // 0x18
	internal char[] linkID; // 0x20

	// Methods

	// RVA: 0x121E80 Offset: 0x121280 VA: 0x180121E80
	internal void SetLinkID(char[] text, int startIndex, int length) { }

	// RVA: 0x121DA0 Offset: 0x1211A0 VA: 0x180121DA0
	public string GetLinkText() { }

	// RVA: 0x121D00 Offset: 0x121100 VA: 0x180121D00
	public string GetLinkID() { }

}

public struct TMP_WordInfo // TypeDefIndex: 6859
{	// Fields
	public TMP_Text textComponent; // 0x0
	public int firstCharacterIndex; // 0x8
	public int lastCharacterIndex; // 0xC
	public int characterCount; // 0x10

	// Methods

	// RVA: 0x1BD410 Offset: 0x1BC810 VA: 0x1801BD410
	public string GetWord() { }

}

public struct TMP_SpriteInfo // TypeDefIndex: 6860
{	// Fields
	public int spriteIndex; // 0x0
	public int characterIndex; // 0x4
	public int vertexIndex; // 0x8

}

