public struct Int64 : IComparable, IFormattable, IConvertible, IComparable<long>, IEquatable<long> // TypeDefIndex: 259
{	// Fields
	internal long m_value; // 0x0
	public const long MaxValue = 9223372036854775807;
	public const long MinValue = -9223372036854775808;

	// Methods

	// RVA: 0x1FB1D0 Offset: 0x1FA5D0 VA: 0x1801FB1D0 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x1FB1B0 Offset: 0x1FA5B0 VA: 0x1801FB1B0 Slot: 23
	public int CompareTo(long value) { }

	// RVA: 0x1FB2D0 Offset: 0x1FA6D0 VA: 0x1801FB2D0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1F5B50 Offset: 0x1F4F50 VA: 0x1801F5B50 Slot: 24
	public bool Equals(long obj) { }

	// RVA: 0x1F5BF0 Offset: 0x1F4FF0 VA: 0x1801F5BF0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1FB920 Offset: 0x1FAD20 VA: 0x1801FB920 Slot: 3
	public override string ToString() { }

	// RVA: 0x1FB8B0 Offset: 0x1FACB0 VA: 0x1801FB8B0 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1FB8E0 Offset: 0x1FACE0 VA: 0x1801FB8E0
	public string ToString(string format) { }

	// RVA: 0x1FB950 Offset: 0x1FAD50 VA: 0x1801FB950 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x1673040 Offset: 0x1671640 VA: 0x181673040
	public static long Parse(string s) { }

	// RVA: 0x1673010 Offset: 0x1671610 VA: 0x181673010
	public static long Parse(string s, IFormatProvider provider) { }

	// RVA: 0x1672FC0 Offset: 0x16715C0 VA: 0x181672FC0
	public static long Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x1673220 Offset: 0x1671820 VA: 0x181673220
	public static bool TryParse(string s, out long result) { }

	// RVA: 0x1673260 Offset: 0x1671860 VA: 0x181673260
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out long result) { }

	// RVA: 0x1FB360 Offset: 0x1FA760 VA: 0x1801FB360 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x1FB370 Offset: 0x1FA770 VA: 0x1801FB370 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x1FB430 Offset: 0x1FA830 VA: 0x1801FB430 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x1FB640 Offset: 0x1FAA40 VA: 0x1801FB640 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1FB3D0 Offset: 0x1FA7D0 VA: 0x1801FB3D0 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1FB580 Offset: 0x1FA980 VA: 0x1801FB580 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1FB790 Offset: 0x1FAB90 VA: 0x1801FB790 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x1FB5E0 Offset: 0x1FA9E0 VA: 0x1801FB5E0 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1FB7F0 Offset: 0x1FABF0 VA: 0x1801FB7F0 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0xFC840 Offset: 0xFBC40 VA: 0x1800FC840 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1FB850 Offset: 0x1FAC50 VA: 0x1801FB850 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1FB6A0 Offset: 0x1FAAA0 VA: 0x1801FB6A0 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1FB520 Offset: 0x1FA920 VA: 0x1801FB520 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1FB4A0 Offset: 0x1FA8A0 VA: 0x1801FB4A0 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1FB490 Offset: 0x1FA890 VA: 0x1801FB490 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1FB700 Offset: 0x1FAB00 VA: 0x1801FB700 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

}

