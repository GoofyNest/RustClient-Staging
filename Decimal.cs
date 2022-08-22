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

	// RVA: 0x17A82C0 Offset: 0x17A68C0 VA: 0x1817A82C0
	public static Decimal Add(Decimal d1, Decimal d2) { }

	// RVA: 0x17A8690 Offset: 0x17A6C90 VA: 0x1817A8690
	private static void FCallAddSub(ref Decimal d1, ref Decimal d2, byte bSign) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x17A8490 Offset: 0x17A6A90 VA: 0x1817A8490
	public static int Compare(Decimal d1, Decimal d2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x17A86A0 Offset: 0x17A6CA0 VA: 0x1817A86A0
	private static int FCallCompare(ref Decimal d1, ref Decimal d2) { }

	// RVA: 0x20D310 Offset: 0x20C710 VA: 0x18020D310 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x20D400 Offset: 0x20C800 VA: 0x18020D400 Slot: 24
	public int CompareTo(Decimal value) { }

	// RVA: 0x17A84F0 Offset: 0x17A6AF0 VA: 0x1817A84F0
	public static Decimal Divide(Decimal d1, Decimal d2) { }

	// RVA: 0x17A86B0 Offset: 0x17A6CB0 VA: 0x1817A86B0
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

	// RVA: 0x17A8AD0 Offset: 0x17A70D0 VA: 0x1817A8AD0
	public static Decimal Parse(string s, IFormatProvider provider) { }

	// RVA: 0x17A8B20 Offset: 0x17A7120 VA: 0x1817A8B20
	public static Decimal Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x17A9C10 Offset: 0x17A8210 VA: 0x1817A9C10
	public static bool TryParse(string s, out Decimal result) { }

	// RVA: 0x17A9BB0 Offset: 0x17A81B0 VA: 0x1817A9BB0
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out Decimal result) { }

	// RVA: 0x17A8710 Offset: 0x17A6D10 VA: 0x1817A8710
	public static int[] GetBits(Decimal d) { }

	// RVA: 0x17A90C0 Offset: 0x17A76C0 VA: 0x1817A90C0
	internal static Decimal ToDecimal(byte[] buffer) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x17A87F0 Offset: 0x17A6DF0 VA: 0x1817A87F0
	internal static Decimal Max(Decimal d1, Decimal d2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x17A8880 Offset: 0x17A6E80 VA: 0x1817A8880
	internal static Decimal Min(Decimal d1, Decimal d2) { }

	// RVA: 0x17A8910 Offset: 0x17A6F10 VA: 0x1817A8910
	public static Decimal Multiply(Decimal d1, Decimal d2) { }

	// RVA: 0x17A86C0 Offset: 0x17A6CC0 VA: 0x1817A86C0
	private static void FCallMultiply(ref Decimal d1, ref Decimal d2) { }

	// RVA: 0x17A8990 Offset: 0x17A6F90 VA: 0x1817A8990
	public static Decimal Negate(Decimal d) { }

	// RVA: 0x17A8B90 Offset: 0x17A7190 VA: 0x1817A8B90
	public static Decimal Round(Decimal d, int decimals) { }

	// RVA: 0x17A86D0 Offset: 0x17A6CD0 VA: 0x1817A86D0
	private static void FCallRound(ref Decimal d, int decimals) { }

	// RVA: 0x17A8FB0 Offset: 0x17A75B0 VA: 0x1817A8FB0
	public static byte ToByte(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x17A9680 Offset: 0x17A7C80 VA: 0x1817A9680
	public static sbyte ToSByte(Decimal value) { }

	// RVA: 0x17A93A0 Offset: 0x17A79A0 VA: 0x1817A93A0
	public static short ToInt16(Decimal value) { }

	// RVA: 0x17A9380 Offset: 0x17A7980 VA: 0x1817A9380
	public static double ToDouble(Decimal d) { }

	// RVA: 0x17A86E0 Offset: 0x17A6CE0 VA: 0x1817A86E0
	internal static int FCallToInt32(Decimal d) { }

	// RVA: 0x17A94B0 Offset: 0x17A7AB0 VA: 0x1817A94B0
	public static int ToInt32(Decimal d) { }

	// RVA: 0x17A9590 Offset: 0x17A7B90 VA: 0x1817A9590
	public static long ToInt64(Decimal d) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x17A9870 Offset: 0x17A7E70 VA: 0x1817A9870
	public static ushort ToUInt16(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x17A9980 Offset: 0x17A7F80 VA: 0x1817A9980
	public static uint ToUInt32(Decimal d) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x17A9A60 Offset: 0x17A8060 VA: 0x1817A9A60
	public static ulong ToUInt64(Decimal d) { }

	// RVA: 0x17A9790 Offset: 0x17A7D90 VA: 0x1817A9790
	public static float ToSingle(Decimal d) { }

	// RVA: 0x17A9B40 Offset: 0x17A8140 VA: 0x1817A9B40
	public static Decimal Truncate(Decimal d) { }

	// RVA: 0x17A8700 Offset: 0x17A6D00 VA: 0x1817A8700
	private static void FCallTruncate(ref Decimal d) { }

	// RVA: 0x17AA7A0 Offset: 0x17A8DA0 VA: 0x1817AA7A0
	public static Decimal op_Implicit(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x17AA810 Offset: 0x17A8E10 VA: 0x1817AA810
	public static Decimal op_Implicit(sbyte value) { }

	// RVA: 0x17AA840 Offset: 0x17A8E40 VA: 0x1817AA840
	public static Decimal op_Implicit(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x17AA7C0 Offset: 0x17A8DC0 VA: 0x1817AA7C0
	public static Decimal op_Implicit(ushort value) { }

	// RVA: 0x17AA7C0 Offset: 0x17A8DC0 VA: 0x1817AA7C0
	public static Decimal op_Implicit(char value) { }

	// RVA: 0x17AA7E0 Offset: 0x17A8DE0 VA: 0x1817AA7E0
	public static Decimal op_Implicit(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x17AA770 Offset: 0x17A8D70 VA: 0x1817AA770
	public static Decimal op_Implicit(uint value) { }

	// RVA: 0x17AA870 Offset: 0x17A8E70 VA: 0x1817AA870
	public static Decimal op_Implicit(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x17AA780 Offset: 0x17A8D80 VA: 0x1817AA780
	public static Decimal op_Implicit(ulong value) { }

	// RVA: 0x17AA300 Offset: 0x17A8900 VA: 0x1817AA300
	public static Decimal op_Explicit(float value) { }

	// RVA: 0x17AA2E0 Offset: 0x17A88E0 VA: 0x1817AA2E0
	public static Decimal op_Explicit(double value) { }

	// RVA: 0x17AA510 Offset: 0x17A8B10 VA: 0x1817AA510
	public static int op_Explicit(Decimal value) { }

	// RVA: 0x17AA3E0 Offset: 0x17A89E0 VA: 0x1817AA3E0
	public static long op_Explicit(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x17AA570 Offset: 0x17A8B70 VA: 0x1817AA570
	public static ulong op_Explicit(Decimal value) { }

	// RVA: 0x17AA380 Offset: 0x17A8980 VA: 0x1817AA380
	public static float op_Explicit(Decimal value) { }

	// RVA: 0x17AA320 Offset: 0x17A8920 VA: 0x1817AA320
	public static double op_Explicit(Decimal value) { }

	// RVA: 0x17AABD0 Offset: 0x17A91D0 VA: 0x1817AABD0
	public static Decimal op_UnaryNegation(Decimal d) { }

	// RVA: 0x17AA8B0 Offset: 0x17A8EB0 VA: 0x1817AA8B0
	public static Decimal op_Increment(Decimal d) { }

	// RVA: 0x17AA170 Offset: 0x17A8770 VA: 0x1817AA170
	public static Decimal op_Addition(Decimal d1, Decimal d2) { }

	// RVA: 0x17AAB50 Offset: 0x17A9150 VA: 0x1817AAB50
	public static Decimal op_Subtraction(Decimal d1, Decimal d2) { }

	// RVA: 0x17AAAD0 Offset: 0x17A90D0 VA: 0x1817AAAD0
	public static Decimal op_Multiply(Decimal d1, Decimal d2) { }

	// RVA: 0x17AA1F0 Offset: 0x17A87F0 VA: 0x1817AA1F0
	public static Decimal op_Division(Decimal d1, Decimal d2) { }

	// RVA: 0x17AA270 Offset: 0x17A8870 VA: 0x1817AA270
	public static bool op_Equality(Decimal d1, Decimal d2) { }

	// RVA: 0x17AA980 Offset: 0x17A8F80 VA: 0x1817AA980
	public static bool op_Inequality(Decimal d1, Decimal d2) { }

	// RVA: 0x17AAA60 Offset: 0x17A9060 VA: 0x1817AAA60
	public static bool op_LessThan(Decimal d1, Decimal d2) { }

	// RVA: 0x17AA9F0 Offset: 0x17A8FF0 VA: 0x1817AA9F0
	public static bool op_LessThanOrEqual(Decimal d1, Decimal d2) { }

	// RVA: 0x17AA700 Offset: 0x17A8D00 VA: 0x1817AA700
	public static bool op_GreaterThan(Decimal d1, Decimal d2) { }

	// RVA: 0x17AA690 Offset: 0x17A8C90 VA: 0x1817AA690
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

	// RVA: 0x17A9C50 Offset: 0x17A8250 VA: 0x1817A9C50
	private static void .cctor() { }

}

