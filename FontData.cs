public class FontData : ISerializationCallbackReceiver // TypeDefIndex: 4928
{	// Fields
	[SerializeField] // RVA: 0xE9520 Offset: 0xE8920 VA: 0x1800E9520
	[FormerlySerializedAsAttribute] // RVA: 0xE9520 Offset: 0xE8920 VA: 0x1800E9520
	private Font m_Font; // 0x10
	[SerializeField] // RVA: 0xE9660 Offset: 0xE8A60 VA: 0x1800E9660
	[FormerlySerializedAsAttribute] // RVA: 0xE9660 Offset: 0xE8A60 VA: 0x1800E9660
	private int m_FontSize; // 0x18
	[SerializeField] // RVA: 0xE9820 Offset: 0xE8C20 VA: 0x1800E9820
	[FormerlySerializedAsAttribute] // RVA: 0xE9820 Offset: 0xE8C20 VA: 0x1800E9820
	private FontStyle m_FontStyle; // 0x1C
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_BestFit; // 0x20
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int m_MinSize; // 0x24
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int m_MaxSize; // 0x28
	[SerializeField] // RVA: 0xE9C50 Offset: 0xE9050 VA: 0x1800E9C50
	[FormerlySerializedAsAttribute] // RVA: 0xE9C50 Offset: 0xE9050 VA: 0x1800E9C50
	private TextAnchor m_Alignment; // 0x2C
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_AlignByGeometry; // 0x30
	[SerializeField] // RVA: 0xE9F00 Offset: 0xE9300 VA: 0x1800E9F00
	[FormerlySerializedAsAttribute] // RVA: 0xE9F00 Offset: 0xE9300 VA: 0x1800E9F00
	private bool m_RichText; // 0x31
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private HorizontalWrapMode m_HorizontalOverflow; // 0x34
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private VerticalWrapMode m_VerticalOverflow; // 0x38
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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

	// RVA: 0x15EAAC0 Offset: 0x15E90C0 VA: 0x1815EAAC0
	public static FontData get_defaultFontData() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public Font get_font() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	public void set_font(Font value) { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	public int get_fontSize() { }

	// RVA: 0x7D0D90 Offset: 0x7CF390 VA: 0x1807D0D90
	public void set_fontSize(int value) { }

	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460
	public FontStyle get_fontStyle() { }

	// RVA: 0x95FB00 Offset: 0x95E100 VA: 0x18095FB00
	public void set_fontStyle(FontStyle value) { }

	// RVA: 0xB106B0 Offset: 0xB0ECB0 VA: 0x180B106B0
	public bool get_bestFit() { }

	// RVA: 0x7F9BF0 Offset: 0x7F81F0 VA: 0x1807F9BF0
	public void set_bestFit(bool value) { }

	// RVA: 0x7D0D10 Offset: 0x7CF310 VA: 0x1807D0D10
	public int get_minSize() { }

	// RVA: 0x7D0D70 Offset: 0x7CF370 VA: 0x1807D0D70
	public void set_minSize(int value) { }

	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	public int get_maxSize() { }

	// RVA: 0x7D0D60 Offset: 0x7CF360 VA: 0x1807D0D60
	public void set_maxSize(int value) { }

	// RVA: 0x5DE3B0 Offset: 0x5DC9B0 VA: 0x1805DE3B0
	public TextAnchor get_alignment() { }

	// RVA: 0x10B82E0 Offset: 0x10B68E0 VA: 0x1810B82E0
	public void set_alignment(TextAnchor value) { }

	// RVA: 0x82BDA0 Offset: 0x82A3A0 VA: 0x18082BDA0
	public bool get_alignByGeometry() { }

	// RVA: 0x82BDD0 Offset: 0x82A3D0 VA: 0x18082BDD0
	public void set_alignByGeometry(bool value) { }

	// RVA: 0xFFB570 Offset: 0xFF9B70 VA: 0x180FFB570
	public bool get_richText() { }

	// RVA: 0x15EAB40 Offset: 0x15E9140 VA: 0x1815EAB40
	public void set_richText(bool value) { }

	// RVA: 0x5E2F40 Offset: 0x5E1540 VA: 0x1805E2F40
	public HorizontalWrapMode get_horizontalOverflow() { }

	// RVA: 0xD73FD0 Offset: 0xD725D0 VA: 0x180D73FD0
	public void set_horizontalOverflow(HorizontalWrapMode value) { }

	// RVA: 0x6BBA50 Offset: 0x6BA050 VA: 0x1806BBA50
	public VerticalWrapMode get_verticalOverflow() { }

	// RVA: 0xC74BD0 Offset: 0xC731D0 VA: 0x180C74BD0
	public void set_verticalOverflow(VerticalWrapMode value) { }

	// RVA: 0xA21B80 Offset: 0xA20180 VA: 0x180A21B80
	public float get_lineSpacing() { }

	// RVA: 0x522390 Offset: 0x520990 VA: 0x180522390
	public void set_lineSpacing(float value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 4
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x15EAA20 Offset: 0x15E9020 VA: 0x1815EAA20 Slot: 5
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

