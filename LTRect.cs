public class LTRect // TypeDefIndex: 5585
{	// Fields
	public Rect _rect; // 0x10
	public float alpha; // 0x20
	public float rotation; // 0x24
	public Vector2 pivot; // 0x28
	public Vector2 margin; // 0x30
	public Rect relativeRect; // 0x38
	public bool rotateEnabled; // 0x48
	[HideInInspector] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public bool rotateFinished; // 0x49
	public bool alphaEnabled; // 0x4A
	public string labelStr; // 0x50
	public LTGUI.Element_Type type; // 0x58
	public GUIStyle style; // 0x60
	public bool useColor; // 0x68
	public Color color; // 0x6C
	public bool fontScaleToFit; // 0x7C
	public bool useSimpleScale; // 0x7D
	public bool sizeByHeight; // 0x7E
	public Texture texture; // 0x80
	private int _id; // 0x88
	[HideInInspector] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public int counter; // 0x8C
	public static bool colorTouched; // 0x0

	// Properties
	public bool hasInitiliazed { get; }
	public int id { get; }
	public float x { get; set; }
	public float y { get; set; }
	public float width { get; set; }
	public float height { get; set; }
	public Rect rect { get; set; }

	// Methods

	// RVA: 0x21A9AD0 Offset: 0x21A80D0 VA: 0x1821A9AD0
	public void .ctor() { }

	// RVA: 0x21A9A30 Offset: 0x21A8030 VA: 0x1821A9A30
	public void .ctor(Rect rect) { }

	// RVA: 0x21A9940 Offset: 0x21A7F40 VA: 0x1821A9940
	public void .ctor(float x, float y, float width, float height) { }

	// RVA: 0x21A9710 Offset: 0x21A7D10 VA: 0x1821A9710
	public void .ctor(float x, float y, float width, float height, float alpha) { }

	// RVA: 0x21A9810 Offset: 0x21A7E10 VA: 0x1821A9810
	public void .ctor(float x, float y, float width, float height, float alpha, float rotation) { }

	// RVA: 0x21A9B90 Offset: 0x21A8190 VA: 0x1821A9B90
	public bool get_hasInitiliazed() { }

	// RVA: 0x21A9BB0 Offset: 0x21A81B0 VA: 0x1821A9BB0
	public int get_id() { }

	// RVA: 0x21AA2A0 Offset: 0x21A88A0 VA: 0x1821AA2A0
	public void setId(int id, int counter) { }

	// RVA: 0x21AA1F0 Offset: 0x21A87F0 VA: 0x1821AA1F0
	public void reset() { }

	// RVA: 0x21A9E80 Offset: 0x21A8480 VA: 0x1821A9E80
	public void resetForRotation() { }

	// RVA: 0x21A9E60 Offset: 0x21A8460 VA: 0x1821A9E60
	public float get_x() { }

	// RVA: 0x21AA3A0 Offset: 0x21A89A0 VA: 0x1821AA3A0
	public void set_x(float value) { }

	// RVA: 0x21A9E70 Offset: 0x21A8470 VA: 0x1821A9E70
	public float get_y() { }

	// RVA: 0x21AA3B0 Offset: 0x21A89B0 VA: 0x1821AA3B0
	public void set_y(float value) { }

	// RVA: 0x21A9E50 Offset: 0x21A8450 VA: 0x1821A9E50
	public float get_width() { }

	// RVA: 0x21AA390 Offset: 0x21A8990 VA: 0x1821AA390
	public void set_width(float value) { }

	// RVA: 0x21A9BA0 Offset: 0x21A81A0 VA: 0x1821A9BA0
	public float get_height() { }

	// RVA: 0x21AA380 Offset: 0x21A8980 VA: 0x1821AA380
	public void set_height(float value) { }

	// RVA: 0x21A9BC0 Offset: 0x21A81C0 VA: 0x1821A9BC0
	public Rect get_rect() { }

	// RVA: 0x10965A0 Offset: 0x1094BA0 VA: 0x1810965A0
	public void set_rect(Rect value) { }

	// RVA: 0x21AA2E0 Offset: 0x21A88E0 VA: 0x1821AA2E0
	public LTRect setStyle(GUIStyle style) { }

	// RVA: 0x21AA290 Offset: 0x21A8890 VA: 0x1821AA290
	public LTRect setFontScaleToFit(bool fontScaleToFit) { }

	// RVA: 0x21AA280 Offset: 0x21A8880 VA: 0x1821AA280
	public LTRect setColor(Color color) { }

	// RVA: 0x199DE50 Offset: 0x199C450 VA: 0x18199DE50
	public LTRect setAlpha(float alpha) { }

	// RVA: 0x21AA2B0 Offset: 0x21A88B0 VA: 0x1821AA2B0
	public LTRect setLabel(string str) { }

	// RVA: 0x21AA370 Offset: 0x21A8970 VA: 0x1821AA370
	public LTRect setUseSimpleScale(bool useSimpleScale, Rect relativeRect) { }

	// RVA: 0x21AA300 Offset: 0x21A8900 VA: 0x1821AA300
	public LTRect setUseSimpleScale(bool useSimpleScale) { }

	// RVA: 0x21AA2D0 Offset: 0x21A88D0 VA: 0x1821AA2D0
	public LTRect setSizeByHeight(bool sizeByHeight) { }

	// RVA: 0x21A9320 Offset: 0x21A7920 VA: 0x1821A9320 Slot: 3
	public override string ToString() { }

}

