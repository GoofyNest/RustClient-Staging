public struct SByte : IComparable, IFormattable, IConvertible, IComparable<sbyte>, IEquatable<sbyte> // TypeDefIndex: 296
{	// Fields
	private sbyte m_value; // 0x0
	public const sbyte MaxValue = 127;
	public const sbyte MinValue = -128;

	// Methods

	// RVA: 0x1DF350 Offset: 0x1DE750 VA: 0x1801DF350 Slot: 4
	public int CompareTo(object obj) { }

	// RVA: 0x1DF340 Offset: 0x1DE740 VA: 0x1801DF340 Slot: 23
	public int CompareTo(sbyte value) { }

	// RVA: 0x1DF420 Offset: 0x1DE820 VA: 0x1801DF420 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1DF4B0 Offset: 0x1DE8B0 VA: 0x1801DF4B0 Slot: 24
	public bool Equals(sbyte obj) { }

	// RVA: 0x1DF4C0 Offset: 0x1DE8C0 VA: 0x1801DF4C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1DFB40 Offset: 0x1DEF40 VA: 0x1801DFB40 Slot: 3
	public override string ToString() { }

	// RVA: 0x1DFA70 Offset: 0x1DEE70 VA: 0x1801DFA70 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1DFAA0 Offset: 0x1DEEA0 VA: 0x1801DFAA0 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x1DF9D0 Offset: 0x1DEDD0 VA: 0x1801DF9D0
	private string ToString(string format, NumberFormatInfo info) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x12A4640 Offset: 0x12A2C40 VA: 0x1812A4640
	public static sbyte Parse(string s, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x12A45F0 Offset: 0x12A2BF0 VA: 0x1812A45F0
	public static sbyte Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x12A4670 Offset: 0x12A2C70 VA: 0x1812A4670
	private static sbyte Parse(string s, NumberStyles style, NumberFormatInfo info) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x12A4A10 Offset: 0x12A3010 VA: 0x1812A4A10
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out sbyte result) { }

	// RVA: 0x12A4990 Offset: 0x12A2F90 VA: 0x1812A4990
	private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out sbyte result) { }

	// RVA: 0x1DF4D0 Offset: 0x1DE8D0 VA: 0x1801DF4D0 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x1DF4E0 Offset: 0x1DE8E0 VA: 0x1801DF4E0 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x1DF5A0 Offset: 0x1DE9A0 VA: 0x1801DF5A0 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x14CC10 Offset: 0x14C010 VA: 0x18014CC10 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1DF540 Offset: 0x1DE940 VA: 0x1801DF540 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1DF6F0 Offset: 0x1DEAF0 VA: 0x1801DF6F0 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1DF8B0 Offset: 0x1DECB0 VA: 0x1801DF8B0 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x1DF750 Offset: 0x1DEB50 VA: 0x1801DF750 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1DF910 Offset: 0x1DED10 VA: 0x1801DF910 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1DF760 Offset: 0x1DEB60 VA: 0x1801DF760 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1DF970 Offset: 0x1DED70 VA: 0x1801DF970 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1DF7C0 Offset: 0x1DEBC0 VA: 0x1801DF7C0 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1DF690 Offset: 0x1DEA90 VA: 0x1801DF690 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1DF610 Offset: 0x1DEA10 VA: 0x1801DF610 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1DF600 Offset: 0x1DEA00 VA: 0x1801DF600 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1DF820 Offset: 0x1DEC20 VA: 0x1801DF820 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

}

