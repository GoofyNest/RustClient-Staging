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

	// RVA: 0x230CF10 Offset: 0x230B510 VA: 0x18230CF10
	public void .ctor() { }

	// RVA: 0x230CE00 Offset: 0x230B400 VA: 0x18230CE00
	public void .ctor(int initialCapacity) { }

	// RVA: 0x230B8E0 Offset: 0x2309EE0 VA: 0x18230B8E0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x230CA00 Offset: 0x230B000 VA: 0x18230CA00 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x230D010 Offset: 0x230B610 VA: 0x18230D010
	public int get_characterCountVisible() { }

	// RVA: 0x230CA80 Offset: 0x230B080 VA: 0x18230CA80
	private TextGenerationSettings ValidatedSettings(TextGenerationSettings settings) { }

	// RVA: 0x230BC60 Offset: 0x230A260 VA: 0x18230BC60
	public void Invalidate() { }

	// RVA: 0x230B990 Offset: 0x2309F90 VA: 0x18230B990
	public void GetCharacters(List<UICharInfo> characters) { }

	// RVA: 0x230B9E0 Offset: 0x2309FE0 VA: 0x18230B9E0
	public void GetLines(List<UILineInfo> lines) { }

	// RVA: 0x230BBA0 Offset: 0x230A1A0 VA: 0x18230BBA0
	public void GetVertices(List<UIVertex> vertices) { }

	// RVA: 0x230BAE0 Offset: 0x230A0E0 VA: 0x18230BAE0
	public float GetPreferredWidth(string str, TextGenerationSettings settings) { }

	// RVA: 0x230BA30 Offset: 0x230A030 VA: 0x18230BA30
	public float GetPreferredHeight(string str, TextGenerationSettings settings) { }

	// RVA: 0x230C320 Offset: 0x230A920 VA: 0x18230C320
	public bool PopulateWithErrors(string str, TextGenerationSettings settings, GameObject context) { }

	// RVA: 0x230C9A0 Offset: 0x230AFA0 VA: 0x18230C9A0
	public bool Populate(string str, TextGenerationSettings settings) { }

	// RVA: 0x230BF90 Offset: 0x230A590 VA: 0x18230BF90
	private TextGenerationError PopulateWithError(string str, TextGenerationSettings settings) { }

	// RVA: 0x230BC70 Offset: 0x230A270 VA: 0x18230BC70
	private TextGenerationError PopulateAlways(string str, TextGenerationSettings settings) { }

	// RVA: 0x230D250 Offset: 0x230B850 VA: 0x18230D250
	public IList<UIVertex> get_verts() { }

	// RVA: 0x230D090 Offset: 0x230B690 VA: 0x18230D090
	public IList<UICharInfo> get_characters() { }

	// RVA: 0x230D140 Offset: 0x230B740 VA: 0x18230D140
	public IList<UILineInfo> get_lines() { }

	// RVA: 0x230D200 Offset: 0x230B800 VA: 0x18230D200
	public Rect get_rectExtents() { }

	// RVA: 0x230D050 Offset: 0x230B650 VA: 0x18230D050
	public int get_characterCount() { }

	// RVA: 0x230D100 Offset: 0x230B700 VA: 0x18230D100
	public int get_lineCount() { }

	[NativeMethodAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	// RVA: 0x230BBF0 Offset: 0x230A1F0 VA: 0x18230BBF0
	private static IntPtr Internal_Create() { }

	[NativeMethodAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	// RVA: 0x230BC20 Offset: 0x230A220 VA: 0x18230BC20
	private static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x230C820 Offset: 0x230AE20 VA: 0x18230C820
	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error) { }

	// RVA: 0x230C620 Offset: 0x230AC20 VA: 0x18230C620
	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, VerticalWrapMode verticalOverFlow, HorizontalWrapMode horizontalOverflow, bool updateBounds, TextAnchor anchor, Vector2 extents, Vector2 pivot, bool generateOutOfBounds, bool alignByGeometry, out TextGenerationError error) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x230BBA0 Offset: 0x230A1A0 VA: 0x18230BBA0
	private void GetVerticesInternal(object vertices) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x230B990 Offset: 0x2309F90 VA: 0x18230B990
	private void GetCharactersInternal(object characters) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x230B9E0 Offset: 0x2309FE0 VA: 0x18230B9E0
	private void GetLinesInternal(object lines) { }

	// RVA: 0x230D1B0 Offset: 0x230B7B0 VA: 0x18230D1B0
	private void get_rectExtents_Injected(out Rect ret) { }

	// RVA: 0x230C560 Offset: 0x230AB60 VA: 0x18230C560
	private bool Populate_Internal_Injected(string str, Font font, ref Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error) { }

}

