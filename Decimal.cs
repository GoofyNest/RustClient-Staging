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

	// RVA: 0x20D9B0 Offset: 0x20CDB0 VA: 0x18020D9B0
	public void .ctor(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x20D9A0 Offset: 0x20CDA0 VA: 0x18020D9A0
	public void .ctor(uint value) { }

	// RVA: 0x20DA30 Offset: 0x20CE30 VA: 0x18020DA30
	public void .ctor(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x20D980 Offset: 0x20CD80 VA: 0x18020D980
	public void .ctor(ulong value) { }

	// RVA: 0x20DA20 Offset: 0x20CE20 VA: 0x18020DA20
	public void .ctor(float value) { }

	// RVA: 0x20D9E0 Offset: 0x20CDE0 VA: 0x18020D9E0
	public void .ctor(double value) { }

	// RVA: 0x20D860 Offset: 0x20CC60 VA: 0x18020D860
	public void .ctor(int[] bits) { }

	// RVA: 0x20D200 Offset: 0x20C600 VA: 0x18020D200
	private void SetBits(int[] bits) { }

	// RVA: 0x20D9F0 Offset: 0x20CDF0 VA: 0x18020D9F0
	public void .ctor(int lo, int mid, int hi, bool isNegative, byte scale) { }

	[OnSerializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x20D1E0 Offset: 0x20C5E0 VA: 0x18020D1E0
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x20D790 Offset: 0x20CB90 VA: 0x18020D790 Slot: 23
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x20DA10 Offset: 0x20CE10 VA: 0x18020DA10
	private void .ctor(int lo, int mid, int hi, int flags) { }

	// RVA: 0x17AA6D0 Offset: 0x17A8CD0 VA: 0x1817AA6D0
	public static Decimal Add(Decimal d1, Decimal d2) { }

	// RVA: 0x17AAAA0 Offset: 0x17A90A0 VA: 0x1817AAAA0
	private static void FCallAddSub(ref Decimal d1, ref Decimal d2, byte bSign) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x17AA8A0 Offset: 0x17A8EA0 VA: 0x1817AA8A0
	public static int Compare(Decimal d1, Decimal d2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x17AAAB0 Offset: 0x17A90B0 VA: 0x1817AAAB0
	private static int FCallCompare(ref Decimal d1, ref Decimal d2) { }

	// RVA: 0x20CF40 Offset: 0x20C340 VA: 0x18020CF40 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x20D030 Offset: 0x20C430 VA: 0x18020D030 Slot: 24
	public int CompareTo(Decimal value) { }

	// RVA: 0x17AA900 Offset: 0x17A8F00 VA: 0x1817AA900
	public static Decimal Divide(Decimal d1, Decimal d2) { }

	// RVA: 0x17AAAC0 Offset: 0x17A90C0 VA: 0x1817AAAC0
	private static void FCallDivide(ref Decimal d1, ref Decimal d2) { }

	// RVA: 0x20D100 Offset: 0x20C500 VA: 0x18020D100 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x20D090 Offset: 0x20C490 VA: 0x18020D090 Slot: 25
	public bool Equals(Decimal value) { }

	// RVA: 0x20D1C0 Offset: 0x20C5C0 VA: 0x18020D1C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20D7A0 Offset: 0x20CBA0 VA: 0x18020D7A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x20D7E0 Offset: 0x20CBE0 VA: 0x18020D7E0 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x20D820 Offset: 0x20CC20 VA: 0x18020D820 Slot: 4
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x17AAEE0 Offset: 0x17A94E0 VA: 0x1817AAEE0
	public static Decimal Parse(string s, IFormatProvider provider) { }

	// RVA: 0x17AAF30 Offset: 0x17A9530 VA: 0x1817AAF30
	public static Decimal Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x17AC020 Offset: 0x17AA620 VA: 0x1817AC020
	public static bool TryParse(string s, out Decimal result) { }

	// RVA: 0x17ABFC0 Offset: 0x17AA5C0 VA: 0x1817ABFC0
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out Decimal result) { }

	// RVA: 0x17AAB20 Offset: 0x17A9120 VA: 0x1817AAB20
	public static int[] GetBits(Decimal d) { }

	// RVA: 0x17AB4D0 Offset: 0x17A9AD0 VA: 0x1817AB4D0
	internal static Decimal ToDecimal(byte[] buffer) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x17AAC00 Offset: 0x17A9200 VA: 0x1817AAC00
	internal static Decimal Max(Decimal d1, Decimal d2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x17AAC90 Offset: 0x17A9290 VA: 0x1817AAC90
	internal static Decimal Min(Decimal d1, Decimal d2) { }

	// RVA: 0x17AAD20 Offset: 0x17A9320 VA: 0x1817AAD20
	public static Decimal Multiply(Decimal d1, Decimal d2) { }

	// RVA: 0x17AAAD0 Offset: 0x17A90D0 VA: 0x1817AAAD0
	private static void FCallMultiply(ref Decimal d1, ref Decimal d2) { }

	// RVA: 0x17AADA0 Offset: 0x17A93A0 VA: 0x1817AADA0
	public static Decimal Negate(Decimal d) { }

	// RVA: 0x17AAFA0 Offset: 0x17A95A0 VA: 0x1817AAFA0
	public static Decimal Round(Decimal d, int decimals) { }

	// RVA: 0x17AAAE0 Offset: 0x17A90E0 VA: 0x1817AAAE0
	private static void FCallRound(ref Decimal d, int decimals) { }

	// RVA: 0x17AB3C0 Offset: 0x17A99C0 VA: 0x1817AB3C0
	public static byte ToByte(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x17ABA90 Offset: 0x17AA090 VA: 0x1817ABA90
	public static sbyte ToSByte(Decimal value) { }

	// RVA: 0x17AB7B0 Offset: 0x17A9DB0 VA: 0x1817AB7B0
	public static short ToInt16(Decimal value) { }

	// RVA: 0x17AB790 Offset: 0x17A9D90 VA: 0x1817AB790
	public static double ToDouble(Decimal d) { }

	// RVA: 0x17AAAF0 Offset: 0x17A90F0 VA: 0x1817AAAF0
	internal static int FCallToInt32(Decimal d) { }

	// RVA: 0x17AB8C0 Offset: 0x17A9EC0 VA: 0x1817AB8C0
	public static int ToInt32(Decimal d) { }

	// RVA: 0x17AB9A0 Offset: 0x17A9FA0 VA: 0x1817AB9A0
	public static long ToInt64(Decimal d) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x17ABC80 Offset: 0x17AA280 VA: 0x1817ABC80
	public static ushort ToUInt16(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x17ABD90 Offset: 0x17AA390 VA: 0x1817ABD90
	public static uint ToUInt32(Decimal d) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x17ABE70 Offset: 0x17AA470 VA: 0x1817ABE70
	public static ulong ToUInt64(Decimal d) { }

	// RVA: 0x17ABBA0 Offset: 0x17AA1A0 VA: 0x1817ABBA0
	public static float ToSingle(Decimal d) { }

	// RVA: 0x17ABF50 Offset: 0x17AA550 VA: 0x1817ABF50
	public static Decimal Truncate(Decimal d) { }

	// RVA: 0x17AAB10 Offset: 0x17A9110 VA: 0x1817AAB10
	private static void FCallTruncate(ref Decimal d) { }

	// RVA: 0x17ACBB0 Offset: 0x17AB1B0 VA: 0x1817ACBB0
	public static Decimal op_Implicit(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x17ACC20 Offset: 0x17AB220 VA: 0x1817ACC20
	public static Decimal op_Implicit(sbyte value) { }

	// RVA: 0x17ACC50 Offset: 0x17AB250 VA: 0x1817ACC50
	public static Decimal op_Implicit(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x17ACBD0 Offset: 0x17AB1D0 VA: 0x1817ACBD0
	public static Decimal op_Implicit(ushort value) { }

	// RVA: 0x17ACBD0 Offset: 0x17AB1D0 VA: 0x1817ACBD0
	public static Decimal op_Implicit(char value) { }

	// RVA: 0x17ACBF0 Offset: 0x17AB1F0 VA: 0x1817ACBF0
	public static Decimal op_Implicit(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x17ACB80 Offset: 0x17AB180 VA: 0x1817ACB80
	public static Decimal op_Implicit(uint value) { }

	// RVA: 0x17ACC80 Offset: 0x17AB280 VA: 0x1817ACC80
	public static Decimal op_Implicit(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x17ACB90 Offset: 0x17AB190 VA: 0x1817ACB90
	public static Decimal op_Implicit(ulong value) { }

	// RVA: 0x17AC710 Offset: 0x17AAD10 VA: 0x1817AC710
	public static Decimal op_Explicit(float value) { }

	// RVA: 0x17AC6F0 Offset: 0x17AACF0 VA: 0x1817AC6F0
	public static Decimal op_Explicit(double value) { }

	// RVA: 0x17AC920 Offset: 0x17AAF20 VA: 0x1817AC920
	public static int op_Explicit(Decimal value) { }

	// RVA: 0x17AC7F0 Offset: 0x17AADF0 VA: 0x1817AC7F0
	public static long op_Explicit(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x17AC980 Offset: 0x17AAF80 VA: 0x1817AC980
	public static ulong op_Explicit(Decimal value) { }

	// RVA: 0x17AC790 Offset: 0x17AAD90 VA: 0x1817AC790
	public static float op_Explicit(Decimal value) { }

	// RVA: 0x17AC730 Offset: 0x17AAD30 VA: 0x1817AC730
	public static double op_Explicit(Decimal value) { }

	// RVA: 0x17ACFE0 Offset: 0x17AB5E0 VA: 0x1817ACFE0
	public static Decimal op_UnaryNegation(Decimal d) { }

	// RVA: 0x17ACCC0 Offset: 0x17AB2C0 VA: 0x1817ACCC0
	public static Decimal op_Increment(Decimal d) { }

	// RVA: 0x17AC580 Offset: 0x17AAB80 VA: 0x1817AC580
	public static Decimal op_Addition(Decimal d1, Decimal d2) { }

	// RVA: 0x17ACF60 Offset: 0x17AB560 VA: 0x1817ACF60
	public static Decimal op_Subtraction(Decimal d1, Decimal d2) { }

	// RVA: 0x17ACEE0 Offset: 0x17AB4E0 VA: 0x1817ACEE0
	public static Decimal op_Multiply(Decimal d1, Decimal d2) { }

	// RVA: 0x17AC600 Offset: 0x17AAC00 VA: 0x1817AC600
	public static Decimal op_Division(Decimal d1, Decimal d2) { }

	// RVA: 0x17AC680 Offset: 0x17AAC80 VA: 0x1817AC680
	public static bool op_Equality(Decimal d1, Decimal d2) { }

	// RVA: 0x17ACD90 Offset: 0x17AB390 VA: 0x1817ACD90
	public static bool op_Inequality(Decimal d1, Decimal d2) { }

	// RVA: 0x17ACE70 Offset: 0x17AB470 VA: 0x1817ACE70
	public static bool op_LessThan(Decimal d1, Decimal d2) { }

	// RVA: 0x17ACE00 Offset: 0x17AB400 VA: 0x1817ACE00
	public static bool op_LessThanOrEqual(Decimal d1, Decimal d2) { }

	// RVA: 0x17ACB10 Offset: 0x17AB110 VA: 0x1817ACB10
	public static bool op_GreaterThan(Decimal d1, Decimal d2) { }

	// RVA: 0x17ACAA0 Offset: 0x17AB0A0 VA: 0x1817ACAA0
	public static bool op_GreaterThanOrEqual(Decimal d1, Decimal d2) { }

	// RVA: 0x20D1D0 Offset: 0x20C5D0 VA: 0x18020D1D0 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x20D210 Offset: 0x20C610 VA: 0x18020D210 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x20D2F0 Offset: 0x20C6F0 VA: 0x18020D2F0 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x20D4D0 Offset: 0x20C8D0 VA: 0x18020D4D0 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x20D280 Offset: 0x20C680 VA: 0x18020D280 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x20D380 Offset: 0x20C780 VA: 0x18020D380 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x20D640 Offset: 0x20CA40 VA: 0x18020D640 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x20D3F0 Offset: 0x20C7F0 VA: 0x18020D3F0 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x20D6B0 Offset: 0x20CAB0 VA: 0x18020D6B0 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x20D460 Offset: 0x20C860 VA: 0x18020D460 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x20D720 Offset: 0x20CB20 VA: 0x18020D720 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x20D540 Offset: 0x20C940 VA: 0x18020D540 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x20D310 Offset: 0x20C710 VA: 0x18020D310 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x14B590 Offset: 0x14A990 VA: 0x18014B590 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x20D300 Offset: 0x20C700 VA: 0x18020D300 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x20D5B0 Offset: 0x20C9B0 VA: 0x18020D5B0 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x17AC060 Offset: 0x17AA660 VA: 0x1817AC060
	private static void .cctor() { }

}

