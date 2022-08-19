public struct Color : IEquatable<Color> // TypeDefIndex: 3460
{	// Fields
	public float r; // 0x0
	public float g; // 0x4
	public float b; // 0x8
	public float a; // 0xC

	// Properties
	public static Color red { get; }
	public static Color green { get; }
	public static Color blue { get; }
	public static Color white { get; }
	public static Color black { get; }
	public static Color yellow { get; }
	public static Color cyan { get; }
	public static Color magenta { get; }
	public static Color gray { get; }
	public static Color grey { get; }
	public static Color clear { get; }
	public float grayscale { get; }
	public Color linear { get; }
	public Color gamma { get; }
	public float maxColorComponent { get; }
	public float Item { get; }

	// Methods

	// RVA: 0xF2B40 Offset: 0xF1F40 VA: 0x1800F2B40
	public void .ctor(float r, float g, float b, float a) { }

	// RVA: 0x213180 Offset: 0x212580 VA: 0x180213180
	public void .ctor(float r, float g, float b) { }

	// RVA: 0x213170 Offset: 0x212570 VA: 0x180213170 Slot: 3
	public override string ToString() { }

	// RVA: 0x2130D0 Offset: 0x2124D0 VA: 0x1802130D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x212F80 Offset: 0x212380 VA: 0x180212F80 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x213060 Offset: 0x212460 VA: 0x180213060 Slot: 4
	public bool Equals(Color other) { }

	// RVA: 0x1824A60 Offset: 0x1823060 VA: 0x181824A60
	public static Color op_Addition(Color a, Color b) { }

	// RVA: 0x1824E50 Offset: 0x1823450 VA: 0x181824E50
	public static Color op_Subtraction(Color a, Color b) { }

	// RVA: 0x1824DC0 Offset: 0x18233C0 VA: 0x181824DC0
	public static Color op_Multiply(Color a, Color b) { }

	// RVA: 0x1824E10 Offset: 0x1823410 VA: 0x181824E10
	public static Color op_Multiply(Color a, float b) { }

	// RVA: 0x1824D80 Offset: 0x1823380 VA: 0x181824D80
	public static Color op_Multiply(float b, Color a) { }

	// RVA: 0x1824AB0 Offset: 0x18230B0 VA: 0x181824AB0
	public static Color op_Division(Color a, float b) { }

	// RVA: 0x1824AD0 Offset: 0x18230D0 VA: 0x181824AD0
	public static bool op_Equality(Color lhs, Color rhs) { }

	// RVA: 0x1824C60 Offset: 0x1823260 VA: 0x181824C60
	public static bool op_Inequality(Color lhs, Color rhs) { }

	// RVA: 0x1824270 Offset: 0x1822870 VA: 0x181824270
	public static Color Lerp(Color a, Color b, float t) { }

	// RVA: 0x213130 Offset: 0x212530 VA: 0x180213130
	internal Color RGBMultiplied(float multiplier) { }

	// RVA: 0x1824A00 Offset: 0x1823000 VA: 0x181824A00
	public static Color get_red() { }

	// RVA: 0x1824880 Offset: 0x1822E80 VA: 0x181824880
	public static Color get_green() { }

	// RVA: 0x1824710 Offset: 0x1822D10 VA: 0x181824710
	public static Color get_blue() { }

	// RVA: 0x1824A20 Offset: 0x1823020 VA: 0x181824A20
	public static Color get_white() { }

	// RVA: 0x18246F0 Offset: 0x1822CF0 VA: 0x1818246F0
	public static Color get_black() { }

	// RVA: 0x1824A40 Offset: 0x1823040 VA: 0x181824A40
	public static Color get_yellow() { }

	// RVA: 0x1824740 Offset: 0x1822D40 VA: 0x181824740
	public static Color get_cyan() { }

	// RVA: 0x1824960 Offset: 0x1822F60 VA: 0x181824960
	public static Color get_magenta() { }

	// RVA: 0x1824820 Offset: 0x1822E20 VA: 0x181824820
	public static Color get_gray() { }

	// RVA: 0x1824820 Offset: 0x1822E20 VA: 0x181824820
	public static Color get_grey() { }

	// RVA: 0x1824730 Offset: 0x1822D30 VA: 0x181824730
	public static Color get_clear() { }

	// RVA: 0x213350 Offset: 0x212750 VA: 0x180213350
	public float get_grayscale() { }

	// RVA: 0x213390 Offset: 0x212790 VA: 0x180213390
	public Color get_linear() { }

	// RVA: 0x213290 Offset: 0x212690 VA: 0x180213290
	public Color get_gamma() { }

	// RVA: 0x2133B0 Offset: 0x2127B0 VA: 0x1802133B0
	public float get_maxColorComponent() { }

	// RVA: 0x1824C00 Offset: 0x1823200 VA: 0x181824C00
	public static Vector4 op_Implicit(Color c) { }

	// RVA: 0x1824BC0 Offset: 0x18231C0 VA: 0x181824BC0
	public static Color op_Implicit(Vector4 v) { }

	// RVA: 0x2131A0 Offset: 0x2125A0 VA: 0x1802131A0
	public float get_Item(int index) { }

	// RVA: 0x1823F50 Offset: 0x1822550 VA: 0x181823F50
	public static Color HSVToRGB(float H, float S, float V, bool hdr) { }

}

public struct Color // TypeDefIndex: 5552
{	// Fields
	public byte r; // 0x0
	public byte g; // 0x1
	public byte b; // 0x2
	public byte a; // 0x3

}

