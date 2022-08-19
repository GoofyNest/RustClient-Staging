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

	// RVA: 0x1F2140 Offset: 0x1F1540 VA: 0x1801F2140 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1F26A0 Offset: 0x1F1AA0 VA: 0x1801F26A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1F2660 Offset: 0x1F1A60 VA: 0x1801F2660 Slot: 20
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1F20B0 Offset: 0x1F14B0 VA: 0x1801F20B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1DF530 Offset: 0x1DE930 VA: 0x1801DF530 Slot: 23
	public bool Equals(bool obj) { }

	// RVA: 0x1F1FC0 Offset: 0x1F13C0 VA: 0x1801F1FC0 Slot: 4
	public int CompareTo(object obj) { }

	// RVA: 0x1F1FA0 Offset: 0x1F13A0 VA: 0x1801F1FA0 Slot: 22
	public int CompareTo(bool value) { }

	// RVA: 0x155FE90 Offset: 0x155E490 VA: 0x18155FE90
	public static bool Parse(string value) { }

	// RVA: 0x15602D0 Offset: 0x155E8D0 VA: 0x1815602D0
	public static bool TryParse(string value, out bool result) { }

	// RVA: 0x15601A0 Offset: 0x155E7A0 VA: 0x1815601A0
	private static string TrimWhiteSpaceAndNull(string value) { }

	// RVA: 0x1F2150 Offset: 0x1F1550 VA: 0x1801F2150 Slot: 5
	public TypeCode GetTypeCode() { }

	// RVA: 0x1F2160 Offset: 0x1F1560 VA: 0x1801F2160 Slot: 6
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x1F21D0 Offset: 0x1F15D0 VA: 0x1801F21D0 Slot: 7
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x1F23F0 Offset: 0x1F17F0 VA: 0x1801F23F0 Slot: 8
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1F2170 Offset: 0x1F1570 VA: 0x1801F2170 Slot: 9
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1F22D0 Offset: 0x1F16D0 VA: 0x1801F22D0 Slot: 10
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1F2540 Offset: 0x1F1940 VA: 0x1801F2540 Slot: 11
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x1F2330 Offset: 0x1F1730 VA: 0x1801F2330 Slot: 12
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1F25A0 Offset: 0x1F19A0 VA: 0x1801F25A0 Slot: 13
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1F2390 Offset: 0x1F1790 VA: 0x1801F2390 Slot: 14
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1F2600 Offset: 0x1F1A00 VA: 0x1801F2600 Slot: 15
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1F2450 Offset: 0x1F1850 VA: 0x1801F2450 Slot: 16
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1F2270 Offset: 0x1F1670 VA: 0x1801F2270 Slot: 17
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1F21F0 Offset: 0x1F15F0 VA: 0x1801F21F0 Slot: 18
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1F21E0 Offset: 0x1F15E0 VA: 0x1801F21E0 Slot: 19
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1F24B0 Offset: 0x1F18B0 VA: 0x1801F24B0 Slot: 21
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x1560510 Offset: 0x155EB10 VA: 0x181560510
	private static void .cctor() { }

}

