public struct Int32 : IComparable, IFormattable, IConvertible, IComparable<int>, IEquatable<int> // TypeDefIndex: 258
{	// Fields
	internal int m_value; // 0x0
	public const int MaxValue = 2147483647;
	public const int MinValue = -2147483648;

	// Methods

	// RVA: 0x1FAA70 Offset: 0x1F9E70 VA: 0x1801FAA70 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x1FAB70 Offset: 0x1F9F70 VA: 0x1801FAB70 Slot: 23
	public int CompareTo(int value) { }

	// RVA: 0x1FAB90 Offset: 0x1F9F90 VA: 0x1801FAB90 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1E50E0 Offset: 0x1E44E0 VA: 0x1801E50E0 Slot: 24
	public bool Equals(int obj) { }

	// RVA: 0xF37A0 Offset: 0xF2BA0 VA: 0x1800F37A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1FB150 Offset: 0x1FA550 VA: 0x1801FB150 Slot: 3
	public override string ToString() { }

	// RVA: 0x1FB1B0 Offset: 0x1FA5B0 VA: 0x1801FB1B0
	public string ToString(string format) { }

	// RVA: 0x1FB180 Offset: 0x1FA580 VA: 0x1801FB180 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1FB1F0 Offset: 0x1FA5F0 VA: 0x1801FB1F0 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x1672890 Offset: 0x1670E90 VA: 0x181672890
	public static int Parse(string s) { }

	// RVA: 0x16728F0 Offset: 0x1670EF0 VA: 0x1816728F0
	public static int Parse(string s, NumberStyles style) { }

	// RVA: 0x16728C0 Offset: 0x1670EC0 VA: 0x1816728C0
	public static int Parse(string s, IFormatProvider provider) { }

	// RVA: 0x1672840 Offset: 0x1670E40 VA: 0x181672840
	public static int Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x1672AD0 Offset: 0x16710D0 VA: 0x181672AD0
	public static bool TryParse(string s, out int result) { }

	// RVA: 0x1672B10 Offset: 0x1671110 VA: 0x181672B10
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out int result) { }

	// RVA: 0x1FAC10 Offset: 0x1FA010 VA: 0x1801FAC10 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x1FAC20 Offset: 0x1FA020 VA: 0x1801FAC20 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x1FACE0 Offset: 0x1FA0E0 VA: 0x1801FACE0 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x1FAEE0 Offset: 0x1FA2E0 VA: 0x1801FAEE0 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1FAC80 Offset: 0x1FA080 VA: 0x1801FAC80 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1FAE20 Offset: 0x1FA220 VA: 0x1801FAE20 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1FB030 Offset: 0x1FA430 VA: 0x1801FB030 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0xF37A0 Offset: 0xF2BA0 VA: 0x1800F37A0 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1FB090 Offset: 0x1FA490 VA: 0x1801FB090 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1FAE80 Offset: 0x1FA280 VA: 0x1801FAE80 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1FB0F0 Offset: 0x1FA4F0 VA: 0x1801FB0F0 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1FAF40 Offset: 0x1FA340 VA: 0x1801FAF40 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1FADC0 Offset: 0x1FA1C0 VA: 0x1801FADC0 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1FAD50 Offset: 0x1FA150 VA: 0x1801FAD50 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1FAD40 Offset: 0x1FA140 VA: 0x1801FAD40 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1FAFA0 Offset: 0x1FA3A0 VA: 0x1801FAFA0 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

}

