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

	// RVA: 0x15D7DE0 Offset: 0x15D63E0 VA: 0x1815D7DE0
	public static FontData get_defaultFontData() { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public Font get_font() { }

	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	public void set_font(Font value) { }

	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	public int get_fontSize() { }

	// RVA: 0x79C6B0 Offset: 0x79ACB0 VA: 0x18079C6B0
	public void set_fontSize(int value) { }

	// RVA: 0x4C13F0 Offset: 0x4BF9F0 VA: 0x1804C13F0
	public FontStyle get_fontStyle() { }

	// RVA: 0x960000 Offset: 0x95E600 VA: 0x180960000
	public void set_fontStyle(FontStyle value) { }

	// RVA: 0xB10B80 Offset: 0xB0F180 VA: 0x180B10B80
	public bool get_bestFit() { }

	// RVA: 0x7FA180 Offset: 0x7F8780 VA: 0x1807FA180
	public void set_bestFit(bool value) { }

	// RVA: 0x79C630 Offset: 0x79AC30 VA: 0x18079C630
	public int get_minSize() { }

	// RVA: 0x79C690 Offset: 0x79AC90 VA: 0x18079C690
	public void set_minSize(int value) { }

	// RVA: 0x4BE590 Offset: 0x4BCB90 VA: 0x1804BE590
	public int get_maxSize() { }

	// RVA: 0x79C680 Offset: 0x79AC80 VA: 0x18079C680
	public void set_maxSize(int value) { }

	// RVA: 0x5DE340 Offset: 0x5DC940 VA: 0x1805DE340
	public TextAnchor get_alignment() { }

	// RVA: 0x10B8D50 Offset: 0x10B7350 VA: 0x1810B8D50
	public void set_alignment(TextAnchor value) { }

	// RVA: 0x82C2F0 Offset: 0x82A8F0 VA: 0x18082C2F0
	public bool get_alignByGeometry() { }

	// RVA: 0x82C320 Offset: 0x82A920 VA: 0x18082C320
	public void set_alignByGeometry(bool value) { }

	// RVA: 0xFFC010 Offset: 0xFFA610 VA: 0x180FFC010
	public bool get_richText() { }

	// RVA: 0x15D7E60 Offset: 0x15D6460 VA: 0x1815D7E60
	public void set_richText(bool value) { }

	// RVA: 0x5E2ED0 Offset: 0x5E14D0 VA: 0x1805E2ED0
	public HorizontalWrapMode get_horizontalOverflow() { }

	// RVA: 0xD74A80 Offset: 0xD73080 VA: 0x180D74A80
	public void set_horizontalOverflow(HorizontalWrapMode value) { }

	// RVA: 0x6BB9E0 Offset: 0x6B9FE0 VA: 0x1806BB9E0
	public VerticalWrapMode get_verticalOverflow() { }

	// RVA: 0xC75070 Offset: 0xC73670 VA: 0x180C75070
	public void set_verticalOverflow(VerticalWrapMode value) { }

	// RVA: 0xA22070 Offset: 0xA20670 VA: 0x180A22070
	public float get_lineSpacing() { }

	// RVA: 0x522320 Offset: 0x520920 VA: 0x180522320
	public void set_lineSpacing(float value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 4
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x15D7D40 Offset: 0x15D6340 VA: 0x1815D7D40 Slot: 5
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

