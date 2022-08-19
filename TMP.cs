public class TMP_Asset : ScriptableObject // TypeDefIndex: 6743
{	// Fields
	public int hashCode; // 0x18
	public Material material; // 0x20
	public int materialHashCode; // 0x28

	// Methods

	// RVA: 0x4C3AE0 Offset: 0x4C20E0 VA: 0x1804C3AE0
	public void .ctor() { }

}

public class TMP_Character : TMP_TextElement // TypeDefIndex: 6744
{	// Methods

	// RVA: 0xC6A480 Offset: 0xC68A80 VA: 0x180C6A480
	public void .ctor() { }

	// RVA: 0xC6A3B0 Offset: 0xC689B0 VA: 0x180C6A3B0
	public void .ctor(uint unicode, Glyph glyph) { }

	// RVA: 0xC6A420 Offset: 0xC68A20 VA: 0x180C6A420
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

	// RVA: 0xC6A500 Offset: 0xC68B00 VA: 0x180C6A500
	public void .ctor() { }

	// RVA: 0xC6A630 Offset: 0xC68C30 VA: 0x180C6A630
	public void .ctor(Color color) { }

	// RVA: 0xC6A5C0 Offset: 0xC68BC0 VA: 0x180C6A5C0
	public void .ctor(Color color0, Color color1, Color color2, Color color3) { }

	// RVA: 0xC6A4B0 Offset: 0xC68AB0 VA: 0x180C6A4B0
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

	// RVA: 0xC6B610 Offset: 0xC69C10 VA: 0x180C6B610
	private static GameObject CreateUIElementRoot(string name, Vector2 size) { }

	// RVA: 0xC6B6B0 Offset: 0xC69CB0 VA: 0x180C6B6B0
	private static GameObject CreateUIObject(string name, GameObject parent) { }

	// RVA: 0xC6B800 Offset: 0xC69E00 VA: 0x180C6B800
	private static void SetDefaultTextValues(TMP_Text lbl) { }

	// RVA: 0xC6B760 Offset: 0xC69D60 VA: 0x180C6B760
	private static void SetDefaultColorTransitionValues(Selectable slider) { }

	// RVA: 0xC6B980 Offset: 0xC69F80 VA: 0x180C6B980
	private static void SetParentAndAlign(GameObject child, GameObject parent) { }

	// RVA: 0xC6B8A0 Offset: 0xC69EA0 VA: 0x180C6B8A0
	private static void SetLayerRecursively(GameObject go, int layer) { }

	// RVA: 0xC6B160 Offset: 0xC69760 VA: 0x180C6B160
	public static GameObject CreateScrollbar(TMP_DefaultControls.Resources resources) { }

	// RVA: 0xC6A680 Offset: 0xC68C80 VA: 0x180C6A680
	public static GameObject CreateButton(TMP_DefaultControls.Resources resources) { }

	// RVA: 0xC6B4C0 Offset: 0xC69AC0 VA: 0x180C6B4C0
	public static GameObject CreateText(TMP_DefaultControls.Resources resources) { }

	// RVA: 0xC6A9C0 Offset: 0xC68FC0 VA: 0x180C6A9C0
	public static GameObject CreateInputField(TMP_DefaultControls.Resources resources) { }

	// RVA: 0xC6BA70 Offset: 0xC6A070 VA: 0x180C6BA70
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
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private string m_Version; // 0x30
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal string m_SourceFontFileGUID; // 0x38
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Font m_SourceFontFile; // 0x40
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private AtlasPopulationMode m_AtlasPopulationMode; // 0x48
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private FaceInfo m_FaceInfo; // 0x50
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private List<Glyph> m_GlyphTable; // 0xA8
	private Dictionary<uint, Glyph> m_GlyphLookupDictionary; // 0xB0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private List<TMP_Character> m_CharacterTable; // 0xB8
	private Dictionary<uint, TMP_Character> m_CharacterLookupDictionary; // 0xC0
	private Texture2D m_AtlasTexture; // 0xC8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Texture2D[] m_AtlasTextures; // 0xD0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal int m_AtlasTextureIndex; // 0xD8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private List<GlyphRect> m_UsedGlyphRects; // 0xE0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private List<GlyphRect> m_FreeGlyphRects; // 0xE8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private FaceInfo_Legacy m_fontInfo; // 0xF0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public Texture2D atlas; // 0xF8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int m_AtlasWidth; // 0x100
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int m_AtlasHeight; // 0x104
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int m_AtlasPadding; // 0x108
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GlyphRenderMode m_AtlasRenderMode; // 0x10C
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal List<TMP_Glyph> m_glyphInfoList; // 0x110
	[SerializeField] // RVA: 0xCB710 Offset: 0xCAB10 VA: 0x1800CB710
	[FormerlySerializedAsAttribute] // RVA: 0xCB710 Offset: 0xCAB10 VA: 0x1800CB710
	internal KerningTable m_KerningTable; // 0x118
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private TMP_FontFeatureTable m_FontFeatureTable; // 0x120
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private List<TMP_FontAsset> fallbackFontAssets; // 0x128
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public List<TMP_FontAsset> m_FallbackFontAssetTable; // 0x130
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal FontAssetCreationSettings m_CreationSettings; // 0x138
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private TMP_FontWeightPair[] m_FontWeightTable; // 0x190
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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
	[ObsoleteAttribute] // RVA: 0xCC0E0 Offset: 0xCB4E0 VA: 0x1800CC0E0
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

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public string get_version() { }

	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	internal void set_version(string value) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public Font get_sourceFontFile() { }

	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	internal void set_sourceFontFile(Font value) { }

	// RVA: 0x598420 Offset: 0x596A20 VA: 0x180598420
	public AtlasPopulationMode get_atlasPopulationMode() { }

	// RVA: 0x598430 Offset: 0x596A30 VA: 0x180598430
	public void set_atlasPopulationMode(AtlasPopulationMode value) { }

	// RVA: 0xC73B20 Offset: 0xC72120 VA: 0x180C73B20
	public FaceInfo get_faceInfo() { }

	// RVA: 0xC73C30 Offset: 0xC72230 VA: 0x180C73C30
	internal void set_faceInfo(FaceInfo value) { }

	// RVA: 0x952B90 Offset: 0x951190 VA: 0x180952B90
	public List<Glyph> get_glyphTable() { }

	// RVA: 0xC73C90 Offset: 0xC72290 VA: 0x180C73C90
	internal void set_glyphTable(List<Glyph> value) { }

	// RVA: 0xC73B80 Offset: 0xC72180 VA: 0x180C73B80
	public Dictionary<uint, Glyph> get_glyphLookupTable() { }

	// RVA: 0x7ACF70 Offset: 0x7AB570 VA: 0x1807ACF70
	public List<TMP_Character> get_characterTable() { }

	// RVA: 0xA4D230 Offset: 0xA4B830 VA: 0x180A4D230
	internal void set_characterTable(List<TMP_Character> value) { }

	// RVA: 0xC73AA0 Offset: 0xC720A0 VA: 0x180C73AA0
	public Dictionary<uint, TMP_Character> get_characterLookupTable() { }

	// RVA: 0xC739C0 Offset: 0xC71FC0 VA: 0x180C739C0
	public Texture2D get_atlasTexture() { }

	// RVA: 0xC73A80 Offset: 0xC72080 VA: 0x180C73A80
	public Texture2D[] get_atlasTextures() { }

	// RVA: 0xC73BD0 Offset: 0xC721D0 VA: 0x180C73BD0
	public void set_atlasTextures(Texture2D[] value) { }

	// RVA: 0x4EF3A0 Offset: 0x4ED9A0 VA: 0x1804EF3A0
	internal List<GlyphRect> get_usedGlyphRects() { }

	// RVA: 0x4EF3B0 Offset: 0x4ED9B0 VA: 0x1804EF3B0
	internal void set_usedGlyphRects(List<GlyphRect> value) { }

	// RVA: 0x872140 Offset: 0x870740 VA: 0x180872140
	internal List<GlyphRect> get_freeGlyphRects() { }

	// RVA: 0x8721C0 Offset: 0x8707C0 VA: 0x1808721C0
	internal void set_freeGlyphRects(List<GlyphRect> value) { }

	// RVA: 0xC73B60 Offset: 0xC72160 VA: 0x180C73B60
	public FaceInfo_Legacy get_fontInfo() { }

	// RVA: 0xC73A90 Offset: 0xC72090 VA: 0x180C73A90
	public int get_atlasWidth() { }

	// RVA: 0xC73BE0 Offset: 0xC721E0 VA: 0x180C73BE0
	internal void set_atlasWidth(int value) { }

	// RVA: 0xC739A0 Offset: 0xC71FA0 VA: 0x180C739A0
	public int get_atlasHeight() { }

	// RVA: 0xC73BB0 Offset: 0xC721B0 VA: 0x180C73BB0
	internal void set_atlasHeight(int value) { }

	// RVA: 0x871FF0 Offset: 0x8705F0 VA: 0x180871FF0
	public int get_atlasPadding() { }

	// RVA: 0x872190 Offset: 0x870790 VA: 0x180872190
	internal void set_atlasPadding(int value) { }

	// RVA: 0xC739B0 Offset: 0xC71FB0 VA: 0x180C739B0
	public GlyphRenderMode get_atlasRenderMode() { }

	// RVA: 0xC73BC0 Offset: 0xC721C0 VA: 0x180C73BC0
	internal void set_atlasRenderMode(GlyphRenderMode value) { }

	// RVA: 0x7DDC60 Offset: 0x7DC260 VA: 0x1807DDC60
	public TMP_FontFeatureTable get_fontFeatureTable() { }

	// RVA: 0xC73C70 Offset: 0xC72270 VA: 0x180C73C70
	internal void set_fontFeatureTable(TMP_FontFeatureTable value) { }

	// RVA: 0x701810 Offset: 0x6FFE10 VA: 0x180701810
	public List<TMP_FontAsset> get_fallbackFontAssetTable() { }

	// RVA: 0x7018A0 Offset: 0x6FFEA0 VA: 0x1807018A0
	public void set_fallbackFontAssetTable(List<TMP_FontAsset> value) { }

	// RVA: 0xC73AD0 Offset: 0xC720D0 VA: 0x180C73AD0
	public FontAssetCreationSettings get_creationSettings() { }

	// RVA: 0xC73BF0 Offset: 0xC721F0 VA: 0x180C73BF0
	public void set_creationSettings(FontAssetCreationSettings value) { }

	// RVA: 0xC73B70 Offset: 0xC72170 VA: 0x180C73B70
	public TMP_FontWeightPair[] get_fontWeightTable() { }

	// RVA: 0xC73C80 Offset: 0xC72280 VA: 0x180C73C80
	internal void set_fontWeightTable(TMP_FontWeightPair[] value) { }

	// RVA: 0xC6DBD0 Offset: 0xC6C1D0 VA: 0x180C6DBD0
	public static TMP_FontAsset CreateFontAsset(Font font) { }

	// RVA: 0xC6DC50 Offset: 0xC6C250 VA: 0x180C6DC50
	public static TMP_FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = 1) { }

	// RVA: 0xC6D4C0 Offset: 0xC6BAC0 VA: 0x180C6D4C0
	private void Awake() { }

	// RVA: 0xC6EE00 Offset: 0xC6D400 VA: 0x180C6EE00
	internal void InitializeDictionaryLookupTables() { }

	// RVA: 0xC6F240 Offset: 0xC6D840 VA: 0x180C6F240
	public void ReadFontAssetDefinition() { }

	// RVA: 0xC6FC30 Offset: 0xC6E230 VA: 0x180C6FC30
	internal void SortCharacterTable() { }

	// RVA: 0xC6FFC0 Offset: 0xC6E5C0 VA: 0x180C6FFC0
	internal void SortGlyphTable() { }

	// RVA: 0xC6FD70 Offset: 0xC6E370 VA: 0x180C6FD70
	internal void SortGlyphAndCharacterTables() { }

	// RVA: 0xC6EBB0 Offset: 0xC6D1B0 VA: 0x180C6EBB0
	public bool HasCharacter(int character) { }

	// RVA: 0xC6E730 Offset: 0xC6CD30 VA: 0x180C6E730
	public bool HasCharacter(char character) { }

	// RVA: 0xC6E7A0 Offset: 0xC6CDA0 VA: 0x180C6E7A0
	public bool HasCharacter(char character, bool searchFallbacks) { }

	// RVA: 0xC6E5B0 Offset: 0xC6CBB0 VA: 0x180C6E5B0
	private bool HasCharacter_Internal(char character, bool searchFallbacks) { }

	// RVA: 0xC6ECD0 Offset: 0xC6D2D0 VA: 0x180C6ECD0
	public bool HasCharacters(string text, out List<char> missingCharacters) { }

	// RVA: 0xC6EC20 Offset: 0xC6D220 VA: 0x180C6EC20
	public bool HasCharacters(string text) { }

	// RVA: 0xC6E420 Offset: 0xC6CA20 VA: 0x180C6E420
	public static string GetCharacters(TMP_FontAsset fontAsset) { }

	// RVA: 0xC6E330 Offset: 0xC6C930 VA: 0x180C6E330
	public static int[] GetCharactersArray(TMP_FontAsset fontAsset) { }

	// RVA: 0xC70D70 Offset: 0xC6F370 VA: 0x180C70D70
	public bool TryAddCharacters(uint[] unicodes) { }

	// RVA: 0xC70D90 Offset: 0xC6F390 VA: 0x180C70D90
	public bool TryAddCharacters(uint[] unicodes, out uint[] missingUnicodes) { }

	// RVA: 0xC70D50 Offset: 0xC6F350 VA: 0x180C70D50
	public bool TryAddCharacters(string characters) { }

	// RVA: 0xC715D0 Offset: 0xC6FBD0 VA: 0x180C715D0
	public bool TryAddCharacters(string characters, out string missingCharacters) { }

	// RVA: 0xC70940 Offset: 0xC6EF40 VA: 0x180C70940
	internal bool TryAddCharacter_Internal(uint unicode) { }

	// RVA: 0xC6D0C0 Offset: 0xC6B6C0 VA: 0x180C6D0C0
	internal TMP_Character AddCharacter_Internal(uint unicode, Glyph glyph) { }

	// RVA: 0xC70100 Offset: 0xC6E700 VA: 0x180C70100
	internal bool TryAddCharacterInternal(uint unicode, out TMP_Character character) { }

	// RVA: 0xC6E4F0 Offset: 0xC6CAF0 VA: 0x180C6E4F0
	internal uint GetGlyphIndex(uint unicode) { }

	// RVA: 0xC71D50 Offset: 0xC70350 VA: 0x180C71D50
	internal void UpdateAtlasTexture() { }

	// RVA: 0xC72100 Offset: 0xC70700 VA: 0x180C72100
	internal void UpdateGlyphAdjustmentRecords(uint unicode, uint glyphIndex) { }

	// RVA: 0xC6D540 Offset: 0xC6BB40 VA: 0x180C6D540
	public void ClearFontAssetData(bool setAtlasSizeToZero = False) { }

	// RVA: 0xC725B0 Offset: 0xC70BB0 VA: 0x180C725B0
	private void UpgradeFontAsset() { }

	// RVA: 0xC732F0 Offset: 0xC718F0 VA: 0x180C732F0
	private void UpgradeGlyphAdjustmentTableToFontFeatureTable() { }

	// RVA: 0xC73720 Offset: 0xC71D20 VA: 0x180C73720
	public void .ctor() { }

	// RVA: 0xC73690 Offset: 0xC71C90 VA: 0x180C73690
	private static void .cctor() { }

}

private sealed class TMP_FontAsset.<>c // TypeDefIndex: 6761
{	// Fields
	public static readonly TMP_FontAsset.<>c <>9; // 0x0
	public static Func<TMP_Character, uint> <>9__100_0; // 0x8
	public static Func<Glyph, uint> <>9__101_0; // 0x10

	// Methods

	// RVA: 0xC84E70 Offset: 0xC83470 VA: 0x180C84E70
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x970960 Offset: 0x96EF60 VA: 0x180970960
	internal uint <SortCharacterTable>b__100_0(TMP_Character c) { }

	// RVA: 0xC84DE0 Offset: 0xC833E0 VA: 0x180C84DE0
	internal uint <SortGlyphTable>b__101_0(Glyph c) { }

}

public class TMP_Glyph : TMP_TextElement_Legacy // TypeDefIndex: 6763
{	// Methods

	// RVA: 0xC74960 Offset: 0xC72F60 VA: 0x180C74960
	public static TMP_Glyph Clone(TMP_Glyph source) { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

}

public struct TMP_FontWeightPair // TypeDefIndex: 6765
{	// Fields
	public TMP_FontAsset regularTypeface; // 0x0
	public TMP_FontAsset italicTypeface; // 0x8

}

public static class TMP_FontUtilities // TypeDefIndex: 6774
{	// Fields
	private static List<int> k_searchedFontAssets; // 0x37BF

	// Methods

	// RVA: 0xC74430 Offset: 0xC72A30 VA: 0x180C74430
	public static TMP_FontAsset SearchForCharacter(TMP_FontAsset font, uint unicode, out TMP_Character character) { }

	// RVA: 0xC74500 Offset: 0xC72B00 VA: 0x180C74500
	public static TMP_FontAsset SearchForCharacter(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character) { }

	// RVA: 0xC741E0 Offset: 0xC727E0 VA: 0x180C741E0
	private static TMP_FontAsset SearchForCharacterInternal(TMP_FontAsset font, uint unicode, out TMP_Character character) { }

	// RVA: 0xC740F0 Offset: 0xC726F0 VA: 0x180C740F0
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

	// RVA: 0xC6D000 Offset: 0xC6B600 VA: 0x180C6D000
	private static void .cctor() { }

	// RVA: 0xC6D060 Offset: 0xC6B660 VA: 0x180C6D060
	public static TMP_FontAssetUtilities get_instance() { }

	// RVA: 0xC6C080 Offset: 0xC6A680 VA: 0x180C6C080
	public static TMP_Character GetCharacterFromFontAsset(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface, out TMP_FontAsset fontAsset) { }

	// RVA: 0xC6BBC0 Offset: 0xC6A1C0 VA: 0x180C6BBC0
	private static TMP_Character GetCharacterFromFontAsset_Internal(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface, out TMP_FontAsset fontAsset) { }

	// RVA: 0xC6C200 Offset: 0xC6A800 VA: 0x180C6C200
	public static TMP_Character GetCharacterFromFontAssets(uint unicode, List<TMP_FontAsset> fontAssets, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface, out TMP_FontAsset fontAsset) { }

	// RVA: 0xC6C480 Offset: 0xC6AA80 VA: 0x180C6C480
	private static bool TryGetCharacterFromFontFile(uint unicode, TMP_FontAsset fontAsset, out TMP_Character character) { }

