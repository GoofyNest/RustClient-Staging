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

	// RVA: 0x230C430 Offset: 0x230AA30 VA: 0x18230C430
	public void .ctor() { }

	// RVA: 0x230C320 Offset: 0x230A920 VA: 0x18230C320
	public void .ctor(int initialCapacity) { }

	// RVA: 0x230AE00 Offset: 0x2309400 VA: 0x18230AE00 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x230BF20 Offset: 0x230A520 VA: 0x18230BF20 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x230C530 Offset: 0x230AB30 VA: 0x18230C530
	public int get_characterCountVisible() { }

	// RVA: 0x230BFA0 Offset: 0x230A5A0 VA: 0x18230BFA0
	private TextGenerationSettings ValidatedSettings(TextGenerationSettings settings) { }

	// RVA: 0x230B180 Offset: 0x2309780 VA: 0x18230B180
	public void Invalidate() { }

	// RVA: 0x230AEB0 Offset: 0x23094B0 VA: 0x18230AEB0
	public void GetCharacters(List<UICharInfo> characters) { }

	// RVA: 0x230AF00 Offset: 0x2309500 VA: 0x18230AF00
	public void GetLines(List<UILineInfo> lines) { }

	// RVA: 0x230B0C0 Offset: 0x23096C0 VA: 0x18230B0C0
	public void GetVertices(List<UIVertex> vertices) { }

	// RVA: 0x230B000 Offset: 0x2309600 VA: 0x18230B000
	public float GetPreferredWidth(string str, TextGenerationSettings settings) { }

	// RVA: 0x230AF50 Offset: 0x2309550 VA: 0x18230AF50
	public float GetPreferredHeight(string str, TextGenerationSettings settings) { }

	// RVA: 0x230B840 Offset: 0x2309E40 VA: 0x18230B840
	public bool PopulateWithErrors(string str, TextGenerationSettings settings, GameObject context) { }

	// RVA: 0x230BEC0 Offset: 0x230A4C0 VA: 0x18230BEC0
	public bool Populate(string str, TextGenerationSettings settings) { }

	// RVA: 0x230B4B0 Offset: 0x2309AB0 VA: 0x18230B4B0
	private TextGenerationError PopulateWithError(string str, TextGenerationSettings settings) { }

	// RVA: 0x230B190 Offset: 0x2309790 VA: 0x18230B190
	private TextGenerationError PopulateAlways(string str, TextGenerationSettings settings) { }

	// RVA: 0x230C770 Offset: 0x230AD70 VA: 0x18230C770
	public IList<UIVertex> get_verts() { }

	// RVA: 0x230C5B0 Offset: 0x230ABB0 VA: 0x18230C5B0
	public IList<UICharInfo> get_characters() { }

	// RVA: 0x230C660 Offset: 0x230AC60 VA: 0x18230C660
	public IList<UILineInfo> get_lines() { }

	// RVA: 0x230C720 Offset: 0x230AD20 VA: 0x18230C720
	public Rect get_rectExtents() { }

	// RVA: 0x230C570 Offset: 0x230AB70 VA: 0x18230C570
	public int get_characterCount() { }

	// RVA: 0x230C620 Offset: 0x230AC20 VA: 0x18230C620
	public int get_lineCount() { }

	[NativeMethodAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	// RVA: 0x230B110 Offset: 0x2309710 VA: 0x18230B110
	private static IntPtr Internal_Create() { }

	[NativeMethodAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	// RVA: 0x230B140 Offset: 0x2309740 VA: 0x18230B140
	private static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x230BD40 Offset: 0x230A340 VA: 0x18230BD40
	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error) { }

	// RVA: 0x230BB40 Offset: 0x230A140 VA: 0x18230BB40
	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, VerticalWrapMode verticalOverFlow, HorizontalWrapMode horizontalOverflow, bool updateBounds, TextAnchor anchor, Vector2 extents, Vector2 pivot, bool generateOutOfBounds, bool alignByGeometry, out TextGenerationError error) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x230B0C0 Offset: 0x23096C0 VA: 0x18230B0C0
	private void GetVerticesInternal(object vertices) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x230AEB0 Offset: 0x23094B0 VA: 0x18230AEB0
	private void GetCharactersInternal(object characters) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x230AF00 Offset: 0x2309500 VA: 0x18230AF00
	private void GetLinesInternal(object lines) { }

	// RVA: 0x230C6D0 Offset: 0x230ACD0 VA: 0x18230C6D0
	private void get_rectExtents_Injected(out Rect ret) { }

	// RVA: 0x230BA80 Offset: 0x230A080 VA: 0x18230BA80
	private bool Populate_Internal_Injected(string str, Font font, ref Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error) { }

}

