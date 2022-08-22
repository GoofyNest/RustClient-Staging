public struct Int64 : IComparable, IFormattable, IConvertible, IComparable<long>, IEquatable<long> // TypeDefIndex: 259
{	// Fields
	internal long m_value; // 0x0
	public const long MaxValue = 9223372036854775807;
	public const long MinValue = -9223372036854775808;

	// Methods

	// RVA: 0x1FAE00 Offset: 0x1FA200 VA: 0x1801FAE00 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x1FADE0 Offset: 0x1FA1E0 VA: 0x1801FADE0 Slot: 23
	public int CompareTo(long value) { }

	// RVA: 0x1FAF00 Offset: 0x1FA300 VA: 0x1801FAF00 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1F49A0 Offset: 0x1F3DA0 VA: 0x1801F49A0 Slot: 24
	public bool Equals(long obj) { }

	// RVA: 0x1F4A40 Offset: 0x1F3E40 VA: 0x1801F4A40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1FB550 Offset: 0x1FA950 VA: 0x1801FB550 Slot: 3
	public override string ToString() { }

	// RVA: 0x1FB4E0 Offset: 0x1FA8E0 VA: 0x1801FB4E0 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1FB510 Offset: 0x1FA910 VA: 0x1801FB510
	public string ToString(string format) { }

	// RVA: 0x1FB580 Offset: 0x1FA980 VA: 0x1801FB580 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x1670C30 Offset: 0x166F230 VA: 0x181670C30
	public static long Parse(string s) { }

	// RVA: 0x1670C00 Offset: 0x166F200 VA: 0x181670C00
	public static long Parse(string s, IFormatProvider provider) { }

	// RVA: 0x1670BB0 Offset: 0x166F1B0 VA: 0x181670BB0
	public static long Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x1670E10 Offset: 0x166F410 VA: 0x181670E10
	public static bool TryParse(string s, out long result) { }

	// RVA: 0x1670E50 Offset: 0x166F450 VA: 0x181670E50
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out long result) { }

	// RVA: 0x1FAF90 Offset: 0x1FA390 VA: 0x1801FAF90 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x1FAFA0 Offset: 0x1FA3A0 VA: 0x1801FAFA0 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x1FB060 Offset: 0x1FA460 VA: 0x1801FB060 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x1FB270 Offset: 0x1FA670 VA: 0x1801FB270 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1FB000 Offset: 0x1FA400 VA: 0x1801FB000 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1FB1B0 Offset: 0x1FA5B0 VA: 0x1801FB1B0 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1FB3C0 Offset: 0x1FA7C0 VA: 0x1801FB3C0 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x1FB210 Offset: 0x1FA610 VA: 0x1801FB210 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1FB420 Offset: 0x1FA820 VA: 0x1801FB420 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0xFC840 Offset: 0xFBC40 VA: 0x1800FC840 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1FB480 Offset: 0x1FA880 VA: 0x1801FB480 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1FB2D0 Offset: 0x1FA6D0 VA: 0x1801FB2D0 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1FB150 Offset: 0x1FA550 VA: 0x1801FB150 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1FB0D0 Offset: 0x1FA4D0 VA: 0x1801FB0D0 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1FB0C0 Offset: 0x1FA4C0 VA: 0x1801FB0C0 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1FB330 Offset: 0x1FA730 VA: 0x1801FB330 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

}

