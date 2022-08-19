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

	// RVA: 0x18AF550 Offset: 0x18ADB50 VA: 0x1818AF550
	public static bool IsInfinity(float f) { }

	// RVA: 0x18AF5B0 Offset: 0x18ADBB0 VA: 0x1818AF5B0
	public static bool IsPositiveInfinity(float f) { }

	// RVA: 0x18AF590 Offset: 0x18ADB90 VA: 0x1818AF590
	public static bool IsNegativeInfinity(float f) { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0x18AF570 Offset: 0x18ADB70 VA: 0x1818AF570
	public static bool IsNaN(float f) { }

	// RVA: 0x18AF530 Offset: 0x18ADB30 VA: 0x1818AF530
	public static bool IsFinite(float f) { }

	// RVA: 0x214730 Offset: 0x213B30 VA: 0x180214730 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x214870 Offset: 0x213C70 VA: 0x180214870 Slot: 23
	public int CompareTo(float value) { }

	// RVA: 0x214910 Offset: 0x213D10 VA: 0x180214910 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2148D0 Offset: 0x213CD0 VA: 0x1802148D0 Slot: 24
	public bool Equals(float obj) { }

	// RVA: 0x2149D0 Offset: 0x213DD0 VA: 0x1802149D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x214F40 Offset: 0x214340 VA: 0x180214F40 Slot: 3
	public override string ToString() { }

	// RVA: 0x214F70 Offset: 0x214370 VA: 0x180214F70 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x214F00 Offset: 0x214300 VA: 0x180214F00
	public string ToString(string format) { }

	// RVA: 0x214FB0 Offset: 0x2143B0 VA: 0x180214FB0 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x18AF600 Offset: 0x18ADC00 VA: 0x1818AF600
	public static float Parse(string s) { }

	// RVA: 0x18AF5D0 Offset: 0x18ADBD0 VA: 0x1818AF5D0
	public static float Parse(string s, IFormatProvider provider) { }

	// RVA: 0x18AF630 Offset: 0x18ADC30 VA: 0x1818AF630
	public static float Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x18AF680 Offset: 0x18ADC80 VA: 0x1818AF680
	private static float Parse(string s, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x18AFB10 Offset: 0x18AE110 VA: 0x1818AFB10
	public static bool TryParse(string s, out float result) { }

	// RVA: 0x18AFAB0 Offset: 0x18AE0B0 VA: 0x1818AFAB0
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out float result) { }

	// RVA: 0x18AF920 Offset: 0x18ADF20 VA: 0x1818AF920
	private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out float result) { }

	// RVA: 0x2149F0 Offset: 0x213DF0 VA: 0x1802149F0 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x214A00 Offset: 0x213E00 VA: 0x180214A00 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x214AC0 Offset: 0x213EC0 VA: 0x180214AC0 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x214CE0 Offset: 0x2140E0 VA: 0x180214CE0 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x214A60 Offset: 0x213E60 VA: 0x180214A60 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x214BC0 Offset: 0x213FC0 VA: 0x180214BC0 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x214DE0 Offset: 0x2141E0 VA: 0x180214DE0 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x214C20 Offset: 0x214020 VA: 0x180214C20 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x214E40 Offset: 0x214240 VA: 0x180214E40 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x214C80 Offset: 0x214080 VA: 0x180214C80 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x214EA0 Offset: 0x2142A0 VA: 0x180214EA0 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0xF2400 Offset: 0xF1800 VA: 0x1800F2400 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x214B60 Offset: 0x213F60 VA: 0x180214B60 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x214AE0 Offset: 0x213EE0 VA: 0x180214AE0 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x214AD0 Offset: 0x213ED0 VA: 0x180214AD0 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x214D40 Offset: 0x214140 VA: 0x180214D40 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

}

