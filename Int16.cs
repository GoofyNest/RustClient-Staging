public struct Int16 : IComparable, IFormattable, IConvertible, IComparable<short>, IEquatable<short> // TypeDefIndex: 257
{	// Fields
	internal short m_value; // 0x0
	public const short MaxValue = 32767;
	public const short MinValue = -32768;

	// Methods

	// RVA: 0x1FA300 Offset: 0x1F9700 VA: 0x1801FA300 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x1FA2F0 Offset: 0x1F96F0 VA: 0x1801FA2F0 Slot: 23
	public int CompareTo(short value) { }

	// RVA: 0x1FA3D0 Offset: 0x1F97D0 VA: 0x1801FA3D0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1F2FF0 Offset: 0x1F23F0 VA: 0x1801F2FF0 Slot: 24
	public bool Equals(short obj) { }

	// RVA: 0x1FA460 Offset: 0x1F9860 VA: 0x1801FA460 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1FAA00 Offset: 0x1F9E00 VA: 0x1801FAA00 Slot: 3
	public override string ToString() { }

	// RVA: 0x1FA9C0 Offset: 0x1F9DC0 VA: 0x1801FA9C0 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1FAA30 Offset: 0x1F9E30 VA: 0x1801FAA30 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x1FA9F0 Offset: 0x1F9DF0 VA: 0x1801FA9F0
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

	// RVA: 0x1FA470 Offset: 0x1F9870 VA: 0x1801FA470 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x1FA480 Offset: 0x1F9880 VA: 0x1801FA480 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x1FA540 Offset: 0x1F9940 VA: 0x1801FA540 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x1FA750 Offset: 0x1F9B50 VA: 0x1801FA750 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1FA4E0 Offset: 0x1F98E0 VA: 0x1801FA4E0 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x121100 Offset: 0x120500 VA: 0x180121100 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1FA8A0 Offset: 0x1F9CA0 VA: 0x1801FA8A0 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x1FA690 Offset: 0x1F9A90 VA: 0x1801FA690 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1FA900 Offset: 0x1F9D00 VA: 0x1801FA900 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1FA6F0 Offset: 0x1F9AF0 VA: 0x1801FA6F0 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1FA960 Offset: 0x1F9D60 VA: 0x1801FA960 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1FA7B0 Offset: 0x1F9BB0 VA: 0x1801FA7B0 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1FA630 Offset: 0x1F9A30 VA: 0x1801FA630 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1FA5B0 Offset: 0x1F99B0 VA: 0x1801FA5B0 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1FA5A0 Offset: 0x1F99A0 VA: 0x1801FA5A0 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1FA810 Offset: 0x1F9C10 VA: 0x1801FA810 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

}