	// RVA: 0xC6CE20 Offset: 0xC6B420 VA: 0x180C6CE20
	public static bool TryGetGlyphFromFontFile(uint glyphIndex, TMP_FontAsset fontAsset, out Glyph glyph) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class TMP_FontFeatureTable // TypeDefIndex: 6776
{	// Fields
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal List<TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords; // 0x10
	internal Dictionary<long, TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookupDictionary; // 0x18

	// Properties
	internal List<TMP_GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords { get; set; }

	// Methods

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal List<TMP_GlyphPairAdjustmentRecord> get_glyphPairAdjustmentRecords() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	internal void set_glyphPairAdjustmentRecords(List<TMP_GlyphPairAdjustmentRecord> value) { }

	// RVA: 0xC73EA0 Offset: 0xC724A0 VA: 0x180C73EA0
	public void .ctor() { }

	// RVA: 0xC73CA0 Offset: 0xC722A0 VA: 0x180C73CA0
	public void SortGlyphPairAdjustmentRecords() { }

}

private sealed class TMP_FontFeatureTable.<>c // TypeDefIndex: 6777
{	// Fields
	public static readonly TMP_FontFeatureTable.<>c <>9; // 0x0
	public static Func<TMP_GlyphPairAdjustmentRecord, uint> <>9__6_0; // 0x8
	public static Func<TMP_GlyphPairAdjustmentRecord, uint> <>9__6_1; // 0x10

	// Methods

	// RVA: 0xC84F30 Offset: 0xC83530 VA: 0x180C84F30
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xC84DA0 Offset: 0xC833A0 VA: 0x180C84DA0
	internal uint <SortGlyphPairAdjustmentRecords>b__6_0(TMP_GlyphPairAdjustmentRecord s) { }

	// RVA: 0xC84DC0 Offset: 0xC833C0 VA: 0x180C84DC0
	internal uint <SortGlyphPairAdjustmentRecords>b__6_1(TMP_GlyphPairAdjustmentRecord s) { }

}

public struct TMP_GlyphValueRecord // TypeDefIndex: 6779
{	// Fields
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float m_XPlacement; // 0x0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float m_YPlacement; // 0x4
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float m_XAdvance; // 0x8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float m_YAdvance; // 0xC

	// Properties
	public float xPlacement { get; set; }
	public float yPlacement { get; set; }
	public float xAdvance { get; set; }
	public float yAdvance { get; set; }

	// Methods

	// RVA: 0xF2400 Offset: 0xF1800 VA: 0x1800F2400
	public float get_xPlacement() { }

	// RVA: 0xF2410 Offset: 0xF1810 VA: 0x1800F2410
	public void set_xPlacement(float value) { }

	// RVA: 0x117990 Offset: 0x116D90 VA: 0x180117990
	public float get_yPlacement() { }

	// RVA: 0x1179A0 Offset: 0x116DA0 VA: 0x1801179A0
	public void set_yPlacement(float value) { }

	// RVA: 0x117180 Offset: 0x116580 VA: 0x180117180
	public float get_xAdvance() { }

	// RVA: 0x1171C0 Offset: 0x1165C0 VA: 0x1801171C0
	public void set_xAdvance(float value) { }

	// RVA: 0x117190 Offset: 0x116590 VA: 0x180117190
	public float get_yAdvance() { }

	// RVA: 0x1171D0 Offset: 0x1165D0 VA: 0x1801171D0
	public void set_yAdvance(float value) { }

	// RVA: 0xF2B40 Offset: 0xF1F40 VA: 0x1800F2B40
	public void .ctor(float xPlacement, float yPlacement, float xAdvance, float yAdvance) { }

	// RVA: 0x117960 Offset: 0x116D60 VA: 0x180117960
	internal void .ctor(GlyphValueRecord_Legacy valueRecord) { }

	// RVA: 0x117550 Offset: 0x116950 VA: 0x180117550
	internal void .ctor(GlyphValueRecord valueRecord) { }

	// RVA: 0xC74940 Offset: 0xC72F40 VA: 0x180C74940
	public static TMP_GlyphValueRecord op_Addition(TMP_GlyphValueRecord a, TMP_GlyphValueRecord b) { }

}

public struct TMP_GlyphAdjustmentRecord // TypeDefIndex: 6780
{	// Fields
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private uint m_GlyphIndex; // 0x0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private TMP_GlyphValueRecord m_GlyphValueRecord; // 0x4

	// Properties
	public uint glyphIndex { get; set; }
	public TMP_GlyphValueRecord glyphValueRecord { get; set; }

	// Methods

	// RVA: 0xF37A0 Offset: 0xF2BA0 VA: 0x1800F37A0
	public uint get_glyphIndex() { }

	// RVA: 0xF38D0 Offset: 0xF2CD0 VA: 0x1800F38D0
	public void set_glyphIndex(uint value) { }

	// RVA: 0x117940 Offset: 0x116D40 VA: 0x180117940
	public TMP_GlyphValueRecord get_glyphValueRecord() { }

	// RVA: 0x117950 Offset: 0x116D50 VA: 0x180117950
	public void set_glyphValueRecord(TMP_GlyphValueRecord value) { }

	// RVA: 0x117900 Offset: 0x116D00 VA: 0x180117900
	public void .ctor(uint glyphIndex, TMP_GlyphValueRecord glyphValueRecord) { }

	// RVA: 0x117910 Offset: 0x116D10 VA: 0x180117910
	internal void .ctor(GlyphAdjustmentRecord adjustmentRecord) { }

}

public class TMP_GlyphPairAdjustmentRecord // TypeDefIndex: 6781
{	// Fields
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private TMP_GlyphAdjustmentRecord m_FirstAdjustmentRecord; // 0x10
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private TMP_GlyphAdjustmentRecord m_SecondAdjustmentRecord; // 0x24
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private FontFeatureLookupFlags m_FeatureLookupFlags; // 0x38

	// Properties
	public TMP_GlyphAdjustmentRecord firstAdjustmentRecord { get; set; }
	public TMP_GlyphAdjustmentRecord secondAdjustmentRecord { get; set; }
	public FontFeatureLookupFlags featureLookupFlags { get; set; }

	// Methods

	// RVA: 0xC748D0 Offset: 0xC72ED0 VA: 0x180C748D0
	public TMP_GlyphAdjustmentRecord get_firstAdjustmentRecord() { }

	// RVA: 0xC74920 Offset: 0xC72F20 VA: 0x180C74920
	public void set_firstAdjustmentRecord(TMP_GlyphAdjustmentRecord value) { }

	// RVA: 0xC748F0 Offset: 0xC72EF0 VA: 0x180C748F0
	public TMP_GlyphAdjustmentRecord get_secondAdjustmentRecord() { }

	// RVA: 0xC74930 Offset: 0xC72F30 VA: 0x180C74930
	public void set_secondAdjustmentRecord(TMP_GlyphAdjustmentRecord value) { }

	// RVA: 0x6BB940 Offset: 0x6B9F40 VA: 0x1806BB940
	public FontFeatureLookupFlags get_featureLookupFlags() { }

	// RVA: 0xC74910 Offset: 0xC72F10 VA: 0x180C74910
	public void set_featureLookupFlags(FontFeatureLookupFlags value) { }

	// RVA: 0xC746C0 Offset: 0xC72CC0 VA: 0x180C746C0
	public void .ctor(TMP_GlyphAdjustmentRecord firstAdjustmentRecord, TMP_GlyphAdjustmentRecord secondAdjustmentRecord) { }

	// RVA: 0xC74710 Offset: 0xC72D10 VA: 0x180C74710
	internal void .ctor(GlyphPairAdjustmentRecord glyphPairAdjustmentRecord) { }

}

public class TMP_InputField : Selectable, IUpdateSelectedHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement, IScrollHandler // TypeDefIndex: 6783
{	// Fields
	protected TouchScreenKeyboard m_SoftKeyboard; // 0xE8
	private static readonly char[] kSeparators; // 0x0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected RectTransform m_TextViewport; // 0xF0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected TMP_Text m_TextComponent; // 0xF8
	protected RectTransform m_TextComponentRectTransform; // 0x100
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected Graphic m_Placeholder; // 0x108
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected Scrollbar m_VerticalScrollbar; // 0x110
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected TMP_ScrollbarEventHandler m_VerticalScrollbarEventHandler; // 0x118
	private bool m_IsDrivenByLayoutComponents; // 0x120
	private float m_ScrollPosition; // 0x124
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected float m_ScrollSensitivity; // 0x128
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private TMP_InputField.ContentType m_ContentType; // 0x12C
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private TMP_InputField.InputType m_InputType; // 0x130
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private char m_AsteriskChar; // 0x134
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private TouchScreenKeyboardType m_KeyboardType; // 0x138
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private TMP_InputField.LineType m_LineType; // 0x13C
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool m_HideMobileInput; // 0x140
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool m_HideSoftKeyboard; // 0x141
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private TMP_InputField.CharacterValidation m_CharacterValidation; // 0x144
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private string m_RegexValue; // 0x148
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float m_GlobalPointSize; // 0x150
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int m_CharacterLimit; // 0x154
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private TMP_InputField.SubmitEvent m_OnEndEdit; // 0x158
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private TMP_InputField.SubmitEvent m_OnSubmit; // 0x160
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private TMP_InputField.SelectionEvent m_OnSelect; // 0x168
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private TMP_InputField.SelectionEvent m_OnDeselect; // 0x170
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private TMP_InputField.TextSelectionEvent m_OnTextSelection; // 0x178
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private TMP_InputField.TextSelectionEvent m_OnEndTextSelection; // 0x180
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private TMP_InputField.OnChangeEvent m_OnValueChanged; // 0x188
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private TMP_InputField.TouchScreenKeyboardEvent m_OnTouchScreenKeyboardStatusChanged; // 0x190
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private TMP_InputField.OnValidateInput m_OnValidateInput; // 0x198
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Color m_CaretColor; // 0x1A0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool m_CustomCaretColor; // 0x1B0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Color m_SelectionColor; // 0x1B4
	[SerializeField] // RVA: 0xD07D0 Offset: 0xCFBD0 VA: 0x1800D07D0
	[TextAreaAttribute] // RVA: 0xD07D0 Offset: 0xCFBD0 VA: 0x1800D07D0
	protected string m_Text; // 0x1C8
	[SerializeField] // RVA: 0xD0850 Offset: 0xCFC50 VA: 0x1800D0850
	[RangeAttribute] // RVA: 0xD0850 Offset: 0xCFC50 VA: 0x1800D0850
	private float m_CaretBlinkRate; // 0x1D0
	[SerializeField] // RVA: 0xD0920 Offset: 0xCFD20 VA: 0x1800D0920
	[RangeAttribute] // RVA: 0xD0920 Offset: 0xCFD20 VA: 0x1800D0920
	private int m_CaretWidth; // 0x1D4
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool m_ReadOnly; // 0x1D8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected TMP_FontAsset m_GlobalFontAsset; // 0x268
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected bool m_OnFocusSelectAll; // 0x270
	protected bool m_isSelectAll; // 0x271
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected bool m_ResetOnDeActivation; // 0x272
	private bool m_SelectionStillActive; // 0x273
	private bool m_ReleaseSelection; // 0x274
	private GameObject m_SelectedObject; // 0x278
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool m_RestoreOriginalTextOnEscape; // 0x280
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected bool m_isRichTextEditingAllowed; // 0x281
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected int m_LineLimit; // 0x284
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0xC82F20 Offset: 0xC81520 VA: 0x180C82F20
	private BaseInput get_inputSystem() { }

	// RVA: 0xC82DC0 Offset: 0xC813C0 VA: 0x180C82DC0
	private string get_compositionString() { }

	// RVA: 0xC82980 Offset: 0xC80F80 VA: 0x180C82980
	protected void .ctor() { }

	// RVA: 0xC830A0 Offset: 0xC816A0 VA: 0x180C830A0
	protected Mesh get_mesh() { }

	// RVA: 0xC833E0 Offset: 0xC819E0 VA: 0x180C833E0
	public bool get_shouldHideMobileInput() { }

	// RVA: 0xC84860 Offset: 0xC82E60 VA: 0x180C84860
	public void set_shouldHideMobileInput(bool value) { }

	// RVA: 0xC83410 Offset: 0xC81A10 VA: 0x180C83410
	public bool get_shouldHideSoftKeyboard() { }

	// RVA: 0xC848E0 Offset: 0xC82EE0 VA: 0x180C848E0
	public void set_shouldHideSoftKeyboard(bool value) { }

	// RVA: 0xC83470 Offset: 0xC81A70 VA: 0x180C83470
	private bool isKeyboardUsingEvents() { }

	// RVA: 0xC83460 Offset: 0xC81A60 VA: 0x180C83460
	public string get_text() { }

	// RVA: 0xC84C00 Offset: 0xC83200 VA: 0x180C84C00
	public void set_text(string value) { }

	// RVA: 0xC816D0 Offset: 0xC7FCD0 VA: 0x180C816D0
	public void SetTextWithoutNotify(string input) { }

	// RVA: 0xC816E0 Offset: 0xC7FCE0 VA: 0x180C816E0
	private void SetText(string value, bool sendCallback = True) { }

	// RVA: 0xC83060 Offset: 0xC81660 VA: 0x180C83060
	public bool get_isFocused() { }

	// RVA: 0x745B70 Offset: 0x744170 VA: 0x180745B70
	public float get_caretBlinkRate() { }

	// RVA: 0xC83500 Offset: 0xC81B00 VA: 0x180C83500
	public void set_caretBlinkRate(float value) { }

	// RVA: 0xC82D80 Offset: 0xC81380 VA: 0x180C82D80
	public int get_caretWidth() { }

	// RVA: 0xC837D0 Offset: 0xC81DD0 VA: 0x180C837D0
	public void set_caretWidth(int value) { }

	// RVA: 0xC73B60 Offset: 0xC72160 VA: 0x180C73B60
	public RectTransform get_textViewport() { }

	// RVA: 0xC84BB0 Offset: 0xC831B0 VA: 0x180C84BB0
	public void set_textViewport(RectTransform value) { }

	// RVA: 0xB0EDC0 Offset: 0xB0D3C0 VA: 0x180B0EDC0
	public TMP_Text get_textComponent() { }

	// RVA: 0xC84B50 Offset: 0xC83150 VA: 0x180C84B50
	public void set_textComponent(TMP_Text value) { }

	// RVA: 0xC831A0 Offset: 0xC817A0 VA: 0x180C831A0
	public Graphic get_placeholder() { }

	// RVA: 0xC84280 Offset: 0xC82880 VA: 0x180C84280
	public void set_placeholder(Graphic value) { }

	// RVA: 0x871D30 Offset: 0x870330 VA: 0x180871D30
	public Scrollbar get_verticalScrollbar() { }

	// RVA: 0xC84C10 Offset: 0xC83210 VA: 0x180C84C10
	public void set_verticalScrollbar(Scrollbar value) { }

	// RVA: 0xC83360 Offset: 0xC81960 VA: 0x180C83360
	public float get_scrollSensitivity() { }

	// RVA: 0xC844F0 Offset: 0xC82AF0 VA: 0x180C844F0
	public void set_scrollSensitivity(float value) { }

	// RVA: 0xC82CC0 Offset: 0xC812C0 VA: 0x180C82CC0
	public Color get_caretColor() { }

	// RVA: 0xC83570 Offset: 0xC81B70 VA: 0x180C83570
	public void set_caretColor(Color value) { }

	// RVA: 0xC82E80 Offset: 0xC81480 VA: 0x180C82E80
	public bool get_customCaretColor() { }

	// RVA: 0xC83B50 Offset: 0xC82150 VA: 0x180C83B50
	public void set_customCaretColor(bool value) { }

	// RVA: 0xC83370 Offset: 0xC81970 VA: 0x180C83370
	public Color get_selectionColor() { }

	// RVA: 0xC84620 Offset: 0xC82C20 VA: 0x180C84620
	public void set_selectionColor(Color value) { }

	// RVA: 0xC83160 Offset: 0xC81760 VA: 0x180C83160
	public TMP_InputField.SubmitEvent get_onEndEdit() { }

	// RVA: 0xC83FF0 Offset: 0xC825F0 VA: 0x180C83FF0
	public void set_onEndEdit(TMP_InputField.SubmitEvent value) { }

	// RVA: 0x7E6DA0 Offset: 0x7E53A0 VA: 0x1807E6DA0
	public TMP_InputField.SubmitEvent get_onSubmit() { }

	// RVA: 0xC840F0 Offset: 0xC826F0 VA: 0x180C840F0
	public void set_onSubmit(TMP_InputField.SubmitEvent value) { }

	// RVA: 0xA3C6F0 Offset: 0xA3ACF0 VA: 0x180A3C6F0
	public TMP_InputField.SelectionEvent get_onSelect() { }

	// RVA: 0xC840A0 Offset: 0xC826A0 VA: 0x180C840A0
	public void set_onSelect(TMP_InputField.SelectionEvent value) { }

	// RVA: 0x900010 Offset: 0x8FE610 VA: 0x180900010
	public TMP_InputField.SelectionEvent get_onDeselect() { }

	// RVA: 0xC83FA0 Offset: 0xC825A0 VA: 0x180C83FA0
	public void set_onDeselect(TMP_InputField.SelectionEvent value) { }

	// RVA: 0xC83190 Offset: 0xC81790 VA: 0x180C83190
	public TMP_InputField.TextSelectionEvent get_onTextSelection() { }

	// RVA: 0xC84140 Offset: 0xC82740 VA: 0x180C84140
	public void set_onTextSelection(TMP_InputField.TextSelectionEvent value) { }

	// RVA: 0xC83170 Offset: 0xC81770 VA: 0x180C83170
	public TMP_InputField.TextSelectionEvent get_onEndTextSelection() { }

	// RVA: 0xC84040 Offset: 0xC82640 VA: 0x180C84040
	public void set_onEndTextSelection(TMP_InputField.TextSelectionEvent value) { }

	// RVA: 0xB0E690 Offset: 0xB0CC90 VA: 0x180B0E690
	public TMP_InputField.OnChangeEvent get_onValueChanged() { }

	// RVA: 0xC84230 Offset: 0xC82830 VA: 0x180C84230
	public void set_onValueChanged(TMP_InputField.OnChangeEvent value) { }

	// RVA: 0xC73B70 Offset: 0xC72170 VA: 0x180C73B70
	public TMP_InputField.TouchScreenKeyboardEvent get_onTouchScreenKeyboardStatusChanged() { }

	// RVA: 0xC84190 Offset: 0xC82790 VA: 0x180C84190
	public void set_onTouchScreenKeyboardStatusChanged(TMP_InputField.TouchScreenKeyboardEvent value) { }

	// RVA: 0xAD8B30 Offset: 0xAD7130 VA: 0x180AD8B30
	public TMP_InputField.OnValidateInput get_onValidateInput() { }

	// RVA: 0xC841E0 Offset: 0xC827E0 VA: 0x180C841E0
	public void set_onValidateInput(TMP_InputField.OnValidateInput value) { }

	// RVA: 0xC82D90 Offset: 0xC81390 VA: 0x180C82D90
	public int get_characterLimit() { }

	// RVA: 0xC83870 Offset: 0xC81E70 VA: 0x180C83870
	public void set_characterLimit(int value) { }

	// RVA: 0xC831B0 Offset: 0xC817B0 VA: 0x180C831B0
	public float get_pointSize() { }

	// RVA: 0xC842D0 Offset: 0xC828D0 VA: 0x180C842D0
	public void set_pointSize(float value) { }

	// RVA: 0xC82EA0 Offset: 0xC814A0 VA: 0x180C82EA0
	public TMP_FontAsset get_fontAsset() { }

	// RVA: 0xC83BC0 Offset: 0xC821C0 VA: 0x180C83BC0
	public void set_fontAsset(TMP_FontAsset value) { }

	// RVA: 0xC83180 Offset: 0xC81780 VA: 0x180C83180
	public bool get_onFocusSelectAll() { }

