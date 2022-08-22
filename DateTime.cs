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

	// RVA: 0x20CC10 Offset: 0x20C010 VA: 0x18020CC10
	public void .ctor(long ticks) { }

	// RVA: 0x1D2EB0 Offset: 0x1D22B0 VA: 0x1801D2EB0
	private void .ctor(ulong dateData) { }

	// RVA: 0x20CC20 Offset: 0x20C020 VA: 0x18020CC20
	public void .ctor(long ticks, DateTimeKind kind) { }

	// RVA: 0x20CED0 Offset: 0x20C2D0 VA: 0x18020CED0
	internal void .ctor(long ticks, DateTimeKind kind, bool isAmbiguousDst) { }

	// RVA: 0x20CFF0 Offset: 0x20C3F0 VA: 0x18020CFF0
	public void .ctor(int year, int month, int day) { }

	// RVA: 0x20CC50 Offset: 0x20C050 VA: 0x18020CC50
	public void .ctor(int year, int month, int day, int hour, int minute, int second) { }

	// RVA: 0x20CEE0 Offset: 0x20C2E0 VA: 0x18020CEE0
	public void .ctor(int year, int month, int day, int hour, int minute, int second, DateTimeKind kind) { }

	// RVA: 0x20CCF0 Offset: 0x20C0F0 VA: 0x18020CCF0
	public void .ctor(int year, int month, int day, int hour, int minute, int second, int millisecond) { }

	// RVA: 0x20CFE0 Offset: 0x20C3E0 VA: 0x18020CFE0
	public void .ctor(int year, int month, int day, int hour, int minute, int second, int millisecond, DateTimeKind kind) { }

	// RVA: 0x20CC30 Offset: 0x20C030 VA: 0x18020CC30
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x20D180 Offset: 0x20C580 VA: 0x18020D180
	internal long get_InternalTicks() { }

	// RVA: 0x20D160 Offset: 0x20C560 VA: 0x18020D160
	private ulong get_InternalKind() { }

	// RVA: 0x20C050 Offset: 0x20B450 VA: 0x18020C050
	public DateTime Add(TimeSpan value) { }

	// RVA: 0x20C060 Offset: 0x20B460 VA: 0x18020C060
	private DateTime Add(double value, int scale) { }

	// RVA: 0x20BF20 Offset: 0x20B320 VA: 0x18020BF20
	public DateTime AddDays(double value) { }

	// RVA: 0x20BF40 Offset: 0x20B340 VA: 0x18020BF40
	public DateTime AddHours(double value) { }

	// RVA: 0x20BF60 Offset: 0x20B360 VA: 0x18020BF60
	public DateTime AddMilliseconds(double value) { }

	// RVA: 0x20BF70 Offset: 0x20B370 VA: 0x18020BF70
	public DateTime AddMonths(int months) { }

	// RVA: 0x20BF80 Offset: 0x20B380 VA: 0x18020BF80
	public DateTime AddSeconds(double value) { }

	// RVA: 0x20BFA0 Offset: 0x20B3A0 VA: 0x18020BFA0
	public DateTime AddTicks(long value) { }

	// RVA: 0x20BFB0 Offset: 0x20B3B0 VA: 0x18020BFB0
	public DateTime AddYears(int value) { }

	// RVA: 0x17A40A0 Offset: 0x17A26A0 VA: 0x1817A40A0
	public static int Compare(DateTime t1, DateTime t2) { }

	// RVA: 0x20C0A0 Offset: 0x20B4A0 VA: 0x18020C0A0 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x20C070 Offset: 0x20B470 VA: 0x18020C070 Slot: 24
	public int CompareTo(DateTime value) { }

	// RVA: 0x17A40C0 Offset: 0x17A26C0 VA: 0x1817A40C0
	private static long DateToTicks(int year, int month, int day) { }

	// RVA: 0x17A6070 Offset: 0x17A4670 VA: 0x1817A6070
	private static long TimeToTicks(int hour, int minute, int second) { }

	// RVA: 0x17A42B0 Offset: 0x17A28B0 VA: 0x1817A42B0
	public static int DaysInMonth(int year, int month) { }

	// RVA: 0x17A4410 Offset: 0x17A2A10 VA: 0x1817A4410
	internal static long DoubleDateToTicks(double value) { }

	// RVA: 0x20C1A0 Offset: 0x20B5A0 VA: 0x18020C1A0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x20C180 Offset: 0x20B580 VA: 0x18020C180 Slot: 25
	public bool Equals(DateTime value) { }

	// RVA: 0x17A46E0 Offset: 0x17A2CE0 VA: 0x1817A46E0
	public static DateTime FromBinary(long dateData) { }

	// RVA: 0x17A4640 Offset: 0x17A2C40 VA: 0x1817A4640
	internal static DateTime FromBinaryRaw(long dateData) { }

	// RVA: 0x17A4A10 Offset: 0x17A3010 VA: 0x1817A4A10
	public static DateTime FromFileTime(long fileTime) { }

	// RVA: 0x17A4950 Offset: 0x17A2F50 VA: 0x1817A4950
	public static DateTime FromFileTimeUtc(long fileTime) { }

	// RVA: 0x17A4B10 Offset: 0x17A3110 VA: 0x1817A4B10
	public static DateTime FromOADate(double d) { }

	// RVA: 0x20C400 Offset: 0x20B800 VA: 0x18020C400 Slot: 23
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17A5450 Offset: 0x17A3A50 VA: 0x1817A5450
	public static DateTime SpecifyKind(DateTime value, DateTimeKind kind) { }

	// RVA: 0x20C4B0 Offset: 0x20B8B0 VA: 0x18020C4B0
	public long ToBinary() { }

	// RVA: 0xFC840 Offset: 0xFBC40 VA: 0x1800FC840
	internal long ToBinaryRaw() { }

	// RVA: 0x20D070 Offset: 0x20C470 VA: 0x18020D070
	public DateTime get_Date() { }

	// RVA: 0x20C230 Offset: 0x20B630 VA: 0x18020C230
	private int GetDatePart(int part) { }

	// RVA: 0x20D100 Offset: 0x20C500 VA: 0x18020D100
	public int get_Day() { }

	// RVA: 0x20D0B0 Offset: 0x20C4B0 VA: 0x18020D0B0
	public DayOfWeek get_DayOfWeek() { }

	// RVA: 0x20C240 Offset: 0x20B640 VA: 0x18020C240 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20D110 Offset: 0x20C510 VA: 0x18020D110
	public int get_Hour() { }

	// RVA: 0x20D1A0 Offset: 0x20C5A0 VA: 0x18020D1A0
	public DateTimeKind get_Kind() { }

	// RVA: 0x20D1D0 Offset: 0x20C5D0 VA: 0x18020D1D0
	public int get_Millisecond() { }

	// RVA: 0x20D220 Offset: 0x20C620 VA: 0x18020D220
	public int get_Minute() { }

	// RVA: 0x20D270 Offset: 0x20C670 VA: 0x18020D270
	public int get_Month() { }

	// RVA: 0x17A7D60 Offset: 0x17A6360 VA: 0x1817A7D60
	public static DateTime get_Now() { }

	// RVA: 0x17A7FE0 Offset: 0x17A65E0 VA: 0x1817A7FE0
	public static DateTime get_UtcNow() { }

	// RVA: 0x17A4EF0 Offset: 0x17A34F0 VA: 0x1817A4EF0
	internal static long GetSystemTimeAsFileTime() { }

	// RVA: 0x20D280 Offset: 0x20C680 VA: 0x18020D280
	public int get_Second() { }

	// RVA: 0x20D180 Offset: 0x20C580 VA: 0x18020D180
	public long get_Ticks() { }

	// RVA: 0x20D2D0 Offset: 0x20C6D0 VA: 0x18020D2D0
	public TimeSpan get_TimeOfDay() { }

	// RVA: 0x20D300 Offset: 0x20C700 VA: 0x18020D300
	public int get_Year() { }

	// RVA: 0x17A4F00 Offset: 0x17A3500 VA: 0x1817A4F00
	public static bool IsLeapYear(int year) { }

	// RVA: 0x17A53C0 Offset: 0x17A39C0 VA: 0x1817A53C0
	public static DateTime Parse(string s, IFormatProvider provider) { }

	// RVA: 0x17A5310 Offset: 0x17A3910 VA: 0x1817A5310
	public static DateTime Parse(string s, IFormatProvider provider, DateTimeStyles styles) { }

	// RVA: 0x17A4FE0 Offset: 0x17A35E0 VA: 0x1817A4FE0
	public static DateTime ParseExact(string s, string format, IFormatProvider provider) { }

	// RVA: 0x17A5240 Offset: 0x17A3840 VA: 0x1817A5240
	public static DateTime ParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style) { }

	// RVA: 0x17A5090 Offset: 0x17A3690 VA: 0x1817A5090
	public static DateTime ParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style) { }

	// RVA: 0x20C270 Offset: 0x20B670 VA: 0x18020C270
	public TimeSpan Subtract(DateTime value) { }

	// RVA: 0x17A5F40 Offset: 0x17A4540 VA: 0x1817A5F40
	private static double TicksToOADate(long value) { }

	// RVA: 0x20C6D0 Offset: 0x20BAD0 VA: 0x18020C6D0
	public double ToOADate() { }

	// RVA: 0x20C550 Offset: 0x20B950 VA: 0x18020C550
	public long ToFileTime() { }

	// RVA: 0x20C540 Offset: 0x20B940 VA: 0x18020C540
	public long ToFileTimeUtc() { }

	// RVA: 0x20C610 Offset: 0x20BA10 VA: 0x18020C610
	public DateTime ToLocalTime() { }

	// RVA: 0x20C620 Offset: 0x20BA20 VA: 0x18020C620
	internal DateTime ToLocalTime(bool throwOnOverflow) { }

	// RVA: 0x20C630 Offset: 0x20BA30 VA: 0x18020C630
	public string ToLongTimeString() { }

	// RVA: 0x20C850 Offset: 0x20BC50 VA: 0x18020C850
	public string ToShortDateString() { }

	// RVA: 0x20C8F0 Offset: 0x20BCF0 VA: 0x18020C8F0
	public string ToShortTimeString() { }

	// RVA: 0x20CB70 Offset: 0x20BF70 VA: 0x18020CB70 Slot: 3
	public override string ToString() { }

	// RVA: 0x20C990 Offset: 0x20BD90 VA: 0x18020C990
	public string ToString(string format) { }

	// RVA: 0x20CA30 Offset: 0x20BE30 VA: 0x18020CA30 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x20CAD0 Offset: 0x20BED0 VA: 0x18020CAD0 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x20CC00 Offset: 0x20C000 VA: 0x18020CC00
	public DateTime ToUniversalTime() { }

	// RVA: 0x17A6DA0 Offset: 0x17A53A0 VA: 0x1817A6DA0
	public static bool TryParse(string s, IFormatProvider provider, DateTimeStyles styles, out DateTime result) { }

	// RVA: 0x17A6CD0 Offset: 0x17A52D0 VA: 0x1817A6CD0
	public static bool TryParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style, out DateTime result) { }

	// RVA: 0x17A8060 Offset: 0x17A6660 VA: 0x1817A8060
	public static DateTime op_Addition(DateTime d, TimeSpan t) { }

	// RVA: 0x17A81E0 Offset: 0x17A67E0 VA: 0x1817A81E0
	public static DateTime op_Subtraction(DateTime d, TimeSpan t) { }

	// RVA: 0x17A82A0 Offset: 0x17A68A0 VA: 0x1817A82A0
	public static TimeSpan op_Subtraction(DateTime d1, DateTime d2) { }

	// RVA: 0x17A8120 Offset: 0x17A6720 VA: 0x1817A8120
	public static bool op_Equality(DateTime d1, DateTime d2) { }

	// RVA: 0x17A8180 Offset: 0x17A6780 VA: 0x1817A8180
	public static bool op_Inequality(DateTime d1, DateTime d2) { }

	// RVA: 0x17A81C0 Offset: 0x17A67C0 VA: 0x1817A81C0
	public static bool op_LessThan(DateTime t1, DateTime t2) { }

	// RVA: 0x17A81A0 Offset: 0x17A67A0 VA: 0x1817A81A0
	public static bool op_LessThanOrEqual(DateTime t1, DateTime t2) { }

	// RVA: 0x17A8160 Offset: 0x17A6760 VA: 0x1817A8160
	public static bool op_GreaterThan(DateTime t1, DateTime t2) { }

	// RVA: 0x17A8140 Offset: 0x17A6740 VA: 0x1817A8140
	public static bool op_GreaterThanOrEqual(DateTime t1, DateTime t2) { }

	// RVA: 0x20C260 Offset: 0x20B660 VA: 0x18020C260 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x20C290 Offset: 0x20B690 VA: 0x18020C290 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x20C2B0 Offset: 0x20B6B0 VA: 0x18020C2B0 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x20C320 Offset: 0x20B720 VA: 0x18020C320 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x20C2A0 Offset: 0x20B6A0 VA: 0x18020C2A0 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x20C2F0 Offset: 0x20B6F0 VA: 0x18020C2F0 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x20C3D0 Offset: 0x20B7D0 VA: 0x18020C3D0 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x20C300 Offset: 0x20B700 VA: 0x18020C300 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x20C3E0 Offset: 0x20B7E0 VA: 0x18020C3E0 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x20C310 Offset: 0x20B710 VA: 0x18020C310 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x20C3F0 Offset: 0x20B7F0 VA: 0x18020C3F0 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x20C330 Offset: 0x20B730 VA: 0x18020C330 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x20C2E0 Offset: 0x20B6E0 VA: 0x18020C2E0 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x20C2C0 Offset: 0x20B6C0 VA: 0x18020C2C0 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0xFC840 Offset: 0xFBC40 VA: 0x1800FC840 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x20C340 Offset: 0x20B740 VA: 0x18020C340 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x17A6A80 Offset: 0x17A5080 VA: 0x1817A6A80
	internal static bool TryCreate(int year, int month, int day, int hour, int minute, int second, int millisecond, out DateTime result) { }

	// RVA: 0x17A6F40 Offset: 0x17A5540 VA: 0x1817A6F40
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

	// RVA: 0x20B930 Offset: 0x20AD30 VA: 0x18020B930
	public void .ctor(long ticks, TimeSpan offset) { }

	// RVA: 0x20BAB0 Offset: 0x20AEB0 VA: 0x18020BAB0
	public void .ctor(DateTime dateTime) { }

	// RVA: 0x20BAA0 Offset: 0x20AEA0 VA: 0x18020BAA0
	public void .ctor(DateTime dateTime, TimeSpan offset) { }

	// RVA: 0x1797A70 Offset: 0x1796070 VA: 0x181797A70
	public static DateTimeOffset get_Now() { }

	// RVA: 0x1797C10 Offset: 0x1796210 VA: 0x181797C10
	public static DateTimeOffset get_UtcNow() { }

	// RVA: 0x20BAD0 Offset: 0x20AED0 VA: 0x18020BAD0
	public DateTime get_DateTime() { }

	// RVA: 0x20BCF0 Offset: 0x20B0F0 VA: 0x18020BCF0
	public DateTime get_UtcDateTime() { }

	// RVA: 0x20BB70 Offset: 0x20AF70 VA: 0x18020BB70
	public DateTime get_LocalDateTime() { }

	// RVA: 0x20BAC0 Offset: 0x20AEC0 VA: 0x18020BAC0
	private DateTime get_ClockDateTime() { }

	// RVA: 0x20BAE0 Offset: 0x20AEE0 VA: 0x18020BAE0
	public int get_Day() { }

	// RVA: 0x20BB10 Offset: 0x20AF10 VA: 0x18020BB10
	public int get_Hour() { }

	// RVA: 0x20BBA0 Offset: 0x20AFA0 VA: 0x18020BBA0
	public int get_Minute() { }

	// RVA: 0x20BC00 Offset: 0x20B000 VA: 0x18020BC00
	public int get_Month() { }

	// RVA: 0x20BC30 Offset: 0x20B030 VA: 0x18020BC30
	public TimeSpan get_Offset() { }

	// RVA: 0x20BC60 Offset: 0x20B060 VA: 0x18020BC60
	public int get_Second() { }

	// RVA: 0x20BCC0 Offset: 0x20B0C0 VA: 0x18020BCC0
	public long get_Ticks() { }

	// RVA: 0x20BD00 Offset: 0x20B100 VA: 0x18020BD00
	public int get_Year() { }

	// RVA: 0x1795D80 Offset: 0x1794380 VA: 0x181795D80
	public static int Compare(DateTimeOffset first, DateTimeOffset second) { }

	// RVA: 0x20B330 Offset: 0x20A730 VA: 0x18020B330 Slot: 4
	private int System.IComparable.CompareTo(object obj) { }

	// RVA: 0x20B020 Offset: 0x20A420 VA: 0x18020B020 Slot: 8
	public int CompareTo(DateTimeOffset other) { }

	// RVA: 0x20B1E0 Offset: 0x20A5E0 VA: 0x18020B1E0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x20B140 Offset: 0x20A540 VA: 0x18020B140 Slot: 9
	public bool Equals(DateTimeOffset other) { }

	// RVA: 0x20B4F0 Offset: 0x20A8F0 VA: 0x18020B4F0 Slot: 7
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x20B500 Offset: 0x20A900 VA: 0x18020B500 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x20B940 Offset: 0x20AD40 VA: 0x18020B940
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x20B300 Offset: 0x20A700 VA: 0x18020B300 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x17960D0 Offset: 0x17946D0 VA: 0x1817960D0
	public static DateTimeOffset Parse(string input, IFormatProvider formatProvider) { }

	// RVA: 0x1796310 Offset: 0x1794910 VA: 0x181796310
	public static DateTimeOffset Parse(string input, IFormatProvider formatProvider, DateTimeStyles styles) { }

	// RVA: 0x1795FB0 Offset: 0x17945B0 VA: 0x181795FB0
	public static DateTimeOffset ParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles) { }

	// RVA: 0x20B8E0 Offset: 0x20ACE0 VA: 0x18020B8E0
	public long ToUnixTimeSeconds() { }

	// RVA: 0x20B890 Offset: 0x20AC90 VA: 0x18020B890
	public long ToUnixTimeMilliseconds() { }

	// RVA: 0x20B680 Offset: 0x20AA80 VA: 0x18020B680 Slot: 3
	public override string ToString() { }

	// RVA: 0x20B5A0 Offset: 0x20A9A0 VA: 0x18020B5A0
	public string ToString(IFormatProvider formatProvider) { }

	// RVA: 0x20B760 Offset: 0x20AB60 VA: 0x18020B760 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x20B850 Offset: 0x20AC50 VA: 0x18020B850
	public DateTimeOffset ToUniversalTime() { }

	// RVA: 0x1796D70 Offset: 0x1795370 VA: 0x181796D70
	public static bool TryParse(string input, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result) { }

	// RVA: 0x17969C0 Offset: 0x1794FC0 VA: 0x1817969C0
	public static bool TryParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result) { }

	// RVA: 0x1796B10 Offset: 0x1795110 VA: 0x181796B10
	public static bool TryParseExact(string input, string[] formats, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result) { }

	// RVA: 0x1797080 Offset: 0x1795680 VA: 0x181797080
	private static short ValidateOffset(TimeSpan offset) { }

	// RVA: 0x1796FC0 Offset: 0x17955C0 VA: 0x181796FC0
	private static DateTime ValidateDate(DateTime dateTime, TimeSpan offset) { }

	// RVA: 0x1797190 Offset: 0x1795790 VA: 0x181797190
	private static DateTimeStyles ValidateStyles(DateTimeStyles style, string parameterName) { }

	// RVA: 0x1797D90 Offset: 0x1796390 VA: 0x181797D90
	public static DateTimeOffset op_Implicit(DateTime dateTime) { }

	// RVA: 0x1797E40 Offset: 0x1796440 VA: 0x181797E40
	public static TimeSpan op_Subtraction(DateTimeOffset left, DateTimeOffset right) { }

	// RVA: 0x1797D00 Offset: 0x1796300 VA: 0x181797D00
	public static bool op_Equality(DateTimeOffset left, DateTimeOffset right) { }

	// RVA: 0x1797DB0 Offset: 0x17963B0 VA: 0x181797DB0
	public static bool op_Inequality(DateTimeOffset left, DateTimeOffset right) { }

	// RVA: 0x17972C0 Offset: 0x17958C0 VA: 0x1817972C0
	private static void .cctor() { }

}

