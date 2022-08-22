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

	// RVA: 0x212530 Offset: 0x211930 VA: 0x180212530
	public void .ctor(float r, float g, float b) { }

	// RVA: 0x212520 Offset: 0x211920 VA: 0x180212520 Slot: 3
	public override string ToString() { }

	// RVA: 0x212480 Offset: 0x211880 VA: 0x180212480 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x212330 Offset: 0x211730 VA: 0x180212330 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x212410 Offset: 0x211810 VA: 0x180212410 Slot: 4
	public bool Equals(Color other) { }

	// RVA: 0x1812160 Offset: 0x1810760 VA: 0x181812160
	public static Color op_Addition(Color a, Color b) { }

	// RVA: 0x1812550 Offset: 0x1810B50 VA: 0x181812550
	public static Color op_Subtraction(Color a, Color b) { }

	// RVA: 0x18124C0 Offset: 0x1810AC0 VA: 0x1818124C0
	public static Color op_Multiply(Color a, Color b) { }

	// RVA: 0x1812510 Offset: 0x1810B10 VA: 0x181812510
	public static Color op_Multiply(Color a, float b) { }

	// RVA: 0x1812480 Offset: 0x1810A80 VA: 0x181812480
	public static Color op_Multiply(float b, Color a) { }

	// RVA: 0x18121B0 Offset: 0x18107B0 VA: 0x1818121B0
	public static Color op_Division(Color a, float b) { }

	// RVA: 0x18121D0 Offset: 0x18107D0 VA: 0x1818121D0
	public static bool op_Equality(Color lhs, Color rhs) { }

	// RVA: 0x1812360 Offset: 0x1810960 VA: 0x181812360
	public static bool op_Inequality(Color lhs, Color rhs) { }

	// RVA: 0x1811970 Offset: 0x180FF70 VA: 0x181811970
	public static Color Lerp(Color a, Color b, float t) { }

	// RVA: 0x2124E0 Offset: 0x2118E0 VA: 0x1802124E0
	internal Color RGBMultiplied(float multiplier) { }

	// RVA: 0x1812100 Offset: 0x1810700 VA: 0x181812100
	public static Color get_red() { }

	// RVA: 0x1811F80 Offset: 0x1810580 VA: 0x181811F80
	public static Color get_green() { }

	// RVA: 0x1811E10 Offset: 0x1810410 VA: 0x181811E10
	public static Color get_blue() { }

	// RVA: 0x1812120 Offset: 0x1810720 VA: 0x181812120
	public static Color get_white() { }

	// RVA: 0x1811DF0 Offset: 0x18103F0 VA: 0x181811DF0
	public static Color get_black() { }

	// RVA: 0x1812140 Offset: 0x1810740 VA: 0x181812140
	public static Color get_yellow() { }

	// RVA: 0x1811E40 Offset: 0x1810440 VA: 0x181811E40
	public static Color get_cyan() { }

	// RVA: 0x1812060 Offset: 0x1810660 VA: 0x181812060
	public static Color get_magenta() { }

	// RVA: 0x1811F20 Offset: 0x1810520 VA: 0x181811F20
	public static Color get_gray() { }

	// RVA: 0x1811F20 Offset: 0x1810520 VA: 0x181811F20
	public static Color get_grey() { }

	// RVA: 0x1811E30 Offset: 0x1810430 VA: 0x181811E30
	public static Color get_clear() { }

	// RVA: 0x212700 Offset: 0x211B00 VA: 0x180212700
	public float get_grayscale() { }

	// RVA: 0x212740 Offset: 0x211B40 VA: 0x180212740
	public Color get_linear() { }

	// RVA: 0x212640 Offset: 0x211A40 VA: 0x180212640
	public Color get_gamma() { }

	// RVA: 0x212760 Offset: 0x211B60 VA: 0x180212760
	public float get_maxColorComponent() { }

	// RVA: 0x1812300 Offset: 0x1810900 VA: 0x181812300
	public static Vector4 op_Implicit(Color c) { }

	// RVA: 0x18122C0 Offset: 0x18108C0 VA: 0x1818122C0
	public static Color op_Implicit(Vector4 v) { }

	// RVA: 0x212550 Offset: 0x211950 VA: 0x180212550
	public float get_Item(int index) { }

	// RVA: 0x1811650 Offset: 0x180FC50 VA: 0x181811650
	public static Color HSVToRGB(float H, float S, float V, bool hdr) { }

}

public struct Color // TypeDefIndex: 5552
{	// Fields
	public byte r; // 0x0
	public byte g; // 0x1
	public byte b; // 0x2
	public byte a; // 0x3

}

