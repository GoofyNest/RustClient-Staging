public struct Byte : IComparable, IFormattable, IConvertible, IComparable<byte>, IEquatable<byte> // TypeDefIndex: 181
{	// Fields
	private byte m_value; // 0x0
	public const byte MaxValue = 255;
	public const byte MinValue = 0;

	// Methods

	// RVA: 0x1F2670 Offset: 0x1F1A70 VA: 0x1801F2670 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x1F2660 Offset: 0x1F1A60 VA: 0x1801F2660 Slot: 23
	public int CompareTo(byte value) { }

	// RVA: 0x1F2740 Offset: 0x1F1B40 VA: 0x1801F2740 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1DF4B0 Offset: 0x1DE8B0 VA: 0x1801DF4B0 Slot: 24
	public bool Equals(byte obj) { }

	// RVA: 0x14CC10 Offset: 0x14C010 VA: 0x18014CC10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1561960 Offset: 0x155FF60 VA: 0x181561960
	public static byte Parse(string s, IFormatProvider provider) { }

	// RVA: 0x1561990 Offset: 0x155FF90 VA: 0x181561990
	public static byte Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x1561870 Offset: 0x155FE70 VA: 0x181561870
	private static byte Parse(string s, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x1562190 Offset: 0x1560790 VA: 0x181562190
	public static bool TryParse(string s, out byte result) { }

	// RVA: 0x15620B0 Offset: 0x15606B0 VA: 0x1815620B0
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out byte result) { }

	// RVA: 0x1562140 Offset: 0x1560740 VA: 0x181562140
	private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out byte result) { }

	// RVA: 0x1F2D50 Offset: 0x1F2150 VA: 0x1801F2D50 Slot: 3
	public override string ToString() { }

	// RVA: 0x1F2D80 Offset: 0x1F2180 VA: 0x1801F2D80
	public string ToString(string format) { }

	// RVA: 0x1F2D20 Offset: 0x1F2120 VA: 0x1801F2D20 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1F2DC0 Offset: 0x1F21C0 VA: 0x1801F2DC0 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x1F27D0 Offset: 0x1F1BD0 VA: 0x1801F27D0 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x1F27E0 Offset: 0x1F1BE0 VA: 0x1801F27E0 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x1F2840 Offset: 0x1F1C40 VA: 0x1801F2840 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x1F2AB0 Offset: 0x1F1EB0 VA: 0x1801F2AB0 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x14CC10 Offset: 0x14C010 VA: 0x18014CC10 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1F2990 Offset: 0x1F1D90 VA: 0x1801F2990 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1F2C00 Offset: 0x1F2000 VA: 0x1801F2C00 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x1F29F0 Offset: 0x1F1DF0 VA: 0x1801F29F0 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1F2C60 Offset: 0x1F2060 VA: 0x1801F2C60 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1F2A50 Offset: 0x1F1E50 VA: 0x1801F2A50 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1F2CC0 Offset: 0x1F20C0 VA: 0x1801F2CC0 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1F2B10 Offset: 0x1F1F10 VA: 0x1801F2B10 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1F2930 Offset: 0x1F1D30 VA: 0x1801F2930 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1F28B0 Offset: 0x1F1CB0 VA: 0x1801F28B0 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1F28A0 Offset: 0x1F1CA0 VA: 0x1801F28A0 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1F2B70 Offset: 0x1F1F70 VA: 0x1801F2B70 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

}

