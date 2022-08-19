public struct SByte : IComparable, IFormattable, IConvertible, IComparable<sbyte>, IEquatable<sbyte> // TypeDefIndex: 296
{	// Fields
	private sbyte m_value; // 0x0
	public const sbyte MaxValue = 127;
	public const sbyte MinValue = -128;

	// Methods

	// RVA: 0x1DF3D0 Offset: 0x1DE7D0 VA: 0x1801DF3D0 Slot: 4
	public int CompareTo(object obj) { }

	// RVA: 0x1DF3C0 Offset: 0x1DE7C0 VA: 0x1801DF3C0 Slot: 23
	public int CompareTo(sbyte value) { }

	// RVA: 0x1DF4A0 Offset: 0x1DE8A0 VA: 0x1801DF4A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1DF530 Offset: 0x1DE930 VA: 0x1801DF530 Slot: 24
	public bool Equals(sbyte obj) { }

	// RVA: 0x1DF540 Offset: 0x1DE940 VA: 0x1801DF540 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1DFBC0 Offset: 0x1DEFC0 VA: 0x1801DFBC0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1DFAF0 Offset: 0x1DEEF0 VA: 0x1801DFAF0 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1DFB20 Offset: 0x1DEF20 VA: 0x1801DFB20 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x1DFA50 Offset: 0x1DEE50 VA: 0x1801DFA50
	private string ToString(string format, NumberFormatInfo info) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x12A4380 Offset: 0x12A2980 VA: 0x1812A4380
	public static sbyte Parse(string s, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x12A4330 Offset: 0x12A2930 VA: 0x1812A4330
	public static sbyte Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x12A43B0 Offset: 0x12A29B0 VA: 0x1812A43B0
	private static sbyte Parse(string s, NumberStyles style, NumberFormatInfo info) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x12A4750 Offset: 0x12A2D50 VA: 0x1812A4750
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out sbyte result) { }

	// RVA: 0x12A46D0 Offset: 0x12A2CD0 VA: 0x1812A46D0
	private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out sbyte result) { }

	// RVA: 0x1DF550 Offset: 0x1DE950 VA: 0x1801DF550 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x1DF560 Offset: 0x1DE960 VA: 0x1801DF560 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x1DF620 Offset: 0x1DEA20 VA: 0x1801DF620 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x14CC90 Offset: 0x14C090 VA: 0x18014CC90 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1DF5C0 Offset: 0x1DE9C0 VA: 0x1801DF5C0 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1DF770 Offset: 0x1DEB70 VA: 0x1801DF770 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1DF930 Offset: 0x1DED30 VA: 0x1801DF930 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x1DF7D0 Offset: 0x1DEBD0 VA: 0x1801DF7D0 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1DF990 Offset: 0x1DED90 VA: 0x1801DF990 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1DF7E0 Offset: 0x1DEBE0 VA: 0x1801DF7E0 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1DF9F0 Offset: 0x1DEDF0 VA: 0x1801DF9F0 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1DF840 Offset: 0x1DEC40 VA: 0x1801DF840 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1DF710 Offset: 0x1DEB10 VA: 0x1801DF710 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1DF690 Offset: 0x1DEA90 VA: 0x1801DF690 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1DF680 Offset: 0x1DEA80 VA: 0x1801DF680 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1DF8A0 Offset: 0x1DECA0 VA: 0x1801DF8A0 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

}

