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

	// RVA: 0x18AF510 Offset: 0x18ADB10 VA: 0x1818AF510
	public static bool IsInfinity(float f) { }

	// RVA: 0x18AF570 Offset: 0x18ADB70 VA: 0x1818AF570
	public static bool IsPositiveInfinity(float f) { }

	// RVA: 0x18AF550 Offset: 0x18ADB50 VA: 0x1818AF550
	public static bool IsNegativeInfinity(float f) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x18AF530 Offset: 0x18ADB30 VA: 0x1818AF530
	public static bool IsNaN(float f) { }

	// RVA: 0x18AF4F0 Offset: 0x18ADAF0 VA: 0x1818AF4F0
	public static bool IsFinite(float f) { }

	// RVA: 0x2146B0 Offset: 0x213AB0 VA: 0x1802146B0 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x2147F0 Offset: 0x213BF0 VA: 0x1802147F0 Slot: 23
	public int CompareTo(float value) { }

	// RVA: 0x214890 Offset: 0x213C90 VA: 0x180214890 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x214850 Offset: 0x213C50 VA: 0x180214850 Slot: 24
	public bool Equals(float obj) { }

	// RVA: 0x214950 Offset: 0x213D50 VA: 0x180214950 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x214EC0 Offset: 0x2142C0 VA: 0x180214EC0 Slot: 3
	public override string ToString() { }

	// RVA: 0x214EF0 Offset: 0x2142F0 VA: 0x180214EF0 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x214E80 Offset: 0x214280 VA: 0x180214E80
	public string ToString(string format) { }

	// RVA: 0x214F30 Offset: 0x214330 VA: 0x180214F30 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x18AF5C0 Offset: 0x18ADBC0 VA: 0x1818AF5C0
	public static float Parse(string s) { }

	// RVA: 0x18AF590 Offset: 0x18ADB90 VA: 0x1818AF590
	public static float Parse(string s, IFormatProvider provider) { }

	// RVA: 0x18AF5F0 Offset: 0x18ADBF0 VA: 0x1818AF5F0
	public static float Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x18AF640 Offset: 0x18ADC40 VA: 0x1818AF640
	private static float Parse(string s, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x18AFAD0 Offset: 0x18AE0D0 VA: 0x1818AFAD0
	public static bool TryParse(string s, out float result) { }

	// RVA: 0x18AFA70 Offset: 0x18AE070 VA: 0x1818AFA70
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out float result) { }

	// RVA: 0x18AF8E0 Offset: 0x18ADEE0 VA: 0x1818AF8E0
	private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out float result) { }

	// RVA: 0x214970 Offset: 0x213D70 VA: 0x180214970 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x214980 Offset: 0x213D80 VA: 0x180214980 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x214A40 Offset: 0x213E40 VA: 0x180214A40 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x214C60 Offset: 0x214060 VA: 0x180214C60 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x2149E0 Offset: 0x213DE0 VA: 0x1802149E0 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x214B40 Offset: 0x213F40 VA: 0x180214B40 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x214D60 Offset: 0x214160 VA: 0x180214D60 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x214BA0 Offset: 0x213FA0 VA: 0x180214BA0 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x214DC0 Offset: 0x2141C0 VA: 0x180214DC0 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x214C00 Offset: 0x214000 VA: 0x180214C00 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x214E20 Offset: 0x214220 VA: 0x180214E20 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0xF2380 Offset: 0xF1780 VA: 0x1800F2380 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x214AE0 Offset: 0x213EE0 VA: 0x180214AE0 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x214A60 Offset: 0x213E60 VA: 0x180214A60 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x214A50 Offset: 0x213E50 VA: 0x180214A50 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x214CC0 Offset: 0x2140C0 VA: 0x180214CC0 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

}

