public struct DateTime : IComparable, IFormattable, IConvertible, ISerializable, IComparable<DateTime>, IEquatable<DateTime> // TypeDefIndex: 197
{	// Fields
	private const long TicksPerMillisecond = 10000;
	private const long TicksPerSecond = 10000000;
	private const long TicksPerMinute = 600000000;
	private const long TicksPerHour = 36000000000;
	private const long TicksPerDay = 864000000000;
	private const int MillisPerSecond = 1000;
	private const int MillisPerMinute = 60000;
	private const int MillisPerHour = 3600000;
	private const int MillisPerDay = 86400000;
	private const int DaysPerYear = 365;
	private const int DaysPer4Years = 1461;
	private const int DaysPer100Years = 36524;
	private const int DaysPer400Years = 146097;
	private const int DaysTo1601 = 584388;
	private const int DaysTo1899 = 693593;
	internal const int DaysTo1970 = 719162;
	private const int DaysTo10000 = 3652059;
	internal const long MinTicks = 0;
	internal const long MaxTicks = 3155378975999999999;
	private const long MaxMillis = 315537897600000;
	private const long FileTimeOffset = 504911232000000000;
	private const long DoubleDateOffset = 599264352000000000;
	private const long OADateMinAsTicks = 31241376000000000;
	private const double OADateMinAsDouble = -657435;
	private const double OADateMaxAsDouble = 2958466;
	private const int DatePartYear = 0;
	private const int DatePartDayOfYear = 1;
	private const int DatePartMonth = 2;
	private const int DatePartDay = 3;
	private static readonly int[] DaysToMonth365; // 0x0
	private static readonly int[] DaysToMonth366; // 0x8
	public static readonly DateTime MinValue; // 0x10
	public static readonly DateTime MaxValue; // 0x18
	private const ulong TicksMask = 4611686018427387903;
	private const ulong FlagsMask = 13835058055282163712;
	private const ulong LocalMask = 9223372036854775808;
	private const long TicksCeiling = 4611686018427387904;
	private const ulong KindUnspecified = 0;
	private const ulong KindUtc = 4611686018427387904;
	private const ulong KindLocal = 9223372036854775808;
	private const ulong KindLocalAmbiguousDst = 13835058055282163712;
	private const int KindShift = 62;
	private const string TicksField = "ticks";
	private const string DateDataField = "dateData";
	private ulong dateData; // 0x0

	// Properties
	internal long InternalTicks { get; }
	private ulong InternalKind { get; }
	public DateTime Date { get; }
	public int Day { get; }
	public DayOfWeek DayOfWeek { get; }
	public int Hour { get; }
	public DateTimeKind Kind { get; }
	public int Millisecond { get; }
	public int Minute { get; }
	public int Month { get; }
	public static DateTime Now { get; }
	public static DateTime UtcNow { get; }
	public int Second { get; }
	public long Ticks { get; }
	public TimeSpan TimeOfDay { get; }
	public int Year { get; }

	// Methods

	// RVA: 0x20C840 Offset: 0x20BC40 VA: 0x18020C840
	public void .ctor(long ticks) { }

	// RVA: 0x1D3520 Offset: 0x1D2920 VA: 0x1801D3520
	private void .ctor(ulong dateData) { }

	// RVA: 0x20C850 Offset: 0x20BC50 VA: 0x18020C850
	public void .ctor(long ticks, DateTimeKind kind) { }

	// RVA: 0x20CB00 Offset: 0x20BF00 VA: 0x18020CB00
	internal void .ctor(long ticks, DateTimeKind kind, bool isAmbiguousDst) { }

	// RVA: 0x20CC20 Offset: 0x20C020 VA: 0x18020CC20
	public void .ctor(int year, int month, int day) { }

	// RVA: 0x20C880 Offset: 0x20BC80 VA: 0x18020C880
	public void .ctor(int year, int month, int day, int hour, int minute, int second) { }

	// RVA: 0x20CB10 Offset: 0x20BF10 VA: 0x18020CB10
	public void .ctor(int year, int month, int day, int hour, int minute, int second, DateTimeKind kind) { }

	// RVA: 0x20C920 Offset: 0x20BD20 VA: 0x18020C920
	public void .ctor(int year, int month, int day, int hour, int minute, int second, int millisecond) { }

	// RVA: 0x20CC10 Offset: 0x20C010 VA: 0x18020CC10
	public void .ctor(int year, int month, int day, int hour, int minute, int second, int millisecond, DateTimeKind kind) { }

	// RVA: 0x20C860 Offset: 0x20BC60 VA: 0x18020C860
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x20CDB0 Offset: 0x20C1B0 VA: 0x18020CDB0
	internal long get_InternalTicks() { }

	// RVA: 0x20CD90 Offset: 0x20C190 VA: 0x18020CD90
	private ulong get_InternalKind() { }

	// RVA: 0x20BC80 Offset: 0x20B080 VA: 0x18020BC80
	public DateTime Add(TimeSpan value) { }

	// RVA: 0x20BC90 Offset: 0x20B090 VA: 0x18020BC90
	private DateTime Add(double value, int scale) { }

	// RVA: 0x20BB50 Offset: 0x20AF50 VA: 0x18020BB50
	public DateTime AddDays(double value) { }

	// RVA: 0x20BB70 Offset: 0x20AF70 VA: 0x18020BB70
	public DateTime AddHours(double value) { }

	// RVA: 0x20BB90 Offset: 0x20AF90 VA: 0x18020BB90
	public DateTime AddMilliseconds(double value) { }

	// RVA: 0x20BBA0 Offset: 0x20AFA0 VA: 0x18020BBA0
	public DateTime AddMonths(int months) { }

	// RVA: 0x20BBB0 Offset: 0x20AFB0 VA: 0x18020BBB0
	public DateTime AddSeconds(double value) { }

	// RVA: 0x20BBD0 Offset: 0x20AFD0 VA: 0x18020BBD0
	public DateTime AddTicks(long value) { }

	// RVA: 0x20BBE0 Offset: 0x20AFE0 VA: 0x18020BBE0
	public DateTime AddYears(int value) { }

	// RVA: 0x17A64B0 Offset: 0x17A4AB0 VA: 0x1817A64B0
	public static int Compare(DateTime t1, DateTime t2) { }

	// RVA: 0x20BCD0 Offset: 0x20B0D0 VA: 0x18020BCD0 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x20BCA0 Offset: 0x20B0A0 VA: 0x18020BCA0 Slot: 24
	public int CompareTo(DateTime value) { }

	// RVA: 0x17A64D0 Offset: 0x17A4AD0 VA: 0x1817A64D0
	private static long DateToTicks(int year, int month, int day) { }

	// RVA: 0x17A8480 Offset: 0x17A6A80 VA: 0x1817A8480
	private static long TimeToTicks(int hour, int minute, int second) { }

	// RVA: 0x17A66C0 Offset: 0x17A4CC0 VA: 0x1817A66C0
	public static int DaysInMonth(int year, int month) { }

	// RVA: 0x17A6820 Offset: 0x17A4E20 VA: 0x1817A6820
	internal static long DoubleDateToTicks(double value) { }

	// RVA: 0x20BDD0 Offset: 0x20B1D0 VA: 0x18020BDD0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x20BDB0 Offset: 0x20B1B0 VA: 0x18020BDB0 Slot: 25
	public bool Equals(DateTime value) { }

	// RVA: 0x17A6AF0 Offset: 0x17A50F0 VA: 0x1817A6AF0
	public static DateTime FromBinary(long dateData) { }

	// RVA: 0x17A6A50 Offset: 0x17A5050 VA: 0x1817A6A50
	internal static DateTime FromBinaryRaw(long dateData) { }

	// RVA: 0x17A6E20 Offset: 0x17A5420 VA: 0x1817A6E20
	public static DateTime FromFileTime(long fileTime) { }

	// RVA: 0x17A6D60 Offset: 0x17A5360 VA: 0x1817A6D60
	public static DateTime FromFileTimeUtc(long fileTime) { }

	// RVA: 0x17A6F20 Offset: 0x17A5520 VA: 0x1817A6F20
	public static DateTime FromOADate(double d) { }

	// RVA: 0x20C030 Offset: 0x20B430 VA: 0x18020C030 Slot: 23
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17A7860 Offset: 0x17A5E60 VA: 0x1817A7860
	public static DateTime SpecifyKind(DateTime value, DateTimeKind kind) { }

	// RVA: 0x20C0E0 Offset: 0x20B4E0 VA: 0x18020C0E0
	public long ToBinary() { }

	// RVA: 0xFC840 Offset: 0xFBC40 VA: 0x1800FC840
	internal long ToBinaryRaw() { }

	// RVA: 0x20CCA0 Offset: 0x20C0A0 VA: 0x18020CCA0
	public DateTime get_Date() { }

	// RVA: 0x20BE60 Offset: 0x20B260 VA: 0x18020BE60
	private int GetDatePart(int part) { }

	// RVA: 0x20CD30 Offset: 0x20C130 VA: 0x18020CD30
	public int get_Day() { }

	// RVA: 0x20CCE0 Offset: 0x20C0E0 VA: 0x18020CCE0
	public DayOfWeek get_DayOfWeek() { }

	// RVA: 0x20BE70 Offset: 0x20B270 VA: 0x18020BE70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20CD40 Offset: 0x20C140 VA: 0x18020CD40
	public int get_Hour() { }

	// RVA: 0x20CDD0 Offset: 0x20C1D0 VA: 0x18020CDD0
	public DateTimeKind get_Kind() { }

	// RVA: 0x20CE00 Offset: 0x20C200 VA: 0x18020CE00
	public int get_Millisecond() { }

	// RVA: 0x20CE50 Offset: 0x20C250 VA: 0x18020CE50
	public int get_Minute() { }

	// RVA: 0x20CEA0 Offset: 0x20C2A0 VA: 0x18020CEA0
	public int get_Month() { }

	// RVA: 0x17AA170 Offset: 0x17A8770 VA: 0x1817AA170
	public static DateTime get_Now() { }

	// RVA: 0x17AA3F0 Offset: 0x17A89F0 VA: 0x1817AA3F0
	public static DateTime get_UtcNow() { }

	// RVA: 0x17A7300 Offset: 0x17A5900 VA: 0x1817A7300
	internal static long GetSystemTimeAsFileTime() { }

	// RVA: 0x20CEB0 Offset: 0x20C2B0 VA: 0x18020CEB0
	public int get_Second() { }

	// RVA: 0x20CDB0 Offset: 0x20C1B0 VA: 0x18020CDB0
	public long get_Ticks() { }

	// RVA: 0x20CF00 Offset: 0x20C300 VA: 0x18020CF00
	public TimeSpan get_TimeOfDay() { }

	// RVA: 0x20CF30 Offset: 0x20C330 VA: 0x18020CF30
	public int get_Year() { }

	// RVA: 0x17A7310 Offset: 0x17A5910 VA: 0x1817A7310
	public static bool IsLeapYear(int year) { }

	// RVA: 0x17A77D0 Offset: 0x17A5DD0 VA: 0x1817A77D0
	public static DateTime Parse(string s, IFormatProvider provider) { }

	// RVA: 0x17A7720 Offset: 0x17A5D20 VA: 0x1817A7720
	public static DateTime Parse(string s, IFormatProvider provider, DateTimeStyles styles) { }

	// RVA: 0x17A73F0 Offset: 0x17A59F0 VA: 0x1817A73F0
	public static DateTime ParseExact(string s, string format, IFormatProvider provider) { }

