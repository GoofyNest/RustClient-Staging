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

	// RVA: 0x22469F0 Offset: 0x2244FF0 VA: 0x1822469F0
	protected void .ctor() { }

	// RVA: 0x2246B50 Offset: 0x2245150 VA: 0x182246B50
	public TextGenerator get_cachedTextGenerator() { }

	// RVA: 0x2246AD0 Offset: 0x22450D0 VA: 0x182246AD0
	public TextGenerator get_cachedTextGeneratorForLayout() { }

	// RVA: 0x2246C90 Offset: 0x2245290 VA: 0x182246C90 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0x2245C80 Offset: 0x2244280 VA: 0x182245C80
	public void FontTextureChanged() { }

	// RVA: 0x2246C30 Offset: 0x2245230 VA: 0x182246C30
	public Font get_font() { }

	// RVA: 0x22474B0 Offset: 0x2245AB0 VA: 0x1822474B0
	public void set_font(Font value) { }

	// RVA: 0x79BDF0 Offset: 0x79A3F0 VA: 0x18079BDF0 Slot: 72
	public virtual string get_text() { }

	// RVA: 0x22477E0 Offset: 0x2245DE0 VA: 0x1822477E0 Slot: 73
	public virtual void set_text(string value) { }

	// RVA: 0x2247310 Offset: 0x2245910 VA: 0x182247310
	public bool get_supportRichText() { }

	// RVA: 0x2247780 Offset: 0x2245D80 VA: 0x182247780
	public void set_supportRichText(bool value) { }

	// RVA: 0x22472B0 Offset: 0x22458B0 VA: 0x1822472B0
	public bool get_resizeTextForBestFit() { }

	// RVA: 0x2247660 Offset: 0x2245C60 VA: 0x182247660
	public void set_resizeTextForBestFit(bool value) { }

	// RVA: 0x22472F0 Offset: 0x22458F0 VA: 0x1822472F0
	public int get_resizeTextMinSize() { }

	// RVA: 0x2247720 Offset: 0x2245D20 VA: 0x182247720
	public void set_resizeTextMinSize(int value) { }

	// RVA: 0x22472D0 Offset: 0x22458D0 VA: 0x1822472D0
	public int get_resizeTextMaxSize() { }

	// RVA: 0x22476C0 Offset: 0x2245CC0 VA: 0x1822476C0
	public void set_resizeTextMaxSize(int value) { }

	// RVA: 0x2246AB0 Offset: 0x22450B0 VA: 0x182246AB0
	public TextAnchor get_alignment() { }

	// RVA: 0x2247390 Offset: 0x2245990 VA: 0x182247390
	public void set_alignment(TextAnchor value) { }

	// RVA: 0x2246A90 Offset: 0x2245090 VA: 0x182246A90
	public bool get_alignByGeometry() { }

	// RVA: 0x2247350 Offset: 0x2245950 VA: 0x182247350
	public void set_alignByGeometry(bool value) { }

	// RVA: 0x2246BF0 Offset: 0x22451F0 VA: 0x182246BF0
	public int get_fontSize() { }

	// RVA: 0x22473F0 Offset: 0x22459F0 VA: 0x1822473F0
	public void set_fontSize(int value) { }

	// RVA: 0x2246C50 Offset: 0x2245250 VA: 0x182246C50
	public HorizontalWrapMode get_horizontalOverflow() { }

	// RVA: 0x22475A0 Offset: 0x2245BA0 VA: 0x1822475A0
	public void set_horizontalOverflow(HorizontalWrapMode value) { }

	// RVA: 0x2247330 Offset: 0x2245930 VA: 0x182247330
	public VerticalWrapMode get_verticalOverflow() { }

	// RVA: 0x22478D0 Offset: 0x2245ED0 VA: 0x1822478D0
	public void set_verticalOverflow(VerticalWrapMode value) { }

	// RVA: 0x2246C70 Offset: 0x2245270 VA: 0x182246C70
	public float get_lineSpacing() { }

	// RVA: 0x2247600 Offset: 0x2245C00 VA: 0x182247600
	public void set_lineSpacing(float value) { }

	// RVA: 0x2246C10 Offset: 0x2245210 VA: 0x182246C10
	public FontStyle get_fontStyle() { }

	// RVA: 0x2247450 Offset: 0x2245A50 VA: 0x182247450
	public void set_fontStyle(FontStyle value) { }

	// RVA: 0x2246EB0 Offset: 0x22454B0 VA: 0x182246EB0
	public float get_pixelsPerUnit() { }

	// RVA: 0x22461E0 Offset: 0x22447E0 VA: 0x1822461E0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2246180 Offset: 0x2244780 VA: 0x182246180 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2246960 Offset: 0x2244F60 VA: 0x182246960 Slot: 41
	protected override void UpdateGeometry() { }

	// RVA: 0x2245B60 Offset: 0x2244160 VA: 0x182245B60
	internal void AssignDefaultFont() { }

	// RVA: 0x2245DB0 Offset: 0x22443B0 VA: 0x182245DB0
	public TextGenerationSettings GetGenerationSettings(Vector2 extents) { }

	// RVA: 0x2246000 Offset: 0x2244600 VA: 0x182246000
	public static Vector2 GetTextAnchorPivot(TextAnchor anchor) { }

	// RVA: 0x2246260 Offset: 0x2244860 VA: 0x182246260 Slot: 44
	protected override void OnPopulateMesh(VertexHelper toFill) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 74
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 75
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x568670 Offset: 0x566C70 VA: 0x180568670 Slot: 76
	public virtual float get_minWidth() { }

	// RVA: 0x2247180 Offset: 0x2245780 VA: 0x182247180 Slot: 77
	public virtual float get_preferredWidth() { }

	// RVA: 0xC835F0 Offset: 0xC81BF0 VA: 0x180C835F0 Slot: 78
	public virtual float get_flexibleWidth() { }

	// RVA: 0x568670 Offset: 0x566C70 VA: 0x180568670 Slot: 79
	public virtual float get_minHeight() { }

	// RVA: 0x2247030 Offset: 0x2245630 VA: 0x182247030 Slot: 80
	public virtual float get_preferredHeight() { }

	// RVA: 0xC835F0 Offset: 0xC81BF0 VA: 0x180C835F0 Slot: 81
	public virtual float get_flexibleHeight() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 82
	public virtual int get_layoutPriority() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

