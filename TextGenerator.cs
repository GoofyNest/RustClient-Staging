public sealed class TextGenerator : IDisposable // TypeDefIndex: 3952
{	// Fields
	internal IntPtr m_Ptr; // 0x10
	private string m_LastString; // 0x18
	private TextGenerationSettings m_LastSettings; // 0x20
	private bool m_HasGenerated; // 0x80
	private TextGenerationError m_LastValid; // 0x84
	private readonly List<UIVertex> m_Verts; // 0x88
	private readonly List<UICharInfo> m_Characters; // 0x90
	private readonly List<UILineInfo> m_Lines; // 0x98
	private bool m_CachedVerts; // 0xA0
	private bool m_CachedCharacters; // 0xA1
	private bool m_CachedLines; // 0xA2

	// Properties
	public int characterCountVisible { get; }
	public IList<UIVertex> verts { get; }
	public IList<UICharInfo> characters { get; }
	public IList<UILineInfo> lines { get; }
	public Rect rectExtents { get; }
	public int characterCount { get; }
	public int lineCount { get; }

	// Methods

	// RVA: 0x230C6F0 Offset: 0x230ACF0 VA: 0x18230C6F0
	public void .ctor() { }

	// RVA: 0x230C5E0 Offset: 0x230ABE0 VA: 0x18230C5E0
	public void .ctor(int initialCapacity) { }

	// RVA: 0x230B0C0 Offset: 0x23096C0 VA: 0x18230B0C0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x230C1E0 Offset: 0x230A7E0 VA: 0x18230C1E0 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x230C7F0 Offset: 0x230ADF0 VA: 0x18230C7F0
	public int get_characterCountVisible() { }

	// RVA: 0x230C260 Offset: 0x230A860 VA: 0x18230C260
	private TextGenerationSettings ValidatedSettings(TextGenerationSettings settings) { }

	// RVA: 0x230B440 Offset: 0x2309A40 VA: 0x18230B440
	public void Invalidate() { }

	// RVA: 0x230B170 Offset: 0x2309770 VA: 0x18230B170
	public void GetCharacters(List<UICharInfo> characters) { }

	// RVA: 0x230B1C0 Offset: 0x23097C0 VA: 0x18230B1C0
	public void GetLines(List<UILineInfo> lines) { }

	// RVA: 0x230B380 Offset: 0x2309980 VA: 0x18230B380
	public void GetVertices(List<UIVertex> vertices) { }

	// RVA: 0x230B2C0 Offset: 0x23098C0 VA: 0x18230B2C0
	public float GetPreferredWidth(string str, TextGenerationSettings settings) { }

	// RVA: 0x230B210 Offset: 0x2309810 VA: 0x18230B210
	public float GetPreferredHeight(string str, TextGenerationSettings settings) { }

	// RVA: 0x230BB00 Offset: 0x230A100 VA: 0x18230BB00
	public bool PopulateWithErrors(string str, TextGenerationSettings settings, GameObject context) { }

	// RVA: 0x230C180 Offset: 0x230A780 VA: 0x18230C180
	public bool Populate(string str, TextGenerationSettings settings) { }

	// RVA: 0x230B770 Offset: 0x2309D70 VA: 0x18230B770
	private TextGenerationError PopulateWithError(string str, TextGenerationSettings settings) { }

	// RVA: 0x230B450 Offset: 0x2309A50 VA: 0x18230B450
	private TextGenerationError PopulateAlways(string str, TextGenerationSettings settings) { }

	// RVA: 0x230CA30 Offset: 0x230B030 VA: 0x18230CA30
	public IList<UIVertex> get_verts() { }

	// RVA: 0x230C870 Offset: 0x230AE70 VA: 0x18230C870
	public IList<UICharInfo> get_characters() { }

	// RVA: 0x230C920 Offset: 0x230AF20 VA: 0x18230C920
	public IList<UILineInfo> get_lines() { }

	// RVA: 0x230C9E0 Offset: 0x230AFE0 VA: 0x18230C9E0
	public Rect get_rectExtents() { }

	// RVA: 0x230C830 Offset: 0x230AE30 VA: 0x18230C830
	public int get_characterCount() { }

	// RVA: 0x230C8E0 Offset: 0x230AEE0 VA: 0x18230C8E0
	public int get_lineCount() { }

	[NativeMethodAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	// RVA: 0x230B3D0 Offset: 0x23099D0 VA: 0x18230B3D0
	private static IntPtr Internal_Create() { }

	[NativeMethodAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	// RVA: 0x230B400 Offset: 0x2309A00 VA: 0x18230B400
	private static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x230C000 Offset: 0x230A600 VA: 0x18230C000
	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error) { }

	// RVA: 0x230BE00 Offset: 0x230A400 VA: 0x18230BE00
	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, VerticalWrapMode verticalOverFlow, HorizontalWrapMode horizontalOverflow, bool updateBounds, TextAnchor anchor, Vector2 extents, Vector2 pivot, bool generateOutOfBounds, bool alignByGeometry, out TextGenerationError error) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x230B380 Offset: 0x2309980 VA: 0x18230B380
	private void GetVerticesInternal(object vertices) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x230B170 Offset: 0x2309770 VA: 0x18230B170
	private void GetCharactersInternal(object characters) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x230B1C0 Offset: 0x23097C0 VA: 0x18230B1C0
	private void GetLinesInternal(object lines) { }

	// RVA: 0x230C990 Offset: 0x230AF90 VA: 0x18230C990
	private void get_rectExtents_Injected(out Rect ret) { }

	// RVA: 0x230BD40 Offset: 0x230A340 VA: 0x18230BD40
	private bool Populate_Internal_Injected(string str, Font font, ref Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error) { }

}

