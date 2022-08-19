public class FontData : ISerializationCallbackReceiver // TypeDefIndex: 4928
{	// Fields
	[SerializeField] // RVA: 0xE94E0 Offset: 0xE88E0 VA: 0x1800E94E0
	[FormerlySerializedAsAttribute] // RVA: 0xE94E0 Offset: 0xE88E0 VA: 0x1800E94E0
	private Font m_Font; // 0x10
	[SerializeField] // RVA: 0xE9610 Offset: 0xE8A10 VA: 0x1800E9610
	[FormerlySerializedAsAttribute] // RVA: 0xE9610 Offset: 0xE8A10 VA: 0x1800E9610
	private int m_FontSize; // 0x18
	[SerializeField] // RVA: 0xE97F0 Offset: 0xE8BF0 VA: 0x1800E97F0
	[FormerlySerializedAsAttribute] // RVA: 0xE97F0 Offset: 0xE8BF0 VA: 0x1800E97F0
	private FontStyle m_FontStyle; // 0x1C
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool m_BestFit; // 0x20
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int m_MinSize; // 0x24
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int m_MaxSize; // 0x28
	[SerializeField] // RVA: 0xE9C80 Offset: 0xE9080 VA: 0x1800E9C80
	[FormerlySerializedAsAttribute] // RVA: 0xE9C80 Offset: 0xE9080 VA: 0x1800E9C80
	private TextAnchor m_Alignment; // 0x2C
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool m_AlignByGeometry; // 0x30
	[SerializeField] // RVA: 0xE9EB0 Offset: 0xE92B0 VA: 0x1800E9EB0
	[FormerlySerializedAsAttribute] // RVA: 0xE9EB0 Offset: 0xE92B0 VA: 0x1800E9EB0
	private bool m_RichText; // 0x31
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private HorizontalWrapMode m_HorizontalOverflow; // 0x34
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private VerticalWrapMode m_VerticalOverflow; // 0x38
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float m_LineSpacing; // 0x3C

	// Properties
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

	// Methods

	// RVA: 0x15EA800 Offset: 0x15E8E00 VA: 0x1815EA800
	public static FontData get_defaultFontData() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public Font get_font() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	public void set_font(Font value) { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	public int get_fontSize() { }

	// RVA: 0x7D0C80 Offset: 0x7CF280 VA: 0x1807D0C80
	public void set_fontSize(int value) { }

	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460
	public FontStyle get_fontStyle() { }

	// RVA: 0x95F9F0 Offset: 0x95DFF0 VA: 0x18095F9F0
	public void set_fontStyle(FontStyle value) { }

	// RVA: 0xB103F0 Offset: 0xB0E9F0 VA: 0x180B103F0
	public bool get_bestFit() { }

	// RVA: 0x7F9AE0 Offset: 0x7F80E0 VA: 0x1807F9AE0
	public void set_bestFit(bool value) { }

	// RVA: 0x7D0C00 Offset: 0x7CF200 VA: 0x1807D0C00
	public int get_minSize() { }

	// RVA: 0x7D0C60 Offset: 0x7CF260 VA: 0x1807D0C60
	public void set_minSize(int value) { }

	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	public int get_maxSize() { }

	// RVA: 0x7D0C50 Offset: 0x7CF250 VA: 0x1807D0C50
	public void set_maxSize(int value) { }

	// RVA: 0x5DE3B0 Offset: 0x5DC9B0 VA: 0x1805DE3B0
	public TextAnchor get_alignment() { }

	// RVA: 0x10B8020 Offset: 0x10B6620 VA: 0x1810B8020
	public void set_alignment(TextAnchor value) { }

	// RVA: 0x82BC90 Offset: 0x82A290 VA: 0x18082BC90
	public bool get_alignByGeometry() { }

	// RVA: 0x82BCC0 Offset: 0x82A2C0 VA: 0x18082BCC0
	public void set_alignByGeometry(bool value) { }

	// RVA: 0xFFB2B0 Offset: 0xFF98B0 VA: 0x180FFB2B0
	public bool get_richText() { }

	// RVA: 0x15EA880 Offset: 0x15E8E80 VA: 0x1815EA880
	public void set_richText(bool value) { }

	// RVA: 0x5E2F40 Offset: 0x5E1540 VA: 0x1805E2F40
	public HorizontalWrapMode get_horizontalOverflow() { }

	// RVA: 0xD73D10 Offset: 0xD72310 VA: 0x180D73D10
	public void set_horizontalOverflow(HorizontalWrapMode value) { }

	// RVA: 0x6BB940 Offset: 0x6B9F40 VA: 0x1806BB940
	public VerticalWrapMode get_verticalOverflow() { }

	// RVA: 0xC74910 Offset: 0xC72F10 VA: 0x180C74910
	public void set_verticalOverflow(VerticalWrapMode value) { }

	// RVA: 0xA218C0 Offset: 0xA1FEC0 VA: 0x180A218C0
	public float get_lineSpacing() { }

	// RVA: 0x522390 Offset: 0x520990 VA: 0x180522390
	public void set_lineSpacing(float value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 4
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x15EA760 Offset: 0x15E8D60 VA: 0x1815EA760 Slot: 5
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

