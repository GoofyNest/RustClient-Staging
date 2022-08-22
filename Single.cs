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

	// RVA: 0x18AF7D0 Offset: 0x18ADDD0 VA: 0x1818AF7D0
	public static bool IsInfinity(float f) { }

	// RVA: 0x18AF830 Offset: 0x18ADE30 VA: 0x1818AF830
	public static bool IsPositiveInfinity(float f) { }

	// RVA: 0x18AF810 Offset: 0x18ADE10 VA: 0x1818AF810
	public static bool IsNegativeInfinity(float f) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x18AF7F0 Offset: 0x18ADDF0 VA: 0x1818AF7F0
	public static bool IsNaN(float f) { }

	// RVA: 0x18AF7B0 Offset: 0x18ADDB0 VA: 0x1818AF7B0
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

	// RVA: 0x18AF880 Offset: 0x18ADE80 VA: 0x1818AF880
	public static float Parse(string s) { }

	// RVA: 0x18AF850 Offset: 0x18ADE50 VA: 0x1818AF850
	public static float Parse(string s, IFormatProvider provider) { }

	// RVA: 0x18AF8B0 Offset: 0x18ADEB0 VA: 0x1818AF8B0
	public static float Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x18AF900 Offset: 0x18ADF00 VA: 0x1818AF900
	private static float Parse(string s, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x18AFD90 Offset: 0x18AE390 VA: 0x1818AFD90
	public static bool TryParse(string s, out float result) { }

	// RVA: 0x18AFD30 Offset: 0x18AE330 VA: 0x1818AFD30
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out float result) { }

	// RVA: 0x18AFBA0 Offset: 0x18AE1A0 VA: 0x1818AFBA0
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