	// RVA: 0xC84090 Offset: 0xC82690 VA: 0x180C84090
	public void set_onFocusSelectAll(bool value) { }

	// RVA: 0xC83340 Offset: 0xC81940 VA: 0x180C83340
	public bool get_resetOnDeActivation() { }

	// RVA: 0xC84440 Offset: 0xC82A40 VA: 0x180C84440
	public void set_resetOnDeActivation(bool value) { }

	// RVA: 0xC83350 Offset: 0xC81950 VA: 0x180C83350
	public bool get_restoreOriginalTextOnEscape() { }

	// RVA: 0xC84450 Offset: 0xC82A50 VA: 0x180C84450
	public void set_restoreOriginalTextOnEscape(bool value) { }

	// RVA: 0xC83070 Offset: 0xC81670 VA: 0x180C83070
	public bool get_isRichTextEditingAllowed() { }

	// RVA: 0xC83DD0 Offset: 0xC823D0 VA: 0x180C83DD0
	public void set_isRichTextEditingAllowed(bool value) { }

	// RVA: 0xC82E70 Offset: 0xC81470 VA: 0x180C82E70
	public TMP_InputField.ContentType get_contentType() { }

	// RVA: 0xC839A0 Offset: 0xC81FA0 VA: 0x180C839A0
	public void set_contentType(TMP_InputField.ContentType value) { }

	// RVA: 0x871D20 Offset: 0x870320 VA: 0x180871D20
	public TMP_InputField.LineType get_lineType() { }

	// RVA: 0xC83EC0 Offset: 0xC824C0 VA: 0x180C83EC0
	public void set_lineType(TMP_InputField.LineType value) { }

	// RVA: 0xC83090 Offset: 0xC81690 VA: 0x180C83090
	public int get_lineLimit() { }

	// RVA: 0xC83E50 Offset: 0xC82450 VA: 0x180C83E50
	public void set_lineLimit(int value) { }

	// RVA: 0xC83040 Offset: 0xC81640 VA: 0x180C83040
	public TMP_InputField.InputType get_inputType() { }

	// RVA: 0xC83CF0 Offset: 0xC822F0 VA: 0x180C83CF0
	public void set_inputType(TMP_InputField.InputType value) { }

	// RVA: 0xC83080 Offset: 0xC81680 VA: 0x180C83080
	public TouchScreenKeyboardType get_keyboardType() { }

	// RVA: 0xC83DE0 Offset: 0xC823E0 VA: 0x180C83DE0
	public void set_keyboardType(TouchScreenKeyboardType value) { }

	// RVA: 0xC82DA0 Offset: 0xC813A0 VA: 0x180C82DA0
	public TMP_InputField.CharacterValidation get_characterValidation() { }

	// RVA: 0xC83920 Offset: 0xC81F20 VA: 0x180C83920
	public void set_characterValidation(TMP_InputField.CharacterValidation value) { }

	// RVA: 0xC83050 Offset: 0xC81650 VA: 0x180C83050
	public TMP_InputValidator get_inputValidator() { }

	// RVA: 0xC83D60 Offset: 0xC82360 VA: 0x180C83D60
	public void set_inputValidator(TMP_InputValidator value) { }

	// RVA: 0xC83330 Offset: 0xC81930 VA: 0x180C83330
	public bool get_readOnly() { }

	// RVA: 0xC84430 Offset: 0xC82A30 VA: 0x180C84430
	public void set_readOnly(bool value) { }

	// RVA: 0xBC7980 Offset: 0xBC5F80 VA: 0x180BC7980
	public bool get_richText() { }

	// RVA: 0xC84460 Offset: 0xC82A60 VA: 0x180C84460
	public void set_richText(bool value) { }

	// RVA: 0xC83140 Offset: 0xC81740 VA: 0x180C83140
	public bool get_multiLine() { }

	// RVA: 0xC82CB0 Offset: 0xC812B0 VA: 0x180C82CB0
	public char get_asteriskChar() { }

	// RVA: 0xC834A0 Offset: 0xC81AA0 VA: 0x180C834A0
	public void set_asteriskChar(char value) { }

	// RVA: 0x8F9F60 Offset: 0x8F8560 VA: 0x1808F9F60
	public bool get_wasCanceled() { }

	// RVA: 0xC76BD0 Offset: 0xC751D0 VA: 0x180C76BD0
	protected void ClampStringPos(ref int pos) { }

	// RVA: 0xC76B80 Offset: 0xC75180 VA: 0x180C76B80
	protected void ClampCaretPos(ref int pos) { }

	// RVA: 0xC82D20 Offset: 0xC81320 VA: 0x180C82D20
	protected int get_caretPositionInternal() { }

	// RVA: 0xC83620 Offset: 0xC81C20 VA: 0x180C83620
	protected void set_caretPositionInternal(int value) { }

	// RVA: 0xC83380 Offset: 0xC81980 VA: 0x180C83380
	protected int get_stringPositionInternal() { }

	// RVA: 0xC849E0 Offset: 0xC82FE0 VA: 0x180C849E0
	protected void set_stringPositionInternal(int value) { }

	// RVA: 0xC82D50 Offset: 0xC81350 VA: 0x180C82D50
	protected int get_caretSelectPositionInternal() { }

	// RVA: 0xC83770 Offset: 0xC81D70 VA: 0x180C83770
	protected void set_caretSelectPositionInternal(int value) { }

	// RVA: 0xC833B0 Offset: 0xC819B0 VA: 0x180C833B0
	protected int get_stringSelectPositionInternal() { }

	// RVA: 0xC84B00 Offset: 0xC83100 VA: 0x180C84B00
	protected void set_stringSelectPositionInternal(int value) { }

	// RVA: 0xC82EB0 Offset: 0xC814B0 VA: 0x180C82EB0
	private bool get_hasSelection() { }

	// RVA: 0xC82D50 Offset: 0xC81350 VA: 0x180C82D50
	public int get_caretPosition() { }

	// RVA: 0xC83680 Offset: 0xC81C80 VA: 0x180C83680
	public void set_caretPosition(int value) { }

	// RVA: 0xC82D20 Offset: 0xC81320 VA: 0x180C82D20
	public int get_selectionAnchorPosition() { }

	// RVA: 0xC84590 Offset: 0xC82B90 VA: 0x180C84590
	public void set_selectionAnchorPosition(int value) { }

	// RVA: 0xC82D50 Offset: 0xC81350 VA: 0x180C82D50
	public int get_selectionFocusPosition() { }

	// RVA: 0xC846D0 Offset: 0xC82CD0 VA: 0x180C846D0
	public void set_selectionFocusPosition(int value) { }

	// RVA: 0xC833B0 Offset: 0xC819B0 VA: 0x180C833B0
	public int get_stringPosition() { }

	// RVA: 0xC84A30 Offset: 0xC83030 VA: 0x180C84A30
	public void set_stringPosition(int value) { }

	// RVA: 0xC83380 Offset: 0xC81980 VA: 0x180C83380
	public int get_selectionStringAnchorPosition() { }

	// RVA: 0xC84760 Offset: 0xC82D60 VA: 0x180C84760
	public void set_selectionStringAnchorPosition(int value) { }

	// RVA: 0xC833B0 Offset: 0xC819B0 VA: 0x180C833B0
	public int get_selectionStringFocusPosition() { }

	// RVA: 0xC847E0 Offset: 0xC82DE0 VA: 0x180C847E0
	public void set_selectionStringFocusPosition(int value) { }

	// RVA: 0xC7E900 Offset: 0xC7CF00 VA: 0x180C7E900 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0xC7E010 Offset: 0xC7C610 VA: 0x180C7E010 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0xC7DD90 Offset: 0xC7C390 VA: 0x180C7DD90
	private void ON_TEXT_CHANGED(Object obj) { }

	[IteratorStateMachineAttribute] // RVA: 0xD1160 Offset: 0xD0560 VA: 0x1800D1160
	// RVA: 0xC76B10 Offset: 0xC75110 VA: 0x180C76B10
	private IEnumerator CaretBlink() { }

	// RVA: 0xC81360 Offset: 0xC7F960 VA: 0x180C81360
	private void SetCaretVisible() { }

	// RVA: 0xC81290 Offset: 0xC7F890 VA: 0x180C81290
	private void SetCaretActive() { }

	// RVA: 0xC7F520 Offset: 0xC7DB20 VA: 0x180C7F520
	protected void OnFocus() { }

	// RVA: 0xC80E20 Offset: 0xC7F420 VA: 0x180C80E20
	protected void SelectAll() { }

	// RVA: 0xC7D030 Offset: 0xC7B630 VA: 0x180C7D030
	public void MoveTextEnd(bool shift) { }

	// RVA: 0xC7D280 Offset: 0xC7B880 VA: 0x180C7D280
	public void MoveTextStart(bool shift) { }

	// RVA: 0xC7D4B0 Offset: 0xC7BAB0 VA: 0x180C7D4B0
	public void MoveToEndOfLine(bool shift, bool ctrl) { }

	// RVA: 0xC7D760 Offset: 0xC7BD60 VA: 0x180C7D760
	public void MoveToStartOfLine(bool shift, bool ctrl) { }

	// RVA: 0xC82DB0 Offset: 0xC813B0 VA: 0x180C82DB0
	private static string get_clipboard() { }

	// RVA: 0xC83990 Offset: 0xC81F90 VA: 0x180C83990
	private static void set_clipboard(string value) { }

	// RVA: 0xC799E0 Offset: 0xC77FE0 VA: 0x180C799E0
	private bool InPlaceEditing() { }

	// RVA: 0xC81EE0 Offset: 0xC804E0 VA: 0x180C81EE0
	private void UpdateStringPositionFromKeyboard() { }

	// RVA: 0xC7A1C0 Offset: 0xC787C0 VA: 0x180C7A1C0 Slot: 60
	protected virtual void LateUpdate() { }

	// RVA: 0xC7AED0 Offset: 0xC794D0 VA: 0x180C7AED0
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0xC7DF70 Offset: 0xC7C570 VA: 0x180C7DF70 Slot: 61
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0xC7E340 Offset: 0xC7C940 VA: 0x180C7E340 Slot: 62
	public virtual void OnDrag(PointerEventData eventData) { }

	[IteratorStateMachineAttribute] // RVA: 0xD12A0 Offset: 0xD06A0 VA: 0x1800D12A0
	// RVA: 0xC7AFE0 Offset: 0xC795E0 VA: 0x180C7AFE0
	private IEnumerator MouseDragOutsideRect(PointerEventData eventData) { }

	// RVA: 0xC7EF60 Offset: 0xC7D560 VA: 0x180C7EF60 Slot: 63
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0xC7F5C0 Offset: 0xC7DBC0 VA: 0x180C7F5C0 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0xC79D60 Offset: 0xC78360 VA: 0x180C79D60
	protected TMP_InputField.EditState KeyPressed(Event evt) { }

	// RVA: 0xC79D50 Offset: 0xC78350 VA: 0x180C79D50 Slot: 64
	protected virtual bool IsValidChar(char c) { }

	// RVA: 0xC80CE0 Offset: 0xC7F2E0 VA: 0x180C80CE0
	public void ProcessEvent(Event e) { }

	// RVA: 0xC803E0 Offset: 0xC7E9E0 VA: 0x180C803E0 Slot: 65
	public virtual void OnUpdateSelected(BaseEventData eventData) { }

	// RVA: 0xC800E0 Offset: 0xC7E6E0 VA: 0x180C800E0 Slot: 66
	public virtual void OnScroll(PointerEventData eventData) { }

	// RVA: 0xC79860 Offset: 0xC77E60 VA: 0x180C79860
	private string GetSelectedString() { }

	// RVA: 0xC77CD0 Offset: 0xC762D0 VA: 0x180C77CD0
	private int FindNextWordBegin() { }

	// RVA: 0xC7C7D0 Offset: 0xC7ADD0 VA: 0x180C7C7D0
	private void MoveRight(bool shift, bool ctrl) { }

	// RVA: 0xC77DE0 Offset: 0xC763E0 VA: 0x180C77DE0
	private int FindPrevWordBegin() { }

	// RVA: 0xC7B420 Offset: 0xC79A20 VA: 0x180C7B420
	private void MoveLeft(bool shift, bool ctrl) { }

	// RVA: 0xC7AB70 Offset: 0xC79170 VA: 0x180C7AB70
	private int LineUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	// RVA: 0xC7A870 Offset: 0xC78E70 VA: 0x180C7A870
	private int LineDownCharacterPosition(int originalPos, bool goToLastChar) { }

	// RVA: 0xC80920 Offset: 0xC7EF20 VA: 0x180C80920
	private int PageUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	// RVA: 0xC80540 Offset: 0xC7EB40 VA: 0x180C80540
	private int PageDownCharacterPosition(int originalPos, bool goToLastChar) { }

	// RVA: 0xC7B410 Offset: 0xC79A10 VA: 0x180C7B410
	private void MoveDown(bool shift) { }

	// RVA: 0xC7B070 Offset: 0xC79670 VA: 0x180C7B070
	private void MoveDown(bool shift, bool goToLastChar) { }

	// RVA: 0xC7DD80 Offset: 0xC7C380 VA: 0x180C7DD80
	private void MoveUp(bool shift) { }

	// RVA: 0xC7DA00 Offset: 0xC7C000 VA: 0x180C7DA00
	private void MoveUp(bool shift, bool goToFirstChar) { }

	// RVA: 0xC7C7C0 Offset: 0xC7ADC0 VA: 0x180C7C7C0
	private void MovePageUp(bool shift) { }

	// RVA: 0xC7C220 Offset: 0xC7A820 VA: 0x180C7C220
	private void MovePageUp(bool shift, bool goToFirstChar) { }

	// RVA: 0xC7C210 Offset: 0xC7A810 VA: 0x180C7C210
	private void MovePageDown(bool shift) { }

	// RVA: 0xC7BC50 Offset: 0xC7A250 VA: 0x180C7BC50
	private void MovePageDown(bool shift, bool goToLastChar) { }

	// RVA: 0xC77370 Offset: 0xC75970 VA: 0x180C77370
	private void Delete() { }

	// RVA: 0xC77000 Offset: 0xC75600 VA: 0x180C77000
	private void DeleteKey() { }

	// RVA: 0xC76560 Offset: 0xC74B60 VA: 0x180C76560
	private void Backspace() { }

	// RVA: 0xC75D10 Offset: 0xC74310 VA: 0x180C75D10 Slot: 67
	protected virtual void Append(string input) { }

	// RVA: 0xC75BA0 Offset: 0xC741A0 VA: 0x180C75BA0 Slot: 68
	protected virtual void Append(char input) { }

	// RVA: 0xC79AD0 Offset: 0xC780D0 VA: 0x180C79AD0
	private void Insert(char c) { }

	// RVA: 0xC821C0 Offset: 0xC807C0 VA: 0x180C821C0
	private void UpdateTouchKeyboardFromEditChanges() { }

	// RVA: 0xC81170 Offset: 0xC7F770 VA: 0x180C81170
	private void SendOnValueChangedAndUpdateLabel() { }

	// RVA: 0xC811D0 Offset: 0xC7F7D0 VA: 0x180C811D0
	private void SendOnValueChanged() { }

	// RVA: 0xC80E80 Offset: 0xC7F480 VA: 0x180C80E80
	protected void SendOnEndEdit() { }

	// RVA: 0xC81050 Offset: 0xC7F650 VA: 0x180C81050
	protected void SendOnSubmit() { }

	// RVA: 0xC81000 Offset: 0xC7F600 VA: 0x180C81000
	protected void SendOnFocus() { }

	// RVA: 0xC80FB0 Offset: 0xC7F5B0 VA: 0x180C80FB0
	protected void SendOnFocusLost() { }

	// RVA: 0xC810A0 Offset: 0xC7F6A0 VA: 0x180C810A0
	protected void SendOnTextSelection() { }

	// RVA: 0xC80ED0 Offset: 0xC7F4D0 VA: 0x180C80ED0
	protected void SendOnEndTextSelection() { }

	// RVA: 0xC81220 Offset: 0xC7F820 VA: 0x180C81220
	protected void SendTouchScreenKeyboardStatusChanged() { }

	// RVA: 0xC81990 Offset: 0xC7FF90 VA: 0x180C81990
	protected void UpdateLabel() { }

	// RVA: 0xC81D30 Offset: 0xC80330 VA: 0x180C81D30
	private void UpdateScrollbar() { }

	// RVA: 0xC80290 Offset: 0xC7E890 VA: 0x180C80290
	private void OnScrollbarValueChange(float value) { }

	// RVA: 0xC759F0 Offset: 0xC73FF0 VA: 0x180C759F0
	private void AdjustTextPositionRelativeToViewport(float relativePosition) { }

	// RVA: 0xC79760 Offset: 0xC77D60 VA: 0x180C79760
	private int GetCaretPositionFromStringIndex(int stringIndex) { }

	// RVA: 0xC797E0 Offset: 0xC77DE0 VA: 0x180C797E0
	private int GetMinCaretPositionFromStringIndex(int stringIndex) { }

	// RVA: 0xC79760 Offset: 0xC77D60 VA: 0x180C79760
	private int GetMaxCaretPositionFromStringIndex(int stringIndex) { }

	// RVA: 0xC79960 Offset: 0xC77F60 VA: 0x180C79960
	private int GetStringIndexFromCaretPosition(int caretPosition) { }

	// RVA: 0xC77ED0 Offset: 0xC764D0 VA: 0x180C77ED0
	public void ForceLabelUpdate() { }

	// RVA: 0xC7AE70 Offset: 0xC79470 VA: 0x180C7AE70
	private void MarkGeometryAsDirty() { }

	// RVA: 0xC80CF0 Offset: 0xC7F2F0 VA: 0x180C80CF0 Slot: 69
	public virtual void Rebuild(CanvasUpdate update) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 70
	public virtual void LayoutComplete() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 71
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0xC818D0 Offset: 0xC7FED0 VA: 0x180C818D0
	private void UpdateGeometry() { }

	// RVA: 0xC75DC0 Offset: 0xC743C0 VA: 0x180C75DC0
	private void AssignPositioningIfNeeded() { }

	// RVA: 0xC7EF90 Offset: 0xC7D590 VA: 0x180C7EF90
	private void OnFillVBO(Mesh vbo) { }

	// RVA: 0xC77EE0 Offset: 0xC764E0 VA: 0x180C77EE0
	private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0xC76C10 Offset: 0xC75210 VA: 0x180C76C10
	private void CreateCursorVerts() { }

