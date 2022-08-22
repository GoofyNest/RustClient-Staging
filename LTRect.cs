public class LTRect // TypeDefIndex: 5585
{	// Fields
	public Rect _rect; // 0x10
	public float alpha; // 0x20
	public float rotation; // 0x24
	public Vector2 pivot; // 0x28
	public Vector2 margin; // 0x30
	public Rect relativeRect; // 0x38
	public bool rotateEnabled; // 0x48
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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

	// RVA: 0x21A9BD0 Offset: 0x21A81D0 VA: 0x1821A9BD0
	public void .ctor() { }

	// RVA: 0x21A9B30 Offset: 0x21A8130 VA: 0x1821A9B30
	public void .ctor(Rect rect) { }

	// RVA: 0x21A9A40 Offset: 0x21A8040 VA: 0x1821A9A40
	public void .ctor(float x, float y, float width, float height) { }

	// RVA: 0x21A9810 Offset: 0x21A7E10 VA: 0x1821A9810
	public void .ctor(float x, float y, float width, float height, float alpha) { }

	// RVA: 0x21A9910 Offset: 0x21A7F10 VA: 0x1821A9910
	public void .ctor(float x, float y, float width, float height, float alpha, float rotation) { }

	// RVA: 0x21A9C90 Offset: 0x21A8290 VA: 0x1821A9C90
	public bool get_hasInitiliazed() { }

	// RVA: 0x21A9CB0 Offset: 0x21A82B0 VA: 0x1821A9CB0
	public int get_id() { }

	// RVA: 0x21AA3A0 Offset: 0x21A89A0 VA: 0x1821AA3A0
	public void setId(int id, int counter) { }

	// RVA: 0x21AA2F0 Offset: 0x21A88F0 VA: 0x1821AA2F0
	public void reset() { }

	// RVA: 0x21A9F80 Offset: 0x21A8580 VA: 0x1821A9F80
	public void resetForRotation() { }

	// RVA: 0x21A9F60 Offset: 0x21A8560 VA: 0x1821A9F60
	public float get_x() { }

	// RVA: 0x21AA4A0 Offset: 0x21A8AA0 VA: 0x1821AA4A0
	public void set_x(float value) { }

	// RVA: 0x21A9F70 Offset: 0x21A8570 VA: 0x1821A9F70
	public float get_y() { }

	// RVA: 0x21AA4B0 Offset: 0x21A8AB0 VA: 0x1821AA4B0
	public void set_y(float value) { }

	// RVA: 0x21A9F50 Offset: 0x21A8550 VA: 0x1821A9F50
	public float get_width() { }

	// RVA: 0x21AA490 Offset: 0x21A8A90 VA: 0x1821AA490
	public void set_width(float value) { }

	// RVA: 0x21A9CA0 Offset: 0x21A82A0 VA: 0x1821A9CA0
	public float get_height() { }

	// RVA: 0x21AA480 Offset: 0x21A8A80 VA: 0x1821AA480
	public void set_height(float value) { }

	// RVA: 0x21A9CC0 Offset: 0x21A82C0 VA: 0x1821A9CC0
	public Rect get_rect() { }

	// RVA: 0x1096860 Offset: 0x1094E60 VA: 0x181096860
	public void set_rect(Rect value) { }

	// RVA: 0x21AA3E0 Offset: 0x21A89E0 VA: 0x1821AA3E0
	public LTRect setStyle(GUIStyle style) { }

	// RVA: 0x21AA390 Offset: 0x21A8990 VA: 0x1821AA390
	public LTRect setFontScaleToFit(bool fontScaleToFit) { }

	// RVA: 0x21AA380 Offset: 0x21A8980 VA: 0x1821AA380
	public LTRect setColor(Color color) { }

	// RVA: 0x199E0D0 Offset: 0x199C6D0 VA: 0x18199E0D0
	public LTRect setAlpha(float alpha) { }

	// RVA: 0x21AA3B0 Offset: 0x21A89B0 VA: 0x1821AA3B0
	public LTRect setLabel(string str) { }

	// RVA: 0x21AA470 Offset: 0x21A8A70 VA: 0x1821AA470
	public LTRect setUseSimpleScale(bool useSimpleScale, Rect relativeRect) { }

	// RVA: 0x21AA400 Offset: 0x21A8A00 VA: 0x1821AA400
	public LTRect setUseSimpleScale(bool useSimpleScale) { }

	// RVA: 0x21AA3D0 Offset: 0x21A89D0 VA: 0x1821AA3D0
	public LTRect setSizeByHeight(bool sizeByHeight) { }

	// RVA: 0x21A9420 Offset: 0x21A7A20 VA: 0x1821A9420 Slot: 3
	public override string ToString() { }

}

