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

	// RVA: 0xF2AC0 Offset: 0xF1EC0 VA: 0x1800F2AC0
	public void .ctor(float r, float g, float b, float a) { }

	// RVA: 0x213100 Offset: 0x212500 VA: 0x180213100
	public void .ctor(float r, float g, float b) { }

	// RVA: 0x2130F0 Offset: 0x2124F0 VA: 0x1802130F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x213050 Offset: 0x212450 VA: 0x180213050 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x212F00 Offset: 0x212300 VA: 0x180212F00 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x212FE0 Offset: 0x2123E0 VA: 0x180212FE0 Slot: 4
	public bool Equals(Color other) { }

	// RVA: 0x1824D20 Offset: 0x1823320 VA: 0x181824D20
	public static Color op_Addition(Color a, Color b) { }

	// RVA: 0x1825110 Offset: 0x1823710 VA: 0x181825110
	public static Color op_Subtraction(Color a, Color b) { }

	// RVA: 0x1825080 Offset: 0x1823680 VA: 0x181825080
	public static Color op_Multiply(Color a, Color b) { }

	// RVA: 0x18250D0 Offset: 0x18236D0 VA: 0x1818250D0
	public static Color op_Multiply(Color a, float b) { }

	// RVA: 0x1825040 Offset: 0x1823640 VA: 0x181825040
	public static Color op_Multiply(float b, Color a) { }

	// RVA: 0x1824D70 Offset: 0x1823370 VA: 0x181824D70
	public static Color op_Division(Color a, float b) { }

	// RVA: 0x1824D90 Offset: 0x1823390 VA: 0x181824D90
	public static bool op_Equality(Color lhs, Color rhs) { }

	// RVA: 0x1824F20 Offset: 0x1823520 VA: 0x181824F20
	public static bool op_Inequality(Color lhs, Color rhs) { }

	// RVA: 0x1824530 Offset: 0x1822B30 VA: 0x181824530
	public static Color Lerp(Color a, Color b, float t) { }

	// RVA: 0x2130B0 Offset: 0x2124B0 VA: 0x1802130B0
	internal Color RGBMultiplied(float multiplier) { }

	// RVA: 0x1824CC0 Offset: 0x18232C0 VA: 0x181824CC0
	public static Color get_red() { }

	// RVA: 0x1824B40 Offset: 0x1823140 VA: 0x181824B40
	public static Color get_green() { }

	// RVA: 0x18249D0 Offset: 0x1822FD0 VA: 0x1818249D0
	public static Color get_blue() { }

	// RVA: 0x1824CE0 Offset: 0x18232E0 VA: 0x181824CE0
	public static Color get_white() { }

	// RVA: 0x18249B0 Offset: 0x1822FB0 VA: 0x1818249B0
	public static Color get_black() { }

	// RVA: 0x1824D00 Offset: 0x1823300 VA: 0x181824D00
	public static Color get_yellow() { }

	// RVA: 0x1824A00 Offset: 0x1823000 VA: 0x181824A00
	public static Color get_cyan() { }

	// RVA: 0x1824C20 Offset: 0x1823220 VA: 0x181824C20
	public static Color get_magenta() { }

	// RVA: 0x1824AE0 Offset: 0x18230E0 VA: 0x181824AE0
	public static Color get_gray() { }

	// RVA: 0x1824AE0 Offset: 0x18230E0 VA: 0x181824AE0
	public static Color get_grey() { }

	// RVA: 0x18249F0 Offset: 0x1822FF0 VA: 0x1818249F0
	public static Color get_clear() { }

	// RVA: 0x2132D0 Offset: 0x2126D0 VA: 0x1802132D0
	public float get_grayscale() { }

	// RVA: 0x213310 Offset: 0x212710 VA: 0x180213310
	public Color get_linear() { }

	// RVA: 0x213210 Offset: 0x212610 VA: 0x180213210
	public Color get_gamma() { }

	// RVA: 0x213330 Offset: 0x212730 VA: 0x180213330
	public float get_maxColorComponent() { }

	// RVA: 0x1824EC0 Offset: 0x18234C0 VA: 0x181824EC0
	public static Vector4 op_Implicit(Color c) { }

	// RVA: 0x1824E80 Offset: 0x1823480 VA: 0x181824E80
	public static Color op_Implicit(Vector4 v) { }

	// RVA: 0x213120 Offset: 0x212520 VA: 0x180213120
	public float get_Item(int index) { }

	// RVA: 0x1824210 Offset: 0x1822810 VA: 0x181824210
	public static Color HSVToRGB(float H, float S, float V, bool hdr) { }

}

public struct Color // TypeDefIndex: 5552
{	// Fields
	public byte r; // 0x0
	public byte g; // 0x1
	public byte b; // 0x2
	public byte a; // 0x3

}

