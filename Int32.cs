public struct Int32 : IComparable, IFormattable, IConvertible, IComparable<int>, IEquatable<int> // TypeDefIndex: 258
{	// Fields
	internal int m_value; // 0x0
	public const int MaxValue = 2147483647;
	public const int MinValue = -2147483648;

	// Methods

	// RVA: 0x1FA620 Offset: 0x1F9A20 VA: 0x1801FA620 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x1FA720 Offset: 0x1F9B20 VA: 0x1801FA720 Slot: 23
	public int CompareTo(int value) { }

	// RVA: 0x1FA740 Offset: 0x1F9B40 VA: 0x1801FA740 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1E5480 Offset: 0x1E4880 VA: 0x1801E5480 Slot: 24
	public bool Equals(int obj) { }

	// RVA: 0xF3720 Offset: 0xF2B20 VA: 0x1800F3720 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1FAD00 Offset: 0x1FA100 VA: 0x1801FAD00 Slot: 3
	public override string ToString() { }

	// RVA: 0x1FAD60 Offset: 0x1FA160 VA: 0x1801FAD60
	public string ToString(string format) { }

	// RVA: 0x1FAD30 Offset: 0x1FA130 VA: 0x1801FAD30 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1FADA0 Offset: 0x1FA1A0 VA: 0x1801FADA0 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x1670740 Offset: 0x166ED40 VA: 0x181670740
	public static int Parse(string s) { }

	// RVA: 0x16707A0 Offset: 0x166EDA0 VA: 0x1816707A0
	public static int Parse(string s, NumberStyles style) { }

	// RVA: 0x1670770 Offset: 0x166ED70 VA: 0x181670770
	public static int Parse(string s, IFormatProvider provider) { }

	// RVA: 0x16706F0 Offset: 0x166ECF0 VA: 0x1816706F0
	public static int Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x1670980 Offset: 0x166EF80 VA: 0x181670980
	public static bool TryParse(string s, out int result) { }

	// RVA: 0x16709C0 Offset: 0x166EFC0 VA: 0x1816709C0
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out int result) { }

	// RVA: 0x1FA7C0 Offset: 0x1F9BC0 VA: 0x1801FA7C0 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x1FA7D0 Offset: 0x1F9BD0 VA: 0x1801FA7D0 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x1FA890 Offset: 0x1F9C90 VA: 0x1801FA890 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x1FAA90 Offset: 0x1F9E90 VA: 0x1801FAA90 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1FA830 Offset: 0x1F9C30 VA: 0x1801FA830 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1FA9D0 Offset: 0x1F9DD0 VA: 0x1801FA9D0 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1FABE0 Offset: 0x1F9FE0 VA: 0x1801FABE0 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0xF3720 Offset: 0xF2B20 VA: 0x1800F3720 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1FAC40 Offset: 0x1FA040 VA: 0x1801FAC40 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1FAA30 Offset: 0x1F9E30 VA: 0x1801FAA30 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1FACA0 Offset: 0x1FA0A0 VA: 0x1801FACA0 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1FAAF0 Offset: 0x1F9EF0 VA: 0x1801FAAF0 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1FA970 Offset: 0x1F9D70 VA: 0x1801FA970 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1FA900 Offset: 0x1F9D00 VA: 0x1801FA900 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1FA8F0 Offset: 0x1F9CF0 VA: 0x1801FA8F0 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1FAB50 Offset: 0x1F9F50 VA: 0x1801FAB50 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

}

