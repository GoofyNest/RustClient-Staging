public struct Double : IComparable, IFormattable, IConvertible, IComparable<double>, IEquatable<double> // TypeDefIndex: 208
{	// Fields
	internal double m_value; // 0x0
	public const double MinValue = -1,79769313486232E+308;
	public const double MaxValue = 1,79769313486232E+308;
	public const double Epsilon = 4,94065645841247E-324;
	public const double NegativeInfinity = -∞;
	public const double PositiveInfinity = ∞;
	public const double NaN = ¤¤¤;
	internal static double NegativeZero; // 0x0

	// Methods

	// RVA: 0x10D51D0 Offset: 0x10D37D0 VA: 0x1810D51D0
	public static bool IsInfinity(double d) { }

	// RVA: 0x10D5250 Offset: 0x10D3850 VA: 0x1810D5250
	public static bool IsPositiveInfinity(double d) { }

	// RVA: 0x10D5230 Offset: 0x10D3830 VA: 0x1810D5230
	public static bool IsNegativeInfinity(double d) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x10D5200 Offset: 0x10D3800 VA: 0x1810D5200
	public static bool IsNaN(double d) { }

	// RVA: 0x10D5150 Offset: 0x10D3750 VA: 0x1810D5150
	public static bool IsFinite(double d) { }

	// RVA: 0x1AC890 Offset: 0x1ABC90 VA: 0x1801AC890 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x1AC760 Offset: 0x1ABB60 VA: 0x1801AC760 Slot: 23
	public int CompareTo(double value) { }

	// RVA: 0x1ACB10 Offset: 0x1ABF10 VA: 0x1801ACB10 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1ACA20 Offset: 0x1ABE20 VA: 0x1801ACA20 Slot: 24
	public bool Equals(double obj) { }

	// RVA: 0x1ACC30 Offset: 0x1AC030 VA: 0x1801ACC30 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1AD220 Offset: 0x1AC620 VA: 0x1801AD220 Slot: 3
	public override string ToString() { }

	// RVA: 0x1AD1A0 Offset: 0x1AC5A0 VA: 0x1801AD1A0
	public string ToString(string format) { }

	// RVA: 0x1AD1E0 Offset: 0x1AC5E0 VA: 0x1801AD1E0 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1AD160 Offset: 0x1AC560 VA: 0x1801AD160 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x10D5270 Offset: 0x10D3870 VA: 0x1810D5270
	public static double Parse(string s) { }

	// RVA: 0x10D5370 Offset: 0x10D3970 VA: 0x1810D5370
	public static double Parse(string s, IFormatProvider provider) { }

	// RVA: 0x10D52E0 Offset: 0x10D38E0 VA: 0x1810D52E0
	public static double Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x10D53F0 Offset: 0x10D39F0 VA: 0x1810D53F0
	private static double Parse(string s, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x10D57E0 Offset: 0x10D3DE0 VA: 0x1810D57E0
	public static bool TryParse(string s, out double result) { }

	// RVA: 0x10D5690 Offset: 0x10D3C90 VA: 0x1810D5690
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out double result) { }

	// RVA: 0x10D5910 Offset: 0x10D3F10 VA: 0x1810D5910
	private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out double result) { }

	// RVA: 0x1ACC40 Offset: 0x1AC040 VA: 0x1801ACC40 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x1ACC50 Offset: 0x1AC050 VA: 0x1801ACC50 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x1ACD10 Offset: 0x1AC110 VA: 0x1801ACD10 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x1ACEE0 Offset: 0x1AC2E0 VA: 0x1801ACEE0 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1ACCB0 Offset: 0x1AC0B0 VA: 0x1801ACCB0 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1ACDC0 Offset: 0x1AC1C0 VA: 0x1801ACDC0 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1AD040 Offset: 0x1AC440 VA: 0x1801AD040 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x1ACE20 Offset: 0x1AC220 VA: 0x1801ACE20 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1AD0A0 Offset: 0x1AC4A0 VA: 0x1801AD0A0 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1ACE80 Offset: 0x1AC280 VA: 0x1801ACE80 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1AD100 Offset: 0x1AC500 VA: 0x1801AD100 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1ACF40 Offset: 0x1AC340 VA: 0x1801ACF40 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1ACDB0 Offset: 0x1AC1B0 VA: 0x1801ACDB0 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1ACD30 Offset: 0x1AC130 VA: 0x1801ACD30 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1ACD20 Offset: 0x1AC120 VA: 0x1801ACD20 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1ACFA0 Offset: 0x1AC3A0 VA: 0x1801ACFA0 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x10D5A00 Offset: 0x10D4000 VA: 0x1810D5A00
	private static void .cctor() { }

}

