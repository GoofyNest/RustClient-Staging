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

	// RVA: 0x1F20C0 Offset: 0x1F14C0 VA: 0x1801F20C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1F2620 Offset: 0x1F1A20 VA: 0x1801F2620 Slot: 3
	public override string ToString() { }

	// RVA: 0x1F25E0 Offset: 0x1F19E0 VA: 0x1801F25E0 Slot: 20
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1F2030 Offset: 0x1F1430 VA: 0x1801F2030 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1DF4B0 Offset: 0x1DE8B0 VA: 0x1801DF4B0 Slot: 23
	public bool Equals(bool obj) { }

	// RVA: 0x1F1F40 Offset: 0x1F1340 VA: 0x1801F1F40 Slot: 4
	public int CompareTo(object obj) { }

	// RVA: 0x1F1F20 Offset: 0x1F1320 VA: 0x1801F1F20 Slot: 22
	public int CompareTo(bool value) { }

	// RVA: 0x1560150 Offset: 0x155E750 VA: 0x181560150
	public static bool Parse(string value) { }

	// RVA: 0x1560590 Offset: 0x155EB90 VA: 0x181560590
	public static bool TryParse(string value, out bool result) { }

	// RVA: 0x1560460 Offset: 0x155EA60 VA: 0x181560460
	private static string TrimWhiteSpaceAndNull(string value) { }

	// RVA: 0x1F20D0 Offset: 0x1F14D0 VA: 0x1801F20D0 Slot: 5
	public TypeCode GetTypeCode() { }

	// RVA: 0x1F20E0 Offset: 0x1F14E0 VA: 0x1801F20E0 Slot: 6
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x1F2150 Offset: 0x1F1550 VA: 0x1801F2150 Slot: 7
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x1F2370 Offset: 0x1F1770 VA: 0x1801F2370 Slot: 8
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1F20F0 Offset: 0x1F14F0 VA: 0x1801F20F0 Slot: 9
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1F2250 Offset: 0x1F1650 VA: 0x1801F2250 Slot: 10
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1F24C0 Offset: 0x1F18C0 VA: 0x1801F24C0 Slot: 11
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x1F22B0 Offset: 0x1F16B0 VA: 0x1801F22B0 Slot: 12
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1F2520 Offset: 0x1F1920 VA: 0x1801F2520 Slot: 13
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1F2310 Offset: 0x1F1710 VA: 0x1801F2310 Slot: 14
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1F2580 Offset: 0x1F1980 VA: 0x1801F2580 Slot: 15
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1F23D0 Offset: 0x1F17D0 VA: 0x1801F23D0 Slot: 16
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1F21F0 Offset: 0x1F15F0 VA: 0x1801F21F0 Slot: 17
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1F2170 Offset: 0x1F1570 VA: 0x1801F2170 Slot: 18
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1F2160 Offset: 0x1F1560 VA: 0x1801F2160 Slot: 19
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1F2430 Offset: 0x1F1830 VA: 0x1801F2430 Slot: 21
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x15607D0 Offset: 0x155EDD0 VA: 0x1815607D0
	private static void .cctor() { }

}

