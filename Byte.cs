public struct Byte : IComparable, IFormattable, IConvertible, IComparable<byte>, IEquatable<byte> // TypeDefIndex: 181
{	// Fields
	private byte m_value; // 0x0
	public const byte MaxValue = 255;
	public const byte MinValue = 0;

	// Methods

	// RVA: 0x1F26F0 Offset: 0x1F1AF0 VA: 0x1801F26F0 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x1F26E0 Offset: 0x1F1AE0 VA: 0x1801F26E0 Slot: 23
	public int CompareTo(byte value) { }

	// RVA: 0x1F27C0 Offset: 0x1F1BC0 VA: 0x1801F27C0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1DF530 Offset: 0x1DE930 VA: 0x1801DF530 Slot: 24
	public bool Equals(byte obj) { }

	// RVA: 0x14CC90 Offset: 0x14C090 VA: 0x18014CC90 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15616A0 Offset: 0x155FCA0 VA: 0x1815616A0
	public static byte Parse(string s, IFormatProvider provider) { }

	// RVA: 0x15616D0 Offset: 0x155FCD0 VA: 0x1815616D0
	public static byte Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x15615B0 Offset: 0x155FBB0 VA: 0x1815615B0
	private static byte Parse(string s, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x1561ED0 Offset: 0x15604D0 VA: 0x181561ED0
	public static bool TryParse(string s, out byte result) { }

	// RVA: 0x1561DF0 Offset: 0x15603F0 VA: 0x181561DF0
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out byte result) { }

	// RVA: 0x1561E80 Offset: 0x1560480 VA: 0x181561E80
	private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out byte result) { }

	// RVA: 0x1F2DD0 Offset: 0x1F21D0 VA: 0x1801F2DD0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1F2E00 Offset: 0x1F2200 VA: 0x1801F2E00
	public string ToString(string format) { }

	// RVA: 0x1F2DA0 Offset: 0x1F21A0 VA: 0x1801F2DA0 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1F2E40 Offset: 0x1F2240 VA: 0x1801F2E40 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x1F2850 Offset: 0x1F1C50 VA: 0x1801F2850 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x1F2860 Offset: 0x1F1C60 VA: 0x1801F2860 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x1F28C0 Offset: 0x1F1CC0 VA: 0x1801F28C0 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x1F2B30 Offset: 0x1F1F30 VA: 0x1801F2B30 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x14CC90 Offset: 0x14C090 VA: 0x18014CC90 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1F2A10 Offset: 0x1F1E10 VA: 0x1801F2A10 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1F2C80 Offset: 0x1F2080 VA: 0x1801F2C80 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x1F2A70 Offset: 0x1F1E70 VA: 0x1801F2A70 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1F2CE0 Offset: 0x1F20E0 VA: 0x1801F2CE0 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1F2AD0 Offset: 0x1F1ED0 VA: 0x1801F2AD0 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1F2D40 Offset: 0x1F2140 VA: 0x1801F2D40 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1F2B90 Offset: 0x1F1F90 VA: 0x1801F2B90 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1F29B0 Offset: 0x1F1DB0 VA: 0x1801F29B0 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1F2930 Offset: 0x1F1D30 VA: 0x1801F2930 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1F2920 Offset: 0x1F1D20 VA: 0x1801F2920 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1F2BF0 Offset: 0x1F1FF0 VA: 0x1801F2BF0 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

}

