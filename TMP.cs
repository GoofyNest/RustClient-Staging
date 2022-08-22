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

	// RVA: 0xC6A740 Offset: 0xC68D40 VA: 0x180C6A740
	public void .ctor() { }

	// RVA: 0xC6A670 Offset: 0xC68C70 VA: 0x180C6A670
	public void .ctor(uint unicode, Glyph glyph) { }

	// RVA: 0xC6A6E0 Offset: 0xC68CE0 VA: 0x180C6A6E0
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

	// RVA: 0xC6A7C0 Offset: 0xC68DC0 VA: 0x180C6A7C0
	public void .ctor() { }

	// RVA: 0xC6A8F0 Offset: 0xC68EF0 VA: 0x180C6A8F0
	public void .ctor(Color color) { }

	// RVA: 0xC6A880 Offset: 0xC68E80 VA: 0x180C6A880
	public void .ctor(Color color0, Color color1, Color color2, Color color3) { }

	// RVA: 0xC6A770 Offset: 0xC68D70 VA: 0x180C6A770
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

	// RVA: 0xC6B8D0 Offset: 0xC69ED0 VA: 0x180C6B8D0
	private static GameObject CreateUIElementRoot(string name, Vector2 size) { }

	// RVA: 0xC6B970 Offset: 0xC69F70 VA: 0x180C6B970
	private static GameObject CreateUIObject(string name, GameObject parent) { }

	// RVA: 0xC6BAC0 Offset: 0xC6A0C0 VA: 0x180C6BAC0
	private static void SetDefaultTextValues(TMP_Text lbl) { }

	// RVA: 0xC6BA20 Offset: 0xC6A020 VA: 0x180C6BA20
	private static void SetDefaultColorTransitionValues(Selectable slider) { }

	// RVA: 0xC6BC40 Offset: 0xC6A240 VA: 0x180C6BC40
	private static void SetParentAndAlign(GameObject child, GameObject parent) { }

	// RVA: 0xC6BB60 Offset: 0xC6A160 VA: 0x180C6BB60
	private static void SetLayerRecursively(GameObject go, int layer) { }

	// RVA: 0xC6B420 Offset: 0xC69A20 VA: 0x180C6B420
	public static GameObject CreateScrollbar(TMP_DefaultControls.Resources resources) { }

	// RVA: 0xC6A940 Offset: 0xC68F40 VA: 0x180C6A940
	public static GameObject CreateButton(TMP_DefaultControls.Resources resources) { }

	// RVA: 0xC6B780 Offset: 0xC69D80 VA: 0x180C6B780
	public static GameObject CreateText(TMP_DefaultControls.Resources resources) { }

	// RVA: 0xC6AC80 Offset: 0xC69280 VA: 0x180C6AC80
	public static GameObject CreateInputField(TMP_DefaultControls.Resources resources) { }

	// RVA: 0xC6BD30 Offset: 0xC6A330 VA: 0x180C6BD30
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

	// RVA: 0xC73DE0 Offset: 0xC723E0 VA: 0x180C73DE0
	public FaceInfo get_faceInfo() { }

	// RVA: 0xC73EF0 Offset: 0xC724F0 VA: 0x180C73EF0
	internal void set_faceInfo(FaceInfo value) { }

	// RVA: 0x952CA0 Offset: 0x9512A0 VA: 0x180952CA0
	public List<Glyph> get_glyphTable() { }

	// RVA: 0xC73F50 Offset: 0xC72550 VA: 0x180C73F50
	internal void set_glyphTable(List<Glyph> value) { }

	// RVA: 0xC73E40 Offset: 0xC72440 VA: 0x180C73E40
	public Dictionary<uint, Glyph> get_glyphLookupTable() { }

	// RVA: 0x7AD080 Offset: 0x7AB680 VA: 0x1807AD080
	public List<TMP_Character> get_characterTable() { }

	// RVA: 0xA4D4F0 Offset: 0xA4BAF0 VA: 0x180A4D4F0
	internal void set_characterTable(List<TMP_Character> value) { }

	// RVA: 0xC73D60 Offset: 0xC72360 VA: 0x180C73D60
	public Dictionary<uint, TMP_Character> get_characterLookupTable() { }

	// RVA: 0xC73C80 Offset: 0xC72280 VA: 0x180C73C80
	public Texture2D get_atlasTexture() { }

	// RVA: 0xC73D40 Offset: 0xC72340 VA: 0x180C73D40
	public Texture2D[] get_atlasTextures() { }

	// RVA: 0xC73E90 Offset: 0xC72490 VA: 0x180C73E90
	public void set_atlasTextures(Texture2D[] value) { }

	// RVA: 0x4EF3A0 Offset: 0x4ED9A0 VA: 0x1804EF3A0
	internal List<GlyphRect> get_usedGlyphRects() { }

	// RVA: 0x4EF3B0 Offset: 0x4ED9B0 VA: 0x1804EF3B0
	internal void set_usedGlyphRects(List<GlyphRect> value) { }

	// RVA: 0x872250 Offset: 0x870850 VA: 0x180872250
	internal List<GlyphRect> get_freeGlyphRects() { }

	// RVA: 0x8722D0 Offset: 0x8708D0 VA: 0x1808722D0
	internal void set_freeGlyphRects(List<GlyphRect> value) { }

	// RVA: 0xC73E20 Offset: 0xC72420 VA: 0x180C73E20
	public FaceInfo_Legacy get_fontInfo() { }

	// RVA: 0xC73D50 Offset: 0xC72350 VA: 0x180C73D50
	public int get_atlasWidth() { }

	// RVA: 0xC73EA0 Offset: 0xC724A0 VA: 0x180C73EA0
	internal void set_atlasWidth(int value) { }

	// RVA: 0xC73C60 Offset: 0xC72260 VA: 0x180C73C60
	public int get_atlasHeight() { }

	// RVA: 0xC73E70 Offset: 0xC72470 VA: 0x180C73E70
	internal void set_atlasHeight(int value) { }

	// RVA: 0x872100 Offset: 0x870700 VA: 0x180872100
	public int get_atlasPadding() { }

	// RVA: 0x8722A0 Offset: 0x8708A0 VA: 0x1808722A0
	internal void set_atlasPadding(int value) { }

	// RVA: 0xC73C70 Offset: 0xC72270 VA: 0x180C73C70
	public GlyphRenderMode get_atlasRenderMode() { }

	// RVA: 0xC73E80 Offset: 0xC72480 VA: 0x180C73E80
	internal void set_atlasRenderMode(GlyphRenderMode value) { }

	// RVA: 0x7DDD70 Offset: 0x7DC370 VA: 0x1807DDD70
	public TMP_FontFeatureTable get_fontFeatureTable() { }

	// RVA: 0xC73F30 Offset: 0xC72530 VA: 0x180C73F30
	internal void set_fontFeatureTable(TMP_FontFeatureTable value) { }

	// RVA: 0x701920 Offset: 0x6FFF20 VA: 0x180701920
	public List<TMP_FontAsset> get_fallbackFontAssetTable() { }

	// RVA: 0x7019B0 Offset: 0x6FFFB0 VA: 0x1807019B0
	public void set_fallbackFontAssetTable(List<TMP_FontAsset> value) { }

	// RVA: 0xC73D90 Offset: 0xC72390 VA: 0x180C73D90
	public FontAssetCreationSettings get_creationSettings() { }

	// RVA: 0xC73EB0 Offset: 0xC724B0 VA: 0x180C73EB0
	public void set_creationSettings(FontAssetCreationSettings value) { }

	// RVA: 0xC73E30 Offset: 0xC72430 VA: 0x180C73E30
	public TMP_FontWeightPair[] get_fontWeightTable() { }

	// RVA: 0xC73F40 Offset: 0xC72540 VA: 0x180C73F40
	internal void set_fontWeightTable(TMP_FontWeightPair[] value) { }

	// RVA: 0xC6DE90 Offset: 0xC6C490 VA: 0x180C6DE90
	public static TMP_FontAsset CreateFontAsset(Font font) { }

	// RVA: 0xC6DF10 Offset: 0xC6C510 VA: 0x180C6DF10
	public static TMP_FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = 1) { }

	// RVA: 0xC6D780 Offset: 0xC6BD80 VA: 0x180C6D780
	private void Awake() { }

	// RVA: 0xC6F0C0 Offset: 0xC6D6C0 VA: 0x180C6F0C0
	internal void InitializeDictionaryLookupTables() { }

	// RVA: 0xC6F500 Offset: 0xC6DB00 VA: 0x180C6F500
	public void ReadFontAssetDefinition() { }

	// RVA: 0xC6FEF0 Offset: 0xC6E4F0 VA: 0x180C6FEF0
	internal void SortCharacterTable() { }

	// RVA: 0xC70280 Offset: 0xC6E880 VA: 0x180C70280
	internal void SortGlyphTable() { }

	// RVA: 0xC70030 Offset: 0xC6E630 VA: 0x180C70030
	internal void SortGlyphAndCharacterTables() { }

	// RVA: 0xC6EE70 Offset: 0xC6D470 VA: 0x180C6EE70
	public bool HasCharacter(int character) { }

	// RVA: 0xC6E9F0 Offset: 0xC6CFF0 VA: 0x180C6E9F0
	public bool HasCharacter(char character) { }

	// RVA: 0xC6EA60 Offset: 0xC6D060 VA: 0x180C6EA60
	public bool HasCharacter(char character, bool searchFallbacks) { }

	// RVA: 0xC6E870 Offset: 0xC6CE70 VA: 0x180C6E870
	private bool HasCharacter_Internal(char character, bool searchFallbacks) { }

	// RVA: 0xC6EF90 Offset: 0xC6D590 VA: 0x180C6EF90
	public bool HasCharacters(string text, out List<char> missingCharacters) { }

	// RVA: 0xC6EEE0 Offset: 0xC6D4E0 VA: 0x180C6EEE0
	public bool HasCharacters(string text) { }

	// RVA: 0xC6E6E0 Offset: 0xC6CCE0 VA: 0x180C6E6E0
	public static string GetCharacters(TMP_FontAsset fontAsset) { }

	// RVA: 0xC6E5F0 Offset: 0xC6CBF0 VA: 0x180C6E5F0
	public static int[] GetCharactersArray(TMP_FontAsset fontAsset) { }

	// RVA: 0xC71030 Offset: 0xC6F630 VA: 0x180C71030
	public bool TryAddCharacters(uint[] unicodes) { }

	// RVA: 0xC71050 Offset: 0xC6F650 VA: 0x180C71050
	public bool TryAddCharacters(uint[] unicodes, out uint[] missingUnicodes) { }

	// RVA: 0xC71010 Offset: 0xC6F610 VA: 0x180C71010
	public bool TryAddCharacters(string characters) { }

	// RVA: 0xC71890 Offset: 0xC6FE90 VA: 0x180C71890
	public bool TryAddCharacters(string characters, out string missingCharacters) { }

	// RVA: 0xC70C00 Offset: 0xC6F200 VA: 0x180C70C00
	internal bool TryAddCharacter_Internal(uint unicode) { }

	// RVA: 0xC6D380 Offset: 0xC6B980 VA: 0x180C6D380
	internal TMP_Character AddCharacter_Internal(uint unicode, Glyph glyph) { }

	// RVA: 0xC703C0 Offset: 0xC6E9C0 VA: 0x180C703C0
	internal bool TryAddCharacterInternal(uint unicode, out TMP_Character character) { }

	// RVA: 0xC6E7B0 Offset: 0xC6CDB0 VA: 0x180C6E7B0
	internal uint GetGlyphIndex(uint unicode) { }

	// RVA: 0xC72010 Offset: 0xC70610 VA: 0x180C72010
	internal void UpdateAtlasTexture() { }

	// RVA: 0xC723C0 Offset: 0xC709C0 VA: 0x180C723C0
	internal void UpdateGlyphAdjustmentRecords(uint unicode, uint glyphIndex) { }

	// RVA: 0xC6D800 Offset: 0xC6BE00 VA: 0x180C6D800
	public void ClearFontAssetData(bool setAtlasSizeToZero = False) { }

	// RVA: 0xC72870 Offset: 0xC70E70 VA: 0x180C72870
	private void UpgradeFontAsset() { }

	// RVA: 0xC735B0 Offset: 0xC71BB0 VA: 0x180C735B0
	private void UpgradeGlyphAdjustmentTableToFontFeatureTable() { }

	// RVA: 0xC739E0 Offset: 0xC71FE0 VA: 0x180C739E0
	public void .ctor() { }

	// RVA: 0xC73950 Offset: 0xC71F50 VA: 0x180C73950
	private static void .cctor() { }

}

private sealed class TMP_FontAsset.<>c // TypeDefIndex: 6761
{	// Fields
	public static readonly TMP_FontAsset.<>c <>9; // 0x0
	public static Func<TMP_Character, uint> <>9__100_0; // 0x8
	public static Func<Glyph, uint> <>9__101_0; // 0x10

	// Methods

	// RVA: 0xC85130 Offset: 0xC83730 VA: 0x180C85130
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x970A70 Offset: 0x96F070 VA: 0x180970A70
	internal uint <SortCharacterTable>b__100_0(TMP_Character c) { }

	// RVA: 0xC850A0 Offset: 0xC836A0 VA: 0x180C850A0
	internal uint <SortGlyphTable>b__101_0(Glyph c) { }

}

public class TMP_Glyph : TMP_TextElement_Legacy // TypeDefIndex: 6763
{	// Methods

	// RVA: 0xC74C20 Offset: 0xC73220 VA: 0x180C74C20
	public static TMP_Glyph Clone(TMP_Glyph source) { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
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

	// RVA: 0xC746F0 Offset: 0xC72CF0 VA: 0x180C746F0
	public static TMP_FontAsset SearchForCharacter(TMP_FontAsset font, uint unicode, out TMP_Character character) { }

	// RVA: 0xC747C0 Offset: 0xC72DC0 VA: 0x180C747C0
	public static TMP_FontAsset SearchForCharacter(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character) { }

	// RVA: 0xC744A0 Offset: 0xC72AA0 VA: 0x180C744A0
	private static TMP_FontAsset SearchForCharacterInternal(TMP_FontAsset font, uint unicode, out TMP_Character character) { }

	// RVA: 0xC743B0 Offset: 0xC729B0 VA: 0x180C743B0
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

	// RVA: 0xC6D2C0 Offset: 0xC6B8C0 VA: 0x180C6D2C0
	private static void .cctor() { }

	// RVA: 0xC6D320 Offset: 0xC6B920 VA: 0x180C6D320
	public static TMP_FontAssetUtilities get_instance() { }

	// RVA: 0xC6C340 Offset: 0xC6A940 VA: 0x180C6C340
	public static TMP_Character GetCharacterFromFontAsset(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface, out TMP_FontAsset fontAsset) { }

	// RVA: 0xC6BE80 Offset: 0xC6A480 VA: 0x180C6BE80
	private static TMP_Character GetCharacterFromFontAsset_Internal(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface, out TMP_FontAsset fontAsset) { }

	// RVA: 0xC6C4C0 Offset: 0xC6AAC0 VA: 0x180C6C4C0
	public static TMP_Character GetCharacterFromFontAssets(uint unicode, List<TMP_FontAsset> fontAssets, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface, out TMP_FontAsset fontAsset) { }

	// RVA: 0xC6C740 Offset: 0xC6AD40 VA: 0x180C6C740
	private static bool TryGetCharacterFromFontFile(uint unicode, TMP_FontAsset fontAsset, out TMP_Character character) { }

	// RVA: 0xC6D0E0 Offset: 0xC6B6E0 VA: 0x180C6D0E0
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

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal List<TMP_GlyphPairAdjustmentRecord> get_glyphPairAdjustmentRecords() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	internal void set_glyphPairAdjustmentRecords(List<TMP_GlyphPairAdjustmentRecord> value) { }

	// RVA: 0xC74160 Offset: 0xC72760 VA: 0x180C74160
	public void .ctor() { }

	// RVA: 0xC73F60 Offset: 0xC72560 VA: 0x180C73F60
	public void SortGlyphPairAdjustmentRecords() { }

}

private sealed class TMP_FontFeatureTable.<>c // TypeDefIndex: 6777
{	// Fields
	public static readonly TMP_FontFeatureTable.<>c <>9; // 0x0
	public static Func<TMP_GlyphPairAdjustmentRecord, uint> <>9__6_0; // 0x8
	public static Func<TMP_GlyphPairAdjustmentRecord, uint> <>9__6_1; // 0x10

