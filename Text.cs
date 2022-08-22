public class Text : MaskableGraphic, ILayoutElement // TypeDefIndex: 5014
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private FontData m_FontData; // 0xC8
	[TextAreaAttribute] // RVA: 0x7DA90 Offset: 0x7CE90 VA: 0x18007DA90
	[SerializeField] // RVA: 0x7DA90 Offset: 0x7CE90 VA: 0x18007DA90
	protected string m_Text; // 0xD0
	private TextGenerator m_TextCache; // 0xD8
	private TextGenerator m_TextCacheForLayout; // 0xE0
	protected static Material s_DefaultText; // 0x0
	protected bool m_DisableFontTextureRebuiltCallback; // 0xE8
	private readonly UIVertex[] m_TempVerts; // 0xF0

	// Properties
	public TextGenerator cachedTextGenerator { get; }
	public TextGenerator cachedTextGeneratorForLayout { get; }
	public override Texture mainTexture { get; }
	public Font font { get; set; }
	public virtual string text { get; set; }
	public bool supportRichText { get; set; }
	public bool resizeTextForBestFit { get; set; }
	public int resizeTextMinSize { get; set; }
	public int resizeTextMaxSize { get; set; }
	public TextAnchor alignment { get; set; }
	public bool alignByGeometry { get; set; }
	public int fontSize { get; set; }
	public HorizontalWrapMode horizontalOverflow { get; set; }
	public VerticalWrapMode verticalOverflow { get; set; }
	public float lineSpacing { get; set; }
	public FontStyle fontStyle { get; set; }
	public float pixelsPerUnit { get; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }

	// Methods

	// RVA: 0x2245F10 Offset: 0x2244510 VA: 0x182245F10
	protected void .ctor() { }

	// RVA: 0x2246070 Offset: 0x2244670 VA: 0x182246070
	public TextGenerator get_cachedTextGenerator() { }

	// RVA: 0x2245FF0 Offset: 0x22445F0 VA: 0x182245FF0
	public TextGenerator get_cachedTextGeneratorForLayout() { }

	// RVA: 0x22461B0 Offset: 0x22447B0 VA: 0x1822461B0 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0x22451A0 Offset: 0x22437A0 VA: 0x1822451A0
	public void FontTextureChanged() { }

	// RVA: 0x2246150 Offset: 0x2244750 VA: 0x182246150
	public Font get_font() { }

	// RVA: 0x22469D0 Offset: 0x2244FD0 VA: 0x1822469D0
	public void set_font(Font value) { }

	// RVA: 0xC73A80 Offset: 0xC72080 VA: 0x180C73A80 Slot: 72
	public virtual string get_text() { }

	// RVA: 0x2246D00 Offset: 0x2245300 VA: 0x182246D00 Slot: 73
	public virtual void set_text(string value) { }

	// RVA: 0x2246830 Offset: 0x2244E30 VA: 0x182246830
	public bool get_supportRichText() { }

	// RVA: 0x2246CA0 Offset: 0x22452A0 VA: 0x182246CA0
	public void set_supportRichText(bool value) { }

	// RVA: 0x22467D0 Offset: 0x2244DD0 VA: 0x1822467D0
	public bool get_resizeTextForBestFit() { }

	// RVA: 0x2246B80 Offset: 0x2245180 VA: 0x182246B80
	public void set_resizeTextForBestFit(bool value) { }

	// RVA: 0x2246810 Offset: 0x2244E10 VA: 0x182246810
	public int get_resizeTextMinSize() { }

	// RVA: 0x2246C40 Offset: 0x2245240 VA: 0x182246C40
	public void set_resizeTextMinSize(int value) { }

	// RVA: 0x22467F0 Offset: 0x2244DF0 VA: 0x1822467F0
	public int get_resizeTextMaxSize() { }

	// RVA: 0x2246BE0 Offset: 0x22451E0 VA: 0x182246BE0
	public void set_resizeTextMaxSize(int value) { }

	// RVA: 0x2245FD0 Offset: 0x22445D0 VA: 0x182245FD0
	public TextAnchor get_alignment() { }

	// RVA: 0x22468B0 Offset: 0x2244EB0 VA: 0x1822468B0
	public void set_alignment(TextAnchor value) { }

	// RVA: 0x2245FB0 Offset: 0x22445B0 VA: 0x182245FB0
	public bool get_alignByGeometry() { }

	// RVA: 0x2246870 Offset: 0x2244E70 VA: 0x182246870
	public void set_alignByGeometry(bool value) { }

	// RVA: 0x2246110 Offset: 0x2244710 VA: 0x182246110
	public int get_fontSize() { }

	// RVA: 0x2246910 Offset: 0x2244F10 VA: 0x182246910
	public void set_fontSize(int value) { }

	// RVA: 0x2246170 Offset: 0x2244770 VA: 0x182246170
	public HorizontalWrapMode get_horizontalOverflow() { }

	// RVA: 0x2246AC0 Offset: 0x22450C0 VA: 0x182246AC0
	public void set_horizontalOverflow(HorizontalWrapMode value) { }

	// RVA: 0x2246850 Offset: 0x2244E50 VA: 0x182246850
	public VerticalWrapMode get_verticalOverflow() { }

	// RVA: 0x2246DF0 Offset: 0x22453F0 VA: 0x182246DF0
	public void set_verticalOverflow(VerticalWrapMode value) { }

	// RVA: 0x2246190 Offset: 0x2244790 VA: 0x182246190
	public float get_lineSpacing() { }

	// RVA: 0x2246B20 Offset: 0x2245120 VA: 0x182246B20
	public void set_lineSpacing(float value) { }

	// RVA: 0x2246130 Offset: 0x2244730 VA: 0x182246130
	public FontStyle get_fontStyle() { }

	// RVA: 0x2246970 Offset: 0x2244F70 VA: 0x182246970
	public void set_fontStyle(FontStyle value) { }

	// RVA: 0x22463D0 Offset: 0x22449D0 VA: 0x1822463D0
	public float get_pixelsPerUnit() { }

	// RVA: 0x2245700 Offset: 0x2243D00 VA: 0x182245700 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x22456A0 Offset: 0x2243CA0 VA: 0x1822456A0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2245E80 Offset: 0x2244480 VA: 0x182245E80 Slot: 41
	protected override void UpdateGeometry() { }

	// RVA: 0x2245080 Offset: 0x2243680 VA: 0x182245080
	internal void AssignDefaultFont() { }

	// RVA: 0x22452D0 Offset: 0x22438D0 VA: 0x1822452D0
	public TextGenerationSettings GetGenerationSettings(Vector2 extents) { }

	// RVA: 0x2245520 Offset: 0x2243B20 VA: 0x182245520
	public static Vector2 GetTextAnchorPivot(TextAnchor anchor) { }

	// RVA: 0x2245780 Offset: 0x2243D80 VA: 0x182245780 Slot: 44
	protected override void OnPopulateMesh(VertexHelper toFill) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 74
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 75
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 76
	public virtual float get_minWidth() { }

	// RVA: 0x22466A0 Offset: 0x2244CA0 VA: 0x1822466A0 Slot: 77
	public virtual float get_preferredWidth() { }

	// RVA: 0xC82E90 Offset: 0xC81490 VA: 0x180C82E90 Slot: 78
	public virtual float get_flexibleWidth() { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 79
	public virtual float get_minHeight() { }

	// RVA: 0x2246550 Offset: 0x2244B50 VA: 0x182246550 Slot: 80
	public virtual float get_preferredHeight() { }

	// RVA: 0xC82E90 Offset: 0xC81490 VA: 0x180C82E90 Slot: 81
	public virtual float get_flexibleHeight() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 82
	public virtual int get_layoutPriority() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

