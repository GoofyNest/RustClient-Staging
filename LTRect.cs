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

	// RVA: 0x21AA3F0 Offset: 0x21A89F0 VA: 0x1821AA3F0
	public void .ctor() { }

	// RVA: 0x21AA350 Offset: 0x21A8950 VA: 0x1821AA350
	public void .ctor(Rect rect) { }

	// RVA: 0x21AA260 Offset: 0x21A8860 VA: 0x1821AA260
	public void .ctor(float x, float y, float width, float height) { }

	// RVA: 0x21AA030 Offset: 0x21A8630 VA: 0x1821AA030
	public void .ctor(float x, float y, float width, float height, float alpha) { }

	// RVA: 0x21AA130 Offset: 0x21A8730 VA: 0x1821AA130
	public void .ctor(float x, float y, float width, float height, float alpha, float rotation) { }

	// RVA: 0x21AA4B0 Offset: 0x21A8AB0 VA: 0x1821AA4B0
	public bool get_hasInitiliazed() { }

	// RVA: 0x21AA4D0 Offset: 0x21A8AD0 VA: 0x1821AA4D0
	public int get_id() { }

	// RVA: 0x21AABC0 Offset: 0x21A91C0 VA: 0x1821AABC0
	public void setId(int id, int counter) { }

	// RVA: 0x21AAB10 Offset: 0x21A9110 VA: 0x1821AAB10
	public void reset() { }

	// RVA: 0x21AA7A0 Offset: 0x21A8DA0 VA: 0x1821AA7A0
	public void resetForRotation() { }

	// RVA: 0x21AA780 Offset: 0x21A8D80 VA: 0x1821AA780
	public float get_x() { }

	// RVA: 0x21AACC0 Offset: 0x21A92C0 VA: 0x1821AACC0
	public void set_x(float value) { }

	// RVA: 0x21AA790 Offset: 0x21A8D90 VA: 0x1821AA790
	public float get_y() { }

	// RVA: 0x21AACD0 Offset: 0x21A92D0 VA: 0x1821AACD0
	public void set_y(float value) { }

	// RVA: 0x21AA770 Offset: 0x21A8D70 VA: 0x1821AA770
	public float get_width() { }

	// RVA: 0x21AACB0 Offset: 0x21A92B0 VA: 0x1821AACB0
	public void set_width(float value) { }

	// RVA: 0x21AA4C0 Offset: 0x21A8AC0 VA: 0x1821AA4C0
	public float get_height() { }

	// RVA: 0x21AACA0 Offset: 0x21A92A0 VA: 0x1821AACA0
	public void set_height(float value) { }

	// RVA: 0x21AA4E0 Offset: 0x21A8AE0 VA: 0x1821AA4E0
	public Rect get_rect() { }

	// RVA: 0x10972D0 Offset: 0x10958D0 VA: 0x1810972D0
	public void set_rect(Rect value) { }

	// RVA: 0x21AAC00 Offset: 0x21A9200 VA: 0x1821AAC00
	public LTRect setStyle(GUIStyle style) { }

	// RVA: 0x21AABB0 Offset: 0x21A91B0 VA: 0x1821AABB0
	public LTRect setFontScaleToFit(bool fontScaleToFit) { }

	// RVA: 0x21AABA0 Offset: 0x21A91A0 VA: 0x1821AABA0
	public LTRect setColor(Color color) { }

	// RVA: 0x198B4D0 Offset: 0x1989AD0 VA: 0x18198B4D0
	public LTRect setAlpha(float alpha) { }

	// RVA: 0x21AABD0 Offset: 0x21A91D0 VA: 0x1821AABD0
	public LTRect setLabel(string str) { }

	// RVA: 0x21AAC90 Offset: 0x21A9290 VA: 0x1821AAC90
	public LTRect setUseSimpleScale(bool useSimpleScale, Rect relativeRect) { }

	// RVA: 0x21AAC20 Offset: 0x21A9220 VA: 0x1821AAC20
	public LTRect setUseSimpleScale(bool useSimpleScale) { }

	// RVA: 0x21AABF0 Offset: 0x21A91F0 VA: 0x1821AABF0
	public LTRect setSizeByHeight(bool sizeByHeight) { }

	// RVA: 0x21A9C40 Offset: 0x21A8240 VA: 0x1821A9C40 Slot: 3
	public override string ToString() { }

}

