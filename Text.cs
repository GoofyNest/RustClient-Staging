public class Text : MaskableGraphic, ILayoutElement // TypeDefIndex: 5014
{	// Fields
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private FontData m_FontData; // 0xC8
	[TextAreaAttribute] // RVA: 0x7D9C0 Offset: 0x7CDC0 VA: 0x18007D9C0
	[SerializeField] // RVA: 0x7D9C0 Offset: 0x7CDC0 VA: 0x18007D9C0
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

	// RVA: 0x22460D0 Offset: 0x22446D0 VA: 0x1822460D0
	protected void .ctor() { }

	// RVA: 0x2246230 Offset: 0x2244830 VA: 0x182246230
	public TextGenerator get_cachedTextGenerator() { }

	// RVA: 0x22461B0 Offset: 0x22447B0 VA: 0x1822461B0
	public TextGenerator get_cachedTextGeneratorForLayout() { }

	// RVA: 0x2246370 Offset: 0x2244970 VA: 0x182246370 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0x2245360 Offset: 0x2243960 VA: 0x182245360
	public void FontTextureChanged() { }

	// RVA: 0x2246310 Offset: 0x2244910 VA: 0x182246310
	public Font get_font() { }

	// RVA: 0x2246B90 Offset: 0x2245190 VA: 0x182246B90
	public void set_font(Font value) { }

	// RVA: 0xC73A80 Offset: 0xC72080 VA: 0x180C73A80 Slot: 72
	public virtual string get_text() { }

	// RVA: 0x2246EC0 Offset: 0x22454C0 VA: 0x182246EC0 Slot: 73
	public virtual void set_text(string value) { }

	// RVA: 0x22469F0 Offset: 0x2244FF0 VA: 0x1822469F0
	public bool get_supportRichText() { }

	// RVA: 0x2246E60 Offset: 0x2245460 VA: 0x182246E60
	public void set_supportRichText(bool value) { }

	// RVA: 0x2246990 Offset: 0x2244F90 VA: 0x182246990
	public bool get_resizeTextForBestFit() { }

	// RVA: 0x2246D40 Offset: 0x2245340 VA: 0x182246D40
	public void set_resizeTextForBestFit(bool value) { }

	// RVA: 0x22469D0 Offset: 0x2244FD0 VA: 0x1822469D0
	public int get_resizeTextMinSize() { }

	// RVA: 0x2246E00 Offset: 0x2245400 VA: 0x182246E00
	public void set_resizeTextMinSize(int value) { }

	// RVA: 0x22469B0 Offset: 0x2244FB0 VA: 0x1822469B0
	public int get_resizeTextMaxSize() { }

	// RVA: 0x2246DA0 Offset: 0x22453A0 VA: 0x182246DA0
	public void set_resizeTextMaxSize(int value) { }

	// RVA: 0x2246190 Offset: 0x2244790 VA: 0x182246190
	public TextAnchor get_alignment() { }

	// RVA: 0x2246A70 Offset: 0x2245070 VA: 0x182246A70
	public void set_alignment(TextAnchor value) { }

	// RVA: 0x2246170 Offset: 0x2244770 VA: 0x182246170
	public bool get_alignByGeometry() { }

	// RVA: 0x2246A30 Offset: 0x2245030 VA: 0x182246A30
	public void set_alignByGeometry(bool value) { }

	// RVA: 0x22462D0 Offset: 0x22448D0 VA: 0x1822462D0
	public int get_fontSize() { }

	// RVA: 0x2246AD0 Offset: 0x22450D0 VA: 0x182246AD0
	public void set_fontSize(int value) { }

	// RVA: 0x2246330 Offset: 0x2244930 VA: 0x182246330
	public HorizontalWrapMode get_horizontalOverflow() { }

	// RVA: 0x2246C80 Offset: 0x2245280 VA: 0x182246C80
	public void set_horizontalOverflow(HorizontalWrapMode value) { }

	// RVA: 0x2246A10 Offset: 0x2245010 VA: 0x182246A10
	public VerticalWrapMode get_verticalOverflow() { }

	// RVA: 0x2246FB0 Offset: 0x22455B0 VA: 0x182246FB0
	public void set_verticalOverflow(VerticalWrapMode value) { }

	// RVA: 0x2246350 Offset: 0x2244950 VA: 0x182246350
	public float get_lineSpacing() { }

	// RVA: 0x2246CE0 Offset: 0x22452E0 VA: 0x182246CE0
	public void set_lineSpacing(float value) { }

	// RVA: 0x22462F0 Offset: 0x22448F0 VA: 0x1822462F0
	public FontStyle get_fontStyle() { }

	// RVA: 0x2246B30 Offset: 0x2245130 VA: 0x182246B30
	public void set_fontStyle(FontStyle value) { }

	// RVA: 0x2246590 Offset: 0x2244B90 VA: 0x182246590
	public float get_pixelsPerUnit() { }

	// RVA: 0x22458C0 Offset: 0x2243EC0 VA: 0x1822458C0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2245860 Offset: 0x2243E60 VA: 0x182245860 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2246040 Offset: 0x2244640 VA: 0x182246040 Slot: 41
	protected override void UpdateGeometry() { }

	// RVA: 0x2245240 Offset: 0x2243840 VA: 0x182245240
	internal void AssignDefaultFont() { }

	// RVA: 0x2245490 Offset: 0x2243A90 VA: 0x182245490
	public TextGenerationSettings GetGenerationSettings(Vector2 extents) { }

	// RVA: 0x22456E0 Offset: 0x2243CE0 VA: 0x1822456E0
	public static Vector2 GetTextAnchorPivot(TextAnchor anchor) { }

	// RVA: 0x2245940 Offset: 0x2243F40 VA: 0x182245940 Slot: 44
	protected override void OnPopulateMesh(VertexHelper toFill) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 74
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 75
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 76
	public virtual float get_minWidth() { }

	// RVA: 0x2246860 Offset: 0x2244E60 VA: 0x182246860 Slot: 77
	public virtual float get_preferredWidth() { }

	// RVA: 0xC82E90 Offset: 0xC81490 VA: 0x180C82E90 Slot: 78
	public virtual float get_flexibleWidth() { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 79
	public virtual float get_minHeight() { }

	// RVA: 0x2246710 Offset: 0x2244D10 VA: 0x182246710 Slot: 80
	public virtual float get_preferredHeight() { }

	// RVA: 0xC82E90 Offset: 0xC81490 VA: 0x180C82E90 Slot: 81
	public virtual float get_flexibleHeight() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 82
	public virtual int get_layoutPriority() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

