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

	// RVA: 0x21A9910 Offset: 0x21A7F10 VA: 0x1821A9910
	public void .ctor() { }

	// RVA: 0x21A9870 Offset: 0x21A7E70 VA: 0x1821A9870
	public void .ctor(Rect rect) { }

	// RVA: 0x21A9780 Offset: 0x21A7D80 VA: 0x1821A9780
	public void .ctor(float x, float y, float width, float height) { }

	// RVA: 0x21A9550 Offset: 0x21A7B50 VA: 0x1821A9550
	public void .ctor(float x, float y, float width, float height, float alpha) { }

	// RVA: 0x21A9650 Offset: 0x21A7C50 VA: 0x1821A9650
	public void .ctor(float x, float y, float width, float height, float alpha, float rotation) { }

	// RVA: 0x21A99D0 Offset: 0x21A7FD0 VA: 0x1821A99D0
	public bool get_hasInitiliazed() { }

	// RVA: 0x21A99F0 Offset: 0x21A7FF0 VA: 0x1821A99F0
	public int get_id() { }

	// RVA: 0x21AA0E0 Offset: 0x21A86E0 VA: 0x1821AA0E0
	public void setId(int id, int counter) { }

	// RVA: 0x21AA030 Offset: 0x21A8630 VA: 0x1821AA030
	public void reset() { }

	// RVA: 0x21A9CC0 Offset: 0x21A82C0 VA: 0x1821A9CC0
	public void resetForRotation() { }

	// RVA: 0x21A9CA0 Offset: 0x21A82A0 VA: 0x1821A9CA0
	public float get_x() { }

	// RVA: 0x21AA1E0 Offset: 0x21A87E0 VA: 0x1821AA1E0
	public void set_x(float value) { }

	// RVA: 0x21A9CB0 Offset: 0x21A82B0 VA: 0x1821A9CB0
	public float get_y() { }

	// RVA: 0x21AA1F0 Offset: 0x21A87F0 VA: 0x1821AA1F0
	public void set_y(float value) { }

	// RVA: 0x21A9C90 Offset: 0x21A8290 VA: 0x1821A9C90
	public float get_width() { }

	// RVA: 0x21AA1D0 Offset: 0x21A87D0 VA: 0x1821AA1D0
	public void set_width(float value) { }

	// RVA: 0x21A99E0 Offset: 0x21A7FE0 VA: 0x1821A99E0
	public float get_height() { }

	// RVA: 0x21AA1C0 Offset: 0x21A87C0 VA: 0x1821AA1C0
	public void set_height(float value) { }

	// RVA: 0x21A9A00 Offset: 0x21A8000 VA: 0x1821A9A00
	public Rect get_rect() { }

	// RVA: 0x10965A0 Offset: 0x1094BA0 VA: 0x1810965A0
	public void set_rect(Rect value) { }

	// RVA: 0x21AA120 Offset: 0x21A8720 VA: 0x1821AA120
	public LTRect setStyle(GUIStyle style) { }

	// RVA: 0x21AA0D0 Offset: 0x21A86D0 VA: 0x1821AA0D0
	public LTRect setFontScaleToFit(bool fontScaleToFit) { }

	// RVA: 0x21AA0C0 Offset: 0x21A86C0 VA: 0x1821AA0C0
	public LTRect setColor(Color color) { }

	// RVA: 0x199DE10 Offset: 0x199C410 VA: 0x18199DE10
	public LTRect setAlpha(float alpha) { }

	// RVA: 0x21AA0F0 Offset: 0x21A86F0 VA: 0x1821AA0F0
	public LTRect setLabel(string str) { }

	// RVA: 0x21AA1B0 Offset: 0x21A87B0 VA: 0x1821AA1B0
	public LTRect setUseSimpleScale(bool useSimpleScale, Rect relativeRect) { }

	// RVA: 0x21AA140 Offset: 0x21A8740 VA: 0x1821AA140
	public LTRect setUseSimpleScale(bool useSimpleScale) { }

	// RVA: 0x21AA110 Offset: 0x21A8710 VA: 0x1821AA110
	public LTRect setSizeByHeight(bool sizeByHeight) { }

	// RVA: 0x21A9160 Offset: 0x21A7760 VA: 0x1821A9160 Slot: 3
	public override string ToString() { }

}

