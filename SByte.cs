public struct SByte : IComparable, IFormattable, IConvertible, IComparable<sbyte>, IEquatable<sbyte> // TypeDefIndex: 296
{	// Fields
	private sbyte m_value; // 0x0
	public const sbyte MaxValue = 127;
	public const sbyte MinValue = -128;

	// Methods

	// RVA: 0x1DF9C0 Offset: 0x1DEDC0 VA: 0x1801DF9C0 Slot: 4
	public int CompareTo(object obj) { }

	// RVA: 0x1DF9B0 Offset: 0x1DEDB0 VA: 0x1801DF9B0 Slot: 23
	public int CompareTo(sbyte value) { }

	// RVA: 0x1DFA90 Offset: 0x1DEE90 VA: 0x1801DFA90 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1DFB20 Offset: 0x1DEF20 VA: 0x1801DFB20 Slot: 24
	public bool Equals(sbyte obj) { }

	// RVA: 0x1DFB30 Offset: 0x1DEF30 VA: 0x1801DFB30 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E01B0 Offset: 0x1DF5B0 VA: 0x1801E01B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E00E0 Offset: 0x1DF4E0 VA: 0x1801E00E0 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1E0110 Offset: 0x1DF510 VA: 0x1801E0110 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x1E0040 Offset: 0x1DF440 VA: 0x1801E0040
	private string ToString(string format, NumberFormatInfo info) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x12A4CE0 Offset: 0x12A32E0 VA: 0x1812A4CE0
	public static sbyte Parse(string s, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x12A4C90 Offset: 0x12A3290 VA: 0x1812A4C90
	public static sbyte Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x12A4D10 Offset: 0x12A3310 VA: 0x1812A4D10
	private static sbyte Parse(string s, NumberStyles style, NumberFormatInfo info) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x12A50B0 Offset: 0x12A36B0 VA: 0x1812A50B0
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out sbyte result) { }

	// RVA: 0x12A5030 Offset: 0x12A3630 VA: 0x1812A5030
	private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out sbyte result) { }

	// RVA: 0x1DFB40 Offset: 0x1DEF40 VA: 0x1801DFB40 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x1DFB50 Offset: 0x1DEF50 VA: 0x1801DFB50 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x1DFC10 Offset: 0x1DF010 VA: 0x1801DFC10 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x14CA30 Offset: 0x14BE30 VA: 0x18014CA30 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1DFBB0 Offset: 0x1DEFB0 VA: 0x1801DFBB0 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1DFD60 Offset: 0x1DF160 VA: 0x1801DFD60 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1DFF20 Offset: 0x1DF320 VA: 0x1801DFF20 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x1DFDC0 Offset: 0x1DF1C0 VA: 0x1801DFDC0 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1DFF80 Offset: 0x1DF380 VA: 0x1801DFF80 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1DFDD0 Offset: 0x1DF1D0 VA: 0x1801DFDD0 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1DFFE0 Offset: 0x1DF3E0 VA: 0x1801DFFE0 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1DFE30 Offset: 0x1DF230 VA: 0x1801DFE30 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1DFD00 Offset: 0x1DF100 VA: 0x1801DFD00 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1DFC80 Offset: 0x1DF080 VA: 0x1801DFC80 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1DFC70 Offset: 0x1DF070 VA: 0x1801DFC70 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1DFE90 Offset: 0x1DF290 VA: 0x1801DFE90 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

}

