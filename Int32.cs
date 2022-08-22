public struct Int32 : IComparable, IFormattable, IConvertible, IComparable<int>, IEquatable<int> // TypeDefIndex: 258
{	// Fields
	internal int m_value; // 0x0
	public const int MaxValue = 2147483647;
	public const int MinValue = -2147483648;

	// Methods

	// RVA: 0x1FA9F0 Offset: 0x1F9DF0 VA: 0x1801FA9F0 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x1FAAF0 Offset: 0x1F9EF0 VA: 0x1801FAAF0 Slot: 23
	public int CompareTo(int value) { }

	// RVA: 0x1FAB10 Offset: 0x1F9F10 VA: 0x1801FAB10 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1E5060 Offset: 0x1E4460 VA: 0x1801E5060 Slot: 24
	public bool Equals(int obj) { }

	// RVA: 0xF3720 Offset: 0xF2B20 VA: 0x1800F3720 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1FB0D0 Offset: 0x1FA4D0 VA: 0x1801FB0D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1FB130 Offset: 0x1FA530 VA: 0x1801FB130
	public string ToString(string format) { }

	// RVA: 0x1FB100 Offset: 0x1FA500 VA: 0x1801FB100 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1FB170 Offset: 0x1FA570 VA: 0x1801FB170 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x1672B50 Offset: 0x1671150 VA: 0x181672B50
	public static int Parse(string s) { }

	// RVA: 0x1672BB0 Offset: 0x16711B0 VA: 0x181672BB0
	public static int Parse(string s, NumberStyles style) { }

	// RVA: 0x1672B80 Offset: 0x1671180 VA: 0x181672B80
	public static int Parse(string s, IFormatProvider provider) { }

	// RVA: 0x1672B00 Offset: 0x1671100 VA: 0x181672B00
	public static int Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x1672D90 Offset: 0x1671390 VA: 0x181672D90
	public static bool TryParse(string s, out int result) { }

	// RVA: 0x1672DD0 Offset: 0x16713D0 VA: 0x181672DD0
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out int result) { }

	// RVA: 0x1FAB90 Offset: 0x1F9F90 VA: 0x1801FAB90 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x1FABA0 Offset: 0x1F9FA0 VA: 0x1801FABA0 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x1FAC60 Offset: 0x1FA060 VA: 0x1801FAC60 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x1FAE60 Offset: 0x1FA260 VA: 0x1801FAE60 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1FAC00 Offset: 0x1FA000 VA: 0x1801FAC00 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1FADA0 Offset: 0x1FA1A0 VA: 0x1801FADA0 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1FAFB0 Offset: 0x1FA3B0 VA: 0x1801FAFB0 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0xF3720 Offset: 0xF2B20 VA: 0x1800F3720 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1FB010 Offset: 0x1FA410 VA: 0x1801FB010 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1FAE00 Offset: 0x1FA200 VA: 0x1801FAE00 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1FB070 Offset: 0x1FA470 VA: 0x1801FB070 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1FAEC0 Offset: 0x1FA2C0 VA: 0x1801FAEC0 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1FAD40 Offset: 0x1FA140 VA: 0x1801FAD40 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1FACD0 Offset: 0x1FA0D0 VA: 0x1801FACD0 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1FACC0 Offset: 0x1FA0C0 VA: 0x1801FACC0 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1FAF20 Offset: 0x1FA320 VA: 0x1801FAF20 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

}

