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

	// RVA: 0x10D44A0 Offset: 0x10D2AA0 VA: 0x1810D44A0
	public static bool IsInfinity(double d) { }

	// RVA: 0x10D4520 Offset: 0x10D2B20 VA: 0x1810D4520
	public static bool IsPositiveInfinity(double d) { }

	// RVA: 0x10D4500 Offset: 0x10D2B00 VA: 0x1810D4500
	public static bool IsNegativeInfinity(double d) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x10D44D0 Offset: 0x10D2AD0 VA: 0x1810D44D0
	public static bool IsNaN(double d) { }

	// RVA: 0x10D4420 Offset: 0x10D2A20 VA: 0x1810D4420
	public static bool IsFinite(double d) { }

	// RVA: 0x19EA00 Offset: 0x19DE00 VA: 0x18019EA00 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x19E8D0 Offset: 0x19DCD0 VA: 0x18019E8D0 Slot: 23
	public int CompareTo(double value) { }

	// RVA: 0x19EC80 Offset: 0x19E080 VA: 0x18019EC80 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x19EB90 Offset: 0x19DF90 VA: 0x18019EB90 Slot: 24
	public bool Equals(double obj) { }

	// RVA: 0x19EDA0 Offset: 0x19E1A0 VA: 0x18019EDA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x19F390 Offset: 0x19E790 VA: 0x18019F390 Slot: 3
	public override string ToString() { }

	// RVA: 0x19F310 Offset: 0x19E710 VA: 0x18019F310
	public string ToString(string format) { }

	// RVA: 0x19F350 Offset: 0x19E750 VA: 0x18019F350 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x19F2D0 Offset: 0x19E6D0 VA: 0x18019F2D0 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x10D4540 Offset: 0x10D2B40 VA: 0x1810D4540
	public static double Parse(string s) { }

	// RVA: 0x10D4640 Offset: 0x10D2C40 VA: 0x1810D4640
	public static double Parse(string s, IFormatProvider provider) { }

	// RVA: 0x10D45B0 Offset: 0x10D2BB0 VA: 0x1810D45B0
	public static double Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x10D46C0 Offset: 0x10D2CC0 VA: 0x1810D46C0
	private static double Parse(string s, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x10D4AB0 Offset: 0x10D30B0 VA: 0x1810D4AB0
	public static bool TryParse(string s, out double result) { }

	// RVA: 0x10D4960 Offset: 0x10D2F60 VA: 0x1810D4960
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out double result) { }

	// RVA: 0x10D4BE0 Offset: 0x10D31E0 VA: 0x1810D4BE0
	private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out double result) { }

	// RVA: 0x19EDB0 Offset: 0x19E1B0 VA: 0x18019EDB0 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x19EDC0 Offset: 0x19E1C0 VA: 0x18019EDC0 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x19EE80 Offset: 0x19E280 VA: 0x18019EE80 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x19F050 Offset: 0x19E450 VA: 0x18019F050 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x19EE20 Offset: 0x19E220 VA: 0x18019EE20 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x19EF30 Offset: 0x19E330 VA: 0x18019EF30 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x19F1B0 Offset: 0x19E5B0 VA: 0x18019F1B0 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x19EF90 Offset: 0x19E390 VA: 0x18019EF90 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x19F210 Offset: 0x19E610 VA: 0x18019F210 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x19EFF0 Offset: 0x19E3F0 VA: 0x18019EFF0 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x19F270 Offset: 0x19E670 VA: 0x18019F270 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x19F0B0 Offset: 0x19E4B0 VA: 0x18019F0B0 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x19EF20 Offset: 0x19E320 VA: 0x18019EF20 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x19EEA0 Offset: 0x19E2A0 VA: 0x18019EEA0 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x19EE90 Offset: 0x19E290 VA: 0x18019EE90 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x19F110 Offset: 0x19E510 VA: 0x18019F110 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x10D4CD0 Offset: 0x10D32D0 VA: 0x1810D4CD0
	private static void .cctor() { }

}