	// RVA: 0x17A7650 Offset: 0x17A5C50 VA: 0x1817A7650
	public static DateTime ParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style) { }

	// RVA: 0x17A74A0 Offset: 0x17A5AA0 VA: 0x1817A74A0
	public static DateTime ParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style) { }

	// RVA: 0x20BEA0 Offset: 0x20B2A0 VA: 0x18020BEA0
	public TimeSpan Subtract(DateTime value) { }

	// RVA: 0x17A8350 Offset: 0x17A6950 VA: 0x1817A8350
	private static double TicksToOADate(long value) { }

	// RVA: 0x20C300 Offset: 0x20B700 VA: 0x18020C300
	public double ToOADate() { }

	// RVA: 0x20C180 Offset: 0x20B580 VA: 0x18020C180
	public long ToFileTime() { }

	// RVA: 0x20C170 Offset: 0x20B570 VA: 0x18020C170
	public long ToFileTimeUtc() { }

	// RVA: 0x20C240 Offset: 0x20B640 VA: 0x18020C240
	public DateTime ToLocalTime() { }

	// RVA: 0x20C250 Offset: 0x20B650 VA: 0x18020C250
	internal DateTime ToLocalTime(bool throwOnOverflow) { }

	// RVA: 0x20C260 Offset: 0x20B660 VA: 0x18020C260
	public string ToLongTimeString() { }

	// RVA: 0x20C480 Offset: 0x20B880 VA: 0x18020C480
	public string ToShortDateString() { }

	// RVA: 0x20C520 Offset: 0x20B920 VA: 0x18020C520
	public string ToShortTimeString() { }

	// RVA: 0x20C7A0 Offset: 0x20BBA0 VA: 0x18020C7A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x20C5C0 Offset: 0x20B9C0 VA: 0x18020C5C0
	public string ToString(string format) { }

	// RVA: 0x20C660 Offset: 0x20BA60 VA: 0x18020C660 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x20C700 Offset: 0x20BB00 VA: 0x18020C700 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x20C830 Offset: 0x20BC30 VA: 0x18020C830
	public DateTime ToUniversalTime() { }

	// RVA: 0x17A91B0 Offset: 0x17A77B0 VA: 0x1817A91B0
	public static bool TryParse(string s, IFormatProvider provider, DateTimeStyles styles, out DateTime result) { }

	// RVA: 0x17A90E0 Offset: 0x17A76E0 VA: 0x1817A90E0
	public static bool TryParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style, out DateTime result) { }

	// RVA: 0x17AA470 Offset: 0x17A8A70 VA: 0x1817AA470
	public static DateTime op_Addition(DateTime d, TimeSpan t) { }

	// RVA: 0x17AA5F0 Offset: 0x17A8BF0 VA: 0x1817AA5F0
	public static DateTime op_Subtraction(DateTime d, TimeSpan t) { }

	// RVA: 0x17AA6B0 Offset: 0x17A8CB0 VA: 0x1817AA6B0
	public static TimeSpan op_Subtraction(DateTime d1, DateTime d2) { }

	// RVA: 0x17AA530 Offset: 0x17A8B30 VA: 0x1817AA530
	public static bool op_Equality(DateTime d1, DateTime d2) { }

	// RVA: 0x17AA590 Offset: 0x17A8B90 VA: 0x1817AA590
	public static bool op_Inequality(DateTime d1, DateTime d2) { }

	// RVA: 0x17AA5D0 Offset: 0x17A8BD0 VA: 0x1817AA5D0
	public static bool op_LessThan(DateTime t1, DateTime t2) { }

	// RVA: 0x17AA5B0 Offset: 0x17A8BB0 VA: 0x1817AA5B0
	public static bool op_LessThanOrEqual(DateTime t1, DateTime t2) { }

	// RVA: 0x17AA570 Offset: 0x17A8B70 VA: 0x1817AA570
	public static bool op_GreaterThan(DateTime t1, DateTime t2) { }

	// RVA: 0x17AA550 Offset: 0x17A8B50 VA: 0x1817AA550
	public static bool op_GreaterThanOrEqual(DateTime t1, DateTime t2) { }

	// RVA: 0x20BE90 Offset: 0x20B290 VA: 0x18020BE90 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x20BEC0 Offset: 0x20B2C0 VA: 0x18020BEC0 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x20BEE0 Offset: 0x20B2E0 VA: 0x18020BEE0 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x20BF50 Offset: 0x20B350 VA: 0x18020BF50 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x20BED0 Offset: 0x20B2D0 VA: 0x18020BED0 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x20BF20 Offset: 0x20B320 VA: 0x18020BF20 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x20C000 Offset: 0x20B400 VA: 0x18020C000 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x20BF30 Offset: 0x20B330 VA: 0x18020BF30 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x20C010 Offset: 0x20B410 VA: 0x18020C010 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x20BF40 Offset: 0x20B340 VA: 0x18020BF40 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x20C020 Offset: 0x20B420 VA: 0x18020C020 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x20BF60 Offset: 0x20B360 VA: 0x18020BF60 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x20BF10 Offset: 0x20B310 VA: 0x18020BF10 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x20BEF0 Offset: 0x20B2F0 VA: 0x18020BEF0 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0xFC840 Offset: 0xFBC40 VA: 0x1800FC840 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x20BF70 Offset: 0x20B370 VA: 0x18020BF70 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x17A8E90 Offset: 0x17A7490 VA: 0x1817A8E90
	internal static bool TryCreate(int year, int month, int day, int hour, int minute, int second, int millisecond, out DateTime result) { }

	// RVA: 0x17A9350 Offset: 0x17A7950 VA: 0x1817A9350
	private static void .cctor() { }

}

public enum DateTimeKind // TypeDefIndex: 198
{	// Fields
	public int value__; // 0x0
	public const DateTimeKind Unspecified = 0;
	public const DateTimeKind Utc = 1;
	public const DateTimeKind Local = 2;

}

public struct DateTimeOffset : IComparable, IFormattable, ISerializable, IDeserializationCallback, IComparable<DateTimeOffset>, IEquatable<DateTimeOffset> // TypeDefIndex: 199
{	// Fields
	public static readonly DateTimeOffset MinValue; // 0x0
	public static readonly DateTimeOffset MaxValue; // 0x10
	private DateTime m_dateTime; // 0x0
	private short m_offsetMinutes; // 0x8

	// Properties
	public static DateTimeOffset Now { get; }
	public static DateTimeOffset UtcNow { get; }
	public DateTime DateTime { get; }
	public DateTime UtcDateTime { get; }
	public DateTime LocalDateTime { get; }
	private DateTime ClockDateTime { get; }
	public int Day { get; }
	public int Hour { get; }
	public int Minute { get; }
	public int Month { get; }
	public TimeSpan Offset { get; }
	public int Second { get; }
	public long Ticks { get; }
	public int Year { get; }

	// Methods

	// RVA: 0x20B560 Offset: 0x20A960 VA: 0x18020B560
	public void .ctor(long ticks, TimeSpan offset) { }

	// RVA: 0x20B6E0 Offset: 0x20AAE0 VA: 0x18020B6E0
	public void .ctor(DateTime dateTime) { }

	// RVA: 0x20B6D0 Offset: 0x20AAD0 VA: 0x18020B6D0
	public void .ctor(DateTime dateTime, TimeSpan offset) { }

	// RVA: 0x1799E80 Offset: 0x1798480 VA: 0x181799E80
	public static DateTimeOffset get_Now() { }

	// RVA: 0x179A020 Offset: 0x1798620 VA: 0x18179A020
	public static DateTimeOffset get_UtcNow() { }

	// RVA: 0x20B700 Offset: 0x20AB00 VA: 0x18020B700
	public DateTime get_DateTime() { }

	// RVA: 0x20B920 Offset: 0x20AD20 VA: 0x18020B920
	public DateTime get_UtcDateTime() { }

	// RVA: 0x20B7A0 Offset: 0x20ABA0 VA: 0x18020B7A0
	public DateTime get_LocalDateTime() { }

	// RVA: 0x20B6F0 Offset: 0x20AAF0 VA: 0x18020B6F0
	private DateTime get_ClockDateTime() { }

	// RVA: 0x20B710 Offset: 0x20AB10 VA: 0x18020B710
	public int get_Day() { }

	// RVA: 0x20B740 Offset: 0x20AB40 VA: 0x18020B740
	public int get_Hour() { }

	// RVA: 0x20B7D0 Offset: 0x20ABD0 VA: 0x18020B7D0
	public int get_Minute() { }

	// RVA: 0x20B830 Offset: 0x20AC30 VA: 0x18020B830
	public int get_Month() { }

	// RVA: 0x20B860 Offset: 0x20AC60 VA: 0x18020B860
	public TimeSpan get_Offset() { }

	// RVA: 0x20B890 Offset: 0x20AC90 VA: 0x18020B890
	public int get_Second() { }

	// RVA: 0x20B8F0 Offset: 0x20ACF0 VA: 0x18020B8F0
	public long get_Ticks() { }

	// RVA: 0x20B930 Offset: 0x20AD30 VA: 0x18020B930
	public int get_Year() { }

	// RVA: 0x1798190 Offset: 0x1796790 VA: 0x181798190
	public static int Compare(DateTimeOffset first, DateTimeOffset second) { }

	// RVA: 0x20AF60 Offset: 0x20A360 VA: 0x18020AF60 Slot: 4
	private int System.IComparable.CompareTo(object obj) { }

	// RVA: 0x20AC50 Offset: 0x20A050 VA: 0x18020AC50 Slot: 8
	public int CompareTo(DateTimeOffset other) { }

	// RVA: 0x20AE10 Offset: 0x20A210 VA: 0x18020AE10 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x20AD70 Offset: 0x20A170 VA: 0x18020AD70 Slot: 9
	public bool Equals(DateTimeOffset other) { }

	// RVA: 0x20B120 Offset: 0x20A520 VA: 0x18020B120 Slot: 7
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x20B130 Offset: 0x20A530 VA: 0x18020B130 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x20B570 Offset: 0x20A970 VA: 0x18020B570
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x20AF30 Offset: 0x20A330 VA: 0x18020AF30 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x17984E0 Offset: 0x1796AE0 VA: 0x1817984E0
	public static DateTimeOffset Parse(string input, IFormatProvider formatProvider) { }

	// RVA: 0x1798720 Offset: 0x1796D20 VA: 0x181798720
	public static DateTimeOffset Parse(string input, IFormatProvider formatProvider, DateTimeStyles styles) { }

	// RVA: 0x17983C0 Offset: 0x17969C0 VA: 0x1817983C0
	public static DateTimeOffset ParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles) { }

	// RVA: 0x20B510 Offset: 0x20A910 VA: 0x18020B510
	public long ToUnixTimeSeconds() { }

	// RVA: 0x20B4C0 Offset: 0x20A8C0 VA: 0x18020B4C0
	public long ToUnixTimeMilliseconds() { }

	// RVA: 0x20B2B0 Offset: 0x20A6B0 VA: 0x18020B2B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x20B1D0 Offset: 0x20A5D0 VA: 0x18020B1D0
	public string ToString(IFormatProvider formatProvider) { }

	// RVA: 0x20B390 Offset: 0x20A790 VA: 0x18020B390 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x20B480 Offset: 0x20A880 VA: 0x18020B480
	public DateTimeOffset ToUniversalTime() { }

	// RVA: 0x1799180 Offset: 0x1797780 VA: 0x181799180
	public static bool TryParse(string input, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result) { }

	// RVA: 0x1798DD0 Offset: 0x17973D0 VA: 0x181798DD0
	public static bool TryParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result) { }

	// RVA: 0x1798F20 Offset: 0x1797520 VA: 0x181798F20
	public static bool TryParseExact(string input, string[] formats, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result) { }

	// RVA: 0x1799490 Offset: 0x1797A90 VA: 0x181799490
	private static short ValidateOffset(TimeSpan offset) { }

	// RVA: 0x17993D0 Offset: 0x17979D0 VA: 0x1817993D0
	private static DateTime ValidateDate(DateTime dateTime, TimeSpan offset) { }

	// RVA: 0x17995A0 Offset: 0x1797BA0 VA: 0x1817995A0
	private static DateTimeStyles ValidateStyles(DateTimeStyles style, string parameterName) { }

	// RVA: 0x179A1A0 Offset: 0x17987A0 VA: 0x18179A1A0
	public static DateTimeOffset op_Implicit(DateTime dateTime) { }

	// RVA: 0x179A250 Offset: 0x1798850 VA: 0x18179A250
	public static TimeSpan op_Subtraction(DateTimeOffset left, DateTimeOffset right) { }

	// RVA: 0x179A110 Offset: 0x1798710 VA: 0x18179A110
	public static bool op_Equality(DateTimeOffset left, DateTimeOffset right) { }

	// RVA: 0x179A1C0 Offset: 0x17987C0 VA: 0x18179A1C0
	public static bool op_Inequality(DateTimeOffset left, DateTimeOffset right) { }

	// RVA: 0x17996D0 Offset: 0x1797CD0 VA: 0x1817996D0
	private static void .cctor() { }

}