	// RVA: 0xC78970 Offset: 0xC76F70 VA: 0x180C78970
	private void GenerateHightlight(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0xC750F0 Offset: 0xC736F0 VA: 0x180C750F0
	private void AdjustRectTransformRelativeToViewport(Vector2 startPosition, float height, bool isCharVisible) { }

	// RVA: 0xC82210 Offset: 0xC80810 VA: 0x180C82210
	protected char Validate(string text, int pos, char ch) { }

	// RVA: 0xC74FA0 Offset: 0xC735A0 VA: 0x180C74FA0
	public void ActivateInputField() { }

	// RVA: 0xC74A00 Offset: 0xC73000 VA: 0x180C74A00
	private void ActivateInputFieldInternal() { }

	// RVA: 0xC802F0 Offset: 0xC7E8F0 VA: 0x180C802F0 Slot: 36
	public override void OnSelect(BaseEventData eventData) { }

	// RVA: 0xC7F590 Offset: 0xC7DB90 VA: 0x180C7F590 Slot: 72
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void OnControlClick() { }

	// RVA: 0xC80DC0 Offset: 0xC7F3C0 VA: 0x180C80DC0
	public void ReleaseSelection() { }

	// RVA: 0xC76DB0 Offset: 0xC753B0 VA: 0x180C76DB0
	public void DeactivateInputField(bool clearSelection = False) { }

	// RVA: 0xC7DFA0 Offset: 0xC7C5A0 VA: 0x180C7DFA0 Slot: 37
	public override void OnDeselect(BaseEventData eventData) { }

	// RVA: 0xC80350 Offset: 0xC7E950 VA: 0x180C80350 Slot: 73
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0xC77B60 Offset: 0xC76160 VA: 0x180C77B60
	private void EnforceContentType() { }

	// RVA: 0xC81610 Offset: 0xC7FC10 VA: 0x180C81610
	private void SetTextComponentWrapMode() { }

	// RVA: 0xC81580 Offset: 0xC7FB80 VA: 0x180C81580
	private void SetTextComponentRichTextMode() { }

	// RVA: 0xC81840 Offset: 0xC7FE40 VA: 0x180C81840
	private void SetToCustomIfContentTypeIsNot(TMP_InputField.ContentType[] allowedContentTypes) { }

	// RVA: 0xC818B0 Offset: 0xC7FEB0 VA: 0x180C818B0
	private void SetToCustom() { }

	// RVA: 0xC818B0 Offset: 0xC7FEB0 VA: 0x180C818B0
	private void SetToCustom(TMP_InputField.CharacterValidation characterValidation) { }

	// RVA: 0xC77B30 Offset: 0xC76130 VA: 0x180C77B30 Slot: 26
	protected override void DoStateTransition(Selectable.SelectionState state, bool instant) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 74
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 75
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 76
	public virtual float get_minWidth() { }

	// RVA: 0xC83270 Offset: 0xC81870 VA: 0x180C83270 Slot: 77
	public virtual float get_preferredWidth() { }

	// RVA: 0xC82E90 Offset: 0xC81490 VA: 0x180C82E90 Slot: 78
	public virtual float get_flexibleWidth() { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 79
	public virtual float get_minHeight() { }

	// RVA: 0xC831C0 Offset: 0xC817C0 VA: 0x180C831C0 Slot: 80
	public virtual float get_preferredHeight() { }

	// RVA: 0xC82E90 Offset: 0xC81490 VA: 0x180C82E90 Slot: 81
	public virtual float get_flexibleHeight() { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 82
	public virtual int get_layoutPriority() { }

	// RVA: 0xC81490 Offset: 0xC7FA90 VA: 0x180C81490
	public void SetGlobalPointSize(float pointSize) { }

	// RVA: 0xC813A0 Offset: 0xC7F9A0 VA: 0x180C813A0
	public void SetGlobalFontAsset(TMP_FontAsset fontAsset) { }

	// RVA: 0xC82910 Offset: 0xC80F10 VA: 0x180C82910
	private static void .cctor() { }

	// RVA: 0xABD310 Offset: 0xABB910 VA: 0x180ABD310 Slot: 46
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

	// RVA: 0xD97850 Offset: 0xD95E50 VA: 0x180D97850 Slot: 12
	public virtual char Invoke(string text, int charIndex, char addedChar) { }

	// RVA: 0xD97780 Offset: 0xD95D80 VA: 0x180D97780 Slot: 13
	public virtual IAsyncResult BeginInvoke(string text, int charIndex, char addedChar, AsyncCallback callback, object object) { }

	// RVA: 0xD97820 Offset: 0xD95E20 VA: 0x180D97820 Slot: 14
	public virtual char EndInvoke(IAsyncResult result) { }

}

public class TMP_InputField.SubmitEvent : UnityEvent<string> // TypeDefIndex: 6789
{	// Methods

	// RVA: 0xD97E30 Offset: 0xD96430 VA: 0x180D97E30
	public void .ctor() { }

}

public class TMP_InputField.OnChangeEvent : UnityEvent<string> // TypeDefIndex: 6790
{	// Methods

	// RVA: 0xD97740 Offset: 0xD95D40 VA: 0x180D97740
	public void .ctor() { }

}

public class TMP_InputField.SelectionEvent : UnityEvent<string> // TypeDefIndex: 6791
{	// Methods

	// RVA: 0xD97DF0 Offset: 0xD963F0 VA: 0x180D97DF0
	public void .ctor() { }

}

public class TMP_InputField.TextSelectionEvent : UnityEvent<string, int, int> // TypeDefIndex: 6792
{	// Methods

	// RVA: 0xDB5990 Offset: 0xDB3F90 VA: 0x180DB5990
	public void .ctor() { }

}

public class TMP_InputField.TouchScreenKeyboardEvent : UnityEvent<TouchScreenKeyboard.Status> // TypeDefIndex: 6793
{	// Methods

	// RVA: 0xDB59D0 Offset: 0xDB3FD0 VA: 0x180DB59D0
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

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xDB5A10 Offset: 0xDB4010 VA: 0x180DB5A10 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xDB5B60 Offset: 0xDB4160 VA: 0x180DB5B60 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xDB5BB0 Offset: 0xDB41B0 VA: 0x180DB5BB0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xDB5E60 Offset: 0xDB4460 VA: 0x180DB5E60 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

public abstract class TMP_InputValidator : ScriptableObject // TypeDefIndex: 6798
{	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract char Validate(ref string text, ref int pos, char ch);

	// RVA: 0x4C3AE0 Offset: 0x4C20E0 VA: 0x1804C3AE0
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
	|-RVA: 0x17ADAF0 Offset: 0x17AC0F0 VA: 0x1817ADAF0
	|-TMP_ListPool<object>.Get
	|-TMP_ListPool<Canvas>.Get
	|-TMP_ListPool<IMaterialModifier>.Get
	|-TMP_ListPool<Mask>.Get
	*/

	// RVA: -1 Offset: -1
	public static void Release(List<T> toRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ADC60 Offset: 0x17AC260 VA: 0x1817ADC60
	|-TMP_ListPool<object>.Release
	|-TMP_ListPool<Canvas>.Release
	|-TMP_ListPool<IMaterialModifier>.Release
	|-TMP_ListPool<Mask>.Release
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ADDE0 Offset: 0x17AC3E0 VA: 0x1817ADDE0
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
	|-RVA: 0xD65280 Offset: 0xD63880 VA: 0x180D65280
	|-TMP_ListPool.<>c<object>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5AD60 Offset: 0xD59360 VA: 0x180D5AD60
	|-TMP_ListPool.<>c<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <.cctor>b__3_0(List<T> l) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E8EB0 Offset: 0x15E74B0 VA: 0x1815E8EB0
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

	// RVA: 0xD9AC10 Offset: 0xD99210 VA: 0x180D9AC10
	private static void .cctor() { }

	// RVA: 0xD99B80 Offset: 0xD98180 VA: 0x180D99B80
	private static void OnPreRender(Camera cam) { }

	// RVA: 0xD99AF0 Offset: 0xD980F0 VA: 0x180D99AF0
	private static void OnPreRenderCanvas() { }

	// RVA: 0xD99720 Offset: 0xD97D20 VA: 0x180D99720
	public static Material GetStencilMaterial(Material baseMaterial, int stencilID) { }

	// RVA: 0xD9A5D0 Offset: 0xD98BD0 VA: 0x180D9A5D0
	public static void ReleaseStencilMaterial(Material stencilMaterial) { }

	// RVA: 0xD98B90 Offset: 0xD97190 VA: 0x180D98B90
	public static Material GetBaseMaterial(Material stencilMaterial) { }

	// RVA: 0xD9AB00 Offset: 0xD99100 VA: 0x180D9AB00
	public static Material SetStencil(Material material, int stencilID) { }

	// RVA: 0xD98120 Offset: 0xD96720 VA: 0x180D98120
	public static void AddMaskingMaterial(Material baseMaterial, Material stencilMaterial, int stencilID) { }

	// RVA: 0xD9A9C0 Offset: 0xD98FC0 VA: 0x180D9A9C0
	public static void RemoveStencilMaterial(Material stencilMaterial) { }

	// RVA: 0xD99C10 Offset: 0xD98210 VA: 0x180D99C10
	public static void ReleaseBaseMaterial(Material baseMaterial) { }

	// RVA: 0xD985A0 Offset: 0xD96BA0 VA: 0x180D985A0
	public static void ClearMaterials() { }

	// RVA: 0xD99330 Offset: 0xD97930 VA: 0x180D99330
	public static int GetStencilID(GameObject obj) { }

	// RVA: 0xD99160 Offset: 0xD97760 VA: 0x180D99160
	public static Material GetMaterialForRendering(MaskableGraphic graphic, Material baseMaterial) { }

	// RVA: 0xD98A30 Offset: 0xD97030 VA: 0x180D98A30
	private static Transform FindRootSortOverrideCanvas(Transform start) { }

	// RVA: 0xD98CF0 Offset: 0xD972F0 VA: 0x180D98CF0
	public static Material GetFallbackMaterial(Material sourceMaterial, Material targetMaterial) { }

	// RVA: 0xD97FF0 Offset: 0xD965F0 VA: 0x180D97FF0
	public static void AddFallbackMaterialReference(Material targetMaterial) { }

	// RVA: 0xD9A820 Offset: 0xD98E20 VA: 0x180D9A820
	public static void RemoveFallbackMaterialReference(Material targetMaterial) { }

	// RVA: 0xD98370 Offset: 0xD96970 VA: 0x180D98370
	public static void CleanupFallbackMaterials() { }

	// RVA: 0xD9A400 Offset: 0xD98A00 VA: 0x180D9A400
	public static void ReleaseFallbackMaterial(Material fallackMaterial) { }

	// RVA: 0xD98740 Offset: 0xD96D40 VA: 0x180D98740
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

	// RVA: 0xDB5EB0 Offset: 0xDB44B0 VA: 0x180DB5EB0
	internal bool <GetBaseMaterial>b__0(TMP_MaterialManager.MaskingMaterial item) { }

}

private sealed class TMP_MaterialManager.<>c__DisplayClass12_0 // TypeDefIndex: 6806
{	// Fields
	public Material stencilMaterial; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xDB5F30 Offset: 0xDB4530 VA: 0x180DB5F30
	internal bool <AddMaskingMaterial>b__0(TMP_MaterialManager.MaskingMaterial item) { }

}

private sealed class TMP_MaterialManager.<>c__DisplayClass13_0 // TypeDefIndex: 6807
{	// Fields
	public Material stencilMaterial; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xDB5FB0 Offset: 0xDB45B0 VA: 0x180DB5FB0
	internal bool <RemoveStencilMaterial>b__0(TMP_MaterialManager.MaskingMaterial item) { }

}

private sealed class TMP_MaterialManager.<>c__DisplayClass14_0 // TypeDefIndex: 6808
{	// Fields
	public Material baseMaterial; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xDB6030 Offset: 0xDB4630 VA: 0x180DB6030
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

	// RVA: 0x122700 Offset: 0x121B00 VA: 0x180122700
	public void .ctor(Mesh mesh, int size) { }

	// RVA: 0x122710 Offset: 0x121B10 VA: 0x180122710
	public void .ctor(Mesh mesh, int size, bool isVolumetric) { }

	// RVA: 0x122500 Offset: 0x121900 VA: 0x180122500
	public void ResizeMeshInfo(int size) { }

	// RVA: 0x122510 Offset: 0x121910 VA: 0x180122510
	public void ResizeMeshInfo(int size, bool isVolumetric) { }

	// RVA: 0x122450 Offset: 0x121850 VA: 0x180122450
	public void Clear() { }

	// RVA: 0x122310 Offset: 0x121710 VA: 0x180122310
	public void Clear(bool uploadChanges) { }

	// RVA: 0x1222D0 Offset: 0x1216D0 VA: 0x1801222D0
	public void ClearUnusedVertices() { }

	// RVA: 0x1221E0 Offset: 0x1215E0 VA: 0x1801221E0
	public void ClearUnusedVertices(int startIndex) { }

	// RVA: 0x122210 Offset: 0x121610 VA: 0x180122210
	public void ClearUnusedVertices(int startIndex, bool updateMesh) { }

	// RVA: 0x122520 Offset: 0x121920 VA: 0x180122520
	public void SortGeometry(VertexSortingOrder order) { }

	// RVA: 0x1225A0 Offset: 0x1219A0 VA: 0x1801225A0
	public void SortGeometry(IList<int> sortingOrder) { }

	// RVA: 0x1226F0 Offset: 0x121AF0 VA: 0x1801226F0
	public void SwapVertexData(int src, int dst) { }

	// RVA: 0xD9CF50 Offset: 0xD9B550 VA: 0x180D9CF50
	private static void .cctor() { }

}

internal class TMP_ObjectPool<T> // TypeDefIndex: 6811
{	// Fields
	private readonly Stack<T> m_Stack; // 0x0
	private readonly UnityAction<T> m_ActionOnGet; // 0x0
	private readonly UnityAction<T> m_ActionOnRelease; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int <countAll>k__BackingField; // 0x0

	// Properties
	public int countAll { get; set; }
	public int countActive { get; }
	public int countInactive { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	public int get_countAll() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	|-TMP_ObjectPool<object>.get_countAll
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	private void set_countAll(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7D0C50 Offset: 0x7CF250 VA: 0x1807D0C50
	|-TMP_ObjectPool<object>.set_countAll
	*/

	// RVA: -1 Offset: -1
	public int get_countActive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AE330 Offset: 0x17AC930 VA: 0x1817AE330
	|-TMP_ObjectPool<object>.get_countActive
	*/

	// RVA: -1 Offset: -1
	public int get_countInactive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE07B10 Offset: 0xE06110 VA: 0x180E07B10
	|-TMP_ObjectPool<object>.get_countInactive
	*/

	// RVA: -1 Offset: -1
	public void .ctor(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AE270 Offset: 0x17AC870 VA: 0x1817AE270
	|-TMP_ObjectPool<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public T Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AE080 Offset: 0x17AC680 VA: 0x1817AE080
	|-TMP_ObjectPool<object>.Get
	*/

	// RVA: -1 Offset: -1
	public void Release(T element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AE170 Offset: 0x17AC770 VA: 0x1817AE170
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

	// RVA: 0x1177C0 Offset: 0x116BC0 VA: 0x1801177C0
	public void Clear() { }

	// RVA: 0x117740 Offset: 0x116B40 VA: 0x180117740
	public byte Add(FontStyles style) { }

	// RVA: 0x1177D0 Offset: 0x116BD0 VA: 0x1801177D0
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
	|-RVA: 0x210500 Offset: 0x20F900 VA: 0x180210500
	|-TMP_RichTextTagStack<int>..ctor
	|-TMP_RichTextTagStack<Int32Enum>..ctor
	|-TMP_RichTextTagStack<float>..ctor
	|-TMP_RichTextTagStack<TextAlignmentOptions>..ctor
	|-TMP_RichTextTagStack<Color32>..ctor
	|
	|-RVA: 0x210650 Offset: 0x20FA50 VA: 0x180210650
	|-TMP_RichTextTagStack<object>..ctor
	|-TMP_RichTextTagStack<TMP_ColorGradient>..ctor
	|
	|-RVA: 0x210730 Offset: 0x20FB30 VA: 0x180210730
	|-TMP_RichTextTagStack<MaterialReference>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x210550 Offset: 0x20F950 VA: 0x180210550
	|-TMP_RichTextTagStack<int>..ctor
	|-TMP_RichTextTagStack<Int32Enum>..ctor
	|-TMP_RichTextTagStack<float>..ctor
	|-TMP_RichTextTagStack<FontWeight>..ctor
	|-TMP_RichTextTagStack<Color32>..ctor
	|
	|-RVA: 0x2105D0 Offset: 0x20F9D0 VA: 0x1802105D0
	|-TMP_RichTextTagStack<object>..ctor
	|
	|-RVA: 0x2106A0 Offset: 0x20FAA0 VA: 0x1802106A0
	|-TMP_RichTextTagStack<MaterialReference>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20F5A0 Offset: 0x20E9A0 VA: 0x18020F5A0
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
	|-RVA: 0x2103D0 Offset: 0x20F7D0 VA: 0x1802103D0
	|-TMP_RichTextTagStack<int>.SetDefault
	|-TMP_RichTextTagStack<Int32Enum>.SetDefault
	|-TMP_RichTextTagStack<FontWeight>.SetDefault
	|-TMP_RichTextTagStack<TextAlignmentOptions>.SetDefault
	|-TMP_RichTextTagStack<Color32>.SetDefault
	|
	|-RVA: 0x210410 Offset: 0x20F810 VA: 0x180210410
	|-TMP_RichTextTagStack<object>.SetDefault
	|-TMP_RichTextTagStack<TMP_ColorGradient>.SetDefault
	|
	|-RVA: 0x2104C0 Offset: 0x20F8C0 VA: 0x1802104C0
	|-TMP_RichTextTagStack<float>.SetDefault
	|
	|-RVA: 0x210460 Offset: 0x20F860 VA: 0x180210460
	|-TMP_RichTextTagStack<MaterialReference>.SetDefault
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20F460 Offset: 0x20E860 VA: 0x18020F460
	|-TMP_RichTextTagStack<int>.Add
	|-TMP_RichTextTagStack<Int32Enum>.Add
	|-TMP_RichTextTagStack<FontWeight>.Add
	|-TMP_RichTextTagStack<TextAlignmentOptions>.Add
	|-TMP_RichTextTagStack<Color32>.Add
	|
	|-RVA: 0x20F4A0 Offset: 0x20E8A0 VA: 0x18020F4A0
	|-TMP_RichTextTagStack<object>.Add
	|-TMP_RichTextTagStack<TMP_ColorGradient>.Add
	|
	|-RVA: 0x20F4F0 Offset: 0x20E8F0 VA: 0x18020F4F0
	|-TMP_RichTextTagStack<float>.Add
	|
	|-RVA: 0x20F530 Offset: 0x20E930 VA: 0x18020F530
	|-TMP_RichTextTagStack<MaterialReference>.Add
	*/

	// RVA: -1 Offset: -1
	public T Remove() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2102F0 Offset: 0x20F6F0 VA: 0x1802102F0
	|-TMP_RichTextTagStack<int>.Remove
	|-TMP_RichTextTagStack<Int32Enum>.Remove
	|-TMP_RichTextTagStack<FontWeight>.Remove
	|-TMP_RichTextTagStack<TextAlignmentOptions>.Remove
	|-TMP_RichTextTagStack<Color32>.Remove
	|
	|-RVA: 0x210360 Offset: 0x20F760 VA: 0x180210360
	|-TMP_RichTextTagStack<object>.Remove
	|-TMP_RichTextTagStack<TMP_ColorGradient>.Remove
	|
	|-RVA: 0x2101C0 Offset: 0x20F5C0 VA: 0x1802101C0
	|-TMP_RichTextTagStack<float>.Remove
	|
	|-RVA: 0x210240 Offset: 0x20F640 VA: 0x180210240
	|-TMP_RichTextTagStack<MaterialReference>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Push(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20FD10 Offset: 0x20F110 VA: 0x18020FD10
	|-TMP_RichTextTagStack<int>.Push
	|-TMP_RichTextTagStack<Int32Enum>.Push
	|
	|-RVA: 0x20FFE0 Offset: 0x20F3E0 VA: 0x18020FFE0
	|-TMP_RichTextTagStack<object>.Push
	|
	|-RVA: 0x2100D0 Offset: 0x20F4D0 VA: 0x1802100D0
	|-TMP_RichTextTagStack<float>.Push
	|
	|-RVA: 0x20FDF0 Offset: 0x20F1F0 VA: 0x18020FDF0
	|-TMP_RichTextTagStack<MaterialReference>.Push
	|
	|-RVA: 0x20FF00 Offset: 0x20F300 VA: 0x18020FF00
	|-TMP_RichTextTagStack<Color32>.Push
	*/

	// RVA: -1 Offset: -1
	public T Pop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20F9F0 Offset: 0x20EDF0 VA: 0x18020F9F0
	|-TMP_RichTextTagStack<int>.Pop
	|-TMP_RichTextTagStack<Int32Enum>.Pop
	|-TMP_RichTextTagStack<Color32>.Pop
	|
	|-RVA: 0x20FA50 Offset: 0x20EE50 VA: 0x18020FA50
	|-TMP_RichTextTagStack<object>.Pop
	|
	|-RVA: 0x20FAC0 Offset: 0x20EEC0 VA: 0x18020FAC0
	|-TMP_RichTextTagStack<float>.Pop
	|
	|-RVA: 0x20F900 Offset: 0x20ED00 VA: 0x18020F900
	|-TMP_RichTextTagStack<MaterialReference>.Pop
	*/

	// RVA: -1 Offset: -1
	public T Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20F790 Offset: 0x20EB90 VA: 0x18020F790
	|-TMP_RichTextTagStack<int>.Peek
	|-TMP_RichTextTagStack<Int32Enum>.Peek
	|-TMP_RichTextTagStack<FontWeight>.Peek
	|-TMP_RichTextTagStack<Color32>.Peek
	|
	|-RVA: 0x20F860 Offset: 0x20EC60 VA: 0x18020F860
	|-TMP_RichTextTagStack<object>.Peek
	|
	|-RVA: 0x20F8B0 Offset: 0x20ECB0 VA: 0x18020F8B0
	|-TMP_RichTextTagStack<float>.Peek
	|
	|-RVA: 0x20F7E0 Offset: 0x20EBE0 VA: 0x18020F7E0
	|-TMP_RichTextTagStack<MaterialReference>.Peek
	*/

	// RVA: -1 Offset: -1
	public T CurrentItem() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20F5B0 Offset: 0x20E9B0 VA: 0x18020F5B0
	|-TMP_RichTextTagStack<int>.CurrentItem
	|-TMP_RichTextTagStack<Int32Enum>.CurrentItem
	|-TMP_RichTextTagStack<Color32>.CurrentItem
	|
	|-RVA: 0x20F720 Offset: 0x20EB20 VA: 0x18020F720
	|-TMP_RichTextTagStack<object>.CurrentItem
	|
	|-RVA: 0x20F6B0 Offset: 0x20EAB0 VA: 0x18020F6B0
	|-TMP_RichTextTagStack<float>.CurrentItem
	|
	|-RVA: 0x20F610 Offset: 0x20EA10 VA: 0x18020F610
	|-TMP_RichTextTagStack<MaterialReference>.CurrentItem
	*/

	// RVA: -1 Offset: -1
	public T PreviousItem() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20FB20 Offset: 0x20EF20 VA: 0x18020FB20
	|-TMP_RichTextTagStack<int>.PreviousItem
	|-TMP_RichTextTagStack<Int32Enum>.PreviousItem
	|-TMP_RichTextTagStack<Color32>.PreviousItem
	|
	|-RVA: 0x20FB90 Offset: 0x20EF90 VA: 0x18020FB90
	|-TMP_RichTextTagStack<object>.PreviousItem
	|
	|-RVA: 0x20FCA0 Offset: 0x20F0A0 VA: 0x18020FCA0
	|-TMP_RichTextTagStack<float>.PreviousItem
	|
	|-RVA: 0x20FC00 Offset: 0x20F000 VA: 0x18020FC00
	|-TMP_RichTextTagStack<MaterialReference>.PreviousItem
	*/

}

public class TMP_ScrollbarEventHandler : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, ISelectHandler, IDeselectHandler // TypeDefIndex: 6818
{	// Fields
	public bool isSelected; // 0x18

	// Methods

	// RVA: 0xD9E3A0 Offset: 0xD9C9A0 VA: 0x180D9E3A0 Slot: 4
	public void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0xD9E3F0 Offset: 0xD9C9F0 VA: 0x180D9E3F0 Slot: 5
	public void OnSelect(BaseEventData eventData) { }

	// RVA: 0xD9E340 Offset: 0xD9C940 VA: 0x180D9E340 Slot: 6
	public void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class TMP_SelectionCaret : MaskableGraphic // TypeDefIndex: 6819
{	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 58
	public override void Cull(Rect clipRect, bool validRect) { }

	// RVA: 0xD9E450 Offset: 0xD9CA50 VA: 0x180D9E450
	public void .ctor() { }

}

public class TMP_Settings : ScriptableObject // TypeDefIndex: 6820
{	// Fields
	private static TMP_Settings s_Instance; // 0x0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool m_enableWordWrapping; // 0x18
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool m_enableKerning; // 0x19
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool m_enableExtraPadding; // 0x1A
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool m_enableTintAllSprites; // 0x1B
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool m_EnableRaycastTarget; // 0x1C
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool m_GetFontFeaturesAtRuntime; // 0x1D
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int m_missingGlyphCharacter; // 0x20
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool m_warningsDisabled; // 0x24
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private TMP_FontAsset m_defaultFontAsset; // 0x28
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private string m_defaultFontAssetPath; // 0x30
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float m_defaultFontSize; // 0x38
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float m_defaultAutoSizeMinRatio; // 0x3C
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float m_defaultAutoSizeMaxRatio; // 0x40
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Vector2 m_defaultTextMeshProTextContainerSize; // 0x44
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Vector2 m_defaultTextMeshProUITextContainerSize; // 0x4C
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool m_autoSizeTextContainer; // 0x54
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private List<TMP_FontAsset> m_fallbackFontAssets; // 0x58
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool m_matchMaterialPreset; // 0x60
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private string m_defaultColorGradientPresetsPath; // 0x68
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool m_enableEmojiSupport; // 0x70
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private TextAsset m_leadingCharacters; // 0x78
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private TextAsset m_followingCharacters; // 0x80
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0xD9ED60 Offset: 0xD9D360 VA: 0x180D9ED60
	public static string get_version() { }

	// RVA: 0xD9EA40 Offset: 0xD9D040 VA: 0x180D9EA40
	public static bool get_enableWordWrapping() { }

	// RVA: 0xD9E9E0 Offset: 0xD9CFE0 VA: 0x180D9E9E0
	public static bool get_enableKerning() { }

	// RVA: 0xD9E9C0 Offset: 0xD9CFC0 VA: 0x180D9E9C0
	public static bool get_enableExtraPadding() { }

	// RVA: 0xD9EA20 Offset: 0xD9D020 VA: 0x180D9EA20
	public static bool get_enableTintAllSprites() { }

	// RVA: 0xD9EA00 Offset: 0xD9D000 VA: 0x180D9EA00
	public static bool get_enableRaycastTarget() { }

	// RVA: 0xD9EAB0 Offset: 0xD9D0B0 VA: 0x180D9EAB0
	public static bool get_getFontFeaturesAtRuntime() { }

	// RVA: 0xD9ED40 Offset: 0xD9D340 VA: 0x180D9ED40
	public static int get_missingGlyphCharacter() { }

	// RVA: 0xD9EDE0 Offset: 0xD9D3E0 VA: 0x180D9EDE0
	public static void set_missingGlyphCharacter(int value) { }

	// RVA: 0xD9ED90 Offset: 0xD9D390 VA: 0x180D9ED90
	public static bool get_warningsDisabled() { }

	// RVA: 0xD9E8C0 Offset: 0xD9CEC0 VA: 0x180D9E8C0
	public static TMP_FontAsset get_defaultFontAsset() { }

	// RVA: 0xD9E8A0 Offset: 0xD9CEA0 VA: 0x180D9E8A0
	public static string get_defaultFontAssetPath() { }

	// RVA: 0xD9E8E0 Offset: 0xD9CEE0 VA: 0x180D9E8E0
	public static float get_defaultFontSize() { }

	// RVA: 0xD9E920 Offset: 0xD9CF20 VA: 0x180D9E920
	public static float get_defaultTextAutoSizingMinRatio() { }

	// RVA: 0xD9E900 Offset: 0xD9CF00 VA: 0x180D9E900
	public static float get_defaultTextAutoSizingMaxRatio() { }

	// RVA: 0xD9E940 Offset: 0xD9CF40 VA: 0x180D9E940
	public static Vector2 get_defaultTextMeshProTextContainerSize() { }

	// RVA: 0xD9E970 Offset: 0xD9CF70 VA: 0x180D9E970
	public static Vector2 get_defaultTextMeshProUITextContainerSize() { }

	// RVA: 0xD9E860 Offset: 0xD9CE60 VA: 0x180D9E860
	public static bool get_autoSizeTextContainer() { }

	// RVA: 0xD9EA60 Offset: 0xD9D060 VA: 0x180D9EA60
	public static List<TMP_FontAsset> get_fallbackFontAssets() { }

	// RVA: 0xD9ED20 Offset: 0xD9D320 VA: 0x180D9ED20
	public static bool get_matchMaterialPreset() { }

	// RVA: 0xD9E880 Offset: 0xD9CE80 VA: 0x180D9E880
	public static string get_defaultColorGradientPresetsPath() { }

	// RVA: 0xD9E9A0 Offset: 0xD9CFA0 VA: 0x180D9E9A0
	public static bool get_enableEmojiSupport() { }

	// RVA: 0xD9EDB0 Offset: 0xD9D3B0 VA: 0x180D9EDB0
	public static void set_enableEmojiSupport(bool value) { }

	// RVA: 0xD9EB80 Offset: 0xD9D180 VA: 0x180D9EB80
	public static TextAsset get_leadingCharacters() { }

	// RVA: 0xD9EA80 Offset: 0xD9D080 VA: 0x180D9EA80
	public static TextAsset get_followingCharacters() { }

	// RVA: 0xD9EBA0 Offset: 0xD9D1A0 VA: 0x180D9EBA0
	public static TMP_Settings.LineBreakingTable get_linebreakingRules() { }

	// RVA: 0xD9EAD0 Offset: 0xD9D0D0 VA: 0x180D9EAD0
	public static TMP_Settings get_instance() { }

	// RVA: 0xD9E630 Offset: 0xD9CC30 VA: 0x180D9E630
	public static TMP_Settings LoadDefaultSettings() { }

	// RVA: 0xD9E5C0 Offset: 0xD9CBC0 VA: 0x180D9E5C0
	public static TMP_Settings GetSettings() { }

	// RVA: 0xD9E540 Offset: 0xD9CB40 VA: 0x180D9E540
	public static TMP_FontAsset GetFontAsset() { }

	// RVA: 0xD9E710 Offset: 0xD9CD10 VA: 0x180D9E710
	public static void LoadLinebreakingRules() { }

	// RVA: 0xD9E460 Offset: 0xD9CA60 VA: 0x180D9E460
	private static Dictionary<int, char> GetCharacters(TextAsset file) { }

	// RVA: 0xD9E850 Offset: 0xD9CE50 VA: 0x180D9E850
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
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private TMP_FontAsset m_fontAsset; // 0x18
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Material m_material; // 0x20
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Material m_sharedMaterial; // 0x28
	private Material m_fallbackMaterial; // 0x30
	private Material m_fallbackSourceMaterial; // 0x38
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool m_isDefaultMaterial; // 0x40
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float m_padding; // 0x44
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Renderer m_renderer; // 0x48
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private MeshFilter m_meshFilter; // 0x50
	private Mesh m_mesh; // 0x58
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_fontAsset(TMP_FontAsset value) { }

	// RVA: 0xDA14D0 Offset: 0xD9FAD0 VA: 0x180DA14D0
	public Material get_material() { }

	// RVA: 0xDA1880 Offset: 0xD9FE80 VA: 0x180DA1880
	public void set_material(Material value) { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public Material get_sharedMaterial() { }

	// RVA: 0xDA1330 Offset: 0xD9F930 VA: 0x180DA1330
	public void set_sharedMaterial(Material value) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public Material get_fallbackMaterial() { }

	// RVA: 0xDA1700 Offset: 0xD9FD00 VA: 0x180DA1700
	public void set_fallbackMaterial(Material value) { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public Material get_fallbackSourceMaterial() { }

	// RVA: 0x6AD5B0 Offset: 0x6ABBB0 VA: 0x1806AD5B0
	public void set_fallbackSourceMaterial(Material value) { }

	// RVA: 0x8054F0 Offset: 0x803AF0 VA: 0x1808054F0
	public bool get_isDefaultMaterial() { }

	// RVA: 0x80FEF0 Offset: 0x80E4F0 VA: 0x18080FEF0
	public void set_isDefaultMaterial(bool value) { }

	// RVA: 0x8054E0 Offset: 0x803AE0 VA: 0x1808054E0
	public float get_padding() { }

	// RVA: 0x88AA90 Offset: 0x889090 VA: 0x18088AA90
	public void set_padding(float value) { }

	// RVA: 0xDA1660 Offset: 0xD9FC60 VA: 0x180DA1660
	public Renderer get_renderer() { }

	// RVA: 0xDA14E0 Offset: 0xD9FAE0 VA: 0x180DA14E0
	public MeshFilter get_meshFilter() { }

	// RVA: 0xDA1580 Offset: 0xD9FB80 VA: 0x180DA1580
	public Mesh get_mesh() { }

	// RVA: 0x4CF880 Offset: 0x4CDE80 VA: 0x1804CF880
	public void set_mesh(Mesh value) { }

	// RVA: 0xDA1020 Offset: 0xD9F620 VA: 0x180DA1020
	private void OnEnable() { }

	// RVA: 0xDA0F50 Offset: 0xD9F550 VA: 0x180DA0F50
	private void OnDisable() { }

	// RVA: 0xDA0E30 Offset: 0xD9F430 VA: 0x180DA0E30
	private void OnDestroy() { }

	// RVA: 0xDA0610 Offset: 0xD9EC10 VA: 0x180DA0610
	public static TMP_SubMesh AddSubTextObject(TextMeshPro textComponent, MaterialReference materialReference) { }

	// RVA: 0xDA0AA0 Offset: 0xD9F0A0 VA: 0x180DA0AA0
	public void DestroySelf() { }

	// RVA: 0xDA0B10 Offset: 0xD9F110 VA: 0x180DA0B10
	private Material GetMaterial(Material mat) { }

	// RVA: 0xDA09F0 Offset: 0xD9EFF0 VA: 0x180DA09F0
	private Material CreateMaterialInstance(Material source) { }

	// RVA: 0xDA0D80 Offset: 0xD9F380 VA: 0x180DA0D80
	private Material GetSharedMaterial() { }

	// RVA: 0xDA1330 Offset: 0xD9F930 VA: 0x180DA1330
	private void SetSharedMaterial(Material mat) { }

	// RVA: 0xDA0CF0 Offset: 0xD9F2F0 VA: 0x180DA0CF0
	public float GetPaddingForMaterial() { }

	// RVA: 0xDA1440 Offset: 0xD9FA40 VA: 0x180DA1440
	public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold) { }

	// RVA: 0xDA1370 Offset: 0xD9F970 VA: 0x180DA1370
	public void SetVerticesDirty() { }

	// RVA: 0xDA1220 Offset: 0xD9F820 VA: 0x180DA1220
	public void SetMaterialDirty() { }

	// RVA: 0xDA1220 Offset: 0xD9F820 VA: 0x180DA1220
	protected void UpdateMaterial() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class TMP_SubMeshUI : MaskableGraphic, IClippable, IMaskable, IMaterialModifier // TypeDefIndex: 6824
{	// Fields
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private TMP_FontAsset m_fontAsset; // 0xC8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Material m_material; // 0xD0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Material m_sharedMaterial; // 0xD8
	private Material m_fallbackMaterial; // 0xE0
	private Material m_fallbackSourceMaterial; // 0xE8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool m_isDefaultMaterial; // 0xF0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float m_padding; // 0xF4
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private CanvasRenderer m_canvasRenderer; // 0xF8
	private Mesh m_mesh; // 0x100
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private TextMeshProUGUI m_TextComponent; // 0x108
	private bool m_isRegisteredForEvents; // 0x110
	private bool m_materialDirty; // 0x111
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0xDA00E0 Offset: 0xD9E6E0 VA: 0x180DA00E0
	public TMP_FontAsset get_fontAsset() { }

	// RVA: 0xDA04C0 Offset: 0xD9EAC0 VA: 0x180DA04C0
	public void set_fontAsset(TMP_FontAsset value) { }

	// RVA: 0xDA0100 Offset: 0xD9E700 VA: 0x180DA0100 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0xDA0240 Offset: 0xD9E840 VA: 0x180DA0240 Slot: 32
	public override Material get_material() { }

	// RVA: 0xDA04E0 Offset: 0xD9EAE0 VA: 0x180DA04E0 Slot: 33
	public override void set_material(Material value) { }

	// RVA: 0xD9F470 Offset: 0xD9DA70 VA: 0x180D9F470
	public Material get_sharedMaterial() { }

	// RVA: 0xD9FCB0 Offset: 0xD9E2B0 VA: 0x180D9FCB0
	public void set_sharedMaterial(Material value) { }

	// RVA: 0x4EF3A0 Offset: 0x4ED9A0 VA: 0x1804EF3A0
	public Material get_fallbackMaterial() { }

	// RVA: 0xDA0320 Offset: 0xD9E920 VA: 0x180DA0320
	public void set_fallbackMaterial(Material value) { }

	// RVA: 0x872140 Offset: 0x870740 VA: 0x180872140
	public Material get_fallbackSourceMaterial() { }

	// RVA: 0x8721C0 Offset: 0x8707C0 VA: 0x1808721C0
	public void set_fallbackSourceMaterial(Material value) { }

	// RVA: 0xDA01D0 Offset: 0xD9E7D0 VA: 0x180DA01D0 Slot: 34
	public override Material get_materialForRendering() { }

	// RVA: 0xDA00F0 Offset: 0xD9E6F0 VA: 0x180DA00F0
	public bool get_isDefaultMaterial() { }

	// RVA: 0xDA04D0 Offset: 0xD9EAD0 VA: 0x180DA04D0
	public void set_isDefaultMaterial(bool value) { }

	// RVA: 0xDA0310 Offset: 0xD9E910 VA: 0x180DA0310
	public float get_padding() { }

	// RVA: 0xDA0600 Offset: 0xD9EC00 VA: 0x180DA0600
	public void set_padding(float value) { }

	// RVA: 0xDA0040 Offset: 0xD9E640 VA: 0x180DA0040
	public CanvasRenderer get_canvasRenderer() { }

	// RVA: 0xDA0250 Offset: 0xD9E850 VA: 0x180DA0250
	public Mesh get_mesh() { }

	// RVA: 0xA2AC20 Offset: 0xA29220 VA: 0x180A2AC20
	public void set_mesh(Mesh value) { }

	// RVA: 0xD9EE10 Offset: 0xD9D410 VA: 0x180D9EE10
	public static TMP_SubMeshUI AddSubTextObject(TextMeshProUGUI textComponent, MaterialReference materialReference) { }

	// RVA: 0xD9FAB0 Offset: 0xD9E0B0 VA: 0x180D9FAB0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0xD9F960 Offset: 0xD9DF60 VA: 0x180D9F960 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0xD9F7C0 Offset: 0xD9DDC0 VA: 0x180D9F7C0 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0xD9FB00 Offset: 0xD9E100 VA: 0x180D9FB00 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0xD9F480 Offset: 0xD9DA80 VA: 0x180D9F480 Slot: 57
	public override Material GetModifiedMaterial(Material baseMaterial) { }

	// RVA: 0xD9F5E0 Offset: 0xD9DBE0 VA: 0x180D9F5E0
	public float GetPaddingForMaterial() { }

	// RVA: 0xD9F680 Offset: 0xD9DC80 VA: 0x180D9F680
	public float GetPaddingForMaterial(Material mat) { }

	// RVA: 0xD9FFB0 Offset: 0xD9E5B0 VA: 0x180D9FFB0
	public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 26
	public override void SetAllDirty() { }

	// RVA: 0xD9FD20 Offset: 0xD9E320 VA: 0x180D9FD20 Slot: 28
	public override void SetVerticesDirty() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 27
	public override void SetLayoutDirty() { }

	// RVA: 0xD9FBF0 Offset: 0xD9E1F0 VA: 0x180D9FBF0 Slot: 29
	public override void SetMaterialDirty() { }

	// RVA: 0xD9FC30 Offset: 0xD9E230 VA: 0x180D9FC30
	public void SetPivotDirty() { }

	// RVA: 0xD9F270 Offset: 0xD9D870 VA: 0x180D9F270 Slot: 58
	public override void Cull(Rect clipRect, bool validRect) { }

	// RVA: 0xD9FE00 Offset: 0xD9E400 VA: 0x180D9FE00 Slot: 41
	protected override void UpdateGeometry() { }

	// RVA: 0xD9FB60 Offset: 0xD9E160 VA: 0x180D9FB60 Slot: 37
	public override void Rebuild(CanvasUpdate update) { }

	// RVA: 0xD9FBD0 Offset: 0xD9E1D0 VA: 0x180D9FBD0
	public void RefreshMaterial() { }

	// RVA: 0xD9FE50 Offset: 0xD9E450 VA: 0x180D9FE50 Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0xD9FBA0 Offset: 0xD9E1A0 VA: 0x180D9FBA0 Slot: 61
	public override void RecalculateClipping() { }

	// RVA: 0xD9FBB0 Offset: 0xD9E1B0 VA: 0x180D9FBB0 Slot: 62
	public override void RecalculateMasking() { }

	// RVA: 0xD9F470 Offset: 0xD9DA70 VA: 0x180D9F470
	private Material GetMaterial() { }

	// RVA: 0xD9F2B0 Offset: 0xD9D8B0 VA: 0x180D9F2B0
	private Material GetMaterial(Material mat) { }

	// RVA: 0xD9F1C0 Offset: 0xD9D7C0 VA: 0x180D9F1C0
	private Material CreateMaterialInstance(Material source) { }

	// RVA: 0xD9F710 Offset: 0xD9DD10 VA: 0x180D9F710
	private Material GetSharedMaterial() { }

	// RVA: 0xD9FCB0 Offset: 0xD9E2B0 VA: 0x180D9FCB0
	private void SetSharedMaterial(Material mat) { }

	// RVA: 0xD9E450 Offset: 0xD9CA50 VA: 0x180D9E450
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
	[SerializeField] // RVA: 0xD07D0 Offset: 0xCFBD0 VA: 0x1800D07D0
	[TextAreaAttribute] // RVA: 0xD07D0 Offset: 0xCFBD0 VA: 0x1800D07D0
	protected string m_text; // 0xC8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected bool m_isRightToLeft; // 0xD0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected TMP_FontAsset m_fontAsset; // 0xD8
	protected TMP_FontAsset m_currentFontAsset; // 0xE0
	protected bool m_isSDFShader; // 0xE8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected Material m_sharedMaterial; // 0xF0
	protected Material m_currentMaterial; // 0xF8
	protected MaterialReference[] m_materialReferences; // 0x100
	protected Dictionary<int, int> m_materialReferenceIndexLookup; // 0x108
	protected TMP_RichTextTagStack<MaterialReference> m_materialReferenceStack; // 0x110
	protected int m_currentMaterialIndex; // 0x150
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected Material[] m_fontSharedMaterials; // 0x158
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected Material m_fontMaterial; // 0x160
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected Material[] m_fontMaterials; // 0x168
	protected bool m_isMaterialDirty; // 0x170
	[SerializeField] // RVA: 0xD7000 Offset: 0xD6400 VA: 0x1800D7000
	[ColorUsageAttribute] // RVA: 0xD7000 Offset: 0xD6400 VA: 0x1800D7000
	protected Color32 m_fontColor32; // 0x174
	[SerializeField] // RVA: 0xD7000 Offset: 0xD6400 VA: 0x1800D7000
	[ColorUsageAttribute] // RVA: 0xD7000 Offset: 0xD6400 VA: 0x1800D7000
	protected Color m_fontColor; // 0x178
	protected static Color32 s_colorWhite; // 0x0
	protected Color32 m_underlineColor; // 0x188
	protected Color32 m_strikethroughColor; // 0x18C
	protected Color32 m_highlightColor; // 0x190
	protected Vector4 m_highlightPadding; // 0x194
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected bool m_enableVertexGradient; // 0x1A4
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected ColorMode m_colorMode; // 0x1A8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected VertexGradient m_fontColorGradient; // 0x1AC
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected TMP_ColorGradient m_fontColorGradientPreset; // 0x1F0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected bool m_overrideHtmlColors; // 0x1F8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected Color32 m_faceColor; // 0x1FC
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected Color32 m_outlineColor; // 0x200
	protected float m_outlineWidth; // 0x204
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected float m_fontSize; // 0x208
	protected float m_currentFontSize; // 0x20C
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected float m_fontSizeBase; // 0x210
	protected TMP_RichTextTagStack<float> m_sizeStack; // 0x218
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected FontWeight m_fontWeight; // 0x230
	protected FontWeight m_FontWeightInternal; // 0x234
	protected TMP_RichTextTagStack<FontWeight> m_FontWeightStack; // 0x238
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected bool m_enableAutoSizing; // 0x250
	protected float m_maxFontSize; // 0x254
	protected float m_minFontSize; // 0x258
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected float m_fontSizeMin; // 0x25C
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected float m_fontSizeMax; // 0x260
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected FontStyles m_fontStyle; // 0x264
	protected FontStyles m_FontStyleInternal; // 0x268
	protected TMP_FontStyleStack m_fontStyleStack; // 0x26C
	protected bool m_isUsingBold; // 0x276
	[SerializeField] // RVA: 0xD8DC0 Offset: 0xD81C0 VA: 0x1800D8DC0
	[FormerlySerializedAsAttribute] // RVA: 0xD8DC0 Offset: 0xD81C0 VA: 0x1800D8DC0
	protected TextAlignmentOptions m_textAlignment; // 0x278
	protected TextAlignmentOptions m_lineJustification; // 0x27C
	protected TMP_RichTextTagStack<TextAlignmentOptions> m_lineJustificationStack; // 0x280
	protected Vector3[] m_textContainerLocalCorners; // 0x298
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected float m_characterSpacing; // 0x2A0
	protected float m_cSpacing; // 0x2A4
	protected float m_monoSpacing; // 0x2A8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected float m_wordSpacing; // 0x2AC
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected float m_lineSpacing; // 0x2B0
	protected float m_lineSpacingDelta; // 0x2B4
	protected float m_lineHeight; // 0x2B8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected float m_lineSpacingMax; // 0x2BC
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected float m_paragraphSpacing; // 0x2C0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected float m_charWidthMaxAdj; // 0x2C4
	protected float m_charWidthAdjDelta; // 0x2C8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected bool m_enableWordWrapping; // 0x2CC
	protected bool m_isCharacterWrappingEnabled; // 0x2CD
	protected bool m_isNonBreakingSpace; // 0x2CE
	protected bool m_isIgnoringAlignment; // 0x2CF
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected float m_wordWrappingRatios; // 0x2D0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected TextOverflowModes m_overflowMode; // 0x2D4
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected int m_firstOverflowCharacterIndex; // 0x2D8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected TMP_Text m_linkedTextComponent; // 0x2E0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected bool m_isLinkedTextComponent; // 0x2E8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected bool m_isTextTruncated; // 0x2E9
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected bool m_enableKerning; // 0x2EA
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected bool m_enableExtraPadding; // 0x2EB
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected bool checkPaddingRequired; // 0x2EC
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected bool m_isRichText; // 0x2ED
	protected bool m_isOverlay; // 0x2EE
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected bool m_isOrthographic; // 0x2EF
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected bool m_isCullingEnabled; // 0x2F0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected bool m_ignoreRectMaskCulling; // 0x2F1
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected bool m_ignoreCulling; // 0x2F2
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected TextureMappingOptions m_horizontalMapping; // 0x2F4
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected TextureMappingOptions m_verticalMapping; // 0x2F8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected float m_uvLineOffset; // 0x2FC
	protected TextRenderFlags m_renderMode; // 0x300
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected VertexSortingOrder m_geometrySortingOrder; // 0x304
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected bool m_VertexBufferAutoSizeReduction; // 0x308
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected int m_firstVisibleCharacter; // 0x30C
	protected int m_maxVisibleCharacters; // 0x310
	protected int m_maxVisibleWords; // 0x314
	protected int m_maxVisibleLines; // 0x318
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected bool m_useMaxVisibleDescender; // 0x31C
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected int m_pageToDisplay; // 0x320
	protected bool m_isNewPage; // 0x324
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected Vector4 m_margin; // 0x328
	protected float m_marginLeft; // 0x338
	protected float m_marginRight; // 0x33C
	protected float m_marginWidth; // 0x340
	protected float m_marginHeight; // 0x344
	protected float m_width; // 0x348
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected TMP_TextInfo m_textInfo; // 0x350
	protected bool m_havePropertiesChanged; // 0x358
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected bool m_isUsingLegacyAnimationComponent; // 0x359
	protected Transform m_transform; // 0x360
	protected RectTransform m_rectTransform; // 0x368
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <autoSizeTextContainer>k__BackingField; // 0x370
	protected bool m_autoSizeTextContainer; // 0x371
	protected Mesh m_mesh; // 0x378
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0xDA00E0 Offset: 0xD9E6E0 VA: 0x180DA00E0
	public string get_text() { }

	// RVA: 0xDB57B0 Offset: 0xDB3DB0 VA: 0x180DB57B0
	public void set_text(string value) { }

	// RVA: 0xDB3C70 Offset: 0xDB2270 VA: 0x180DB3C70
	public bool get_isRightToLeftText() { }

	// RVA: 0xDB4FE0 Offset: 0xDB35E0 VA: 0x180DB4FE0
	public void set_isRightToLeftText(bool value) { }

	// RVA: 0xD9F470 Offset: 0xD9DA70 VA: 0x180D9F470
	public TMP_FontAsset get_font() { }

	// RVA: 0xDB4D50 Offset: 0xDB3350 VA: 0x180DB4D50
	public void set_font(TMP_FontAsset value) { }

	// RVA: 0xC73B60 Offset: 0xC72160 VA: 0x180C73B60 Slot: 63
	public virtual Material get_fontSharedMaterial() { }

	// RVA: 0xDB4AB0 Offset: 0xDB30B0 VA: 0x180DB4AB0 Slot: 64
	public virtual void set_fontSharedMaterial(Material value) { }

	// RVA: 0xDB3BA0 Offset: 0xDB21A0 VA: 0x180DB3BA0 Slot: 65
	public virtual Material[] get_fontSharedMaterials() { }

	// RVA: 0xDB4A50 Offset: 0xDB3050 VA: 0x180DB4A50 Slot: 66
	public virtual void set_fontSharedMaterials(Material[] value) { }

	// RVA: 0xDB3B50 Offset: 0xDB2150 VA: 0x180DB3B50
	public Material get_fontMaterial() { }

	// RVA: 0xDB4930 Offset: 0xDB2F30 VA: 0x180DB4930
	public void set_fontMaterial(Material value) { }

	// RVA: 0xDB3B70 Offset: 0xDB2170 VA: 0x180DB3B70 Slot: 67
	public virtual Material[] get_fontMaterials() { }

	// RVA: 0xDB4A50 Offset: 0xDB3050 VA: 0x180DB4A50 Slot: 68
	public virtual void set_fontMaterials(Material[] value) { }

	// RVA: 0xDB39B0 Offset: 0xDB1FB0 VA: 0x180DB39B0 Slot: 22
	public override Color get_color() { }

	// RVA: 0xDB4640 Offset: 0xDB2C40 VA: 0x180DB4640 Slot: 23
	public override void set_color(Color value) { }

	// RVA: 0xDB3860 Offset: 0xDB1E60 VA: 0x180DB3860
	public float get_alpha() { }

	// RVA: 0xDB44B0 Offset: 0xDB2AB0 VA: 0x180DB44B0
	public void set_alpha(float value) { }

	// RVA: 0xDB39F0 Offset: 0xDB1FF0 VA: 0x180DB39F0
	public bool get_enableVertexGradient() { }

	// RVA: 0xDB47A0 Offset: 0xDB2DA0 VA: 0x180DB47A0
	public void set_enableVertexGradient(bool value) { }

	// RVA: 0xDB3980 Offset: 0xDB1F80 VA: 0x180DB3980
	public VertexGradient get_colorGradient() { }

	// RVA: 0xDB45F0 Offset: 0xDB2BF0 VA: 0x180DB45F0
	public void set_colorGradient(VertexGradient value) { }

	// RVA: 0xDB3970 Offset: 0xDB1F70 VA: 0x180DB3970
	public TMP_ColorGradient get_colorGradientPreset() { }

	// RVA: 0xDB45B0 Offset: 0xDB2BB0 VA: 0x180DB45B0
	public void set_colorGradientPreset(TMP_ColorGradient value) { }

	// RVA: 0xDB3FC0 Offset: 0xDB25C0 VA: 0x180DB3FC0
	public bool get_overrideColorTags() { }

	// RVA: 0xDB5670 Offset: 0xDB3C70 VA: 0x180DB5670
	public void set_overrideColorTags(bool value) { }

	// RVA: 0xDB3A20 Offset: 0xDB2020 VA: 0x180DB3A20
	public Color32 get_faceColor() { }

	// RVA: 0xDB4880 Offset: 0xDB2E80 VA: 0x180DB4880
	public void set_faceColor(Color32 value) { }

	// RVA: 0xDB3DE0 Offset: 0xDB23E0 VA: 0x180DB3DE0
	public Color32 get_outlineColor() { }

	// RVA: 0xDB5540 Offset: 0xDB3B40 VA: 0x180DB5540
	public void set_outlineColor(Color32 value) { }

	// RVA: 0xDB3ED0 Offset: 0xDB24D0 VA: 0x180DB3ED0
	public float get_outlineWidth() { }

	// RVA: 0xDB55B0 Offset: 0xDB3BB0 VA: 0x180DB55B0
	public void set_outlineWidth(float value) { }

	// RVA: 0xDB3BD0 Offset: 0xDB21D0 VA: 0x180DB3BD0
	public float get_fontSize() { }

	// RVA: 0xDB4C20 Offset: 0xDB3220 VA: 0x180DB4C20
	public void set_fontSize(float value) { }

	// RVA: 0xDB3B90 Offset: 0xDB2190 VA: 0x180DB3B90
	public float get_fontScale() { }

	// RVA: 0xDB3BF0 Offset: 0xDB21F0 VA: 0x180DB3BF0
	public FontWeight get_fontWeight() { }

	// RVA: 0xDB4CF0 Offset: 0xDB32F0 VA: 0x180DB4CF0
	public void set_fontWeight(FontWeight value) { }

	// RVA: 0xDB3FF0 Offset: 0xDB25F0 VA: 0x180DB3FF0
	public float get_pixelsPerUnit() { }

	// RVA: 0xDB39C0 Offset: 0xDB1FC0 VA: 0x180DB39C0
	public bool get_enableAutoSizing() { }

	// RVA: 0xDB46B0 Offset: 0xDB2CB0 VA: 0x180DB46B0
	public void set_enableAutoSizing(bool value) { }

	// RVA: 0xDB3BC0 Offset: 0xDB21C0 VA: 0x180DB3BC0
	public float get_fontSizeMin() { }

	// RVA: 0xDB4BD0 Offset: 0xDB31D0 VA: 0x180DB4BD0
	public void set_fontSizeMin(float value) { }

	// RVA: 0x8F95A0 Offset: 0x8F7BA0 VA: 0x1808F95A0
	public float get_fontSizeMax() { }

	// RVA: 0xDB4B80 Offset: 0xDB3180 VA: 0x180DB4B80
	public void set_fontSizeMax(float value) { }

	// RVA: 0xDB3BE0 Offset: 0xDB21E0 VA: 0x180DB3BE0
	public FontStyles get_fontStyle() { }

	// RVA: 0xDB4C90 Offset: 0xDB3290 VA: 0x180DB4C90
	public void set_fontStyle(FontStyles value) { }

	// RVA: 0xDB3CA0 Offset: 0xDB22A0 VA: 0x180DB3CA0
	public bool get_isUsingBold() { }

	// RVA: 0xDB3850 Offset: 0xDB1E50 VA: 0x180DB3850
	public TextAlignmentOptions get_alignment() { }

	// RVA: 0xDB4480 Offset: 0xDB2A80 VA: 0x180DB4480
	public void set_alignment(TextAlignmentOptions value) { }

	// RVA: 0xDB3950 Offset: 0xDB1F50 VA: 0x180DB3950
	public float get_characterSpacing() { }

	// RVA: 0xDB44F0 Offset: 0xDB2AF0 VA: 0x180DB44F0
	public void set_characterSpacing(float value) { }

	// RVA: 0xDB4460 Offset: 0xDB2A60 VA: 0x180DB4460
	public float get_wordSpacing() { }

	// RVA: 0xDB58D0 Offset: 0xDB3ED0 VA: 0x180DB58D0
	public void set_wordSpacing(float value) { }

	// RVA: 0xDB3D90 Offset: 0xDB2390 VA: 0x180DB3D90
	public float get_lineSpacing() { }

	// RVA: 0xDB5120 Offset: 0xDB3720 VA: 0x180DB5120
	public void set_lineSpacing(float value) { }

	// RVA: 0xDB3D80 Offset: 0xDB2380 VA: 0x180DB3D80
	public float get_lineSpacingAdjustment() { }

	// RVA: 0xDB50C0 Offset: 0xDB36C0 VA: 0x180DB50C0
	public void set_lineSpacingAdjustment(float value) { }

	// RVA: 0xDB3FE0 Offset: 0xDB25E0 VA: 0x180DB3FE0
	public float get_paragraphSpacing() { }

	// RVA: 0xDB56D0 Offset: 0xDB3CD0 VA: 0x180DB56D0
	public void set_paragraphSpacing(float value) { }

	// RVA: 0xDB3960 Offset: 0xDB1F60 VA: 0x180DB3960
	public float get_characterWidthAdjustment() { }

	// RVA: 0xDB4550 Offset: 0xDB2B50 VA: 0x180DB4550
	public void set_characterWidthAdjustment(float value) { }

	// RVA: 0xDB3A00 Offset: 0xDB2000 VA: 0x180DB3A00
	public bool get_enableWordWrapping() { }

	// RVA: 0xDB47D0 Offset: 0xDB2DD0 VA: 0x180DB47D0
	public void set_enableWordWrapping(bool value) { }

	// RVA: 0xDB4470 Offset: 0xDB2A70 VA: 0x180DB4470
	public float get_wordWrappingRatios() { }

	// RVA: 0xDB5930 Offset: 0xDB3F30 VA: 0x180DB5930
	public void set_wordWrappingRatios(float value) { }

	// RVA: 0xDB3FB0 Offset: 0xDB25B0 VA: 0x180DB3FB0
	public TextOverflowModes get_overflowMode() { }

	// RVA: 0xDB5610 Offset: 0xDB3C10 VA: 0x180DB5610
	public void set_overflowMode(TextOverflowModes value) { }

	// RVA: 0xDB3C80 Offset: 0xDB2280 VA: 0x180DB3C80
	public bool get_isTextOverflowing() { }

	// RVA: 0xDB3B10 Offset: 0xDB2110 VA: 0x180DB3B10
	public int get_firstOverflowCharacterIndex() { }

	// RVA: 0x9A0000 Offset: 0x99E600 VA: 0x1809A0000
	public TMP_Text get_linkedTextComponent() { }

	// RVA: 0xDB5180 Offset: 0xDB3780 VA: 0x180DB5180
	public void set_linkedTextComponent(TMP_Text value) { }

	// RVA: 0xDB3C40 Offset: 0xDB2240 VA: 0x180DB3C40
	public bool get_isLinkedTextComponent() { }

	// RVA: 0xDB4F00 Offset: 0xDB3500 VA: 0x180DB4F00
	public void set_isLinkedTextComponent(bool value) { }

	// RVA: 0xDB3C90 Offset: 0xDB2290 VA: 0x180DB3C90
	public bool get_isTextTruncated() { }

	// RVA: 0xDB39E0 Offset: 0xDB1FE0 VA: 0x180DB39E0
	public bool get_enableKerning() { }

	// RVA: 0xDB4740 Offset: 0xDB2D40 VA: 0x180DB4740
	public void set_enableKerning(bool value) { }

	// RVA: 0xDB3A10 Offset: 0xDB2010 VA: 0x180DB3A10
	public bool get_extraPadding() { }

	// RVA: 0xDB4830 Offset: 0xDB2E30 VA: 0x180DB4830
	public void set_extraPadding(bool value) { }

	// RVA: 0xDB4320 Offset: 0xDB2920 VA: 0x180DB4320
	public bool get_richText() { }

	// RVA: 0xDB5750 Offset: 0xDB3D50 VA: 0x180DB5750
	public void set_richText(bool value) { }

	// RVA: 0xDB3C60 Offset: 0xDB2260 VA: 0x180DB3C60
	public bool get_isOverlay() { }

	// RVA: 0xDB4F90 Offset: 0xDB3590 VA: 0x180DB4F90
	public void set_isOverlay(bool value) { }

	// RVA: 0xDB3C50 Offset: 0xDB2250 VA: 0x180DB3C50
	public bool get_isOrthographic() { }

	// RVA: 0xDB4F60 Offset: 0xDB3560 VA: 0x180DB4F60
	public void set_isOrthographic(bool value) { }

	// RVA: 0xDB39D0 Offset: 0xDB1FD0 VA: 0x180DB39D0
	public bool get_enableCulling() { }

	// RVA: 0xDB4700 Offset: 0xDB2D00 VA: 0x180DB4700
	public void set_enableCulling(bool value) { }

	// RVA: 0xDB3C20 Offset: 0xDB2220 VA: 0x180DB3C20
	public bool get_ignoreRectMaskCulling() { }

	// RVA: 0xDB4EC0 Offset: 0xDB34C0 VA: 0x180DB4EC0
	public void set_ignoreRectMaskCulling(bool value) { }

	// RVA: 0xDB3C30 Offset: 0xDB2230 VA: 0x180DB3C30
	public bool get_ignoreVisibility() { }

	// RVA: 0xDB4EE0 Offset: 0xDB34E0 VA: 0x180DB4EE0
	public void set_ignoreVisibility(bool value) { }

	// RVA: 0x8383A0 Offset: 0x8369A0 VA: 0x1808383A0
	public TextureMappingOptions get_horizontalMapping() { }

	// RVA: 0xDB4E90 Offset: 0xDB3490 VA: 0x180DB4E90
	public void set_horizontalMapping(TextureMappingOptions value) { }

	// RVA: 0x838390 Offset: 0x836990 VA: 0x180838390
	public TextureMappingOptions get_verticalMapping() { }

	// RVA: 0xDB58A0 Offset: 0xDB3EA0 VA: 0x180DB58A0
	public void set_verticalMapping(TextureMappingOptions value) { }

	// RVA: 0xDB3DA0 Offset: 0xDB23A0 VA: 0x180DB3DA0
	public float get_mappingUvLineOffset() { }

	// RVA: 0xDB53C0 Offset: 0xDB39C0 VA: 0x180DB53C0
	public void set_mappingUvLineOffset(float value) { }

	// RVA: 0xAC5670 Offset: 0xAC3C70 VA: 0x180AC5670
	public TextRenderFlags get_renderMode() { }

	// RVA: 0xDB5730 Offset: 0xDB3D30 VA: 0x180DB5730
	public void set_renderMode(TextRenderFlags value) { }

	// RVA: 0xDB3C00 Offset: 0xDB2200 VA: 0x180DB3C00
	public VertexSortingOrder get_geometrySortingOrder() { }

	// RVA: 0xDB4E40 Offset: 0xDB3440 VA: 0x180DB4E40
	public void set_geometrySortingOrder(VertexSortingOrder value) { }

	// RVA: 0xDB4450 Offset: 0xDB2A50 VA: 0x180DB4450
	public bool get_vertexBufferAutoSizeReduction() { }

	// RVA: 0xDB5880 Offset: 0xDB3E80 VA: 0x180DB5880
	public void set_vertexBufferAutoSizeReduction(bool value) { }

	// RVA: 0xDB3B20 Offset: 0xDB2120 VA: 0x180DB3B20
	public int get_firstVisibleCharacter() { }

	// RVA: 0xDB4900 Offset: 0xDB2F00 VA: 0x180DB4900
	public void set_firstVisibleCharacter(int value) { }

	// RVA: 0xDB3DC0 Offset: 0xDB23C0 VA: 0x180DB3DC0
	public int get_maxVisibleCharacters() { }

	// RVA: 0xDB54B0 Offset: 0xDB3AB0 VA: 0x180DB54B0
	public void set_maxVisibleCharacters(int value) { }

	// RVA: 0xA4AED0 Offset: 0xA494D0 VA: 0x180A4AED0
	public int get_maxVisibleWords() { }

	// RVA: 0xDB5510 Offset: 0xDB3B10 VA: 0x180DB5510
	public void set_maxVisibleWords(int value) { }

	// RVA: 0xDB3DD0 Offset: 0xDB23D0 VA: 0x180DB3DD0
	public int get_maxVisibleLines() { }

	// RVA: 0xDB54E0 Offset: 0xDB3AE0 VA: 0x180DB54E0
	public void set_maxVisibleLines(int value) { }

	// RVA: 0xDB4440 Offset: 0xDB2A40 VA: 0x180DB4440
	public bool get_useMaxVisibleDescender() { }

	// RVA: 0xDB5850 Offset: 0xDB3E50 VA: 0x180DB5850
	public void set_useMaxVisibleDescender(bool value) { }

	// RVA: 0xDB3FD0 Offset: 0xDB25D0 VA: 0x180DB3FD0
	public int get_pageToDisplay() { }

	// RVA: 0xDB56A0 Offset: 0xDB3CA0 VA: 0x180DB56A0
	public void set_pageToDisplay(int value) { }

	// RVA: 0xDB3DB0 Offset: 0xDB23B0 VA: 0x180DB3DB0 Slot: 69
	public virtual Vector4 get_margin() { }

	// RVA: 0xDB53F0 Offset: 0xDB39F0 VA: 0x180DB53F0 Slot: 70
	public virtual void set_margin(Vector4 value) { }

	// RVA: 0xDB4390 Offset: 0xDB2990 VA: 0x180DB4390
	public TMP_TextInfo get_textInfo() { }

	// RVA: 0xDB3C10 Offset: 0xDB2210 VA: 0x180DB3C10
	public bool get_havePropertiesChanged() { }

	// RVA: 0xDB4E60 Offset: 0xDB3460 VA: 0x180DB4E60
	public void set_havePropertiesChanged(bool value) { }

	// RVA: 0xDB3CB0 Offset: 0xDB22B0 VA: 0x180DB3CB0
	public bool get_isUsingLegacyAnimationComponent() { }

	// RVA: 0xDB5040 Offset: 0xDB3640 VA: 0x180DB5040
	public void set_isUsingLegacyAnimationComponent(bool value) { }

	// RVA: 0xDB43A0 Offset: 0xDB29A0 VA: 0x180DB43A0
	public Transform get_transform() { }

	// RVA: 0xDB4280 Offset: 0xDB2880 VA: 0x180DB4280
	public RectTransform get_rectTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xDB3870 Offset: 0xDB1E70 VA: 0x180DB3870 Slot: 71
	public virtual bool get_autoSizeTextContainer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xDB44E0 Offset: 0xDB2AE0 VA: 0x180DB44E0 Slot: 72
	public virtual void set_autoSizeTextContainer(bool value) { }

	// RVA: 0x79D930 Offset: 0x79BF30 VA: 0x18079D930 Slot: 73
	public virtual Mesh get_mesh() { }

	// RVA: 0xDB3CC0 Offset: 0xDB22C0 VA: 0x180DB3CC0
	public bool get_isVolumetricText() { }

	// RVA: 0xDB5050 Offset: 0xDB3650 VA: 0x180DB5050
	public void set_isVolumetricText(bool value) { }

	// RVA: 0xDB3880 Offset: 0xDB1E80 VA: 0x180DB3880
	public Bounds get_bounds() { }

	// RVA: 0xDB4330 Offset: 0xDB2930 VA: 0x180DB4330
	public Bounds get_textBounds() { }

	// RVA: 0xDB3B30 Offset: 0xDB2130 VA: 0x180DB3B30 Slot: 74
	public float get_flexibleHeight() { }

	// RVA: 0xDB3B40 Offset: 0xDB2140 VA: 0x180DB3B40 Slot: 75
	public float get_flexibleWidth() { }

	// RVA: 0x72FF20 Offset: 0x72E520 VA: 0x18072FF20 Slot: 76
	public float get_minWidth() { }

	// RVA: 0x730240 Offset: 0x72E840 VA: 0x180730240 Slot: 77
	public float get_minHeight() { }

	// RVA: 0x730070 Offset: 0x72E670 VA: 0x180730070
	public float get_maxWidth() { }

	// RVA: 0x730380 Offset: 0x72E980 VA: 0x180730380
	public float get_maxHeight() { }

	// RVA: 0xDB3CD0 Offset: 0xDB22D0 VA: 0x180DB3CD0
	protected LayoutElement get_layoutElement() { }

	// RVA: 0xDB4240 Offset: 0xDB2840 VA: 0x180DB4240 Slot: 78
	public virtual float get_preferredWidth() { }

	// RVA: 0xDB4200 Offset: 0xDB2800 VA: 0x180DB4200 Slot: 79
	public virtual float get_preferredHeight() { }

	// RVA: 0xDA8F30 Offset: 0xDA7530 VA: 0x180DA8F30 Slot: 80
	public virtual float get_renderedWidth() { }

	// RVA: 0xDA8DA0 Offset: 0xDA73A0 VA: 0x180DA8DA0 Slot: 81
	public virtual float get_renderedHeight() { }

	// RVA: 0xDB3D70 Offset: 0xDB2370 VA: 0x180DB3D70 Slot: 82
	public int get_layoutPriority() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 83
	protected virtual void LoadFontAsset() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 84
	protected virtual void SetSharedMaterial(Material mat) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 85
	protected virtual Material GetMaterial(Material mat) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 86
	protected virtual void SetFontBaseMaterial(Material mat) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 87
	protected virtual Material[] GetSharedMaterials() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 88
	protected virtual void SetSharedMaterials(Material[] materials) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 89
	protected virtual Material[] GetMaterials(Material[] mats) { }

	// RVA: 0xDA4110 Offset: 0xDA2710 VA: 0x180DA4110 Slot: 90
	protected virtual Material CreateMaterialInstance(Material source) { }

	// RVA: 0xDAD3A0 Offset: 0xDAB9A0 VA: 0x180DAD3A0
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

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 96
	protected virtual float GetPaddingForMaterial() { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 97
	protected virtual float GetPaddingForMaterial(Material mat) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 98
	protected virtual Vector3[] GetTextContainerLocalCorners() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 99
	public virtual void ForceMeshUpdate() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 100
	public virtual void ForceMeshUpdate(bool ignoreActiveState) { }

	// RVA: 0xDAD350 Offset: 0xDAB950 VA: 0x180DAD350
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

	// RVA: 0xDA4230 Offset: 0xDA2830 VA: 0x180DA4230 Slot: 47
	public override void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0xDA41C0 Offset: 0xDA27C0 VA: 0x180DA41C0 Slot: 49
	public override void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 106
	protected virtual void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 107
	protected virtual void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0xDAB740 Offset: 0xDA9D40 VA: 0x180DAB740
	protected void ParseInputText() { }

	// RVA: 0xDAD7E0 Offset: 0xDABDE0 VA: 0x180DAD7E0
	protected void StringToCharArray(string sourceText, ref TMP_Text.UnicodeChar[] charBuffer) { }

	// RVA: 0xDAD450 Offset: 0xDABA50 VA: 0x180DAD450
	protected void StringBuilderToIntArray(StringBuilder sourceText, ref TMP_Text.UnicodeChar[] charBuffer) { }

	// RVA: 0xDAB290 Offset: 0xDA9890 VA: 0x180DAB290
	private bool IsTagName(ref string text, string tag, int index) { }

	// RVA: 0xDAB090 Offset: 0xDA9690 VA: 0x180DAB090
	private bool IsTagName(ref char[] text, string tag, int index) { }

	// RVA: 0xDAB190 Offset: 0xDA9790 VA: 0x180DAB190
	private bool IsTagName(ref int[] text, string tag, int index) { }

	// RVA: 0xDAB380 Offset: 0xDA9980 VA: 0x180DAB380
	private bool IsTagName(ref StringBuilder text, string tag, int index) { }

	// RVA: 0xDA9300 Offset: 0xDA7900 VA: 0x180DA9300
	private int GetTagHashCode(ref string text, int index, out int closeIndex) { }

	// RVA: 0xDA93B0 Offset: 0xDA79B0 VA: 0x180DA93B0
	private int GetTagHashCode(ref char[] text, int index, out int closeIndex) { }

	// RVA: 0xDA9420 Offset: 0xDA7A20 VA: 0x180DA9420
	private int GetTagHashCode(ref int[] text, int index, out int closeIndex) { }

	// RVA: 0xDA9230 Offset: 0xDA7830 VA: 0x180DA9230
	private int GetTagHashCode(ref StringBuilder text, int index, out int closeIndex) { }

	// RVA: -1 Offset: -1
	private void ResizeInternalArray<T>(ref T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D4260 Offset: 0x5D2860 VA: 0x1805D4260
	|-TMP_Text.ResizeInternalArray<object>
	|
	|-RVA: 0x5D42F0 Offset: 0x5D28F0 VA: 0x1805D42F0
	|-TMP_Text.ResizeInternalArray<TMP_Text.UnicodeChar>
	*/

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 108
	protected virtual int SetArraySizes(TMP_Text.UnicodeChar[] chars) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 109
	protected virtual void GenerateTextMesh() { }

	// RVA: 0xDA88A0 Offset: 0xDA6EA0 VA: 0x180DA88A0
	public Vector2 GetPreferredValues() { }

	// RVA: 0xDA8A60 Offset: 0xDA7060 VA: 0x180DA8A60
	public Vector2 GetPreferredValues(float width, float height) { }

	// RVA: 0xDA8950 Offset: 0xDA6F50 VA: 0x180DA8950
	public Vector2 GetPreferredValues(string text) { }

	// RVA: 0xDA87D0 Offset: 0xDA6DD0 VA: 0x180DA87D0
	public Vector2 GetPreferredValues(string text, float width, float height) { }

	// RVA: 0xDA8BD0 Offset: 0xDA71D0 VA: 0x180DA8BD0
	protected float GetPreferredWidth() { }

	// RVA: 0xDA8B50 Offset: 0xDA7150 VA: 0x180DA8B50
	protected float GetPreferredWidth(Vector2 margin) { }

	// RVA: 0xDA8550 Offset: 0xDA6B50 VA: 0x180DA8550
	protected float GetPreferredHeight() { }

	// RVA: 0xDA8750 Offset: 0xDA6D50 VA: 0x180DA8750
	protected float GetPreferredHeight(Vector2 margin) { }

	// RVA: 0xDA8E80 Offset: 0xDA7480 VA: 0x180DA8E80
	public Vector2 GetRenderedValues() { }

	// RVA: 0xDA8DC0 Offset: 0xDA73C0 VA: 0x180DA8DC0
	public Vector2 GetRenderedValues(bool onlyVisibleCharacters) { }

	// RVA: 0xDA8F30 Offset: 0xDA7530 VA: 0x180DA8F30
	protected float GetRenderedWidth() { }

	// RVA: 0xDA8F50 Offset: 0xDA7550 VA: 0x180DA8F50
	protected float GetRenderedWidth(bool onlyVisibleCharacters) { }

	// RVA: 0xDA8DA0 Offset: 0xDA73A0 VA: 0x180DA8DA0
	protected float GetRenderedHeight() { }

	// RVA: 0xDA8D80 Offset: 0xDA7380 VA: 0x180DA8D80
	protected float GetRenderedHeight(bool onlyVisibleCharacters) { }

	// RVA: 0xDA1920 Offset: 0xD9FF20 VA: 0x180DA1920 Slot: 110
	protected virtual Vector2 CalculatePreferredValues(float defaultFontSize, Vector2 marginSize, bool ignoreTextAutoSizing) { }

	// RVA: 0xDA8390 Offset: 0xDA6990 VA: 0x180DA8390 Slot: 111
	protected virtual Bounds GetCompoundBounds() { }

	// RVA: 0xDA9490 Offset: 0xDA7A90 VA: 0x180DA9490
	protected Bounds GetTextBounds() { }

	// RVA: 0xDA98A0 Offset: 0xDA7EA0 VA: 0x180DA98A0
	protected Bounds GetTextBounds(bool onlyVisibleCharacters) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 112
	protected virtual void AdjustLineOffset(int startIndex, int endIndex, float offset) { }

	// RVA: 0xDAB810 Offset: 0xDA9E10 VA: 0x180DAB810
	protected void ResizeLineExtents(int size) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 113
	public virtual TMP_TextInfo GetTextInfo(string text) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 114
	public virtual void ComputeMarginSize() { }

	// RVA: 0xDACF00 Offset: 0xDAB500 VA: 0x180DACF00
	protected void SaveWordWrappingState(ref WordWrapState state, int index, int count) { }

	// RVA: 0xDABAA0 Offset: 0xDAA0A0 VA: 0x180DABAA0
	protected int RestoreWordWrappingState(ref WordWrapState state) { }

	// RVA: 0xDABEF0 Offset: 0xDAA4F0 VA: 0x180DABEF0 Slot: 115
	protected virtual void SaveGlyphVertexInfo(float padding, float style_padding, Color32 vertexColor) { }

	// RVA: 0xDA78A0 Offset: 0xDA5EA0 VA: 0x180DA78A0 Slot: 116
	protected virtual void FillCharacterVertexBuffers(int i, int index_X4) { }

	// RVA: 0xDA6390 Offset: 0xDA4990 VA: 0x180DA6390 Slot: 117
	protected virtual void FillCharacterVertexBuffers(int i, int index_X4, bool isVolumetric) { }

	// RVA: 0xDA4A60 Offset: 0xDA3060 VA: 0x180DA4A60 Slot: 118
	protected virtual void DrawUnderlineMesh(Vector3 start, Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor) { }

	// RVA: 0xDA42D0 Offset: 0xDA28D0 VA: 0x180DA42D0 Slot: 119
	protected virtual void DrawTextHighlight(Vector3 start, Vector3 end, ref int index, Color32 highlightColor) { }

	// RVA: 0xDAB470 Offset: 0xDA9A70 VA: 0x180DAB470
	protected void LoadDefaultSettings() { }

	// RVA: 0xDA8F70 Offset: 0xDA7570 VA: 0x180DA8F70
	protected void GetSpecialCharacters(TMP_FontAsset fontAsset) { }

	// RVA: 0xDAB790 Offset: 0xDA9D90 VA: 0x180DAB790
	protected void ReplaceTagWithCharacter(int[] chars, int insertionIndex, int tagLength, char c) { }

	// RVA: 0xDA83A0 Offset: 0xDA69A0 VA: 0x180DA83A0
	protected TMP_FontAsset GetFontAssetForWeight(int fontWeight) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 120
	protected virtual void SetActiveSubMeshes(bool state) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 121
	protected virtual void ClearSubMeshObjects() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 122
	public virtual void ClearMesh() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 123
	public virtual void ClearMesh(bool uploadGeometry) { }

	// RVA: 0xDA8460 Offset: 0xDA6A60 VA: 0x180DA8460 Slot: 124
	public virtual string GetParsedText() { }

	// RVA: 0xDAB700 Offset: 0xDA9D00 VA: 0x180DAB700
	protected Vector2 PackUV(float x, float y, float scale) { }

	// RVA: 0xDAB6C0 Offset: 0xDA9CC0 VA: 0x180DAB6C0
	protected float PackUV(float x, float y) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 125
	internal virtual void InternalUpdate() { }

	// RVA: 0xDAAF80 Offset: 0xDA9580 VA: 0x180DAAF80
	protected int HexToInt(char hex) { }

	// RVA: 0xDA9D40 Offset: 0xDA8340 VA: 0x180DA9D40
	protected int GetUTF16(string text, int i) { }

	// RVA: 0xDA9E20 Offset: 0xDA8420 VA: 0x180DA9E20
	protected int GetUTF16(StringBuilder text, int i) { }

	// RVA: 0xDAA090 Offset: 0xDA8690 VA: 0x180DAA090
	protected int GetUTF32(string text, int i) { }

	// RVA: 0xDA9F00 Offset: 0xDA8500 VA: 0x180DA9F00
	protected int GetUTF32(StringBuilder text, int i) { }

	// RVA: 0xDAA220 Offset: 0xDA8820 VA: 0x180DAA220
	protected Color32 HexCharsToColor(char[] hexChars, int tagCount) { }

	// RVA: 0xDAAB90 Offset: 0xDA9190 VA: 0x180DAAB90
	protected Color32 HexCharsToColor(char[] hexChars, int startIndex, int length) { }

	// RVA: 0xDA82B0 Offset: 0xDA68B0 VA: 0x180DA82B0
	private int GetAttributeParameters(char[] chars, int startIndex, int length, ref float[] parameters) { }

	// RVA: 0xDA40E0 Offset: 0xDA26E0 VA: 0x180DA40E0
	protected float ConvertToFloat(char[] chars, int startIndex, int length) { }

	// RVA: 0xDA3F30 Offset: 0xDA2530 VA: 0x180DA3F30
	protected float ConvertToFloat(char[] chars, int startIndex, int length, out int lastIndex) { }

	// RVA: 0xDADCC0 Offset: 0xDAC2C0 VA: 0x180DADCC0
	protected bool ValidateHtmlTag(TMP_Text.UnicodeChar[] chars, int startIndex, out int endIndex) { }

	// RVA: 0xDB3020 Offset: 0xDB1620 VA: 0x180DB3020
	protected void .ctor() { }

	// RVA: 0xDB2EE0 Offset: 0xDB14E0 VA: 0x180DB2EE0
	private static void .cctor() { }

}

public class TMP_TextElement // TypeDefIndex: 6840
{	// Fields
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected TextElementType m_ElementType; // 0x10
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private uint m_Unicode; // 0x14
	private Glyph m_Glyph; // 0x18
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private uint m_GlyphIndex; // 0x20
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0x57C9D0 Offset: 0x57AFD0 VA: 0x18057C9D0
	public uint get_unicode() { }

	// RVA: 0x57C9F0 Offset: 0x57AFF0 VA: 0x18057C9F0
	public void set_unicode(uint value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public Glyph get_glyph() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_glyph(Glyph value) { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public uint get_glyphIndex() { }

	// RVA: 0x69D620 Offset: 0x69BC20 VA: 0x18069D620
	public void set_glyphIndex(uint value) { }

	// RVA: 0x7D0460 Offset: 0x7CEA60 VA: 0x1807D0460
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

	// RVA: 0x1156850 Offset: 0x1154E50 VA: 0x181156850
	public void .ctor() { }

	// RVA: 0x11566E0 Offset: 0x1154CE0 VA: 0x1811566E0
	public void .ctor(TMP_Text textComponent) { }

	// RVA: 0x1155FA0 Offset: 0x11545A0 VA: 0x181155FA0
	public void Clear() { }

	// RVA: 0x1155E90 Offset: 0x1154490 VA: 0x181155E90
	public void ClearMeshInfo(bool updateMesh) { }

	// RVA: 0x1155B30 Offset: 0x1154130 VA: 0x181155B30
	public void ClearAllMeshInfo() { }

	// RVA: 0x11565A0 Offset: 0x1154BA0 VA: 0x1811565A0
	public void ResetVertexLayout(bool isVolumetric) { }

	// RVA: 0x1155F20 Offset: 0x1154520 VA: 0x181155F20
	public void ClearUnusedVertices(MaterialReference[] materials) { }

	// RVA: 0x1155BB0 Offset: 0x11541B0 VA: 0x181155BB0
	public void ClearLineInfo() { }

	// RVA: 0x1156020 Offset: 0x1154620 VA: 0x181156020
	public TMP_MeshInfo[] CopyMeshInfoVertexData() { }

	// RVA: -1 Offset: -1
	public static void Resize<T>(ref T[] array, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3DB0 Offset: 0x5D23B0 VA: 0x1805D3DB0
	|-TMP_TextInfo.Resize<object>
	|-TMP_TextInfo.Resize<TMP_SubMesh>
	|-TMP_TextInfo.Resize<TMP_SubMeshUI>
	|
	|-RVA: 0x5D3FC0 Offset: 0x5D25C0 VA: 0x1805D3FC0
	|-TMP_TextInfo.Resize<TMP_LinkInfo>
	|
	|-RVA: 0x5D41D0 Offset: 0x5D27D0 VA: 0x1805D41D0
	|-TMP_TextInfo.Resize<TMP_WordInfo>
	*/

	// RVA: -1 Offset: -1
	public static void Resize<T>(ref T[] array, int size, bool isBlockAllocated) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3E40 Offset: 0x5D2440 VA: 0x1805D3E40
	|-TMP_TextInfo.Resize<object>
	|-TMP_TextInfo.Resize<Material>
	|
	|-RVA: 0x5D3F00 Offset: 0x5D2500 VA: 0x1805D3F00
	|-TMP_TextInfo.Resize<TMP_CharacterInfo>
	|
	|-RVA: 0x5D4050 Offset: 0x5D2650 VA: 0x1805D4050
	|-TMP_TextInfo.Resize<TMP_MeshInfo>
	|
	|-RVA: 0x5D4110 Offset: 0x5D2710 VA: 0x1805D4110
	|-TMP_TextInfo.Resize<TMP_PageInfo>
	*/

	// RVA: 0x1156630 Offset: 0x1154C30 VA: 0x181156630
	private static void .cctor() { }

}

public class TMP_TextParsingUtilities // TypeDefIndex: 6843
{	// Fields
	private static readonly TMP_TextParsingUtilities s_Instance; // 0x2B11394
	private const string k_LookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-";
	private const string k_LookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-";

	// Properties
	public static TMP_TextParsingUtilities instance { get; }

	// Methods

	// RVA: 0x1156C10 Offset: 0x1155210 VA: 0x181156C10
	private static void .cctor() { }

	// RVA: 0x1156C70 Offset: 0x1155270 VA: 0x181156C70
	public static TMP_TextParsingUtilities get_instance() { }

	// RVA: 0x11569A0 Offset: 0x1154FA0 VA: 0x1811569A0
	public static uint GetHashCode(string s) { }

	// RVA: 0x1156940 Offset: 0x1154F40 VA: 0x181156940
	public static int GetHashCodeCaseSensitive(string s) { }

	// RVA: 0x1156AF0 Offset: 0x11550F0 VA: 0x181156AF0
	public static char ToLowerASCIIFast(char c) { }

	// RVA: 0x1156B50 Offset: 0x1155150 VA: 0x181156B50
	public static char ToUpperASCIIFast(char c) { }

	// RVA: 0x1156BB0 Offset: 0x11551B0 VA: 0x181156BB0
	public static uint ToUpperASCIIFast(uint c) { }

	// RVA: 0x1156A90 Offset: 0x1155090 VA: 0x181156A90
	public static uint ToLowerASCIIFast(uint c) { }

	// RVA: 0x1156A50 Offset: 0x1155050 VA: 0x181156A50
	public static bool IsHighSurrogate(uint c) { }

	// RVA: 0x1156A70 Offset: 0x1155070 VA: 0x181156A70
	public static bool IsLowSurrogate(uint c) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public static class TMP_TextUtilities // TypeDefIndex: 6846
{	// Fields
	private static Vector3[] m_rectWorldCorners; // 0x3840
	private const string k_lookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-";
	private const string k_lookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-";

	// Methods

	// RVA: 0x115B500 Offset: 0x1159B00 VA: 0x18115B500
	public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera) { }

	// RVA: 0x115B700 Offset: 0x1159D00 VA: 0x18115B700
	public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera, out CaretPosition cursor) { }

	// RVA: 0x1159730 Offset: 0x1157D30 VA: 0x181159730
	public static int FindNearestLine(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x1158C70 Offset: 0x1157270 VA: 0x181158C70
	public static int FindNearestCharacterOnLine(TMP_Text text, Vector3 position, int line, Camera camera, bool visibleOnly) { }

	// RVA: 0x115BE00 Offset: 0x115A400 VA: 0x18115BE00
	public static bool IsIntersectingRectTransform(RectTransform rectTransform, Vector3 position, Camera camera) { }

	// RVA: 0x1156FD0 Offset: 0x11555D0 VA: 0x181156FD0
	public static int FindIntersectingCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly) { }

	// RVA: 0x11591F0 Offset: 0x11577F0 VA: 0x1811591F0
	public static int FindNearestCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly) { }

	// RVA: 0x1157E00 Offset: 0x1156400 VA: 0x181157E00
	public static int FindIntersectingWord(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x115A7A0 Offset: 0x1158DA0 VA: 0x18115A7A0
	public static int FindNearestWord(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x1157340 Offset: 0x1155940 VA: 0x181157340
	public static int FindIntersectingLine(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x11575A0 Offset: 0x1155BA0 VA: 0x1811575A0
	public static int FindIntersectingLink(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x1159A50 Offset: 0x1158050 VA: 0x181159A50
	public static int FindNearestLink(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x115C010 Offset: 0x115A610 VA: 0x18115C010
	private static bool PointIntersectRectangle(Vector3 m, Vector3 a, Vector3 b, Vector3 c, Vector3 d) { }

	// RVA: 0x115C2A0 Offset: 0x115A8A0 VA: 0x18115C2A0
	public static bool ScreenPointToWorldPointInRectangle(Transform transform, Vector2 screenPoint, Camera cam, out Vector3 worldPoint) { }

	// RVA: 0x115BB60 Offset: 0x115A160 VA: 0x18115BB60
	private static bool IntersectLinePlane(TMP_TextUtilities.LineSegment line, Vector3 point, Vector3 normal, out Vector3 intersectingPoint) { }

	// RVA: 0x1156CD0 Offset: 0x11552D0 VA: 0x181156CD0
	public static float DistanceToLine(Vector3 a, Vector3 b, Vector3 point) { }

	// RVA: 0x115C5F0 Offset: 0x115ABF0 VA: 0x18115C5F0
	public static char ToLowerFast(char c) { }

	// RVA: 0x115C650 Offset: 0x115AC50 VA: 0x18115C650
	public static char ToUpperFast(char c) { }

	// RVA: 0x1156940 Offset: 0x1154F40 VA: 0x181156940
	public static int GetSimpleHashCode(string s) { }

	// RVA: 0x115B9A0 Offset: 0x1159FA0 VA: 0x18115B9A0
	public static uint GetSimpleHashCodeLowercase(string s) { }

	// RVA: 0x115BA50 Offset: 0x115A050 VA: 0x18115BA50
	public static int HexToInt(char hex) { }

	// RVA: 0x115C4E0 Offset: 0x115AAE0 VA: 0x18115C4E0
	public static int StringHexToInt(string s) { }

	// RVA: 0x115C6B0 Offset: 0x115ACB0 VA: 0x18115C6B0
	private static void .cctor() { }

}

private struct TMP_TextUtilities.LineSegment // TypeDefIndex: 6847
{	// Fields
	public Vector3 Point1; // 0x0
	public Vector3 Point2; // 0xC

	// Methods

	// RVA: 0x1BD6E0 Offset: 0x1BCAE0 VA: 0x1801BD6E0
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

	// RVA: 0x115D3E0 Offset: 0x115B9E0 VA: 0x18115D3E0
	public static TMP_UpdateManager get_instance() { }

	// RVA: 0x115D1B0 Offset: 0x115B7B0 VA: 0x18115D1B0
	protected void .ctor() { }

	// RVA: 0x115CEA0 Offset: 0x115B4A0 VA: 0x18115CEA0
	internal static void RegisterTextObjectForUpdate(TMP_Text textObject) { }

	// RVA: 0x115CA80 Offset: 0x115B080 VA: 0x18115CA80
	private void InternalRegisterTextObjectForUpdate(TMP_Text textObject) { }

	// RVA: 0x115CDE0 Offset: 0x115B3E0 VA: 0x18115CDE0
	public static void RegisterTextElementForLayoutRebuild(TMP_Text element) { }

	// RVA: 0x115C9C0 Offset: 0x115AFC0 VA: 0x18115C9C0
	private bool InternalRegisterTextElementForLayoutRebuild(TMP_Text element) { }

	// RVA: 0x115CD20 Offset: 0x115B320 VA: 0x18115CD20
	public static void RegisterTextElementForGraphicRebuild(TMP_Text element) { }

	// RVA: 0x115C900 Offset: 0x115AF00 VA: 0x18115C900
	private bool InternalRegisterTextElementForGraphicRebuild(TMP_Text element) { }

	// RVA: 0x115CD10 Offset: 0x115B310 VA: 0x18115CD10
	private void OnBeginFrameRendering(ScriptableRenderContext renderContext, Camera[] cameras) { }

	// RVA: 0x115CD10 Offset: 0x115B310 VA: 0x18115CD10
	private void OnCameraPreCull(Camera cam) { }

	// RVA: 0x115C700 Offset: 0x115AD00 VA: 0x18115C700
	private void DoRebuilds() { }

	// RVA: 0x115D110 Offset: 0x115B710 VA: 0x18115D110
	internal static void UnRegisterTextObjectForUpdate(TMP_Text textObject) { }

	// RVA: 0x115CF60 Offset: 0x115B560 VA: 0x18115CF60
	public static void UnRegisterTextElementForRebuild(TMP_Text element) { }

	// RVA: 0x115CB30 Offset: 0x115B130 VA: 0x18115CB30
	private void InternalUnRegisterTextElementForGraphicRebuild(TMP_Text element) { }

	// RVA: 0x115CBD0 Offset: 0x115B1D0 VA: 0x18115CBD0
	private void InternalUnRegisterTextElementForLayoutRebuild(TMP_Text element) { }

	// RVA: 0x115CC70 Offset: 0x115B270 VA: 0x18115CC70
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

	// RVA: 0x115E140 Offset: 0x115C740 VA: 0x18115E140
	public static TMP_UpdateRegistry get_instance() { }

	// RVA: 0x115E020 Offset: 0x115C620 VA: 0x18115E020
	protected void .ctor() { }

	// RVA: 0x115DCE0 Offset: 0x115C2E0 VA: 0x18115DCE0
	public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x115D590 Offset: 0x115BB90 VA: 0x18115D590
	private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x115DBB0 Offset: 0x115C1B0 VA: 0x18115DBB0
	public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x115D460 Offset: 0x115BA60 VA: 0x18115D460
	private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x115D8C0 Offset: 0x115BEC0 VA: 0x18115D8C0
	private void PerformUpdateForCanvasRendererObjects() { }

	// RVA: 0x115DB60 Offset: 0x115C160 VA: 0x18115DB60
	private void PerformUpdateForMeshRendererObjects() { }

	// RVA: 0x115DE10 Offset: 0x115C410 VA: 0x18115DE10
	public static void UnRegisterCanvasElementForRebuild(ICanvasElement element) { }

	// RVA: 0x115D7C0 Offset: 0x115BDC0 VA: 0x18115D7C0
	private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x115D6C0 Offset: 0x115BCC0 VA: 0x18115D6C0
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

	// RVA: 0xD9ADE0 Offset: 0xD993E0 VA: 0x180D9ADE0
	public static bool Approximately(float a, float b) { }

	// RVA: 0xD9AE10 Offset: 0xD99410 VA: 0x180D9AE10
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

	// RVA: 0x1220E0 Offset: 0x1214E0 VA: 0x1801220E0
	internal void SetLinkID(char[] text, int startIndex, int length) { }

	// RVA: 0x122000 Offset: 0x121400 VA: 0x180122000
	public string GetLinkText() { }

	// RVA: 0x121F60 Offset: 0x121360 VA: 0x180121F60
	public string GetLinkID() { }

}

public struct TMP_WordInfo // TypeDefIndex: 6859
{	// Fields
	public TMP_Text textComponent; // 0x0
	public int firstCharacterIndex; // 0x8
	public int lastCharacterIndex; // 0xC
	public int characterCount; // 0x10

	// Methods

	// RVA: 0x1BD710 Offset: 0x1BCB10 VA: 0x1801BD710
	public string GetWord() { }

}

public struct TMP_SpriteInfo // TypeDefIndex: 6860
{	// Fields
	public int spriteIndex; // 0x0
	public int characterIndex; // 0x4
	public int vertexIndex; // 0x8

}