	// Methods

	// RVA: 0xC851F0 Offset: 0xC837F0 VA: 0x180C851F0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xC85060 Offset: 0xC83660 VA: 0x180C85060
	internal uint <SortGlyphPairAdjustmentRecords>b__6_0(TMP_GlyphPairAdjustmentRecord s) { }

	// RVA: 0xC85080 Offset: 0xC83680 VA: 0x180C85080
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

	// RVA: 0xC74C00 Offset: 0xC73200 VA: 0x180C74C00
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

	// RVA: 0xC74B90 Offset: 0xC73190 VA: 0x180C74B90
	public TMP_GlyphAdjustmentRecord get_firstAdjustmentRecord() { }

	// RVA: 0xC74BE0 Offset: 0xC731E0 VA: 0x180C74BE0
	public void set_firstAdjustmentRecord(TMP_GlyphAdjustmentRecord value) { }

	// RVA: 0xC74BB0 Offset: 0xC731B0 VA: 0x180C74BB0
	public TMP_GlyphAdjustmentRecord get_secondAdjustmentRecord() { }

	// RVA: 0xC74BF0 Offset: 0xC731F0 VA: 0x180C74BF0
	public void set_secondAdjustmentRecord(TMP_GlyphAdjustmentRecord value) { }

	// RVA: 0x6BBA50 Offset: 0x6BA050 VA: 0x1806BBA50
	public FontFeatureLookupFlags get_featureLookupFlags() { }

	// RVA: 0xC74BD0 Offset: 0xC731D0 VA: 0x180C74BD0
	public void set_featureLookupFlags(FontFeatureLookupFlags value) { }

	// RVA: 0xC74980 Offset: 0xC72F80 VA: 0x180C74980
	public void .ctor(TMP_GlyphAdjustmentRecord firstAdjustmentRecord, TMP_GlyphAdjustmentRecord secondAdjustmentRecord) { }

	// RVA: 0xC749D0 Offset: 0xC72FD0 VA: 0x180C749D0
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

	// RVA: 0xC831E0 Offset: 0xC817E0 VA: 0x180C831E0
	private BaseInput get_inputSystem() { }

	// RVA: 0xC83080 Offset: 0xC81680 VA: 0x180C83080
	private string get_compositionString() { }

	// RVA: 0xC82C40 Offset: 0xC81240 VA: 0x180C82C40
	protected void .ctor() { }

	// RVA: 0xC83360 Offset: 0xC81960 VA: 0x180C83360
	protected Mesh get_mesh() { }

	// RVA: 0xC836A0 Offset: 0xC81CA0 VA: 0x180C836A0
	public bool get_shouldHideMobileInput() { }

	// RVA: 0xC84B20 Offset: 0xC83120 VA: 0x180C84B20
	public void set_shouldHideMobileInput(bool value) { }

	// RVA: 0xC836D0 Offset: 0xC81CD0 VA: 0x180C836D0
	public bool get_shouldHideSoftKeyboard() { }

	// RVA: 0xC84BA0 Offset: 0xC831A0 VA: 0x180C84BA0
	public void set_shouldHideSoftKeyboard(bool value) { }

	// RVA: 0xC83730 Offset: 0xC81D30 VA: 0x180C83730
	private bool isKeyboardUsingEvents() { }

	// RVA: 0xC83720 Offset: 0xC81D20 VA: 0x180C83720
	public string get_text() { }

	// RVA: 0xC84EC0 Offset: 0xC834C0 VA: 0x180C84EC0
	public void set_text(string value) { }

	// RVA: 0xC81990 Offset: 0xC7FF90 VA: 0x180C81990
	public void SetTextWithoutNotify(string input) { }

	// RVA: 0xC819A0 Offset: 0xC7FFA0 VA: 0x180C819A0
	private void SetText(string value, bool sendCallback = True) { }

	// RVA: 0xC83320 Offset: 0xC81920 VA: 0x180C83320
	public bool get_isFocused() { }

	// RVA: 0x745C80 Offset: 0x744280 VA: 0x180745C80
	public float get_caretBlinkRate() { }

	// RVA: 0xC837C0 Offset: 0xC81DC0 VA: 0x180C837C0
	public void set_caretBlinkRate(float value) { }

	// RVA: 0xC83040 Offset: 0xC81640 VA: 0x180C83040
	public int get_caretWidth() { }

	// RVA: 0xC83A90 Offset: 0xC82090 VA: 0x180C83A90
	public void set_caretWidth(int value) { }

	// RVA: 0xC73E20 Offset: 0xC72420 VA: 0x180C73E20
	public RectTransform get_textViewport() { }

	// RVA: 0xC84E70 Offset: 0xC83470 VA: 0x180C84E70
	public void set_textViewport(RectTransform value) { }

	// RVA: 0xB0F080 Offset: 0xB0D680 VA: 0x180B0F080
	public TMP_Text get_textComponent() { }

	// RVA: 0xC84E10 Offset: 0xC83410 VA: 0x180C84E10
	public void set_textComponent(TMP_Text value) { }

	// RVA: 0xC83460 Offset: 0xC81A60 VA: 0x180C83460
	public Graphic get_placeholder() { }

	// RVA: 0xC84540 Offset: 0xC82B40 VA: 0x180C84540
	public void set_placeholder(Graphic value) { }

	// RVA: 0x871E40 Offset: 0x870440 VA: 0x180871E40
	public Scrollbar get_verticalScrollbar() { }

	// RVA: 0xC84ED0 Offset: 0xC834D0 VA: 0x180C84ED0
	public void set_verticalScrollbar(Scrollbar value) { }

	// RVA: 0xC83620 Offset: 0xC81C20 VA: 0x180C83620
	public float get_scrollSensitivity() { }

	// RVA: 0xC847B0 Offset: 0xC82DB0 VA: 0x180C847B0
	public void set_scrollSensitivity(float value) { }

	// RVA: 0xC82F80 Offset: 0xC81580 VA: 0x180C82F80
	public Color get_caretColor() { }

	// RVA: 0xC83830 Offset: 0xC81E30 VA: 0x180C83830
	public void set_caretColor(Color value) { }

	// RVA: 0xC83140 Offset: 0xC81740 VA: 0x180C83140
	public bool get_customCaretColor() { }

	// RVA: 0xC83E10 Offset: 0xC82410 VA: 0x180C83E10
	public void set_customCaretColor(bool value) { }

	// RVA: 0xC83630 Offset: 0xC81C30 VA: 0x180C83630
	public Color get_selectionColor() { }

	// RVA: 0xC848E0 Offset: 0xC82EE0 VA: 0x180C848E0
	public void set_selectionColor(Color value) { }

	// RVA: 0xC83420 Offset: 0xC81A20 VA: 0x180C83420
	public TMP_InputField.SubmitEvent get_onEndEdit() { }

	// RVA: 0xC842B0 Offset: 0xC828B0 VA: 0x180C842B0
	public void set_onEndEdit(TMP_InputField.SubmitEvent value) { }

	// RVA: 0x7E6EB0 Offset: 0x7E54B0 VA: 0x1807E6EB0
	public TMP_InputField.SubmitEvent get_onSubmit() { }

	// RVA: 0xC843B0 Offset: 0xC829B0 VA: 0x180C843B0
	public void set_onSubmit(TMP_InputField.SubmitEvent value) { }

	// RVA: 0xA3C9B0 Offset: 0xA3AFB0 VA: 0x180A3C9B0
	public TMP_InputField.SelectionEvent get_onSelect() { }

	// RVA: 0xC84360 Offset: 0xC82960 VA: 0x180C84360
	public void set_onSelect(TMP_InputField.SelectionEvent value) { }

	// RVA: 0x900120 Offset: 0x8FE720 VA: 0x180900120
	public TMP_InputField.SelectionEvent get_onDeselect() { }

	// RVA: 0xC84260 Offset: 0xC82860 VA: 0x180C84260
	public void set_onDeselect(TMP_InputField.SelectionEvent value) { }

	// RVA: 0xC83450 Offset: 0xC81A50 VA: 0x180C83450
	public TMP_InputField.TextSelectionEvent get_onTextSelection() { }

	// RVA: 0xC84400 Offset: 0xC82A00 VA: 0x180C84400
	public void set_onTextSelection(TMP_InputField.TextSelectionEvent value) { }

	// RVA: 0xC83430 Offset: 0xC81A30 VA: 0x180C83430
	public TMP_InputField.TextSelectionEvent get_onEndTextSelection() { }

	// RVA: 0xC84300 Offset: 0xC82900 VA: 0x180C84300
	public void set_onEndTextSelection(TMP_InputField.TextSelectionEvent value) { }

	// RVA: 0xB0E950 Offset: 0xB0CF50 VA: 0x180B0E950
	public TMP_InputField.OnChangeEvent get_onValueChanged() { }

	// RVA: 0xC844F0 Offset: 0xC82AF0 VA: 0x180C844F0
	public void set_onValueChanged(TMP_InputField.OnChangeEvent value) { }

	// RVA: 0xC73E30 Offset: 0xC72430 VA: 0x180C73E30
	public TMP_InputField.TouchScreenKeyboardEvent get_onTouchScreenKeyboardStatusChanged() { }

	// RVA: 0xC84450 Offset: 0xC82A50 VA: 0x180C84450
	public void set_onTouchScreenKeyboardStatusChanged(TMP_InputField.TouchScreenKeyboardEvent value) { }

	// RVA: 0xAD8DF0 Offset: 0xAD73F0 VA: 0x180AD8DF0
	public TMP_InputField.OnValidateInput get_onValidateInput() { }

	// RVA: 0xC844A0 Offset: 0xC82AA0 VA: 0x180C844A0
	public void set_onValidateInput(TMP_InputField.OnValidateInput value) { }

	// RVA: 0xC83050 Offset: 0xC81650 VA: 0x180C83050
	public int get_characterLimit() { }

	// RVA: 0xC83B30 Offset: 0xC82130 VA: 0x180C83B30
	public void set_characterLimit(int value) { }

	// RVA: 0xC83470 Offset: 0xC81A70 VA: 0x180C83470
	public float get_pointSize() { }

	// RVA: 0xC84590 Offset: 0xC82B90 VA: 0x180C84590
	public void set_pointSize(float value) { }

	// RVA: 0xC83160 Offset: 0xC81760 VA: 0x180C83160
	public TMP_FontAsset get_fontAsset() { }

	// RVA: 0xC83E80 Offset: 0xC82480 VA: 0x180C83E80
	public void set_fontAsset(TMP_FontAsset value) { }

	// RVA: 0xC83440 Offset: 0xC81A40 VA: 0x180C83440
	public bool get_onFocusSelectAll() { }

	// RVA: 0xC84350 Offset: 0xC82950 VA: 0x180C84350
	public void set_onFocusSelectAll(bool value) { }

	// RVA: 0xC83600 Offset: 0xC81C00 VA: 0x180C83600
	public bool get_resetOnDeActivation() { }

	// RVA: 0xC84700 Offset: 0xC82D00 VA: 0x180C84700
	public void set_resetOnDeActivation(bool value) { }

	// RVA: 0xC83610 Offset: 0xC81C10 VA: 0x180C83610
	public bool get_restoreOriginalTextOnEscape() { }

	// RVA: 0xC84710 Offset: 0xC82D10 VA: 0x180C84710
	public void set_restoreOriginalTextOnEscape(bool value) { }

	// RVA: 0xC83330 Offset: 0xC81930 VA: 0x180C83330
	public bool get_isRichTextEditingAllowed() { }

	// RVA: 0xC84090 Offset: 0xC82690 VA: 0x180C84090
	public void set_isRichTextEditingAllowed(bool value) { }

	// RVA: 0xC83130 Offset: 0xC81730 VA: 0x180C83130
	public TMP_InputField.ContentType get_contentType() { }

	// RVA: 0xC83C60 Offset: 0xC82260 VA: 0x180C83C60
	public void set_contentType(TMP_InputField.ContentType value) { }

	// RVA: 0x871E30 Offset: 0x870430 VA: 0x180871E30
	public TMP_InputField.LineType get_lineType() { }

	// RVA: 0xC84180 Offset: 0xC82780 VA: 0x180C84180
	public void set_lineType(TMP_InputField.LineType value) { }

	// RVA: 0xC83350 Offset: 0xC81950 VA: 0x180C83350
	public int get_lineLimit() { }

	// RVA: 0xC84110 Offset: 0xC82710 VA: 0x180C84110
	public void set_lineLimit(int value) { }

	// RVA: 0xC83300 Offset: 0xC81900 VA: 0x180C83300
	public TMP_InputField.InputType get_inputType() { }

	// RVA: 0xC83FB0 Offset: 0xC825B0 VA: 0x180C83FB0
	public void set_inputType(TMP_InputField.InputType value) { }

	// RVA: 0xC83340 Offset: 0xC81940 VA: 0x180C83340
	public TouchScreenKeyboardType get_keyboardType() { }

	// RVA: 0xC840A0 Offset: 0xC826A0 VA: 0x180C840A0
	public void set_keyboardType(TouchScreenKeyboardType value) { }

	// RVA: 0xC83060 Offset: 0xC81660 VA: 0x180C83060
	public TMP_InputField.CharacterValidation get_characterValidation() { }

	// RVA: 0xC83BE0 Offset: 0xC821E0 VA: 0x180C83BE0
	public void set_characterValidation(TMP_InputField.CharacterValidation value) { }

	// RVA: 0xC83310 Offset: 0xC81910 VA: 0x180C83310
	public TMP_InputValidator get_inputValidator() { }

	// RVA: 0xC84020 Offset: 0xC82620 VA: 0x180C84020
	public void set_inputValidator(TMP_InputValidator value) { }

	// RVA: 0xC835F0 Offset: 0xC81BF0 VA: 0x180C835F0
	public bool get_readOnly() { }

	// RVA: 0xC846F0 Offset: 0xC82CF0 VA: 0x180C846F0
	public void set_readOnly(bool value) { }

	// RVA: 0xBC7C40 Offset: 0xBC6240 VA: 0x180BC7C40
	public bool get_richText() { }

	// RVA: 0xC84720 Offset: 0xC82D20 VA: 0x180C84720
	public void set_richText(bool value) { }

	// RVA: 0xC83400 Offset: 0xC81A00 VA: 0x180C83400
	public bool get_multiLine() { }

	// RVA: 0xC82F70 Offset: 0xC81570 VA: 0x180C82F70
	public char get_asteriskChar() { }

	// RVA: 0xC83760 Offset: 0xC81D60 VA: 0x180C83760
	public void set_asteriskChar(char value) { }

	// RVA: 0x8FA070 Offset: 0x8F8670 VA: 0x1808FA070
	public bool get_wasCanceled() { }

	// RVA: 0xC76E90 Offset: 0xC75490 VA: 0x180C76E90
	protected void ClampStringPos(ref int pos) { }

	// RVA: 0xC76E40 Offset: 0xC75440 VA: 0x180C76E40
	protected void ClampCaretPos(ref int pos) { }

	// RVA: 0xC82FE0 Offset: 0xC815E0 VA: 0x180C82FE0
	protected int get_caretPositionInternal() { }

	// RVA: 0xC838E0 Offset: 0xC81EE0 VA: 0x180C838E0
	protected void set_caretPositionInternal(int value) { }

	// RVA: 0xC83640 Offset: 0xC81C40 VA: 0x180C83640
	protected int get_stringPositionInternal() { }

	// RVA: 0xC84CA0 Offset: 0xC832A0 VA: 0x180C84CA0
	protected void set_stringPositionInternal(int value) { }

	// RVA: 0xC83010 Offset: 0xC81610 VA: 0x180C83010
	protected int get_caretSelectPositionInternal() { }

