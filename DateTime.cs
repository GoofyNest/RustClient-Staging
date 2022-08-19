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

	// RVA: 0x20CC90 Offset: 0x20C090 VA: 0x18020CC90
	public void .ctor(long ticks) { }

	// RVA: 0x1D2F30 Offset: 0x1D2330 VA: 0x1801D2F30
	private void .ctor(ulong dateData) { }

	// RVA: 0x20CCA0 Offset: 0x20C0A0 VA: 0x18020CCA0
	public void .ctor(long ticks, DateTimeKind kind) { }

	// RVA: 0x20CF50 Offset: 0x20C350 VA: 0x18020CF50
	internal void .ctor(long ticks, DateTimeKind kind, bool isAmbiguousDst) { }

	// RVA: 0x20D070 Offset: 0x20C470 VA: 0x18020D070
	public void .ctor(int year, int month, int day) { }

	// RVA: 0x20CCD0 Offset: 0x20C0D0 VA: 0x18020CCD0
	public void .ctor(int year, int month, int day, int hour, int minute, int second) { }

	// RVA: 0x20CF60 Offset: 0x20C360 VA: 0x18020CF60
	public void .ctor(int year, int month, int day, int hour, int minute, int second, DateTimeKind kind) { }

	// RVA: 0x20CD70 Offset: 0x20C170 VA: 0x18020CD70
	public void .ctor(int year, int month, int day, int hour, int minute, int second, int millisecond) { }

	// RVA: 0x20D060 Offset: 0x20C460 VA: 0x18020D060
	public void .ctor(int year, int month, int day, int hour, int minute, int second, int millisecond, DateTimeKind kind) { }

	// RVA: 0x20CCB0 Offset: 0x20C0B0 VA: 0x18020CCB0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x20D200 Offset: 0x20C600 VA: 0x18020D200
	internal long get_InternalTicks() { }

	// RVA: 0x20D1E0 Offset: 0x20C5E0 VA: 0x18020D1E0
	private ulong get_InternalKind() { }

	// RVA: 0x20C0D0 Offset: 0x20B4D0 VA: 0x18020C0D0
	public DateTime Add(TimeSpan value) { }

	// RVA: 0x20C0E0 Offset: 0x20B4E0 VA: 0x18020C0E0
	private DateTime Add(double value, int scale) { }

	// RVA: 0x20BFA0 Offset: 0x20B3A0 VA: 0x18020BFA0
	public DateTime AddDays(double value) { }

	// RVA: 0x20BFC0 Offset: 0x20B3C0 VA: 0x18020BFC0
	public DateTime AddHours(double value) { }

	// RVA: 0x20BFE0 Offset: 0x20B3E0 VA: 0x18020BFE0
	public DateTime AddMilliseconds(double value) { }

	// RVA: 0x20BFF0 Offset: 0x20B3F0 VA: 0x18020BFF0
	public DateTime AddMonths(int months) { }

	// RVA: 0x20C000 Offset: 0x20B400 VA: 0x18020C000
	public DateTime AddSeconds(double value) { }

	// RVA: 0x20C020 Offset: 0x20B420 VA: 0x18020C020
	public DateTime AddTicks(long value) { }

	// RVA: 0x20C030 Offset: 0x20B430 VA: 0x18020C030
	public DateTime AddYears(int value) { }

	// RVA: 0x17A3DE0 Offset: 0x17A23E0 VA: 0x1817A3DE0
	public static int Compare(DateTime t1, DateTime t2) { }

	// RVA: 0x20C120 Offset: 0x20B520 VA: 0x18020C120 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x20C0F0 Offset: 0x20B4F0 VA: 0x18020C0F0 Slot: 24
	public int CompareTo(DateTime value) { }

	// RVA: 0x17A3E00 Offset: 0x17A2400 VA: 0x1817A3E00
	private static long DateToTicks(int year, int month, int day) { }

	// RVA: 0x17A5DB0 Offset: 0x17A43B0 VA: 0x1817A5DB0
	private static long TimeToTicks(int hour, int minute, int second) { }

	// RVA: 0x17A3FF0 Offset: 0x17A25F0 VA: 0x1817A3FF0
	public static int DaysInMonth(int year, int month) { }

	// RVA: 0x17A4150 Offset: 0x17A2750 VA: 0x1817A4150
	internal static long DoubleDateToTicks(double value) { }

	// RVA: 0x20C220 Offset: 0x20B620 VA: 0x18020C220 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x20C200 Offset: 0x20B600 VA: 0x18020C200 Slot: 25
	public bool Equals(DateTime value) { }

	// RVA: 0x17A4420 Offset: 0x17A2A20 VA: 0x1817A4420
	public static DateTime FromBinary(long dateData) { }

	// RVA: 0x17A4380 Offset: 0x17A2980 VA: 0x1817A4380
	internal static DateTime FromBinaryRaw(long dateData) { }

	// RVA: 0x17A4750 Offset: 0x17A2D50 VA: 0x1817A4750
	public static DateTime FromFileTime(long fileTime) { }

	// RVA: 0x17A4690 Offset: 0x17A2C90 VA: 0x1817A4690
	public static DateTime FromFileTimeUtc(long fileTime) { }

	// RVA: 0x17A4850 Offset: 0x17A2E50 VA: 0x1817A4850
	public static DateTime FromOADate(double d) { }

	// RVA: 0x20C480 Offset: 0x20B880 VA: 0x18020C480 Slot: 23
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17A5190 Offset: 0x17A3790 VA: 0x1817A5190
	public static DateTime SpecifyKind(DateTime value, DateTimeKind kind) { }

	// RVA: 0x20C530 Offset: 0x20B930 VA: 0x18020C530
	public long ToBinary() { }

	// RVA: 0xFC8C0 Offset: 0xFBCC0 VA: 0x1800FC8C0
	internal long ToBinaryRaw() { }

	// RVA: 0x20D0F0 Offset: 0x20C4F0 VA: 0x18020D0F0
	public DateTime get_Date() { }

	// RVA: 0x20C2B0 Offset: 0x20B6B0 VA: 0x18020C2B0
	private int GetDatePart(int part) { }

	// RVA: 0x20D180 Offset: 0x20C580 VA: 0x18020D180
	public int get_Day() { }

	// RVA: 0x20D130 Offset: 0x20C530 VA: 0x18020D130
	public DayOfWeek get_DayOfWeek() { }

	// RVA: 0x20C2C0 Offset: 0x20B6C0 VA: 0x18020C2C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20D190 Offset: 0x20C590 VA: 0x18020D190
	public int get_Hour() { }

	// RVA: 0x20D220 Offset: 0x20C620 VA: 0x18020D220
	public DateTimeKind get_Kind() { }

	// RVA: 0x20D250 Offset: 0x20C650 VA: 0x18020D250
	public int get_Millisecond() { }

	// RVA: 0x20D2A0 Offset: 0x20C6A0 VA: 0x18020D2A0
	public int get_Minute() { }

	// RVA: 0x20D2F0 Offset: 0x20C6F0 VA: 0x18020D2F0
	public int get_Month() { }

	// RVA: 0x17A7AA0 Offset: 0x17A60A0 VA: 0x1817A7AA0
	public static DateTime get_Now() { }

	// RVA: 0x17A7D20 Offset: 0x17A6320 VA: 0x1817A7D20
	public static DateTime get_UtcNow() { }

	// RVA: 0x17A4C30 Offset: 0x17A3230 VA: 0x1817A4C30
	internal static long GetSystemTimeAsFileTime() { }

	// RVA: 0x20D300 Offset: 0x20C700 VA: 0x18020D300
	public int get_Second() { }

	// RVA: 0x20D200 Offset: 0x20C600 VA: 0x18020D200
	public long get_Ticks() { }

	// RVA: 0x20D350 Offset: 0x20C750 VA: 0x18020D350
	public TimeSpan get_TimeOfDay() { }

	// RVA: 0x20D380 Offset: 0x20C780 VA: 0x18020D380
	public int get_Year() { }

	// RVA: 0x17A4C40 Offset: 0x17A3240 VA: 0x1817A4C40
	public static bool IsLeapYear(int year) { }

	// RVA: 0x17A5100 Offset: 0x17A3700 VA: 0x1817A5100
	public static DateTime Parse(string s, IFormatProvider provider) { }

	// RVA: 0x17A5050 Offset: 0x17A3650 VA: 0x1817A5050
	public static DateTime Parse(string s, IFormatProvider provider, DateTimeStyles styles) { }

	// RVA: 0x17A4D20 Offset: 0x17A3320 VA: 0x1817A4D20
	public static DateTime ParseExact(string s, string format, IFormatProvider provider) { }

	// RVA: 0x17A4F80 Offset: 0x17A3580 VA: 0x1817A4F80
	public static DateTime ParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style) { }

	// RVA: 0x17A4DD0 Offset: 0x17A33D0 VA: 0x1817A4DD0
	public static DateTime ParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style) { }

	// RVA: 0x20C2F0 Offset: 0x20B6F0 VA: 0x18020C2F0
	public TimeSpan Subtract(DateTime value) { }

	// RVA: 0x17A5C80 Offset: 0x17A4280 VA: 0x1817A5C80
	private static double TicksToOADate(long value) { }

	// RVA: 0x20C750 Offset: 0x20BB50 VA: 0x18020C750
	public double ToOADate() { }

	// RVA: 0x20C5D0 Offset: 0x20B9D0 VA: 0x18020C5D0
	public long ToFileTime() { }

	// RVA: 0x20C5C0 Offset: 0x20B9C0 VA: 0x18020C5C0
	public long ToFileTimeUtc() { }

	// RVA: 0x20C690 Offset: 0x20BA90 VA: 0x18020C690
	public DateTime ToLocalTime() { }

	// RVA: 0x20C6A0 Offset: 0x20BAA0 VA: 0x18020C6A0
	internal DateTime ToLocalTime(bool throwOnOverflow) { }

	// RVA: 0x20C6B0 Offset: 0x20BAB0 VA: 0x18020C6B0
	public string ToLongTimeString() { }

	// RVA: 0x20C8D0 Offset: 0x20BCD0 VA: 0x18020C8D0
	public string ToShortDateString() { }

	// RVA: 0x20C970 Offset: 0x20BD70 VA: 0x18020C970
	public string ToShortTimeString() { }

	// RVA: 0x20CBF0 Offset: 0x20BFF0 VA: 0x18020CBF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x20CA10 Offset: 0x20BE10 VA: 0x18020CA10
	public string ToString(string format) { }

	// RVA: 0x20CAB0 Offset: 0x20BEB0 VA: 0x18020CAB0 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x20CB50 Offset: 0x20BF50 VA: 0x18020CB50 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x20CC80 Offset: 0x20C080 VA: 0x18020CC80
	public DateTime ToUniversalTime() { }

	// RVA: 0x17A6AE0 Offset: 0x17A50E0 VA: 0x1817A6AE0
	public static bool TryParse(string s, IFormatProvider provider, DateTimeStyles styles, out DateTime result) { }

	// RVA: 0x17A6A10 Offset: 0x17A5010 VA: 0x1817A6A10
	public static bool TryParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style, out DateTime result) { }

	// RVA: 0x17A7DA0 Offset: 0x17A63A0 VA: 0x1817A7DA0
	public static DateTime op_Addition(DateTime d, TimeSpan t) { }

	// RVA: 0x17A7F20 Offset: 0x17A6520 VA: 0x1817A7F20
	public static DateTime op_Subtraction(DateTime d, TimeSpan t) { }

	// RVA: 0x17A7FE0 Offset: 0x17A65E0 VA: 0x1817A7FE0
	public static TimeSpan op_Subtraction(DateTime d1, DateTime d2) { }

	// RVA: 0x17A7E60 Offset: 0x17A6460 VA: 0x1817A7E60
	public static bool op_Equality(DateTime d1, DateTime d2) { }

	// RVA: 0x17A7EC0 Offset: 0x17A64C0 VA: 0x1817A7EC0
	public static bool op_Inequality(DateTime d1, DateTime d2) { }

	// RVA: 0x17A7F00 Offset: 0x17A6500 VA: 0x1817A7F00
	public static bool op_LessThan(DateTime t1, DateTime t2) { }

	// RVA: 0x17A7EE0 Offset: 0x17A64E0 VA: 0x1817A7EE0
	public static bool op_LessThanOrEqual(DateTime t1, DateTime t2) { }

	// RVA: 0x17A7EA0 Offset: 0x17A64A0 VA: 0x1817A7EA0
	public static bool op_GreaterThan(DateTime t1, DateTime t2) { }

	// RVA: 0x17A7E80 Offset: 0x17A6480 VA: 0x1817A7E80
	public static bool op_GreaterThanOrEqual(DateTime t1, DateTime t2) { }

	// RVA: 0x20C2E0 Offset: 0x20B6E0 VA: 0x18020C2E0 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x20C310 Offset: 0x20B710 VA: 0x18020C310 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x20C330 Offset: 0x20B730 VA: 0x18020C330 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x20C3A0 Offset: 0x20B7A0 VA: 0x18020C3A0 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x20C320 Offset: 0x20B720 VA: 0x18020C320 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x20C370 Offset: 0x20B770 VA: 0x18020C370 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x20C450 Offset: 0x20B850 VA: 0x18020C450 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x20C380 Offset: 0x20B780 VA: 0x18020C380 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x20C460 Offset: 0x20B860 VA: 0x18020C460 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x20C390 Offset: 0x20B790 VA: 0x18020C390 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x20C470 Offset: 0x20B870 VA: 0x18020C470 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x20C3B0 Offset: 0x20B7B0 VA: 0x18020C3B0 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x20C360 Offset: 0x20B760 VA: 0x18020C360 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x20C340 Offset: 0x20B740 VA: 0x18020C340 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0xFC8C0 Offset: 0xFBCC0 VA: 0x1800FC8C0 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x20C3C0 Offset: 0x20B7C0 VA: 0x18020C3C0 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x17A67C0 Offset: 0x17A4DC0 VA: 0x1817A67C0
	internal static bool TryCreate(int year, int month, int day, int hour, int minute, int second, int millisecond, out DateTime result) { }

	// RVA: 0x17A6C80 Offset: 0x17A5280 VA: 0x1817A6C80
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

	// RVA: 0x20B9B0 Offset: 0x20ADB0 VA: 0x18020B9B0
	public void .ctor(long ticks, TimeSpan offset) { }

	// RVA: 0x20BB30 Offset: 0x20AF30 VA: 0x18020BB30
	public void .ctor(DateTime dateTime) { }

	// RVA: 0x20BB20 Offset: 0x20AF20 VA: 0x18020BB20
	public void .ctor(DateTime dateTime, TimeSpan offset) { }

	// RVA: 0x17977B0 Offset: 0x1795DB0 VA: 0x1817977B0
	public static DateTimeOffset get_Now() { }

	// RVA: 0x1797950 Offset: 0x1795F50 VA: 0x181797950
	public static DateTimeOffset get_UtcNow() { }

	// RVA: 0x20BB50 Offset: 0x20AF50 VA: 0x18020BB50
	public DateTime get_DateTime() { }

	// RVA: 0x20BD70 Offset: 0x20B170 VA: 0x18020BD70
	public DateTime get_UtcDateTime() { }

	// RVA: 0x20BBF0 Offset: 0x20AFF0 VA: 0x18020BBF0
	public DateTime get_LocalDateTime() { }

	// RVA: 0x20BB40 Offset: 0x20AF40 VA: 0x18020BB40
	private DateTime get_ClockDateTime() { }

	// RVA: 0x20BB60 Offset: 0x20AF60 VA: 0x18020BB60
	public int get_Day() { }

	// RVA: 0x20BB90 Offset: 0x20AF90 VA: 0x18020BB90
	public int get_Hour() { }

	// RVA: 0x20BC20 Offset: 0x20B020 VA: 0x18020BC20
	public int get_Minute() { }

	// RVA: 0x20BC80 Offset: 0x20B080 VA: 0x18020BC80
	public int get_Month() { }

	// RVA: 0x20BCB0 Offset: 0x20B0B0 VA: 0x18020BCB0
	public TimeSpan get_Offset() { }

	// RVA: 0x20BCE0 Offset: 0x20B0E0 VA: 0x18020BCE0
	public int get_Second() { }

	// RVA: 0x20BD40 Offset: 0x20B140 VA: 0x18020BD40
	public long get_Ticks() { }

	// RVA: 0x20BD80 Offset: 0x20B180 VA: 0x18020BD80
	public int get_Year() { }

	// RVA: 0x1795AC0 Offset: 0x17940C0 VA: 0x181795AC0
	public static int Compare(DateTimeOffset first, DateTimeOffset second) { }

	// RVA: 0x20B3B0 Offset: 0x20A7B0 VA: 0x18020B3B0 Slot: 4
	private int System.IComparable.CompareTo(object obj) { }

	// RVA: 0x20B0A0 Offset: 0x20A4A0 VA: 0x18020B0A0 Slot: 8
	public int CompareTo(DateTimeOffset other) { }

	// RVA: 0x20B260 Offset: 0x20A660 VA: 0x18020B260 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x20B1C0 Offset: 0x20A5C0 VA: 0x18020B1C0 Slot: 9
	public bool Equals(DateTimeOffset other) { }

	// RVA: 0x20B570 Offset: 0x20A970 VA: 0x18020B570 Slot: 7
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x20B580 Offset: 0x20A980 VA: 0x18020B580 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x20B9C0 Offset: 0x20ADC0 VA: 0x18020B9C0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x20B380 Offset: 0x20A780 VA: 0x18020B380 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1795E10 Offset: 0x1794410 VA: 0x181795E10
	public static DateTimeOffset Parse(string input, IFormatProvider formatProvider) { }

	// RVA: 0x1796050 Offset: 0x1794650 VA: 0x181796050
	public static DateTimeOffset Parse(string input, IFormatProvider formatProvider, DateTimeStyles styles) { }

	// RVA: 0x1795CF0 Offset: 0x17942F0 VA: 0x181795CF0
	public static DateTimeOffset ParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles) { }

	// RVA: 0x20B960 Offset: 0x20AD60 VA: 0x18020B960
	public long ToUnixTimeSeconds() { }

	// RVA: 0x20B910 Offset: 0x20AD10 VA: 0x18020B910
	public long ToUnixTimeMilliseconds() { }

	// RVA: 0x20B700 Offset: 0x20AB00 VA: 0x18020B700 Slot: 3
	public override string ToString() { }

	// RVA: 0x20B620 Offset: 0x20AA20 VA: 0x18020B620
	public string ToString(IFormatProvider formatProvider) { }

	// RVA: 0x20B7E0 Offset: 0x20ABE0 VA: 0x18020B7E0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x20B8D0 Offset: 0x20ACD0 VA: 0x18020B8D0
	public DateTimeOffset ToUniversalTime() { }

	// RVA: 0x1796AB0 Offset: 0x17950B0 VA: 0x181796AB0
	public static bool TryParse(string input, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result) { }

	// RVA: 0x1796700 Offset: 0x1794D00 VA: 0x181796700
	public static bool TryParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result) { }

	// RVA: 0x1796850 Offset: 0x1794E50 VA: 0x181796850
	public static bool TryParseExact(string input, string[] formats, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result) { }

	// RVA: 0x1796DC0 Offset: 0x17953C0 VA: 0x181796DC0
	private static short ValidateOffset(TimeSpan offset) { }

	// RVA: 0x1796D00 Offset: 0x1795300 VA: 0x181796D00
	private static DateTime ValidateDate(DateTime dateTime, TimeSpan offset) { }

	// RVA: 0x1796ED0 Offset: 0x17954D0 VA: 0x181796ED0
	private static DateTimeStyles ValidateStyles(DateTimeStyles style, string parameterName) { }

	// RVA: 0x1797AD0 Offset: 0x17960D0 VA: 0x181797AD0
	public static DateTimeOffset op_Implicit(DateTime dateTime) { }

	// RVA: 0x1797B80 Offset: 0x1796180 VA: 0x181797B80
	public static TimeSpan op_Subtraction(DateTimeOffset left, DateTimeOffset right) { }

	// RVA: 0x1797A40 Offset: 0x1796040 VA: 0x181797A40
	public static bool op_Equality(DateTimeOffset left, DateTimeOffset right) { }

	// RVA: 0x1797AF0 Offset: 0x17960F0 VA: 0x181797AF0
	public static bool op_Inequality(DateTimeOffset left, DateTimeOffset right) { }

	// RVA: 0x1797000 Offset: 0x1795600 VA: 0x181797000
	private static void .cctor() { }

}