internal static class DateTimeFormat // TypeDefIndex: 225
{	// Fields
	internal static readonly TimeSpan NullOffset; // 0x0
	internal static char[] allStandardFormats; // 0x8
	internal static string[] fixedNumberFormats; // 0x10

	// Methods

	// RVA: 0x1794C90 Offset: 0x1793290 VA: 0x181794C90
	internal static void FormatDigits(StringBuilder outputBuffer, int value, int len) { }

	// RVA: 0x1794D10 Offset: 0x1793310 VA: 0x181794D10
	internal static void FormatDigits(StringBuilder outputBuffer, int value, int len, bool overrideLengthLimit) { }

	// RVA: 0x1795520 Offset: 0x1793B20 VA: 0x181795520
	private static void HebrewFormatDigits(StringBuilder outputBuffer, int digits) { }

	// RVA: 0x1795890 Offset: 0x1793E90 VA: 0x181795890
	internal static int ParseRepeatPattern(string format, int pos, char patternChar) { }

	// RVA: 0x1794C50 Offset: 0x1793250 VA: 0x181794C50
	private static string FormatDayOfWeek(int dayOfWeek, int repeat, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1794ED0 Offset: 0x17934D0 VA: 0x181794ED0
	private static string FormatMonth(int month, int repeatCount, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1794E10 Offset: 0x1793410 VA: 0x181794E10
	private static string FormatHebrewMonthName(DateTime time, int month, int repeatCount, DateTimeFormatInfo dtfi) { }

	// RVA: 0x17956F0 Offset: 0x1793CF0 VA: 0x1817956F0
	internal static int ParseQuoteString(string format, int pos, StringBuilder result) { }

	// RVA: 0x17956B0 Offset: 0x1793CB0 VA: 0x1817956B0
	internal static int ParseNextChar(string format, int pos) { }

	// RVA: 0x17955A0 Offset: 0x1793BA0 VA: 0x1817955A0
	private static bool IsUseGenitiveForm(string format, int index, int tokenLen, char patternToMatch) { }

	// RVA: 0x17939B0 Offset: 0x1791FB0 VA: 0x1817939B0
	private static string FormatCustomized(DateTime dateTime, string format, DateTimeFormatInfo dtfi, TimeSpan offset) { }

	// RVA: 0x1793620 Offset: 0x1791C20 VA: 0x181793620
	private static void FormatCustomizedTimeZone(DateTime dateTime, TimeSpan offset, string format, int tokenLen, bool timeOnly, StringBuilder result) { }

	// RVA: 0x17933F0 Offset: 0x17919F0 VA: 0x1817933F0
	private static void FormatCustomizedRoundripTimeZone(DateTime dateTime, TimeSpan offset, StringBuilder result) { }

	// RVA: 0x1795200 Offset: 0x1793800 VA: 0x181795200
	internal static string GetRealFormat(string format, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1792D70 Offset: 0x1791370 VA: 0x181792D70
	private static string ExpandPredefinedFormat(string format, ref DateTime dateTime, ref DateTimeFormatInfo dtfi, ref TimeSpan offset) { }

	// RVA: 0x1794F10 Offset: 0x1793510 VA: 0x181794F10
	internal static string Format(DateTime dateTime, string format, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1794FA0 Offset: 0x17935A0 VA: 0x181794FA0
	internal static string Format(DateTime dateTime, string format, DateTimeFormatInfo dtfi, TimeSpan offset) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal static void InvalidFormatForLocal(string format, DateTime dateTime) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal static void InvalidFormatForUtc(string format, DateTime dateTime) { }

	// RVA: 0x1795910 Offset: 0x1793F10 VA: 0x181795910
	private static void .cctor() { }

}

internal static class DateTimeParse // TypeDefIndex: 226
{	// Fields
	internal static DateTimeParse.MatchNumberDelegate m_hebrewNumberParser; // 0x0
	private static DateTimeParse.DS[][] dateParsingStates; // 0x8

	// Methods

	// RVA: 0x179F520 Offset: 0x179DB20 VA: 0x18179F520
	internal static DateTime ParseExact(string s, string format, DateTimeFormatInfo dtfi, DateTimeStyles style) { }

	// RVA: 0x179F2C0 Offset: 0x179D8C0 VA: 0x18179F2C0
	internal static DateTime ParseExact(string s, string format, DateTimeFormatInfo dtfi, DateTimeStyles style, out TimeSpan offset) { }

	// RVA: 0x17A1F70 Offset: 0x17A0570 VA: 0x1817A1F70
	internal static bool TryParseExact(string s, string format, DateTimeFormatInfo dtfi, DateTimeStyles style, out DateTime result) { }

	// RVA: 0x17A1BC0 Offset: 0x17A01C0 VA: 0x1817A1BC0
	internal static bool TryParseExact(string s, string format, DateTimeFormatInfo dtfi, DateTimeStyles style, out DateTime result, out TimeSpan offset) { }

	// RVA: 0x17A1E30 Offset: 0x17A0430 VA: 0x1817A1E30
	internal static bool TryParseExact(string s, string format, DateTimeFormatInfo dtfi, DateTimeStyles style, ref DateTimeResult result) { }

	// RVA: 0x179F190 Offset: 0x179D790 VA: 0x18179F190
	internal static DateTime ParseExactMultiple(string s, string[] formats, DateTimeFormatInfo dtfi, DateTimeStyles style) { }

	// RVA: 0x17A1A30 Offset: 0x17A0030 VA: 0x1817A1A30
	internal static bool TryParseExactMultiple(string s, string[] formats, DateTimeFormatInfo dtfi, DateTimeStyles style, out DateTime result, out TimeSpan offset) { }

	// RVA: 0x17A1710 Offset: 0x179FD10 VA: 0x1817A1710
	internal static bool TryParseExactMultiple(string s, string[] formats, DateTimeFormatInfo dtfi, DateTimeStyles style, ref DateTimeResult result) { }

	// RVA: 0x179D770 Offset: 0x179BD70 VA: 0x18179D770
	private static bool MatchWord(ref __DTString str, string target) { }

	// RVA: 0x179B9A0 Offset: 0x1799FA0 VA: 0x18179B9A0
	private static bool GetTimeZoneName(ref __DTString str) { }

	// RVA: 0x179BF20 Offset: 0x179A520 VA: 0x18179BF20
	internal static bool IsDigit(char ch) { }

	// RVA: 0x179F870 Offset: 0x179DE70 VA: 0x18179F870
	private static bool ParseFraction(ref __DTString str, out double result) { }

	// RVA: 0x17A0350 Offset: 0x179E950 VA: 0x1817A0350
	private static bool ParseTimeZone(ref __DTString str, ref TimeSpan result) { }

	// RVA: 0x179BDC0 Offset: 0x179A3C0 VA: 0x18179BDC0
	private static bool HandleTimeZone(ref __DTString str, ref DateTimeResult result) { }

	// RVA: 0x179BF40 Offset: 0x179A540 VA: 0x18179BF40
	private static bool Lex(DateTimeParse.DS dps, ref __DTString str, ref DateTimeToken dtok, ref DateTimeRawInfo raw, ref DateTimeResult result, ref DateTimeFormatInfo dtfi, DateTimeStyles styles) { }

	// RVA: 0x17A2E00 Offset: 0x17A1400 VA: 0x1817A2E00
	private static bool VerifyValidPunctuation(ref __DTString str) { }

	// RVA: 0x179BA40 Offset: 0x179A040 VA: 0x18179BA40
	private static bool GetYearMonthDayOrder(string datePattern, DateTimeFormatInfo dtfi, out int order) { }

	// RVA: 0x179BC70 Offset: 0x179A270 VA: 0x18179BC70
	private static bool GetYearMonthOrder(string pattern, DateTimeFormatInfo dtfi, out int order) { }

	// RVA: 0x179B650 Offset: 0x1799C50 VA: 0x18179B650
	private static bool GetMonthDayOrder(string pattern, DateTimeFormatInfo dtfi, out int order) { }

	// RVA: 0x17A1660 Offset: 0x179FC60 VA: 0x1817A1660
	private static bool TryAdjustYear(ref DateTimeResult result, int year, out int adjustedYear) { }

	// RVA: 0x17A15E0 Offset: 0x179FBE0 VA: 0x1817A15E0
	private static bool SetDateYMD(ref DateTimeResult result, int year, int month, int day) { }

	// RVA: 0x17A1460 Offset: 0x179FA60 VA: 0x1817A1460
	private static bool SetDateMDY(ref DateTimeResult result, int month, int day, int year) { }

	// RVA: 0x17A13A0 Offset: 0x179F9A0 VA: 0x1817A13A0
	private static bool SetDateDMY(ref DateTimeResult result, int day, int month, int year) { }

	// RVA: 0x17A1520 Offset: 0x179FB20 VA: 0x1817A1520
	private static bool SetDateYDM(ref DateTimeResult result, int year, int day, int month) { }

	// RVA: 0x179B430 Offset: 0x1799A30 VA: 0x18179B430
	private static void GetDefaultYear(ref DateTimeResult result, ref DateTimeStyles styles) { }

	// RVA: 0x179AD30 Offset: 0x1799330 VA: 0x18179AD30
	private static bool GetDayOfNN(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x179A690 Offset: 0x1798C90 VA: 0x18179A690
	private static bool GetDayOfNNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x179A170 Offset: 0x1798770 VA: 0x18179A170
	private static bool GetDayOfMN(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x179B4D0 Offset: 0x1799AD0 VA: 0x18179B4D0
	private static bool GetHebrewDayOfNM(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x179A400 Offset: 0x1798A00 VA: 0x18179A400
	private static bool GetDayOfNM(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1799D60 Offset: 0x1798360 VA: 0x181799D60
	private static bool GetDayOfMNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x179B150 Offset: 0x1799750 VA: 0x18179B150
	private static bool GetDayOfYNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x179AB50 Offset: 0x1799150 VA: 0x18179AB50
	private static bool GetDayOfNNY(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x179AF10 Offset: 0x1799510 VA: 0x18179AF10
	private static bool GetDayOfYMN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x179B2F0 Offset: 0x17998F0 VA: 0x18179B2F0
	private static bool GetDayOfYN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x179B010 Offset: 0x1799610 VA: 0x18179B010
	private static bool GetDayOfYM(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1797F10 Offset: 0x1796510 VA: 0x181797F10
	private static void AdjustTimeMark(DateTimeFormatInfo dtfi, ref DateTimeRawInfo raw) { }

	// RVA: 0x1797ED0 Offset: 0x17964D0 VA: 0x181797ED0
	private static bool AdjustHour(ref int hour, DateTimeParse.TM timeMark) { }

	// RVA: 0x179B910 Offset: 0x1799F10 VA: 0x18179B910
	private static bool GetTimeOfN(DateTimeFormatInfo dtfi, ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x179B880 Offset: 0x1799E80 VA: 0x18179B880
	private static bool GetTimeOfNN(DateTimeFormatInfo dtfi, ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x179B7E0 Offset: 0x1799DE0 VA: 0x18179B7E0
	private static bool GetTimeOfNNN(DateTimeFormatInfo dtfi, ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x1799610 Offset: 0x1797C10 VA: 0x181799610
	private static bool GetDateOfDSN(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x17996A0 Offset: 0x1797CA0 VA: 0x1817996A0
	private static bool GetDateOfNDS(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x1799760 Offset: 0x1797D60 VA: 0x181799760
	private static bool GetDateOfNNDS(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x17A08B0 Offset: 0x179EEB0 VA: 0x1817A08B0
	private static bool ProcessDateTimeSuffix(ref DateTimeResult result, ref DateTimeRawInfo raw, ref DateTimeToken dtok) { }

	// RVA: 0x17A0990 Offset: 0x179EF90 VA: 0x1817A0990
	internal static bool ProcessHebrewTerminalState(DateTimeParse.DS dps, ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x17A0E10 Offset: 0x179F410 VA: 0x1817A0E10
	internal static bool ProcessTerminaltState(DateTimeParse.DS dps, ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x17A0660 Offset: 0x179EC60 VA: 0x1817A0660
	internal static DateTime Parse(string s, DateTimeFormatInfo dtfi, DateTimeStyles styles) { }

	// RVA: 0x17A0780 Offset: 0x179ED80 VA: 0x1817A0780
	internal static DateTime Parse(string s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out TimeSpan offset) { }

	// RVA: 0x17A2B50 Offset: 0x17A1150 VA: 0x1817A2B50
	internal static bool TryParse(string s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out DateTime result) { }

	// RVA: 0x17A2C80 Offset: 0x17A1280 VA: 0x1817A2C80
	internal static bool TryParse(string s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out DateTime result, out TimeSpan offset) { }

	// RVA: 0x17A2260 Offset: 0x17A0860 VA: 0x1817A2260
	internal static bool TryParse(string s, DateTimeFormatInfo dtfi, DateTimeStyles styles, ref DateTimeResult result) { }

	// RVA: 0x1798740 Offset: 0x1796D40 VA: 0x181798740
	private static bool DetermineTimeZoneAdjustments(ref DateTimeResult result, DateTimeStyles styles, bool bTimeOnly) { }

	// RVA: 0x1798540 Offset: 0x1796B40 VA: 0x181798540
	private static bool DateTimeOffsetTimeZonePostProcessing(ref DateTimeResult result, DateTimeStyles styles) { }

	// RVA: 0x17981A0 Offset: 0x17967A0 VA: 0x1817981A0
	private static bool AdjustTimeZoneToUniversal(ref DateTimeResult result) { }

	// RVA: 0x1797F80 Offset: 0x1796580 VA: 0x181797F80
	private static bool AdjustTimeZoneToLocal(ref DateTimeResult result, bool bTimeOnly) { }

	// RVA: 0x179F950 Offset: 0x179DF50 VA: 0x18179F950
	private static bool ParseISO8601(ref DateTimeRawInfo raw, ref __DTString str, DateTimeStyles styles, ref DateTimeResult result) { }

	// RVA: 0x179D3F0 Offset: 0x179B9F0 VA: 0x18179D3F0
	internal static bool MatchHebrewDigits(ref __DTString str, int digitLen, out int number) { }

	// RVA: 0x179EFB0 Offset: 0x179D5B0 VA: 0x18179EFB0
	internal static bool ParseDigits(ref __DTString str, int digitLen, out int result) { }

	// RVA: 0x179F0E0 Offset: 0x179D6E0 VA: 0x18179F0E0
	internal static bool ParseDigits(ref __DTString str, int minDigitLen, int maxDigitLen, out int result) { }

	// RVA: 0x179F730 Offset: 0x179DD30 VA: 0x18179F730
	private static bool ParseFractionExact(ref __DTString str, int maxDigitLen, ref double result) { }

	// RVA: 0x179FF70 Offset: 0x179E570 VA: 0x18179FF70
	private static bool ParseSign(ref __DTString str, ref bool result) { }

	// RVA: 0x179FFD0 Offset: 0x179E5D0 VA: 0x18179FFD0
	private static bool ParseTimeZoneOffset(ref __DTString str, int len, ref TimeSpan result) { }

	// RVA: 0x179CF80 Offset: 0x179B580 VA: 0x18179CF80
	private static bool MatchAbbreviatedMonthName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	// RVA: 0x179D4D0 Offset: 0x179BAD0 VA: 0x18179D4D0
	private static bool MatchMonthName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	// RVA: 0x179CEA0 Offset: 0x179B4A0 VA: 0x18179CEA0
	private static bool MatchAbbreviatedDayName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	// RVA: 0x179D190 Offset: 0x179B790 VA: 0x18179D190
	private static bool MatchDayName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	// RVA: 0x179D270 Offset: 0x179B870 VA: 0x18179D270
	private static bool MatchEraName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	// RVA: 0x179D660 Offset: 0x179BC60 VA: 0x18179D660
	private static bool MatchTimeMark(ref __DTString str, DateTimeFormatInfo dtfi, ref DateTimeParse.TM result) { }

	// RVA: 0x179D0E0 Offset: 0x179B6E0 VA: 0x18179D0E0
	private static bool MatchAbbreviatedTimeMark(ref __DTString str, DateTimeFormatInfo dtfi, ref DateTimeParse.TM result) { }

	// RVA: 0x1798490 Offset: 0x1796A90 VA: 0x181798490
	private static bool CheckNewValue(ref int currentValue, int newValue, char patternChar, ref DateTimeResult result) { }

	// RVA: 0x1799A00 Offset: 0x1798000 VA: 0x181799A00
	private static DateTime GetDateTimeNow(ref DateTimeResult result, ref DateTimeStyles styles) { }

	// RVA: 0x1798260 Offset: 0x1796860 VA: 0x181798260
	private static bool CheckDefaultDateTime(ref DateTimeResult result, ref Calendar cal, DateTimeStyles styles) { }

	// RVA: 0x1798F70 Offset: 0x1797570 VA: 0x181798F70
	private static string ExpandPredefinedFormat(string format, ref DateTimeFormatInfo dtfi, ref ParsingInfo parseInfo, ref DateTimeResult result) { }

	// RVA: 0x179D8B0 Offset: 0x179BEB0 VA: 0x18179D8B0
	private static bool ParseByFormat(ref __DTString str, ref __DTString format, ref ParsingInfo parseInfo, DateTimeFormatInfo dtfi, ref DateTimeResult result) { }

	// RVA: 0x17A2190 Offset: 0x17A0790 VA: 0x1817A2190
	internal static bool TryParseQuoteString(string format, int pos, StringBuilder result, out int returnValue) { }

	// RVA: 0x1798940 Offset: 0x1796F40 VA: 0x181798940
	private static bool DoStrictParse(string s, string formatParam, DateTimeStyles styles, DateTimeFormatInfo dtfi, ref DateTimeResult result) { }

	// RVA: 0x1799B70 Offset: 0x1798170 VA: 0x181799B70
	private static Exception GetDateTimeParseException(ref DateTimeResult result) { }

	// RVA: 0x17A2F70 Offset: 0x17A1570 VA: 0x1817A2F70
	private static void .cctor() { }

}

internal sealed class DateTimeParse.MatchNumberDelegate : MulticastDelegate // TypeDefIndex: 227
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x17AADA0 Offset: 0x17A93A0 VA: 0x1817AADA0 Slot: 12
	public virtual bool Invoke(ref __DTString str, int digitLen, out int result) { }

	// RVA: 0x17AACF0 Offset: 0x17A92F0 VA: 0x1817AACF0 Slot: 13
	public virtual IAsyncResult BeginInvoke(ref __DTString str, int digitLen, out int result, AsyncCallback callback, object object) { }

	// RVA: 0x175F2D0 Offset: 0x175D8D0 VA: 0x18175F2D0 Slot: 14
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

	// RVA: 0x20BD60 Offset: 0x20B160 VA: 0x18020BD60
	internal void Init(int* numberBuffer) { }

	// RVA: 0x20BD30 Offset: 0x20B130 VA: 0x18020BD30
	internal void AddNumber(int value) { }

	// RVA: 0x20BD50 Offset: 0x20B150 VA: 0x18020BD50
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

	// RVA: 0x20BE30 Offset: 0x20B230 VA: 0x18020BE30
	internal void Init() { }

	// RVA: 0x20BE60 Offset: 0x20B260 VA: 0x18020BE60
	internal void SetDate(int year, int month, int day) { }

	// RVA: 0x20BE70 Offset: 0x20B270 VA: 0x18020BE70
	internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) { }

	// RVA: 0x20BEB0 Offset: 0x20B2B0 VA: 0x18020BEB0
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

	// RVA: 0x16E5470 Offset: 0x16E3A70 VA: 0x1816E5470
	private string get_CultureName() { }

	// RVA: 0x16E54B0 Offset: 0x16E3AB0 VA: 0x1816E54B0
	private CultureInfo get_Culture() { }

	// RVA: 0x16E6670 Offset: 0x16E4C70 VA: 0x1816E6670
	private string get_LanguageName() { }

	// RVA: 0x16E6DB0 Offset: 0x16E53B0 VA: 0x1816E6DB0
	private string[] internalGetAbbreviatedDayOfWeekNames() { }

	// RVA: 0x16E6E90 Offset: 0x16E5490 VA: 0x1816E6E90
	private string[] internalGetDayOfWeekNames() { }

	// RVA: 0x16E6E20 Offset: 0x16E5420 VA: 0x1816E6E20
	private string[] internalGetAbbreviatedMonthNames() { }

	// RVA: 0x16E7290 Offset: 0x16E5890 VA: 0x1816E7290
	private string[] internalGetMonthNames() { }

	// RVA: 0x16E4BE0 Offset: 0x16E31E0 VA: 0x1816E4BE0
	public void .ctor() { }

	// RVA: 0x16E4D10 Offset: 0x16E3310 VA: 0x1816E4D10
	internal void .ctor(CultureData cultureData, Calendar cal) { }

	// RVA: 0x16E3030 Offset: 0x16E1630 VA: 0x1816E3030
	private void InitializeOverridableProperties(CultureData cultureData, int calendarID) { }

	[OnDeserializedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x16E38C0 Offset: 0x16E1EC0 VA: 0x1816E38C0
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x16E40A0 Offset: 0x16E26A0 VA: 0x1816E40A0
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x16E6430 Offset: 0x16E4A30 VA: 0x1816E6430
	public static DateTimeFormatInfo get_InvariantInfo() { }

	// RVA: 0x16E5570 Offset: 0x16E3B70 VA: 0x1816E5570
	public static DateTimeFormatInfo get_CurrentInfo() { }

	// RVA: 0x16E2750 Offset: 0x16E0D50 VA: 0x1816E2750
	public static DateTimeFormatInfo GetInstance(IFormatProvider provider) { }

	// RVA: 0x16E26C0 Offset: 0x16E0CC0 VA: 0x1816E26C0 Slot: 5
	public object GetFormat(Type formatType) { }

	// RVA: 0x16E04E0 Offset: 0x16DEAE0 VA: 0x1816E04E0 Slot: 4
	public object Clone() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public string get_AMDesignator() { }

	// RVA: 0x4E8520 Offset: 0x4E6B20 VA: 0x1804E8520
	public Calendar get_Calendar() { }

	// RVA: 0x16E7300 Offset: 0x16E5900 VA: 0x1816E7300
	public void set_Calendar(Calendar value) { }

	// RVA: 0x16E6980 Offset: 0x16E4F80 VA: 0x1816E6980
	private int[] get_OptionalCalendars() { }

	// RVA: 0x16E5980 Offset: 0x16E3F80 VA: 0x1816E5980
	internal string[] get_EraNames() { }

	// RVA: 0x16E2560 Offset: 0x16E0B60 VA: 0x1816E2560
	public string GetEraName(int era) { }

	// RVA: 0x16E4E60 Offset: 0x16E3460 VA: 0x1816E4E60
	internal string[] get_AbbreviatedEraNames() { }

	// RVA: 0x16E1AA0 Offset: 0x16E00A0 VA: 0x1816E1AA0
	public string GetAbbreviatedEraName(int era) { }

	// RVA: 0x16E4DF0 Offset: 0x16E33F0 VA: 0x1816E4DF0
	internal string[] get_AbbreviatedEnglishEraNames() { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public string get_DateSeparator() { }

	// RVA: 0x16E5F00 Offset: 0x16E4500 VA: 0x1816E5F00
	public string get_FullDateTimePattern() { }

	// RVA: 0x16E66B0 Offset: 0x16E4CB0 VA: 0x1816E66B0
	public string get_LongDatePattern() { }

	// RVA: 0x16E7700 Offset: 0x16E5D00 VA: 0x1816E7700
	public void set_LongDatePattern(string value) { }

	// RVA: 0x16E6710 Offset: 0x16E4D10 VA: 0x1816E6710
	public string get_LongTimePattern() { }

	// RVA: 0x16E7810 Offset: 0x16E5E10 VA: 0x1816E7810
	public void set_LongTimePattern(string value) { }

	// RVA: 0x16E67B0 Offset: 0x16E4DB0 VA: 0x1816E67B0
	public string get_MonthDayPattern() { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public string get_PMDesignator() { }

	// RVA: 0x16E69D0 Offset: 0x16E4FD0 VA: 0x1816E69D0
	public string get_RFC1123Pattern() { }

	// RVA: 0x16E6A00 Offset: 0x16E5000 VA: 0x1816E6A00
	public string get_ShortDatePattern() { }

	// RVA: 0x16E7940 Offset: 0x16E5F40 VA: 0x1816E7940
	public void set_ShortDatePattern(string value) { }

	// RVA: 0x16E6A60 Offset: 0x16E5060 VA: 0x1816E6A60
	public string get_ShortTimePattern() { }

	// RVA: 0x16E7A70 Offset: 0x16E6070 VA: 0x1816E7A70
	public void set_ShortTimePattern(string value) { }

	// RVA: 0x16E6B00 Offset: 0x16E5100 VA: 0x1816E6B00
	public string get_SortableDateTimePattern() { }

	// RVA: 0x16E62B0 Offset: 0x16E48B0 VA: 0x1816E62B0
	internal string get_GeneralShortTimePattern() { }

	// RVA: 0x16E61D0 Offset: 0x16E47D0 VA: 0x1816E61D0
	internal string get_GeneralLongTimePattern() { }

	// RVA: 0x16E5670 Offset: 0x16E3C70 VA: 0x1816E5670
	internal string get_DateTimeOffsetPattern() { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public string get_TimeSeparator() { }

	// RVA: 0x16E6D20 Offset: 0x16E5320 VA: 0x1816E6D20
	public string get_UniversalSortableDateTimePattern() { }

	// RVA: 0x16E6D50 Offset: 0x16E5350 VA: 0x1816E6D50
	public string get_YearMonthPattern() { }

	// RVA: 0x16E7B80 Offset: 0x16E6180 VA: 0x1816E7B80
	public void set_YearMonthPattern(string value) { }

	// RVA: 0x16E4D70 Offset: 0x16E3370 VA: 0x1816E4D70
	public string[] get_AbbreviatedDayNames() { }

	// RVA: 0x16E5900 Offset: 0x16E3F00 VA: 0x1816E5900
	public string[] get_DayNames() { }

	// RVA: 0x16E4ED0 Offset: 0x16E34D0 VA: 0x1816E4ED0
	public string[] get_AbbreviatedMonthNames() { }

	// RVA: 0x16E6900 Offset: 0x16E4F00 VA: 0x1816E6900
	public string[] get_MonthNames() { }

	// RVA: 0x16E63F0 Offset: 0x16E49F0 VA: 0x1816E63F0
	internal bool get_HasSpacesInMonthNames() { }

	// RVA: 0x16E63D0 Offset: 0x16E49D0 VA: 0x1816E63D0
	internal bool get_HasSpacesInDayNames() { }

	// RVA: 0x16E7070 Offset: 0x16E5670 VA: 0x1816E7070
	internal string internalGetMonthName(int month, MonthNameStyles style, bool abbreviated) { }

	// RVA: 0x16E6F00 Offset: 0x16E5500 VA: 0x1816E6F00
	private string[] internalGetGenitiveMonthNames(bool abbreviated) { }

	// RVA: 0x16E6FF0 Offset: 0x16E55F0 VA: 0x1816E6FF0
	internal string[] internalGetLeapYearMonthNames() { }

	// RVA: 0x16E1950 Offset: 0x16DFF50 VA: 0x1816E1950
	public string GetAbbreviatedDayName(DayOfWeek dayofweek) { }

	// RVA: 0x16E22A0 Offset: 0x16E08A0 VA: 0x1816E22A0
	private static string[] GetCombinedPatterns(string[] patterns1, string[] patterns2, string connectString) { }

	// RVA: 0x16E1D80 Offset: 0x16E0380 VA: 0x1816E1D80
	public string[] GetAllDateTimePatterns(char format) { }

	// RVA: 0x16E2410 Offset: 0x16E0A10 VA: 0x1816E2410
	public string GetDayName(DayOfWeek dayofweek) { }

	// RVA: 0x16E1C20 Offset: 0x16E0220 VA: 0x1816E1C20
	public string GetAbbreviatedMonthName(int month) { }

	// RVA: 0x16E2D90 Offset: 0x16E1390 VA: 0x1816E2D90
	public string GetMonthName(int month) { }

	// RVA: 0x16E2B10 Offset: 0x16E1110 VA: 0x1816E2B10
	private static string[] GetMergedPatterns(string[] patterns, string defaultPattern) { }

	// RVA: 0x16E5290 Offset: 0x16E3890 VA: 0x1816E5290
	private string[] get_AllYearMonthPatterns() { }

	// RVA: 0x16E50F0 Offset: 0x16E36F0 VA: 0x1816E50F0
	private string[] get_AllShortDatePatterns() { }

	// RVA: 0x16E51D0 Offset: 0x16E37D0 VA: 0x1816E51D0
	private string[] get_AllShortTimePatterns() { }

	// RVA: 0x16E4F50 Offset: 0x16E3550 VA: 0x1816E4F50
	private string[] get_AllLongDatePatterns() { }

	// RVA: 0x16E5030 Offset: 0x16E3630 VA: 0x1816E5030
	private string[] get_AllLongTimePatterns() { }

	// RVA: 0x16E6CB0 Offset: 0x16E52B0 VA: 0x1816E6CB0
	private string[] get_UnclonedYearMonthPatterns() { }

	// RVA: 0x16E6BF0 Offset: 0x16E51F0 VA: 0x1816E6BF0
	private string[] get_UnclonedShortDatePatterns() { }

	// RVA: 0x16E6B30 Offset: 0x16E5130 VA: 0x1816E6B30
	private string[] get_UnclonedLongDatePatterns() { }

	// RVA: 0x16E6C60 Offset: 0x16E5260 VA: 0x1816E6C60
	private string[] get_UnclonedShortTimePatterns() { }

	// RVA: 0x16E6BA0 Offset: 0x16E51A0 VA: 0x1816E6BA0
	private string[] get_UnclonedLongTimePatterns() { }

	// RVA: 0x16E6660 Offset: 0x16E4C60 VA: 0x1816E6660
	public bool get_IsReadOnly() { }

	// RVA: 0x16E6820 Offset: 0x16E4E20 VA: 0x1816E6820
	public string[] get_MonthGenitiveNames() { }

	// RVA: 0x16E6110 Offset: 0x16E4710 VA: 0x1816E6110
	internal string get_FullTimeSpanPositivePattern() { }

	// RVA: 0x16E5FF0 Offset: 0x16E45F0 VA: 0x1816E5FF0
	internal string get_FullTimeSpanNegativePattern() { }

	// RVA: 0x16E5370 Offset: 0x16E3970 VA: 0x1816E5370
	internal CompareInfo get_CompareInfo() { }

	// RVA: 0x16E4960 Offset: 0x16E2F60 VA: 0x1816E4960
	internal static void ValidateStyles(DateTimeStyles style, string parameterName) { }

	// RVA: 0x16E59F0 Offset: 0x16E3FF0 VA: 0x1816E59F0
	internal DateTimeFormatFlags get_FormatFlags() { }

	// RVA: 0x16E6390 Offset: 0x16E4990 VA: 0x1816E6390
	internal bool get_HasForceTwoDigitYears() { }

	// RVA: 0x16E6410 Offset: 0x16E4A10 VA: 0x1816E6410
	internal bool get_HasYearMonthAdjustment() { }

	// RVA: 0x16E4A80 Offset: 0x16E3080 VA: 0x1816E4A80
	internal bool YearMonthAdjustment(ref int year, ref int month, bool parsedMonthName) { }

	// RVA: 0x16E29D0 Offset: 0x16E0FD0 VA: 0x1816E29D0
	internal static DateTimeFormatInfo GetJapaneseCalendarDTFI() { }

	// RVA: 0x16E2EF0 Offset: 0x16E14F0 VA: 0x1816E2EF0
	internal static DateTimeFormatInfo GetTaiwanCalendarDTFI() { }

	// RVA: 0x16E04B0 Offset: 0x16DEAB0 VA: 0x1816E04B0
	private void ClearTokenHashTable() { }

	// RVA: 0x16E05E0 Offset: 0x16DEBE0 VA: 0x1816E05E0
	internal TokenHashValue[] CreateTokenHashTable() { }

	// RVA: 0x16E03E0 Offset: 0x16DE9E0 VA: 0x1816E03E0
	private void AddMonthNames(TokenHashValue[] temp, string monthPostfix) { }

	// RVA: 0x16E4740 Offset: 0x16E2D40 VA: 0x1816E4740
	private static bool TryParseHebrewNumber(ref __DTString str, out bool badFormat, out int number) { }

	// RVA: 0x16E38A0 Offset: 0x16E1EA0 VA: 0x1816E38A0
	private static bool IsHebrewChar(char ch) { }

	// RVA: 0x16E42F0 Offset: 0x16E28F0 VA: 0x1816E42F0
	internal bool Tokenize(TokenType TokenMask, out TokenType tokenType, out int tokenValue, ref __DTString str) { }

	// RVA: 0x16E3260 Offset: 0x16E1860 VA: 0x1816E3260
	private void InsertAtCurrentHashNode(TokenHashValue[] hashTable, string str, char ch, TokenType tokenType, int tokenValue, int pos, int hashcode, int hashProbe) { }

	// RVA: 0x16E34B0 Offset: 0x16E1AB0 VA: 0x1816E34B0
	private void InsertHash(TokenHashValue[] hashTable, string str, TokenType tokenType, int tokenValue) { }

	// RVA: 0x16E4BA0 Offset: 0x16E31A0 VA: 0x1816E4BA0
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

	// RVA: 0x16E00C0 Offset: 0x16DE6C0 VA: 0x1816E00C0
	private static Dictionary<string, string> get_KnownWords() { }

	// RVA: 0x16DFF80 Offset: 0x16DE580 VA: 0x1816DFF80
	internal static int SkipWhiteSpacesAndNonLetter(string pattern, int currentIndex) { }

	// RVA: 0x16DEDE0 Offset: 0x16DD3E0 VA: 0x1816DEDE0
	internal void AddDateWordOrPostfix(string formatPostfix, string str) { }

	// RVA: 0x16DEFB0 Offset: 0x16DD5B0 VA: 0x1816DEFB0
	internal int AddDateWords(string pattern, int index, string formatPostfix) { }

	// RVA: 0x16DFF10 Offset: 0x16DE510 VA: 0x1816DFF10
	internal static int ScanRepeatChar(string pattern, char ch, int index, out int count) { }

	// RVA: 0x16DF1E0 Offset: 0x16DD7E0 VA: 0x1816DF1E0
	internal void AddIgnorableSymbols(string text) { }

	// RVA: 0x16DFCD0 Offset: 0x16DE2D0 VA: 0x1816DFCD0
	internal void ScanDateWord(string pattern) { }

	// RVA: 0x16DF6F0 Offset: 0x16DDCF0 VA: 0x1816DF6F0
	internal string[] GetDateWordsOfDTFI(DateTimeFormatInfo dtfi) { }

	// RVA: 0x16DFA70 Offset: 0x16DE070 VA: 0x1816DFA70
	internal static FORMATFLAGS GetFormatFlagGenitiveMonth(string[] monthNames, string[] genitveMonthNames, string[] abbrevMonthNames, string[] genetiveAbbrevMonthNames) { }

	// RVA: 0x16DFC10 Offset: 0x16DE210 VA: 0x1816DFC10
	internal static FORMATFLAGS GetFormatFlagUseSpaceInMonthNames(string[] monthNames, string[] genitveMonthNames, string[] abbrevMonthNames, string[] genetiveAbbrevMonthNames) { }

	// RVA: 0x16DFBD0 Offset: 0x16DE1D0 VA: 0x1816DFBD0
	internal static FORMATFLAGS GetFormatFlagUseSpaceInDayNames(string[] dayNames, string[] abbrevDayNames) { }

	// RVA: 0x16DFBC0 Offset: 0x16DE1C0 VA: 0x1816DFBC0
	internal static FORMATFLAGS GetFormatFlagUseHebrewCalendar(int calID) { }

	// RVA: 0x16DF630 Offset: 0x16DDC30 VA: 0x1816DF630
	private static bool EqualStringArrays(string[] array1, string[] array2) { }

	// RVA: 0x16DF550 Offset: 0x16DDB50 VA: 0x1816DF550
	private static bool ArrayElementsHaveSpace(string[] array) { }

	// RVA: 0x16DF2B0 Offset: 0x16DD8B0 VA: 0x1816DF2B0
	private static bool ArrayElementsBeginWithDigit(string[] array) { }

	// RVA: 0x16E0050 Offset: 0x16DE650 VA: 0x1816E0050
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

	// RVA: 0xFE5F60 Offset: 0xFE4560 VA: 0x180FE5F60 Slot: 7
	public override object get_Value() { }

}

internal sealed class DateTimeTypeInfo : TraceLoggingTypeInfo<DateTime> // TypeDefIndex: 1571
{	// Methods

	// RVA: 0xD69710 Offset: 0xD67D10 VA: 0x180D69710 Slot: 4
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

	// RVA: 0xD696C0 Offset: 0xD67CC0 VA: 0x180D696C0 Slot: 7
	public override void WriteData(TraceLoggingDataCollector collector, ref DateTime value) { }

	// RVA: 0xD697A0 Offset: 0xD67DA0 VA: 0x180D697A0
	public void .ctor() { }

}

internal sealed class DateTimeOffsetTypeInfo : TraceLoggingTypeInfo<DateTimeOffset> // TypeDefIndex: 1572
{	// Methods

	// RVA: 0xD695C0 Offset: 0xD67BC0 VA: 0x180D695C0 Slot: 4
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

	// RVA: 0xD69540 Offset: 0xD67B40 VA: 0x180D69540 Slot: 7
	public override void WriteData(TraceLoggingDataCollector collector, ref DateTimeOffset value) { }

	// RVA: 0xD69680 Offset: 0xD67C80 VA: 0x180D69680
	public void .ctor() { }

}

internal class DateTimeFacetsChecker : FacetsChecker // TypeDefIndex: 2251
{	// Methods

	// RVA: 0x1516700 Offset: 0x1514D00 VA: 0x181516700 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x15162D0 Offset: 0x15148D0 VA: 0x1815162D0 Slot: 10
	internal override Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype) { }

	// RVA: 0x15168C0 Offset: 0x1514EC0 VA: 0x1815168C0 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x1516780 Offset: 0x1514D80 VA: 0x181516780
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

	// RVA: 0x12798C0 Offset: 0x1277EC0 VA: 0x1812798C0
	internal void .ctor(DataColumn column) { }

	// RVA: 0x12787C0 Offset: 0x1276DC0 VA: 0x1812787C0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1278E50 Offset: 0x1277450 VA: 0x181278E50 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1278C90 Offset: 0x1277290 VA: 0x181278C90 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x12790F0 Offset: 0x12776F0 VA: 0x1812790F0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1279350 Offset: 0x1277950 VA: 0x181279350 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1279440 Offset: 0x1277A40 VA: 0x181279440 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1279710 Offset: 0x1277D10 VA: 0x181279710 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1279590 Offset: 0x1277B90 VA: 0x181279590 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1279180 Offset: 0x1277780 VA: 0x181279180 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1279060 Offset: 0x1277660 VA: 0x181279060 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1279400 Offset: 0x1277A00 VA: 0x181279400 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1279200 Offset: 0x1277800 VA: 0x181279200 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1279670 Offset: 0x1277C70 VA: 0x181279670 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x1279850 Offset: 0x1277E50 VA: 0x181279850
	private static void .cctor() { }

}

internal sealed class DateTimeStorage : DataStorage // TypeDefIndex: 4385
{	// Fields
	private static readonly DateTime s_defaultValue; // 0x0
	private DateTime[] _values; // 0x50

	// Methods

	// RVA: 0x127AE40 Offset: 0x1279440 VA: 0x18127AE40
	internal void .ctor(DataColumn column) { }

	// RVA: 0x12799D0 Offset: 0x1277FD0 VA: 0x1812799D0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x127A000 Offset: 0x1278600 VA: 0x18127A000 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1279E70 Offset: 0x1278470 VA: 0x181279E70 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x127A2A0 Offset: 0x12788A0 VA: 0x18127A2A0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x127A5C0 Offset: 0x1278BC0 VA: 0x18127A5C0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x127A6A0 Offset: 0x1278CA0 VA: 0x18127A6A0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x127AAF0 Offset: 0x12790F0 VA: 0x18127AAF0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x127A7C0 Offset: 0x1278DC0 VA: 0x18127A7C0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x127A380 Offset: 0x1278980 VA: 0x18127A380 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x127A1B0 Offset: 0x12787B0 VA: 0x18127A1B0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x127A660 Offset: 0x1278C60 VA: 0x18127A660 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x127A430 Offset: 0x1278A30 VA: 0x18127A430 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x127A8A0 Offset: 0x1278EA0 VA: 0x18127A8A0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x127ADD0 Offset: 0x12793D0 VA: 0x18127ADD0
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

	// RVA: 0x1802F40 Offset: 0x1801540 VA: 0x181802F40
	private static void .cctor() { }

	// RVA: 0x211360 Offset: 0x210760 VA: 0x180211360
	public bool Parse(char[] text, int startIndex, int length) { }

	// RVA: 0x2112F0 Offset: 0x2106F0 VA: 0x1802112F0
	private bool ParseDate(int start) { }

	// RVA: 0x211300 Offset: 0x210700 VA: 0x180211300
	private bool ParseTimeAndZoneAndWhitespace(int start) { }

	// RVA: 0x211340 Offset: 0x210740 VA: 0x180211340
	private bool ParseTime(ref int start) { }

	// RVA: 0x211350 Offset: 0x210750 VA: 0x180211350
	private bool ParseZone(int start) { }

	// RVA: 0x211290 Offset: 0x210690 VA: 0x180211290
	private bool Parse4Digit(int start, out int num) { }

	// RVA: 0x211280 Offset: 0x210680 VA: 0x180211280
	private bool Parse2Digit(int start, out int num) { }

	// RVA: 0x2112A0 Offset: 0x2106A0 VA: 0x1802112A0
	private bool ParseChar(int start, char ch) { }

}

internal static class DateTimeUtils // TypeDefIndex: 5949
{	// Fields
	internal static readonly long InitialJavaScriptDateTicks; // 0x0
	private static readonly int[] DaysToMonth365; // 0x8
	private static readonly int[] DaysToMonth366; // 0x10

	// Methods

	// RVA: 0x1806730 Offset: 0x1804D30 VA: 0x181806730
	private static void .cctor() { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1803A10 Offset: 0x1802010 VA: 0x181803A10
	public static TimeSpan GetUtcOffset(DateTime d) { }

	// RVA: 0x1803A80 Offset: 0x1802080 VA: 0x181803A80
	public static XmlDateTimeSerializationMode ToSerializationMode(DateTimeKind kind) { }

	// RVA: 0x1803650 Offset: 0x1801C50 VA: 0x181803650
	internal static DateTime EnsureDateTime(DateTime value, DateTimeZoneHandling timeZone) { }

	// RVA: 0xE5CC00 Offset: 0xE5B200 VA: 0x180E5CC00
	private static DateTime SwitchToLocalTime(DateTime value) { }

	// RVA: 0xE5CC70 Offset: 0xE5B270 VA: 0x180E5CC70
	private static DateTime SwitchToUtcTime(DateTime value) { }

	// RVA: 0x1803C30 Offset: 0x1802230 VA: 0x181803C30
	private static long ToUniversalTicks(DateTime dateTime) { }

	// RVA: 0x1803B10 Offset: 0x1802110 VA: 0x181803B10
	private static long ToUniversalTicks(DateTime dateTime, TimeSpan offset) { }

	// RVA: 0x1803170 Offset: 0x1801770 VA: 0x181803170
	internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, TimeSpan offset) { }

	// RVA: 0x18031E0 Offset: 0x18017E0 VA: 0x1818031E0
	internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime) { }

	// RVA: 0x1803320 Offset: 0x1801920 VA: 0x181803320
	internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, bool convertToUtc) { }

	// RVA: 0x1805860 Offset: 0x1803E60 VA: 0x181805860
	private static long UniversialTicksToJavaScriptTicks(long universialTicks) { }

	// RVA: 0x1803440 Offset: 0x1801A40 VA: 0x181803440
	internal static DateTime ConvertJavaScriptTicksToDateTime(long javaScriptTicks) { }

	// RVA: 0x1803DB0 Offset: 0x18023B0 VA: 0x181803DB0
	internal static bool TryParseDateTimeIso(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt) { }

	// RVA: 0x1804430 Offset: 0x1802A30 VA: 0x181804430
	internal static bool TryParseDateTimeOffsetIso(StringReference text, out DateTimeOffset dt) { }

	// RVA: 0x1803550 Offset: 0x1801B50 VA: 0x181803550
	private static DateTime CreateDateTime(DateTimeParser dateTimeParser) { }

	// RVA: 0x1805020 Offset: 0x1803620 VA: 0x181805020
	internal static bool TryParseDateTime(StringReference s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) { }

	// RVA: 0x1804D60 Offset: 0x1803360 VA: 0x181804D60
	internal static bool TryParseDateTime(string s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) { }

	// RVA: 0x1804740 Offset: 0x1802D40 VA: 0x181804740
	internal static bool TryParseDateTimeOffset(StringReference s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) { }

	// RVA: 0x1804A80 Offset: 0x1803080 VA: 0x181804A80
	internal static bool TryParseDateTimeOffset(string s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) { }

	// RVA: 0x1805380 Offset: 0x1803980 VA: 0x181805380
	private static bool TryParseMicrosoftDate(StringReference text, out long ticks, out TimeSpan offset, out DateTimeKind kind) { }

	// RVA: 0x1804200 Offset: 0x1802800 VA: 0x181804200
	private static bool TryParseDateTimeMicrosoft(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt) { }

	// RVA: 0x1803CC0 Offset: 0x18022C0 VA: 0x181803CC0
	private static bool TryParseDateTimeExact(string text, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) { }

	// RVA: 0x18045E0 Offset: 0x1802BE0 VA: 0x1818045E0
	private static bool TryParseDateTimeOffsetMicrosoft(StringReference text, out DateTimeOffset dt) { }

	// RVA: 0x1804370 Offset: 0x1802970 VA: 0x181804370
	private static bool TryParseDateTimeOffsetExact(string text, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) { }

	// RVA: 0x18056D0 Offset: 0x1803CD0 VA: 0x1818056D0
	private static bool TryReadOffset(StringReference offsetText, int startIndex, out TimeSpan offset) { }

	// RVA: 0x1805C90 Offset: 0x1804290 VA: 0x181805C90
	internal static void WriteDateTimeString(TextWriter writer, DateTime value, DateFormatHandling format, string formatString, CultureInfo culture) { }

	// RVA: 0x1805E00 Offset: 0x1804400 VA: 0x181805E00
	internal static int WriteDateTimeString(char[] chars, int start, DateTime value, Nullable<TimeSpan> offset, DateTimeKind kind, DateFormatHandling format) { }

	// RVA: 0x18061D0 Offset: 0x18047D0 VA: 0x1818061D0
	internal static int WriteDefaultIsoDate(char[] chars, int start, DateTime dt) { }

	// RVA: 0x18034D0 Offset: 0x1801AD0 VA: 0x1818034D0
	private static void CopyIntToCharArray(char[] chars, int start, int value, int digits) { }

	// RVA: 0x1805A60 Offset: 0x1804060 VA: 0x181805A60
	internal static int WriteDateTimeOffset(char[] chars, int start, TimeSpan offset, DateFormatHandling format) { }

	// RVA: 0x18058E0 Offset: 0x1803EE0 VA: 0x1818058E0
	internal static void WriteDateTimeOffsetString(TextWriter writer, DateTimeOffset value, DateFormatHandling format, string formatString, CultureInfo culture) { }

	// RVA: 0x1803820 Offset: 0x1801E20 VA: 0x181803820
	private static void GetDateValues(DateTime td, out int year, out int month, out int day) { }

}

public abstract class DateTimeConverterBase : JsonConverter // TypeDefIndex: 6101
{	// Methods

	// RVA: 0xF889F0 Offset: 0xF86FF0 VA: 0x180F889F0 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

