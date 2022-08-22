public struct Int16 : IComparable, IFormattable, IConvertible, IComparable<short>, IEquatable<short> // TypeDefIndex: 257
{	// Fields
	internal short m_value; // 0x0
	public const short MaxValue = 32767;
	public const short MinValue = -32768;

	// Methods

	// RVA: 0x1FA280 Offset: 0x1F9680 VA: 0x1801FA280 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x1FA270 Offset: 0x1F9670 VA: 0x1801FA270 Slot: 23
	public int CompareTo(short value) { }

	// RVA: 0x1FA350 Offset: 0x1F9750 VA: 0x1801FA350 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1F2F70 Offset: 0x1F2370 VA: 0x1801F2F70 Slot: 24
	public bool Equals(short obj) { }

	// RVA: 0x1FA3E0 Offset: 0x1F97E0 VA: 0x1801FA3E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1FA980 Offset: 0x1F9D80 VA: 0x1801FA980 Slot: 3
	public override string ToString() { }

	// RVA: 0x1FA940 Offset: 0x1F9D40 VA: 0x1801FA940 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1FA9B0 Offset: 0x1F9DB0 VA: 0x1801FA9B0 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x1FA970 Offset: 0x1F9D70 VA: 0x1801FA970
	private string ToString(string format, NumberFormatInfo info) { }

	// RVA: 0x1672090 Offset: 0x1670690 VA: 0x181672090
	public static short Parse(string s, IFormatProvider provider) { }

	// RVA: 0x16720C0 Offset: 0x16706C0 VA: 0x1816720C0
	public static short Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x1672110 Offset: 0x1670710 VA: 0x181672110
	private static short Parse(string s, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x1672620 Offset: 0x1670C20 VA: 0x181672620
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out short result) { }

	// RVA: 0x16725A0 Offset: 0x1670BA0 VA: 0x1816725A0
	private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out short result) { }

	// RVA: 0x1FA3F0 Offset: 0x1F97F0 VA: 0x1801FA3F0 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x1FA400 Offset: 0x1F9800 VA: 0x1801FA400 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x1FA4C0 Offset: 0x1F98C0 VA: 0x1801FA4C0 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x1FA6D0 Offset: 0x1F9AD0 VA: 0x1801FA6D0 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1FA460 Offset: 0x1F9860 VA: 0x1801FA460 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x121080 Offset: 0x120480 VA: 0x180121080 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1FA820 Offset: 0x1F9C20 VA: 0x1801FA820 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x1FA610 Offset: 0x1F9A10 VA: 0x1801FA610 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1FA880 Offset: 0x1F9C80 VA: 0x1801FA880 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1FA670 Offset: 0x1F9A70 VA: 0x1801FA670 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1FA8E0 Offset: 0x1F9CE0 VA: 0x1801FA8E0 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1FA730 Offset: 0x1F9B30 VA: 0x1801FA730 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1FA5B0 Offset: 0x1F99B0 VA: 0x1801FA5B0 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1FA530 Offset: 0x1F9930 VA: 0x1801FA530 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1FA520 Offset: 0x1F9920 VA: 0x1801FA520 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1FA790 Offset: 0x1F9B90 VA: 0x1801FA790 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

}

