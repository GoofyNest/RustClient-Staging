public struct Single : IComparable, IFormattable, IConvertible, IComparable<float>, IEquatable<float> // TypeDefIndex: 299
{	// Fields
	internal float m_value; // 0x0
	public const float MinValue = -3,402823E+38;
	public const float Epsilon = 1,401298E-45;
	public const float MaxValue = 3,402823E+38;
	public const float PositiveInfinity = ∞;
	public const float NegativeInfinity = -∞;
	public const float NaN = ¤¤¤;

	// Methods

	// RVA: 0x18AEEF0 Offset: 0x18AD4F0 VA: 0x1818AEEF0
	public static bool IsInfinity(float f) { }

	// RVA: 0x18AEF50 Offset: 0x18AD550 VA: 0x1818AEF50
	public static bool IsPositiveInfinity(float f) { }

	// RVA: 0x18AEF30 Offset: 0x18AD530 VA: 0x1818AEF30
	public static bool IsNegativeInfinity(float f) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x18AEF10 Offset: 0x18AD510 VA: 0x1818AEF10
	public static bool IsNaN(float f) { }

	// RVA: 0x18AEED0 Offset: 0x18AD4D0 VA: 0x1818AEED0
	public static bool IsFinite(float f) { }

	// RVA: 0x214D80 Offset: 0x214180 VA: 0x180214D80 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x214EC0 Offset: 0x2142C0 VA: 0x180214EC0 Slot: 23
	public int CompareTo(float value) { }

	// RVA: 0x214F60 Offset: 0x214360 VA: 0x180214F60 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x214F20 Offset: 0x214320 VA: 0x180214F20 Slot: 24
	public bool Equals(float obj) { }

	// RVA: 0x215020 Offset: 0x214420 VA: 0x180215020 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x215590 Offset: 0x214990 VA: 0x180215590 Slot: 3
	public override string ToString() { }

	// RVA: 0x2155C0 Offset: 0x2149C0 VA: 0x1802155C0 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x215550 Offset: 0x214950 VA: 0x180215550
	public string ToString(string format) { }

	// RVA: 0x215600 Offset: 0x214A00 VA: 0x180215600 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x18AEFA0 Offset: 0x18AD5A0 VA: 0x1818AEFA0
	public static float Parse(string s) { }

	// RVA: 0x18AEF70 Offset: 0x18AD570 VA: 0x1818AEF70
	public static float Parse(string s, IFormatProvider provider) { }

	// RVA: 0x18AEFD0 Offset: 0x18AD5D0 VA: 0x1818AEFD0
	public static float Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x18AF020 Offset: 0x18AD620 VA: 0x1818AF020
	private static float Parse(string s, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x18AF4B0 Offset: 0x18ADAB0 VA: 0x1818AF4B0
	public static bool TryParse(string s, out float result) { }

	// RVA: 0x18AF450 Offset: 0x18ADA50 VA: 0x1818AF450
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out float result) { }

	// RVA: 0x18AF2C0 Offset: 0x18AD8C0 VA: 0x1818AF2C0
	private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out float result) { }

	// RVA: 0x215040 Offset: 0x214440 VA: 0x180215040 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x215050 Offset: 0x214450 VA: 0x180215050 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x215110 Offset: 0x214510 VA: 0x180215110 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x215330 Offset: 0x214730 VA: 0x180215330 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x2150B0 Offset: 0x2144B0 VA: 0x1802150B0 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x215210 Offset: 0x214610 VA: 0x180215210 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x215430 Offset: 0x214830 VA: 0x180215430 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x215270 Offset: 0x214670 VA: 0x180215270 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x215490 Offset: 0x214890 VA: 0x180215490 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x2152D0 Offset: 0x2146D0 VA: 0x1802152D0 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x2154F0 Offset: 0x2148F0 VA: 0x1802154F0 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0xF2380 Offset: 0xF1780 VA: 0x1800F2380 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x2151B0 Offset: 0x2145B0 VA: 0x1802151B0 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x215130 Offset: 0x214530 VA: 0x180215130 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x215120 Offset: 0x214520 VA: 0x180215120 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x215390 Offset: 0x214790 VA: 0x180215390 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

}

