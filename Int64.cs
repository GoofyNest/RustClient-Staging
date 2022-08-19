public struct Int64 : IComparable, IFormattable, IConvertible, IComparable<long>, IEquatable<long> // TypeDefIndex: 259
{	// Fields
	internal long m_value; // 0x0
	public const long MaxValue = 9223372036854775807;
	public const long MinValue = -9223372036854775808;

	// Methods

	// RVA: 0x1FB250 Offset: 0x1FA650 VA: 0x1801FB250 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x1FB230 Offset: 0x1FA630 VA: 0x1801FB230 Slot: 23
	public int CompareTo(long value) { }

	// RVA: 0x1FB350 Offset: 0x1FA750 VA: 0x1801FB350 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1F5BD0 Offset: 0x1F4FD0 VA: 0x1801F5BD0 Slot: 24
	public bool Equals(long obj) { }

	// RVA: 0x1F5C70 Offset: 0x1F5070 VA: 0x1801F5C70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1FB9A0 Offset: 0x1FADA0 VA: 0x1801FB9A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1FB930 Offset: 0x1FAD30 VA: 0x1801FB930 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1FB960 Offset: 0x1FAD60 VA: 0x1801FB960
	public string ToString(string format) { }

	// RVA: 0x1FB9D0 Offset: 0x1FADD0 VA: 0x1801FB9D0 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x1672D80 Offset: 0x1671380 VA: 0x181672D80
	public static long Parse(string s) { }

	// RVA: 0x1672D50 Offset: 0x1671350 VA: 0x181672D50
	public static long Parse(string s, IFormatProvider provider) { }

	// RVA: 0x1672D00 Offset: 0x1671300 VA: 0x181672D00
	public static long Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x1672F60 Offset: 0x1671560 VA: 0x181672F60
	public static bool TryParse(string s, out long result) { }

	// RVA: 0x1672FA0 Offset: 0x16715A0 VA: 0x181672FA0
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out long result) { }

	// RVA: 0x1FB3E0 Offset: 0x1FA7E0 VA: 0x1801FB3E0 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x1FB3F0 Offset: 0x1FA7F0 VA: 0x1801FB3F0 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x1FB4B0 Offset: 0x1FA8B0 VA: 0x1801FB4B0 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x1FB6C0 Offset: 0x1FAAC0 VA: 0x1801FB6C0 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1FB450 Offset: 0x1FA850 VA: 0x1801FB450 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1FB600 Offset: 0x1FAA00 VA: 0x1801FB600 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1FB810 Offset: 0x1FAC10 VA: 0x1801FB810 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x1FB660 Offset: 0x1FAA60 VA: 0x1801FB660 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1FB870 Offset: 0x1FAC70 VA: 0x1801FB870 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0xFC8C0 Offset: 0xFBCC0 VA: 0x1800FC8C0 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1FB8D0 Offset: 0x1FACD0 VA: 0x1801FB8D0 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1FB720 Offset: 0x1FAB20 VA: 0x1801FB720 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1FB5A0 Offset: 0x1FA9A0 VA: 0x1801FB5A0 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1FB520 Offset: 0x1FA920 VA: 0x1801FB520 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1FB510 Offset: 0x1FA910 VA: 0x1801FB510 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1FB780 Offset: 0x1FAB80 VA: 0x1801FB780 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

}