internal static class DateTimeFormat // TypeDefIndex: 225
{	// Fields
	internal static readonly TimeSpan NullOffset; // 0x0
	internal static char[] allStandardFormats; // 0x8
	internal static string[] fixedNumberFormats; // 0x10

	// Methods

	// RVA: 0x17970A0 Offset: 0x17956A0 VA: 0x1817970A0
	internal static void FormatDigits(StringBuilder outputBuffer, int value, int len) { }

	// RVA: 0x1797120 Offset: 0x1795720 VA: 0x181797120
	internal static void FormatDigits(StringBuilder outputBuffer, int value, int len, bool overrideLengthLimit) { }

	// RVA: 0x1797930 Offset: 0x1795F30 VA: 0x181797930
	private static void HebrewFormatDigits(StringBuilder outputBuffer, int digits) { }

	// RVA: 0x1797CA0 Offset: 0x17962A0 VA: 0x181797CA0
	internal static int ParseRepeatPattern(string format, int pos, char patternChar) { }

	// RVA: 0x1797060 Offset: 0x1795660 VA: 0x181797060
	private static string FormatDayOfWeek(int dayOfWeek, int repeat, DateTimeFormatInfo dtfi) { }

	// RVA: 0x17972E0 Offset: 0x17958E0 VA: 0x1817972E0
	private static string FormatMonth(int month, int repeatCount, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1797220 Offset: 0x1795820 VA: 0x181797220
	private static string FormatHebrewMonthName(DateTime time, int month, int repeatCount, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1797B00 Offset: 0x1796100 VA: 0x181797B00
	internal static int ParseQuoteString(string format, int pos, StringBuilder result) { }

	// RVA: 0x1797AC0 Offset: 0x17960C0 VA: 0x181797AC0
	internal static int ParseNextChar(string format, int pos) { }

	// RVA: 0x17979B0 Offset: 0x1795FB0 VA: 0x1817979B0
	private static bool IsUseGenitiveForm(string format, int index, int tokenLen, char patternToMatch) { }

	// RVA: 0x1795DC0 Offset: 0x17943C0 VA: 0x181795DC0
	private static string FormatCustomized(DateTime dateTime, string format, DateTimeFormatInfo dtfi, TimeSpan offset) { }

	// RVA: 0x1795A30 Offset: 0x1794030 VA: 0x181795A30
	private static void FormatCustomizedTimeZone(DateTime dateTime, TimeSpan offset, string format, int tokenLen, bool timeOnly, StringBuilder result) { }

	// RVA: 0x1795800 Offset: 0x1793E00 VA: 0x181795800
	private static void FormatCustomizedRoundripTimeZone(DateTime dateTime, TimeSpan offset, StringBuilder result) { }

	// RVA: 0x1797610 Offset: 0x1795C10 VA: 0x181797610
	internal static string GetRealFormat(string format, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1795180 Offset: 0x1793780 VA: 0x181795180
	private static string ExpandPredefinedFormat(string format, ref DateTime dateTime, ref DateTimeFormatInfo dtfi, ref TimeSpan offset) { }

	// RVA: 0x1797320 Offset: 0x1795920 VA: 0x181797320
	internal static string Format(DateTime dateTime, string format, DateTimeFormatInfo dtfi) { }

	// RVA: 0x17973B0 Offset: 0x17959B0 VA: 0x1817973B0
	internal static string Format(DateTime dateTime, string format, DateTimeFormatInfo dtfi, TimeSpan offset) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal static void InvalidFormatForLocal(string format, DateTime dateTime) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal static void InvalidFormatForUtc(string format, DateTime dateTime) { }

	// RVA: 0x1797D20 Offset: 0x1796320 VA: 0x181797D20
	private static void .cctor() { }

}

internal static class DateTimeParse // TypeDefIndex: 226
{	// Fields
	internal static DateTimeParse.MatchNumberDelegate m_hebrewNumberParser; // 0x0
	private static DateTimeParse.DS[][] dateParsingStates; // 0x8

	// Methods

	// RVA: 0x17A1930 Offset: 0x179FF30 VA: 0x1817A1930
	internal static DateTime ParseExact(string s, string format, DateTimeFormatInfo dtfi, DateTimeStyles style) { }

	// RVA: 0x17A16D0 Offset: 0x179FCD0 VA: 0x1817A16D0
	internal static DateTime ParseExact(string s, string format, DateTimeFormatInfo dtfi, DateTimeStyles style, out TimeSpan offset) { }

	// RVA: 0x17A4380 Offset: 0x17A2980 VA: 0x1817A4380
	internal static bool TryParseExact(string s, string format, DateTimeFormatInfo dtfi, DateTimeStyles style, out DateTime result) { }

	// RVA: 0x17A3FD0 Offset: 0x17A25D0 VA: 0x1817A3FD0
	internal static bool TryParseExact(string s, string format, DateTimeFormatInfo dtfi, DateTimeStyles style, out DateTime result, out TimeSpan offset) { }

	// RVA: 0x17A4240 Offset: 0x17A2840 VA: 0x1817A4240
	internal static bool TryParseExact(string s, string format, DateTimeFormatInfo dtfi, DateTimeStyles style, ref DateTimeResult result) { }

	// RVA: 0x17A15A0 Offset: 0x179FBA0 VA: 0x1817A15A0
	internal static DateTime ParseExactMultiple(string s, string[] formats, DateTimeFormatInfo dtfi, DateTimeStyles style) { }

	// RVA: 0x17A3E40 Offset: 0x17A2440 VA: 0x1817A3E40
	internal static bool TryParseExactMultiple(string s, string[] formats, DateTimeFormatInfo dtfi, DateTimeStyles style, out DateTime result, out TimeSpan offset) { }

	// RVA: 0x17A3B20 Offset: 0x17A2120 VA: 0x1817A3B20
	internal static bool TryParseExactMultiple(string s, string[] formats, DateTimeFormatInfo dtfi, DateTimeStyles style, ref DateTimeResult result) { }

	// RVA: 0x179FB80 Offset: 0x179E180 VA: 0x18179FB80
	private static bool MatchWord(ref __DTString str, string target) { }

	// RVA: 0x179DDB0 Offset: 0x179C3B0 VA: 0x18179DDB0
	private static bool GetTimeZoneName(ref __DTString str) { }

	// RVA: 0x179E330 Offset: 0x179C930 VA: 0x18179E330
	internal static bool IsDigit(char ch) { }

	// RVA: 0x17A1C80 Offset: 0x17A0280 VA: 0x1817A1C80
	private static bool ParseFraction(ref __DTString str, out double result) { }

	// RVA: 0x17A2760 Offset: 0x17A0D60 VA: 0x1817A2760
	private static bool ParseTimeZone(ref __DTString str, ref TimeSpan result) { }

	// RVA: 0x179E1D0 Offset: 0x179C7D0 VA: 0x18179E1D0
	private static bool HandleTimeZone(ref __DTString str, ref DateTimeResult result) { }

	// RVA: 0x179E350 Offset: 0x179C950 VA: 0x18179E350
	private static bool Lex(DateTimeParse.DS dps, ref __DTString str, ref DateTimeToken dtok, ref DateTimeRawInfo raw, ref DateTimeResult result, ref DateTimeFormatInfo dtfi, DateTimeStyles styles) { }

	// RVA: 0x17A5210 Offset: 0x17A3810 VA: 0x1817A5210
	private static bool VerifyValidPunctuation(ref __DTString str) { }

	// RVA: 0x179DE50 Offset: 0x179C450 VA: 0x18179DE50
	private static bool GetYearMonthDayOrder(string datePattern, DateTimeFormatInfo dtfi, out int order) { }

	// RVA: 0x179E080 Offset: 0x179C680 VA: 0x18179E080
	private static bool GetYearMonthOrder(string pattern, DateTimeFormatInfo dtfi, out int order) { }

	// RVA: 0x179DA60 Offset: 0x179C060 VA: 0x18179DA60
	private static bool GetMonthDayOrder(string pattern, DateTimeFormatInfo dtfi, out int order) { }

	// RVA: 0x17A3A70 Offset: 0x17A2070 VA: 0x1817A3A70
	private static bool TryAdjustYear(ref DateTimeResult result, int year, out int adjustedYear) { }

	// RVA: 0x17A39F0 Offset: 0x17A1FF0 VA: 0x1817A39F0
	private static bool SetDateYMD(ref DateTimeResult result, int year, int month, int day) { }

	// RVA: 0x17A3870 Offset: 0x17A1E70 VA: 0x1817A3870
	private static bool SetDateMDY(ref DateTimeResult result, int month, int day, int year) { }

	// RVA: 0x17A37B0 Offset: 0x17A1DB0 VA: 0x1817A37B0
	private static bool SetDateDMY(ref DateTimeResult result, int day, int month, int year) { }

	// RVA: 0x17A3930 Offset: 0x17A1F30 VA: 0x1817A3930
	private static bool SetDateYDM(ref DateTimeResult result, int year, int day, int month) { }

	// RVA: 0x179D840 Offset: 0x179BE40 VA: 0x18179D840
	private static void GetDefaultYear(ref DateTimeResult result, ref DateTimeStyles styles) { }

	// RVA: 0x179D140 Offset: 0x179B740 VA: 0x18179D140
	private static bool GetDayOfNN(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x179CAA0 Offset: 0x179B0A0 VA: 0x18179CAA0
	private static bool GetDayOfNNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x179C580 Offset: 0x179AB80 VA: 0x18179C580
	private static bool GetDayOfMN(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x179D8E0 Offset: 0x179BEE0 VA: 0x18179D8E0
	private static bool GetHebrewDayOfNM(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x179C810 Offset: 0x179AE10 VA: 0x18179C810
	private static bool GetDayOfNM(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x179C170 Offset: 0x179A770 VA: 0x18179C170
	private static bool GetDayOfMNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x179D560 Offset: 0x179BB60 VA: 0x18179D560
	private static bool GetDayOfYNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x179CF60 Offset: 0x179B560 VA: 0x18179CF60
	private static bool GetDayOfNNY(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x179D320 Offset: 0x179B920 VA: 0x18179D320
	private static bool GetDayOfYMN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x179D700 Offset: 0x179BD00 VA: 0x18179D700
	private static bool GetDayOfYN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x179D420 Offset: 0x179BA20 VA: 0x18179D420
	private static bool GetDayOfYM(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x179A320 Offset: 0x1798920 VA: 0x18179A320
	private static void AdjustTimeMark(DateTimeFormatInfo dtfi, ref DateTimeRawInfo raw) { }

	// RVA: 0x179A2E0 Offset: 0x17988E0 VA: 0x18179A2E0
	private static bool AdjustHour(ref int hour, DateTimeParse.TM timeMark) { }

	// RVA: 0x179DD20 Offset: 0x179C320 VA: 0x18179DD20
	private static bool GetTimeOfN(DateTimeFormatInfo dtfi, ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x179DC90 Offset: 0x179C290 VA: 0x18179DC90
	private static bool GetTimeOfNN(DateTimeFormatInfo dtfi, ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x179DBF0 Offset: 0x179C1F0 VA: 0x18179DBF0
	private static bool GetTimeOfNNN(DateTimeFormatInfo dtfi, ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x179BA20 Offset: 0x179A020 VA: 0x18179BA20
	private static bool GetDateOfDSN(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x179BAB0 Offset: 0x179A0B0 VA: 0x18179BAB0
	private static bool GetDateOfNDS(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x179BB70 Offset: 0x179A170 VA: 0x18179BB70
	private static bool GetDateOfNNDS(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x17A2CC0 Offset: 0x17A12C0 VA: 0x1817A2CC0
	private static bool ProcessDateTimeSuffix(ref DateTimeResult result, ref DateTimeRawInfo raw, ref DateTimeToken dtok) { }

	// RVA: 0x17A2DA0 Offset: 0x17A13A0 VA: 0x1817A2DA0
	internal static bool ProcessHebrewTerminalState(DateTimeParse.DS dps, ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x17A3220 Offset: 0x17A1820 VA: 0x1817A3220
	internal static bool ProcessTerminaltState(DateTimeParse.DS dps, ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x17A2A70 Offset: 0x17A1070 VA: 0x1817A2A70
	internal static DateTime Parse(string s, DateTimeFormatInfo dtfi, DateTimeStyles styles) { }

	// RVA: 0x17A2B90 Offset: 0x17A1190 VA: 0x1817A2B90
	internal static DateTime Parse(string s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out TimeSpan offset) { }

	// RVA: 0x17A4F60 Offset: 0x17A3560 VA: 0x1817A4F60
	internal static bool TryParse(string s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out DateTime result) { }

	// RVA: 0x17A5090 Offset: 0x17A3690 VA: 0x1817A5090
	internal static bool TryParse(string s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out DateTime result, out TimeSpan offset) { }

	// RVA: 0x17A4670 Offset: 0x17A2C70 VA: 0x1817A4670
	internal static bool TryParse(string s, DateTimeFormatInfo dtfi, DateTimeStyles styles, ref DateTimeResult result) { }

	// RVA: 0x179AB50 Offset: 0x1799150 VA: 0x18179AB50
	private static bool DetermineTimeZoneAdjustments(ref DateTimeResult result, DateTimeStyles styles, bool bTimeOnly) { }

	// RVA: 0x179A950 Offset: 0x1798F50 VA: 0x18179A950
	private static bool DateTimeOffsetTimeZonePostProcessing(ref DateTimeResult result, DateTimeStyles styles) { }

	// RVA: 0x179A5B0 Offset: 0x1798BB0 VA: 0x18179A5B0
	private static bool AdjustTimeZoneToUniversal(ref DateTimeResult result) { }

	// RVA: 0x179A390 Offset: 0x1798990 VA: 0x18179A390
	private static bool AdjustTimeZoneToLocal(ref DateTimeResult result, bool bTimeOnly) { }

	// RVA: 0x17A1D60 Offset: 0x17A0360 VA: 0x1817A1D60
	private static bool ParseISO8601(ref DateTimeRawInfo raw, ref __DTString str, DateTimeStyles styles, ref DateTimeResult result) { }

	// RVA: 0x179F800 Offset: 0x179DE00 VA: 0x18179F800
	internal static bool MatchHebrewDigits(ref __DTString str, int digitLen, out int number) { }

	// RVA: 0x17A13C0 Offset: 0x179F9C0 VA: 0x1817A13C0
	internal static bool ParseDigits(ref __DTString str, int digitLen, out int result) { }

	// RVA: 0x17A14F0 Offset: 0x179FAF0 VA: 0x1817A14F0
	internal static bool ParseDigits(ref __DTString str, int minDigitLen, int maxDigitLen, out int result) { }

	// RVA: 0x17A1B40 Offset: 0x17A0140 VA: 0x1817A1B40
	private static bool ParseFractionExact(ref __DTString str, int maxDigitLen, ref double result) { }

	// RVA: 0x17A2380 Offset: 0x17A0980 VA: 0x1817A2380
	private static bool ParseSign(ref __DTString str, ref bool result) { }

	// RVA: 0x17A23E0 Offset: 0x17A09E0 VA: 0x1817A23E0
	private static bool ParseTimeZoneOffset(ref __DTString str, int len, ref TimeSpan result) { }

	// RVA: 0x179F390 Offset: 0x179D990 VA: 0x18179F390
	private static bool MatchAbbreviatedMonthName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	// RVA: 0x179F8E0 Offset: 0x179DEE0 VA: 0x18179F8E0
	private static bool MatchMonthName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	// RVA: 0x179F2B0 Offset: 0x179D8B0 VA: 0x18179F2B0
	private static bool MatchAbbreviatedDayName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	// RVA: 0x179F5A0 Offset: 0x179DBA0 VA: 0x18179F5A0
	private static bool MatchDayName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	// RVA: 0x179F680 Offset: 0x179DC80 VA: 0x18179F680
	private static bool MatchEraName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	// RVA: 0x179FA70 Offset: 0x179E070 VA: 0x18179FA70
	private static bool MatchTimeMark(ref __DTString str, DateTimeFormatInfo dtfi, ref DateTimeParse.TM result) { }

	// RVA: 0x179F4F0 Offset: 0x179DAF0 VA: 0x18179F4F0
	private static bool MatchAbbreviatedTimeMark(ref __DTString str, DateTimeFormatInfo dtfi, ref DateTimeParse.TM result) { }

	// RVA: 0x179A8A0 Offset: 0x1798EA0 VA: 0x18179A8A0
	private static bool CheckNewValue(ref int currentValue, int newValue, char patternChar, ref DateTimeResult result) { }

	// RVA: 0x179BE10 Offset: 0x179A410 VA: 0x18179BE10
	private static DateTime GetDateTimeNow(ref DateTimeResult result, ref DateTimeStyles styles) { }

	// RVA: 0x179A670 Offset: 0x1798C70 VA: 0x18179A670
	private static bool CheckDefaultDateTime(ref DateTimeResult result, ref Calendar cal, DateTimeStyles styles) { }

	// RVA: 0x179B380 Offset: 0x1799980 VA: 0x18179B380
	private static string ExpandPredefinedFormat(string format, ref DateTimeFormatInfo dtfi, ref ParsingInfo parseInfo, ref DateTimeResult result) { }

	// RVA: 0x179FCC0 Offset: 0x179E2C0 VA: 0x18179FCC0
	private static bool ParseByFormat(ref __DTString str, ref __DTString format, ref ParsingInfo parseInfo, DateTimeFormatInfo dtfi, ref DateTimeResult result) { }

	// RVA: 0x17A45A0 Offset: 0x17A2BA0 VA: 0x1817A45A0
	internal static bool TryParseQuoteString(string format, int pos, StringBuilder result, out int returnValue) { }

	// RVA: 0x179AD50 Offset: 0x1799350 VA: 0x18179AD50
	private static bool DoStrictParse(string s, string formatParam, DateTimeStyles styles, DateTimeFormatInfo dtfi, ref DateTimeResult result) { }

	// RVA: 0x179BF80 Offset: 0x179A580 VA: 0x18179BF80
	private static Exception GetDateTimeParseException(ref DateTimeResult result) { }

	// RVA: 0x17A5380 Offset: 0x17A3980 VA: 0x1817A5380
	private static void .cctor() { }

}

internal sealed class DateTimeParse.MatchNumberDelegate : MulticastDelegate // TypeDefIndex: 227
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x17AD1B0 Offset: 0x17AB7B0 VA: 0x1817AD1B0 Slot: 12
	public virtual bool Invoke(ref __DTString str, int digitLen, out int result) { }

	// RVA: 0x17AD100 Offset: 0x17AB700 VA: 0x1817AD100 Slot: 13
	public virtual IAsyncResult BeginInvoke(ref __DTString str, int digitLen, out int result, AsyncCallback callback, object object) { }

	// RVA: 0x175CE90 Offset: 0x175B490 VA: 0x18175CE90 Slot: 14
	public virtual bool EndInvoke(ref __DTString str, out int result, IAsyncResult __result) { }

}

internal enum DateTimeParse.DTT // TypeDefIndex: 228
{	// Fields
	public int value__; // 0x0
	public const DateTimeParse.DTT End = 0;
	public const DateTimeParse.DTT NumEnd = 1;
	public const DateTimeParse.DTT NumAmpm = 2;
	public const DateTimeParse.DTT NumSpace = 3;
	public const DateTimeParse.DTT NumDatesep = 4;
	public const DateTimeParse.DTT NumTimesep = 5;
	public const DateTimeParse.DTT MonthEnd = 6;
	public const DateTimeParse.DTT MonthSpace = 7;
	public const DateTimeParse.DTT MonthDatesep = 8;
	public const DateTimeParse.DTT NumDatesuff = 9;
	public const DateTimeParse.DTT NumTimesuff = 10;
	public const DateTimeParse.DTT DayOfWeek = 11;
	public const DateTimeParse.DTT YearSpace = 12;
	public const DateTimeParse.DTT YearDateSep = 13;
	public const DateTimeParse.DTT YearEnd = 14;
	public const DateTimeParse.DTT TimeZone = 15;
	public const DateTimeParse.DTT Era = 16;
	public const DateTimeParse.DTT NumUTCTimeMark = 17;
	public const DateTimeParse.DTT Unk = 18;
	public const DateTimeParse.DTT NumLocalTimeMark = 19;
	public const DateTimeParse.DTT Max = 20;

}

internal enum DateTimeParse.TM // TypeDefIndex: 229
{	// Fields
	public int value__; // 0x0
	public const DateTimeParse.TM NotSet = -1;
	public const DateTimeParse.TM AM = 0;
	public const DateTimeParse.TM PM = 1;

}

internal enum DateTimeParse.DS // TypeDefIndex: 230
{	// Fields
	public int value__; // 0x0
	public const DateTimeParse.DS BEGIN = 0;
	public const DateTimeParse.DS N = 1;
	public const DateTimeParse.DS NN = 2;
	public const DateTimeParse.DS D_Nd = 3;
	public const DateTimeParse.DS D_NN = 4;
	public const DateTimeParse.DS D_NNd = 5;
	public const DateTimeParse.DS D_M = 6;
	public const DateTimeParse.DS D_MN = 7;
	public const DateTimeParse.DS D_NM = 8;
	public const DateTimeParse.DS D_MNd = 9;
	public const DateTimeParse.DS D_NDS = 10;
	public const DateTimeParse.DS D_Y = 11;
	public const DateTimeParse.DS D_YN = 12;
	public const DateTimeParse.DS D_YNd = 13;
	public const DateTimeParse.DS D_YM = 14;
	public const DateTimeParse.DS D_YMd = 15;
	public const DateTimeParse.DS D_S = 16;
	public const DateTimeParse.DS T_S = 17;
	public const DateTimeParse.DS T_Nt = 18;
	public const DateTimeParse.DS T_NNt = 19;
	public const DateTimeParse.DS ERROR = 20;
	public const DateTimeParse.DS DX_NN = 21;
	public const DateTimeParse.DS DX_NNN = 22;
	public const DateTimeParse.DS DX_MN = 23;
	public const DateTimeParse.DS DX_NM = 24;
	public const DateTimeParse.DS DX_MNN = 25;
	public const DateTimeParse.DS DX_DS = 26;
	public const DateTimeParse.DS DX_DSN = 27;
	public const DateTimeParse.DS DX_NDS = 28;
	public const DateTimeParse.DS DX_NNDS = 29;
	public const DateTimeParse.DS DX_YNN = 30;
	public const DateTimeParse.DS DX_YMN = 31;
	public const DateTimeParse.DS DX_YN = 32;
	public const DateTimeParse.DS DX_YM = 33;
	public const DateTimeParse.DS TX_N = 34;
	public const DateTimeParse.DS TX_NN = 35;
	public const DateTimeParse.DS TX_NNN = 36;
	public const DateTimeParse.DS TX_TS = 37;
	public const DateTimeParse.DS DX_NNY = 38;

}

internal struct DateTimeToken // TypeDefIndex: 234
{	// Fields
	internal DateTimeParse.DTT dtt; // 0x0
	internal TokenType suffix; // 0x4
	internal int num; // 0x8

}

internal struct DateTimeRawInfo // TypeDefIndex: 235
{	// Fields
	private int* num; // 0x0
	internal int numCount; // 0x8
	internal int month; // 0xC
	internal int year; // 0x10
	internal int dayOfWeek; // 0x14
	internal int era; // 0x18
	internal DateTimeParse.TM timeMark; // 0x1C
	internal double fraction; // 0x20
	internal bool hasSameDateAndTimeSeparators; // 0x28
	internal bool timeZone; // 0x29

	// Methods

	// RVA: 0x20B990 Offset: 0x20AD90 VA: 0x18020B990
	internal void Init(int* numberBuffer) { }

	// RVA: 0x20B960 Offset: 0x20AD60 VA: 0x18020B960
	internal void AddNumber(int value) { }

	// RVA: 0x20B980 Offset: 0x20AD80 VA: 0x18020B980
	internal int GetNumber(int index) { }

}

internal struct DateTimeResult // TypeDefIndex: 238
{	// Fields
	internal int Year; // 0x0
	internal int Month; // 0x4
	internal int Day; // 0x8
	internal int Hour; // 0xC
	internal int Minute; // 0x10
	internal int Second; // 0x14
	internal double fraction; // 0x18
	internal int era; // 0x20
	internal ParseFlags flags; // 0x24
	internal TimeSpan timeZoneOffset; // 0x28
	internal Calendar calendar; // 0x30
	internal DateTime parsedDate; // 0x38
	internal ParseFailureKind failure; // 0x40
	internal string failureMessageID; // 0x48
	internal object failureMessageFormatArgument; // 0x50
	internal string failureArgumentName; // 0x58

	// Methods

	// RVA: 0x20BA60 Offset: 0x20AE60 VA: 0x18020BA60
	internal void Init() { }

	// RVA: 0x20BA90 Offset: 0x20AE90 VA: 0x18020BA90
	internal void SetDate(int year, int month, int day) { }

	// RVA: 0x20BAA0 Offset: 0x20AEA0 VA: 0x18020BAA0
	internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) { }

	// RVA: 0x20BAE0 Offset: 0x20AEE0 VA: 0x18020BAE0
	internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument, string failureArgumentName) { }

}

internal enum DateTimeFormatFlags // TypeDefIndex: 694
{	// Fields
	public int value__; // 0x0
	public const DateTimeFormatFlags None = 0;
	public const DateTimeFormatFlags UseGenitiveMonth = 1;
	public const DateTimeFormatFlags UseLeapYearMonth = 2;
	public const DateTimeFormatFlags UseSpacesInMonthNames = 4;
	public const DateTimeFormatFlags UseHebrewRule = 8;
	public const DateTimeFormatFlags UseSpacesInDayNames = 16;
	public const DateTimeFormatFlags UseDigitPrefixInTokens = 32;
	public const DateTimeFormatFlags NotInitialized = -1;

}

public sealed class DateTimeFormatInfo : ICloneable, IFormatProvider // TypeDefIndex: 695
{	// Fields
	private static DateTimeFormatInfo invariantInfo; // 0x0
	private CultureData m_cultureData; // 0x10
	[OptionalFieldAttribute] // RVA: 0x92F60 Offset: 0x92360 VA: 0x180092F60
	internal string m_name; // 0x18
	private string m_langName; // 0x20
	private CompareInfo m_compareInfo; // 0x28
	private CultureInfo m_cultureInfo; // 0x30
	internal string amDesignator; // 0x38
	internal string pmDesignator; // 0x40
	[OptionalFieldAttribute] // RVA: 0x96550 Offset: 0x95950 VA: 0x180096550
	internal string dateSeparator; // 0x48
	[OptionalFieldAttribute] // RVA: 0x96550 Offset: 0x95950 VA: 0x180096550
	internal string generalShortTimePattern; // 0x50
	[OptionalFieldAttribute] // RVA: 0x96550 Offset: 0x95950 VA: 0x180096550
	internal string generalLongTimePattern; // 0x58
	[OptionalFieldAttribute] // RVA: 0x96550 Offset: 0x95950 VA: 0x180096550
	internal string timeSeparator; // 0x60
	internal string monthDayPattern; // 0x68
	[OptionalFieldAttribute] // RVA: 0x92F60 Offset: 0x92360 VA: 0x180092F60
	internal string dateTimeOffsetPattern; // 0x70
	internal const string rfc1123Pattern = "ddd, dd MMM yyyy HH\':\'mm\':\'ss \'GMT\'";
	internal const string sortableDateTimePattern = "yyyy\'-\'MM\'-\'dd\'T\'HH\':\'mm\':\'ss";
	internal const string universalSortableDateTimePattern = "yyyy\'-\'MM\'-\'dd HH\':\'mm\':\'ss\'Z\'";
	internal Calendar calendar; // 0x78
	internal int firstDayOfWeek; // 0x80
	internal int calendarWeekRule; // 0x84
	[OptionalFieldAttribute] // RVA: 0x96550 Offset: 0x95950 VA: 0x180096550
	internal string fullDateTimePattern; // 0x88
	internal string[] abbreviatedDayNames; // 0x90
	[OptionalFieldAttribute] // RVA: 0x92F60 Offset: 0x92360 VA: 0x180092F60
	internal string[] m_superShortDayNames; // 0x98
	internal string[] dayNames; // 0xA0
	internal string[] abbreviatedMonthNames; // 0xA8
	internal string[] monthNames; // 0xB0
	[OptionalFieldAttribute] // RVA: 0x92F60 Offset: 0x92360 VA: 0x180092F60
	internal string[] genitiveMonthNames; // 0xB8
	[OptionalFieldAttribute] // RVA: 0x92F60 Offset: 0x92360 VA: 0x180092F60
	internal string[] m_genitiveAbbreviatedMonthNames; // 0xC0
	[OptionalFieldAttribute] // RVA: 0x92F60 Offset: 0x92360 VA: 0x180092F60
	internal string[] leapYearMonthNames; // 0xC8
	internal string longDatePattern; // 0xD0
	internal string shortDatePattern; // 0xD8
	internal string yearMonthPattern; // 0xE0
	internal string longTimePattern; // 0xE8
	internal string shortTimePattern; // 0xF0
	[OptionalFieldAttribute] // RVA: 0xA9AF0 Offset: 0xA8EF0 VA: 0x1800A9AF0
	private string[] allYearMonthPatterns; // 0xF8
	internal string[] allShortDatePatterns; // 0x100
	internal string[] allLongDatePatterns; // 0x108
	internal string[] allShortTimePatterns; // 0x110
	internal string[] allLongTimePatterns; // 0x118
	internal string[] m_eraNames; // 0x120
	internal string[] m_abbrevEraNames; // 0x128
	internal string[] m_abbrevEnglishEraNames; // 0x130
	internal int[] optionalCalendars; // 0x138
	private const int DEFAULT_ALL_DATETIMES_SIZE = 132;
	internal bool m_isReadOnly; // 0x140
	[OptionalFieldAttribute] // RVA: 0x92F60 Offset: 0x92360 VA: 0x180092F60
	internal DateTimeFormatFlags formatFlags; // 0x144
	internal static bool preferExistingTokens; // 0x8
	[OptionalFieldAttribute] // RVA: 0x96550 Offset: 0x95950 VA: 0x180096550
	private int CultureID; // 0x148
	[OptionalFieldAttribute] // RVA: 0x96550 Offset: 0x95950 VA: 0x180096550
	private bool m_useUserOverride; // 0x14C
	[OptionalFieldAttribute] // RVA: 0x96550 Offset: 0x95950 VA: 0x180096550
	private bool bUseCalendarInfo; // 0x14D
	[OptionalFieldAttribute] // RVA: 0x96550 Offset: 0x95950 VA: 0x180096550
	private int nDataItem; // 0x150
	[OptionalFieldAttribute] // RVA: 0x92F60 Offset: 0x92360 VA: 0x180092F60
	internal bool m_isDefaultCalendar; // 0x154
	[OptionalFieldAttribute] // RVA: 0x92F60 Offset: 0x92360 VA: 0x180092F60
	private static Hashtable s_calendarNativeNames; // 0x10
	[OptionalFieldAttribute] // RVA: 0x96550 Offset: 0x95950 VA: 0x180096550
	internal string[] m_dateWords; // 0x158
	private string m_fullTimeSpanPositivePattern; // 0x160
	private string m_fullTimeSpanNegativePattern; // 0x168
	internal const DateTimeStyles InvalidDateTimeStyles = -256;
	private TokenHashValue[] m_dtfiTokenHash; // 0x170
	private const int TOKEN_HASH_SIZE = 199;
	private const int SECOND_PRIME = 197;
	private const string dateSeparatorOrTimeZoneOffset = "-";
	private const string invariantDateSeparator = "/";
	private const string invariantTimeSeparator = ":";
	internal const string IgnorablePeriod = ".";
	internal const string IgnorableComma = ",";
	internal const string CJKYearSuff = "年";
	internal const string CJKMonthSuff = "月";
	internal const string CJKDaySuff = "日";
	internal const string KoreanYearSuff = "년";
	internal const string KoreanMonthSuff = "월";
	internal const string KoreanDaySuff = "일";
	internal const string KoreanHourSuff = "시";
	internal const string KoreanMinuteSuff = "분";
	internal const string KoreanSecondSuff = "초";
	internal const string CJKHourSuff = "時";
	internal const string ChineseHourSuff = "时";
	internal const string CJKMinuteSuff = "分";
	internal const string CJKSecondSuff = "秒";
	internal const string LocalTimeMark = "T";
	internal const string KoreanLangName = "ko";
	internal const string JapaneseLangName = "ja";
	internal const string EnglishLangName = "en";
	private static DateTimeFormatInfo s_jajpDTFI; // 0x18
	private static DateTimeFormatInfo s_zhtwDTFI; // 0x20

	// Properties
	private string CultureName { get; }
	private CultureInfo Culture { get; }
	private string LanguageName { get; }
	public static DateTimeFormatInfo InvariantInfo { get; }
	public static DateTimeFormatInfo CurrentInfo { get; }
	public string AMDesignator { get; }
	public Calendar Calendar { get; set; }
	private int[] OptionalCalendars { get; }
	internal string[] EraNames { get; }
	internal string[] AbbreviatedEraNames { get; }
	internal string[] AbbreviatedEnglishEraNames { get; }
	public string DateSeparator { get; }
	public string FullDateTimePattern { get; }
	public string LongDatePattern { get; set; }
	public string LongTimePattern { get; set; }
	public string MonthDayPattern { get; }
	public string PMDesignator { get; }
	public string RFC1123Pattern { get; }
	public string ShortDatePattern { get; set; }
	public string ShortTimePattern { get; set; }
	public string SortableDateTimePattern { get; }
	internal string GeneralShortTimePattern { get; }
	internal string GeneralLongTimePattern { get; }
	internal string DateTimeOffsetPattern { get; }
	public string TimeSeparator { get; }
	public string UniversalSortableDateTimePattern { get; }
	public string YearMonthPattern { get; set; }
	public string[] AbbreviatedDayNames { get; }
	public string[] DayNames { get; }
	public string[] AbbreviatedMonthNames { get; }
	public string[] MonthNames { get; }
	internal bool HasSpacesInMonthNames { get; }
	internal bool HasSpacesInDayNames { get; }
	private string[] AllYearMonthPatterns { get; }
	private string[] AllShortDatePatterns { get; }
	private string[] AllShortTimePatterns { get; }
	private string[] AllLongDatePatterns { get; }
	private string[] AllLongTimePatterns { get; }
	private string[] UnclonedYearMonthPatterns { get; }
	private string[] UnclonedShortDatePatterns { get; }
	private string[] UnclonedLongDatePatterns { get; }
	private string[] UnclonedShortTimePatterns { get; }
	private string[] UnclonedLongTimePatterns { get; }
	public bool IsReadOnly { get; }
	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public string[] MonthGenitiveNames { get; }
	internal string FullTimeSpanPositivePattern { get; }
	internal string FullTimeSpanNegativePattern { get; }
	internal CompareInfo CompareInfo { get; }
	internal DateTimeFormatFlags FormatFlags { get; }
	internal bool HasForceTwoDigitYears { get; }
	internal bool HasYearMonthAdjustment { get; }

	// Methods

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	private static bool InitPreferExistingTokens() { }

	// RVA: 0x16E3060 Offset: 0x16E1660 VA: 0x1816E3060
	private string get_CultureName() { }

	// RVA: 0x16E30A0 Offset: 0x16E16A0 VA: 0x1816E30A0
	private CultureInfo get_Culture() { }

	// RVA: 0x16E4260 Offset: 0x16E2860 VA: 0x1816E4260
	private string get_LanguageName() { }

	// RVA: 0x16E49A0 Offset: 0x16E2FA0 VA: 0x1816E49A0
	private string[] internalGetAbbreviatedDayOfWeekNames() { }

	// RVA: 0x16E4A80 Offset: 0x16E3080 VA: 0x1816E4A80
	private string[] internalGetDayOfWeekNames() { }

	// RVA: 0x16E4A10 Offset: 0x16E3010 VA: 0x1816E4A10
	private string[] internalGetAbbreviatedMonthNames() { }

	// RVA: 0x16E4E80 Offset: 0x16E3480 VA: 0x1816E4E80
	private string[] internalGetMonthNames() { }

	// RVA: 0x16E27D0 Offset: 0x16E0DD0 VA: 0x1816E27D0
	public void .ctor() { }

	// RVA: 0x16E2900 Offset: 0x16E0F00 VA: 0x1816E2900
	internal void .ctor(CultureData cultureData, Calendar cal) { }

	// RVA: 0x16E0C20 Offset: 0x16DF220 VA: 0x1816E0C20
	private void InitializeOverridableProperties(CultureData cultureData, int calendarID) { }

	[OnDeserializedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x16E14B0 Offset: 0x16DFAB0 VA: 0x1816E14B0
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x16E1C90 Offset: 0x16E0290 VA: 0x1816E1C90
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x16E4020 Offset: 0x16E2620 VA: 0x1816E4020
	public static DateTimeFormatInfo get_InvariantInfo() { }

	// RVA: 0x16E3160 Offset: 0x16E1760 VA: 0x1816E3160
	public static DateTimeFormatInfo get_CurrentInfo() { }

	// RVA: 0x16E0340 Offset: 0x16DE940 VA: 0x1816E0340
	public static DateTimeFormatInfo GetInstance(IFormatProvider provider) { }

	// RVA: 0x16E02B0 Offset: 0x16DE8B0 VA: 0x1816E02B0 Slot: 5
	public object GetFormat(Type formatType) { }

	// RVA: 0x16DE0D0 Offset: 0x16DC6D0 VA: 0x1816DE0D0 Slot: 4
	public object Clone() { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public string get_AMDesignator() { }

	// RVA: 0x4E84B0 Offset: 0x4E6AB0 VA: 0x1804E84B0
	public Calendar get_Calendar() { }

	// RVA: 0x16E4EF0 Offset: 0x16E34F0 VA: 0x1816E4EF0
	public void set_Calendar(Calendar value) { }

	// RVA: 0x16E4570 Offset: 0x16E2B70 VA: 0x1816E4570
	private int[] get_OptionalCalendars() { }

	// RVA: 0x16E3570 Offset: 0x16E1B70 VA: 0x1816E3570
	internal string[] get_EraNames() { }

	// RVA: 0x16E0150 Offset: 0x16DE750 VA: 0x1816E0150
	public string GetEraName(int era) { }

	// RVA: 0x16E2A50 Offset: 0x16E1050 VA: 0x1816E2A50
	internal string[] get_AbbreviatedEraNames() { }

	// RVA: 0x16DF690 Offset: 0x16DDC90 VA: 0x1816DF690
	public string GetAbbreviatedEraName(int era) { }

	// RVA: 0x16E29E0 Offset: 0x16E0FE0 VA: 0x1816E29E0
	internal string[] get_AbbreviatedEnglishEraNames() { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0
	public string get_DateSeparator() { }

	// RVA: 0x16E3AF0 Offset: 0x16E20F0 VA: 0x1816E3AF0
	public string get_FullDateTimePattern() { }

	// RVA: 0x16E42A0 Offset: 0x16E28A0 VA: 0x1816E42A0
	public string get_LongDatePattern() { }

	// RVA: 0x16E52F0 Offset: 0x16E38F0 VA: 0x1816E52F0
	public void set_LongDatePattern(string value) { }

	// RVA: 0x16E4300 Offset: 0x16E2900 VA: 0x1816E4300
	public string get_LongTimePattern() { }

	// RVA: 0x16E5400 Offset: 0x16E3A00 VA: 0x1816E5400
	public void set_LongTimePattern(string value) { }

	// RVA: 0x16E43A0 Offset: 0x16E29A0 VA: 0x1816E43A0
	public string get_MonthDayPattern() { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	public string get_PMDesignator() { }

	// RVA: 0x16E45C0 Offset: 0x16E2BC0 VA: 0x1816E45C0
	public string get_RFC1123Pattern() { }

	// RVA: 0x16E45F0 Offset: 0x16E2BF0 VA: 0x1816E45F0
	public string get_ShortDatePattern() { }

	// RVA: 0x16E5530 Offset: 0x16E3B30 VA: 0x1816E5530
	public void set_ShortDatePattern(string value) { }

	// RVA: 0x16E4650 Offset: 0x16E2C50 VA: 0x1816E4650
	public string get_ShortTimePattern() { }

	// RVA: 0x16E5660 Offset: 0x16E3C60 VA: 0x1816E5660
	public void set_ShortTimePattern(string value) { }

	// RVA: 0x16E46F0 Offset: 0x16E2CF0 VA: 0x1816E46F0
	public string get_SortableDateTimePattern() { }

	// RVA: 0x16E3EA0 Offset: 0x16E24A0 VA: 0x1816E3EA0
	internal string get_GeneralShortTimePattern() { }

	// RVA: 0x16E3DC0 Offset: 0x16E23C0 VA: 0x1816E3DC0
	internal string get_GeneralLongTimePattern() { }

	// RVA: 0x16E3260 Offset: 0x16E1860 VA: 0x1816E3260
	internal string get_DateTimeOffsetPattern() { }

	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0
	public string get_TimeSeparator() { }

	// RVA: 0x16E4910 Offset: 0x16E2F10 VA: 0x1816E4910
	public string get_UniversalSortableDateTimePattern() { }

	// RVA: 0x16E4940 Offset: 0x16E2F40 VA: 0x1816E4940
	public string get_YearMonthPattern() { }

	// RVA: 0x16E5770 Offset: 0x16E3D70 VA: 0x1816E5770
	public void set_YearMonthPattern(string value) { }

	// RVA: 0x16E2960 Offset: 0x16E0F60 VA: 0x1816E2960
	public string[] get_AbbreviatedDayNames() { }

	// RVA: 0x16E34F0 Offset: 0x16E1AF0 VA: 0x1816E34F0
	public string[] get_DayNames() { }

	// RVA: 0x16E2AC0 Offset: 0x16E10C0 VA: 0x1816E2AC0
	public string[] get_AbbreviatedMonthNames() { }

	// RVA: 0x16E44F0 Offset: 0x16E2AF0 VA: 0x1816E44F0
	public string[] get_MonthNames() { }

	// RVA: 0x16E3FE0 Offset: 0x16E25E0 VA: 0x1816E3FE0
	internal bool get_HasSpacesInMonthNames() { }

	// RVA: 0x16E3FC0 Offset: 0x16E25C0 VA: 0x1816E3FC0
	internal bool get_HasSpacesInDayNames() { }

	// RVA: 0x16E4C60 Offset: 0x16E3260 VA: 0x1816E4C60
	internal string internalGetMonthName(int month, MonthNameStyles style, bool abbreviated) { }

	// RVA: 0x16E4AF0 Offset: 0x16E30F0 VA: 0x1816E4AF0
	private string[] internalGetGenitiveMonthNames(bool abbreviated) { }

	// RVA: 0x16E4BE0 Offset: 0x16E31E0 VA: 0x1816E4BE0
	internal string[] internalGetLeapYearMonthNames() { }

	// RVA: 0x16DF540 Offset: 0x16DDB40 VA: 0x1816DF540
	public string GetAbbreviatedDayName(DayOfWeek dayofweek) { }

	// RVA: 0x16DFE90 Offset: 0x16DE490 VA: 0x1816DFE90
	private static string[] GetCombinedPatterns(string[] patterns1, string[] patterns2, string connectString) { }

	// RVA: 0x16DF970 Offset: 0x16DDF70 VA: 0x1816DF970
	public string[] GetAllDateTimePatterns(char format) { }

	// RVA: 0x16E0000 Offset: 0x16DE600 VA: 0x1816E0000
	public string GetDayName(DayOfWeek dayofweek) { }

	// RVA: 0x16DF810 Offset: 0x16DDE10 VA: 0x1816DF810
	public string GetAbbreviatedMonthName(int month) { }

	// RVA: 0x16E0980 Offset: 0x16DEF80 VA: 0x1816E0980
	public string GetMonthName(int month) { }

	// RVA: 0x16E0700 Offset: 0x16DED00 VA: 0x1816E0700
	private static string[] GetMergedPatterns(string[] patterns, string defaultPattern) { }

	// RVA: 0x16E2E80 Offset: 0x16E1480 VA: 0x1816E2E80
	private string[] get_AllYearMonthPatterns() { }

	// RVA: 0x16E2CE0 Offset: 0x16E12E0 VA: 0x1816E2CE0
	private string[] get_AllShortDatePatterns() { }

	// RVA: 0x16E2DC0 Offset: 0x16E13C0 VA: 0x1816E2DC0
	private string[] get_AllShortTimePatterns() { }

	// RVA: 0x16E2B40 Offset: 0x16E1140 VA: 0x1816E2B40
	private string[] get_AllLongDatePatterns() { }

	// RVA: 0x16E2C20 Offset: 0x16E1220 VA: 0x1816E2C20
	private string[] get_AllLongTimePatterns() { }

	// RVA: 0x16E48A0 Offset: 0x16E2EA0 VA: 0x1816E48A0
	private string[] get_UnclonedYearMonthPatterns() { }

	// RVA: 0x16E47E0 Offset: 0x16E2DE0 VA: 0x1816E47E0
	private string[] get_UnclonedShortDatePatterns() { }

	// RVA: 0x16E4720 Offset: 0x16E2D20 VA: 0x1816E4720
	private string[] get_UnclonedLongDatePatterns() { }

	// RVA: 0x16E4850 Offset: 0x16E2E50 VA: 0x1816E4850
	private string[] get_UnclonedShortTimePatterns() { }

	// RVA: 0x16E4790 Offset: 0x16E2D90 VA: 0x1816E4790
	private string[] get_UnclonedLongTimePatterns() { }

	// RVA: 0x16E4250 Offset: 0x16E2850 VA: 0x1816E4250
	public bool get_IsReadOnly() { }

	// RVA: 0x16E4410 Offset: 0x16E2A10 VA: 0x1816E4410
	public string[] get_MonthGenitiveNames() { }

	// RVA: 0x16E3D00 Offset: 0x16E2300 VA: 0x1816E3D00
	internal string get_FullTimeSpanPositivePattern() { }

	// RVA: 0x16E3BE0 Offset: 0x16E21E0 VA: 0x1816E3BE0
	internal string get_FullTimeSpanNegativePattern() { }

	// RVA: 0x16E2F60 Offset: 0x16E1560 VA: 0x1816E2F60
	internal CompareInfo get_CompareInfo() { }

	// RVA: 0x16E2550 Offset: 0x16E0B50 VA: 0x1816E2550
	internal static void ValidateStyles(DateTimeStyles style, string parameterName) { }

	// RVA: 0x16E35E0 Offset: 0x16E1BE0 VA: 0x1816E35E0
	internal DateTimeFormatFlags get_FormatFlags() { }

	// RVA: 0x16E3F80 Offset: 0x16E2580 VA: 0x1816E3F80
	internal bool get_HasForceTwoDigitYears() { }

	// RVA: 0x16E4000 Offset: 0x16E2600 VA: 0x1816E4000
	internal bool get_HasYearMonthAdjustment() { }

	// RVA: 0x16E2670 Offset: 0x16E0C70 VA: 0x1816E2670
	internal bool YearMonthAdjustment(ref int year, ref int month, bool parsedMonthName) { }

	// RVA: 0x16E05C0 Offset: 0x16DEBC0 VA: 0x1816E05C0
	internal static DateTimeFormatInfo GetJapaneseCalendarDTFI() { }

	// RVA: 0x16E0AE0 Offset: 0x16DF0E0 VA: 0x1816E0AE0
	internal static DateTimeFormatInfo GetTaiwanCalendarDTFI() { }

	// RVA: 0x16DE0A0 Offset: 0x16DC6A0 VA: 0x1816DE0A0
	private void ClearTokenHashTable() { }

	// RVA: 0x16DE1D0 Offset: 0x16DC7D0 VA: 0x1816DE1D0
	internal TokenHashValue[] CreateTokenHashTable() { }

	// RVA: 0x16DDFD0 Offset: 0x16DC5D0 VA: 0x1816DDFD0
	private void AddMonthNames(TokenHashValue[] temp, string monthPostfix) { }

	// RVA: 0x16E2330 Offset: 0x16E0930 VA: 0x1816E2330
	private static bool TryParseHebrewNumber(ref __DTString str, out bool badFormat, out int number) { }

	// RVA: 0x16E1490 Offset: 0x16DFA90 VA: 0x1816E1490
	private static bool IsHebrewChar(char ch) { }

	// RVA: 0x16E1EE0 Offset: 0x16E04E0 VA: 0x1816E1EE0
	internal bool Tokenize(TokenType TokenMask, out TokenType tokenType, out int tokenValue, ref __DTString str) { }

	// RVA: 0x16E0E50 Offset: 0x16DF450 VA: 0x1816E0E50
	private void InsertAtCurrentHashNode(TokenHashValue[] hashTable, string str, char ch, TokenType tokenType, int tokenValue, int pos, int hashcode, int hashProbe) { }

	// RVA: 0x16E10A0 Offset: 0x16DF6A0 VA: 0x1816E10A0
	private void InsertHash(TokenHashValue[] hashTable, string str, TokenType tokenType, int tokenValue) { }

	// RVA: 0x16E2790 Offset: 0x16E0D90 VA: 0x1816E2790
	private static void .cctor() { }

}

internal class DateTimeFormatInfoScanner // TypeDefIndex: 699
{	// Fields
	internal List<string> m_dateWords; // 0x10
	private static Dictionary<string, string> s_knownWords; // 0x0
	private DateTimeFormatInfoScanner.FoundDatePattern m_ymdFlags; // 0x18

	// Properties
	private static Dictionary<string, string> KnownWords { get; }

	// Methods

	// RVA: 0x16DDCB0 Offset: 0x16DC2B0 VA: 0x1816DDCB0
	private static Dictionary<string, string> get_KnownWords() { }

	// RVA: 0x16DDB70 Offset: 0x16DC170 VA: 0x1816DDB70
	internal static int SkipWhiteSpacesAndNonLetter(string pattern, int currentIndex) { }

	// RVA: 0x16DC9D0 Offset: 0x16DAFD0 VA: 0x1816DC9D0
	internal void AddDateWordOrPostfix(string formatPostfix, string str) { }

	// RVA: 0x16DCBA0 Offset: 0x16DB1A0 VA: 0x1816DCBA0
	internal int AddDateWords(string pattern, int index, string formatPostfix) { }

	// RVA: 0x16DDB00 Offset: 0x16DC100 VA: 0x1816DDB00
	internal static int ScanRepeatChar(string pattern, char ch, int index, out int count) { }

	// RVA: 0x16DCDD0 Offset: 0x16DB3D0 VA: 0x1816DCDD0
	internal void AddIgnorableSymbols(string text) { }

	// RVA: 0x16DD8C0 Offset: 0x16DBEC0 VA: 0x1816DD8C0
	internal void ScanDateWord(string pattern) { }

	// RVA: 0x16DD2E0 Offset: 0x16DB8E0 VA: 0x1816DD2E0
	internal string[] GetDateWordsOfDTFI(DateTimeFormatInfo dtfi) { }

	// RVA: 0x16DD660 Offset: 0x16DBC60 VA: 0x1816DD660
	internal static FORMATFLAGS GetFormatFlagGenitiveMonth(string[] monthNames, string[] genitveMonthNames, string[] abbrevMonthNames, string[] genetiveAbbrevMonthNames) { }

	// RVA: 0x16DD800 Offset: 0x16DBE00 VA: 0x1816DD800
	internal static FORMATFLAGS GetFormatFlagUseSpaceInMonthNames(string[] monthNames, string[] genitveMonthNames, string[] abbrevMonthNames, string[] genetiveAbbrevMonthNames) { }

	// RVA: 0x16DD7C0 Offset: 0x16DBDC0 VA: 0x1816DD7C0
	internal static FORMATFLAGS GetFormatFlagUseSpaceInDayNames(string[] dayNames, string[] abbrevDayNames) { }

	// RVA: 0x16DD7B0 Offset: 0x16DBDB0 VA: 0x1816DD7B0
	internal static FORMATFLAGS GetFormatFlagUseHebrewCalendar(int calID) { }

	// RVA: 0x16DD220 Offset: 0x16DB820 VA: 0x1816DD220
	private static bool EqualStringArrays(string[] array1, string[] array2) { }

	// RVA: 0x16DD140 Offset: 0x16DB740 VA: 0x1816DD140
	private static bool ArrayElementsHaveSpace(string[] array) { }

	// RVA: 0x16DCEA0 Offset: 0x16DB4A0 VA: 0x1816DCEA0
	private static bool ArrayElementsBeginWithDigit(string[] array) { }

	// RVA: 0x16DDC40 Offset: 0x16DC240 VA: 0x1816DDC40
	public void .ctor() { }

}

private enum DateTimeFormatInfoScanner.FoundDatePattern // TypeDefIndex: 700
{	// Fields
	public int value__; // 0x0
	public const DateTimeFormatInfoScanner.FoundDatePattern None = 0;
	public const DateTimeFormatInfoScanner.FoundDatePattern FoundYearPatternFlag = 1;
	public const DateTimeFormatInfoScanner.FoundDatePattern FoundMonthPatternFlag = 2;
	public const DateTimeFormatInfoScanner.FoundDatePattern FoundDayPatternFlag = 4;
	public const DateTimeFormatInfoScanner.FoundDatePattern FoundYMDPatternFlag = 7;

}

public enum DateTimeStyles // TypeDefIndex: 701
{	// Fields
	public int value__; // 0x0
	public const DateTimeStyles None = 0;
	public const DateTimeStyles AllowLeadingWhite = 1;
	public const DateTimeStyles AllowTrailingWhite = 2;
	public const DateTimeStyles AllowInnerWhite = 4;
	public const DateTimeStyles AllowWhiteSpaces = 7;
	public const DateTimeStyles NoCurrentDateDefault = 8;
	public const DateTimeStyles AdjustToUniversal = 16;
	public const DateTimeStyles AssumeLocal = 32;
	public const DateTimeStyles AssumeUniversal = 64;
	public const DateTimeStyles RoundtripKind = 128;

}

public sealed class DateTimeConstantAttribute : CustomConstantAttribute // TypeDefIndex: 1303
{	// Fields
	private DateTime date; // 0x10

	// Properties
	public override object Value { get; }

	// Methods

	// RVA: 0xFE6A00 Offset: 0xFE5000 VA: 0x180FE6A00 Slot: 7
	public override object get_Value() { }

}

internal sealed class DateTimeTypeInfo : TraceLoggingTypeInfo<DateTime> // TypeDefIndex: 1571
{	// Methods

	// RVA: 0xD6A1C0 Offset: 0xD687C0 VA: 0x180D6A1C0 Slot: 4
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

	// RVA: 0xD6A170 Offset: 0xD68770 VA: 0x180D6A170 Slot: 7
	public override void WriteData(TraceLoggingDataCollector collector, ref DateTime value) { }

	// RVA: 0xD6A250 Offset: 0xD68850 VA: 0x180D6A250
	public void .ctor() { }

}

internal sealed class DateTimeOffsetTypeInfo : TraceLoggingTypeInfo<DateTimeOffset> // TypeDefIndex: 1572
{	// Methods

	// RVA: 0xD6A070 Offset: 0xD68670 VA: 0x180D6A070 Slot: 4
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

	// RVA: 0xD69FF0 Offset: 0xD685F0 VA: 0x180D69FF0 Slot: 7
	public override void WriteData(TraceLoggingDataCollector collector, ref DateTimeOffset value) { }

	// RVA: 0xD6A130 Offset: 0xD68730 VA: 0x180D6A130
	public void .ctor() { }

}

internal class DateTimeFacetsChecker : FacetsChecker // TypeDefIndex: 2251
{	// Methods

	// RVA: 0x15157D0 Offset: 0x1513DD0 VA: 0x1815157D0 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x15153A0 Offset: 0x15139A0 VA: 0x1815153A0 Slot: 10
	internal override Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1515990 Offset: 0x1513F90 VA: 0x181515990 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x1515850 Offset: 0x1513E50 VA: 0x181515850
	private bool MatchEnumeration(DateTime value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

internal sealed class DateTimeOffsetStorage : DataStorage // TypeDefIndex: 4384
{
// Namespace: System.Data.Common
internal sealed class DateTimeOffsetStorage : DataStorage // TypeDefIndex: 4384
	// Fields
	private static readonly DateTimeOffset s_defaultValue; // 0x0
	private DateTimeOffset[] _values; // 0x50

	// Methods

	// RVA: 0x1279F60 Offset: 0x1278560 VA: 0x181279F60
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1278E60 Offset: 0x1277460 VA: 0x181278E60 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x12794F0 Offset: 0x1277AF0 VA: 0x1812794F0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1279330 Offset: 0x1277930 VA: 0x181279330 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1279790 Offset: 0x1277D90 VA: 0x181279790 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x12799F0 Offset: 0x1277FF0 VA: 0x1812799F0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1279AE0 Offset: 0x12780E0 VA: 0x181279AE0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1279DB0 Offset: 0x12783B0 VA: 0x181279DB0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1279C30 Offset: 0x1278230 VA: 0x181279C30 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1279820 Offset: 0x1277E20 VA: 0x181279820 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1279700 Offset: 0x1277D00 VA: 0x181279700 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1279AA0 Offset: 0x12780A0 VA: 0x181279AA0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x12798A0 Offset: 0x1277EA0 VA: 0x1812798A0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1279D10 Offset: 0x1278310 VA: 0x181279D10 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x1279EF0 Offset: 0x12784F0 VA: 0x181279EF0
	private static void .cctor() { }

}

internal sealed class DateTimeStorage : DataStorage // TypeDefIndex: 4385
{	// Fields
	private static readonly DateTime s_defaultValue; // 0x0
	private DateTime[] _values; // 0x50

	// Methods

	// RVA: 0x127B4E0 Offset: 0x1279AE0 VA: 0x18127B4E0
	internal void .ctor(DataColumn column) { }

	// RVA: 0x127A070 Offset: 0x1278670 VA: 0x18127A070 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x127A6A0 Offset: 0x1278CA0 VA: 0x18127A6A0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x127A510 Offset: 0x1278B10 VA: 0x18127A510 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x127A940 Offset: 0x1278F40 VA: 0x18127A940 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x127AC60 Offset: 0x1279260 VA: 0x18127AC60 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x127AD40 Offset: 0x1279340 VA: 0x18127AD40 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x127B190 Offset: 0x1279790 VA: 0x18127B190 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x127AE60 Offset: 0x1279460 VA: 0x18127AE60 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x127AA20 Offset: 0x1279020 VA: 0x18127AA20 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x127A850 Offset: 0x1278E50 VA: 0x18127A850 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x127AD00 Offset: 0x1279300 VA: 0x18127AD00 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x127AAD0 Offset: 0x12790D0 VA: 0x18127AAD0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x127AF40 Offset: 0x1279540 VA: 0x18127AF40 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x127B470 Offset: 0x1279A70 VA: 0x18127B470
	private static void .cctor() { }

}

public enum DateTimeZoneHandling // TypeDefIndex: 5867
{	// Fields
	public int value__; // 0x0
	public const DateTimeZoneHandling Local = 0;
	public const DateTimeZoneHandling Utc = 1;
	public const DateTimeZoneHandling Unspecified = 2;
	public const DateTimeZoneHandling RoundtripKind = 3;

}

internal struct DateTimeParser // TypeDefIndex: 5916
{	// Fields
	public int Year; // 0x0
	public int Month; // 0x4
	public int Day; // 0x8
	public int Hour; // 0xC
	public int Minute; // 0x10
	public int Second; // 0x14
	public int Fraction; // 0x18
	public int ZoneHour; // 0x1C
	public int ZoneMinute; // 0x20
	public ParserTimeZone Zone; // 0x24
	private char[] _text; // 0x28
	private int _end; // 0x30
	private static readonly int[] Power10; // 0x0
	private static readonly int Lzyyyy; // 0x8
	private static readonly int Lzyyyy_; // 0xC
	private static readonly int Lzyyyy_MM; // 0x10
	private static readonly int Lzyyyy_MM_; // 0x14
	private static readonly int Lzyyyy_MM_dd; // 0x18
	private static readonly int Lzyyyy_MM_ddT; // 0x1C
	private static readonly int LzHH; // 0x20
	private static readonly int LzHH_; // 0x24
	private static readonly int LzHH_mm; // 0x28
	private static readonly int LzHH_mm_; // 0x2C
	private static readonly int LzHH_mm_ss; // 0x30
	private static readonly int Lz_; // 0x34
	private static readonly int Lz_zz; // 0x38

	// Methods

	// RVA: 0x17F0380 Offset: 0x17EE980 VA: 0x1817F0380
	private static void .cctor() { }

	// RVA: 0x2106C0 Offset: 0x20FAC0 VA: 0x1802106C0
	public bool Parse(char[] text, int startIndex, int length) { }

	// RVA: 0x210650 Offset: 0x20FA50 VA: 0x180210650
	private bool ParseDate(int start) { }

	// RVA: 0x210660 Offset: 0x20FA60 VA: 0x180210660
	private bool ParseTimeAndZoneAndWhitespace(int start) { }

	// RVA: 0x2106A0 Offset: 0x20FAA0 VA: 0x1802106A0
	private bool ParseTime(ref int start) { }

	// RVA: 0x2106B0 Offset: 0x20FAB0 VA: 0x1802106B0
	private bool ParseZone(int start) { }

	// RVA: 0x2105F0 Offset: 0x20F9F0 VA: 0x1802105F0
	private bool Parse4Digit(int start, out int num) { }

	// RVA: 0x2105E0 Offset: 0x20F9E0 VA: 0x1802105E0
	private bool Parse2Digit(int start, out int num) { }

	// RVA: 0x210600 Offset: 0x20FA00 VA: 0x180210600
	private bool ParseChar(int start, char ch) { }

}

internal static class DateTimeUtils // TypeDefIndex: 5949
{	// Fields
	internal static readonly long InitialJavaScriptDateTicks; // 0x0
	private static readonly int[] DaysToMonth365; // 0x8
	private static readonly int[] DaysToMonth366; // 0x10

	// Methods

	// RVA: 0x17F3B70 Offset: 0x17F2170 VA: 0x1817F3B70
	private static void .cctor() { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x17F0E50 Offset: 0x17EF450 VA: 0x1817F0E50
	public static TimeSpan GetUtcOffset(DateTime d) { }

	// RVA: 0x17F0EC0 Offset: 0x17EF4C0 VA: 0x1817F0EC0
	public static XmlDateTimeSerializationMode ToSerializationMode(DateTimeKind kind) { }

	// RVA: 0x17F0A90 Offset: 0x17EF090 VA: 0x1817F0A90
	internal static DateTime EnsureDateTime(DateTime value, DateTimeZoneHandling timeZone) { }

	// RVA: 0xE5D6B0 Offset: 0xE5BCB0 VA: 0x180E5D6B0
	private static DateTime SwitchToLocalTime(DateTime value) { }

	// RVA: 0xE5D720 Offset: 0xE5BD20 VA: 0x180E5D720
	private static DateTime SwitchToUtcTime(DateTime value) { }

	// RVA: 0x17F1070 Offset: 0x17EF670 VA: 0x1817F1070
	private static long ToUniversalTicks(DateTime dateTime) { }

	// RVA: 0x17F0F50 Offset: 0x17EF550 VA: 0x1817F0F50
	private static long ToUniversalTicks(DateTime dateTime, TimeSpan offset) { }

	// RVA: 0x17F05B0 Offset: 0x17EEBB0 VA: 0x1817F05B0
	internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, TimeSpan offset) { }

	// RVA: 0x17F0620 Offset: 0x17EEC20 VA: 0x1817F0620
	internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime) { }

	// RVA: 0x17F0760 Offset: 0x17EED60 VA: 0x1817F0760
	internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, bool convertToUtc) { }

	// RVA: 0x17F2CA0 Offset: 0x17F12A0 VA: 0x1817F2CA0
	private static long UniversialTicksToJavaScriptTicks(long universialTicks) { }

	// RVA: 0x17F0880 Offset: 0x17EEE80 VA: 0x1817F0880
	internal static DateTime ConvertJavaScriptTicksToDateTime(long javaScriptTicks) { }

	// RVA: 0x17F11F0 Offset: 0x17EF7F0 VA: 0x1817F11F0
	internal static bool TryParseDateTimeIso(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt) { }

	// RVA: 0x17F1870 Offset: 0x17EFE70 VA: 0x1817F1870
	internal static bool TryParseDateTimeOffsetIso(StringReference text, out DateTimeOffset dt) { }

	// RVA: 0x17F0990 Offset: 0x17EEF90 VA: 0x1817F0990
	private static DateTime CreateDateTime(DateTimeParser dateTimeParser) { }

	// RVA: 0x17F2460 Offset: 0x17F0A60 VA: 0x1817F2460
	internal static bool TryParseDateTime(StringReference s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) { }

	// RVA: 0x17F21A0 Offset: 0x17F07A0 VA: 0x1817F21A0
	internal static bool TryParseDateTime(string s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) { }

	// RVA: 0x17F1B80 Offset: 0x17F0180 VA: 0x1817F1B80
	internal static bool TryParseDateTimeOffset(StringReference s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) { }

	// RVA: 0x17F1EC0 Offset: 0x17F04C0 VA: 0x1817F1EC0
	internal static bool TryParseDateTimeOffset(string s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) { }

	// RVA: 0x17F27C0 Offset: 0x17F0DC0 VA: 0x1817F27C0
	private static bool TryParseMicrosoftDate(StringReference text, out long ticks, out TimeSpan offset, out DateTimeKind kind) { }

	// RVA: 0x17F1640 Offset: 0x17EFC40 VA: 0x1817F1640
	private static bool TryParseDateTimeMicrosoft(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt) { }

	// RVA: 0x17F1100 Offset: 0x17EF700 VA: 0x1817F1100
	private static bool TryParseDateTimeExact(string text, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) { }

	// RVA: 0x17F1A20 Offset: 0x17F0020 VA: 0x1817F1A20
	private static bool TryParseDateTimeOffsetMicrosoft(StringReference text, out DateTimeOffset dt) { }

	// RVA: 0x17F17B0 Offset: 0x17EFDB0 VA: 0x1817F17B0
	private static bool TryParseDateTimeOffsetExact(string text, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) { }

	// RVA: 0x17F2B10 Offset: 0x17F1110 VA: 0x1817F2B10
	private static bool TryReadOffset(StringReference offsetText, int startIndex, out TimeSpan offset) { }

	// RVA: 0x17F30D0 Offset: 0x17F16D0 VA: 0x1817F30D0
	internal static void WriteDateTimeString(TextWriter writer, DateTime value, DateFormatHandling format, string formatString, CultureInfo culture) { }

	// RVA: 0x17F3240 Offset: 0x17F1840 VA: 0x1817F3240
	internal static int WriteDateTimeString(char[] chars, int start, DateTime value, Nullable<TimeSpan> offset, DateTimeKind kind, DateFormatHandling format) { }

	// RVA: 0x17F3610 Offset: 0x17F1C10 VA: 0x1817F3610
	internal static int WriteDefaultIsoDate(char[] chars, int start, DateTime dt) { }

	// RVA: 0x17F0910 Offset: 0x17EEF10 VA: 0x1817F0910
	private static void CopyIntToCharArray(char[] chars, int start, int value, int digits) { }

	// RVA: 0x17F2EA0 Offset: 0x17F14A0 VA: 0x1817F2EA0
	internal static int WriteDateTimeOffset(char[] chars, int start, TimeSpan offset, DateFormatHandling format) { }

	// RVA: 0x17F2D20 Offset: 0x17F1320 VA: 0x1817F2D20
	internal static void WriteDateTimeOffsetString(TextWriter writer, DateTimeOffset value, DateFormatHandling format, string formatString, CultureInfo culture) { }

	// RVA: 0x17F0C60 Offset: 0x17EF260 VA: 0x1817F0C60
	private static void GetDateValues(DateTime td, out int year, out int month, out int day) { }

}

public abstract class DateTimeConverterBase : JsonConverter // TypeDefIndex: 6101
{	// Methods

	// RVA: 0xF89490 Offset: 0xF87A90 VA: 0x180F89490 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