internal static class DateTimeFormat // TypeDefIndex: 225
{	// Fields
	internal static readonly TimeSpan NullOffset; // 0x0
	internal static char[] allStandardFormats; // 0x8
	internal static string[] fixedNumberFormats; // 0x10

	// Methods

	// RVA: 0x17949D0 Offset: 0x1792FD0 VA: 0x1817949D0
	internal static void FormatDigits(StringBuilder outputBuffer, int value, int len) { }

	// RVA: 0x1794A50 Offset: 0x1793050 VA: 0x181794A50
	internal static void FormatDigits(StringBuilder outputBuffer, int value, int len, bool overrideLengthLimit) { }

	// RVA: 0x1795260 Offset: 0x1793860 VA: 0x181795260
	private static void HebrewFormatDigits(StringBuilder outputBuffer, int digits) { }

	// RVA: 0x17955D0 Offset: 0x1793BD0 VA: 0x1817955D0
	internal static int ParseRepeatPattern(string format, int pos, char patternChar) { }

	// RVA: 0x1794990 Offset: 0x1792F90 VA: 0x181794990
	private static string FormatDayOfWeek(int dayOfWeek, int repeat, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1794C10 Offset: 0x1793210 VA: 0x181794C10
	private static string FormatMonth(int month, int repeatCount, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1794B50 Offset: 0x1793150 VA: 0x181794B50
	private static string FormatHebrewMonthName(DateTime time, int month, int repeatCount, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1795430 Offset: 0x1793A30 VA: 0x181795430
	internal static int ParseQuoteString(string format, int pos, StringBuilder result) { }

	// RVA: 0x17953F0 Offset: 0x17939F0 VA: 0x1817953F0
	internal static int ParseNextChar(string format, int pos) { }

	// RVA: 0x17952E0 Offset: 0x17938E0 VA: 0x1817952E0
	private static bool IsUseGenitiveForm(string format, int index, int tokenLen, char patternToMatch) { }

	// RVA: 0x17936F0 Offset: 0x1791CF0 VA: 0x1817936F0
	private static string FormatCustomized(DateTime dateTime, string format, DateTimeFormatInfo dtfi, TimeSpan offset) { }

	// RVA: 0x1793360 Offset: 0x1791960 VA: 0x181793360
	private static void FormatCustomizedTimeZone(DateTime dateTime, TimeSpan offset, string format, int tokenLen, bool timeOnly, StringBuilder result) { }

	// RVA: 0x1793130 Offset: 0x1791730 VA: 0x181793130
	private static void FormatCustomizedRoundripTimeZone(DateTime dateTime, TimeSpan offset, StringBuilder result) { }

	// RVA: 0x1794F40 Offset: 0x1793540 VA: 0x181794F40
	internal static string GetRealFormat(string format, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1792AB0 Offset: 0x17910B0 VA: 0x181792AB0
	private static string ExpandPredefinedFormat(string format, ref DateTime dateTime, ref DateTimeFormatInfo dtfi, ref TimeSpan offset) { }

	// RVA: 0x1794C50 Offset: 0x1793250 VA: 0x181794C50
	internal static string Format(DateTime dateTime, string format, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1794CE0 Offset: 0x17932E0 VA: 0x181794CE0
	internal static string Format(DateTime dateTime, string format, DateTimeFormatInfo dtfi, TimeSpan offset) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal static void InvalidFormatForLocal(string format, DateTime dateTime) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal static void InvalidFormatForUtc(string format, DateTime dateTime) { }

	// RVA: 0x1795650 Offset: 0x1793C50 VA: 0x181795650
	private static void .cctor() { }

}

internal static class DateTimeParse // TypeDefIndex: 226
{	// Fields
	internal static DateTimeParse.MatchNumberDelegate m_hebrewNumberParser; // 0x0
	private static DateTimeParse.DS[][] dateParsingStates; // 0x8

	// Methods

	// RVA: 0x179F260 Offset: 0x179D860 VA: 0x18179F260
	internal static DateTime ParseExact(string s, string format, DateTimeFormatInfo dtfi, DateTimeStyles style) { }

	// RVA: 0x179F000 Offset: 0x179D600 VA: 0x18179F000
	internal static DateTime ParseExact(string s, string format, DateTimeFormatInfo dtfi, DateTimeStyles style, out TimeSpan offset) { }

	// RVA: 0x17A1CB0 Offset: 0x17A02B0 VA: 0x1817A1CB0
	internal static bool TryParseExact(string s, string format, DateTimeFormatInfo dtfi, DateTimeStyles style, out DateTime result) { }

	// RVA: 0x17A1900 Offset: 0x179FF00 VA: 0x1817A1900
	internal static bool TryParseExact(string s, string format, DateTimeFormatInfo dtfi, DateTimeStyles style, out DateTime result, out TimeSpan offset) { }

	// RVA: 0x17A1B70 Offset: 0x17A0170 VA: 0x1817A1B70
	internal static bool TryParseExact(string s, string format, DateTimeFormatInfo dtfi, DateTimeStyles style, ref DateTimeResult result) { }

	// RVA: 0x179EED0 Offset: 0x179D4D0 VA: 0x18179EED0
	internal static DateTime ParseExactMultiple(string s, string[] formats, DateTimeFormatInfo dtfi, DateTimeStyles style) { }

	// RVA: 0x17A1770 Offset: 0x179FD70 VA: 0x1817A1770
	internal static bool TryParseExactMultiple(string s, string[] formats, DateTimeFormatInfo dtfi, DateTimeStyles style, out DateTime result, out TimeSpan offset) { }

	// RVA: 0x17A1450 Offset: 0x179FA50 VA: 0x1817A1450
	internal static bool TryParseExactMultiple(string s, string[] formats, DateTimeFormatInfo dtfi, DateTimeStyles style, ref DateTimeResult result) { }

	// RVA: 0x179D4B0 Offset: 0x179BAB0 VA: 0x18179D4B0
	private static bool MatchWord(ref __DTString str, string target) { }

	// RVA: 0x179B6E0 Offset: 0x1799CE0 VA: 0x18179B6E0
	private static bool GetTimeZoneName(ref __DTString str) { }

	// RVA: 0x179BC60 Offset: 0x179A260 VA: 0x18179BC60
	internal static bool IsDigit(char ch) { }

	// RVA: 0x179F5B0 Offset: 0x179DBB0 VA: 0x18179F5B0
	private static bool ParseFraction(ref __DTString str, out double result) { }

	// RVA: 0x17A0090 Offset: 0x179E690 VA: 0x1817A0090
	private static bool ParseTimeZone(ref __DTString str, ref TimeSpan result) { }

	// RVA: 0x179BB00 Offset: 0x179A100 VA: 0x18179BB00
	private static bool HandleTimeZone(ref __DTString str, ref DateTimeResult result) { }

	// RVA: 0x179BC80 Offset: 0x179A280 VA: 0x18179BC80
	private static bool Lex(DateTimeParse.DS dps, ref __DTString str, ref DateTimeToken dtok, ref DateTimeRawInfo raw, ref DateTimeResult result, ref DateTimeFormatInfo dtfi, DateTimeStyles styles) { }

	// RVA: 0x17A2B40 Offset: 0x17A1140 VA: 0x1817A2B40
	private static bool VerifyValidPunctuation(ref __DTString str) { }

	// RVA: 0x179B780 Offset: 0x1799D80 VA: 0x18179B780
	private static bool GetYearMonthDayOrder(string datePattern, DateTimeFormatInfo dtfi, out int order) { }

	// RVA: 0x179B9B0 Offset: 0x1799FB0 VA: 0x18179B9B0
	private static bool GetYearMonthOrder(string pattern, DateTimeFormatInfo dtfi, out int order) { }

	// RVA: 0x179B390 Offset: 0x1799990 VA: 0x18179B390
	private static bool GetMonthDayOrder(string pattern, DateTimeFormatInfo dtfi, out int order) { }

	// RVA: 0x17A13A0 Offset: 0x179F9A0 VA: 0x1817A13A0
	private static bool TryAdjustYear(ref DateTimeResult result, int year, out int adjustedYear) { }

	// RVA: 0x17A1320 Offset: 0x179F920 VA: 0x1817A1320
	private static bool SetDateYMD(ref DateTimeResult result, int year, int month, int day) { }

	// RVA: 0x17A11A0 Offset: 0x179F7A0 VA: 0x1817A11A0
	private static bool SetDateMDY(ref DateTimeResult result, int month, int day, int year) { }

	// RVA: 0x17A10E0 Offset: 0x179F6E0 VA: 0x1817A10E0
	private static bool SetDateDMY(ref DateTimeResult result, int day, int month, int year) { }

	// RVA: 0x17A1260 Offset: 0x179F860 VA: 0x1817A1260
	private static bool SetDateYDM(ref DateTimeResult result, int year, int day, int month) { }

	// RVA: 0x179B170 Offset: 0x1799770 VA: 0x18179B170
	private static void GetDefaultYear(ref DateTimeResult result, ref DateTimeStyles styles) { }

	// RVA: 0x179AA70 Offset: 0x1799070 VA: 0x18179AA70
	private static bool GetDayOfNN(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x179A3D0 Offset: 0x17989D0 VA: 0x18179A3D0
	private static bool GetDayOfNNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1799EB0 Offset: 0x17984B0 VA: 0x181799EB0
	private static bool GetDayOfMN(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x179B210 Offset: 0x1799810 VA: 0x18179B210
	private static bool GetHebrewDayOfNM(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x179A140 Offset: 0x1798740 VA: 0x18179A140
	private static bool GetDayOfNM(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1799AA0 Offset: 0x17980A0 VA: 0x181799AA0
	private static bool GetDayOfMNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x179AE90 Offset: 0x1799490 VA: 0x18179AE90
	private static bool GetDayOfYNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x179A890 Offset: 0x1798E90 VA: 0x18179A890
	private static bool GetDayOfNNY(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x179AC50 Offset: 0x1799250 VA: 0x18179AC50
	private static bool GetDayOfYMN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x179B030 Offset: 0x1799630 VA: 0x18179B030
	private static bool GetDayOfYN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x179AD50 Offset: 0x1799350 VA: 0x18179AD50
	private static bool GetDayOfYM(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1797C50 Offset: 0x1796250 VA: 0x181797C50
	private static void AdjustTimeMark(DateTimeFormatInfo dtfi, ref DateTimeRawInfo raw) { }

	// RVA: 0x1797C10 Offset: 0x1796210 VA: 0x181797C10
	private static bool AdjustHour(ref int hour, DateTimeParse.TM timeMark) { }

	// RVA: 0x179B650 Offset: 0x1799C50 VA: 0x18179B650
	private static bool GetTimeOfN(DateTimeFormatInfo dtfi, ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x179B5C0 Offset: 0x1799BC0 VA: 0x18179B5C0
	private static bool GetTimeOfNN(DateTimeFormatInfo dtfi, ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x179B520 Offset: 0x1799B20 VA: 0x18179B520
	private static bool GetTimeOfNNN(DateTimeFormatInfo dtfi, ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x1799350 Offset: 0x1797950 VA: 0x181799350
	private static bool GetDateOfDSN(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x17993E0 Offset: 0x17979E0 VA: 0x1817993E0
	private static bool GetDateOfNDS(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x17994A0 Offset: 0x1797AA0 VA: 0x1817994A0
	private static bool GetDateOfNNDS(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x17A05F0 Offset: 0x179EBF0 VA: 0x1817A05F0
	private static bool ProcessDateTimeSuffix(ref DateTimeResult result, ref DateTimeRawInfo raw, ref DateTimeToken dtok) { }

	// RVA: 0x17A06D0 Offset: 0x179ECD0 VA: 0x1817A06D0
	internal static bool ProcessHebrewTerminalState(DateTimeParse.DS dps, ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x17A0B50 Offset: 0x179F150 VA: 0x1817A0B50
	internal static bool ProcessTerminaltState(DateTimeParse.DS dps, ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x17A03A0 Offset: 0x179E9A0 VA: 0x1817A03A0
	internal static DateTime Parse(string s, DateTimeFormatInfo dtfi, DateTimeStyles styles) { }

	// RVA: 0x17A04C0 Offset: 0x179EAC0 VA: 0x1817A04C0
	internal static DateTime Parse(string s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out TimeSpan offset) { }

	// RVA: 0x17A2890 Offset: 0x17A0E90 VA: 0x1817A2890
	internal static bool TryParse(string s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out DateTime result) { }

	// RVA: 0x17A29C0 Offset: 0x17A0FC0 VA: 0x1817A29C0
	internal static bool TryParse(string s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out DateTime result, out TimeSpan offset) { }

	// RVA: 0x17A1FA0 Offset: 0x17A05A0 VA: 0x1817A1FA0
	internal static bool TryParse(string s, DateTimeFormatInfo dtfi, DateTimeStyles styles, ref DateTimeResult result) { }

	// RVA: 0x1798480 Offset: 0x1796A80 VA: 0x181798480
	private static bool DetermineTimeZoneAdjustments(ref DateTimeResult result, DateTimeStyles styles, bool bTimeOnly) { }

	// RVA: 0x1798280 Offset: 0x1796880 VA: 0x181798280
	private static bool DateTimeOffsetTimeZonePostProcessing(ref DateTimeResult result, DateTimeStyles styles) { }

	// RVA: 0x1797EE0 Offset: 0x17964E0 VA: 0x181797EE0
	private static bool AdjustTimeZoneToUniversal(ref DateTimeResult result) { }

	// RVA: 0x1797CC0 Offset: 0x17962C0 VA: 0x181797CC0
	private static bool AdjustTimeZoneToLocal(ref DateTimeResult result, bool bTimeOnly) { }

	// RVA: 0x179F690 Offset: 0x179DC90 VA: 0x18179F690
	private static bool ParseISO8601(ref DateTimeRawInfo raw, ref __DTString str, DateTimeStyles styles, ref DateTimeResult result) { }

	// RVA: 0x179D130 Offset: 0x179B730 VA: 0x18179D130
	internal static bool MatchHebrewDigits(ref __DTString str, int digitLen, out int number) { }

	// RVA: 0x179ECF0 Offset: 0x179D2F0 VA: 0x18179ECF0
	internal static bool ParseDigits(ref __DTString str, int digitLen, out int result) { }

	// RVA: 0x179EE20 Offset: 0x179D420 VA: 0x18179EE20
	internal static bool ParseDigits(ref __DTString str, int minDigitLen, int maxDigitLen, out int result) { }

	// RVA: 0x179F470 Offset: 0x179DA70 VA: 0x18179F470
	private static bool ParseFractionExact(ref __DTString str, int maxDigitLen, ref double result) { }

	// RVA: 0x179FCB0 Offset: 0x179E2B0 VA: 0x18179FCB0
	private static bool ParseSign(ref __DTString str, ref bool result) { }

	// RVA: 0x179FD10 Offset: 0x179E310 VA: 0x18179FD10
	private static bool ParseTimeZoneOffset(ref __DTString str, int len, ref TimeSpan result) { }

	// RVA: 0x179CCC0 Offset: 0x179B2C0 VA: 0x18179CCC0
	private static bool MatchAbbreviatedMonthName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	// RVA: 0x179D210 Offset: 0x179B810 VA: 0x18179D210
	private static bool MatchMonthName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	// RVA: 0x179CBE0 Offset: 0x179B1E0 VA: 0x18179CBE0
	private static bool MatchAbbreviatedDayName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	// RVA: 0x179CED0 Offset: 0x179B4D0 VA: 0x18179CED0
	private static bool MatchDayName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	// RVA: 0x179CFB0 Offset: 0x179B5B0 VA: 0x18179CFB0
	private static bool MatchEraName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	// RVA: 0x179D3A0 Offset: 0x179B9A0 VA: 0x18179D3A0
	private static bool MatchTimeMark(ref __DTString str, DateTimeFormatInfo dtfi, ref DateTimeParse.TM result) { }

	// RVA: 0x179CE20 Offset: 0x179B420 VA: 0x18179CE20
	private static bool MatchAbbreviatedTimeMark(ref __DTString str, DateTimeFormatInfo dtfi, ref DateTimeParse.TM result) { }

	// RVA: 0x17981D0 Offset: 0x17967D0 VA: 0x1817981D0
	private static bool CheckNewValue(ref int currentValue, int newValue, char patternChar, ref DateTimeResult result) { }

	// RVA: 0x1799740 Offset: 0x1797D40 VA: 0x181799740
	private static DateTime GetDateTimeNow(ref DateTimeResult result, ref DateTimeStyles styles) { }

	// RVA: 0x1797FA0 Offset: 0x17965A0 VA: 0x181797FA0
	private static bool CheckDefaultDateTime(ref DateTimeResult result, ref Calendar cal, DateTimeStyles styles) { }

	// RVA: 0x1798CB0 Offset: 0x17972B0 VA: 0x181798CB0
	private static string ExpandPredefinedFormat(string format, ref DateTimeFormatInfo dtfi, ref ParsingInfo parseInfo, ref DateTimeResult result) { }

	// RVA: 0x179D5F0 Offset: 0x179BBF0 VA: 0x18179D5F0
	private static bool ParseByFormat(ref __DTString str, ref __DTString format, ref ParsingInfo parseInfo, DateTimeFormatInfo dtfi, ref DateTimeResult result) { }

	// RVA: 0x17A1ED0 Offset: 0x17A04D0 VA: 0x1817A1ED0
	internal static bool TryParseQuoteString(string format, int pos, StringBuilder result, out int returnValue) { }

	// RVA: 0x1798680 Offset: 0x1796C80 VA: 0x181798680
	private static bool DoStrictParse(string s, string formatParam, DateTimeStyles styles, DateTimeFormatInfo dtfi, ref DateTimeResult result) { }

	// RVA: 0x17998B0 Offset: 0x1797EB0 VA: 0x1817998B0
	private static Exception GetDateTimeParseException(ref DateTimeResult result) { }

	// RVA: 0x17A2CB0 Offset: 0x17A12B0 VA: 0x1817A2CB0
	private static void .cctor() { }

}

internal sealed class DateTimeParse.MatchNumberDelegate : MulticastDelegate // TypeDefIndex: 227
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x17AAAE0 Offset: 0x17A90E0 VA: 0x1817AAAE0 Slot: 12
	public virtual bool Invoke(ref __DTString str, int digitLen, out int result) { }

	// RVA: 0x17AAA30 Offset: 0x17A9030 VA: 0x1817AAA30 Slot: 13
	public virtual IAsyncResult BeginInvoke(ref __DTString str, int digitLen, out int result, AsyncCallback callback, object object) { }

	// RVA: 0x175F010 Offset: 0x175D610 VA: 0x18175F010 Slot: 14
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

	// RVA: 0x20BDE0 Offset: 0x20B1E0 VA: 0x18020BDE0
	internal void Init(int* numberBuffer) { }

	// RVA: 0x20BDB0 Offset: 0x20B1B0 VA: 0x18020BDB0
	internal void AddNumber(int value) { }

	// RVA: 0x20BDD0 Offset: 0x20B1D0 VA: 0x18020BDD0
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

	// RVA: 0x20BEB0 Offset: 0x20B2B0 VA: 0x18020BEB0
	internal void Init() { }

	// RVA: 0x20BEE0 Offset: 0x20B2E0 VA: 0x18020BEE0
	internal void SetDate(int year, int month, int day) { }

	// RVA: 0x20BEF0 Offset: 0x20B2F0 VA: 0x18020BEF0
	internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) { }

	// RVA: 0x20BF30 Offset: 0x20B330 VA: 0x18020BF30
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
	[OptionalFieldAttribute] // RVA: 0x92F70 Offset: 0x92370 VA: 0x180092F70
	internal string m_name; // 0x18
	private string m_langName; // 0x20
	private CompareInfo m_compareInfo; // 0x28
	private CultureInfo m_cultureInfo; // 0x30
	internal string amDesignator; // 0x38
	internal string pmDesignator; // 0x40
	[OptionalFieldAttribute] // RVA: 0x96510 Offset: 0x95910 VA: 0x180096510
	internal string dateSeparator; // 0x48
	[OptionalFieldAttribute] // RVA: 0x96510 Offset: 0x95910 VA: 0x180096510
	internal string generalShortTimePattern; // 0x50
	[OptionalFieldAttribute] // RVA: 0x96510 Offset: 0x95910 VA: 0x180096510
	internal string generalLongTimePattern; // 0x58
	[OptionalFieldAttribute] // RVA: 0x96510 Offset: 0x95910 VA: 0x180096510
	internal string timeSeparator; // 0x60
	internal string monthDayPattern; // 0x68
	[OptionalFieldAttribute] // RVA: 0x92F70 Offset: 0x92370 VA: 0x180092F70
	internal string dateTimeOffsetPattern; // 0x70
	internal const string rfc1123Pattern = "ddd, dd MMM yyyy HH\':\'mm\':\'ss \'GMT\'";
	internal const string sortableDateTimePattern = "yyyy\'-\'MM\'-\'dd\'T\'HH\':\'mm\':\'ss";
	internal const string universalSortableDateTimePattern = "yyyy\'-\'MM\'-\'dd HH\':\'mm\':\'ss\'Z\'";
	internal Calendar calendar; // 0x78
	internal int firstDayOfWeek; // 0x80
	internal int calendarWeekRule; // 0x84
	[OptionalFieldAttribute] // RVA: 0x96510 Offset: 0x95910 VA: 0x180096510
	internal string fullDateTimePattern; // 0x88
	internal string[] abbreviatedDayNames; // 0x90
	[OptionalFieldAttribute] // RVA: 0x92F70 Offset: 0x92370 VA: 0x180092F70
	internal string[] m_superShortDayNames; // 0x98
	internal string[] dayNames; // 0xA0
	internal string[] abbreviatedMonthNames; // 0xA8
	internal string[] monthNames; // 0xB0
	[OptionalFieldAttribute] // RVA: 0x92F70 Offset: 0x92370 VA: 0x180092F70
	internal string[] genitiveMonthNames; // 0xB8
	[OptionalFieldAttribute] // RVA: 0x92F70 Offset: 0x92370 VA: 0x180092F70
	internal string[] m_genitiveAbbreviatedMonthNames; // 0xC0
	[OptionalFieldAttribute] // RVA: 0x92F70 Offset: 0x92370 VA: 0x180092F70
	internal string[] leapYearMonthNames; // 0xC8
	internal string longDatePattern; // 0xD0
	internal string shortDatePattern; // 0xD8
	internal string yearMonthPattern; // 0xE0
	internal string longTimePattern; // 0xE8
	internal string shortTimePattern; // 0xF0
	[OptionalFieldAttribute] // RVA: 0xA9B30 Offset: 0xA8F30 VA: 0x1800A9B30
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
	[OptionalFieldAttribute] // RVA: 0x92F70 Offset: 0x92370 VA: 0x180092F70
	internal DateTimeFormatFlags formatFlags; // 0x144
	internal static bool preferExistingTokens; // 0x8
	[OptionalFieldAttribute] // RVA: 0x96510 Offset: 0x95910 VA: 0x180096510
	private int CultureID; // 0x148
	[OptionalFieldAttribute] // RVA: 0x96510 Offset: 0x95910 VA: 0x180096510
	private bool m_useUserOverride; // 0x14C
	[OptionalFieldAttribute] // RVA: 0x96510 Offset: 0x95910 VA: 0x180096510
	private bool bUseCalendarInfo; // 0x14D
	[OptionalFieldAttribute] // RVA: 0x96510 Offset: 0x95910 VA: 0x180096510
	private int nDataItem; // 0x150
	[OptionalFieldAttribute] // RVA: 0x92F70 Offset: 0x92370 VA: 0x180092F70
	internal bool m_isDefaultCalendar; // 0x154
	[OptionalFieldAttribute] // RVA: 0x92F70 Offset: 0x92370 VA: 0x180092F70
	private static Hashtable s_calendarNativeNames; // 0x10
	[OptionalFieldAttribute] // RVA: 0x96510 Offset: 0x95910 VA: 0x180096510
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
	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
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

	// RVA: 0x16E51B0 Offset: 0x16E37B0 VA: 0x1816E51B0
	private string get_CultureName() { }

	// RVA: 0x16E51F0 Offset: 0x16E37F0 VA: 0x1816E51F0
	private CultureInfo get_Culture() { }

	// RVA: 0x16E63B0 Offset: 0x16E49B0 VA: 0x1816E63B0
	private string get_LanguageName() { }

	// RVA: 0x16E6AF0 Offset: 0x16E50F0 VA: 0x1816E6AF0
	private string[] internalGetAbbreviatedDayOfWeekNames() { }

	// RVA: 0x16E6BD0 Offset: 0x16E51D0 VA: 0x1816E6BD0
	private string[] internalGetDayOfWeekNames() { }

	// RVA: 0x16E6B60 Offset: 0x16E5160 VA: 0x1816E6B60
	private string[] internalGetAbbreviatedMonthNames() { }

	// RVA: 0x16E6FD0 Offset: 0x16E55D0 VA: 0x1816E6FD0
	private string[] internalGetMonthNames() { }

	// RVA: 0x16E4920 Offset: 0x16E2F20 VA: 0x1816E4920
	public void .ctor() { }

	// RVA: 0x16E4A50 Offset: 0x16E3050 VA: 0x1816E4A50
	internal void .ctor(CultureData cultureData, Calendar cal) { }

	// RVA: 0x16E2D70 Offset: 0x16E1370 VA: 0x1816E2D70
	private void InitializeOverridableProperties(CultureData cultureData, int calendarID) { }

	[OnDeserializedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x16E3600 Offset: 0x16E1C00 VA: 0x1816E3600
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x16E3DE0 Offset: 0x16E23E0 VA: 0x1816E3DE0
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x16E6170 Offset: 0x16E4770 VA: 0x1816E6170
	public static DateTimeFormatInfo get_InvariantInfo() { }

	// RVA: 0x16E52B0 Offset: 0x16E38B0 VA: 0x1816E52B0
	public static DateTimeFormatInfo get_CurrentInfo() { }

	// RVA: 0x16E2490 Offset: 0x16E0A90 VA: 0x1816E2490
	public static DateTimeFormatInfo GetInstance(IFormatProvider provider) { }

	// RVA: 0x16E2400 Offset: 0x16E0A00 VA: 0x1816E2400 Slot: 5
	public object GetFormat(Type formatType) { }

	// RVA: 0x16E0220 Offset: 0x16DE820 VA: 0x1816E0220 Slot: 4
	public object Clone() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public string get_AMDesignator() { }

	// RVA: 0x4E8520 Offset: 0x4E6B20 VA: 0x1804E8520
	public Calendar get_Calendar() { }

	// RVA: 0x16E7040 Offset: 0x16E5640 VA: 0x1816E7040
	public void set_Calendar(Calendar value) { }

	// RVA: 0x16E66C0 Offset: 0x16E4CC0 VA: 0x1816E66C0
	private int[] get_OptionalCalendars() { }

	// RVA: 0x16E56C0 Offset: 0x16E3CC0 VA: 0x1816E56C0
	internal string[] get_EraNames() { }

	// RVA: 0x16E22A0 Offset: 0x16E08A0 VA: 0x1816E22A0
	public string GetEraName(int era) { }

	// RVA: 0x16E4BA0 Offset: 0x16E31A0 VA: 0x1816E4BA0
	internal string[] get_AbbreviatedEraNames() { }

	// RVA: 0x16E17E0 Offset: 0x16DFDE0 VA: 0x1816E17E0
	public string GetAbbreviatedEraName(int era) { }

	// RVA: 0x16E4B30 Offset: 0x16E3130 VA: 0x1816E4B30
	internal string[] get_AbbreviatedEnglishEraNames() { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public string get_DateSeparator() { }

	// RVA: 0x16E5C40 Offset: 0x16E4240 VA: 0x1816E5C40
	public string get_FullDateTimePattern() { }

	// RVA: 0x16E63F0 Offset: 0x16E49F0 VA: 0x1816E63F0
	public string get_LongDatePattern() { }

	// RVA: 0x16E7440 Offset: 0x16E5A40 VA: 0x1816E7440
	public void set_LongDatePattern(string value) { }

	// RVA: 0x16E6450 Offset: 0x16E4A50 VA: 0x1816E6450
	public string get_LongTimePattern() { }

	// RVA: 0x16E7550 Offset: 0x16E5B50 VA: 0x1816E7550
	public void set_LongTimePattern(string value) { }

	// RVA: 0x16E64F0 Offset: 0x16E4AF0 VA: 0x1816E64F0
	public string get_MonthDayPattern() { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public string get_PMDesignator() { }

	// RVA: 0x16E6710 Offset: 0x16E4D10 VA: 0x1816E6710
	public string get_RFC1123Pattern() { }

	// RVA: 0x16E6740 Offset: 0x16E4D40 VA: 0x1816E6740
	public string get_ShortDatePattern() { }

	// RVA: 0x16E7680 Offset: 0x16E5C80 VA: 0x1816E7680
	public void set_ShortDatePattern(string value) { }

	// RVA: 0x16E67A0 Offset: 0x16E4DA0 VA: 0x1816E67A0
	public string get_ShortTimePattern() { }

	// RVA: 0x16E77B0 Offset: 0x16E5DB0 VA: 0x1816E77B0
	public void set_ShortTimePattern(string value) { }

	// RVA: 0x16E6840 Offset: 0x16E4E40 VA: 0x1816E6840
	public string get_SortableDateTimePattern() { }

	// RVA: 0x16E5FF0 Offset: 0x16E45F0 VA: 0x1816E5FF0
	internal string get_GeneralShortTimePattern() { }

	// RVA: 0x16E5F10 Offset: 0x16E4510 VA: 0x1816E5F10
	internal string get_GeneralLongTimePattern() { }

	// RVA: 0x16E53B0 Offset: 0x16E39B0 VA: 0x1816E53B0
	internal string get_DateTimeOffsetPattern() { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public string get_TimeSeparator() { }

	// RVA: 0x16E6A60 Offset: 0x16E5060 VA: 0x1816E6A60
	public string get_UniversalSortableDateTimePattern() { }

	// RVA: 0x16E6A90 Offset: 0x16E5090 VA: 0x1816E6A90
	public string get_YearMonthPattern() { }

	// RVA: 0x16E78C0 Offset: 0x16E5EC0 VA: 0x1816E78C0
	public void set_YearMonthPattern(string value) { }

	// RVA: 0x16E4AB0 Offset: 0x16E30B0 VA: 0x1816E4AB0
	public string[] get_AbbreviatedDayNames() { }

	// RVA: 0x16E5640 Offset: 0x16E3C40 VA: 0x1816E5640
	public string[] get_DayNames() { }

	// RVA: 0x16E4C10 Offset: 0x16E3210 VA: 0x1816E4C10
	public string[] get_AbbreviatedMonthNames() { }

	// RVA: 0x16E6640 Offset: 0x16E4C40 VA: 0x1816E6640
	public string[] get_MonthNames() { }

	// RVA: 0x16E6130 Offset: 0x16E4730 VA: 0x1816E6130
	internal bool get_HasSpacesInMonthNames() { }

	// RVA: 0x16E6110 Offset: 0x16E4710 VA: 0x1816E6110
	internal bool get_HasSpacesInDayNames() { }

	// RVA: 0x16E6DB0 Offset: 0x16E53B0 VA: 0x1816E6DB0
	internal string internalGetMonthName(int month, MonthNameStyles style, bool abbreviated) { }

	// RVA: 0x16E6C40 Offset: 0x16E5240 VA: 0x1816E6C40
	private string[] internalGetGenitiveMonthNames(bool abbreviated) { }

	// RVA: 0x16E6D30 Offset: 0x16E5330 VA: 0x1816E6D30
	internal string[] internalGetLeapYearMonthNames() { }

	// RVA: 0x16E1690 Offset: 0x16DFC90 VA: 0x1816E1690
	public string GetAbbreviatedDayName(DayOfWeek dayofweek) { }

	// RVA: 0x16E1FE0 Offset: 0x16E05E0 VA: 0x1816E1FE0
	private static string[] GetCombinedPatterns(string[] patterns1, string[] patterns2, string connectString) { }

	// RVA: 0x16E1AC0 Offset: 0x16E00C0 VA: 0x1816E1AC0
	public string[] GetAllDateTimePatterns(char format) { }

	// RVA: 0x16E2150 Offset: 0x16E0750 VA: 0x1816E2150
	public string GetDayName(DayOfWeek dayofweek) { }

	// RVA: 0x16E1960 Offset: 0x16DFF60 VA: 0x1816E1960
	public string GetAbbreviatedMonthName(int month) { }

	// RVA: 0x16E2AD0 Offset: 0x16E10D0 VA: 0x1816E2AD0
	public string GetMonthName(int month) { }

	// RVA: 0x16E2850 Offset: 0x16E0E50 VA: 0x1816E2850
	private static string[] GetMergedPatterns(string[] patterns, string defaultPattern) { }

	// RVA: 0x16E4FD0 Offset: 0x16E35D0 VA: 0x1816E4FD0
	private string[] get_AllYearMonthPatterns() { }

	// RVA: 0x16E4E30 Offset: 0x16E3430 VA: 0x1816E4E30
	private string[] get_AllShortDatePatterns() { }

	// RVA: 0x16E4F10 Offset: 0x16E3510 VA: 0x1816E4F10
	private string[] get_AllShortTimePatterns() { }

	// RVA: 0x16E4C90 Offset: 0x16E3290 VA: 0x1816E4C90
	private string[] get_AllLongDatePatterns() { }

	// RVA: 0x16E4D70 Offset: 0x16E3370 VA: 0x1816E4D70
	private string[] get_AllLongTimePatterns() { }

	// RVA: 0x16E69F0 Offset: 0x16E4FF0 VA: 0x1816E69F0
	private string[] get_UnclonedYearMonthPatterns() { }

	// RVA: 0x16E6930 Offset: 0x16E4F30 VA: 0x1816E6930
	private string[] get_UnclonedShortDatePatterns() { }

	// RVA: 0x16E6870 Offset: 0x16E4E70 VA: 0x1816E6870
	private string[] get_UnclonedLongDatePatterns() { }

	// RVA: 0x16E69A0 Offset: 0x16E4FA0 VA: 0x1816E69A0
	private string[] get_UnclonedShortTimePatterns() { }

	// RVA: 0x16E68E0 Offset: 0x16E4EE0 VA: 0x1816E68E0
	private string[] get_UnclonedLongTimePatterns() { }

	// RVA: 0x16E63A0 Offset: 0x16E49A0 VA: 0x1816E63A0
	public bool get_IsReadOnly() { }

	// RVA: 0x16E6560 Offset: 0x16E4B60 VA: 0x1816E6560
	public string[] get_MonthGenitiveNames() { }

	// RVA: 0x16E5E50 Offset: 0x16E4450 VA: 0x1816E5E50
	internal string get_FullTimeSpanPositivePattern() { }

	// RVA: 0x16E5D30 Offset: 0x16E4330 VA: 0x1816E5D30
	internal string get_FullTimeSpanNegativePattern() { }

	// RVA: 0x16E50B0 Offset: 0x16E36B0 VA: 0x1816E50B0
	internal CompareInfo get_CompareInfo() { }

	// RVA: 0x16E46A0 Offset: 0x16E2CA0 VA: 0x1816E46A0
	internal static void ValidateStyles(DateTimeStyles style, string parameterName) { }

	// RVA: 0x16E5730 Offset: 0x16E3D30 VA: 0x1816E5730
	internal DateTimeFormatFlags get_FormatFlags() { }

	// RVA: 0x16E60D0 Offset: 0x16E46D0 VA: 0x1816E60D0
	internal bool get_HasForceTwoDigitYears() { }

	// RVA: 0x16E6150 Offset: 0x16E4750 VA: 0x1816E6150
	internal bool get_HasYearMonthAdjustment() { }

	// RVA: 0x16E47C0 Offset: 0x16E2DC0 VA: 0x1816E47C0
	internal bool YearMonthAdjustment(ref int year, ref int month, bool parsedMonthName) { }

	// RVA: 0x16E2710 Offset: 0x16E0D10 VA: 0x1816E2710
	internal static DateTimeFormatInfo GetJapaneseCalendarDTFI() { }

	// RVA: 0x16E2C30 Offset: 0x16E1230 VA: 0x1816E2C30
	internal static DateTimeFormatInfo GetTaiwanCalendarDTFI() { }

	// RVA: 0x16E01F0 Offset: 0x16DE7F0 VA: 0x1816E01F0
	private void ClearTokenHashTable() { }

	// RVA: 0x16E0320 Offset: 0x16DE920 VA: 0x1816E0320
	internal TokenHashValue[] CreateTokenHashTable() { }

	// RVA: 0x16E0120 Offset: 0x16DE720 VA: 0x1816E0120
	private void AddMonthNames(TokenHashValue[] temp, string monthPostfix) { }

	// RVA: 0x16E4480 Offset: 0x16E2A80 VA: 0x1816E4480
	private static bool TryParseHebrewNumber(ref __DTString str, out bool badFormat, out int number) { }

	// RVA: 0x16E35E0 Offset: 0x16E1BE0 VA: 0x1816E35E0
	private static bool IsHebrewChar(char ch) { }

	// RVA: 0x16E4030 Offset: 0x16E2630 VA: 0x1816E4030
	internal bool Tokenize(TokenType TokenMask, out TokenType tokenType, out int tokenValue, ref __DTString str) { }

	// RVA: 0x16E2FA0 Offset: 0x16E15A0 VA: 0x1816E2FA0
	private void InsertAtCurrentHashNode(TokenHashValue[] hashTable, string str, char ch, TokenType tokenType, int tokenValue, int pos, int hashcode, int hashProbe) { }

	// RVA: 0x16E31F0 Offset: 0x16E17F0 VA: 0x1816E31F0
	private void InsertHash(TokenHashValue[] hashTable, string str, TokenType tokenType, int tokenValue) { }

	// RVA: 0x16E48E0 Offset: 0x16E2EE0 VA: 0x1816E48E0
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

	// RVA: 0x16DFE00 Offset: 0x16DE400 VA: 0x1816DFE00
	private static Dictionary<string, string> get_KnownWords() { }

	// RVA: 0x16DFCC0 Offset: 0x16DE2C0 VA: 0x1816DFCC0
	internal static int SkipWhiteSpacesAndNonLetter(string pattern, int currentIndex) { }

	// RVA: 0x16DEB20 Offset: 0x16DD120 VA: 0x1816DEB20
	internal void AddDateWordOrPostfix(string formatPostfix, string str) { }

	// RVA: 0x16DECF0 Offset: 0x16DD2F0 VA: 0x1816DECF0
	internal int AddDateWords(string pattern, int index, string formatPostfix) { }

	// RVA: 0x16DFC50 Offset: 0x16DE250 VA: 0x1816DFC50
	internal static int ScanRepeatChar(string pattern, char ch, int index, out int count) { }

	// RVA: 0x16DEF20 Offset: 0x16DD520 VA: 0x1816DEF20
	internal void AddIgnorableSymbols(string text) { }

	// RVA: 0x16DFA10 Offset: 0x16DE010 VA: 0x1816DFA10
	internal void ScanDateWord(string pattern) { }

	// RVA: 0x16DF430 Offset: 0x16DDA30 VA: 0x1816DF430
	internal string[] GetDateWordsOfDTFI(DateTimeFormatInfo dtfi) { }

	// RVA: 0x16DF7B0 Offset: 0x16DDDB0 VA: 0x1816DF7B0
	internal static FORMATFLAGS GetFormatFlagGenitiveMonth(string[] monthNames, string[] genitveMonthNames, string[] abbrevMonthNames, string[] genetiveAbbrevMonthNames) { }

	// RVA: 0x16DF950 Offset: 0x16DDF50 VA: 0x1816DF950
	internal static FORMATFLAGS GetFormatFlagUseSpaceInMonthNames(string[] monthNames, string[] genitveMonthNames, string[] abbrevMonthNames, string[] genetiveAbbrevMonthNames) { }

	// RVA: 0x16DF910 Offset: 0x16DDF10 VA: 0x1816DF910
	internal static FORMATFLAGS GetFormatFlagUseSpaceInDayNames(string[] dayNames, string[] abbrevDayNames) { }

	// RVA: 0x16DF900 Offset: 0x16DDF00 VA: 0x1816DF900
	internal static FORMATFLAGS GetFormatFlagUseHebrewCalendar(int calID) { }

	// RVA: 0x16DF370 Offset: 0x16DD970 VA: 0x1816DF370
	private static bool EqualStringArrays(string[] array1, string[] array2) { }

	// RVA: 0x16DF290 Offset: 0x16DD890 VA: 0x1816DF290
	private static bool ArrayElementsHaveSpace(string[] array) { }

	// RVA: 0x16DEFF0 Offset: 0x16DD5F0 VA: 0x1816DEFF0
	private static bool ArrayElementsBeginWithDigit(string[] array) { }

	// RVA: 0x16DFD90 Offset: 0x16DE390 VA: 0x1816DFD90
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

	// RVA: 0xFE5CA0 Offset: 0xFE42A0 VA: 0x180FE5CA0 Slot: 7
	public override object get_Value() { }

}

internal sealed class DateTimeTypeInfo : TraceLoggingTypeInfo<DateTime> // TypeDefIndex: 1571
{	// Methods

	// RVA: 0xD69450 Offset: 0xD67A50 VA: 0x180D69450 Slot: 4
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

	// RVA: 0xD69400 Offset: 0xD67A00 VA: 0x180D69400 Slot: 7
	public override void WriteData(TraceLoggingDataCollector collector, ref DateTime value) { }

	// RVA: 0xD694E0 Offset: 0xD67AE0 VA: 0x180D694E0
	public void .ctor() { }

}

internal sealed class DateTimeOffsetTypeInfo : TraceLoggingTypeInfo<DateTimeOffset> // TypeDefIndex: 1572
{	// Methods

	// RVA: 0xD69300 Offset: 0xD67900 VA: 0x180D69300 Slot: 4
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

	// RVA: 0xD69280 Offset: 0xD67880 VA: 0x180D69280 Slot: 7
	public override void WriteData(TraceLoggingDataCollector collector, ref DateTimeOffset value) { }

	// RVA: 0xD693C0 Offset: 0xD679C0 VA: 0x180D693C0
	public void .ctor() { }

}

internal class DateTimeFacetsChecker : FacetsChecker // TypeDefIndex: 2251
{	// Methods

	// RVA: 0x1516440 Offset: 0x1514A40 VA: 0x181516440 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1516010 Offset: 0x1514610 VA: 0x181516010 Slot: 10
	internal override Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1516600 Offset: 0x1514C00 VA: 0x181516600 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x15164C0 Offset: 0x1514AC0 VA: 0x1815164C0
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

	// RVA: 0x1279600 Offset: 0x1277C00 VA: 0x181279600
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1278500 Offset: 0x1276B00 VA: 0x181278500 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1278B90 Offset: 0x1277190 VA: 0x181278B90 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x12789D0 Offset: 0x1276FD0 VA: 0x1812789D0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1278E30 Offset: 0x1277430 VA: 0x181278E30 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1279090 Offset: 0x1277690 VA: 0x181279090 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1279180 Offset: 0x1277780 VA: 0x181279180 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1279450 Offset: 0x1277A50 VA: 0x181279450 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x12792D0 Offset: 0x12778D0 VA: 0x1812792D0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1278EC0 Offset: 0x12774C0 VA: 0x181278EC0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1278DA0 Offset: 0x12773A0 VA: 0x181278DA0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1279140 Offset: 0x1277740 VA: 0x181279140 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1278F40 Offset: 0x1277540 VA: 0x181278F40 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x12793B0 Offset: 0x12779B0 VA: 0x1812793B0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x1279590 Offset: 0x1277B90 VA: 0x181279590
	private static void .cctor() { }

}

internal sealed class DateTimeStorage : DataStorage // TypeDefIndex: 4385
{	// Fields
	private static readonly DateTime s_defaultValue; // 0x0
	private DateTime[] _values; // 0x50

	// Methods

	// RVA: 0x127AB80 Offset: 0x1279180 VA: 0x18127AB80
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1279710 Offset: 0x1277D10 VA: 0x181279710 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1279D40 Offset: 0x1278340 VA: 0x181279D40 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1279BB0 Offset: 0x12781B0 VA: 0x181279BB0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1279FE0 Offset: 0x12785E0 VA: 0x181279FE0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x127A300 Offset: 0x1278900 VA: 0x18127A300 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x127A3E0 Offset: 0x12789E0 VA: 0x18127A3E0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x127A830 Offset: 0x1278E30 VA: 0x18127A830 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x127A500 Offset: 0x1278B00 VA: 0x18127A500 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x127A0C0 Offset: 0x12786C0 VA: 0x18127A0C0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1279EF0 Offset: 0x12784F0 VA: 0x181279EF0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x127A3A0 Offset: 0x12789A0 VA: 0x18127A3A0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x127A170 Offset: 0x1278770 VA: 0x18127A170 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x127A5E0 Offset: 0x1278BE0 VA: 0x18127A5E0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x127AB10 Offset: 0x1279110 VA: 0x18127AB10
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

	// RVA: 0x1802C80 Offset: 0x1801280 VA: 0x181802C80
	private static void .cctor() { }

	// RVA: 0x2113E0 Offset: 0x2107E0 VA: 0x1802113E0
	public bool Parse(char[] text, int startIndex, int length) { }

	// RVA: 0x211370 Offset: 0x210770 VA: 0x180211370
	private bool ParseDate(int start) { }

	// RVA: 0x211380 Offset: 0x210780 VA: 0x180211380
	private bool ParseTimeAndZoneAndWhitespace(int start) { }

	// RVA: 0x2113C0 Offset: 0x2107C0 VA: 0x1802113C0
	private bool ParseTime(ref int start) { }

	// RVA: 0x2113D0 Offset: 0x2107D0 VA: 0x1802113D0
	private bool ParseZone(int start) { }

	// RVA: 0x211310 Offset: 0x210710 VA: 0x180211310
	private bool Parse4Digit(int start, out int num) { }

	// RVA: 0x211300 Offset: 0x210700 VA: 0x180211300
	private bool Parse2Digit(int start, out int num) { }

	// RVA: 0x211320 Offset: 0x210720 VA: 0x180211320
	private bool ParseChar(int start, char ch) { }

}

internal static class DateTimeUtils // TypeDefIndex: 5949
{	// Fields
	internal static readonly long InitialJavaScriptDateTicks; // 0x0
	private static readonly int[] DaysToMonth365; // 0x8
	private static readonly int[] DaysToMonth366; // 0x10

	// Methods

	// RVA: 0x1806470 Offset: 0x1804A70 VA: 0x181806470
	private static void .cctor() { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1803750 Offset: 0x1801D50 VA: 0x181803750
	public static TimeSpan GetUtcOffset(DateTime d) { }

	// RVA: 0x18037C0 Offset: 0x1801DC0 VA: 0x1818037C0
	public static XmlDateTimeSerializationMode ToSerializationMode(DateTimeKind kind) { }

	// RVA: 0x1803390 Offset: 0x1801990 VA: 0x181803390
	internal static DateTime EnsureDateTime(DateTime value, DateTimeZoneHandling timeZone) { }

	// RVA: 0xE5C940 Offset: 0xE5AF40 VA: 0x180E5C940
	private static DateTime SwitchToLocalTime(DateTime value) { }

	// RVA: 0xE5C9B0 Offset: 0xE5AFB0 VA: 0x180E5C9B0
	private static DateTime SwitchToUtcTime(DateTime value) { }

	// RVA: 0x1803970 Offset: 0x1801F70 VA: 0x181803970
	private static long ToUniversalTicks(DateTime dateTime) { }

	// RVA: 0x1803850 Offset: 0x1801E50 VA: 0x181803850
	private static long ToUniversalTicks(DateTime dateTime, TimeSpan offset) { }

	// RVA: 0x1802EB0 Offset: 0x18014B0 VA: 0x181802EB0
	internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, TimeSpan offset) { }

	// RVA: 0x1802F20 Offset: 0x1801520 VA: 0x181802F20
	internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime) { }

	// RVA: 0x1803060 Offset: 0x1801660 VA: 0x181803060
	internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, bool convertToUtc) { }

	// RVA: 0x18055A0 Offset: 0x1803BA0 VA: 0x1818055A0
	private static long UniversialTicksToJavaScriptTicks(long universialTicks) { }

	// RVA: 0x1803180 Offset: 0x1801780 VA: 0x181803180
	internal static DateTime ConvertJavaScriptTicksToDateTime(long javaScriptTicks) { }

	// RVA: 0x1803AF0 Offset: 0x18020F0 VA: 0x181803AF0
	internal static bool TryParseDateTimeIso(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt) { }

	// RVA: 0x1804170 Offset: 0x1802770 VA: 0x181804170
	internal static bool TryParseDateTimeOffsetIso(StringReference text, out DateTimeOffset dt) { }

	// RVA: 0x1803290 Offset: 0x1801890 VA: 0x181803290
	private static DateTime CreateDateTime(DateTimeParser dateTimeParser) { }

	// RVA: 0x1804D60 Offset: 0x1803360 VA: 0x181804D60
	internal static bool TryParseDateTime(StringReference s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) { }

	// RVA: 0x1804AA0 Offset: 0x18030A0 VA: 0x181804AA0
	internal static bool TryParseDateTime(string s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) { }

	// RVA: 0x1804480 Offset: 0x1802A80 VA: 0x181804480
	internal static bool TryParseDateTimeOffset(StringReference s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) { }

	// RVA: 0x18047C0 Offset: 0x1802DC0 VA: 0x1818047C0
	internal static bool TryParseDateTimeOffset(string s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) { }

	// RVA: 0x18050C0 Offset: 0x18036C0 VA: 0x1818050C0
	private static bool TryParseMicrosoftDate(StringReference text, out long ticks, out TimeSpan offset, out DateTimeKind kind) { }

	// RVA: 0x1803F40 Offset: 0x1802540 VA: 0x181803F40
	private static bool TryParseDateTimeMicrosoft(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt) { }

	// RVA: 0x1803A00 Offset: 0x1802000 VA: 0x181803A00
	private static bool TryParseDateTimeExact(string text, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) { }

	// RVA: 0x1804320 Offset: 0x1802920 VA: 0x181804320
	private static bool TryParseDateTimeOffsetMicrosoft(StringReference text, out DateTimeOffset dt) { }

	// RVA: 0x18040B0 Offset: 0x18026B0 VA: 0x1818040B0
	private static bool TryParseDateTimeOffsetExact(string text, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) { }

	// RVA: 0x1805410 Offset: 0x1803A10 VA: 0x181805410
	private static bool TryReadOffset(StringReference offsetText, int startIndex, out TimeSpan offset) { }

	// RVA: 0x18059D0 Offset: 0x1803FD0 VA: 0x1818059D0
	internal static void WriteDateTimeString(TextWriter writer, DateTime value, DateFormatHandling format, string formatString, CultureInfo culture) { }

	// RVA: 0x1805B40 Offset: 0x1804140 VA: 0x181805B40
	internal static int WriteDateTimeString(char[] chars, int start, DateTime value, Nullable<TimeSpan> offset, DateTimeKind kind, DateFormatHandling format) { }

	// RVA: 0x1805F10 Offset: 0x1804510 VA: 0x181805F10
	internal static int WriteDefaultIsoDate(char[] chars, int start, DateTime dt) { }

	// RVA: 0x1803210 Offset: 0x1801810 VA: 0x181803210
	private static void CopyIntToCharArray(char[] chars, int start, int value, int digits) { }

	// RVA: 0x18057A0 Offset: 0x1803DA0 VA: 0x1818057A0
	internal static int WriteDateTimeOffset(char[] chars, int start, TimeSpan offset, DateFormatHandling format) { }

	// RVA: 0x1805620 Offset: 0x1803C20 VA: 0x181805620
	internal static void WriteDateTimeOffsetString(TextWriter writer, DateTimeOffset value, DateFormatHandling format, string formatString, CultureInfo culture) { }

	// RVA: 0x1803560 Offset: 0x1801B60 VA: 0x181803560
	private static void GetDateValues(DateTime td, out int year, out int month, out int day) { }

}

public abstract class DateTimeConverterBase : JsonConverter // TypeDefIndex: 6101
{	// Methods

	// RVA: 0xF88730 Offset: 0xF86D30 VA: 0x180F88730 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