	// RVA: 0xC83A30 Offset: 0xC82030 VA: 0x180C83A30
	protected void set_caretSelectPositionInternal(int value) { }

	// RVA: 0xC83670 Offset: 0xC81C70 VA: 0x180C83670
	protected int get_stringSelectPositionInternal() { }

	// RVA: 0xC84DC0 Offset: 0xC833C0 VA: 0x180C84DC0
	protected void set_stringSelectPositionInternal(int value) { }

	// RVA: 0xC83170 Offset: 0xC81770 VA: 0x180C83170
	private bool get_hasSelection() { }

	// RVA: 0xC83010 Offset: 0xC81610 VA: 0x180C83010
	public int get_caretPosition() { }

	// RVA: 0xC83940 Offset: 0xC81F40 VA: 0x180C83940
	public void set_caretPosition(int value) { }

	// RVA: 0xC82FE0 Offset: 0xC815E0 VA: 0x180C82FE0
	public int get_selectionAnchorPosition() { }

	// RVA: 0xC84850 Offset: 0xC82E50 VA: 0x180C84850
	public void set_selectionAnchorPosition(int value) { }

	// RVA: 0xC83010 Offset: 0xC81610 VA: 0x180C83010
	public int get_selectionFocusPosition() { }

	// RVA: 0xC84990 Offset: 0xC82F90 VA: 0x180C84990
	public void set_selectionFocusPosition(int value) { }

	// RVA: 0xC83670 Offset: 0xC81C70 VA: 0x180C83670
	public int get_stringPosition() { }

	// RVA: 0xC84CF0 Offset: 0xC832F0 VA: 0x180C84CF0
	public void set_stringPosition(int value) { }

	// RVA: 0xC83640 Offset: 0xC81C40 VA: 0x180C83640
	public int get_selectionStringAnchorPosition() { }

	// RVA: 0xC84A20 Offset: 0xC83020 VA: 0x180C84A20
	public void set_selectionStringAnchorPosition(int value) { }

	// RVA: 0xC83670 Offset: 0xC81C70 VA: 0x180C83670
	public int get_selectionStringFocusPosition() { }

	// RVA: 0xC84AA0 Offset: 0xC830A0 VA: 0x180C84AA0
	public void set_selectionStringFocusPosition(int value) { }

	// RVA: 0xC7EBC0 Offset: 0xC7D1C0 VA: 0x180C7EBC0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0xC7E2D0 Offset: 0xC7C8D0 VA: 0x180C7E2D0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0xC7E050 Offset: 0xC7C650 VA: 0x180C7E050
	private void ON_TEXT_CHANGED(Object obj) { }

	[IteratorStateMachineAttribute] // RVA: 0xD11F0 Offset: 0xD05F0 VA: 0x1800D11F0
	// RVA: 0xC76DD0 Offset: 0xC753D0 VA: 0x180C76DD0
	private IEnumerator CaretBlink() { }

	// RVA: 0xC81620 Offset: 0xC7FC20 VA: 0x180C81620
	private void SetCaretVisible() { }

	// RVA: 0xC81550 Offset: 0xC7FB50 VA: 0x180C81550
	private void SetCaretActive() { }

	// RVA: 0xC7F7E0 Offset: 0xC7DDE0 VA: 0x180C7F7E0
	protected void OnFocus() { }

	// RVA: 0xC810E0 Offset: 0xC7F6E0 VA: 0x180C810E0
	protected void SelectAll() { }

	// RVA: 0xC7D2F0 Offset: 0xC7B8F0 VA: 0x180C7D2F0
	public void MoveTextEnd(bool shift) { }

	// RVA: 0xC7D540 Offset: 0xC7BB40 VA: 0x180C7D540
	public void MoveTextStart(bool shift) { }

	// RVA: 0xC7D770 Offset: 0xC7BD70 VA: 0x180C7D770
	public void MoveToEndOfLine(bool shift, bool ctrl) { }

	// RVA: 0xC7DA20 Offset: 0xC7C020 VA: 0x180C7DA20
	public void MoveToStartOfLine(bool shift, bool ctrl) { }

	// RVA: 0xC83070 Offset: 0xC81670 VA: 0x180C83070
	private static string get_clipboard() { }

	// RVA: 0xC83C50 Offset: 0xC82250 VA: 0x180C83C50
	private static void set_clipboard(string value) { }

	// RVA: 0xC79CA0 Offset: 0xC782A0 VA: 0x180C79CA0
	private bool InPlaceEditing() { }

	// RVA: 0xC821A0 Offset: 0xC807A0 VA: 0x180C821A0
	private void UpdateStringPositionFromKeyboard() { }

	// RVA: 0xC7A480 Offset: 0xC78A80 VA: 0x180C7A480 Slot: 60
	protected virtual void LateUpdate() { }

	// RVA: 0xC7B190 Offset: 0xC79790 VA: 0x180C7B190
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0xC7E230 Offset: 0xC7C830 VA: 0x180C7E230 Slot: 61
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0xC7E600 Offset: 0xC7CC00 VA: 0x180C7E600 Slot: 62
	public virtual void OnDrag(PointerEventData eventData) { }

	[IteratorStateMachineAttribute] // RVA: 0xD1330 Offset: 0xD0730 VA: 0x1800D1330
	// RVA: 0xC7B2A0 Offset: 0xC798A0 VA: 0x180C7B2A0
	private IEnumerator MouseDragOutsideRect(PointerEventData eventData) { }

	// RVA: 0xC7F220 Offset: 0xC7D820 VA: 0x180C7F220 Slot: 63
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0xC7F880 Offset: 0xC7DE80 VA: 0x180C7F880 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0xC7A020 Offset: 0xC78620 VA: 0x180C7A020
	protected TMP_InputField.EditState KeyPressed(Event evt) { }

	// RVA: 0xC7A010 Offset: 0xC78610 VA: 0x180C7A010 Slot: 64
	protected virtual bool IsValidChar(char c) { }

	// RVA: 0xC80FA0 Offset: 0xC7F5A0 VA: 0x180C80FA0
	public void ProcessEvent(Event e) { }

	// RVA: 0xC806A0 Offset: 0xC7ECA0 VA: 0x180C806A0 Slot: 65
	public virtual void OnUpdateSelected(BaseEventData eventData) { }

	// RVA: 0xC803A0 Offset: 0xC7E9A0 VA: 0x180C803A0 Slot: 66
	public virtual void OnScroll(PointerEventData eventData) { }

	// RVA: 0xC79B20 Offset: 0xC78120 VA: 0x180C79B20
	private string GetSelectedString() { }

	// RVA: 0xC77F90 Offset: 0xC76590 VA: 0x180C77F90
	private int FindNextWordBegin() { }

	// RVA: 0xC7CA90 Offset: 0xC7B090 VA: 0x180C7CA90
	private void MoveRight(bool shift, bool ctrl) { }

	// RVA: 0xC780A0 Offset: 0xC766A0 VA: 0x180C780A0
	private int FindPrevWordBegin() { }

	// RVA: 0xC7B6E0 Offset: 0xC79CE0 VA: 0x180C7B6E0
	private void MoveLeft(bool shift, bool ctrl) { }

	// RVA: 0xC7AE30 Offset: 0xC79430 VA: 0x180C7AE30
	private int LineUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	// RVA: 0xC7AB30 Offset: 0xC79130 VA: 0x180C7AB30
	private int LineDownCharacterPosition(int originalPos, bool goToLastChar) { }

	// RVA: 0xC80BE0 Offset: 0xC7F1E0 VA: 0x180C80BE0
	private int PageUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	// RVA: 0xC80800 Offset: 0xC7EE00 VA: 0x180C80800
	private int PageDownCharacterPosition(int originalPos, bool goToLastChar) { }

	// RVA: 0xC7B6D0 Offset: 0xC79CD0 VA: 0x180C7B6D0
	private void MoveDown(bool shift) { }

	// RVA: 0xC7B330 Offset: 0xC79930 VA: 0x180C7B330
	private void MoveDown(bool shift, bool goToLastChar) { }

	// RVA: 0xC7E040 Offset: 0xC7C640 VA: 0x180C7E040
	private void MoveUp(bool shift) { }

	// RVA: 0xC7DCC0 Offset: 0xC7C2C0 VA: 0x180C7DCC0
	private void MoveUp(bool shift, bool goToFirstChar) { }

	// RVA: 0xC7CA80 Offset: 0xC7B080 VA: 0x180C7CA80
	private void MovePageUp(bool shift) { }

	// RVA: 0xC7C4E0 Offset: 0xC7AAE0 VA: 0x180C7C4E0
	private void MovePageUp(bool shift, bool goToFirstChar) { }

	// RVA: 0xC7C4D0 Offset: 0xC7AAD0 VA: 0x180C7C4D0
	private void MovePageDown(bool shift) { }

	// RVA: 0xC7BF10 Offset: 0xC7A510 VA: 0x180C7BF10
	private void MovePageDown(bool shift, bool goToLastChar) { }

	// RVA: 0xC77630 Offset: 0xC75C30 VA: 0x180C77630
	private void Delete() { }

	// RVA: 0xC772C0 Offset: 0xC758C0 VA: 0x180C772C0
	private void DeleteKey() { }

	// RVA: 0xC76820 Offset: 0xC74E20 VA: 0x180C76820
	private void Backspace() { }

	// RVA: 0xC75FD0 Offset: 0xC745D0 VA: 0x180C75FD0 Slot: 67
	protected virtual void Append(string input) { }

	// RVA: 0xC75E60 Offset: 0xC74460 VA: 0x180C75E60 Slot: 68
	protected virtual void Append(char input) { }

	// RVA: 0xC79D90 Offset: 0xC78390 VA: 0x180C79D90
	private void Insert(char c) { }

	// RVA: 0xC82480 Offset: 0xC80A80 VA: 0x180C82480
	private void UpdateTouchKeyboardFromEditChanges() { }

	// RVA: 0xC81430 Offset: 0xC7FA30 VA: 0x180C81430
	private void SendOnValueChangedAndUpdateLabel() { }

	// RVA: 0xC81490 Offset: 0xC7FA90 VA: 0x180C81490
	private void SendOnValueChanged() { }

	// RVA: 0xC81140 Offset: 0xC7F740 VA: 0x180C81140
	protected void SendOnEndEdit() { }

	// RVA: 0xC81310 Offset: 0xC7F910 VA: 0x180C81310
	protected void SendOnSubmit() { }

	// RVA: 0xC812C0 Offset: 0xC7F8C0 VA: 0x180C812C0
	protected void SendOnFocus() { }

	// RVA: 0xC81270 Offset: 0xC7F870 VA: 0x180C81270
	protected void SendOnFocusLost() { }

	// RVA: 0xC81360 Offset: 0xC7F960 VA: 0x180C81360
	protected void SendOnTextSelection() { }

	// RVA: 0xC81190 Offset: 0xC7F790 VA: 0x180C81190
	protected void SendOnEndTextSelection() { }

	// RVA: 0xC814E0 Offset: 0xC7FAE0 VA: 0x180C814E0
	protected void SendTouchScreenKeyboardStatusChanged() { }

	// RVA: 0xC81C50 Offset: 0xC80250 VA: 0x180C81C50
	protected void UpdateLabel() { }

	// RVA: 0xC81FF0 Offset: 0xC805F0 VA: 0x180C81FF0
	private void UpdateScrollbar() { }

	// RVA: 0xC80550 Offset: 0xC7EB50 VA: 0x180C80550
	private void OnScrollbarValueChange(float value) { }

	// RVA: 0xC75CB0 Offset: 0xC742B0 VA: 0x180C75CB0
	private void AdjustTextPositionRelativeToViewport(float relativePosition) { }

	// RVA: 0xC79A20 Offset: 0xC78020 VA: 0x180C79A20
	private int GetCaretPositionFromStringIndex(int stringIndex) { }

	// RVA: 0xC79AA0 Offset: 0xC780A0 VA: 0x180C79AA0
	private int GetMinCaretPositionFromStringIndex(int stringIndex) { }

	// RVA: 0xC79A20 Offset: 0xC78020 VA: 0x180C79A20
	private int GetMaxCaretPositionFromStringIndex(int stringIndex) { }

	// RVA: 0xC79C20 Offset: 0xC78220 VA: 0x180C79C20
	private int GetStringIndexFromCaretPosition(int caretPosition) { }

	// RVA: 0xC78190 Offset: 0xC76790 VA: 0x180C78190
	public void ForceLabelUpdate() { }

	// RVA: 0xC7B130 Offset: 0xC79730 VA: 0x180C7B130
	private void MarkGeometryAsDirty() { }

	// RVA: 0xC80FB0 Offset: 0xC7F5B0 VA: 0x180C80FB0 Slot: 69
	public virtual void Rebuild(CanvasUpdate update) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 70
	public virtual void LayoutComplete() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 71
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0xC81B90 Offset: 0xC80190 VA: 0x180C81B90
	private void UpdateGeometry() { }

	// RVA: 0xC76080 Offset: 0xC74680 VA: 0x180C76080
	private void AssignPositioningIfNeeded() { }

	// RVA: 0xC7F250 Offset: 0xC7D850 VA: 0x180C7F250
	private void OnFillVBO(Mesh vbo) { }

	// RVA: 0xC781A0 Offset: 0xC767A0 VA: 0x180C781A0
	private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0xC76ED0 Offset: 0xC754D0 VA: 0x180C76ED0
	private void CreateCursorVerts() { }

