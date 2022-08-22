public struct Boolean : IComparable, IConvertible, IComparable<bool>, IEquatable<bool> // TypeDefIndex: 179
{	// Fields
	private bool m_value; // 0x0
	internal const int True = 1;
	internal const int False = 0;
	internal const string TrueLiteral = "True";
	internal const string FalseLiteral = "False";
	public static readonly string TrueString; // 0x0
	public static readonly string FalseString; // 0x8

	// Methods

	// RVA: 0x1F24E0 Offset: 0x1F18E0 VA: 0x1801F24E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1F2A40 Offset: 0x1F1E40 VA: 0x1801F2A40 Slot: 3
	public override string ToString() { }

	// RVA: 0x1F2A00 Offset: 0x1F1E00 VA: 0x1801F2A00 Slot: 20
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1F2450 Offset: 0x1F1850 VA: 0x1801F2450 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1DFB20 Offset: 0x1DEF20 VA: 0x1801DFB20 Slot: 23
	public bool Equals(bool obj) { }

	// RVA: 0x1F2360 Offset: 0x1F1760 VA: 0x1801F2360 Slot: 4
	public int CompareTo(object obj) { }

	// RVA: 0x1F2340 Offset: 0x1F1740 VA: 0x1801F2340 Slot: 22
	public int CompareTo(bool value) { }

	// RVA: 0x155F220 Offset: 0x155D820 VA: 0x18155F220
	public static bool Parse(string value) { }

	// RVA: 0x155F660 Offset: 0x155DC60 VA: 0x18155F660
	public static bool TryParse(string value, out bool result) { }

	// RVA: 0x155F530 Offset: 0x155DB30 VA: 0x18155F530
	private static string TrimWhiteSpaceAndNull(string value) { }

	// RVA: 0x1F24F0 Offset: 0x1F18F0 VA: 0x1801F24F0 Slot: 5
	public TypeCode GetTypeCode() { }

	// RVA: 0x1F2500 Offset: 0x1F1900 VA: 0x1801F2500 Slot: 6
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x1F2570 Offset: 0x1F1970 VA: 0x1801F2570 Slot: 7
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x1F2790 Offset: 0x1F1B90 VA: 0x1801F2790 Slot: 8
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1F2510 Offset: 0x1F1910 VA: 0x1801F2510 Slot: 9
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1F2670 Offset: 0x1F1A70 VA: 0x1801F2670 Slot: 10
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1F28E0 Offset: 0x1F1CE0 VA: 0x1801F28E0 Slot: 11
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x1F26D0 Offset: 0x1F1AD0 VA: 0x1801F26D0 Slot: 12
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1F2940 Offset: 0x1F1D40 VA: 0x1801F2940 Slot: 13
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1F2730 Offset: 0x1F1B30 VA: 0x1801F2730 Slot: 14
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1F29A0 Offset: 0x1F1DA0 VA: 0x1801F29A0 Slot: 15
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1F27F0 Offset: 0x1F1BF0 VA: 0x1801F27F0 Slot: 16
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1F2610 Offset: 0x1F1A10 VA: 0x1801F2610 Slot: 17
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1F2590 Offset: 0x1F1990 VA: 0x1801F2590 Slot: 18
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1F2580 Offset: 0x1F1980 VA: 0x1801F2580 Slot: 19
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1F2850 Offset: 0x1F1C50 VA: 0x1801F2850 Slot: 21
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x155F8A0 Offset: 0x155DEA0 VA: 0x18155F8A0
	private static void .cctor() { }

}

