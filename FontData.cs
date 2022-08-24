public class FontData : ISerializationCallbackReceiver // TypeDefIndex: 4928
{	[SerializeField] // RVA: 0xE9600 Offset: 0xE8A00 VA: 0x1800E9600
	[FormerlySerializedAsAttribute] // RVA: 0xE9600 Offset: 0xE8A00 VA: 0x1800E9600
	private Font m_Font; // 0x10
	[SerializeField] // RVA: 0xE9750 Offset: 0xE8B50 VA: 0x1800E9750
	[FormerlySerializedAsAttribute] // RVA: 0xE9750 Offset: 0xE8B50 VA: 0x1800E9750
	private int m_FontSize; // 0x18
	[SerializeField] // RVA: 0xE9950 Offset: 0xE8D50 VA: 0x1800E9950
	[FormerlySerializedAsAttribute] // RVA: 0xE9950 Offset: 0xE8D50 VA: 0x1800E9950
	private FontStyle m_FontStyle; // 0x1C
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private bool m_BestFit; // 0x20
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private int m_MinSize; // 0x24
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private int m_MaxSize; // 0x28
	[SerializeField] // RVA: 0xE9D70 Offset: 0xE9170 VA: 0x1800E9D70
	[FormerlySerializedAsAttribute] // RVA: 0xE9D70 Offset: 0xE9170 VA: 0x1800E9D70
	private TextAnchor m_Alignment; // 0x2C
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private bool m_AlignByGeometry; // 0x30
	[SerializeField] // RVA: 0xEA040 Offset: 0xE9440 VA: 0x1800EA040
	[FormerlySerializedAsAttribute] // RVA: 0xEA040 Offset: 0xE9440 VA: 0x1800EA040
	private bool m_RichText; // 0x31
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private HorizontalWrapMode m_HorizontalOverflow; // 0x34
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private VerticalWrapMode m_VerticalOverflow; // 0x38
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float m_LineSpacing; // 0x3C

	public static FontData defaultFontData { get; }
	public Font font { get; set; }
	public int fontSize { get; set; }
	public FontStyle fontStyle { get; set; }
	public bool bestFit { get; set; }
	public int minSize { get; set; }
	public int maxSize { get; set; }
	public TextAnchor alignment { get; set; }
	public bool alignByGeometry { get; set; }
	public bool richText { get; set; }
	public HorizontalWrapMode horizontalOverflow { get; set; }
	public VerticalWrapMode verticalOverflow { get; set; }
	public float lineSpacing { get; set; }


	public static FontData get_defaultFontData() { }

	public Font get_font() { }

	public void set_font(Font value) { }

	public int get_fontSize() { }

	public void set_fontSize(int value) { }

	public FontStyle get_fontStyle() { }

	public void set_fontStyle(FontStyle value) { }

	public bool get_bestFit() { }

	public void set_bestFit(bool value) { }

	public int get_minSize() { }

	public void set_minSize(int value) { }

	public int get_maxSize() { }

	public void set_maxSize(int value) { }

	public TextAnchor get_alignment() { }

	public void set_alignment(TextAnchor value) { }

	public bool get_alignByGeometry() { }

	public void set_alignByGeometry(bool value) { }

	public bool get_richText() { }

	public void set_richText(bool value) { }

	public HorizontalWrapMode get_horizontalOverflow() { }

	public void set_horizontalOverflow(HorizontalWrapMode value) { }

	public VerticalWrapMode get_verticalOverflow() { }

	public void set_verticalOverflow(VerticalWrapMode value) { }

	public float get_lineSpacing() { }

	public void set_lineSpacing(float value) { }

	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	public void .ctor() { }

}