	// RVA: 0xC78C30 Offset: 0xC77230 VA: 0x180C78C30
	private void GenerateHightlight(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0xC753B0 Offset: 0xC739B0 VA: 0x180C753B0
	private void AdjustRectTransformRelativeToViewport(Vector2 startPosition, float height, bool isCharVisible) { }

	// RVA: 0xC824D0 Offset: 0xC80AD0 VA: 0x180C824D0
	protected char Validate(string text, int pos, char ch) { }

	// RVA: 0xC75260 Offset: 0xC73860 VA: 0x180C75260
	public void ActivateInputField() { }

	// RVA: 0xC74CC0 Offset: 0xC732C0 VA: 0x180C74CC0
	private void ActivateInputFieldInternal() { }

	// RVA: 0xC805B0 Offset: 0xC7EBB0 VA: 0x180C805B0 Slot: 36
	public override void OnSelect(BaseEventData eventData) { }

	// RVA: 0xC7F850 Offset: 0xC7DE50 VA: 0x180C7F850 Slot: 72
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void OnControlClick() { }

	// RVA: 0xC81080 Offset: 0xC7F680 VA: 0x180C81080
	public void ReleaseSelection() { }

	// RVA: 0xC77070 Offset: 0xC75670 VA: 0x180C77070
	public void DeactivateInputField(bool clearSelection = False) { }

	// RVA: 0xC7E260 Offset: 0xC7C860 VA: 0x180C7E260 Slot: 37
	public override void OnDeselect(BaseEventData eventData) { }

	// RVA: 0xC80610 Offset: 0xC7EC10 VA: 0x180C80610 Slot: 73
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0xC77E20 Offset: 0xC76420 VA: 0x180C77E20
	private void EnforceContentType() { }

	// RVA: 0xC818D0 Offset: 0xC7FED0 VA: 0x180C818D0
	private void SetTextComponentWrapMode() { }

	// RVA: 0xC81840 Offset: 0xC7FE40 VA: 0x180C81840
	private void SetTextComponentRichTextMode() { }

	// RVA: 0xC81B00 Offset: 0xC80100 VA: 0x180C81B00
	private void SetToCustomIfContentTypeIsNot(TMP_InputField.ContentType[] allowedContentTypes) { }

	// RVA: 0xC81B70 Offset: 0xC80170 VA: 0x180C81B70
	private void SetToCustom() { }

	// RVA: 0xC81B70 Offset: 0xC80170 VA: 0x180C81B70
	private void SetToCustom(TMP_InputField.CharacterValidation characterValidation) { }

	// RVA: 0xC77DF0 Offset: 0xC763F0 VA: 0x180C77DF0 Slot: 26
	protected override void DoStateTransition(Selectable.SelectionState state, bool instant) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 74
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 75
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 76
	public virtual float get_minWidth() { }

	// RVA: 0xC83530 Offset: 0xC81B30 VA: 0x180C83530 Slot: 77
	public virtual float get_preferredWidth() { }

	// RVA: 0xC83150 Offset: 0xC81750 VA: 0x180C83150 Slot: 78
	public virtual float get_flexibleWidth() { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 79
	public virtual float get_minHeight() { }

	// RVA: 0xC83480 Offset: 0xC81A80 VA: 0x180C83480 Slot: 80
	public virtual float get_preferredHeight() { }

	// RVA: 0xC83150 Offset: 0xC81750 VA: 0x180C83150 Slot: 81
	public virtual float get_flexibleHeight() { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 82
	public virtual int get_layoutPriority() { }

	// RVA: 0xC81750 Offset: 0xC7FD50 VA: 0x180C81750
	public void SetGlobalPointSize(float pointSize) { }

	// RVA: 0xC81660 Offset: 0xC7FC60 VA: 0x180C81660
	public void SetGlobalFontAsset(TMP_FontAsset fontAsset) { }

	// RVA: 0xC82BD0 Offset: 0xC811D0 VA: 0x180C82BD0
	private static void .cctor() { }

	// RVA: 0xABD5D0 Offset: 0xABBBD0 VA: 0x180ABD5D0 Slot: 46
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

	// RVA: 0xD97B10 Offset: 0xD96110 VA: 0x180D97B10 Slot: 12
	public virtual char Invoke(string text, int charIndex, char addedChar) { }

	// RVA: 0xD97A40 Offset: 0xD96040 VA: 0x180D97A40 Slot: 13
	public virtual IAsyncResult BeginInvoke(string text, int charIndex, char addedChar, AsyncCallback callback, object object) { }

	// RVA: 0xD97AE0 Offset: 0xD960E0 VA: 0x180D97AE0 Slot: 14
	public virtual char EndInvoke(IAsyncResult result) { }

}

public class TMP_InputField.SubmitEvent : UnityEvent<string> // TypeDefIndex: 6789
{	// Methods

	// RVA: 0xD980F0 Offset: 0xD966F0 VA: 0x180D980F0
	public void .ctor() { }

}

public class TMP_InputField.OnChangeEvent : UnityEvent<string> // TypeDefIndex: 6790
{	// Methods

	// RVA: 0xD97A00 Offset: 0xD96000 VA: 0x180D97A00
	public void .ctor() { }

}

public class TMP_InputField.SelectionEvent : UnityEvent<string> // TypeDefIndex: 6791
{	// Methods

	// RVA: 0xD980B0 Offset: 0xD966B0 VA: 0x180D980B0
	public void .ctor() { }

}

public class TMP_InputField.TextSelectionEvent : UnityEvent<string, int, int> // TypeDefIndex: 6792
{	// Methods

	// RVA: 0xDB5C50 Offset: 0xDB4250 VA: 0x180DB5C50
	public void .ctor() { }

}

public class TMP_InputField.TouchScreenKeyboardEvent : UnityEvent<TouchScreenKeyboard.Status> // TypeDefIndex: 6793
{	// Methods

	// RVA: 0xDB5C90 Offset: 0xDB4290 VA: 0x180DB5C90
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

	// RVA: 0xDB5CD0 Offset: 0xDB42D0 VA: 0x180DB5CD0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDB5E20 Offset: 0xDB4420 VA: 0x180DB5E20 Slot: 8
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

	// RVA: 0xDB5E70 Offset: 0xDB4470 VA: 0x180DB5E70 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDB6120 Offset: 0xDB4720 VA: 0x180DB6120 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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
	|-RVA: 0x17ADDB0 Offset: 0x17AC3B0 VA: 0x1817ADDB0
	|-TMP_ListPool<object>.Get
	|-TMP_ListPool<Canvas>.Get
	|-TMP_ListPool<IMaterialModifier>.Get
	|-TMP_ListPool<Mask>.Get
	*/

	// RVA: -1 Offset: -1
	public static void Release(List<T> toRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ADF20 Offset: 0x17AC520 VA: 0x1817ADF20
	|-TMP_ListPool<object>.Release
	|-TMP_ListPool<Canvas>.Release
	|-TMP_ListPool<IMaterialModifier>.Release
	|-TMP_ListPool<Mask>.Release
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AE0A0 Offset: 0x17AC6A0 VA: 0x1817AE0A0
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
	|-RVA: 0xD65540 Offset: 0xD63B40 VA: 0x180D65540
	|-TMP_ListPool.<>c<object>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5B020 Offset: 0xD59620 VA: 0x180D5B020
	|-TMP_ListPool.<>c<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <.cctor>b__3_0(List<T> l) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E9170 Offset: 0x15E7770 VA: 0x1815E9170
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

	// RVA: 0xD9AED0 Offset: 0xD994D0 VA: 0x180D9AED0
	private static void .cctor() { }

	// RVA: 0xD99E40 Offset: 0xD98440 VA: 0x180D99E40
	private static void OnPreRender(Camera cam) { }

	// RVA: 0xD99DB0 Offset: 0xD983B0 VA: 0x180D99DB0
	private static void OnPreRenderCanvas() { }

	// RVA: 0xD999E0 Offset: 0xD97FE0 VA: 0x180D999E0
	public static Material GetStencilMaterial(Material baseMaterial, int stencilID) { }

	// RVA: 0xD9A890 Offset: 0xD98E90 VA: 0x180D9A890
	public static void ReleaseStencilMaterial(Material stencilMaterial) { }

	// RVA: 0xD98E50 Offset: 0xD97450 VA: 0x180D98E50
	public static Material GetBaseMaterial(Material stencilMaterial) { }

	// RVA: 0xD9ADC0 Offset: 0xD993C0 VA: 0x180D9ADC0
	public static Material SetStencil(Material material, int stencilID) { }

	// RVA: 0xD983E0 Offset: 0xD969E0 VA: 0x180D983E0
	public static void AddMaskingMaterial(Material baseMaterial, Material stencilMaterial, int stencilID) { }

	// RVA: 0xD9AC80 Offset: 0xD99280 VA: 0x180D9AC80
	public static void RemoveStencilMaterial(Material stencilMaterial) { }

	// RVA: 0xD99ED0 Offset: 0xD984D0 VA: 0x180D99ED0
	public static void ReleaseBaseMaterial(Material baseMaterial) { }

	// RVA: 0xD98860 Offset: 0xD96E60 VA: 0x180D98860
	public static void ClearMaterials() { }

	// RVA: 0xD995F0 Offset: 0xD97BF0 VA: 0x180D995F0
	public static int GetStencilID(GameObject obj) { }

	// RVA: 0xD99420 Offset: 0xD97A20 VA: 0x180D99420
	public static Material GetMaterialForRendering(MaskableGraphic graphic, Material baseMaterial) { }

	// RVA: 0xD98CF0 Offset: 0xD972F0 VA: 0x180D98CF0
	private static Transform FindRootSortOverrideCanvas(Transform start) { }

	// RVA: 0xD98FB0 Offset: 0xD975B0 VA: 0x180D98FB0
	public static Material GetFallbackMaterial(Material sourceMaterial, Material targetMaterial) { }

	// RVA: 0xD982B0 Offset: 0xD968B0 VA: 0x180D982B0
	public static void AddFallbackMaterialReference(Material targetMaterial) { }

	// RVA: 0xD9AAE0 Offset: 0xD990E0 VA: 0x180D9AAE0
	public static void RemoveFallbackMaterialReference(Material targetMaterial) { }

	// RVA: 0xD98630 Offset: 0xD96C30 VA: 0x180D98630
	public static void CleanupFallbackMaterials() { }

	// RVA: 0xD9A6C0 Offset: 0xD98CC0 VA: 0x180D9A6C0
	public static void ReleaseFallbackMaterial(Material fallackMaterial) { }

	// RVA: 0xD98A00 Offset: 0xD97000 VA: 0x180D98A00
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

	// RVA: 0xDB6170 Offset: 0xDB4770 VA: 0x180DB6170
	internal bool <GetBaseMaterial>b__0(TMP_MaterialManager.MaskingMaterial item) { }

}

private sealed class TMP_MaterialManager.<>c__DisplayClass12_0 // TypeDefIndex: 6806
{	// Fields
	public Material stencilMaterial; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xDB61F0 Offset: 0xDB47F0 VA: 0x180DB61F0
	internal bool <AddMaskingMaterial>b__0(TMP_MaterialManager.MaskingMaterial item) { }

}

private sealed class TMP_MaterialManager.<>c__DisplayClass13_0 // TypeDefIndex: 6807
{	// Fields
	public Material stencilMaterial; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xDB6270 Offset: 0xDB4870 VA: 0x180DB6270
	internal bool <RemoveStencilMaterial>b__0(TMP_MaterialManager.MaskingMaterial item) { }

}

private sealed class TMP_MaterialManager.<>c__DisplayClass14_0 // TypeDefIndex: 6808
{	// Fields
	public Material baseMaterial; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xDB62F0 Offset: 0xDB48F0 VA: 0x180DB62F0
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

	// RVA: 0x122680 Offset: 0x121A80 VA: 0x180122680
	public void .ctor(Mesh mesh, int size) { }

	// RVA: 0x122690 Offset: 0x121A90 VA: 0x180122690
	public void .ctor(Mesh mesh, int size, bool isVolumetric) { }

	// RVA: 0x122480 Offset: 0x121880 VA: 0x180122480
	public void ResizeMeshInfo(int size) { }

	// RVA: 0x122490 Offset: 0x121890 VA: 0x180122490
	public void ResizeMeshInfo(int size, bool isVolumetric) { }

	// RVA: 0x1223D0 Offset: 0x1217D0 VA: 0x1801223D0
	public void Clear() { }

	// RVA: 0x122290 Offset: 0x121690 VA: 0x180122290
	public void Clear(bool uploadChanges) { }

	// RVA: 0x122250 Offset: 0x121650 VA: 0x180122250
	public void ClearUnusedVertices() { }

	// RVA: 0x122160 Offset: 0x121560 VA: 0x180122160
	public void ClearUnusedVertices(int startIndex) { }

	// RVA: 0x122190 Offset: 0x121590 VA: 0x180122190
	public void ClearUnusedVertices(int startIndex, bool updateMesh) { }

	// RVA: 0x1224A0 Offset: 0x1218A0 VA: 0x1801224A0
	public void SortGeometry(VertexSortingOrder order) { }

	// RVA: 0x122520 Offset: 0x121920 VA: 0x180122520
	public void SortGeometry(IList<int> sortingOrder) { }

	// RVA: 0x122670 Offset: 0x121A70 VA: 0x180122670
	public void SwapVertexData(int src, int dst) { }

	// RVA: 0xD9D210 Offset: 0xD9B810 VA: 0x180D9D210
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
	|-RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	|-TMP_ObjectPool<object>.get_countAll
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	private void set_countAll(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7D0D60 Offset: 0x7CF360 VA: 0x1807D0D60
	|-TMP_ObjectPool<object>.set_countAll
	*/

	// RVA: -1 Offset: -1
	public int get_countActive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AE5F0 Offset: 0x17ACBF0 VA: 0x1817AE5F0
	|-TMP_ObjectPool<object>.get_countActive
	*/

	// RVA: -1 Offset: -1
	public int get_countInactive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE07DD0 Offset: 0xE063D0 VA: 0x180E07DD0
	|-TMP_ObjectPool<object>.get_countInactive
	*/

	// RVA: -1 Offset: -1
	public void .ctor(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AE530 Offset: 0x17ACB30 VA: 0x1817AE530
	|-TMP_ObjectPool<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public T Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AE340 Offset: 0x17AC940 VA: 0x1817AE340
	|-TMP_ObjectPool<object>.Get
	*/

	// RVA: -1 Offset: -1
	public void Release(T element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AE430 Offset: 0x17ACA30 VA: 0x1817AE430
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
	|-RVA: 0x210480 Offset: 0x20F880 VA: 0x180210480
	|-TMP_RichTextTagStack<int>..ctor
	|-TMP_RichTextTagStack<Int32Enum>..ctor
	|-TMP_RichTextTagStack<float>..ctor
	|-TMP_RichTextTagStack<TextAlignmentOptions>..ctor
	|-TMP_RichTextTagStack<Color32>..ctor
	|
	|-RVA: 0x2105D0 Offset: 0x20F9D0 VA: 0x1802105D0
	|-TMP_RichTextTagStack<object>..ctor
	|-TMP_RichTextTagStack<TMP_ColorGradient>..ctor
	|
	|-RVA: 0x2106B0 Offset: 0x20FAB0 VA: 0x1802106B0
	|-TMP_RichTextTagStack<MaterialReference>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2104D0 Offset: 0x20F8D0 VA: 0x1802104D0
	|-TMP_RichTextTagStack<int>..ctor
	|-TMP_RichTextTagStack<Int32Enum>..ctor
	|-TMP_RichTextTagStack<float>..ctor
	|-TMP_RichTextTagStack<FontWeight>..ctor
	|-TMP_RichTextTagStack<Color32>..ctor
	|
	|-RVA: 0x210550 Offset: 0x20F950 VA: 0x180210550
	|-TMP_RichTextTagStack<object>..ctor
	|
	|-RVA: 0x210620 Offset: 0x20FA20 VA: 0x180210620
	|-TMP_RichTextTagStack<MaterialReference>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20F520 Offset: 0x20E920 VA: 0x18020F520
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
	|-RVA: 0x210350 Offset: 0x20F750 VA: 0x180210350
	|-TMP_RichTextTagStack<int>.SetDefault
	|-TMP_RichTextTagStack<Int32Enum>.SetDefault
	|-TMP_RichTextTagStack<FontWeight>.SetDefault
	|-TMP_RichTextTagStack<TextAlignmentOptions>.SetDefault
	|-TMP_RichTextTagStack<Color32>.SetDefault
	|
	|-RVA: 0x210390 Offset: 0x20F790 VA: 0x180210390
	|-TMP_RichTextTagStack<object>.SetDefault
	|-TMP_RichTextTagStack<TMP_ColorGradient>.SetDefault
	|
	|-RVA: 0x210440 Offset: 0x20F840 VA: 0x180210440
	|-TMP_RichTextTagStack<float>.SetDefault
	|
	|-RVA: 0x2103E0 Offset: 0x20F7E0 VA: 0x1802103E0
	|-TMP_RichTextTagStack<MaterialReference>.SetDefault
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20F3E0 Offset: 0x20E7E0 VA: 0x18020F3E0
	|-TMP_RichTextTagStack<int>.Add
	|-TMP_RichTextTagStack<Int32Enum>.Add
	|-TMP_RichTextTagStack<FontWeight>.Add
	|-TMP_RichTextTagStack<TextAlignmentOptions>.Add
	|-TMP_RichTextTagStack<Color32>.Add
	|
	|-RVA: 0x20F420 Offset: 0x20E820 VA: 0x18020F420
	|-TMP_RichTextTagStack<object>.Add
	|-TMP_RichTextTagStack<TMP_ColorGradient>.Add
	|
	|-RVA: 0x20F470 Offset: 0x20E870 VA: 0x18020F470
	|-TMP_RichTextTagStack<float>.Add
	|
	|-RVA: 0x20F4B0 Offset: 0x20E8B0 VA: 0x18020F4B0
	|-TMP_RichTextTagStack<MaterialReference>.Add
	*/

	// RVA: -1 Offset: -1
	public T Remove() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x210270 Offset: 0x20F670 VA: 0x180210270
	|-TMP_RichTextTagStack<int>.Remove
	|-TMP_RichTextTagStack<Int32Enum>.Remove
	|-TMP_RichTextTagStack<FontWeight>.Remove
	|-TMP_RichTextTagStack<TextAlignmentOptions>.Remove
	|-TMP_RichTextTagStack<Color32>.Remove
	|
	|-RVA: 0x2102E0 Offset: 0x20F6E0 VA: 0x1802102E0
	|-TMP_RichTextTagStack<object>.Remove
	|-TMP_RichTextTagStack<TMP_ColorGradient>.Remove
	|
	|-RVA: 0x210140 Offset: 0x20F540 VA: 0x180210140
	|-TMP_RichTextTagStack<float>.Remove
	|
	|-RVA: 0x2101C0 Offset: 0x20F5C0 VA: 0x1802101C0
	|-TMP_RichTextTagStack<MaterialReference>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Push(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20FC90 Offset: 0x20F090 VA: 0x18020FC90
	|-TMP_RichTextTagStack<int>.Push
	|-TMP_RichTextTagStack<Int32Enum>.Push
	|
	|-RVA: 0x20FF60 Offset: 0x20F360 VA: 0x18020FF60
	|-TMP_RichTextTagStack<object>.Push
	|
	|-RVA: 0x210050 Offset: 0x20F450 VA: 0x180210050
	|-TMP_RichTextTagStack<float>.Push
	|
	|-RVA: 0x20FD70 Offset: 0x20F170 VA: 0x18020FD70
	|-TMP_RichTextTagStack<MaterialReference>.Push
	|
	|-RVA: 0x20FE80 Offset: 0x20F280 VA: 0x18020FE80
	|-TMP_RichTextTagStack<Color32>.Push
	*/

	// RVA: -1 Offset: -1
	public T Pop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20F970 Offset: 0x20ED70 VA: 0x18020F970
	|-TMP_RichTextTagStack<int>.Pop
	|-TMP_RichTextTagStack<Int32Enum>.Pop
	|-TMP_RichTextTagStack<Color32>.Pop
	|
	|-RVA: 0x20F9D0 Offset: 0x20EDD0 VA: 0x18020F9D0
	|-TMP_RichTextTagStack<object>.Pop
	|
	|-RVA: 0x20FA40 Offset: 0x20EE40 VA: 0x18020FA40
	|-TMP_RichTextTagStack<float>.Pop
	|
	|-RVA: 0x20F880 Offset: 0x20EC80 VA: 0x18020F880
	|-TMP_RichTextTagStack<MaterialReference>.Pop
	*/

	// RVA: -1 Offset: -1
	public T Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20F710 Offset: 0x20EB10 VA: 0x18020F710
	|-TMP_RichTextTagStack<int>.Peek
	|-TMP_RichTextTagStack<Int32Enum>.Peek
	|-TMP_RichTextTagStack<FontWeight>.Peek
	|-TMP_RichTextTagStack<Color32>.Peek
	|
	|-RVA: 0x20F7E0 Offset: 0x20EBE0 VA: 0x18020F7E0
	|-TMP_RichTextTagStack<object>.Peek
	|
	|-RVA: 0x20F830 Offset: 0x20EC30 VA: 0x18020F830
	|-TMP_RichTextTagStack<float>.Peek
	|
	|-RVA: 0x20F760 Offset: 0x20EB60 VA: 0x18020F760
	|-TMP_RichTextTagStack<MaterialReference>.Peek
	*/

	// RVA: -1 Offset: -1
	public T CurrentItem() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20F530 Offset: 0x20E930 VA: 0x18020F530
	|-TMP_RichTextTagStack<int>.CurrentItem
	|-TMP_RichTextTagStack<Int32Enum>.CurrentItem
	|-TMP_RichTextTagStack<Color32>.CurrentItem
	|
	|-RVA: 0x20F6A0 Offset: 0x20EAA0 VA: 0x18020F6A0
	|-TMP_RichTextTagStack<object>.CurrentItem
	|
	|-RVA: 0x20F630 Offset: 0x20EA30 VA: 0x18020F630
	|-TMP_RichTextTagStack<float>.CurrentItem
	|
	|-RVA: 0x20F590 Offset: 0x20E990 VA: 0x18020F590
	|-TMP_RichTextTagStack<MaterialReference>.CurrentItem
	*/

	// RVA: -1 Offset: -1
	public T PreviousItem() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20FAA0 Offset: 0x20EEA0 VA: 0x18020FAA0
	|-TMP_RichTextTagStack<int>.PreviousItem
	|-TMP_RichTextTagStack<Int32Enum>.PreviousItem
	|-TMP_RichTextTagStack<Color32>.PreviousItem
	|
	|-RVA: 0x20FB10 Offset: 0x20EF10 VA: 0x18020FB10
	|-TMP_RichTextTagStack<object>.PreviousItem
	|
	|-RVA: 0x20FC20 Offset: 0x20F020 VA: 0x18020FC20
	|-TMP_RichTextTagStack<float>.PreviousItem
	|
	|-RVA: 0x20FB80 Offset: 0x20EF80 VA: 0x18020FB80
	|-TMP_RichTextTagStack<MaterialReference>.PreviousItem
	*/

}

public class TMP_ScrollbarEventHandler : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, ISelectHandler, IDeselectHandler // TypeDefIndex: 6818
{	// Fields
	public bool isSelected; // 0x18

	// Methods

	// RVA: 0xD9E660 Offset: 0xD9CC60 VA: 0x180D9E660 Slot: 4
	public void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0xD9E6B0 Offset: 0xD9CCB0 VA: 0x180D9E6B0 Slot: 5
	public void OnSelect(BaseEventData eventData) { }

	// RVA: 0xD9E600 Offset: 0xD9CC00 VA: 0x180D9E600 Slot: 6
	public void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class TMP_SelectionCaret : MaskableGraphic // TypeDefIndex: 6819
{	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 58
	public override void Cull(Rect clipRect, bool validRect) { }

	// RVA: 0xD9E710 Offset: 0xD9CD10 VA: 0x180D9E710
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

	// RVA: 0xD9F020 Offset: 0xD9D620 VA: 0x180D9F020
	public static string get_version() { }

	// RVA: 0xD9ED00 Offset: 0xD9D300 VA: 0x180D9ED00
	public static bool get_enableWordWrapping() { }

	// RVA: 0xD9ECA0 Offset: 0xD9D2A0 VA: 0x180D9ECA0
	public static bool get_enableKerning() { }

	// RVA: 0xD9EC80 Offset: 0xD9D280 VA: 0x180D9EC80
	public static bool get_enableExtraPadding() { }

	// RVA: 0xD9ECE0 Offset: 0xD9D2E0 VA: 0x180D9ECE0
	public static bool get_enableTintAllSprites() { }

	// RVA: 0xD9ECC0 Offset: 0xD9D2C0 VA: 0x180D9ECC0
	public static bool get_enableRaycastTarget() { }

	// RVA: 0xD9ED70 Offset: 0xD9D370 VA: 0x180D9ED70
	public static bool get_getFontFeaturesAtRuntime() { }

	// RVA: 0xD9F000 Offset: 0xD9D600 VA: 0x180D9F000
	public static int get_missingGlyphCharacter() { }

	// RVA: 0xD9F0A0 Offset: 0xD9D6A0 VA: 0x180D9F0A0
	public static void set_missingGlyphCharacter(int value) { }

	// RVA: 0xD9F050 Offset: 0xD9D650 VA: 0x180D9F050
	public static bool get_warningsDisabled() { }

	// RVA: 0xD9EB80 Offset: 0xD9D180 VA: 0x180D9EB80
	public static TMP_FontAsset get_defaultFontAsset() { }

	// RVA: 0xD9EB60 Offset: 0xD9D160 VA: 0x180D9EB60
	public static string get_defaultFontAssetPath() { }

	// RVA: 0xD9EBA0 Offset: 0xD9D1A0 VA: 0x180D9EBA0
	public static float get_defaultFontSize() { }

	// RVA: 0xD9EBE0 Offset: 0xD9D1E0 VA: 0x180D9EBE0
	public static float get_defaultTextAutoSizingMinRatio() { }

	// RVA: 0xD9EBC0 Offset: 0xD9D1C0 VA: 0x180D9EBC0
	public static float get_defaultTextAutoSizingMaxRatio() { }

	// RVA: 0xD9EC00 Offset: 0xD9D200 VA: 0x180D9EC00
	public static Vector2 get_defaultTextMeshProTextContainerSize() { }

	// RVA: 0xD9EC30 Offset: 0xD9D230 VA: 0x180D9EC30
	public static Vector2 get_defaultTextMeshProUITextContainerSize() { }

	// RVA: 0xD9EB20 Offset: 0xD9D120 VA: 0x180D9EB20
	public static bool get_autoSizeTextContainer() { }

	// RVA: 0xD9ED20 Offset: 0xD9D320 VA: 0x180D9ED20
	public static List<TMP_FontAsset> get_fallbackFontAssets() { }

	// RVA: 0xD9EFE0 Offset: 0xD9D5E0 VA: 0x180D9EFE0
	public static bool get_matchMaterialPreset() { }

	// RVA: 0xD9EB40 Offset: 0xD9D140 VA: 0x180D9EB40
	public static string get_defaultColorGradientPresetsPath() { }

	// RVA: 0xD9EC60 Offset: 0xD9D260 VA: 0x180D9EC60
	public static bool get_enableEmojiSupport() { }

	// RVA: 0xD9F070 Offset: 0xD9D670 VA: 0x180D9F070
	public static void set_enableEmojiSupport(bool value) { }

	// RVA: 0xD9EE40 Offset: 0xD9D440 VA: 0x180D9EE40
	public static TextAsset get_leadingCharacters() { }

	// RVA: 0xD9ED40 Offset: 0xD9D340 VA: 0x180D9ED40
	public static TextAsset get_followingCharacters() { }

	// RVA: 0xD9EE60 Offset: 0xD9D460 VA: 0x180D9EE60
	public static TMP_Settings.LineBreakingTable get_linebreakingRules() { }

	// RVA: 0xD9ED90 Offset: 0xD9D390 VA: 0x180D9ED90
	public static TMP_Settings get_instance() { }

	// RVA: 0xD9E8F0 Offset: 0xD9CEF0 VA: 0x180D9E8F0
	public static TMP_Settings LoadDefaultSettings() { }

	// RVA: 0xD9E880 Offset: 0xD9CE80 VA: 0x180D9E880
	public static TMP_Settings GetSettings() { }

	// RVA: 0xD9E800 Offset: 0xD9CE00 VA: 0x180D9E800
	public static TMP_FontAsset GetFontAsset() { }

	// RVA: 0xD9E9D0 Offset: 0xD9CFD0 VA: 0x180D9E9D0
	public static void LoadLinebreakingRules() { }

	// RVA: 0xD9E720 Offset: 0xD9CD20 VA: 0x180D9E720
	private static Dictionary<int, char> GetCharacters(TextAsset file) { }

	// RVA: 0xD9EB10 Offset: 0xD9D110 VA: 0x180D9EB10
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

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_fontAsset(TMP_FontAsset value) { }

	// RVA: 0xDA1790 Offset: 0xD9FD90 VA: 0x180DA1790
	public Material get_material() { }

	// RVA: 0xDA1B40 Offset: 0xDA0140 VA: 0x180DA1B40
	public void set_material(Material value) { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public Material get_sharedMaterial() { }

	// RVA: 0xDA15F0 Offset: 0xD9FBF0 VA: 0x180DA15F0
	public void set_sharedMaterial(Material value) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public Material get_fallbackMaterial() { }

	// RVA: 0xDA19C0 Offset: 0xD9FFC0 VA: 0x180DA19C0
	public void set_fallbackMaterial(Material value) { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public Material get_fallbackSourceMaterial() { }

	// RVA: 0x6AD6C0 Offset: 0x6ABCC0 VA: 0x1806AD6C0
	public void set_fallbackSourceMaterial(Material value) { }

	// RVA: 0x805600 Offset: 0x803C00 VA: 0x180805600
	public bool get_isDefaultMaterial() { }

	// RVA: 0x810000 Offset: 0x80E600 VA: 0x180810000
	public void set_isDefaultMaterial(bool value) { }

	// RVA: 0x8055F0 Offset: 0x803BF0 VA: 0x1808055F0
	public float get_padding() { }

	// RVA: 0x88ABA0 Offset: 0x8891A0 VA: 0x18088ABA0
	public void set_padding(float value) { }

	// RVA: 0xDA1920 Offset: 0xD9FF20 VA: 0x180DA1920
	public Renderer get_renderer() { }

	// RVA: 0xDA17A0 Offset: 0xD9FDA0 VA: 0x180DA17A0
	public MeshFilter get_meshFilter() { }

	// RVA: 0xDA1840 Offset: 0xD9FE40 VA: 0x180DA1840
	public Mesh get_mesh() { }

	// RVA: 0x4CF880 Offset: 0x4CDE80 VA: 0x1804CF880
	public void set_mesh(Mesh value) { }

	// RVA: 0xDA12E0 Offset: 0xD9F8E0 VA: 0x180DA12E0
	private void OnEnable() { }

	// RVA: 0xDA1210 Offset: 0xD9F810 VA: 0x180DA1210
	private void OnDisable() { }

	// RVA: 0xDA10F0 Offset: 0xD9F6F0 VA: 0x180DA10F0
	private void OnDestroy() { }

	// RVA: 0xDA08D0 Offset: 0xD9EED0 VA: 0x180DA08D0
	public static TMP_SubMesh AddSubTextObject(TextMeshPro textComponent, MaterialReference materialReference) { }

	// RVA: 0xDA0D60 Offset: 0xD9F360 VA: 0x180DA0D60
	public void DestroySelf() { }

	// RVA: 0xDA0DD0 Offset: 0xD9F3D0 VA: 0x180DA0DD0
	private Material GetMaterial(Material mat) { }

	// RVA: 0xDA0CB0 Offset: 0xD9F2B0 VA: 0x180DA0CB0
	private Material CreateMaterialInstance(Material source) { }

	// RVA: 0xDA1040 Offset: 0xD9F640 VA: 0x180DA1040
	private Material GetSharedMaterial() { }

	// RVA: 0xDA15F0 Offset: 0xD9FBF0 VA: 0x180DA15F0
	private void SetSharedMaterial(Material mat) { }

	// RVA: 0xDA0FB0 Offset: 0xD9F5B0 VA: 0x180DA0FB0
	public float GetPaddingForMaterial() { }

	// RVA: 0xDA1700 Offset: 0xD9FD00 VA: 0x180DA1700
	public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold) { }

	// RVA: 0xDA1630 Offset: 0xD9FC30 VA: 0x180DA1630
	public void SetVerticesDirty() { }

	// RVA: 0xDA14E0 Offset: 0xD9FAE0 VA: 0x180DA14E0
	public void SetMaterialDirty() { }

	// RVA: 0xDA14E0 Offset: 0xD9FAE0 VA: 0x180DA14E0
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

	// RVA: 0xDA03A0 Offset: 0xD9E9A0 VA: 0x180DA03A0
	public TMP_FontAsset get_fontAsset() { }

	// RVA: 0xDA0780 Offset: 0xD9ED80 VA: 0x180DA0780
	public void set_fontAsset(TMP_FontAsset value) { }

	// RVA: 0xDA03C0 Offset: 0xD9E9C0 VA: 0x180DA03C0 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0xDA0500 Offset: 0xD9EB00 VA: 0x180DA0500 Slot: 32
	public override Material get_material() { }

	// RVA: 0xDA07A0 Offset: 0xD9EDA0 VA: 0x180DA07A0 Slot: 33
	public override void set_material(Material value) { }

	// RVA: 0xD9F730 Offset: 0xD9DD30 VA: 0x180D9F730
	public Material get_sharedMaterial() { }

	// RVA: 0xD9FF70 Offset: 0xD9E570 VA: 0x180D9FF70
	public void set_sharedMaterial(Material value) { }

	// RVA: 0x4EF3A0 Offset: 0x4ED9A0 VA: 0x1804EF3A0
	public Material get_fallbackMaterial() { }

	// RVA: 0xDA05E0 Offset: 0xD9EBE0 VA: 0x180DA05E0
	public void set_fallbackMaterial(Material value) { }

	// RVA: 0x872250 Offset: 0x870850 VA: 0x180872250
	public Material get_fallbackSourceMaterial() { }

	// RVA: 0x8722D0 Offset: 0x8708D0 VA: 0x1808722D0
	public void set_fallbackSourceMaterial(Material value) { }

	// RVA: 0xDA0490 Offset: 0xD9EA90 VA: 0x180DA0490 Slot: 34
	public override Material get_materialForRendering() { }

	// RVA: 0xDA03B0 Offset: 0xD9E9B0 VA: 0x180DA03B0
	public bool get_isDefaultMaterial() { }

	// RVA: 0xDA0790 Offset: 0xD9ED90 VA: 0x180DA0790
	public void set_isDefaultMaterial(bool value) { }

	// RVA: 0xDA05D0 Offset: 0xD9EBD0 VA: 0x180DA05D0
	public float get_padding() { }

	// RVA: 0xDA08C0 Offset: 0xD9EEC0 VA: 0x180DA08C0
	public void set_padding(float value) { }

	// RVA: 0xDA0300 Offset: 0xD9E900 VA: 0x180DA0300
	public CanvasRenderer get_canvasRenderer() { }

	// RVA: 0xDA0510 Offset: 0xD9EB10 VA: 0x180DA0510
	public Mesh get_mesh() { }

	// RVA: 0xA2AEE0 Offset: 0xA294E0 VA: 0x180A2AEE0
	public void set_mesh(Mesh value) { }

	// RVA: 0xD9F0D0 Offset: 0xD9D6D0 VA: 0x180D9F0D0
	public static TMP_SubMeshUI AddSubTextObject(TextMeshProUGUI textComponent, MaterialReference materialReference) { }

	// RVA: 0xD9FD70 Offset: 0xD9E370 VA: 0x180D9FD70 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0xD9FC20 Offset: 0xD9E220 VA: 0x180D9FC20 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0xD9FA80 Offset: 0xD9E080 VA: 0x180D9FA80 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0xD9FDC0 Offset: 0xD9E3C0 VA: 0x180D9FDC0 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0xD9F740 Offset: 0xD9DD40 VA: 0x180D9F740 Slot: 57
	public override Material GetModifiedMaterial(Material baseMaterial) { }

	// RVA: 0xD9F8A0 Offset: 0xD9DEA0 VA: 0x180D9F8A0
	public float GetPaddingForMaterial() { }

	// RVA: 0xD9F940 Offset: 0xD9DF40 VA: 0x180D9F940
	public float GetPaddingForMaterial(Material mat) { }

	// RVA: 0xDA0270 Offset: 0xD9E870 VA: 0x180DA0270
	public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 26
	public override void SetAllDirty() { }

	// RVA: 0xD9FFE0 Offset: 0xD9E5E0 VA: 0x180D9FFE0 Slot: 28
	public override void SetVerticesDirty() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 27
	public override void SetLayoutDirty() { }

	// RVA: 0xD9FEB0 Offset: 0xD9E4B0 VA: 0x180D9FEB0 Slot: 29
	public override void SetMaterialDirty() { }

	// RVA: 0xD9FEF0 Offset: 0xD9E4F0 VA: 0x180D9FEF0
	public void SetPivotDirty() { }

	// RVA: 0xD9F530 Offset: 0xD9DB30 VA: 0x180D9F530 Slot: 58
	public override void Cull(Rect clipRect, bool validRect) { }

	// RVA: 0xDA00C0 Offset: 0xD9E6C0 VA: 0x180DA00C0 Slot: 41
	protected override void UpdateGeometry() { }

	// RVA: 0xD9FE20 Offset: 0xD9E420 VA: 0x180D9FE20 Slot: 37
	public override void Rebuild(CanvasUpdate update) { }

	// RVA: 0xD9FE90 Offset: 0xD9E490 VA: 0x180D9FE90
	public void RefreshMaterial() { }

	// RVA: 0xDA0110 Offset: 0xD9E710 VA: 0x180DA0110 Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0xD9FE60 Offset: 0xD9E460 VA: 0x180D9FE60 Slot: 61
	public override void RecalculateClipping() { }

	// RVA: 0xD9FE70 Offset: 0xD9E470 VA: 0x180D9FE70 Slot: 62
	public override void RecalculateMasking() { }

	// RVA: 0xD9F730 Offset: 0xD9DD30 VA: 0x180D9F730
	private Material GetMaterial() { }

	// RVA: 0xD9F570 Offset: 0xD9DB70 VA: 0x180D9F570
	private Material GetMaterial(Material mat) { }

	// RVA: 0xD9F480 Offset: 0xD9DA80 VA: 0x180D9F480
	private Material CreateMaterialInstance(Material source) { }

	// RVA: 0xD9F9D0 Offset: 0xD9DFD0 VA: 0x180D9F9D0
	private Material GetSharedMaterial() { }

	// RVA: 0xD9FF70 Offset: 0xD9E570 VA: 0x180D9FF70
	private void SetSharedMaterial(Material mat) { }

	// RVA: 0xD9E710 Offset: 0xD9CD10 VA: 0x180D9E710
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

	// RVA: 0xDA03A0 Offset: 0xD9E9A0 VA: 0x180DA03A0
	public string get_text() { }

	// RVA: 0xDB5A70 Offset: 0xDB4070 VA: 0x180DB5A70
	public void set_text(string value) { }

	// RVA: 0xDB3F30 Offset: 0xDB2530 VA: 0x180DB3F30
	public bool get_isRightToLeftText() { }

	// RVA: 0xDB52A0 Offset: 0xDB38A0 VA: 0x180DB52A0
	public void set_isRightToLeftText(bool value) { }

	// RVA: 0xD9F730 Offset: 0xD9DD30 VA: 0x180D9F730
	public TMP_FontAsset get_font() { }

	// RVA: 0xDB5010 Offset: 0xDB3610 VA: 0x180DB5010
	public void set_font(TMP_FontAsset value) { }

	// RVA: 0xC73E20 Offset: 0xC72420 VA: 0x180C73E20 Slot: 63
	public virtual Material get_fontSharedMaterial() { }

	// RVA: 0xDB4D70 Offset: 0xDB3370 VA: 0x180DB4D70 Slot: 64
	public virtual void set_fontSharedMaterial(Material value) { }

	// RVA: 0xDB3E60 Offset: 0xDB2460 VA: 0x180DB3E60 Slot: 65
	public virtual Material[] get_fontSharedMaterials() { }

	// RVA: 0xDB4D10 Offset: 0xDB3310 VA: 0x180DB4D10 Slot: 66
	public virtual void set_fontSharedMaterials(Material[] value) { }

	// RVA: 0xDB3E10 Offset: 0xDB2410 VA: 0x180DB3E10
	public Material get_fontMaterial() { }

	// RVA: 0xDB4BF0 Offset: 0xDB31F0 VA: 0x180DB4BF0
	public void set_fontMaterial(Material value) { }

	// RVA: 0xDB3E30 Offset: 0xDB2430 VA: 0x180DB3E30 Slot: 67
	public virtual Material[] get_fontMaterials() { }

	// RVA: 0xDB4D10 Offset: 0xDB3310 VA: 0x180DB4D10 Slot: 68
	public virtual void set_fontMaterials(Material[] value) { }

	// RVA: 0xDB3C70 Offset: 0xDB2270 VA: 0x180DB3C70 Slot: 22
	public override Color get_color() { }

	// RVA: 0xDB4900 Offset: 0xDB2F00 VA: 0x180DB4900 Slot: 23
	public override void set_color(Color value) { }

	// RVA: 0xDB3B20 Offset: 0xDB2120 VA: 0x180DB3B20
	public float get_alpha() { }

	// RVA: 0xDB4770 Offset: 0xDB2D70 VA: 0x180DB4770
	public void set_alpha(float value) { }

	// RVA: 0xDB3CB0 Offset: 0xDB22B0 VA: 0x180DB3CB0
	public bool get_enableVertexGradient() { }

	// RVA: 0xDB4A60 Offset: 0xDB3060 VA: 0x180DB4A60
	public void set_enableVertexGradient(bool value) { }

	// RVA: 0xDB3C40 Offset: 0xDB2240 VA: 0x180DB3C40
	public VertexGradient get_colorGradient() { }

	// RVA: 0xDB48B0 Offset: 0xDB2EB0 VA: 0x180DB48B0
	public void set_colorGradient(VertexGradient value) { }

	// RVA: 0xDB3C30 Offset: 0xDB2230 VA: 0x180DB3C30
	public TMP_ColorGradient get_colorGradientPreset() { }

	// RVA: 0xDB4870 Offset: 0xDB2E70 VA: 0x180DB4870
	public void set_colorGradientPreset(TMP_ColorGradient value) { }

	// RVA: 0xDB4280 Offset: 0xDB2880 VA: 0x180DB4280
	public bool get_overrideColorTags() { }

	// RVA: 0xDB5930 Offset: 0xDB3F30 VA: 0x180DB5930
	public void set_overrideColorTags(bool value) { }

	// RVA: 0xDB3CE0 Offset: 0xDB22E0 VA: 0x180DB3CE0
	public Color32 get_faceColor() { }

	// RVA: 0xDB4B40 Offset: 0xDB3140 VA: 0x180DB4B40
	public void set_faceColor(Color32 value) { }

	// RVA: 0xDB40A0 Offset: 0xDB26A0 VA: 0x180DB40A0
	public Color32 get_outlineColor() { }

	// RVA: 0xDB5800 Offset: 0xDB3E00 VA: 0x180DB5800
	public void set_outlineColor(Color32 value) { }

	// RVA: 0xDB4190 Offset: 0xDB2790 VA: 0x180DB4190
	public float get_outlineWidth() { }

	// RVA: 0xDB5870 Offset: 0xDB3E70 VA: 0x180DB5870
	public void set_outlineWidth(float value) { }

	// RVA: 0xDB3E90 Offset: 0xDB2490 VA: 0x180DB3E90
	public float get_fontSize() { }

	// RVA: 0xDB4EE0 Offset: 0xDB34E0 VA: 0x180DB4EE0
	public void set_fontSize(float value) { }

	// RVA: 0xDB3E50 Offset: 0xDB2450 VA: 0x180DB3E50
	public float get_fontScale() { }

	// RVA: 0xDB3EB0 Offset: 0xDB24B0 VA: 0x180DB3EB0
	public FontWeight get_fontWeight() { }

	// RVA: 0xDB4FB0 Offset: 0xDB35B0 VA: 0x180DB4FB0
	public void set_fontWeight(FontWeight value) { }

	// RVA: 0xDB42B0 Offset: 0xDB28B0 VA: 0x180DB42B0
	public float get_pixelsPerUnit() { }

	// RVA: 0xDB3C80 Offset: 0xDB2280 VA: 0x180DB3C80
	public bool get_enableAutoSizing() { }

	// RVA: 0xDB4970 Offset: 0xDB2F70 VA: 0x180DB4970
	public void set_enableAutoSizing(bool value) { }

	// RVA: 0xDB3E80 Offset: 0xDB2480 VA: 0x180DB3E80
	public float get_fontSizeMin() { }

	// RVA: 0xDB4E90 Offset: 0xDB3490 VA: 0x180DB4E90
	public void set_fontSizeMin(float value) { }

	// RVA: 0x8F96B0 Offset: 0x8F7CB0 VA: 0x1808F96B0
	public float get_fontSizeMax() { }

	// RVA: 0xDB4E40 Offset: 0xDB3440 VA: 0x180DB4E40
	public void set_fontSizeMax(float value) { }

	// RVA: 0xDB3EA0 Offset: 0xDB24A0 VA: 0x180DB3EA0
	public FontStyles get_fontStyle() { }

	// RVA: 0xDB4F50 Offset: 0xDB3550 VA: 0x180DB4F50
	public void set_fontStyle(FontStyles value) { }

	// RVA: 0xDB3F60 Offset: 0xDB2560 VA: 0x180DB3F60
	public bool get_isUsingBold() { }

	// RVA: 0xDB3B10 Offset: 0xDB2110 VA: 0x180DB3B10
	public TextAlignmentOptions get_alignment() { }

	// RVA: 0xDB4740 Offset: 0xDB2D40 VA: 0x180DB4740
	public void set_alignment(TextAlignmentOptions value) { }

	// RVA: 0xDB3C10 Offset: 0xDB2210 VA: 0x180DB3C10
	public float get_characterSpacing() { }

	// RVA: 0xDB47B0 Offset: 0xDB2DB0 VA: 0x180DB47B0
	public void set_characterSpacing(float value) { }

	// RVA: 0xDB4720 Offset: 0xDB2D20 VA: 0x180DB4720
	public float get_wordSpacing() { }

	// RVA: 0xDB5B90 Offset: 0xDB4190 VA: 0x180DB5B90
	public void set_wordSpacing(float value) { }

	// RVA: 0xDB4050 Offset: 0xDB2650 VA: 0x180DB4050
	public float get_lineSpacing() { }

	// RVA: 0xDB53E0 Offset: 0xDB39E0 VA: 0x180DB53E0
	public void set_lineSpacing(float value) { }

	// RVA: 0xDB4040 Offset: 0xDB2640 VA: 0x180DB4040
	public float get_lineSpacingAdjustment() { }

	// RVA: 0xDB5380 Offset: 0xDB3980 VA: 0x180DB5380
	public void set_lineSpacingAdjustment(float value) { }

	// RVA: 0xDB42A0 Offset: 0xDB28A0 VA: 0x180DB42A0
	public float get_paragraphSpacing() { }

	// RVA: 0xDB5990 Offset: 0xDB3F90 VA: 0x180DB5990
	public void set_paragraphSpacing(float value) { }

	// RVA: 0xDB3C20 Offset: 0xDB2220 VA: 0x180DB3C20
	public float get_characterWidthAdjustment() { }

	// RVA: 0xDB4810 Offset: 0xDB2E10 VA: 0x180DB4810
	public void set_characterWidthAdjustment(float value) { }

	// RVA: 0xDB3CC0 Offset: 0xDB22C0 VA: 0x180DB3CC0
	public bool get_enableWordWrapping() { }

	// RVA: 0xDB4A90 Offset: 0xDB3090 VA: 0x180DB4A90
	public void set_enableWordWrapping(bool value) { }

	// RVA: 0xDB4730 Offset: 0xDB2D30 VA: 0x180DB4730
	public float get_wordWrappingRatios() { }

	// RVA: 0xDB5BF0 Offset: 0xDB41F0 VA: 0x180DB5BF0
	public void set_wordWrappingRatios(float value) { }

	// RVA: 0xDB4270 Offset: 0xDB2870 VA: 0x180DB4270
	public TextOverflowModes get_overflowMode() { }

	// RVA: 0xDB58D0 Offset: 0xDB3ED0 VA: 0x180DB58D0
	public void set_overflowMode(TextOverflowModes value) { }

	// RVA: 0xDB3F40 Offset: 0xDB2540 VA: 0x180DB3F40
	public bool get_isTextOverflowing() { }

	// RVA: 0xDB3DD0 Offset: 0xDB23D0 VA: 0x180DB3DD0
	public int get_firstOverflowCharacterIndex() { }

	// RVA: 0x9A0110 Offset: 0x99E710 VA: 0x1809A0110
	public TMP_Text get_linkedTextComponent() { }

	// RVA: 0xDB5440 Offset: 0xDB3A40 VA: 0x180DB5440
	public void set_linkedTextComponent(TMP_Text value) { }

	// RVA: 0xDB3F00 Offset: 0xDB2500 VA: 0x180DB3F00
	public bool get_isLinkedTextComponent() { }

	// RVA: 0xDB51C0 Offset: 0xDB37C0 VA: 0x180DB51C0
	public void set_isLinkedTextComponent(bool value) { }

	// RVA: 0xDB3F50 Offset: 0xDB2550 VA: 0x180DB3F50
	public bool get_isTextTruncated() { }

	// RVA: 0xDB3CA0 Offset: 0xDB22A0 VA: 0x180DB3CA0
	public bool get_enableKerning() { }

	// RVA: 0xDB4A00 Offset: 0xDB3000 VA: 0x180DB4A00
	public void set_enableKerning(bool value) { }

	// RVA: 0xDB3CD0 Offset: 0xDB22D0 VA: 0x180DB3CD0
	public bool get_extraPadding() { }

	// RVA: 0xDB4AF0 Offset: 0xDB30F0 VA: 0x180DB4AF0
	public void set_extraPadding(bool value) { }

	// RVA: 0xDB45E0 Offset: 0xDB2BE0 VA: 0x180DB45E0
	public bool get_richText() { }

	// RVA: 0xDB5A10 Offset: 0xDB4010 VA: 0x180DB5A10
	public void set_richText(bool value) { }

	// RVA: 0xDB3F20 Offset: 0xDB2520 VA: 0x180DB3F20
	public bool get_isOverlay() { }

	// RVA: 0xDB5250 Offset: 0xDB3850 VA: 0x180DB5250
	public void set_isOverlay(bool value) { }

	// RVA: 0xDB3F10 Offset: 0xDB2510 VA: 0x180DB3F10
	public bool get_isOrthographic() { }

	// RVA: 0xDB5220 Offset: 0xDB3820 VA: 0x180DB5220
	public void set_isOrthographic(bool value) { }

	// RVA: 0xDB3C90 Offset: 0xDB2290 VA: 0x180DB3C90
	public bool get_enableCulling() { }

	// RVA: 0xDB49C0 Offset: 0xDB2FC0 VA: 0x180DB49C0
	public void set_enableCulling(bool value) { }

	// RVA: 0xDB3EE0 Offset: 0xDB24E0 VA: 0x180DB3EE0
	public bool get_ignoreRectMaskCulling() { }

	// RVA: 0xDB5180 Offset: 0xDB3780 VA: 0x180DB5180
	public void set_ignoreRectMaskCulling(bool value) { }

	// RVA: 0xDB3EF0 Offset: 0xDB24F0 VA: 0x180DB3EF0
	public bool get_ignoreVisibility() { }

	// RVA: 0xDB51A0 Offset: 0xDB37A0 VA: 0x180DB51A0
	public void set_ignoreVisibility(bool value) { }

	// RVA: 0x8384B0 Offset: 0x836AB0 VA: 0x1808384B0
	public TextureMappingOptions get_horizontalMapping() { }

	// RVA: 0xDB5150 Offset: 0xDB3750 VA: 0x180DB5150
	public void set_horizontalMapping(TextureMappingOptions value) { }

	// RVA: 0x8384A0 Offset: 0x836AA0 VA: 0x1808384A0
	public TextureMappingOptions get_verticalMapping() { }

	// RVA: 0xDB5B60 Offset: 0xDB4160 VA: 0x180DB5B60
	public void set_verticalMapping(TextureMappingOptions value) { }

	// RVA: 0xDB4060 Offset: 0xDB2660 VA: 0x180DB4060
	public float get_mappingUvLineOffset() { }

	// RVA: 0xDB5680 Offset: 0xDB3C80 VA: 0x180DB5680
	public void set_mappingUvLineOffset(float value) { }

	// RVA: 0xAC5930 Offset: 0xAC3F30 VA: 0x180AC5930
	public TextRenderFlags get_renderMode() { }

	// RVA: 0xDB59F0 Offset: 0xDB3FF0 VA: 0x180DB59F0
	public void set_renderMode(TextRenderFlags value) { }

	// RVA: 0xDB3EC0 Offset: 0xDB24C0 VA: 0x180DB3EC0
	public VertexSortingOrder get_geometrySortingOrder() { }

	// RVA: 0xDB5100 Offset: 0xDB3700 VA: 0x180DB5100
	public void set_geometrySortingOrder(VertexSortingOrder value) { }

	// RVA: 0xDB4710 Offset: 0xDB2D10 VA: 0x180DB4710
	public bool get_vertexBufferAutoSizeReduction() { }

	// RVA: 0xDB5B40 Offset: 0xDB4140 VA: 0x180DB5B40
	public void set_vertexBufferAutoSizeReduction(bool value) { }

	// RVA: 0xDB3DE0 Offset: 0xDB23E0 VA: 0x180DB3DE0
	public int get_firstVisibleCharacter() { }

	// RVA: 0xDB4BC0 Offset: 0xDB31C0 VA: 0x180DB4BC0
	public void set_firstVisibleCharacter(int value) { }

	// RVA: 0xDB4080 Offset: 0xDB2680 VA: 0x180DB4080
	public int get_maxVisibleCharacters() { }

	// RVA: 0xDB5770 Offset: 0xDB3D70 VA: 0x180DB5770
	public void set_maxVisibleCharacters(int value) { }

	// RVA: 0xA4B190 Offset: 0xA49790 VA: 0x180A4B190
	public int get_maxVisibleWords() { }

	// RVA: 0xDB57D0 Offset: 0xDB3DD0 VA: 0x180DB57D0
	public void set_maxVisibleWords(int value) { }

	// RVA: 0xDB4090 Offset: 0xDB2690 VA: 0x180DB4090
	public int get_maxVisibleLines() { }

	// RVA: 0xDB57A0 Offset: 0xDB3DA0 VA: 0x180DB57A0
	public void set_maxVisibleLines(int value) { }

	// RVA: 0xDB4700 Offset: 0xDB2D00 VA: 0x180DB4700
	public bool get_useMaxVisibleDescender() { }

	// RVA: 0xDB5B10 Offset: 0xDB4110 VA: 0x180DB5B10
	public void set_useMaxVisibleDescender(bool value) { }

	// RVA: 0xDB4290 Offset: 0xDB2890 VA: 0x180DB4290
	public int get_pageToDisplay() { }

	// RVA: 0xDB5960 Offset: 0xDB3F60 VA: 0x180DB5960
	public void set_pageToDisplay(int value) { }

	// RVA: 0xDB4070 Offset: 0xDB2670 VA: 0x180DB4070 Slot: 69
	public virtual Vector4 get_margin() { }

	// RVA: 0xDB56B0 Offset: 0xDB3CB0 VA: 0x180DB56B0 Slot: 70
	public virtual void set_margin(Vector4 value) { }

	// RVA: 0xDB4650 Offset: 0xDB2C50 VA: 0x180DB4650
	public TMP_TextInfo get_textInfo() { }

	// RVA: 0xDB3ED0 Offset: 0xDB24D0 VA: 0x180DB3ED0
	public bool get_havePropertiesChanged() { }

	// RVA: 0xDB5120 Offset: 0xDB3720 VA: 0x180DB5120
	public void set_havePropertiesChanged(bool value) { }

	// RVA: 0xDB3F70 Offset: 0xDB2570 VA: 0x180DB3F70
	public bool get_isUsingLegacyAnimationComponent() { }

	// RVA: 0xDB5300 Offset: 0xDB3900 VA: 0x180DB5300
	public void set_isUsingLegacyAnimationComponent(bool value) { }

	// RVA: 0xDB4660 Offset: 0xDB2C60 VA: 0x180DB4660
	public Transform get_transform() { }

	// RVA: 0xDB4540 Offset: 0xDB2B40 VA: 0x180DB4540
	public RectTransform get_rectTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDB3B30 Offset: 0xDB2130 VA: 0x180DB3B30 Slot: 71
	public virtual bool get_autoSizeTextContainer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDB47A0 Offset: 0xDB2DA0 VA: 0x180DB47A0 Slot: 72
	public virtual void set_autoSizeTextContainer(bool value) { }

	// RVA: 0x79DA40 Offset: 0x79C040 VA: 0x18079DA40 Slot: 73
	public virtual Mesh get_mesh() { }

	// RVA: 0xDB3F80 Offset: 0xDB2580 VA: 0x180DB3F80
	public bool get_isVolumetricText() { }

	// RVA: 0xDB5310 Offset: 0xDB3910 VA: 0x180DB5310
	public void set_isVolumetricText(bool value) { }

	// RVA: 0xDB3B40 Offset: 0xDB2140 VA: 0x180DB3B40
	public Bounds get_bounds() { }

	// RVA: 0xDB45F0 Offset: 0xDB2BF0 VA: 0x180DB45F0
	public Bounds get_textBounds() { }

	// RVA: 0xDB3DF0 Offset: 0xDB23F0 VA: 0x180DB3DF0 Slot: 74
	public float get_flexibleHeight() { }

	// RVA: 0xDB3E00 Offset: 0xDB2400 VA: 0x180DB3E00 Slot: 75
	public float get_flexibleWidth() { }

	// RVA: 0x730030 Offset: 0x72E630 VA: 0x180730030 Slot: 76
	public float get_minWidth() { }

	// RVA: 0x730350 Offset: 0x72E950 VA: 0x180730350 Slot: 77
	public float get_minHeight() { }

	// RVA: 0x730180 Offset: 0x72E780 VA: 0x180730180
	public float get_maxWidth() { }

	// RVA: 0x730490 Offset: 0x72EA90 VA: 0x180730490
	public float get_maxHeight() { }

	// RVA: 0xDB3F90 Offset: 0xDB2590 VA: 0x180DB3F90
	protected LayoutElement get_layoutElement() { }

	// RVA: 0xDB4500 Offset: 0xDB2B00 VA: 0x180DB4500 Slot: 78
	public virtual float get_preferredWidth() { }

	// RVA: 0xDB44C0 Offset: 0xDB2AC0 VA: 0x180DB44C0 Slot: 79
	public virtual float get_preferredHeight() { }

	// RVA: 0xDA91F0 Offset: 0xDA77F0 VA: 0x180DA91F0 Slot: 80
	public virtual float get_renderedWidth() { }

	// RVA: 0xDA9060 Offset: 0xDA7660 VA: 0x180DA9060 Slot: 81
	public virtual float get_renderedHeight() { }

	// RVA: 0xDB4030 Offset: 0xDB2630 VA: 0x180DB4030 Slot: 82
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

	// RVA: 0xDA43D0 Offset: 0xDA29D0 VA: 0x180DA43D0 Slot: 90
	protected virtual Material CreateMaterialInstance(Material source) { }

	// RVA: 0xDAD660 Offset: 0xDABC60 VA: 0x180DAD660
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

	// RVA: 0xDAD610 Offset: 0xDABC10 VA: 0x180DAD610
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

	// RVA: 0xDA44F0 Offset: 0xDA2AF0 VA: 0x180DA44F0 Slot: 47
	public override void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0xDA4480 Offset: 0xDA2A80 VA: 0x180DA4480 Slot: 49
	public override void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 106
	protected virtual void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 107
	protected virtual void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0xDABA00 Offset: 0xDAA000 VA: 0x180DABA00
	protected void ParseInputText() { }

	// RVA: 0xDADAA0 Offset: 0xDAC0A0 VA: 0x180DADAA0
	protected void StringToCharArray(string sourceText, ref TMP_Text.UnicodeChar[] charBuffer) { }

	// RVA: 0xDAD710 Offset: 0xDABD10 VA: 0x180DAD710
	protected void StringBuilderToIntArray(StringBuilder sourceText, ref TMP_Text.UnicodeChar[] charBuffer) { }

	// RVA: 0xDAB550 Offset: 0xDA9B50 VA: 0x180DAB550
	private bool IsTagName(ref string text, string tag, int index) { }

	// RVA: 0xDAB350 Offset: 0xDA9950 VA: 0x180DAB350
	private bool IsTagName(ref char[] text, string tag, int index) { }

	// RVA: 0xDAB450 Offset: 0xDA9A50 VA: 0x180DAB450
	private bool IsTagName(ref int[] text, string tag, int index) { }

	// RVA: 0xDAB640 Offset: 0xDA9C40 VA: 0x180DAB640
	private bool IsTagName(ref StringBuilder text, string tag, int index) { }

	// RVA: 0xDA95C0 Offset: 0xDA7BC0 VA: 0x180DA95C0
	private int GetTagHashCode(ref string text, int index, out int closeIndex) { }

	// RVA: 0xDA9670 Offset: 0xDA7C70 VA: 0x180DA9670
	private int GetTagHashCode(ref char[] text, int index, out int closeIndex) { }

	// RVA: 0xDA96E0 Offset: 0xDA7CE0 VA: 0x180DA96E0
	private int GetTagHashCode(ref int[] text, int index, out int closeIndex) { }

	// RVA: 0xDA94F0 Offset: 0xDA7AF0 VA: 0x180DA94F0
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

	// RVA: 0xDA8B60 Offset: 0xDA7160 VA: 0x180DA8B60
	public Vector2 GetPreferredValues() { }

	// RVA: 0xDA8D20 Offset: 0xDA7320 VA: 0x180DA8D20
	public Vector2 GetPreferredValues(float width, float height) { }

	// RVA: 0xDA8C10 Offset: 0xDA7210 VA: 0x180DA8C10
	public Vector2 GetPreferredValues(string text) { }

	// RVA: 0xDA8A90 Offset: 0xDA7090 VA: 0x180DA8A90
	public Vector2 GetPreferredValues(string text, float width, float height) { }

	// RVA: 0xDA8E90 Offset: 0xDA7490 VA: 0x180DA8E90
	protected float GetPreferredWidth() { }

	// RVA: 0xDA8E10 Offset: 0xDA7410 VA: 0x180DA8E10
	protected float GetPreferredWidth(Vector2 margin) { }

	// RVA: 0xDA8810 Offset: 0xDA6E10 VA: 0x180DA8810
	protected float GetPreferredHeight() { }

	// RVA: 0xDA8A10 Offset: 0xDA7010 VA: 0x180DA8A10
	protected float GetPreferredHeight(Vector2 margin) { }

	// RVA: 0xDA9140 Offset: 0xDA7740 VA: 0x180DA9140
	public Vector2 GetRenderedValues() { }

	// RVA: 0xDA9080 Offset: 0xDA7680 VA: 0x180DA9080
	public Vector2 GetRenderedValues(bool onlyVisibleCharacters) { }

	// RVA: 0xDA91F0 Offset: 0xDA77F0 VA: 0x180DA91F0
	protected float GetRenderedWidth() { }

	// RVA: 0xDA9210 Offset: 0xDA7810 VA: 0x180DA9210
	protected float GetRenderedWidth(bool onlyVisibleCharacters) { }

	// RVA: 0xDA9060 Offset: 0xDA7660 VA: 0x180DA9060
	protected float GetRenderedHeight() { }

	// RVA: 0xDA9040 Offset: 0xDA7640 VA: 0x180DA9040
	protected float GetRenderedHeight(bool onlyVisibleCharacters) { }

	// RVA: 0xDA1BE0 Offset: 0xDA01E0 VA: 0x180DA1BE0 Slot: 110
	protected virtual Vector2 CalculatePreferredValues(float defaultFontSize, Vector2 marginSize, bool ignoreTextAutoSizing) { }

	// RVA: 0xDA8650 Offset: 0xDA6C50 VA: 0x180DA8650 Slot: 111
	protected virtual Bounds GetCompoundBounds() { }

	// RVA: 0xDA9750 Offset: 0xDA7D50 VA: 0x180DA9750
	protected Bounds GetTextBounds() { }

	// RVA: 0xDA9B60 Offset: 0xDA8160 VA: 0x180DA9B60
	protected Bounds GetTextBounds(bool onlyVisibleCharacters) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 112
	protected virtual void AdjustLineOffset(int startIndex, int endIndex, float offset) { }

	// RVA: 0xDABAD0 Offset: 0xDAA0D0 VA: 0x180DABAD0
	protected void ResizeLineExtents(int size) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 113
	public virtual TMP_TextInfo GetTextInfo(string text) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 114
	public virtual void ComputeMarginSize() { }

	// RVA: 0xDAD1C0 Offset: 0xDAB7C0 VA: 0x180DAD1C0
	protected void SaveWordWrappingState(ref WordWrapState state, int index, int count) { }

	// RVA: 0xDABD60 Offset: 0xDAA360 VA: 0x180DABD60
	protected int RestoreWordWrappingState(ref WordWrapState state) { }

	// RVA: 0xDAC1B0 Offset: 0xDAA7B0 VA: 0x180DAC1B0 Slot: 115
	protected virtual void SaveGlyphVertexInfo(float padding, float style_padding, Color32 vertexColor) { }

	// RVA: 0xDA7B60 Offset: 0xDA6160 VA: 0x180DA7B60 Slot: 116
	protected virtual void FillCharacterVertexBuffers(int i, int index_X4) { }

	// RVA: 0xDA6650 Offset: 0xDA4C50 VA: 0x180DA6650 Slot: 117
	protected virtual void FillCharacterVertexBuffers(int i, int index_X4, bool isVolumetric) { }

	// RVA: 0xDA4D20 Offset: 0xDA3320 VA: 0x180DA4D20 Slot: 118
	protected virtual void DrawUnderlineMesh(Vector3 start, Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor) { }

	// RVA: 0xDA4590 Offset: 0xDA2B90 VA: 0x180DA4590 Slot: 119
	protected virtual void DrawTextHighlight(Vector3 start, Vector3 end, ref int index, Color32 highlightColor) { }

	// RVA: 0xDAB730 Offset: 0xDA9D30 VA: 0x180DAB730
	protected void LoadDefaultSettings() { }

	// RVA: 0xDA9230 Offset: 0xDA7830 VA: 0x180DA9230
	protected void GetSpecialCharacters(TMP_FontAsset fontAsset) { }

	// RVA: 0xDABA50 Offset: 0xDAA050 VA: 0x180DABA50
	protected void ReplaceTagWithCharacter(int[] chars, int insertionIndex, int tagLength, char c) { }

	// RVA: 0xDA8660 Offset: 0xDA6C60 VA: 0x180DA8660
	protected TMP_FontAsset GetFontAssetForWeight(int fontWeight) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 120
	protected virtual void SetActiveSubMeshes(bool state) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 121
	protected virtual void ClearSubMeshObjects() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 122
	public virtual void ClearMesh() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 123
	public virtual void ClearMesh(bool uploadGeometry) { }

	// RVA: 0xDA8720 Offset: 0xDA6D20 VA: 0x180DA8720 Slot: 124
	public virtual string GetParsedText() { }

	// RVA: 0xDAB9C0 Offset: 0xDA9FC0 VA: 0x180DAB9C0
	protected Vector2 PackUV(float x, float y, float scale) { }

	// RVA: 0xDAB980 Offset: 0xDA9F80 VA: 0x180DAB980
	protected float PackUV(float x, float y) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 125
	internal virtual void InternalUpdate() { }

	// RVA: 0xDAB240 Offset: 0xDA9840 VA: 0x180DAB240
	protected int HexToInt(char hex) { }

	// RVA: 0xDAA000 Offset: 0xDA8600 VA: 0x180DAA000
	protected int GetUTF16(string text, int i) { }

	// RVA: 0xDAA0E0 Offset: 0xDA86E0 VA: 0x180DAA0E0
	protected int GetUTF16(StringBuilder text, int i) { }

	// RVA: 0xDAA350 Offset: 0xDA8950 VA: 0x180DAA350
	protected int GetUTF32(string text, int i) { }

	// RVA: 0xDAA1C0 Offset: 0xDA87C0 VA: 0x180DAA1C0
	protected int GetUTF32(StringBuilder text, int i) { }

	// RVA: 0xDAA4E0 Offset: 0xDA8AE0 VA: 0x180DAA4E0
	protected Color32 HexCharsToColor(char[] hexChars, int tagCount) { }

	// RVA: 0xDAAE50 Offset: 0xDA9450 VA: 0x180DAAE50
	protected Color32 HexCharsToColor(char[] hexChars, int startIndex, int length) { }

	// RVA: 0xDA8570 Offset: 0xDA6B70 VA: 0x180DA8570
	private int GetAttributeParameters(char[] chars, int startIndex, int length, ref float[] parameters) { }

	// RVA: 0xDA43A0 Offset: 0xDA29A0 VA: 0x180DA43A0
	protected float ConvertToFloat(char[] chars, int startIndex, int length) { }

	// RVA: 0xDA41F0 Offset: 0xDA27F0 VA: 0x180DA41F0
	protected float ConvertToFloat(char[] chars, int startIndex, int length, out int lastIndex) { }

	// RVA: 0xDADF80 Offset: 0xDAC580 VA: 0x180DADF80
	protected bool ValidateHtmlTag(TMP_Text.UnicodeChar[] chars, int startIndex, out int endIndex) { }

	// RVA: 0xDB32E0 Offset: 0xDB18E0 VA: 0x180DB32E0
	protected void .ctor() { }

	// RVA: 0xDB31A0 Offset: 0xDB17A0 VA: 0x180DB31A0
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

	// RVA: 0x69D730 Offset: 0x69BD30 VA: 0x18069D730
	public void set_glyphIndex(uint value) { }

	// RVA: 0x7D0570 Offset: 0x7CEB70 VA: 0x1807D0570
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

	// RVA: 0x1156B10 Offset: 0x1155110 VA: 0x181156B10
	public void .ctor() { }

	// RVA: 0x11569A0 Offset: 0x1154FA0 VA: 0x1811569A0
	public void .ctor(TMP_Text textComponent) { }

	// RVA: 0x1156260 Offset: 0x1154860 VA: 0x181156260
	public void Clear() { }

	// RVA: 0x1156150 Offset: 0x1154750 VA: 0x181156150
	public void ClearMeshInfo(bool updateMesh) { }

	// RVA: 0x1155DF0 Offset: 0x11543F0 VA: 0x181155DF0
	public void ClearAllMeshInfo() { }

	// RVA: 0x1156860 Offset: 0x1154E60 VA: 0x181156860
	public void ResetVertexLayout(bool isVolumetric) { }

	// RVA: 0x11561E0 Offset: 0x11547E0 VA: 0x1811561E0
	public void ClearUnusedVertices(MaterialReference[] materials) { }

	// RVA: 0x1155E70 Offset: 0x1154470 VA: 0x181155E70
	public void ClearLineInfo() { }

	// RVA: 0x11562E0 Offset: 0x11548E0 VA: 0x1811562E0
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

	// RVA: 0x11568F0 Offset: 0x1154EF0 VA: 0x1811568F0
	private static void .cctor() { }

}

public class TMP_TextParsingUtilities // TypeDefIndex: 6843
{	// Fields
	private static readonly TMP_TextParsingUtilities s_Instance; // 0x2B113F4
	private const string k_LookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-";
	private const string k_LookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-";

	// Properties
	public static TMP_TextParsingUtilities instance { get; }

	// Methods

	// RVA: 0x1156ED0 Offset: 0x11554D0 VA: 0x181156ED0
	private static void .cctor() { }

	// RVA: 0x1156F30 Offset: 0x1155530 VA: 0x181156F30
	public static TMP_TextParsingUtilities get_instance() { }

	// RVA: 0x1156C60 Offset: 0x1155260 VA: 0x181156C60
	public static uint GetHashCode(string s) { }

	// RVA: 0x1156C00 Offset: 0x1155200 VA: 0x181156C00
	public static int GetHashCodeCaseSensitive(string s) { }

	// RVA: 0x1156DB0 Offset: 0x11553B0 VA: 0x181156DB0
	public static char ToLowerASCIIFast(char c) { }

	// RVA: 0x1156E10 Offset: 0x1155410 VA: 0x181156E10
	public static char ToUpperASCIIFast(char c) { }

	// RVA: 0x1156E70 Offset: 0x1155470 VA: 0x181156E70
	public static uint ToUpperASCIIFast(uint c) { }

	// RVA: 0x1156D50 Offset: 0x1155350 VA: 0x181156D50
	public static uint ToLowerASCIIFast(uint c) { }

	// RVA: 0x1156D10 Offset: 0x1155310 VA: 0x181156D10
	public static bool IsHighSurrogate(uint c) { }

	// RVA: 0x1156D30 Offset: 0x1155330 VA: 0x181156D30
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

	// RVA: 0x115B7C0 Offset: 0x1159DC0 VA: 0x18115B7C0
	public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera) { }

	// RVA: 0x115B9C0 Offset: 0x1159FC0 VA: 0x18115B9C0
	public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera, out CaretPosition cursor) { }

	// RVA: 0x11599F0 Offset: 0x1157FF0 VA: 0x1811599F0
	public static int FindNearestLine(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x1158F30 Offset: 0x1157530 VA: 0x181158F30
	public static int FindNearestCharacterOnLine(TMP_Text text, Vector3 position, int line, Camera camera, bool visibleOnly) { }

	// RVA: 0x115C0C0 Offset: 0x115A6C0 VA: 0x18115C0C0
	public static bool IsIntersectingRectTransform(RectTransform rectTransform, Vector3 position, Camera camera) { }

	// RVA: 0x1157290 Offset: 0x1155890 VA: 0x181157290
	public static int FindIntersectingCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly) { }

	// RVA: 0x11594B0 Offset: 0x1157AB0 VA: 0x1811594B0
	public static int FindNearestCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly) { }

	// RVA: 0x11580C0 Offset: 0x11566C0 VA: 0x1811580C0
	public static int FindIntersectingWord(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x115AA60 Offset: 0x1159060 VA: 0x18115AA60
	public static int FindNearestWord(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x1157600 Offset: 0x1155C00 VA: 0x181157600
	public static int FindIntersectingLine(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x1157860 Offset: 0x1155E60 VA: 0x181157860
	public static int FindIntersectingLink(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x1159D10 Offset: 0x1158310 VA: 0x181159D10
	public static int FindNearestLink(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x115C2D0 Offset: 0x115A8D0 VA: 0x18115C2D0
	private static bool PointIntersectRectangle(Vector3 m, Vector3 a, Vector3 b, Vector3 c, Vector3 d) { }

	// RVA: 0x115C560 Offset: 0x115AB60 VA: 0x18115C560
	public static bool ScreenPointToWorldPointInRectangle(Transform transform, Vector2 screenPoint, Camera cam, out Vector3 worldPoint) { }

	// RVA: 0x115BE20 Offset: 0x115A420 VA: 0x18115BE20
	private static bool IntersectLinePlane(TMP_TextUtilities.LineSegment line, Vector3 point, Vector3 normal, out Vector3 intersectingPoint) { }

	// RVA: 0x1156F90 Offset: 0x1155590 VA: 0x181156F90
	public static float DistanceToLine(Vector3 a, Vector3 b, Vector3 point) { }

	// RVA: 0x115C8B0 Offset: 0x115AEB0 VA: 0x18115C8B0
	public static char ToLowerFast(char c) { }

	// RVA: 0x115C910 Offset: 0x115AF10 VA: 0x18115C910
	public static char ToUpperFast(char c) { }

	// RVA: 0x1156C00 Offset: 0x1155200 VA: 0x181156C00
	public static int GetSimpleHashCode(string s) { }

	// RVA: 0x115BC60 Offset: 0x115A260 VA: 0x18115BC60
	public static uint GetSimpleHashCodeLowercase(string s) { }

	// RVA: 0x115BD10 Offset: 0x115A310 VA: 0x18115BD10
	public static int HexToInt(char hex) { }

	// RVA: 0x115C7A0 Offset: 0x115ADA0 VA: 0x18115C7A0
	public static int StringHexToInt(string s) { }

	// RVA: 0x115C970 Offset: 0x115AF70 VA: 0x18115C970
	private static void .cctor() { }

}

private struct TMP_TextUtilities.LineSegment // TypeDefIndex: 6847
{	// Fields
	public Vector3 Point1; // 0x0
	public Vector3 Point2; // 0xC

	// Methods

	// RVA: 0x1BD660 Offset: 0x1BCA60 VA: 0x1801BD660
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

	// RVA: 0x115D6A0 Offset: 0x115BCA0 VA: 0x18115D6A0
	public static TMP_UpdateManager get_instance() { }

	// RVA: 0x115D470 Offset: 0x115BA70 VA: 0x18115D470
	protected void .ctor() { }

	// RVA: 0x115D160 Offset: 0x115B760 VA: 0x18115D160
	internal static void RegisterTextObjectForUpdate(TMP_Text textObject) { }

	// RVA: 0x115CD40 Offset: 0x115B340 VA: 0x18115CD40
	private void InternalRegisterTextObjectForUpdate(TMP_Text textObject) { }

	// RVA: 0x115D0A0 Offset: 0x115B6A0 VA: 0x18115D0A0
	public static void RegisterTextElementForLayoutRebuild(TMP_Text element) { }

	// RVA: 0x115CC80 Offset: 0x115B280 VA: 0x18115CC80
	private bool InternalRegisterTextElementForLayoutRebuild(TMP_Text element) { }

	// RVA: 0x115CFE0 Offset: 0x115B5E0 VA: 0x18115CFE0
	public static void RegisterTextElementForGraphicRebuild(TMP_Text element) { }

	// RVA: 0x115CBC0 Offset: 0x115B1C0 VA: 0x18115CBC0
	private bool InternalRegisterTextElementForGraphicRebuild(TMP_Text element) { }

	// RVA: 0x115CFD0 Offset: 0x115B5D0 VA: 0x18115CFD0
	private void OnBeginFrameRendering(ScriptableRenderContext renderContext, Camera[] cameras) { }

	// RVA: 0x115CFD0 Offset: 0x115B5D0 VA: 0x18115CFD0
	private void OnCameraPreCull(Camera cam) { }

	// RVA: 0x115C9C0 Offset: 0x115AFC0 VA: 0x18115C9C0
	private void DoRebuilds() { }

	// RVA: 0x115D3D0 Offset: 0x115B9D0 VA: 0x18115D3D0
	internal static void UnRegisterTextObjectForUpdate(TMP_Text textObject) { }

	// RVA: 0x115D220 Offset: 0x115B820 VA: 0x18115D220
	public static void UnRegisterTextElementForRebuild(TMP_Text element) { }

	// RVA: 0x115CDF0 Offset: 0x115B3F0 VA: 0x18115CDF0
	private void InternalUnRegisterTextElementForGraphicRebuild(TMP_Text element) { }

	// RVA: 0x115CE90 Offset: 0x115B490 VA: 0x18115CE90
	private void InternalUnRegisterTextElementForLayoutRebuild(TMP_Text element) { }

	// RVA: 0x115CF30 Offset: 0x115B530 VA: 0x18115CF30
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

	// RVA: 0x115E400 Offset: 0x115CA00 VA: 0x18115E400
	public static TMP_UpdateRegistry get_instance() { }

	// RVA: 0x115E2E0 Offset: 0x115C8E0 VA: 0x18115E2E0
	protected void .ctor() { }

	// RVA: 0x115DFA0 Offset: 0x115C5A0 VA: 0x18115DFA0
	public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x115D850 Offset: 0x115BE50 VA: 0x18115D850
	private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x115DE70 Offset: 0x115C470 VA: 0x18115DE70
	public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x115D720 Offset: 0x115BD20 VA: 0x18115D720
	private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x115DB80 Offset: 0x115C180 VA: 0x18115DB80
	private void PerformUpdateForCanvasRendererObjects() { }

	// RVA: 0x115DE20 Offset: 0x115C420 VA: 0x18115DE20
	private void PerformUpdateForMeshRendererObjects() { }

	// RVA: 0x115E0D0 Offset: 0x115C6D0 VA: 0x18115E0D0
	public static void UnRegisterCanvasElementForRebuild(ICanvasElement element) { }

	// RVA: 0x115DA80 Offset: 0x115C080 VA: 0x18115DA80
	private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x115D980 Offset: 0x115BF80 VA: 0x18115D980
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

	// RVA: 0xD9B0A0 Offset: 0xD996A0 VA: 0x180D9B0A0
	public static bool Approximately(float a, float b) { }

	// RVA: 0xD9B0D0 Offset: 0xD996D0 VA: 0x180D9B0D0
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

	// RVA: 0x122060 Offset: 0x121460 VA: 0x180122060
	internal void SetLinkID(char[] text, int startIndex, int length) { }

	// RVA: 0x121F80 Offset: 0x121380 VA: 0x180121F80
	public string GetLinkText() { }

	// RVA: 0x121EE0 Offset: 0x1212E0 VA: 0x180121EE0
	public string GetLinkID() { }

}

public struct TMP_WordInfo // TypeDefIndex: 6859
{	// Fields
	public TMP_Text textComponent; // 0x0
	public int firstCharacterIndex; // 0x8
	public int lastCharacterIndex; // 0xC
	public int characterCount; // 0x10

	// Methods

	// RVA: 0x1BD690 Offset: 0x1BCA90 VA: 0x1801BD690
	public string GetWord() { }

}

public struct TMP_SpriteInfo // TypeDefIndex: 6860
{	// Fields
	public int spriteIndex; // 0x0
	public int characterIndex; // 0x4
	public int vertexIndex; // 0x8

}

