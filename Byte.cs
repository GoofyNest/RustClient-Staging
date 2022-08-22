public struct Byte : IComparable, IFormattable, IConvertible, IComparable<byte>, IEquatable<byte> // TypeDefIndex: 181
{	// Fields
	private byte m_value; // 0x0
	public const byte MaxValue = 255;
	public const byte MinValue = 0;

	// Methods

	// RVA: 0x1F2A90 Offset: 0x1F1E90 VA: 0x1801F2A90 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x1F2A80 Offset: 0x1F1E80 VA: 0x1801F2A80 Slot: 23
	public int CompareTo(byte value) { }

	// RVA: 0x1F2B60 Offset: 0x1F1F60 VA: 0x1801F2B60 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1DFB20 Offset: 0x1DEF20 VA: 0x1801DFB20 Slot: 24
	public bool Equals(byte obj) { }

	// RVA: 0x14CA30 Offset: 0x14BE30 VA: 0x18014CA30 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1560A30 Offset: 0x155F030 VA: 0x181560A30
	public static byte Parse(string s, IFormatProvider provider) { }

	// RVA: 0x1560A60 Offset: 0x155F060 VA: 0x181560A60
	public static byte Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x1560940 Offset: 0x155EF40 VA: 0x181560940
	private static byte Parse(string s, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x1561260 Offset: 0x155F860 VA: 0x181561260
	public static bool TryParse(string s, out byte result) { }

	// RVA: 0x1561180 Offset: 0x155F780 VA: 0x181561180
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out byte result) { }

	// RVA: 0x1561210 Offset: 0x155F810 VA: 0x181561210
	private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out byte result) { }

	// RVA: 0x1F3170 Offset: 0x1F2570 VA: 0x1801F3170 Slot: 3
	public override string ToString() { }

	// RVA: 0x1F31A0 Offset: 0x1F25A0 VA: 0x1801F31A0
	public string ToString(string format) { }

	// RVA: 0x1F3140 Offset: 0x1F2540 VA: 0x1801F3140 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1F31E0 Offset: 0x1F25E0 VA: 0x1801F31E0 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x1F2BF0 Offset: 0x1F1FF0 VA: 0x1801F2BF0 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x1F2C00 Offset: 0x1F2000 VA: 0x1801F2C00 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x1F2C60 Offset: 0x1F2060 VA: 0x1801F2C60 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x1F2ED0 Offset: 0x1F22D0 VA: 0x1801F2ED0 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x14CA30 Offset: 0x14BE30 VA: 0x18014CA30 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1F2DB0 Offset: 0x1F21B0 VA: 0x1801F2DB0 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1F3020 Offset: 0x1F2420 VA: 0x1801F3020 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x1F2E10 Offset: 0x1F2210 VA: 0x1801F2E10 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1F3080 Offset: 0x1F2480 VA: 0x1801F3080 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1F2E70 Offset: 0x1F2270 VA: 0x1801F2E70 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1F30E0 Offset: 0x1F24E0 VA: 0x1801F30E0 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1F2F30 Offset: 0x1F2330 VA: 0x1801F2F30 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1F2D50 Offset: 0x1F2150 VA: 0x1801F2D50 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1F2CD0 Offset: 0x1F20D0 VA: 0x1801F2CD0 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1F2CC0 Offset: 0x1F20C0 VA: 0x1801F2CC0 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1F2F90 Offset: 0x1F2390 VA: 0x1801F2F90 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

}

