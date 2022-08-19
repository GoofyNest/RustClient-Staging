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

	// RVA: 0x230C5F0 Offset: 0x230ABF0 VA: 0x18230C5F0
	public void .ctor() { }

	// RVA: 0x230C4E0 Offset: 0x230AAE0 VA: 0x18230C4E0
	public void .ctor(int initialCapacity) { }

	// RVA: 0x230AFC0 Offset: 0x23095C0 VA: 0x18230AFC0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x230C0E0 Offset: 0x230A6E0 VA: 0x18230C0E0 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x230C6F0 Offset: 0x230ACF0 VA: 0x18230C6F0
	public int get_characterCountVisible() { }

	// RVA: 0x230C160 Offset: 0x230A760 VA: 0x18230C160
	private TextGenerationSettings ValidatedSettings(TextGenerationSettings settings) { }

	// RVA: 0x230B340 Offset: 0x2309940 VA: 0x18230B340
	public void Invalidate() { }

	// RVA: 0x230B070 Offset: 0x2309670 VA: 0x18230B070
	public void GetCharacters(List<UICharInfo> characters) { }

	// RVA: 0x230B0C0 Offset: 0x23096C0 VA: 0x18230B0C0
	public void GetLines(List<UILineInfo> lines) { }

	// RVA: 0x230B280 Offset: 0x2309880 VA: 0x18230B280
	public void GetVertices(List<UIVertex> vertices) { }

	// RVA: 0x230B1C0 Offset: 0x23097C0 VA: 0x18230B1C0
	public float GetPreferredWidth(string str, TextGenerationSettings settings) { }

	// RVA: 0x230B110 Offset: 0x2309710 VA: 0x18230B110
	public float GetPreferredHeight(string str, TextGenerationSettings settings) { }

	// RVA: 0x230BA00 Offset: 0x230A000 VA: 0x18230BA00
	public bool PopulateWithErrors(string str, TextGenerationSettings settings, GameObject context) { }

	// RVA: 0x230C080 Offset: 0x230A680 VA: 0x18230C080
	public bool Populate(string str, TextGenerationSettings settings) { }

	// RVA: 0x230B670 Offset: 0x2309C70 VA: 0x18230B670
	private TextGenerationError PopulateWithError(string str, TextGenerationSettings settings) { }

	// RVA: 0x230B350 Offset: 0x2309950 VA: 0x18230B350
	private TextGenerationError PopulateAlways(string str, TextGenerationSettings settings) { }

	// RVA: 0x230C930 Offset: 0x230AF30 VA: 0x18230C930
	public IList<UIVertex> get_verts() { }

	// RVA: 0x230C770 Offset: 0x230AD70 VA: 0x18230C770
	public IList<UICharInfo> get_characters() { }

	// RVA: 0x230C820 Offset: 0x230AE20 VA: 0x18230C820
	public IList<UILineInfo> get_lines() { }

	// RVA: 0x230C8E0 Offset: 0x230AEE0 VA: 0x18230C8E0
	public Rect get_rectExtents() { }

	// RVA: 0x230C730 Offset: 0x230AD30 VA: 0x18230C730
	public int get_characterCount() { }

	// RVA: 0x230C7E0 Offset: 0x230ADE0 VA: 0x18230C7E0
	public int get_lineCount() { }

	[NativeMethodAttribute] // RVA: 0x90510 Offset: 0x8F910 VA: 0x180090510
	// RVA: 0x230B2D0 Offset: 0x23098D0 VA: 0x18230B2D0
	private static IntPtr Internal_Create() { }

	[NativeMethodAttribute] // RVA: 0x90510 Offset: 0x8F910 VA: 0x180090510
	// RVA: 0x230B300 Offset: 0x2309900 VA: 0x18230B300
	private static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x230BF00 Offset: 0x230A500 VA: 0x18230BF00
	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error) { }

	// RVA: 0x230BD00 Offset: 0x230A300 VA: 0x18230BD00
	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, VerticalWrapMode verticalOverFlow, HorizontalWrapMode horizontalOverflow, bool updateBounds, TextAnchor anchor, Vector2 extents, Vector2 pivot, bool generateOutOfBounds, bool alignByGeometry, out TextGenerationError error) { }

	[NativeThrowsAttribute] // RVA: 0x80A80 Offset: 0x7FE80 VA: 0x180080A80
	// RVA: 0x230B280 Offset: 0x2309880 VA: 0x18230B280
	private void GetVerticesInternal(object vertices) { }

	[NativeThrowsAttribute] // RVA: 0x80A80 Offset: 0x7FE80 VA: 0x180080A80
	// RVA: 0x230B070 Offset: 0x2309670 VA: 0x18230B070
	private void GetCharactersInternal(object characters) { }

	[NativeThrowsAttribute] // RVA: 0x80A80 Offset: 0x7FE80 VA: 0x180080A80
	// RVA: 0x230B0C0 Offset: 0x23096C0 VA: 0x18230B0C0
	private void GetLinesInternal(object lines) { }

	// RVA: 0x230C890 Offset: 0x230AE90 VA: 0x18230C890
	private void get_rectExtents_Injected(out Rect ret) { }

	// RVA: 0x230BC40 Offset: 0x230A240 VA: 0x18230BC40
	private bool Populate_Internal_Injected(string str, Font font, ref Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error) { }

}

