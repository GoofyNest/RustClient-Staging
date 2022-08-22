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

	// RVA: 0x22461D0 Offset: 0x22447D0 VA: 0x1822461D0
	protected void .ctor() { }

	// RVA: 0x2246330 Offset: 0x2244930 VA: 0x182246330
	public TextGenerator get_cachedTextGenerator() { }

	// RVA: 0x22462B0 Offset: 0x22448B0 VA: 0x1822462B0
	public TextGenerator get_cachedTextGeneratorForLayout() { }

	// RVA: 0x2246470 Offset: 0x2244A70 VA: 0x182246470 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0x2245460 Offset: 0x2243A60 VA: 0x182245460
	public void FontTextureChanged() { }

	// RVA: 0x2246410 Offset: 0x2244A10 VA: 0x182246410
	public Font get_font() { }

	// RVA: 0x2246C90 Offset: 0x2245290 VA: 0x182246C90
	public void set_font(Font value) { }

	// RVA: 0xC73D40 Offset: 0xC72340 VA: 0x180C73D40 Slot: 72
	public virtual string get_text() { }

	// RVA: 0x2246FC0 Offset: 0x22455C0 VA: 0x182246FC0 Slot: 73
	public virtual void set_text(string value) { }

	// RVA: 0x2246AF0 Offset: 0x22450F0 VA: 0x182246AF0
	public bool get_supportRichText() { }

	// RVA: 0x2246F60 Offset: 0x2245560 VA: 0x182246F60
	public void set_supportRichText(bool value) { }

	// RVA: 0x2246A90 Offset: 0x2245090 VA: 0x182246A90
	public bool get_resizeTextForBestFit() { }

	// RVA: 0x2246E40 Offset: 0x2245440 VA: 0x182246E40
	public void set_resizeTextForBestFit(bool value) { }

	// RVA: 0x2246AD0 Offset: 0x22450D0 VA: 0x182246AD0
	public int get_resizeTextMinSize() { }

	// RVA: 0x2246F00 Offset: 0x2245500 VA: 0x182246F00
	public void set_resizeTextMinSize(int value) { }

	// RVA: 0x2246AB0 Offset: 0x22450B0 VA: 0x182246AB0
	public int get_resizeTextMaxSize() { }

	// RVA: 0x2246EA0 Offset: 0x22454A0 VA: 0x182246EA0
	public void set_resizeTextMaxSize(int value) { }

	// RVA: 0x2246290 Offset: 0x2244890 VA: 0x182246290
	public TextAnchor get_alignment() { }

	// RVA: 0x2246B70 Offset: 0x2245170 VA: 0x182246B70
	public void set_alignment(TextAnchor value) { }

	// RVA: 0x2246270 Offset: 0x2244870 VA: 0x182246270
	public bool get_alignByGeometry() { }

	// RVA: 0x2246B30 Offset: 0x2245130 VA: 0x182246B30
	public void set_alignByGeometry(bool value) { }

	// RVA: 0x22463D0 Offset: 0x22449D0 VA: 0x1822463D0
	public int get_fontSize() { }

	// RVA: 0x2246BD0 Offset: 0x22451D0 VA: 0x182246BD0
	public void set_fontSize(int value) { }

	// RVA: 0x2246430 Offset: 0x2244A30 VA: 0x182246430
	public HorizontalWrapMode get_horizontalOverflow() { }

	// RVA: 0x2246D80 Offset: 0x2245380 VA: 0x182246D80
	public void set_horizontalOverflow(HorizontalWrapMode value) { }

	// RVA: 0x2246B10 Offset: 0x2245110 VA: 0x182246B10
	public VerticalWrapMode get_verticalOverflow() { }

	// RVA: 0x22470B0 Offset: 0x22456B0 VA: 0x1822470B0
	public void set_verticalOverflow(VerticalWrapMode value) { }

	// RVA: 0x2246450 Offset: 0x2244A50 VA: 0x182246450
	public float get_lineSpacing() { }

	// RVA: 0x2246DE0 Offset: 0x22453E0 VA: 0x182246DE0
	public void set_lineSpacing(float value) { }

	// RVA: 0x22463F0 Offset: 0x22449F0 VA: 0x1822463F0
	public FontStyle get_fontStyle() { }

	// RVA: 0x2246C30 Offset: 0x2245230 VA: 0x182246C30
	public void set_fontStyle(FontStyle value) { }

	// RVA: 0x2246690 Offset: 0x2244C90 VA: 0x182246690
	public float get_pixelsPerUnit() { }

	// RVA: 0x22459C0 Offset: 0x2243FC0 VA: 0x1822459C0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2245960 Offset: 0x2243F60 VA: 0x182245960 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2246140 Offset: 0x2244740 VA: 0x182246140 Slot: 41
	protected override void UpdateGeometry() { }

	// RVA: 0x2245340 Offset: 0x2243940 VA: 0x182245340
	internal void AssignDefaultFont() { }

	// RVA: 0x2245590 Offset: 0x2243B90 VA: 0x182245590
	public TextGenerationSettings GetGenerationSettings(Vector2 extents) { }

	// RVA: 0x22457E0 Offset: 0x2243DE0 VA: 0x1822457E0
	public static Vector2 GetTextAnchorPivot(TextAnchor anchor) { }

	// RVA: 0x2245A40 Offset: 0x2244040 VA: 0x182245A40 Slot: 44
	protected override void OnPopulateMesh(VertexHelper toFill) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 74
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 75
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 76
	public virtual float get_minWidth() { }

	// RVA: 0x2246960 Offset: 0x2244F60 VA: 0x182246960 Slot: 77
	public virtual float get_preferredWidth() { }

	// RVA: 0xC83150 Offset: 0xC81750 VA: 0x180C83150 Slot: 78
	public virtual float get_flexibleWidth() { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 79
	public virtual float get_minHeight() { }

	// RVA: 0x2246810 Offset: 0x2244E10 VA: 0x182246810 Slot: 80
	public virtual float get_preferredHeight() { }

	// RVA: 0xC83150 Offset: 0xC81750 VA: 0x180C83150 Slot: 81
	public virtual float get_flexibleHeight() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 82
	public virtual int get_layoutPriority() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

