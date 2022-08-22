public struct Decimal : IFormattable, IComparable, IConvertible, IDeserializationCallback, IComparable<Decimal>, IEquatable<Decimal> // TypeDefIndex: 202
{	// Fields
	private const int SignMask = -2147483648;
	private const byte DECIMAL_NEG = 128;
	private const byte DECIMAL_ADD = 0;
	private const int ScaleMask = 16711680;
	private const int ScaleShift = 16;
	private const int MaxInt32Scale = 9;
	private static uint[] Powers10; // 0x0
	[DecimalConstantAttribute] // RVA: 0x76340 Offset: 0x75740 VA: 0x180076340
	public static readonly Decimal Zero; // 0x8
	[DecimalConstantAttribute] // RVA: 0x763C0 Offset: 0x757C0 VA: 0x1800763C0
	public static readonly Decimal One; // 0x18
	[DecimalConstantAttribute] // RVA: 0x76490 Offset: 0x75890 VA: 0x180076490
	public static readonly Decimal MinusOne; // 0x28
	[DecimalConstantAttribute] // RVA: 0x76550 Offset: 0x75950 VA: 0x180076550
	public static readonly Decimal MaxValue; // 0x38
	[DecimalConstantAttribute] // RVA: 0x766D0 Offset: 0x75AD0 VA: 0x1800766D0
	public static readonly Decimal MinValue; // 0x48
	[DecimalConstantAttribute] // RVA: 0x76780 Offset: 0x75B80 VA: 0x180076780
	private static readonly Decimal NearNegativeZero; // 0x58
	[DecimalConstantAttribute] // RVA: 0x76880 Offset: 0x75C80 VA: 0x180076880
	private static readonly Decimal NearPositiveZero; // 0x68
	private int flags; // 0x0
	private int hi; // 0x4
	private int lo; // 0x8
	private int mid; // 0xC

	// Methods

	// RVA: 0x20DD80 Offset: 0x20D180 VA: 0x18020DD80
	public void .ctor(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x20DD70 Offset: 0x20D170 VA: 0x18020DD70
	public void .ctor(uint value) { }

	// RVA: 0x20DE00 Offset: 0x20D200 VA: 0x18020DE00
	public void .ctor(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x20DD50 Offset: 0x20D150 VA: 0x18020DD50
	public void .ctor(ulong value) { }

	// RVA: 0x20DDF0 Offset: 0x20D1F0 VA: 0x18020DDF0
	public void .ctor(float value) { }

	// RVA: 0x20DDB0 Offset: 0x20D1B0 VA: 0x18020DDB0
	public void .ctor(double value) { }

	// RVA: 0x20DC30 Offset: 0x20D030 VA: 0x18020DC30
	public void .ctor(int[] bits) { }

	// RVA: 0x20D5D0 Offset: 0x20C9D0 VA: 0x18020D5D0
	private void SetBits(int[] bits) { }

	// RVA: 0x20DDC0 Offset: 0x20D1C0 VA: 0x18020DDC0
	public void .ctor(int lo, int mid, int hi, bool isNegative, byte scale) { }

	[OnSerializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x20D5B0 Offset: 0x20C9B0 VA: 0x18020D5B0
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x20DB60 Offset: 0x20CF60 VA: 0x18020DB60 Slot: 23
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x20DDE0 Offset: 0x20D1E0 VA: 0x18020DDE0
	private void .ctor(int lo, int mid, int hi, int flags) { }

	// RVA: 0x17A8000 Offset: 0x17A6600 VA: 0x1817A8000
	public static Decimal Add(Decimal d1, Decimal d2) { }

	// RVA: 0x17A83D0 Offset: 0x17A69D0 VA: 0x1817A83D0
	private static void FCallAddSub(ref Decimal d1, ref Decimal d2, byte bSign) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x17A81D0 Offset: 0x17A67D0 VA: 0x1817A81D0
	public static int Compare(Decimal d1, Decimal d2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x17A83E0 Offset: 0x17A69E0 VA: 0x1817A83E0
	private static int FCallCompare(ref Decimal d1, ref Decimal d2) { }

	// RVA: 0x20D310 Offset: 0x20C710 VA: 0x18020D310 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x20D400 Offset: 0x20C800 VA: 0x18020D400 Slot: 24
	public int CompareTo(Decimal value) { }

	// RVA: 0x17A8230 Offset: 0x17A6830 VA: 0x1817A8230
	public static Decimal Divide(Decimal d1, Decimal d2) { }

	// RVA: 0x17A83F0 Offset: 0x17A69F0 VA: 0x1817A83F0
	private static void FCallDivide(ref Decimal d1, ref Decimal d2) { }

	// RVA: 0x20D4D0 Offset: 0x20C8D0 VA: 0x18020D4D0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x20D460 Offset: 0x20C860 VA: 0x18020D460 Slot: 25
	public bool Equals(Decimal value) { }

	// RVA: 0x20D590 Offset: 0x20C990 VA: 0x18020D590 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20DB70 Offset: 0x20CF70 VA: 0x18020DB70 Slot: 3
	public override string ToString() { }

	// RVA: 0x20DBB0 Offset: 0x20CFB0 VA: 0x18020DBB0 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x20DBF0 Offset: 0x20CFF0 VA: 0x18020DBF0 Slot: 4
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x17A8810 Offset: 0x17A6E10 VA: 0x1817A8810
	public static Decimal Parse(string s, IFormatProvider provider) { }

	// RVA: 0x17A8860 Offset: 0x17A6E60 VA: 0x1817A8860
	public static Decimal Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x17A9950 Offset: 0x17A7F50 VA: 0x1817A9950
	public static bool TryParse(string s, out Decimal result) { }

	// RVA: 0x17A98F0 Offset: 0x17A7EF0 VA: 0x1817A98F0
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out Decimal result) { }

	// RVA: 0x17A8450 Offset: 0x17A6A50 VA: 0x1817A8450
	public static int[] GetBits(Decimal d) { }

	// RVA: 0x17A8E00 Offset: 0x17A7400 VA: 0x1817A8E00
	internal static Decimal ToDecimal(byte[] buffer) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x17A8530 Offset: 0x17A6B30 VA: 0x1817A8530
	internal static Decimal Max(Decimal d1, Decimal d2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x17A85C0 Offset: 0x17A6BC0 VA: 0x1817A85C0
	internal static Decimal Min(Decimal d1, Decimal d2) { }

	// RVA: 0x17A8650 Offset: 0x17A6C50 VA: 0x1817A8650
	public static Decimal Multiply(Decimal d1, Decimal d2) { }

	// RVA: 0x17A8400 Offset: 0x17A6A00 VA: 0x1817A8400
	private static void FCallMultiply(ref Decimal d1, ref Decimal d2) { }

	// RVA: 0x17A86D0 Offset: 0x17A6CD0 VA: 0x1817A86D0
	public static Decimal Negate(Decimal d) { }

	// RVA: 0x17A88D0 Offset: 0x17A6ED0 VA: 0x1817A88D0
	public static Decimal Round(Decimal d, int decimals) { }

	// RVA: 0x17A8410 Offset: 0x17A6A10 VA: 0x1817A8410
	private static void FCallRound(ref Decimal d, int decimals) { }

	// RVA: 0x17A8CF0 Offset: 0x17A72F0 VA: 0x1817A8CF0
	public static byte ToByte(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x17A93C0 Offset: 0x17A79C0 VA: 0x1817A93C0
	public static sbyte ToSByte(Decimal value) { }

	// RVA: 0x17A90E0 Offset: 0x17A76E0 VA: 0x1817A90E0
	public static short ToInt16(Decimal value) { }

	// RVA: 0x17A90C0 Offset: 0x17A76C0 VA: 0x1817A90C0
	public static double ToDouble(Decimal d) { }

	// RVA: 0x17A8420 Offset: 0x17A6A20 VA: 0x1817A8420
	internal static int FCallToInt32(Decimal d) { }

	// RVA: 0x17A91F0 Offset: 0x17A77F0 VA: 0x1817A91F0
	public static int ToInt32(Decimal d) { }

	// RVA: 0x17A92D0 Offset: 0x17A78D0 VA: 0x1817A92D0
	public static long ToInt64(Decimal d) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x17A95B0 Offset: 0x17A7BB0 VA: 0x1817A95B0
	public static ushort ToUInt16(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x17A96C0 Offset: 0x17A7CC0 VA: 0x1817A96C0
	public static uint ToUInt32(Decimal d) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x17A97A0 Offset: 0x17A7DA0 VA: 0x1817A97A0
	public static ulong ToUInt64(Decimal d) { }

	// RVA: 0x17A94D0 Offset: 0x17A7AD0 VA: 0x1817A94D0
	public static float ToSingle(Decimal d) { }

	// RVA: 0x17A9880 Offset: 0x17A7E80 VA: 0x1817A9880
	public static Decimal Truncate(Decimal d) { }

	// RVA: 0x17A8440 Offset: 0x17A6A40 VA: 0x1817A8440
	private static void FCallTruncate(ref Decimal d) { }

	// RVA: 0x17AA4E0 Offset: 0x17A8AE0 VA: 0x1817AA4E0
	public static Decimal op_Implicit(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x17AA550 Offset: 0x17A8B50 VA: 0x1817AA550
	public static Decimal op_Implicit(sbyte value) { }

	// RVA: 0x17AA580 Offset: 0x17A8B80 VA: 0x1817AA580
	public static Decimal op_Implicit(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x17AA500 Offset: 0x17A8B00 VA: 0x1817AA500
	public static Decimal op_Implicit(ushort value) { }

	// RVA: 0x17AA500 Offset: 0x17A8B00 VA: 0x1817AA500
	public static Decimal op_Implicit(char value) { }

	// RVA: 0x17AA520 Offset: 0x17A8B20 VA: 0x1817AA520
	public static Decimal op_Implicit(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x17AA4B0 Offset: 0x17A8AB0 VA: 0x1817AA4B0
	public static Decimal op_Implicit(uint value) { }

	// RVA: 0x17AA5B0 Offset: 0x17A8BB0 VA: 0x1817AA5B0
	public static Decimal op_Implicit(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x17AA4C0 Offset: 0x17A8AC0 VA: 0x1817AA4C0
	public static Decimal op_Implicit(ulong value) { }

	// RVA: 0x17AA040 Offset: 0x17A8640 VA: 0x1817AA040
	public static Decimal op_Explicit(float value) { }

	// RVA: 0x17AA020 Offset: 0x17A8620 VA: 0x1817AA020
	public static Decimal op_Explicit(double value) { }

	// RVA: 0x17AA250 Offset: 0x17A8850 VA: 0x1817AA250
	public static int op_Explicit(Decimal value) { }

	// RVA: 0x17AA120 Offset: 0x17A8720 VA: 0x1817AA120
	public static long op_Explicit(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x17AA2B0 Offset: 0x17A88B0 VA: 0x1817AA2B0
	public static ulong op_Explicit(Decimal value) { }

	// RVA: 0x17AA0C0 Offset: 0x17A86C0 VA: 0x1817AA0C0
	public static float op_Explicit(Decimal value) { }

	// RVA: 0x17AA060 Offset: 0x17A8660 VA: 0x1817AA060
	public static double op_Explicit(Decimal value) { }

	// RVA: 0x17AA910 Offset: 0x17A8F10 VA: 0x1817AA910
	public static Decimal op_UnaryNegation(Decimal d) { }

	// RVA: 0x17AA5F0 Offset: 0x17A8BF0 VA: 0x1817AA5F0
	public static Decimal op_Increment(Decimal d) { }

	// RVA: 0x17A9EB0 Offset: 0x17A84B0 VA: 0x1817A9EB0
	public static Decimal op_Addition(Decimal d1, Decimal d2) { }

	// RVA: 0x17AA890 Offset: 0x17A8E90 VA: 0x1817AA890
	public static Decimal op_Subtraction(Decimal d1, Decimal d2) { }

	// RVA: 0x17AA810 Offset: 0x17A8E10 VA: 0x1817AA810
	public static Decimal op_Multiply(Decimal d1, Decimal d2) { }

	// RVA: 0x17A9F30 Offset: 0x17A8530 VA: 0x1817A9F30
	public static Decimal op_Division(Decimal d1, Decimal d2) { }

	// RVA: 0x17A9FB0 Offset: 0x17A85B0 VA: 0x1817A9FB0
	public static bool op_Equality(Decimal d1, Decimal d2) { }

	// RVA: 0x17AA6C0 Offset: 0x17A8CC0 VA: 0x1817AA6C0
	public static bool op_Inequality(Decimal d1, Decimal d2) { }

	// RVA: 0x17AA7A0 Offset: 0x17A8DA0 VA: 0x1817AA7A0
	public static bool op_LessThan(Decimal d1, Decimal d2) { }

	// RVA: 0x17AA730 Offset: 0x17A8D30 VA: 0x1817AA730
	public static bool op_LessThanOrEqual(Decimal d1, Decimal d2) { }

	// RVA: 0x17AA440 Offset: 0x17A8A40 VA: 0x1817AA440
	public static bool op_GreaterThan(Decimal d1, Decimal d2) { }

	// RVA: 0x17AA3D0 Offset: 0x17A89D0 VA: 0x1817AA3D0
	public static bool op_GreaterThanOrEqual(Decimal d1, Decimal d2) { }

	// RVA: 0x20D5A0 Offset: 0x20C9A0 VA: 0x18020D5A0 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x20D5E0 Offset: 0x20C9E0 VA: 0x18020D5E0 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x20D6C0 Offset: 0x20CAC0 VA: 0x18020D6C0 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x20D8A0 Offset: 0x20CCA0 VA: 0x18020D8A0 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x20D650 Offset: 0x20CA50 VA: 0x18020D650 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x20D750 Offset: 0x20CB50 VA: 0x18020D750 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x20DA10 Offset: 0x20CE10 VA: 0x18020DA10 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x20D7C0 Offset: 0x20CBC0 VA: 0x18020D7C0 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x20DA80 Offset: 0x20CE80 VA: 0x18020DA80 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x20D830 Offset: 0x20CC30 VA: 0x18020D830 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x20DAF0 Offset: 0x20CEF0 VA: 0x18020DAF0 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x20D910 Offset: 0x20CD10 VA: 0x18020D910 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x20D6E0 Offset: 0x20CAE0 VA: 0x18020D6E0 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x14B770 Offset: 0x14AB70 VA: 0x18014B770 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x20D6D0 Offset: 0x20CAD0 VA: 0x18020D6D0 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x20D980 Offset: 0x20CD80 VA: 0x18020D980 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x17A9990 Offset: 0x17A7F90 VA: 0x1817A9990
	private static void .cctor() { }

}

