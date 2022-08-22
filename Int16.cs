public struct Int16 : IComparable, IFormattable, IConvertible, IComparable<short>, IEquatable<short> // TypeDefIndex: 257
{	// Fields
	internal short m_value; // 0x0
	public const short MaxValue = 32767;
	public const short MinValue = -32768;

	// Methods

	// RVA: 0x1F9EB0 Offset: 0x1F92B0 VA: 0x1801F9EB0 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x1F9EA0 Offset: 0x1F92A0 VA: 0x1801F9EA0 Slot: 23
	public int CompareTo(short value) { }

	// RVA: 0x1F9F80 Offset: 0x1F9380 VA: 0x1801F9F80 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1F3390 Offset: 0x1F2790 VA: 0x1801F3390 Slot: 24
	public bool Equals(short obj) { }

	// RVA: 0x1FA010 Offset: 0x1F9410 VA: 0x1801FA010 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1FA5B0 Offset: 0x1F99B0 VA: 0x1801FA5B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1FA570 Offset: 0x1F9970 VA: 0x1801FA570 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1FA5E0 Offset: 0x1F99E0 VA: 0x1801FA5E0 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x1FA5A0 Offset: 0x1F99A0 VA: 0x1801FA5A0
	private string ToString(string format, NumberFormatInfo info) { }

	// RVA: 0x166FF40 Offset: 0x166E540 VA: 0x18166FF40
	public static short Parse(string s, IFormatProvider provider) { }

	// RVA: 0x166FF70 Offset: 0x166E570 VA: 0x18166FF70
	public static short Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x166FFC0 Offset: 0x166E5C0 VA: 0x18166FFC0
	private static short Parse(string s, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x16704D0 Offset: 0x166EAD0 VA: 0x1816704D0
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out short result) { }

	// RVA: 0x1670450 Offset: 0x166EA50 VA: 0x181670450
	private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out short result) { }

	// RVA: 0x1FA020 Offset: 0x1F9420 VA: 0x1801FA020 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x1FA030 Offset: 0x1F9430 VA: 0x1801FA030 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x1FA0F0 Offset: 0x1F94F0 VA: 0x1801FA0F0 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x1FA300 Offset: 0x1F9700 VA: 0x1801FA300 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1FA090 Offset: 0x1F9490 VA: 0x1801FA090 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x120EA0 Offset: 0x1202A0 VA: 0x180120EA0 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1FA450 Offset: 0x1F9850 VA: 0x1801FA450 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x1FA240 Offset: 0x1F9640 VA: 0x1801FA240 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1FA4B0 Offset: 0x1F98B0 VA: 0x1801FA4B0 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1FA2A0 Offset: 0x1F96A0 VA: 0x1801FA2A0 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1FA510 Offset: 0x1F9910 VA: 0x1801FA510 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1FA360 Offset: 0x1F9760 VA: 0x1801FA360 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1FA1E0 Offset: 0x1F95E0 VA: 0x1801FA1E0 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1FA160 Offset: 0x1F9560 VA: 0x1801FA160 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1FA150 Offset: 0x1F9550 VA: 0x1801FA150 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1FA3C0 Offset: 0x1F97C0 VA: 0x1801FA3C0 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

}

